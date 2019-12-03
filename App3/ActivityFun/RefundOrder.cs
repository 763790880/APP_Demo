using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App3.Model;
using Newtonsoft.Json;

namespace App3.ActivityFun
{
   public class RefundOrder:BaseActivity
    {
        #region 退款
        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="salesOrder"></param>
        public void Refund(SalesOrder salesOrder)
        {
            try
            {
                new Log().SendLog("开始退款订单号：" + salesOrder.SubSaleNo + "&时间=" + DateTime.Now.ToString());
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
                new Log().SendLog("准备进入退款接口：bundle" + JsonConvert.SerializeObject(bundle) + "&时间=" + DateTime.Now.ToString());
                intent.PutExtras(bundle);
                this.StartActivityForResult(intent, 2);
            }
            catch (Exception ex)
            {
                new Log().SendLog("退款出现异常！" + ex.Message);
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
                            new Log().SendLog("订单号：" + mhtOrderNo + "退款回调失败，失败原因：" + msg + "&时间=" + DateTime.Now.ToString());
                            this.ShowAlert("退款成功，回调失败：" + msg, false);
                        }
                        break;

                    // 支付取消
                    case 0:

                        if (reason != null)
                        {
                            new Log().SendLog("订单号：" + mhtOrderNo + "退款取消!&时间=" + DateTime.Now.ToString());
                            this.ShowAlert("退款取消", false);
                        }
                        break;
                    case -2:
                        //交易失败
                        if (reason != null)
                        {
                            new Log().SendLog("订单号：" + mhtOrderNo + "退款失败!失败原因=" + reason + "&时间=" + DateTime.Now.ToString());
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

                new Log().SendLog("退款中转出现异常！" + ex.Message);
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
            new Log().SendLog("订单号：" + mhtOrderNo + "进入RefundBack退款回调，支付结果为：" + transStatus + "&时间=" + DateTime.Now.ToString());
            try
            {
                string msg = "";
                var user = new Users();
                user.Password = Password;
                user.UserName = UserName;
                var tokenInfo = await Post<Users>(url + "/api/Token/Login", user);
                if (string.IsNullOrWhiteSpace(tokenInfo))
                {
                    new Log().SendLog("订单号：" + mhtOrderNo + "Token获取失败！，Password：" + user.Password + "&UserName" + user.UserName + "&时间=" + DateTime.Now.ToString());
                    msg = "Token获取失败！";
                    return msg;
                }
                new Log().SendLog("开始解析Token，tokenInfo：" + tokenInfo + "&时间=" + DateTime.Now.ToString());
                TokenInfo token = ByteToModel<TokenInfo>(tokenInfo);
                new Log().SendLog("Token解析成功，tokenInfo：" + tokenInfo + "&时间=" + DateTime.Now.ToString());
                new Log().SendLog("准备开始退款回调，时间=" + DateTime.Now.ToString());
                var _salesOrder = await Get(url + "/api/SalesOrder/ReturnSalesOrderPOS?SubSalesNo=" + mhtOrderNo + "&Account=pos机器&sysKey=" + SYSKEY, token.Token);//token.Token
                new Log().SendLog("退款回调成功，时间=" + DateTime.Now.ToString());
                var result = ByteToModel<ResultInfo>(_salesOrder);
                new Log().SendLog("退款回调成功，解析结果result=" + result + "&时间" + DateTime.Now.ToString());
                if (result == null)
                {
                    msg = "销售单获取失败！";
                    return msg;
                }
                if (result.ResultCode != 1)
                {
                    new Log().SendLog("退款回调出现问题，ResultMess=" + result.ResultMess + "&时间" + DateTime.Now.ToString());
                    msg = result.ResultMess;
                    return msg;
                }
                //var obj = (JavaList<SalesOrder>)result.Data;
                return msg;
            }
            catch (Exception ex)
            {
                new Log().SendLog("退款回调异常");
                return "退款回调出现异常-请联系管理员";
            }
        }
        #endregion
    }
}