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
   public class Pay: BaseActivity
    {
        #region 支付

        /// <summary>
        /// 支付
        /// </summary>
        public void Collection(SalesOrder salesOrder)
        {
            try
            {
                //createFloatView();
                new Log().SendLog("开始支付订单号：" + salesOrder.SubSaleNo + "&时间=" + DateTime.Now.ToString());
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
                new Log().SendLog("准备进入支付接口：bundle" + JsonConvert.SerializeObject(bundle) + "&时间=" + DateTime.Now.ToString());

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
    }
}