using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using ZXing.Mobile;
using Android.Content;
using Android.Views.Animations;
using Animation = Android.Views.Animations.Animation;
using System;
using System.Threading.Tasks;
using App3.Model;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Acr.UserDialogs;
using Android.Content.PM;

namespace App3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : BaseActivity //AppCompatActivity  之前引用
    {

        #region 全局标量 
        protected static View zxingOverlay;
        protected static MobileBarcodeScanner scanner;
        protected static SalesOrder _salesOrder;//当前订单
        protected static int _orderType;//当前支付类型 1扫码 0银联
        protected static int _orderRefundType;//当前退款类型 1扫码 2银联
        protected static int _scanType;//当前扫描类型 1.支付  2退款 3结算
        protected static MobileBarcodeScanningOptions mbs;
        protected static ImageView ivScanning;
        // 从上到下的平移动画
        protected static Animation verticalAnimation;
        //支付金额
        protected static decimal mhtOrderAmt;
        //支付订单号
        protected static string mhtOrderNo;
        //当前单号类型：1-SO：2-RE
        protected static string mOrderType;
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
            SetContentView(Resource.Layout.activity_main);
            //创建扫描层
            CreateScan();
            //socket通讯
            //Task star = new Task(StartClient);
            //star.Start();
            //事件绑定
            Bind();
            //加载完毕
            CloseFloatWindow();
            PackageManager pm = this.PackageManager;
            //var bol = BindRemoteService();
            //if (!bol)
            //    Close();


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
                zxingOverlay.Measure(MeasureSpecMode.Unspecified.GetHashCode(), MeasureSpecMode.Unspecified.GetHashCode());
                scanner.CustomOverlay = zxingOverlay;


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
            Button btnScan = this.FindControl<Button>("btnScan");
            btnScan.Click += (s, e) =>
            {
                var str = ReadTXT();
                this.ShowToast(str);
                //var ddd=systemInf.SerialNo;
                //InvokeRemoteService();
                createFloatView();
                textPrompt.Text = "微信/支付宝支付，请将销售订单二维码放入框内";
                _orderType = 1;//支付类型
                _scanType = 1;//扫描类型
                Task t = new Task(AutoScan);
                t.Start();
            };
            Button btnHttp = this.FindControl<Button>("btnUnion");
            btnHttp.Click += (s, e) =>
            {
                createFloatView();
                textPrompt.Text = "银行卡支付，请将销售订单二维码放入框内";
                _orderType = 0;//支付类型
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
            Button btnSettlement = this.FindControl<Button>("btnSettlement");//结算
            btnSettlement.Click += (s, e) =>
            {
                ShowActivity<View1>();
                //CreateTXT("我是设置得值其中包含了很多得数据");
                //_scanType = 3;//扫描类型
                ////UserDialogs.Instance.Alert("您确认开始结算吗？","","确认");
                //this.RunOnUi(() =>
                //{
                //    this.ShowAlert("您确认开始结算吗？", true, (d) =>
                //    {
                //        Settlement(1);
                //    });
                //});

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
                if (!lastBackKeyDownTime.HasValue || DateTime.Now - lastBackKeyDownTime.Value > new TimeSpan(0, 0, 2))
                {
                    CloseFloatWindow();
                    lastBackKeyDownTime = DateTime.Now;
                    Toast.MakeText(this.ApplicationContext, "再按一次退出程序", ToastLength.Short).Show();
                    return true;
                }
                else
                {
                    Close();//关闭进程杀死
                }
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
        private string _ip = "paytest.sunits.cc";
        private int _port = 61026;
        private Socket _socket = null;
        private byte[] buffer = new byte[1024 * 1024 * 2];
        /// <summary>
        /// 开启服务,连接服务端
        /// </summary>
        public void StartClient()
        {
            try
            {
                //1.0 实例化套接字(IP4寻址地址,流式传输,TCP协议)
                _socket = new System.Net.Sockets.Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //2.0 创建IP对象

                //IPAddress address = IPAddress.Parse(_ip);//GetHostEntry
                IPHostEntry hostinfo = Dns.GetHostEntry(_ip);
                IPAddress[] aryIP = hostinfo.AddressList;
                IPAddress address = aryIP[0];
                //3.0 创建网络端口包括ip和端口
                IPEndPoint endPoint = new IPEndPoint(address, _port);
                //4.0 建立连接
                _socket.Connect(endPoint);
                //5.0 接收数据
                _socket.Send(Encoding.UTF8.GetBytes("链接成功"));
                while (true)
                {
                    Thread.Sleep(2000);
                    int length = _socket.Receive(buffer);
                    var str = Encoding.UTF8.GetString(buffer, 0, length);
                    if (!string.IsNullOrWhiteSpace(str))
                        this.RunOnUi(() => { this.ShowAlert(str, false); });
                }
            }
            catch (Exception ex)
            {
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
            }
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
        #region 退款
        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="salesOrder"></param>
        public void Refund(SalesOrder salesOrder)
        {
            try
            {
                SendLog("开始退款订单号：" + salesOrder.SubSaleNo + "&时间=" + DateTime.Now.ToString());
                if (_orderRefundType != 2 && _orderRefundType != 1)
                {
                    this.ShowAlert("退款类型错误");
                    return;
                }
                Intent intent = new Intent();
                intent.SetComponent(componet);
                Bundle bundle = new Bundle();
                mhtOrderAmt = salesOrder.ReadyPay.Value;
                mhtOrderNo = salesOrder.SubSaleNo;
                string proc_cd = _orderRefundType == 1 ? "680000" : "200000";
                var pay_tp = _orderRefundType == 1 ? "1" : "0";
                bundle.PutString("msg_tp", "0200");
                bundle.PutString("pay_tp", pay_tp);
                bundle.PutString("proc_tp", "00");
                bundle.PutString("proc_cd", proc_cd);//扫码支付680000  //银联支付 200000  //交易处理码需要与支付方式联动
                //bundle.PutString("amt", salesOrder.ReadyPay.Value.ToString());
                bundle.PutString("order_no", salesOrder.SubSaleNo);
                bundle.PutString("appid", "com.companyname.sunits.pay");
                bundle.PutString("time_stamp", DateTime.Now.ToString("yyyyMMddhhmmss"));
                bundle.PutString("order_info", salesOrder.Remarks);
                SendLog("准备进入退款接口：bundle" + JsonConvert.SerializeObject(bundle) + "&时间=" + DateTime.Now.ToString());
                intent.PutExtras(bundle);
                this.StartActivityForResult(intent, 2);
            }
            catch (Exception ex)
            {
                SendLog("退款出现异常！" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("退款出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }
        }
        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="resultCode"></param>
        /// <param name="pay_tp"></param>
        /// <param name="reason"></param>
        public async Task ActivityRefundAsync(Result resultCode, string pay_tp, string reason)
        {
            try
            {
                switch ((int)resultCode)
                {
                    // 支付成功
                    case -1:
                        // TODO:
                        var msg = await RefundBackAsync("A001");
                        if (string.IsNullOrWhiteSpace(msg))
                            this.ShowAlert("退款成功", false);
                        else
                        {
                            SendLog("订单号：" + mhtOrderNo + "退款回调失败，失败原因：" + msg + "&时间=" + DateTime.Now.ToString());
                            this.ShowAlert("退款成功，回调失败：" + msg, false);
                        }
                        break;

                    // 支付取消
                    case 0:

                        if (reason != null)
                        {
                            SendLog("订单号：" + mhtOrderNo + "退款取消!&时间=" + DateTime.Now.ToString());
                            this.ShowAlert("退款取消", false);
                        }
                        break;
                    case -2:
                        //交易失败
                        if (reason != null)
                        {
                            SendLog("订单号：" + mhtOrderNo + "退款失败!失败原因=" + reason + "&时间=" + DateTime.Now.ToString());
                            this.ShowAlert("退款失败!!" + reason, false);
                        }
                        break;

                    default:
                        // TODO:
                        break;

                }
            }
            catch (Exception ex)
            {

                SendLog("退款中转出现异常！" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("退款中转出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

        }
        /// <summary>
        /// 退款回调
        /// </summary>
        /// <param name="transStatus"></param>
        /// <returns></returns>
        public async Task<string> RefundBackAsync(string transStatus)
        {
            SendLog("订单号：" + mhtOrderNo + "进入RefundBack退款回调，支付结果为：" + transStatus + "&时间=" + DateTime.Now.ToString());
            try
            {
                string msg = "";
                var user = new Users();
                user.Password = Password;
                user.UserName = UserName;
                var tokenInfo = await Post<Users>(url + "/api/Token/Login", user);
                if (string.IsNullOrWhiteSpace(tokenInfo))
                {
                    SendLog("订单号：" + mhtOrderNo + "Token获取失败！，Password：" + user.Password + "&UserName" + user.UserName + "&时间=" + DateTime.Now.ToString());
                    msg = "Token获取失败！";
                    return msg;
                }
                SendLog("开始解析Token，tokenInfo：" + tokenInfo + "&时间=" + DateTime.Now.ToString());
                TokenInfo token = ByteToModel<TokenInfo>(tokenInfo);
                SendLog("Token解析成功，tokenInfo：" + tokenInfo + "&时间=" + DateTime.Now.ToString());
                SendLog("准备开始退款回调，时间=" + DateTime.Now.ToString());
                var _salesOrder = await Get(url + "/api/SalesOrder/ReturnSalesOrderPOS?SubSalesNo=" + mhtOrderNo + "&Account=pos机器&sysKey=" + SYSKEY, token.Token);//token.Token
                SendLog("退款回调成功，时间=" + DateTime.Now.ToString());
                var result = ByteToModel<ResultInfo>(_salesOrder);
                SendLog("退款回调成功，解析结果result=" + result + "&时间" + DateTime.Now.ToString());
                if (result == null)
                {
                    msg = "销售单获取失败！";
                    return msg;
                }
                if (result.ResultCode != 1)
                {
                    SendLog("退款回调出现问题，ResultMess=" + result.ResultMess + "&时间" + DateTime.Now.ToString());
                    msg = result.ResultMess;
                    return msg;
                }
                //var obj = (JavaList<SalesOrder>)result.Data;
                return msg;
            }
            catch (Exception ex)
            {
                SendLog("退款回调异常");
                return "退款回调出现异常-请联系管理员";
            }
        }
        #endregion
        #region 支付

        /// <summary>
        /// 支付
        /// </summary>
        public void Collection(SalesOrder salesOrder)
        {
            try
            {
                //createFloatView();
                SendLog("开始支付订单号：" + salesOrder.SubSaleNo + "&时间=" + DateTime.Now.ToString());
                if (_orderType != 0 && _orderType != 1)
                {
                    this.ShowAlert("支付类型错误");
                    return;
                }

                Intent intent = new Intent();
                intent.SetComponent(componet);
                Bundle bundle = new Bundle();
                mhtOrderAmt = salesOrder.ReadyPay.Value;
                mhtOrderNo = salesOrder.SubSaleNo;
                string proc_cd = _orderType == 0 ? "000000" : "660000";
                bundle.PutString("msg_tp", "0200");
                bundle.PutString("pay_tp", "" + _orderType);
                bundle.PutString("proc_tp", "00");
                bundle.PutString("proc_cd", proc_cd);
                bundle.PutString("amt", salesOrder.ReadyPay.Value.ToString());
                bundle.PutString("order_no", salesOrder.SubSaleNo);
                bundle.PutString("appid", "com.companyname.sunits.pay");
                bundle.PutString("time_stamp", DateTime.Now.ToString("yyyyMMddhhmmss"));
                bundle.PutString("order_info", salesOrder.Remarks);
                intent.PutExtras(bundle);
                this.StartActivityForResult(intent, 1);
                //扫码支付660000  //银联支付 000000  //交易处理码需要与支付方式联动
                SendLog("准备进入支付接口：bundle" + JsonConvert.SerializeObject(bundle) + "&时间=" + DateTime.Now.ToString());

            }
            catch (ActivityNotFoundException e)
            {
                this.RunOnUi(() =>
                {
                    this.ShowAlert("支付接口出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }
            catch (Exception e)
            {
                this.RunOnUi(() =>
                {
                    this.ShowAlert("支付接口出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }
        }

        /// <summary>
        /// 支付回调   //mhtOrderNo=SO123456&payChannelType=14&mhtOrderAmt=1000&transStatus=A001&mhtReserved=POSSaleOrder
        /// </summary>
        public async Task CollectionCallback(string transStatus, string pay_tp, string refernumber = "")
        {
            //try
            //{
            //    Log("订单号：" + mhtOrderNo + "进入CollectionCallback回调，支付结果为：" + transStatus + "&时间=" + DateTime.Now.ToString());
            //    var random = new Random().Next(1000, 9999);
            //    var amt = decimal.Round(decimal.Parse(mhtOrderAmt.ToString()), 2);
            //    var mhtAmt = (amt * 100).ToString();
            //    var mhtReserved = "";
            //    switch (mOrderType)
            //    {
            //        case "RE":
            //            mhtReserved = "Recepit";
            //            break;
            //        case "SO":
            //            mhtReserved = "POSSaleOrder";
            //            break;
            //        default:
            //            break;
            //    }
            //    var payChannelType = 14;
            //    if (pay_tp == "1")
            //        payChannelType = 13;
            //    if (pay_tp == "2")
            //        payChannelType = 12;
            //    var str = "payChannelType=" + payChannelType + "&transStatus=" + transStatus + "&mhtReserved=" + mhtReserved + "&Refernumber=" + refernumber + "&mhtOrderAmt=" + mhtAmt + "&mhtOrderNo=" + (mhtOrderNo + random.ToString()) + "&nowPayOrderNo=" + mhtOrderNo + "&payType=" + (_orderType == 0 ? "4" : "3") + "&payTypeName=" + (_orderType == 0 ? "POS银联支付" : "POS扫码支付");
            //    //var json = JsonConvert.DeserializeObject(str);
            //    Log("开始访问支付回调接口：" + mhtOrderNo + "进入CollectionCallback回调，str为：" + str + "&时间=" + DateTime.Now.ToString());
            //    var result = await PostObj(webpay + "/AggregatePay/PayBackNotify", str);
            //    if (result)
            //    {
            //        this.RunOnUi(() =>
            //        {
            //            this.ShowAlert("同步零售系统成功");
            //        });
            //    }
            //    else
            //    {
            //        this.RunOnUi(() =>
            //        {
            //            this.ShowAlert("同步零售系统失败！！");
            //        });
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Log("支付回调出现异常！" + ex.Message);
            //    this.RunOnUi(() =>
            //    {
            //        this.ShowAlert("支付回调出现异常-请联系管理员", false, (d) =>
            //        {
            //            Close();
            //        });
            //    });
            //}

        }
        /// <summary>
        /// 支付中转
        /// </summary>
        /// <param name="resultCode"></param>
        /// <param name="pay_tp"></param>
        /// <param name="reason"></param>
        public void ActivityPay(Result resultCode, string pay_tp, string reason, string refernumber)
        {
            //try
            //{
            //    Log("进入支付中转switch：resultCode：" + resultCode + "&pay_tp=" + pay_tp + "reason=" + reason + "&时间=" + DateTime.Now.ToString());
            //    switch ((int)resultCode)
            //    {
            //        // 支付成功
            //        case -1:
            //            // TODO:
            //            this.ShowAlert("支付成功", false);
            //            if (pay_tp != "0")
            //            {
            //                createFloatView();
            //                PayPrinting();
            //            }
            //            CollectionCallback("A001", pay_tp, refernumber);
            //            break;

            //        // 支付取消
            //        case 0:

            //            if (reason != null)
            //            {
            //                // TODO:
            //                this.ShowAlert("支付取消", false);
            //            }
            //            break;
            //        case -2:
            //            //交易失败
            //            if (reason != null)
            //            {
            //                // TODO: 
            //                this.ShowAlert("交易失败!!" + reason, false);
            //                CollectionCallback("A002", pay_tp);
            //            }
            //            break;

            //        default:
            //            // TODO:
            //            break;

            //    }
            //}
            //catch (Exception ex)
            //{
            //    SendLog("支付中转出现异常！" + ex.Message);
            //    this.RunOnUi(() =>
            //    {
            //        this.ShowAlert("支付中转出现异常-请联系管理员", false, (d) =>
            //        {
            //            Close();
            //        });
            //    });
            //}

        }
        /// <summary>
        /// 支付打印
        /// </summary>
        public async Task PayPrinting()
        {
            //try
            //{
            //    Intent intent = new Intent();
            //    intent.SetComponent(componet);
            //    Bundle bundle = new Bundle();
            //    bundle.PutString("msg_tp", "0200");
            //    bundle.PutString("pay_tp", "" + _orderType);
            //    bundle.PutString("proc_tp", "00");
            //    bundle.PutString("proc_cd", "700007");//扫码支付660000  //银联支付 000000  //交易处理码需要与支付方式联动
            //    //bundle.PutString("order_no", mhtOrderNo);
            //    bundle.PutString("appid", "com.companyname.sunits.pay");
            //    bundle.PutString("time_stamp", DateTime.Now.ToString("yyyyMMddhhmmss"));
            //    bundle.PutString("order_info", "");
            //    Log("准备进入支付打印接口：bundle" + JsonConvert.SerializeObject(bundle) + "&时间=" + DateTime.Now.ToString());
            //    intent.PutExtras(bundle);
            //    this.StartActivityForResult(intent, 4);
            //}
            //catch (Exception ex)
            //{
            //    Log("支付成功打印出现异常！" + ex.Message);
            //    this.RunOnUi(() =>
            //    {
            //        this.ShowAlert("支付成功打印出现异常-请联系管理员", false, (d) =>
            //        {
            //            Close();
            //        });
            //    });
            //}
        }
        #endregion
        #region 获取销售订单定金信息
        /// <summary>
        /// 获取销售单号
        /// </summary>
        /// <returns></returns>
        public Tuple<SalesOrder, string> GetSalesOrder(string orderNo)
        {
            try
            {
                string msg = "";
                var token = GetTokenAsync();
                if (!token.Success)
                {
                    SendLog("解析Token失败！！&时间=" + DateTime.Now.ToString());
                    return new Tuple<SalesOrder, string>(null, token.Message);
                }
                var payType = _orderType == 0 ? 2 : 1;
                SendLog("开始获取获取销售单号，tokenInfo：" + token.Token + "&url=" + url + "/api/SalesOrder/GetSalesOrderDetailBySalesOrderNO?salesOrder=" + orderNo + "&payType=" + payType + "&scanType=" + _scanType + "&时间=" + DateTime.Now.ToString());
                var _salesOrder = Get(url + "/api/SalesOrder/GetSalesOrderDetailBySalesOrderNO?salesOrder=" + orderNo + "&payType=" + payType + "&scanType=" + _scanType, token.Token);//token.Token
                SendLog("结束过去销售单号，_salesOrder：" + _salesOrder + "&时间=" + DateTime.Now.ToString());
                SendLog("开始解析_salesOrder！&时间=" + DateTime.Now.ToString());
                var result = ByteToModel<SalesOrderInfo>(_salesOrder.Result);
                SendLog("解析_salesOrder结束！&时间=" + DateTime.Now.ToString());
                if (result == null)
                {
                    msg = "销售单获取失败！";
                    SendLog("销售单获取失败！！&时间=" + DateTime.Now.ToString());
                    return new Tuple<SalesOrder, string>(null, msg);
                }
                if (result.ResultCode != 1)
                {
                    msg = result.ResultMess;
                    SendLog("获取销售单出现问题！！ResultMess:" + result.ResultMess + "&时间=" + DateTime.Now.ToString());
                    return new Tuple<SalesOrder, string>(null, msg);
                }
                //var obj = (JavaList<SalesOrder>)result.Data;
                return new Tuple<SalesOrder, string>((SalesOrder)result.Data, msg);
            }
            catch (Exception ex)
            {
                SendLog("获取销售单号APP出现Exception错误");
                return new Tuple<SalesOrder, string>(null, "软件内部出现错误,联系管理员");
            }

        }
        /// <summary>
        /// 获取定金单号
        /// </summary>
        /// <returns></returns>
        public Tuple<Receipt, string> GetReceiptSubSaleNo(string ReceiptSubSaleNo)
        {
            try
            {
                string msg = "";
                var token = GetTokenAsync();
                if (!token.Success)
                {
                    SendLog("解析Token失败！！&时间=" + DateTime.Now.ToString());
                    return new Tuple<Receipt, string>(null, token.Message);
                }
                SendLog("开始获取获取定金单号，tokenInfo：" + token.Token + "&url=" + url + "/api/SaleReceipt/GetSaleReceiptDeposit?ReceiptSubSaleNo=" + ReceiptSubSaleNo + "&sysKey=" + SYSKEY + "&时间=" + DateTime.Now.ToString());
                var _receiptSubSaleNo = Get(url + "/api/SaleReceipt/GetSaleReceiptDeposit?ReceiptSubSaleNo=" + ReceiptSubSaleNo + "&sysKey=" + SYSKEY, token.Token).Result;//token.Token
                SendLog("结束过去定金单号，_salesOrder：" + _salesOrder + "&时间=" + DateTime.Now.ToString());
                SendLog("开始解析_receiptSubSaleNo！&时间=" + DateTime.Now.ToString());
                var result = ByteToModel<ReceiptInfo>(_receiptSubSaleNo);
                SendLog("解析_receiptSubSaleNo结束！&时间=" + DateTime.Now.ToString());
                if (result == null)
                {
                    msg = "定金单获取失败！";
                    SendLog("定金单获取失败！！&时间=" + DateTime.Now.ToString());
                    return new Tuple<Receipt, string>(null, msg);
                }
                if (result.ResultCode != 1)
                {
                    msg = result.ResultMess;
                    SendLog("获取定金单出现问题！！ResultMess:" + result.ResultMess + "&时间=" + DateTime.Now.ToString());
                    return new Tuple<Receipt, string>(null, msg);
                }
                //var obj = (JavaList<SalesOrder>)result.Data;
                return new Tuple<Receipt, string>((Receipt)result.Data, msg);
            }
            catch (Exception ex)
            {
                SendLog("获取定金单号APP出现Exception错误");
                return new Tuple<Receipt, string>(null, "软件内部出现错误,联系管理员");
            }

        }
        /// <summary>
        /// 获取Token
        /// </summary>
        /// <returns></returns>
        public TokenInfo GetTokenAsync()
        {
            try
            {
                string msg = "";
                var user = new Users();
                user.Password = Password;
                user.UserName = UserName;
                var tokenInfo = Post<Users>(url + "/api/Token/Login", user);
                if (string.IsNullOrWhiteSpace(tokenInfo.Result))
                {
                    msg = "Token获取失败！";
                    SendLog("获取定金单号Token获取失败！&时间=" + DateTime.Now.ToString());
                    return new TokenInfo() { Message = "Token获取失败！" };
                }
                var payType = _orderType == 0 ? 2 : 1;
                SendLog("获取定金单号开始解析Token，tokenInfo：" + tokenInfo + "&时间=" + DateTime.Now.ToString());
                TokenInfo token = ByteToModel<TokenInfo>(tokenInfo.Result);
                return token;
            }
            catch (Exception)
            {
                return new TokenInfo() { Message = "Token解析失败！" };
            }

        }
        //处理RE单号逻辑
        public void ManageRE(string ReceiptSubSaleNo)
        {
            try
            {
                mOrderType = "RE";
                if (_scanType == 2)
                {
                    this.RunOnUi(() => { this.ShowAlert("RE单号不支持退款", false); });
                    return;
                }
                SendLog("准备进入ManageRE方法RE单号处理逻辑！ReceiptSubSaleNo=" + ReceiptSubSaleNo + "&时间=" + DateTime.Now.ToString());
                var _receiptSubSaleNo = GetReceiptSubSaleNo(ReceiptSubSaleNo);
                //CloseFloatWindow();
                if (_receiptSubSaleNo.Item1 == null || _receiptSubSaleNo.Item1.tb_Receipt_Id == 0)
                {

                    this.RunOnUi(() => { this.ShowAlert(_receiptSubSaleNo.Item2, false); });
                }
                else
                {
                    if (_receiptSubSaleNo.Item1.PayStatus != "A003")
                    {
                        this.RunOnUi(() => { this.ShowAlert("订单支付过或非线上资金收据", false); });
                    }
                    else
                    {
                        var model = _receiptSubSaleNo.Item1;
                        _salesOrder = new SalesOrder() { ReadyPay = model.ReceiptAmount, SubSaleNo = model.ReceiptNo, Remarks = model.Remark, CreateDate = model.CreateDate.Value, PayMent = 0 };
                        Collection(_salesOrder);
                    }
                }
            }
            catch (Exception ex)
            {
                SendLog("处理RE单号逻辑现异常！" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("处理RE单号逻辑出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

        }
        //处理SO单号逻辑
        public void ManageSO(string saleOrder)
        {
            try
            {
                mOrderType = "SO";
                SendLog("准备进入GetSalesOrder方法SO单号处理逻辑！saleOrder=" + saleOrder + "&时间=" + DateTime.Now.ToString());
                var models = GetSalesOrder(saleOrder);
                _salesOrder = models.Item1;
                SendLog("HandleScanResultAsync方法获取销售单信息！销售单信息=" + JsonConvert.SerializeObject(_salesOrder) + "&时间=" + DateTime.Now.ToString());
                this.CloseFloatWindow();
                if (models.Item1 == null)
                {
                    this.RunOnUi(() => { this.ShowAlert(models.Item2); });
                }
                else
                {
                    //if (models.Item1.ReadyPay == models.Item1.PayMent)
                    //{
                    //    //this.RunOnUi(this.CloseFloatWindow);
                    //    this.RunOnUi(() => { this.ShowAlert("订单已开过票", false); });
                    //}
                    //else
                    if (models.Item1.OnlinePay == 1)
                    {
                        //this.RunOnUi(this.CloseFloatWindow);
                        //支付
                        if (_scanType == 1)
                        {
                            if (models.Item1.ReadyPay == models.Item1.PayMent)
                            {
                                this.RunOnUi(() => { this.ShowAlert("订单已支付,已开票", false); });
                            }
                            else
                                this.RunOnUi(() => { this.ShowAlert("订单已支付，未开票", false); });
                        }
                        #region 退款
                        else if (_scanType == 2)//退款
                        {
                            _orderRefundType = models.Item1.PayType;//支付类型
                            var ctime = models.Item1.CreateDate.ToString("yyyyMMdd");
                            var ntime = DateTime.Now.ToString("yyyyMMdd");
                            if (models.Item1.ReadyPay == models.Item1.PayMent)
                            {
                                this.RunOnUi(() => { this.ShowAlert("已经开票的暂时不支持退款", false); });
                            }
                            else if (!models.Item1.SubSaleNo.Contains("SO"))
                            {
                                this.RunOnUi(() => { this.ShowAlert("只能退SO的单子", false); });
                            }
                            else if (_orderRefundType != 1 && _orderRefundType != 2)
                            {
                                this.RunOnUi(() => { this.ShowAlert("退款失败，类型不符", false); });
                                SendLog("订单号：" + mhtOrderNo + "退款失败，_orderRefundType：" + _orderRefundType + "PayType=" + models.Item1.PayType + "&时间=" + DateTime.Now.ToString());
                            }
                            else if (ctime != ntime)
                            {
                                this.RunOnUi(() => { this.ShowAlert("退款失败，只能退当日", false); });
                            }
                            else
                            {
                                this.createFloatView();
                                Refund(models.Item1);
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        if (_scanType == 1)
                        {
                            if (models.Item1.PayType == 0)
                            {
                                _salesOrder = models.Item1;
                                this.createFloatView();
                                Collection(models.Item1);
                            }
                            else
                            {
                                this.RunOnUi(() => { this.ShowAlert("订单已支付", false); });
                            }
                        }
                        else if (_scanType == 2)
                        {
                            this.RunOnUi(() => { this.ShowAlert("订单未支付", false); });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                SendLog("处理SO单号逻辑！" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("处理SO单号逻辑-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

        }
        #endregion
    }
}