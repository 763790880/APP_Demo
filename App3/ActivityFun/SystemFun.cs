using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace App3.ActivityFun
{
   public class SystemFun:BaseActivity
    {
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
                Task t = new Task(new ScanOrder().AutoScan);
                t.Start();
            };
            Button btnHttp = this.FindControl<Button>("btnUnion");
            btnHttp.Click += (s, e) =>
            {
                createFloatView();
                textPrompt.Text = "银行卡支付，请将销售订单二维码放入框内";
                _orderType = 0;//支付类型
                _scanType = 1;//扫描类型
                Task t = new Task(new ScanOrder().AutoScan);
                t.Start();
            };
            Button btnRefund = this.FindControl<Button>("btnRefund");//退款
            btnRefund.Click += (s, e) =>
            {
                createFloatView();
                textPrompt.Text = "退款扫描，请将销售订单二维码放入框内";
                _scanType = 2;//扫描类型
                //AutoScan();
                Task t = new Task(new ScanOrder().AutoScan);
                t.Start();
            };
            Button btnSettlement = this.FindControl<Button>("btnSettlement");//结算
            btnSettlement.Click += (s, e) =>
            {
                CreateTXT("我是设置得值其中包含了很多得数据");
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
                new Log().SendLog("开始结算!&时间=" + DateTime.Now.ToString());
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
                new Log().SendLog("准备进入结算接口：bundle" + JsonConvert.SerializeObject(bundle) + "&时间=" + DateTime.Now.ToString());
                intent.PutExtras(bundle);
                this.StartActivityForResult(intent, 3);
            }
            catch (Exception ex)
            {
                new Log().SendLog("结算出现异常！" + ex.Message);
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
    }
}