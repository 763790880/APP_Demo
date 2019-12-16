using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using App3.Comment;
using App3.Model;
using Newtonsoft.Json;
using ZXing.Mobile;

namespace App3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class CashReceiptsActivity : BaseActivity
    {
        private string itcode;
        private string REcode;
        EditText cusPhone;
        EditText cusName;
        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //Loding 加载层
            UserDialogs.Init(this);
            //Java.Lang.Class.FromType(typeof(componet))
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.CashReceipts);
            #region GetUser放在同步方法中出现了异常
            var task = Task.Run(() =>
            {
                var typesSpinner = FindViewById<Spinner>(Resource.Id.butengineer);
                List<Model.Engineer> engineers = GetUser().Result;
                typesSpinner.Adapter = new OrderAdapter(this, engineers);
                typesSpinner.ItemSelected += typesSpinner_ItemSelected;
            });
            task.Wait();
            #endregion
            CreateScan();

            cusPhone = FindViewById<EditText>(Resource.Id.customerPhone);
            cusName = FindViewById<EditText>(Resource.Id.customerName);

            Button btnOrderScan = this.FindControl<Button>("credateOrderScan");//扫码支付
            btnOrderScan.Click += (s, e) =>
            {
                _scanType = 1;
                _orderType = 1;
                Task.Run(CredateOrder);
            };
            Button btnOrderUnion = this.FindControl<Button>("credateOrderUnion");//刷卡支付
            btnOrderUnion.Click += (s, e) =>
            {
                _scanType = 1;
                _orderType = 0;
                Task.Run(CredateOrder);
            };
            Button butmember = this.FindControl<Button>("butmember");//会员
            butmember.Click += (s, e) =>
            {
                Task.Run(AutoScan);
            };
            base.OnCreate(savedInstanceState);
        }
        /// <summary>
        /// 页面得click事件  直接标注方法名
        /// </summary>
        /// <param name="v"></param>
        public void CredateOrder()
        {
            createFloatView();
            if (!string.IsNullOrWhiteSpace(REcode))
            {
                Task.Run(() =>
                {
                    ManageRE(REcode);
                });
            }
            else
            {
                EditText customerName = FindViewById<EditText>(Resource.Id.customerName);
                EditText customerPhone = FindViewById<EditText>(Resource.Id.customerPhone);
                EditText receiptPrice = FindViewById<EditText>(Resource.Id.receiptPrice);
                var phone = customerPhone.Text;
                var name = customerName.Text;
                var price = receiptPrice.Text;
                string address = url + "/api/SaleReceipt/SavePOSReceipt";
                #region 创建资金收据json
                try
                {
                    var ORjson = ReadTXT();
                    var OR = JsonConvert.DeserializeObject<DatabaseTXT>(ORjson);
                    var time = DateTime.Now;
                    CashReceipts cashReceipts = new CashReceipts();
                    address += "?SysKey=" + SYSKEY;
                    cashReceipts.SysKey = SYSKEY;
                    address += "&ITcode=" + itcode;
                    cashReceipts.ITcode = itcode;
                    address += "&Phone=" + phone;
                    cashReceipts.Phone = phone;
                    address += "&CustomerName=" + name;
                    cashReceipts.CustomerName = name;
                    address += "&ReceiptAmount=" + Convert.ToDecimal(price);
                    cashReceipts.ReceiptAmount = Convert.ToDecimal(price);
                    address += "&Orgnization_Id=" + OR.InvoiceID;
                    cashReceipts.Orgnization_Id = OR.InvoiceID;
                    #endregion

                    var result = Post<CashReceipts>(address, cashReceipts).Result;
                    if (string.IsNullOrWhiteSpace(result))
                    {
                        CloseFloatWindow();
                        this.RunOnUi(() =>
                        {
                            ShowToast("创建资金收据失败，联系管理员");
                        });
                        return;
                    }
                    try
                    {
                        OrderNOInfo orderNOInfo = JsonConvert.DeserializeObject<OrderNOInfo>(result);
                        if (orderNOInfo.ResultCode != 1)
                        {
                            CloseFloatWindow();
                            this.RunOnUi(() =>
                            {
                                ShowToast(orderNOInfo.ResultMess);
                            });
                            return;
                        }
                        var orderNO = orderNOInfo.Data;
                        REcode = orderNO;
                        Task.Run(() =>
                        {
                            ManageRE(orderNO);
                        });
                    }
                    catch (Exception ex)
                    {
                        CloseFloatWindow();
                        SendLog("创建资金收据失败,出现异常：" + ex.Message);
                        this.RunOnUi(() =>
                        {
                            ShowToast("创建资金收据失败，联系管理员");
                        });
                        return;
                    }
                }
                catch (Exception ex)
                {
                    SendLog("创建资金收据出现错误，可能是设置错误，异常：" + ex.Message);
                    this.RunOnUi(() =>
                    {
                        ShowToast("设置信息发生异常，重新设置或联系管理员");
                    });
                    return;
                }
            }

        }
        private async Task<List<Model.Engineer>> GetUser()
        {
            try
            {
                var ORjson = ReadTXT();
                var model = JsonConvert.DeserializeObject<DatabaseTXT>(ORjson);
                var OrgnizationNumber = model.InvoiceCode;
                var result = await Get(url + "/api/Orgnization/GetOrUser?OrgnizationNumber=" + OrgnizationNumber, "");//token.Token
                var _engineerInfo = ByteToModel<Model.EngineerInfo>(result);
                return _engineerInfo.Data;
            }
            catch (Exception ex)
            {
                return new List<Model.Engineer>();
            }

        }
        private void typesSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            var toast = spinner.GetItemAtPosition(e.Position);
            itcode = toast.ToString();
            //Toast.MakeText(this, toast.ToString(), ToastLength.Long).Show();
        }
        /// <summary>
        /// 支付成功/失败
        /// </summary>
        /// <param name="requestCode">1.支付,2.退款</param>
        /// <param name="resultCode"></param>
        /// <param name="data"></param>
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            try
            {
                SendLog("订单号：" + mhtOrderNo + "进入OnActivityResult回调，支付结果为：" + (int)resultCode + "&时间=" + DateTime.Now.ToString() + "&类型=" + requestCode);
                base.OnActivityResult(requestCode, resultCode, data);
                Bundle bundle = data.Extras;
                var reason = bundle.GetString("reason");
                SendLog("订单号：" + mhtOrderNo + "获取到参数，reason：" + reason);
                var pay_tp = bundle.GetString("pay_tp");
                SendLog("订单号：" + mhtOrderNo + "获取到参数，pay_tp：" + pay_tp);
                SendLog("准备进入switch分支   requestCode：" + requestCode + "&时间=" + DateTime.Now.ToString());
                switch (requestCode)
                {
                    ///支付
                    case 1:
                        SendLog("准备进入ActivityPay" + DateTime.Now.ToString());
                        var refernumber = bundle.GetString("refernumber");
                        ActivityPay(resultCode, pay_tp, reason, refernumber);
                        break;
                    //退款
                    case 2:
                        SendLog("准备进入ActivityRefundAsync" + DateTime.Now.ToString());
                        ActivityRefundAsync(resultCode, pay_tp, reason);
                        break;
                    //结算
                    case 3:
                        break;
                    //扫码打印
                    case 4:
                        CloseFloatWindow();
                        break;
                    default: break;
                }
            }
            catch (Exception ex)
            {
                SendLog("接口回调方法出现异常！" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("接口回调出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

        }

        protected View zxingOverlay;
        protected MobileBarcodeScanner scanner;
        protected MobileBarcodeScanningOptions mbs;
        protected ImageView ivScanning;
        // 从上到下的平移动画
        protected Animation verticalAnimation;
        /// <summary>
        /// 创建扫描对象
        /// </summary>
        public void CreateScan()
        {
            try
            {
                scanner = new MobileBarcodeScanner();
                zxingOverlay = LayoutInflater.FromContext(this).Inflate(Resource.Layout.ZxingOverlay, null);
                scanner.UseCustomOverlay = false;
                zxingOverlay.Measure(MeasureSpecMode.Unspecified.GetHashCode(), MeasureSpecMode.Unspecified.GetHashCode());
                scanner.CustomOverlay = zxingOverlay;
                //Button btnCancelScan = zxingOverlay.FindViewById<Button>(Resource.Id.btnCancelScan);//取消扫描
                //btnCancelScan.Click += (s, e) =>
                //{
                //    if (scanner != null)
                //    {
                //        scanner.Cancel();
                //    }
                //};
                //<Button
                //android: id = "@+id/btnCancelScan"
                //android: textAppearance = "?android:textAppearanceMedium"
                //android: layout_width = "fill_parent"
                //android: layout_height = "wrap_content"
                //android: text = "取消扫描"
                //android: textColor = "#ffffffff"
                //android: background = "#aa000000"
                //android: gravity = "center" />



                mbs = MobileBarcodeScanningOptions.Default;
                mbs.AssumeGS1 = true;
                mbs.AutoRotate = true;
                mbs.DisableAutofocus = false;
                mbs.PureBarcode = false;
                mbs.TryInverted = true;
                mbs.TryHarder = true;
                mbs.UseCode39ExtendedMode = true;
                mbs.UseFrontCameraIfAvailable = false;
                mbs.UseNativeScanning = true;

                ivScanning = zxingOverlay.FindViewById<ImageView>(Resource.Id.ivScanning);
                // 从上到下的平移动画
                verticalAnimation = new TranslateAnimation(0, 0, 0, 800)
                {
                    Duration = 3000, // 动画持续时间
                    RepeatCount = Animation.Infinite // 无限循环
                };
            }
            catch (Exception ex)
            {
                SendLog("创建扫描对象出现异常" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("创建扫描对象出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

        }
        /// <summary>
        /// 扫描动画
        /// </summary>
        public void AutoScan()
        {
            try
            {
                verticalAnimation.StartNow();
                // 播放动画
                ivScanning.Animation = verticalAnimation;
                scanner.AutoFocus();
                var result = scanner.Scan(this, mbs).Result;
                DisplayCamera().Wait();
                GiveVal(result);
            }
            catch (Exception ex)
            {
                SendLog("扫描对象出现异常" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("扫描对象出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

        }
        public async Task GiveVal(ZXing.Result result)
        {
            if (result != null && !string.IsNullOrEmpty(result.Text))
            {
                //var member = new GetData().GetMember(result.Text);
                var model = Get(url + "/api/Customer/GetMemberInfoByServiceCardNo?ServiceCardNo=" + result.Text, "").Result;
                var resulr = JsonConvert.DeserializeObject<MemberInfo>(model);
                if (resulr.ResultCode != 1)
                {
                    this.RunOnUi(() => { this.ShowToast(resulr.ResultMess); });
                    return ;
                }
                if (resulr.Data != null)
                {
                    RunOnUi(()=> {
                        
                        cusName.SetText(resulr.Data.CustomerName,TextView.BufferType.Editable);
                       
                        cusPhone.SetText(resulr.Data.CustomerPhone, TextView.BufferType.Editable);
                        //cusPhone.Text = resulr.Data.CustomerPhone;
                        var receiptPrice = FindViewById<EditText>(Resource.Id.receiptPrice);
                        receiptPrice.Focusable = true;
                        receiptPrice.RequestFocus();
                    });
                }

            }
            else
            {
                this.RunOnUi(this.CloseFloatWindow);
                this.RunOnUi(() => { this.ShowToast("扫描取消"); });
            }
        }
    }
}