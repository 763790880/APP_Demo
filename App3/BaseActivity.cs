using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Hardware;
using Android.OS;
using Android.Views;
using Android.Widget;
using App3.Model;
using Com.Lkl.Cloudpos.Mdx.Aidl;
using Com.Lkl.Cloudpos.Mdx.Aidl.System;
using Newtonsoft.Json;
using RestSharp;

namespace App3
{
    public class BaseActivity : Activity
    {
        #region 常量
        protected const string SYSKEY = "UE9T57q/5LiK5pSv5LuY";
        protected const string Password = "A2MqspbZhTBAdtIVBLGhc12cu/G8OCyX";//A2MqspbZhTBAdtIVBLGhc12cu/G8OCyX
        protected const string UserName = "20181115144834995";
        public ComponentName componet = new ComponentName("com.lkl.cloudpos.payment", "com.lkl.cloudpos.payment.activity.MainMenuActivity");
        public const string url = "http://itest.sunits.cc";//获取单号  正式//http://rsapi.sunits.com   //http://itest.sunits.cc  //http://r27532594m.qicp.vip:39767
        public const string webpay = "http://jxcweixin15815.sunits.cc";//支付回调  //  正式//http://inventory.sunits.net:15813 //http://r27532594m.qicp.vip:39767  //http://jxcweixin15815.sunits.cc
        protected static bool IsFirst = false;//是否首次运行  并检测完系统
        #endregion
        protected void ShowActivity<T>() where T : Activity
        {
            Intent intent = new Intent(this, typeof(T));
            StartActivity(intent);
        }
        protected void OpenService<T>() where T : Service
        {
            Intent intent = new Intent(this, typeof(T));
            StartService(intent);
        }

        #region  各种提示信息
        protected void ShowToast(string msg)
        {
            UserDialogs.Instance.HideLoading();
            
            Toast.MakeText(this, msg, ToastLength.Short).Show();
        }

        private AlertDialog dialog;
        protected AlertDialog InitDialog(string msg, Action<AlertDialog> comfirmCallback, Action<AlertDialog> cancelCallback,bool IsShow)
        {
            AlertDialog cdialog;
            //构造器
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            //标题
            //builder.SetTitle("提示");
            //图标
            //builder.SetIcon(android.R.drawable.btn_dialog);
            //内容
            builder.SetMessage(msg);
            //setPositiveButton(表示按钮的文本，表示单击按钮触发单击事件)
            builder.SetPositiveButton("确认", new EventHandler<DialogClickEventArgs>((s, e) =>
            {
                if (comfirmCallback != null)
                {
                    comfirmCallback(dialog);
                }
            }));
            if (IsShow)
            { 
                builder.SetNegativeButton("取消", new EventHandler<DialogClickEventArgs>((s, e) =>
            {
                if (cancelCallback != null)
                {
                    cancelCallback(dialog);
                }
            }));
            }
            //builder.SetNeutralButton("稍后提醒", new EventHandler<DialogClickEventArgs>((s, e) => { }));
            cdialog = builder.Create();//构建dialog对象

            return cdialog;
        }
        /// <summary>
        /// 弹出层
        /// </summary>
        /// <param name="msg">提示信息</param>
        /// <param name="IsShow">是否显示取消按钮</param>
        /// <param name="comfirmCallback">确认按钮事件</param>
        /// <param name="cancelCallback">取消按钮事件</param>
        protected void ShowAlert(string msg, bool IsShow=true, Action<AlertDialog> comfirmCallback = null, Action<AlertDialog> cancelCallback = null)
        {
            UserDialogs.Instance.HideLoading();
            if (comfirmCallback == null)
            {
                cancelCallback = (d) => { dialog.Dismiss(); };
            }
            if (cancelCallback == null)
            {
                cancelCallback = (d) => { dialog.Dismiss(); };
            }
            dialog = InitDialog(msg, comfirmCallback, cancelCallback, IsShow);
            if (dialog != null && !dialog.IsShowing)
            {
                dialog.Show();
            }
        }
        protected void CancelAlert()
        {
            if (dialog != null && dialog.IsShowing)
            {
                dialog.Cancel();
            }
        }
        protected void NotifyMessage(string message, string title = "消息")
        {
            NotificationManager manager = (NotificationManager)GetSystemService(Context.NotificationService);  // 在Android进行通知处理，首先需要重系统哪里获得通知管理器NotificationManager，它是一个系统Service。  
            PendingIntent pendingIntent = PendingIntent.GetActivity(this, 0,
                    new Intent(this, typeof(MainActivity)), 0);
            Notification notify1 = new Notification();
            notify1.Icon = Resource.Drawable.tubiao;
            notify1.TickerText = JaveString("您有新短消息，请注意查收！");
            notify1.When = DateTime.Now.ToFileTime();
            notify1.SetLatestEventInfo(this, title, message, pendingIntent);
            notify1.Number = 1;
            notify1.Flags |= NotificationFlags.AutoCancel; // FLAG_AUTO_CANCEL表明当通知被用户点击时，通知将被清除。  
                                                           // 通过通知管理器来发起通知。如果id不同，则每click，在statu那里增加一个提示  
            manager.Notify(1, notify1);
        }
        protected static Java.Lang.String JaveString(string str)
        {
            return new Java.Lang.String("您有新短消息，请注意查收！");
        }
        #endregion

        #region 寻找资源
        protected T FindControl<T>(string name) where T : View
        {
            return FindViewById<T>(GetCode(name));
        }

        protected T FindControl<T>(string name, Action clickCallBack) where T : View
        {
            View view = FindViewById<T>(GetCode(name));
            view.Click += (s, e) =>
            {
                clickCallBack();
            };
            return FindViewById<T>(GetCode(name));
        }

        protected int GetCode(string name)
        {
            var R = this.Resources;
            var code = (typeof(Resource.Id)).GetFields().FirstOrDefault(f => f.Name == name).GetValue(R);
            return (int)code;
        }
        #endregion

        #region 异步调用
        protected void AsyncLoad(Action action)
        {
            IAsyncResult result = action.BeginInvoke((iar) =>
            {
            }, null);
        }
        protected void AsyncLoad(Action action, Action callback)
        {
            IAsyncResult result = action.BeginInvoke((iar) =>
            {
                this.RunOnUiThread(callback);
            }, null);
        }

        protected void AsyncLoad<T>(Action<T> action, T para, Action callback)
        {
            IAsyncResult result = action.BeginInvoke(para, (iar) =>
            {
                this.RunOnUiThread(callback);
            }, null);
        }
        protected void RunOnUi(Action action)
        {
            ((BaseActivity)this).RunOnUiThread(() => { action(); });//回UI线程
        }
        #endregion

        #region 获取数据
        protected void GetRest<T>(string url, Action<T> callback)
        {
            //Task.Run(() =>
            //{
            //    try
            //    {
            //        HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
            //        request.ContentType = "application/json";
            //        request.Method = "GET";
            //        using (WebResponse response = request.GetResponse())
            //        {
            //            using (Stream stream = response.GetResponseStream())
            //            {
            //                T jsonDoc = JsonObject.Load(stream);
            //                callback(jsonDoc);
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Log.Debug("BaseActivity", $"Exception at GetRest" + ex.Message);
            //    }
            //});

        }
        //发送get请求获取bytes
        protected static async System.Threading.Tasks.Task<byte[]> GetBytes(string path)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(path);
                request.Method = "post";
                request.Timeout = 500;
                //request.Proxy设置代理
                //path 中可添加querystring参数
                //request.UserAgent 请求的代理
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Stream responseStream = response.GetResponseStream();
                    //将流转成字节
                    byte[] bytes = new byte[responseStream.Length];
                    responseStream.Read(bytes, 0, bytes.Length);
                    //byte[] bytes = StreamToBytes(responseStream);
                    return bytes;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        protected static async System.Threading.Tasks.Task<bool> PostObj(string url, object data)
        {
            RestClient restClient = Instance(url);
            RestRequest request = new RestRequest();
            //request.AddQueryParameter("id","")  添加url的参数(AddUrlSegment)
            //request.AddHeader("Authorization","token");添加请求头参数
             request.AddHeader("content-type", "application/json; charset=UTF-8");
            request.AddJsonBody(data);
            //request.AddParameter("application/x-www-form-urlencoded; charset=UTF-8", user, ParameterType.RequestBody);
            var response = await restClient.ExecutePostTaskAsync(request);
            //var response = await restClient.ExecutePostTaskAsync<string>(request); 自动序列化
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
               
                //var result = JsonConvert.DeserializeObject<string>();
                if (response.Content == "success=Y")
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        protected static async System.Threading.Tasks.Task<string> Post<T>(string url, T user)
        {
            try
            {
                RestClient restClient = Instance(url);
                RestRequest request = new RestRequest();
                //request.AddQueryParameter("id","")  添加url的参数(AddUrlSegment)
                //request.AddHeader("Authorization","token");添加请求头参数
                request.AddHeader("content-type", "application/json; charset=UTF-8");
                request.AddJsonBody(user);
                //request.AddParameter("application/x-www-form-urlencoded; charset=UTF-8", user, ParameterType.RequestBody);
                var response = await restClient.ExecutePostTaskAsync(request);
                //var response = await restClient.ExecutePostTaskAsync<string>(request); 自动序列化
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //var result = JsonConvert.DeserializeObject<string>(response.Content);
                    return response.Content;
                    //if (result == "success")
                    //{ 
                    //    return true;
                    //}
                    //return false;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {

                throw;
            }

        }
        protected static async System.Threading.Tasks.Task<string> Get(string url,string token)
        {
            try
            {
                RestClient restClient = Instance(url);
                RestRequest request = new RestRequest();
                request.AddHeader("content-type", "application/json; charset=UTF-8");
                request.AddHeader("auth", token);
                var response = await restClient.ExecuteGetTaskAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return response.Content;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        internal static RestClient Instance(string url)
        {
            var restClient = new RestClient(url)
            {
                Timeout = 20000,
                ReadWriteTimeout = 5000
            };
            return restClient;
        }
        #endregion

        #region 各种转换
        protected static string ByteToString(byte[] buff)
        {
            string str = Encoding.UTF8.GetString(buff);
            return str;
        }
        protected static T ByteToModel<T>(byte[] buff)
        {
            T obj;
            using (MemoryStream ms = new MemoryStream(buff))
            {
                IFormatter iFormatter = new BinaryFormatter();
                obj = (T)iFormatter.Deserialize(ms);
            }
            return obj;
        }
        protected static T ByteToModel<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
        //protected ImageView ByteToImage(byte[] buff)
        //{
        //    String teststr = String.Format("Size%d--No.1:%02X,Last:%02X", buff.Length, tempbyte[0], tempbyte[buff.Length - 1]);
        //    tv_Receive.append(teststr);

        //    Bitmap bm_finger = getPicFromBytes(tempbyte, null);
        //    ((ImageView)findViewById(R.id.IV_fingerprint)).setImageBitmap(bm_finger);
        //}
        #endregion

        #region 终止
        protected void Close()
        {
            Finish();
            Process.KillProcess(Android.OS.Process.MyPid());
        }
        #endregion

        #region 链接服务
        protected static BookServiceConnection _bookServiceConnection;
        private static IAidlSystem systemInf = null;

        protected bool BindRemoteService()//绑定远程服务
        {
            try
            {
                Intent intent = new Intent("lkl_cloudpos_mdx_service");
                if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
                {
                    intent = CreateExplicitFromImplicitIntent(intent);
                }

                if (_bookServiceConnection == null)
                {
                    _bookServiceConnection = new BookServiceConnection();
                }
                this.BindService(intent, _bookServiceConnection, Bind.AutoCreate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            //Toast.MakeText(this, "绑定远程服务", ToastLength.Short).Show();
        }
        private void UnBindRemoteService()//解绑远程服务
        {
            if (_bookServiceConnection != null)
            {
                this.UnbindService(_bookServiceConnection);
                _bookServiceConnection = null;
                Toast.MakeText(this, "解绑远程服务", ToastLength.Short).Show();
            }
        }

        //从隐式声明的Intent中创建一个显式声明的Intent（在Android5.0及以上系统中需要显式声明Intent才能启动Service）
        private Intent CreateExplicitFromImplicitIntent(Intent implicitIntent)
        {
            PackageManager pm = this.PackageManager;
            //查出所有的能匹配这个隐式意图的服务列表
            IList<ResolveInfo> resolveInfo = pm.QueryIntentServices(implicitIntent, 0);
            if (resolveInfo == null || resolveInfo.Count != 1)
            {
                return null;
            }
            ResolveInfo serviceInfo = resolveInfo[0];
            string packageName = serviceInfo.ServiceInfo.PackageName;//取出包名
            string className = serviceInfo.ServiceInfo.Name;//取出服务名
            ComponentName component = new ComponentName(packageName, className);//用包名和服务名来创建一个ComponentName对象

            //拿隐式意图对象implicitIntent作为构造参数，来创建一个新的显示的意图
            Intent explicitIntent = new Intent(implicitIntent);
            explicitIntent.SetComponent(component);//设置显示意图的组件名对象

            return explicitIntent;
        }

        /// <summary>
        /// Printer
        /// </summary>
        public class BookServiceConnection : Java.Lang.Object, IServiceConnection
        {
            protected IAidlDeviceService Service { get; private set; }
            public void OnServiceConnected(ComponentName name, IBinder service)
            {
                Service = AidlDeviceServiceStub.AsInterface(service);
                systemInf= AidlSystemStub.AsInterface(Service.SystemService);
            }
            public void OnServiceDisconnected(ComponentName name)
            {
            }
        }
        #endregion


        #region 创建设置文件
        private string mRecordFile = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath + "/sunits.txt";
        private Java.IO.File dir = Android.OS.Environment.ExternalStorageDirectory;
        /// <summary>
        /// 读取文件
        /// </summary>
        protected internal string ReadTXT()
        {
            string text;
            Java.IO.File file = new Java.IO.File(dir, "sunits.txt");
            if (!file.Exists()) {
                text = "这个东西不存在!";
                return text;
            }
            text = System.IO.File.ReadAllText(mRecordFile);
            return text;
        }
        protected internal DatabaseTXT ReadTXTModel()
        {
            try
            {
                var json = ReadTXT();
                var model = JsonConvert.DeserializeObject<DatabaseTXT>(json);
                return model;
            }
            catch (Exception ex)
            {

                return null;
            }

        }
        /// <summary>
        /// 创建文件
        /// </summary>
        protected internal bool CreateTXT(string obj,string path="")
        {
            try
            {
                if (string.IsNullOrWhiteSpace(path))
                    path = mRecordFile;
                DeleteTXT(path);
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(obj);
                }
                return true;
            }
            catch (Exception ex)
            {
                ShowToast("设置信息出现了异常");
                return false;
            }

        }
        /// <summary>
        /// 删除文件
        /// </summary>
        protected internal void DeleteTXT(string path="")
        {
            Java.IO.File file = new Java.IO.File(dir, "sunits.txt");
            if (file.Exists())
            {
                file.Delete();
            }
        }
        #endregion
        #region 创建悬浮框
        /// <summary>
        /// 创建弹层
        /// </summary>
        protected void createFloatView()
        {
            string msg = "";
            if (!IsFirst)
            {
                msg = "首次运行，加载时间较长";
            }
            UserDialogs.Instance.ShowLoading(msg, MaskType.Black);
        }
        /// <summary>
        /// 关闭弹层
        /// </summary>
        protected void CloseFloatWindow()
        {
            UserDialogs.Instance.HideLoading();
        }
        #endregion

        #region 日志
        public async Task SendLog(string mess)
        {
            try
            {
                Get(url + "/api/Log/SetLogInfo?mess=【POS机】" + mess, "");
            }
            catch (Exception ex)
            {
                RunOnUi(() => { ShowAlert("日志书写错误"); });
            }

        }
        #endregion

        #region 支付
        protected SalesOrder _salesOrder;//当前订单
        protected int _orderType;//当前支付类型 1扫码 0银联
        protected int _orderRefundType;//当前退款类型 1扫码 2银联
        protected int _scanType;//当前扫描类型 1.支付  2退款 3结算
        //支付金额
        protected decimal mhtOrderAmt;
        //支付订单号
        protected string mhtOrderNo;
        //当前单号类型：1-SO：2-RE
        protected string mOrderType;
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
            try
            {
                SendLog("订单号：" + mhtOrderNo + "进入CollectionCallback回调，支付结果为：" + transStatus + "&时间=" + DateTime.Now.ToString());
                var random = new Random().Next(1000, 9999);
                var amt = decimal.Round(decimal.Parse(mhtOrderAmt.ToString()), 2);
                var mhtAmt = (amt * 100).ToString();
                var mhtReserved = "";
                switch (mOrderType)
                {
                    case "RE":
                        mhtReserved = "Recepit";
                        break;
                    case "SO":
                        mhtReserved = "POSSaleOrder";
                        break;
                    default:
                        break;
                }
                var payChannelType = 14;
                if (pay_tp == "1")
                    payChannelType = 13;
                if (pay_tp == "2")
                    payChannelType = 12;
                var str = "payChannelType=" + payChannelType + "&transStatus=" + transStatus + "&mhtReserved=" + mhtReserved + "&Refernumber=" + refernumber + "&mhtOrderAmt=" + mhtAmt + "&mhtOrderNo=" + (mhtOrderNo + random.ToString()) + "&nowPayOrderNo=" + mhtOrderNo + "&payType=" + (_orderType == 0 ? "4" : "3") + "&payTypeName=" + (_orderType == 0 ? "POS银联支付" : "POS扫码支付");
                //var json = JsonConvert.DeserializeObject(str);
                SendLog("开始访问支付回调接口：" + mhtOrderNo + "进入CollectionCallback回调，str为：" + str + "&时间=" + DateTime.Now.ToString());
                var result = await PostObj(webpay + "/AggregatePay/PayBackNotify", str);
                if (result)
                {
                    this.RunOnUi(() =>
                    {
                        this.ShowAlert("同步零售系统成功");
                    });
                }
                else
                {
                    this.RunOnUi(() =>
                    {
                        this.ShowAlert("同步零售系统失败！！");
                    });
                }
            }
            catch (Exception ex)
            {
                SendLog("支付回调出现异常！" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("支付回调出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

        }
        /// <summary>
        /// 支付中转
        /// </summary>
        /// <param name="resultCode"></param>
        /// <param name="pay_tp"></param>
        /// <param name="reason"></param>
        public void ActivityPay(Result resultCode, string pay_tp, string reason, string refernumber)
        {
            try
            {
                SendLog("进入支付中转switch：resultCode：" + resultCode + "&pay_tp=" + pay_tp + "reason=" + reason + "&时间=" + DateTime.Now.ToString());
                switch ((int)resultCode)
                {
                    // 支付成功
                    case -1:
                        // TODO:
                        this.ShowAlert("支付成功", false);
                        if (pay_tp != "0")
                        {
                            createFloatView();
                            Task.Run(PayPrinting);
                            //PayPrinting();
                        }
                        var t=CollectionCallback("A001", pay_tp, refernumber);
                        t.Wait();
                        ShowActivity<MainActivity>();
                        break;

                    // 支付取消
                    case 0:

                        if (reason != null)
                        {
                            // TODO:
                            this.ShowAlert("支付取消", false);
                        }
                        break;
                    case -2:
                        //交易失败
                        if (reason != null)
                        {
                            // TODO: 
                            this.ShowAlert("交易失败!!" + reason, false);
                            CollectionCallback("A002", pay_tp);
                        }
                        break;

                    default:
                        // TODO:
                        break;

                }
            }
            catch (Exception ex)
            {
                SendLog("支付中转出现异常！" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("支付中转出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

        }
        /// <summary>
        /// 支付打印
        /// </summary>
        public async Task PayPrinting()
        {
            try
            {
                Intent intent = new Intent();
                intent.SetComponent(componet);
                Bundle bundle = new Bundle();
                bundle.PutString("msg_tp", "0200");
                bundle.PutString("pay_tp", "" + _orderType);
                bundle.PutString("proc_tp", "00");
                bundle.PutString("proc_cd", "700007");//扫码支付660000  //银联支付 000000  //交易处理码需要与支付方式联动
                //bundle.PutString("order_no", mhtOrderNo);
                bundle.PutString("appid", "com.companyname.sunits.pay");
                bundle.PutString("time_stamp", DateTime.Now.ToString("yyyyMMddhhmmss"));
                bundle.PutString("order_info", "");
                SendLog("准备进入支付打印接口：bundle" + JsonConvert.SerializeObject(bundle) + "&时间=" + DateTime.Now.ToString());
                intent.PutExtras(bundle);
                this.StartActivityForResult(intent, 4);
            }
            catch (Exception ex)
            {
                SendLog("支付成功打印出现异常！" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("支付成功打印出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }
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

        #region 检测设备
        public bool Check()
        {
            try
            {
                var ORjson = ReadTXT();
                var OR = JsonConvert.DeserializeObject<DatabaseTXT>(ORjson);
                if (string.IsNullOrWhiteSpace(OR.InvoiceCode))
                {
                    this.RunOnUi(() =>
                    {
                        this.ShowAlert("请先设置设备");
                    });
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                this.RunOnUi(() =>
                {
                    this.ShowAlert("请先设置设备");
                });
                return false;
            }
        }

        public async Task DisplayCamera()
        {
            bool canUse = true;
            Camera mCamera = null;
            try
            {
                // TODO camera驱动挂掉,处理??    
                mCamera = Camera.Open();
            }
            catch (Exception e)
            {
                canUse = false;
            }
            if (canUse)
            {
                mCamera.Release();
                //mCamera.SetPreviewDisplay(null);
                mCamera = null;
            }
        }
        #endregion
    }
}