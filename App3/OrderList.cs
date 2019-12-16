using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
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
    public class OrderList : BaseActivity
    {
        private Android.Widget.Toolbar toolbar;
        private RecyclerView recyclerView;
        private RecyclerViewAdapter adapter;
        private string itcode;//当前选择得工程师
        private string user;//客户名称
        private string phone;//客户手机号
        private List<Model.SalesOrderDetails> salesOrderDetails;
        private DatabaseTXT OR;
        Spinner spinnerGroup;
        List<Orgnization> engineerGroup;
        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //Loding 加载层
            UserDialogs.Init(this);
            //Java.Lang.Class.FromType(typeof(componet))
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.OrderList);
            CreateScan();
            var ORjson = ReadTXT();
            OR = JsonConvert.DeserializeObject<DatabaseTXT>(ORjson);

            #region
            var ordersjson = Intent.GetStringExtra("obj");
            //if (string.IsNullOrWhiteSpace(ordersjson))  orderQuantity
            //    Close();
            //List<string> data = new List<string>() { "科比", "加内特", "麦迪", "费舍尔", "杰梅因奥尼尔", "大Z", "纳什", "雷阿伦", "马布里", "艾弗森", "安东尼沃克" };
            salesOrderDetails = JsonConvert.DeserializeObject<List<Model.SalesOrderDetails>>(ordersjson);
            var quantity=FindViewById<TextView>(Resource.Id.orderQuantity);
            quantity.Text = "数量："+ salesOrderDetails.Count;
            var price = FindViewById<TextView>(Resource.Id.orderPrice);
            price.Text = "金额：" + salesOrderDetails.Sum(f=>f.Money);
            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            adapter = new RecyclerViewAdapter(salesOrderDetails, this);
            recyclerView.SetLayoutManager(new LinearLayoutManager(this));
            recyclerView.AddItemDecoration(new MyItemDecoration(this, (int)Orientation.Vertical));
            recyclerView.SetAdapter(adapter);
            #endregion
            #region GetUser放在同步方法中出现了异常  butgroup
            var task =Task.Run(()=> {
                var typesSpinner = FindViewById<Spinner>(Resource.Id.butengineer);
                List<Model.Engineer> engineers = GetUser().Result;
                typesSpinner.Adapter = new OrderAdapter(this, engineers);
                typesSpinner.ItemSelected += typesSpinner_ItemSelected;
                //-----------------------------------------
                spinnerGroup = FindViewById<Spinner>(Resource.Id.butgroup);
                engineerGroup = GetGroup(OR.InvoiceCode).Result;
                spinnerGroup.Adapter = new SetUpTheAdapterG(this, engineerGroup);
                //spinnerGroup.SetSelection(1);
                spinnerGroup.ItemSelected += Group_ItemSelected;
            });
            task.Wait();
            
            #endregion

            //
            Button btnOrderScan = this.FindControl<Button>("credateOrderScan");//扫码支付
            btnOrderScan.Click += (s, e) =>
            {
                _scanType = 1;
                _orderType = 1;
                Task t = new Task(CredateOrder);
                t.Start();
            };
            Button btnOrderUnion = this.FindControl<Button>("credateOrderUnion");//扫码支付
            btnOrderUnion.Click += (s, e) =>
            {
                _scanType = 1;
                _orderType = 0;
                Task t = new Task(CredateOrder);
                t.Start();
            };
            Button butmember = this.FindControl<Button>("butmember");//会员
            butmember.Click += (s, e) =>
            {
                Task.Run(AutoScan);
            };
            base.OnCreate(savedInstanceState);
        }
        private void typesSpinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            var toast = spinner.GetItemAtPosition(e.Position);
            var engineer = toast.Cast<Model.Engineer>();
            itcode = engineer.Account;
            for (int i = 0; i < engineerGroup.Count; i++)
            {
                if (engineer.ORCode == engineerGroup[i].OrgnizationNumber)
                {
                    spinnerGroup.SetSelection(i);
                }
            }
       
            //Toast.MakeText(this, toast.ToString(), ToastLength.Long).Show();
        }
        private void Group_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            var toast = spinner.GetItemAtPosition(e.Position);
            var model = toast.Cast<Model.Orgnization>();
            OR.GroupID = model.tb_Orgnization_Id;
            OR.GroupCode = model.OrgnizationNumber;
            OR.GroupName = model.OrgnizationName;
            ShowToast(model.OrgnizationName);
        }
        private async Task<List<Model.Orgnization>> GetGroup(string orgnizationNumber)
        {
            try
            {
                var result = await Get(url + "/api/Orgnization/GetGroup?OrgnizationNumber=" + orgnizationNumber, "");//token.Token
                var _engineerInfo = ByteToModel<Model.OrgnizationInfo>(result);
                return _engineerInfo.Data;
            }
            catch (Exception ex)
            {
                return new List<Model.Orgnization>();
            }
        }
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                ShowActivity<MainActivity>();
            }
            return true;
        }
        private async Task<List<Model.Engineer>> GetUser()
        {
            try
            {
                var result =await Get(url + "/api/Orgnization/GetOrUser?OrgnizationNumber=" + OR.InvoiceCode, "");//token.Token
                var _engineerInfo = ByteToModel<Model.EngineerInfo>(result);
                return _engineerInfo.Data;
            }
            catch (Exception ex)
            {
                return new List<Model.Engineer>();
            }

        }
        private string orderSO;
        /// <summary>
        /// 页面得click事件  直接标注方法名
        /// </summary>
        /// <param name="v"></param>
        public void CredateOrder()
        {
            createFloatView();
            if (!string.IsNullOrWhiteSpace(orderSO))
            {
                ManageSO(orderSO);
                return;
            }
            EditText customerName = FindViewById<EditText>(Resource.Id.customerName);
            EditText customerPhone = FindViewById<EditText>(Resource.Id.customerPhone);
            var phone = customerPhone.Text;
            var name = customerName.Text;
            string address = url + "/api/SalesOrder/AddSalesOrderNew";
            #region 创建销售单json
            try
            {
                var time = DateTime.Now;
                MSalesViews mSalesViews = new MSalesViews();
                mSalesViews.sysKey = SYSKEY;
                #region MSalesOrder
                MSalesOrder mSalesOrder = new MSalesOrder();
                mSalesOrder.CreateDate = time;
                mSalesOrder.InvoiceOrgCode = OR.InvoiceCode;//开票站  SaleOrgCode
                mSalesOrder.InvoiceOrgCode_Id = OR.InvoiceID;
                mSalesOrder.InvoiceOrgName = OR.InvoiceName;
                mSalesOrder.SaleOrg_Id = OR.GroupID;//业务组
                mSalesOrder.SaleOrgCode = OR.GroupCode;
                mSalesOrder.SaleOrgName = OR.GroupName;
                mSalesOrder.CustomerType = "正常销售";
                mSalesOrder.CustomerName = name;
                mSalesOrder.CustomerNumber = "";
                mSalesOrder.MobileNo = phone;
                mSalesOrder.ServiceType = "1";
                mSalesOrder.GroupName = OR.GroupName;//业务组
                mSalesOrder.GroupOrgCode = OR.GroupCode;
                mSalesOrder.GroupOrgId = OR.GroupID;
                mSalesOrder.Creator = itcode;
                mSalesOrder.CreateDate = time;
                #endregion
                #region LMSalesOrderDetail
                List<MSalesOrderDetail> mSalesOrderDetails = new List<MSalesOrderDetail>();
                var count = salesOrderDetails.GroupBy(f => f.Code).Count();
                for (int i = 0; i < count; i++)
                {
                    var code = salesOrderDetails[i].Code;
                    var price = salesOrderDetails[i].Money;
                    var ct = salesOrderDetails.Count(f => f.Code == code);
                    MSalesOrderDetail mSalesOrderDetail = new MSalesOrderDetail();
                    mSalesOrderDetail.SaleBy = itcode;
                    mSalesOrderDetail.Amount = ct * price;
                    mSalesOrderDetail.SaleDate = time;
                    mSalesOrderDetail.ActiveFlg = 1;
                    mSalesOrderDetail.SaleType = 0;
                    mSalesOrderDetail.MaterialCode = code;
                    mSalesOrderDetail.SaleQnty = ct;
                    mSalesOrderDetail.SalePrice = price;
                    mSalesOrderDetail.IsService = 0;
                    mSalesOrderDetail.Creator = itcode;
                    mSalesOrderDetail.CreateDate = time;
                    mSalesOrderDetails.Add(mSalesOrderDetail);
                }
                #endregion
                #region MSalesSubOrder
                MSalesSubOrder mSalesSubOrder = new MSalesSubOrder();
                mSalesSubOrder.SaleBy = itcode;
                mSalesSubOrder.SaleDate = time;
                mSalesSubOrder.OnlinePay = 0;
                mSalesSubOrder.Creator = itcode;
                mSalesSubOrder.CreateDate = time;
                mSalesSubOrder.FromType = 7;
                #endregion
                #region MSalesOutDetail
                List<MSalesOutDetail> mSalesOutDetails = new List<MSalesOutDetail>();
                foreach (var item in salesOrderDetails)
                {
                    MSalesOutDetail mSalesOutDetail = new MSalesOutDetail();
                    mSalesOutDetail.MaterialBarCode = item.Barcode;
                    mSalesOutDetail.CreateDate = time;
                    mSalesOutDetail.Creator = "posapp";
                    mSalesOutDetail.SignCode = item.CodeID;
                    mSalesOutDetails.Add(mSalesOutDetail);
                }
                #endregion
                mSalesViews.LMSalesOrderDetail = mSalesOrderDetails;
                mSalesViews.MSalesOrder = mSalesOrder;
                mSalesViews.MSalesSubOrder = mSalesSubOrder;
                mSalesViews.MSalesOutDetail = mSalesOutDetails;
                #endregion

                var result = Post<MSalesViews>(address, mSalesViews).Result;
                if (string.IsNullOrWhiteSpace(result))
                {
                    CloseFloatWindow();
                    this.RunOnUi(() =>
                    {
                        ShowToast("创建销售单失败，联系管理员");
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
                    orderSO = orderNO;
                    Task.Run(()=> {
                        ManageSO(orderNO);
                    });
                }
                catch (Exception ex)
                {
                    CloseFloatWindow();
                    SendLog("创建销售单失败,出现异常：" + ex.Message);
                    this.RunOnUi(() =>
                    {
                        ShowToast("创建销售单失败，联系管理员");
                    });
                    return;
                }
            }
            catch (Exception ex)
            {
                SendLog("创建销售单出现错误，可能是设置错误，异常："+ex.Message);
                this.RunOnUi(() =>
                {
                    ShowToast("设置信息发生异常，重新设置或联系管理员");
                });
                return;
            }
           
 
        }

        #region 调取接口回调
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
        #endregion
        #region 会员
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
            SendLog("进入扫描回调HandleScanResultAsync！&时间=" + DateTime.Now.ToString());
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
                    RunOnUi(() => {
                        var cusName = FindViewById<EditText>(Resource.Id.customerName);
                        cusName.Text = resulr.Data.CustomerName;
                        var cusPhone = FindViewById<EditText>(Resource.Id.customerPhone);
                        cusPhone.Text = resulr.Data.CustomerPhone;
                    });
                }
            }
            else
            {
                this.RunOnUi(this.CloseFloatWindow);
                this.RunOnUi(() => { this.ShowToast("扫描取消"); });
            }
        }
        #endregion
    }
}