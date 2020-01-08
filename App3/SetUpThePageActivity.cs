using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
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
using App3.Model;
using Newtonsoft.Json;
using ZXing.Mobile;

namespace App3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class SetUpThePageActivity : BaseActivity
    {
        #region 全局标量 
        protected View zxingOverlay;
        protected MobileBarcodeScanner scanner;
        protected MobileBarcodeScanningOptions mbs;
        protected ImageView ivScanning;
        // 从上到下的平移动画
        protected Animation verticalAnimation;
        //当前订单号集合
        private List<string> orders = new List<string>();
        #endregion
        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //Loding 加载层
            UserDialogs.Init(this);
            //加载
            createFloatView();
            base.OnCreate(savedInstanceState);
            //Java.Lang.Class.FromType(typeof(componet))
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.SetUpThePage);
            //创建扫描层
            CreateScan();
            //事件绑定
            Bind();
            //加载完毕
            CloseFloatWindow();


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
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
                string txndetail = bundle.GetString("txndetail");
                if (!string.IsNullOrWhiteSpace(txndetail))
                {
                    var mmodel = Analysis(txndetail).Result;
                    CheckOrganization(mmodel.merid, mmodel.termid);
                }
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
                        SendLog("准备进入ActivitySettlement");
                        ActivitySettlement(reason);
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
        #region 扫描获取订单
        /// <summary>
        /// 扫描动画
        /// </summary>
        public void AutoScan()
        {
            try
            {
                if (!IsFirst)
                {
                    var vb = CheckVersion();
                    if (!vb)
                    {
                        this.RunOnUi(() => { this.ShowAlert("当前版本需要升级", false); });
                        return;
                    }
                    else
                        IsFirst = true;
                }
                verticalAnimation.StartNow();
                // 播放动画
                ivScanning.Animation = verticalAnimation;
                var result = scanner.Scan(this, mbs).Result;
                DisplayCamera().Wait();
                HandleScanResultAsync(result);
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
        /// <summary>
        /// 创建扫描对象
        /// </summary>
        public void CreateScan()
        {
            try
            {
                scanner = new MobileBarcodeScanner();
                zxingOverlay = LayoutInflater.FromContext(this).Inflate(Resource.Layout.ZxingOverlay, null);
                scanner.UseCustomOverlay = true;
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
        /// 扫描回调
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        async Task HandleScanResultAsync(ZXing.Result result)
        {
            try
            {
                SendLog("进入扫描回调HandleScanResultAsync！&时间=" + DateTime.Now.ToString());
                if (result != null && !string.IsNullOrEmpty(result.Text))
                {
                    if (result.Text != null && result.Text.Trim().Length > 5)
                    {
                        SendLog("HandleScanResultAsync扫描结果！Text=" + result.Text + "&时间=" + DateTime.Now.ToString());
                        //截取销售单号
                        var saleOrder = ParsingSaleOrder(result.Text);

                        if (string.IsNullOrWhiteSpace(saleOrder))
                        {
                            this.RunOnUi(() => { this.ShowAlert("没有发现订单号", false); });
                        }
                        //SO单号处理
                        else if (saleOrder.Contains("SO"))
                        {
                            ManageSO(saleOrder);
                        }
                        //RE单号处理
                        else if (saleOrder.Contains("RE"))
                        {
                            ManageRE(saleOrder);
                        }
                        else
                        {
                            this.RunOnUi(() => { this.ShowToast("未识别"); });
                        }
                    }
                    else
                    {

                        this.RunOnUi(() => { this.ShowToast("扫描无数据"); });
                        //new Java.Lang.String("扫描无数据");
                    }

                }
                else
                {
                    this.RunOnUi(this.CloseFloatWindow);
                    //this.RunOnUi(() => { this.ShowToast("扫描取消"); });
                    //new Java.Lang.String("扫描取消");
                }
            }
            catch (Exception ex)
            {

                SendLog("扫描回调出现异常！" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("扫描回调出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

            //CloseFloatWindow();
        }

        /// <summary>
        /// 截取销售子单号
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string ParsingSaleOrder(string url)
        {
            try
            {
                SendLog("开始截取地址中得销售单号！url:" + url + "&时间=" + DateTime.Now.ToString());
                int IndexofA = url.IndexOf("oid=");
                int IndexofB = url.IndexOf("&", IndexofA);
                var saleOrder = url.Substring(IndexofA + 4, IndexofB - IndexofA - 4);
                SendLog("截取销售单号结束！截取结果为:" + saleOrder + "&时间=" + DateTime.Now.ToString());
                return saleOrder;
            }
            catch (Exception ex)
            {
                SendLog("截取销售单号中发现异常！Exception:" + ex.Message + "&时间=" + DateTime.Now.ToString());
                return "";
            }

        }
        #endregion
        #region 系统
        /// <summary>
        /// 按钮事件绑定
        /// </summary>
        public void Bind()
        {
            TextView textPrompt = zxingOverlay.FindViewById<TextView>(Resource.Id.textPrompt);
            Button btnScan = this.FindViewById<Button>(Resource.Id.btnScan);
            btnScan.Click += (s, e) =>
            {
                //var str = ReadTXT();
                //this.ShowToast(str);
                //var ddd=systemInf.SerialNo;
                //InvokeRemoteService();
                createFloatView();
                textPrompt.Text = "微信/支付宝支付，请将销售订单二维码放入框内";
                _orderType = 1;//支付类型
                _scanType = 1;//扫描类型
                Task t = new Task(AutoScan);
                t.Start();
            };
            Button btnRefund = this.FindControl<Button>("btnRefund");//退款
            btnRefund.Click += (s, e) =>
            {
                createFloatView();
                textPrompt.Text = "退款扫描，请将销售订单二维码放入框内";
                _scanType = 2;//扫描类型
                //AutoScan();
                Task t = new Task(AutoScan);
                t.Start();
            };
            Button btnSettlement = this.FindViewById<Button>(Resource.Id.btnSettlement);//结算
            btnSettlement.Click += (s, e) =>
            {
                //OpenOrder();
                _scanType = 3;//扫描类型
                //UserDialogs.Instance.Alert("您确认开始结算吗？","","确认");
                this.RunOnUi(() =>
                {
                    this.ShowAlert("您确认开始结算吗？", true, (d) =>
                    {
                        Settlement(1);
                    });
                });

            };
            Button button1 = this.FindViewById<Button>(Resource.Id.btnSetUpThe);//设置
            button1.Click += (s, e) =>
            {
                createFloatView();
                //var json = ReadTXT();
                //if(string.IsNullOrWhiteSpace(json))
                ShowActivity<SetUpTheActivity>();
                //else
                //    this.RunOnUi(() =>
                //    {
                //        this.ShowAlert("您已经设置过，无需再次设置", false, (d) =>
                //        {
                //            Close();
                //        });
                //    });
            };
        }
        /// <summary>
        /// 获取当前APP版本号
        /// </summary>
        /// <returns></returns>
        public string GetVersion()
        {
            try
            {
                return this.PackageManager.GetPackageInfo(this.PackageName, 0).VersionName;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        /// <summary>
        /// 监听返回键 一次关闭弹层  二次关闭软件
        /// </summary>
        /// <returns></returns>
        DateTime? lastBackKeyDownTime;
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                ShowActivity<MainActivity>();
            }
            return base.OnKeyDown(keyCode, e);
        }
        /// <summary>
        /// 对比当前版本号
        /// </summary>
        /// <returns></returns>
        public bool CheckVersion()
        {
            var version = GetVersion();
            var result = Get(url + "/api/Token/GetVersion?version=" + version, "");
            if (result.Result == "true")
                return true;
            else
                return false;
        }
        #endregion
        #region 结算
        /// <summary>
        /// 结算
        /// </summary>
        /// <param name="salesOrder"></param>
        public void Settlement(int _type)
        {
            try
            {
                SendLog("开始结算!&时间=" + DateTime.Now.ToString());
                if (_type != 0 && _type != 1)
                {
                    this.ShowAlert("结算类型错误");
                    return;
                }

                Intent intent = new Intent();
                intent.SetComponent(componet);
                Bundle bundle = new Bundle();
                bundle.PutString("msg_tp", "0200");
                bundle.PutString("pay_tp", "" + _type);
                bundle.PutString("proc_tp", "00");
                bundle.PutString("proc_cd", "900000");//扫码支付660000  //银联支付 000000  //交易处理码需要与支付方式联动
                bundle.PutString("return_type", "1");//打单页面是否自动关闭
                bundle.PutString("appid", "com.companyname.sunits.pay");
                bundle.PutString("time_stamp", DateTime.Now.ToString("yyyyMMddhhmmss"));
                SendLog("准备进入结算接口：bundle" + JsonConvert.SerializeObject(bundle) + "&时间=" + DateTime.Now.ToString());
                intent.PutExtras(bundle);
                this.StartActivityForResult(intent, 3);
            }
            catch (Exception ex)
            {
                SendLog("结算出现异常！" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("结算出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }
        }
        /// <summary>
        /// 结算回调
        /// </summary>
        /// <param name="reason"></param>
        public void ActivitySettlement(string reason)
        {

            if (reason != null)
            {
                // TODO: 
                this.ShowAlert("结算失败!!" + reason);
            }

        }
        #endregion
        #region 身份识别-模拟请求  获取商户号
        public void Authentication()
        {
            try
            {
                SendLog("开始查询余额!&时间=" + DateTime.Now.ToString());
                Intent intent = new Intent();
                intent.SetComponent(componet);
                Bundle bundle = new Bundle();
                bundle.PutString("msg_tp", "0300");
                bundle.PutString("pay_tp", "0");
                bundle.PutString("proc_cd", "030000");
                bundle.PutString("appid", "com.companyname.sunits.pay");
                SendLog("准备进入查询接口：bundle" + JsonConvert.SerializeObject(bundle) + "&时间=" + DateTime.Now.ToString());
                intent.PutExtras(bundle);
                this.StartActivityForResult(intent, 4);
            }
            catch (Exception ex)
            {
                SendLog("查询余额出现异常！" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("身份验证出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }
        }
        async Task SaveUser(string merid)
        {
            Model.DatabaseTXT databaseTXT = new Model.DatabaseTXT();
            string json = await Get(url + "", "");
            var model=JsonConvert.DeserializeObject<DatabaseTXT>(json);
            model.Merid = merid;
            var txt=JsonConvert.SerializeObject(model);
            var b = CreateTXT(txt);
            if (b)
            {
                this.RunOnUi(() =>
                {
                    //ShowToast("设置成功");
                    ShowActivity<MainActivity>();
                });

            }
            else
            {
                this.RunOnUi(() =>
                {
                    ShowToast("设置失败");
                });
            }
        }
        #endregion
    }
}