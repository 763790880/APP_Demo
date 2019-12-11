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
   public class MSalesOrder
    {
        #region Model
        private int _tb_salesorder_id;
        private string _repairno;
        private string _salesorderno;
        private int _saleorg_id;
        private string _saleorgcode;
        private int _invoiceorgcode_id;
        private string _invoiceorgcode;
        private string _customertype;
        private string _customernumber;
        private string _customername;
        private string _telno = "";
        private string _mobileno = "";
        private string _company;
        private string _zipcode;
        private string _address;
        private string _invoicetitle;
        private string _servicetype;
        private string _groupname;
        private string _remarks;
        private string _creator;
        private DateTime? _createdate;
        private string _lastediter;
        private DateTime? _lasteditdate;
        private string _email_address;
        private int? _tb_customer_Id;
        private int? _groupOrgId;
        private string _groupOrgCode;
        private string _couponId;
        private string _saleorgname;
        private string _invoiceorgname;
        private string _appOpenId;
        private string _ygUnionId;
        private string _bu;
        private string _mflist;
        private string _wxUnionId;
        private string _customerTypeNew;
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
        public string RepairNo
        {
            set { _repairno = value; }
            get { return _repairno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SalesOrderNo
        {
            set { _salesorderno = value; }
            get { return _salesorderno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SaleOrg_Id
        {
            set { _saleorg_id = value; }
            get { return _saleorg_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SaleOrgCode
        {
            set { _saleorgcode = value; }
            get { return _saleorgcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int InvoiceOrgCode_Id
        {
            set { _invoiceorgcode_id = value; }
            get { return _invoiceorgcode_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InvoiceOrgCode
        {
            set { _invoiceorgcode = value; }
            get { return _invoiceorgcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerType
        {
            set { _customertype = value; }
            get { return _customertype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerNumber
        {
            set { _customernumber = value; }
            get { return _customernumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CustomerName
        {
            set { _customername = value; }
            get { return _customername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TelNo
        {
            set { _telno = value; }
            get { return _telno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MobileNo
        {
            set { _mobileno = value; }
            get { return _mobileno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Company
        {
            set { _company = value; }
            get { return _company; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZipCode
        {
            set { _zipcode = value; }
            get { return _zipcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InvoiceTitle
        {
            set { _invoicetitle = value; }
            get { return _invoicetitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ServiceType
        {
            set { _servicetype = value; }
            get { return _servicetype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GroupName
        {
            set { _groupname = value; }
            get { return _groupname; }
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
        /// 邮件地址
        /// </summary>
        public string email_address
        {
            set { _email_address = value; }
            get { return _email_address; }
        }
        /// <summary>
        /// 客户id
        /// </summary>
        public int? tb_Customer_Id
        {
            set { _tb_customer_Id = value; }
            get { return _tb_customer_Id; }
        }
        /// <summary>
        /// 业务组id
        /// </summary>
        public int? GroupOrgId
        {
            set { _groupOrgId = value; }
            get { return _groupOrgId; }
        }
        /// <summary>
        /// 业务组编号
        /// </summary>
        public string GroupOrgCode
        {
            set { _groupOrgCode = value; }
            get { return _groupOrgCode; }
        }
        /// <summary>
        /// 组合卡券id
        /// </summary>
        public string CouponId
        {
            set { _couponId = value; }
            get { return _couponId; }
        }

        /// <summary>
        /// 达成站名称
        /// </summary>
        public string SaleOrgName
        {
            set { _saleorgname = value; }
            get { return _saleorgname; }
        }

        /// <summary>
        /// 开票站名称
        /// </summary>
        public string InvoiceOrgName
        {
            set { _invoiceorgname = value; }
            get { return _invoiceorgname; }
        }

        /// <summary>
        /// 移动openId
        /// </summary>
        public string AppOpenId
        {
            set { _appOpenId = value; }
            get { return _appOpenId; }
        }

        /// <summary>
        /// 阳光唯一ID
        /// </summary>
        public string YgUnionId
        {
            set { _ygUnionId = value; }
            get { return _ygUnionId; }
        }

        /// <summary>
        /// BU
        /// </summary>
        public string BU
        {
            set { _bu = value; }
            get { return _bu; }
        }

        /// <summary>
        /// 物料分类集合
        /// </summary>
        public string Mflist
        {
            set { _mflist = value; }
            get { return _mflist; }
        }

        /// <summary>
        /// UnionId
        /// </summary>
        public string WxUnionId
        {
            set { _wxUnionId = value; }
            get { return _wxUnionId; }
        }

        /// <summary>
        /// 客户类型（原客户类型更改为销售类型）
        /// </summary>
        public string CustomerTypeNew
        {
            set { _customerTypeNew = value; }
            get { return _customerTypeNew; }
        }
        #endregion Model
    }
}