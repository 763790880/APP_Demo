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
using Android.OS;
using Android.Runtime;
using Android.Telephony;
using Android.Util;
using Android.Views;
using Android.Widget;
using App3.Model;
using Newtonsoft.Json;
using RestSharp;

namespace App3
{
    public class BaseActivity : Activity
    {
        public void ShowActivity<T>() where T : Activity
        {
            Intent intent = new Intent(this, typeof(T));
            StartActivity(intent);
        }
        public void OpenService<T>() where T : Service
        {
            Intent intent = new Intent(this, typeof(T));
            StartService(intent);
        }

        #region  各种提示信息
        public void ShowToast(string msg)
        {
            Toast.MakeText(this, msg, ToastLength.Short).Show();
        }

        private AlertDialog dialog;
        public AlertDialog InitDialog(string msg, Action<AlertDialog> comfirmCallback, Action<AlertDialog> cancelCallback,bool IsShow)
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
        public void ShowAlert(string msg, bool IsShow=true, Action<AlertDialog> comfirmCallback = null, Action<AlertDialog> cancelCallback = null)
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
        public void CancelAlert()
        {
            if (dialog != null && dialog.IsShowing)
            {
                dialog.Cancel();
            }
        }
        public void NotifyMessage(string message, string title = "消息")
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
        public static Java.Lang.String JaveString(string str)
        {
            return new Java.Lang.String("您有新短消息，请注意查收！");
        }
        #endregion

        #region 寻找资源
        public T FindControl<T>(string name) where T : View
        {
            return FindViewById<T>(GetCode(name));
        }

        public T FindControl<T>(string name, Action clickCallBack) where T : View
        {
            View view = FindViewById<T>(GetCode(name));
            view.Click += (s, e) =>
            {
                clickCallBack();
            };
            return FindViewById<T>(GetCode(name));
        }

        public int GetCode(string name)
        {
            var R = this.Resources;
            var code = (typeof(Resource.Id)).GetFields().FirstOrDefault(f => f.Name == name).GetValue(R);
            return (int)code;
        }
        #endregion

        #region 异步调用
        public void AsyncLoad(Action action)
        {
            IAsyncResult result = action.BeginInvoke((iar) =>
            {
            }, null);
        }
        public void AsyncLoad(Action action, Action callback)
        {
            IAsyncResult result = action.BeginInvoke((iar) =>
            {
                this.RunOnUiThread(callback);
            }, null);
        }

        public void AsyncLoad<T>(Action<T> action, T para, Action callback)
        {
            IAsyncResult result = action.BeginInvoke(para, (iar) =>
            {
                this.RunOnUiThread(callback);
            }, null);
        }
        public void RunOnUi(Action action)
        {
            ((BaseActivity)this).RunOnUiThread(() => { action(); });//回UI线程
        }
        #endregion

        #region 获取数据
        public void GetRest<T>(string url, Action<T> callback)
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
        public static async System.Threading.Tasks.Task<byte[]> GetBytes(string path)
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
        public static async System.Threading.Tasks.Task<bool> PostObj(string url, object data)
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
                return true;
                //var result = JsonConvert.DeserializeObject<string>(response.Content);
                //if (result == "success=Y")
                //{
                    
                //}
                //return false;
            }
            else
            {
                return false;
            }
        }
        public static async System.Threading.Tasks.Task<string> Post<T>(string url, T user)
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
        public static async System.Threading.Tasks.Task<string> Get(string url,string token)
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
        public static string ByteToString(byte[] buff)
        {
            string str = Encoding.UTF8.GetString(buff);
            return str;
        }
        public static T ByteToModel<T>(byte[] buff)
        {
            T obj;
            using (MemoryStream ms = new MemoryStream(buff))
            {
                IFormatter iFormatter = new BinaryFormatter();
                obj = (T)iFormatter.Deserialize(ms);
            }
            return obj;
        }
        public static T ByteToModel<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
        //public ImageView ByteToImage(byte[] buff)
        //{
        //    String teststr = String.Format("Size%d--No.1:%02X,Last:%02X", buff.Length, tempbyte[0], tempbyte[buff.Length - 1]);
        //    tv_Receive.append(teststr);

        //    Bitmap bm_finger = getPicFromBytes(tempbyte, null);
        //    ((ImageView)findViewById(R.id.IV_fingerprint)).setImageBitmap(bm_finger);
        //}
        #endregion

        #region 终止
        public void Close()
        {
            Finish();
            Process.KillProcess(Android.OS.Process.MyPid());
        }
        #endregion 

    }
}