using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
   public class GetOrder:BaseActivity
    {
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
                    new Log().SendLog("解析Token失败！！&时间=" + DateTime.Now.ToString());
                    return new Tuple<SalesOrder, string>(null, token.Message);
                }
                var payType = _orderType == 0 ? 2 : 1;
                new Log().SendLog("开始获取获取销售单号，tokenInfo：" + token.Token + "&url=" + url + "/api/SalesOrder/GetSalesOrderDetailBySalesOrderNO?salesOrder=" + orderNo + "&payType=" + payType + "&scanType=" + _scanType + "&时间=" + DateTime.Now.ToString());
                var _salesOrder = Get(url + "/api/SalesOrder/GetSalesOrderDetailBySalesOrderNO?salesOrder=" + orderNo + "&payType=" + payType + "&scanType=" + _scanType, token.Token);//token.Token
                new Log().SendLog("结束过去销售单号，_salesOrder：" + _salesOrder + "&时间=" + DateTime.Now.ToString());
                new Log().SendLog("开始解析_salesOrder！&时间=" + DateTime.Now.ToString());
                var result = ByteToModel<SalesOrderInfo>(_salesOrder.Result);
                new Log().SendLog("解析_salesOrder结束！&时间=" + DateTime.Now.ToString());
                if (result == null)
                {
                    msg = "销售单获取失败！";
                    new Log().SendLog("销售单获取失败！！&时间=" + DateTime.Now.ToString());
                    return new Tuple<SalesOrder, string>(null, msg);
                }
                if (result.ResultCode != 1)
                {
                    msg = result.ResultMess;
                    new Log().SendLog("获取销售单出现问题！！ResultMess:" + result.ResultMess + "&时间=" + DateTime.Now.ToString());
                    return new Tuple<SalesOrder, string>(null, msg);
                }
                //var obj = (JavaList<SalesOrder>)result.Data;
                return new Tuple<SalesOrder, string>((SalesOrder)result.Data, msg);
            }
            catch (Exception ex)
            {
                new Log().SendLog("获取销售单号APP出现Exception错误");
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
                    new Log().SendLog("解析Token失败！！&时间=" + DateTime.Now.ToString());
                    return new Tuple<Receipt, string>(null, token.Message);
                }
                new Log().SendLog("开始获取获取定金单号，tokenInfo：" + token.Token + "&url=" + url + "/api/SaleReceipt/GetSaleReceiptDeposit?ReceiptSubSaleNo=" + ReceiptSubSaleNo + "&sysKey=" + SYSKEY + "&时间=" + DateTime.Now.ToString());
                var _receiptSubSaleNo = Get(url + "/api/SaleReceipt/GetSaleReceiptDeposit?ReceiptSubSaleNo=" + ReceiptSubSaleNo + "&sysKey=" + SYSKEY, token.Token).Result;//token.Token
                new Log().SendLog("结束过去定金单号，_salesOrder：" + _salesOrder + "&时间=" + DateTime.Now.ToString());
                new Log().SendLog("开始解析_receiptSubSaleNo！&时间=" + DateTime.Now.ToString());
                var result = ByteToModel<ReceiptInfo>(_receiptSubSaleNo);
                new Log().SendLog("解析_receiptSubSaleNo结束！&时间=" + DateTime.Now.ToString());
                if (result == null)
                {
                    msg = "定金单获取失败！";
                    new Log().SendLog("定金单获取失败！！&时间=" + DateTime.Now.ToString());
                    return new Tuple<Receipt, string>(null, msg);
                }
                if (result.ResultCode != 1)
                {
                    msg = result.ResultMess;
                    new Log().SendLog("获取定金单出现问题！！ResultMess:" + result.ResultMess + "&时间=" + DateTime.Now.ToString());
                    return new Tuple<Receipt, string>(null, msg);
                }
                //var obj = (JavaList<SalesOrder>)result.Data;
                return new Tuple<Receipt, string>((Receipt)result.Data, msg);
            }
            catch (Exception ex)
            {
                new Log().SendLog("获取定金单号APP出现Exception错误");
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
                    new Log().SendLog("获取定金单号Token获取失败！&时间=" + DateTime.Now.ToString());
                    return new TokenInfo() { Message = "Token获取失败！" };
                }
                var payType = _orderType == 0 ? 2 : 1;
                new Log().SendLog("获取定金单号开始解析Token，tokenInfo：" + tokenInfo + "&时间=" + DateTime.Now.ToString());
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
                new Log().SendLog("准备进入ManageRE方法RE单号处理逻辑！ReceiptSubSaleNo=" + ReceiptSubSaleNo + "&时间=" + DateTime.Now.ToString());
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
                        new Pay().Collection(_salesOrder);
                    }
                }
            }
            catch (Exception ex)
            {
                new Log().SendLog("处理RE单号逻辑现异常！" + ex.Message);
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
                new Log().SendLog("准备进入GetSalesOrder方法SO单号处理逻辑！saleOrder=" + saleOrder + "&时间=" + DateTime.Now.ToString());
                var models = GetSalesOrder(saleOrder);
                _salesOrder = models.Item1;
                new Log().SendLog("HandleScanResultAsync方法获取销售单信息！销售单信息=" + JsonConvert.SerializeObject(_salesOrder) + "&时间=" + DateTime.Now.ToString());
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
                                new Log().SendLog("订单号：" + mhtOrderNo + "退款失败，_orderRefundType：" + _orderRefundType + "PayType=" + models.Item1.PayType + "&时间=" + DateTime.Now.ToString());
                            }
                            else if (ctime != ntime)
                            {
                                this.RunOnUi(() => { this.ShowAlert("退款失败，只能退当日", false); });
                            }
                            else
                            {
                                this.createFloatView();
                                new RefundOrder().Refund(models.Item1);
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
                                new Pay().Collection(models.Item1);
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
                new Log().SendLog("处理SO单号逻辑！" + ex.Message);
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