using Android.App;
using Android.OS;
using Android.Runtime;
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
using System.Collections.Generic;
using Android.Widget;
using Android.Support.V7.Widget;
using Android.Hardware.Camera2;

namespace App3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : BaseActivity //AppCompatActivity  之前引用
    {

        #region 全局标量 
        protected View zxingOverlay;
        protected MobileBarcodeScanner scanner;
        protected MobileBarcodeScanningOptions mbs;
        protected ImageView ivScanning;
        // 从上到下的平移动画
        protected Animation verticalAnimation;
        //当前订单号集合
        private List<string> orders=new List<string>();
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
                scanner.AutoFocus();
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
            //Button btnScan = this.FindControl<Button>("btnScan");
            //btnScan.Click += (s, e) =>
            //{
            //    var str = ReadTXT();
            //    this.ShowToast(str);
            //    //var ddd=systemInf.SerialNo;
            //    //InvokeRemoteService();
            //    createFloatView();
            //    textPrompt.Text = "微信/支付宝支付，请将销售订单二维码放入框内";
            //    _orderType = 1;//支付类型
            //    _scanType = 1;//扫描类型
            //    Task t = new Task(AutoScan);
            //    t.Start();
            //};
            Button btnHttp = this.FindControl<Button>("btnUnion");
            btnHttp.Click += (s, e) =>
            {
                var b = Check();
                if (!b)
                    return;
                createFloatView();
                textPrompt.Text = "银行卡支付，请将销售订单二维码放入框内";
                _orderType = 0;//支付类型
                _scanType = 1;//扫描类型
                Task t = new Task(AutoScan);
                t.Start();
            };
            //Button btnRefund = this.FindControl<Button>("btnRefund");//退款
            //btnRefund.Click += (s, e) =>
            //{
            //    createFloatView();
            //    textPrompt.Text = "退款扫描，请将销售订单二维码放入框内";
            //    _scanType = 2;//扫描类型
            //    //AutoScan();
            //    Task t = new Task(AutoScan);
            //    t.Start();
            //};
            //Button btnSettlement = this.FindControl<Button>("btnSettlement");//结算
            //btnSettlement.Click += (s, e) =>
            //{
            //    //OpenOrder();
            //    _scanType = 3;//扫描类型
            //    //UserDialogs.Instance.Alert("您确认开始结算吗？","","确认");
            //    this.RunOnUi(() =>
            //    {
            //        this.ShowAlert("您确认开始结算吗？", true, (d) =>
            //        {
            //            Settlement(1);
            //        });
            //    });

            //};
            Button btnMargin = this.FindControl<Button>("btnMargin");//定金
            btnMargin.Click += (s, e) =>
            {
                var b = Check();
                if (!b)
                    return;
                createFloatView();
                ShowActivity<CashReceiptsActivity>();
                CloseFloatWindow();
            };
            Button button2 = this.FindControl<Button>("btnOrder");//创建销售单
            button2.Click += (s, e) =>
            {
                createFloatView();
                Task t = new Task(CreateOrderScan);
                t.Start();
            };
            Button button1 = this.FindControl<Button>("btnSetUpThe");//设置
            button1.Click += (s, e) =>
            {
                createFloatView();
                ShowActivity<SetUpThePageActivity>();
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
                    return true;
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
        #region 创建订单
        private List<SalesOrderDetails> OrderDetails = new List<SalesOrderDetails>();
        private MobileBarcodeScanner scanorder;
        public void CreateOrderScan()
        {
            var b=Check();
            if (!b)
                return;
            try
            {
                var createOrder = LayoutInflater.FromContext(this).Inflate(Resource.Layout.CreateOrder, null);
                scanorder = new MobileBarcodeScanner();
                scanorder.UseCustomOverlay = true;
                createOrder.Measure(MeasureSpecMode.Unspecified.GetHashCode(), MeasureSpecMode.Unspecified.GetHashCode());
                Button btnCancelScan = createOrder.FindViewById<Button>(Resource.Id.cancel);//取消扫描
                btnCancelScan.Click += (s, e) =>
                {
                    if (scanorder != null)
                    {
                        //orders.Clear();
                        //OrderDetails.Clear();
                        this.RunOnUi(() =>
                        {
                            ShowActivity<MainActivity>();
                        });
                    }
                };
                Button btnSubOrder = createOrder.FindViewById<Button>(Resource.Id.subOrder);//提交订单
                btnSubOrder.Click += (s, e) =>
                {
                    if (scanorder != null)
                    {
                        if (OrderDetails.Count > 0)
                        {
                            this.RunOnUi(() =>
                            {
                                OpenOrder();
                            });
                        }
                        else
                        {
                            this.RunOnUi(() =>
                            {
                                ShowToast("当前没有物料");
                            });
                        }

                    }
                };
                scanorder.CustomOverlay = createOrder;
                var ivScanningorder = createOrder.FindViewById<ImageView>(Resource.Id.ivScanning);
                CreteView(createOrder);
                //new rect
                // 从上到下的平移动画
                var verticalAnimationOrder = new TranslateAnimation(0, 0, 0, 800)
                {
                    Duration = 3000, // 动画持续时间
                    RepeatCount = Animation.Infinite // 无限循环
                };
                verticalAnimationOrder.StartNow();
                // 播放动画
                ivScanningorder.Animation = verticalAnimationOrder;
                //ivScanningorder.StopNestedScroll();
                //SetPreviewCallback
                scanorder.AutoFocus();
                var result = scanorder.Scan(this, mbs).Result;
                DisplayCamera().Wait();
                createOrder.Dispose();
                verticalAnimationOrder.Dispose();
                ivScanningorder.Dispose();
                AddList(result);
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
        public void CreteView(View view)
        {


            //var createOrder = LayoutInflater.FromContext(this).Inflate(Resource.Layout.CreateOrder, null);

            var orderNumber = view.FindViewById<TextView>(Resource.Id.orderNumber);
            if (orders!=null&& orders.Count>0)
            {
                var recyclerView = view.FindViewById<RecyclerView>(Resource.Id.recyclerView);
                var adapter = new RecyclerViewAdapter(OrderDetails, this);
                recyclerView.SetLayoutManager(new LinearLayoutManager(this));
                recyclerView.AddItemDecoration(new Comment.MyItemDecoration(this, (int)Orientation.Vertical));
                recyclerView.SetAdapter(adapter);
                //TextView baseView = view.FindViewById<TextView>(Resource.Id.baseView);
                //gridview.RemoveView(baseView);
                //foreach (var item in orders)
                //{
                //    TextView text = new TextView(this);
                //    text.TextSize = 20;
                //    text.SetPadding(8, 8, 8, 8);
                //    text.Text = item;
                //    gridview.AddView(text);
                //}
                orderNumber.Text = orders.Count.ToString();
                //TableRow tableRow = new TableRow(this);
                //tableRow.Left
            }
        }
        public void AddList(ZXing.Result result)
        {
            //震动
            Vibrator vibrator = (Vibrator)Application.Context.GetSystemService(Context.VibratorService);
            long[] pattern = { 0, 350, 220, 350 };
            vibrator.Vibrate(pattern, -1);
            var bf = true;
            if (result == null)
                bf=false;
            if (result!=null&&!string.IsNullOrWhiteSpace(result.Text))
            {
                if (orders.Contains(result.Text))
                    bf = false;
                var b = AddOrders(result.Text);
                if (!b.Result)
                    bf = false;
                if (bf)
                { 
                    string orderDetails = result.Text;
                    orders.Add(orderDetails);
                    this.RunOnUi(() =>
                    {
                        ShowToast("添加成功");
                    });
                }
                CreateOrderScan();
            }
            this.RunOnUi(() =>
            {
                ShowToast("取消开单");
            });
        }
        private async Task<bool> AddOrders(string Barcode)
        {
            try
            {
                var result = Get(url + "/api/Material/GetMateriaBarcode?Barcode=" + Barcode + "&sysKey=" + SYSKEY, "");//token.Token
                var _salesOrderDetails = ByteToModel<SalesOrderDetailInfo>(result.Result);
                if (_salesOrderDetails.ResultCode == 1)
                {
                    foreach (var item in OrderDetails)
                    {
                        if (item.Barcode.Contains(_salesOrderDetails.Data.Barcode))
                        {
                            this.RunOnUi(() =>
                            {
                                ShowToast("此条码已存在");
                            });
                            return false;
                        }
                    }
                    OrderDetails.Add(_salesOrderDetails.Data);
                    return true;
                }
                else {
                    this.RunOnUi(() =>
                    {
                        ShowToast(_salesOrderDetails.ResultMess);
                    });
                    return false;
                }
            }
            catch (Exception ex)
            {
                this.RunOnUi(() =>
                {
                    ShowToast("未找到此条码");
                });
                SendLog("提交订单，根据条码获取数据：条码="+ Barcode+"!!发生异常");
                return false;
            }
        }
        private void OpenOrder()
        {
            Intent intent = new Intent(this, typeof(OrderList));
            var objval = JsonConvert.SerializeObject(OrderDetails);
            //orders.Clear();
            //OrderDetails.Clear();
            intent.PutExtra("obj", objval);
            StartActivity(intent);
        }
        /// <summary>
        /// 
        /// 页面得click事件  直接标注方法名
        /// </summary>
        /// <param name="v"></param>
        [Java.Interop.Export("Cancel")]
        public void Cancel(View v)
        {
            Button button = (v as Button);
            var val = button.Text;
            this.RunOnUi(() =>
            {
                ShowToast("取消取消取消89"+ val);
            });
        }
        #endregion
    }
}