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
   public class ORJavaObj:Java.Lang.Object
    {
        #region Model
        private int _tb_orgnization_id;
        private string _orgnizationnumber;
        private string _orgnizationname;
        private int? _parentorgnizationid;
        private string _orgnizationtype;
        private string _orgnizationdesc;
        private int _isvalid = 1;
        private string _citylevel;
        private DateTime? _createdate;
        private string _creator;
        private DateTime? _lasteditdate;
        private string _lastediter;
        private string _r3companyno;
        private string _financecode;
        private string _8bitcode;
        private int? _invoiceflag;
        private decimal? _usablereserve;
        private decimal? _lockreserve;
        private decimal? _temporaryusablereserve;
        private decimal? _temporarylockreserve;
        private int? _orgnizationrank;
        private decimal? _salesreturnlockreserve;
        private decimal? _tagamount;
        private decimal? _fcstamount;
        private int? _stationlevel;
        private string _tax_no = "";
        private string _organization_full_name;
        private decimal? _tax_rate;
        private int? _tax_type;
        private int? _electronic_invoice_status;
        private int? _paper_generalinvoice_status;
        private int? _paper_specialinvoice_status;
        private int? _storeType;
        private string _province;
        private string _region;
        private string _county;
        private string _provincecode;
        private string _regioncode;
        private string _countycode;
        private string _bacode;
        public string BACode
        {
            set { _bacode = value; }
            get { return _bacode; }
        }
        public string province
        {
            set { _province = value; }
            get { return _province; }
        }
        public string region
        {
            set { _region = value; }
            get { return _region; }
        }
        public string county
        {
            set { _county = value; }
            get { return _county; }
        }
        public string provinceCode
        {
            set { _provincecode = value; }
            get { return _provincecode; }
        }
        public string regioncode
        {
            set { _regioncode = value; }
            get { return _regioncode; }
        }
        public string countycode
        {
            set { _countycode = value; }
            get { return _countycode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int tb_Orgnization_Id
        {
            set { _tb_orgnization_id = value; }
            get { return _tb_orgnization_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OrgnizationNumber
        {
            set { _orgnizationnumber = value; }
            get { return _orgnizationnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OrgnizationName
        {
            set { _orgnizationname = value; }
            get { return _orgnizationname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ParentOrgnizationId
        {
            set { _parentorgnizationid = value; }
            get { return _parentorgnizationid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OrgnizationType
        {
            set { _orgnizationtype = value; }
            get { return _orgnizationtype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OrgnizationDesc
        {
            set { _orgnizationdesc = value; }
            get { return _orgnizationdesc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsValid
        {
            set { _isvalid = value; }
            get { return _isvalid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CityLevel
        {
            set { _citylevel = value; }
            get { return _citylevel; }
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
        public string Creator
        {
            set { _creator = value; }
            get { return _creator; }
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
        public string LastEditer
        {
            set { _lastediter = value; }
            get { return _lastediter; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string R3CompanyNo
        {
            set { _r3companyno = value; }
            get { return _r3companyno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FinanceCode
        {
            set { _financecode = value; }
            get { return _financecode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _8bitCode
        {
            set { _8bitcode = value; }
            get { return _8bitcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? InvoiceFlag
        {
            set { _invoiceflag = value; }
            get { return _invoiceflag; }
        }
        /// <summary>
        /// 可用储备金额度
        /// </summary>
        public decimal? UsableReserve
        {
            set { _usablereserve = value; }
            get { return _usablereserve; }
        }
        /// <summary>
        /// 锁定储备金额度
        /// </summary>
        public decimal? LockReserve
        {
            set { _lockreserve = value; }
            get { return _lockreserve; }
        }
        /// <summary>
        /// 临时可用储备金额度
        /// </summary>
        public decimal? TemporaryUsableReserve
        {
            set { _temporaryusablereserve = value; }
            get { return _temporaryusablereserve; }
        }
        /// <summary>
        /// 临时锁定储备金额度
        /// </summary>
        public decimal? TemporaryLockReserve
        {
            set { _temporarylockreserve = value; }
            get { return _temporarylockreserve; }
        }
        /// <summary>
        /// 组织机构级别
        /// </summary>
        public int? OrgnizationRank
        {
            set { _orgnizationrank = value; }
            get { return _orgnizationrank; }
        }
        /// <summary>
        /// 销售退货临时锁定金额(没有可减
        /// </summary>
        public decimal? SalesReturnLockReserve
        {
            set { _salesreturnlockreserve = value; }
            get { return _salesreturnlockreserve; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TagAmount
        {
            set { _tagamount = value; }
            get { return _tagamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? FcstAmount
        {
            set { _fcstamount = value; }
            get { return _fcstamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? StationLevel
        {
            set { _stationlevel = value; }
            get { return _stationlevel; }
        }
        /// <summary>
        /// 税号
        /// </summary>
        public string tax_no
        {
            set { _tax_no = value; }
            get { return _tax_no; }
        }
        /// <summary>
        /// 机构全称
        /// </summary>
        public string organization_full_name
        {
            set { _organization_full_name = value; }
            get { return _organization_full_name; }
        }
        /// <summary>
        /// 税率
        /// </summary>
        public decimal? tax_rate
        {
            set { _tax_rate = value; }
            get { return _tax_rate; }
        }
        /// <summary>
        /// 纳税类型1-一般纳税人2-小规模纳税人
        /// </summary>
        public int? tax_type
        {
            set { _tax_type = value; }
            get { return _tax_type; }
        }
        /// <summary>
        /// 电子发票开通状态0-否1-是
        /// </summary>
        public int? electronic_invoice_status
        {
            set { _electronic_invoice_status = value; }
            get { return _electronic_invoice_status; }
        }
        /// <summary>
        /// 纸质普通发票开通状态0-否1-是
        /// </summary>
        public int? paper_generalInvoice_status
        {
            set { _paper_generalinvoice_status = value; }
            get { return _paper_generalinvoice_status; }
        }
        /// <summary>
        /// 纸质专用发票开通状态0-否1-是
        /// </summary>
        public int? paper_specialInvoice_status
        {
            set { _paper_specialinvoice_status = value; }
            get { return _paper_specialinvoice_status; }
        }
        /// <summary>
        /// 店面类型（1.正常 2.Top店 3.燎原店）
        /// </summary>
        public int? StoreType
        {
            set { _storeType = value; }
            get { return _storeType; }
        }
        /// <summary>
        /// 法人
        /// </summary>
        public string legalPerson { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public string longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public string latitude { get; set; }
        /// <summary>
        /// 机构分类1-分区 2-站 3-网点
        /// </summary>
        public int? orgClassify { get; set; }
        /// <summary>
        /// 机构详细地址
        /// </summary>
        public string org_address { get; set; }
        #endregion Model
    }
}