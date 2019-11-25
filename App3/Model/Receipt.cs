using System;

namespace App3.Model
{
    [Serializable]
    public class Receipt
    { /// <summary>
      /// 
      /// </summary>
        public int tb_Receipt_Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tb_Orgnization_Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ReceiptNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public System.DateTime ReceiptDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal ReceiptAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> ActionFlg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Creator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LastEditer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> LastEditDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Contact { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ContactTelephone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string UseMemo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal AvailableAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ReceiptType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OldReceiptNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EngineerAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> CashAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> POSAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> CheckAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> RemittanceAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> ReceiptClassify { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> WeiXinAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> AlipayAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NowPayOrderNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PayStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NowReturnOrderNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NowReturnStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> NowReturnTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> PayTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NowPaySubOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> IsSuccAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PosTranCardNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PosSerialNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<System.DateTime> PosTranTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PosReferNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> IsPosSuccAccount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SubSaleNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> AuditStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PaperReceiptNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ReceiptSubSaleNo { get; set; }
        /// <summary>
        /// 是否线上0否1是
        /// </summary>
        public Nullable<int> IsOnline { get; set; }
        /// <summary>
        /// 是否删除0否1是
        /// </summary>
        public byte IsDel { get; set; }
        /// <summary>
        /// 支付类型，0-线下支付，1-现在支付，2-拉卡拉线上支付宝微信支付，3-拉卡拉线上POS支付
        /// </summary>
        public Nullable<byte> payType { get; set; }
        /// <summary>
        /// 支付类型名称
        /// </summary>
        public string payTypeName { get; set; }
    }
}