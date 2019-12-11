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

namespace App3.Model
{
   public class MSalesSubOrder
    {
        #region Model
        private int _tb_salessuborder_id;
        private int _tb_salesorder_id;
        private string _subsaleno;
        private DateTime _saledate;
        private string _saleby;
        private string _remarks;
        private string _creator;
        private DateTime? _createdate;
        private string _lastediter;
        private DateTime? _lasteditdate;
        private int? _activeflg = 1;
        private byte[] _subsalenoimg;
        private int _saletype = 0;
        private string _redinvoicereason;
        private int? _approvalstatus = 0;
        private string _approver;
        private DateTime? _approvalttime;
        private int? _invoicestatustwo = 0;
        private string _invoicetortwo;
        private DateTime? _invoicetimetwo;
        private string _invoiceremarktwo;
        private int? _invoicestatus = 0;
        private string _invoicetor;
        private DateTime? _invoicetime;
        private string _invoiceremark;
        private int? _istwocheck = 0;
        private int? _vasapprovalstatus = 0;
        private string _vasapprover;
        private DateTime? _vasapprovertime;
        private string _vasremark;
        private byte[] _subsalenoqrcodeimg;
        private int? _smbapprovalstatus = 0;
        private int? _vasnewapprovalstatus = 0;
        private int? _overinvoicestatus = 0;
        private decimal? _readypay = 0M;
        private decimal? _payment = 0M;
        private DateTime? _servicestarttime;
        private DateTime? _serviceendtime;
        private int? _fromType;
        private decimal? _postage;
        private string _oldSubOrderNo;
        private string _fromOrderNo;
        private int? _onlinepay = 0;
        /// <summary>
        /// 
        /// </summary>
        public int tb_SalesSubOrder_Id
        {
            set { _tb_salessuborder_id = value; }
            get { return _tb_salessuborder_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int tb_SalesOrder_Id
        {
            set { _tb_salesorder_id = value; }
            get { return _tb_salesorder_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SubSaleNo
        {
            set { _subsaleno = value; }
            get { return _subsaleno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime SaleDate
        {
            set { _saledate = value; }
            get { return _saledate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SaleBy
        {
            set { _saleby = value; }
            get { return _saleby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remarks
        {
            set { _remarks = value; }
            get { return _remarks; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Creator
        {
            set { _creator = value; }
            get { return _creator; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LastEditer
        {
            set { _lastediter = value; }
            get { return _lastediter; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? LastEditDate
        {
            set { _lasteditdate = value; }
            get { return _lasteditdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ActiveFlg
        {
            set { _activeflg = value; }
            get { return _activeflg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public byte[] SubSaleNoImg
        {
            set { _subsalenoimg = value; }
            get { return _subsalenoimg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SaleType
        {
            set { _saletype = value; }
            get { return _saletype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RedInvoiceReason
        {
            set { _redinvoicereason = value; }
            get { return _redinvoicereason; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ApprovalStatus
        {
            set { _approvalstatus = value; }
            get { return _approvalstatus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Approver
        {
            set { _approver = value; }
            get { return _approver; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ApprovalTtime
        {
            set { _approvalttime = value; }
            get { return _approvalttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? InvoiceStatusTwo
        {
            set { _invoicestatustwo = value; }
            get { return _invoicestatustwo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InvoicetorTwo
        {
            set { _invoicetortwo = value; }
            get { return _invoicetortwo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? InvoiceTimeTwo
        {
            set { _invoicetimetwo = value; }
            get { return _invoicetimetwo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InvoiceRemarkTwo
        {
            set { _invoiceremarktwo = value; }
            get { return _invoiceremarktwo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? InvoiceStatus
        {
            set { _invoicestatus = value; }
            get { return _invoicestatus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Invoicetor
        {
            set { _invoicetor = value; }
            get { return _invoicetor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? InvoiceTime
        {
            set { _invoicetime = value; }
            get { return _invoicetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InvoiceRemark
        {
            set { _invoiceremark = value; }
            get { return _invoiceremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? isTwoCheck
        {
            set { _istwocheck = value; }
            get { return _istwocheck; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? VASApprovalStatus
        {
            set { _vasapprovalstatus = value; }
            get { return _vasapprovalstatus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VASApprover
        {
            set { _vasapprover = value; }
            get { return _vasapprover; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? VASApproverTime
        {
            set { _vasapprovertime = value; }
            get { return _vasapprovertime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VASRemark
        {
            set { _vasremark = value; }
            get { return _vasremark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public byte[] SubSaleNoQRCodeImg
        {
            set { _subsalenoqrcodeimg = value; }
            get { return _subsalenoqrcodeimg; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? SMBApprovalStatus
        {
            set { _smbapprovalstatus = value; }
            get { return _smbapprovalstatus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? VASNewApprovalStatus
        {
            set { _vasnewapprovalstatus = value; }
            get { return _vasnewapprovalstatus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? OverInvoiceStatus
        {
            set { _overinvoicestatus = value; }
            get { return _overinvoicestatus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ReadyPay
        {
            set { _readypay = value; }
            get { return _readypay; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PayMent
        {
            set { _payment = value; }
            get { return _payment; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ServiceStartTime
        {
            set { _servicestarttime = value; }
            get { return _servicestarttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ServiceEndTime
        {
            set { _serviceendtime = value; }
            get { return _serviceendtime; }
        }
        /// <summary>
        /// 来源标签
        /// </summary>
        public int? FromType
        {
            set { _fromType = value; }
            get { return _fromType; }
        }
        /// <summary>
        /// 邮费
        /// </summary>
        public decimal? Postage
        {
            set { _postage = value; }
            get { return _postage; }
        }
        /// <summary>
        /// 原子单号
        /// </summary>
        public string OldSubOrderNo
        {
            set { _oldSubOrderNo = value; }
            get { return _oldSubOrderNo; }
        }
        /// <summary>
        /// 来源单号
        /// </summary>
        public string FromOrderNo
        {
            set { _fromOrderNo = value; }
            get { return _fromOrderNo; }
        }
        /// <summary>
        /// 已在线支付标识（0：未支付 1：已支付）
        /// </summary>
        public int? OnlinePay
        {
            set { _onlinepay = value; }
            get { return _onlinepay; }
        }

        #endregion Model
    }
}