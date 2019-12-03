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
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using App3.Model;
using Com.Lkl.Cloudpos.Mdx.Aidl;
using Com.Lkl.Cloudpos.Mdx.Aidl.System;
using Newtonsoft.Json;
using RestSharp;
using ZXing.Mobile;

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
        internal static RestClient Instance(string url)
        {
            var restClient = new RestClient(url)
            {
                Timeout = 50000,
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
                text = "这个东西不存在：："; 
            }
            text = System.IO.File.ReadAllText(mRecordFile);
            return text;
        }
        /// <summary>
        /// 创建文件
        /// </summary>
        protected internal void CreateTXT(string obj,string path="")
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
            }
            catch (Exception ex)
            {
                ShowToast("设置信息出现了异常");
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
        protected void createFloatView()
        {
            string msg = "";
            if (!IsFirst)
            {
                msg = "首次运行，加载时间较长";
            }
            UserDialogs.Instance.ShowLoading(msg, MaskType.Black);
        }
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
    }
}