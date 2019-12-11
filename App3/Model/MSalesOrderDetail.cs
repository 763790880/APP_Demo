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
   public class MSalesOrderDetail
    {
        #region Model
        private int _tb_salesorderdetail_id;
        private int _tb_salesorder_id;
        private int _tb_salessuborder_id;
        private int _tb_material_id;
        private string _materialcode;
        private string _tempmaterialcode;
        private int? _tb_materialsuit_id;
        private int _saleqnty = 1;
        private decimal _saleprice = 0M;
        private decimal _oldSalePrice = 0M;
        private decimal _amount = 0M;
        private int _outqnty = 0;
        private decimal _incomeamount = 0M;
        private decimal _invoiceamount = 0M;
        private decimal _bonusrate = 0M;
        private string _remarks;
        private string _projectno;
        private string _repairno;
        private string _business;
        private string _brand;
        private string _creator;
        private DateTime? _createdate;
        private string _lastediter;
        private DateTime? _lasteditdate;
        private string _r3saleno = "0";
        private DateTime? _r3saledate;
        private decimal? _commision_extra = 0M;
        private decimal? _commision = 0M;
        private string _materialdescription;
        private string _saleby;
        private string _repairby;
        private string _deliverby;
        private int? _activeflg = 1;
        private DateTime _saledate;
        private int _saletype = 0;
        private string _redinvoicereason;
        private int? _cancreater3sale = 0;
        private decimal _tempcost = 0M;
        private decimal _actualcost = 0M;
        private string _ticketnumber;
        private int _old_salesorderdetail_id;
        private decimal? _materialowestsellprice = 0M;
        private string _sunitsmaterialcode;
        private decimal? _tempmediaprice = 0M;
        private decimal? _templowestsellprice = 0M;
        private int? _isservice = 0;
        private int? _salesClass = 0;
        private string _contractNO;
        /// <summary>
        /// 
        /// </summary>
        public int tb_SalesOrderDetail_Id
        {
            set { _tb_salesorderdetail_id = value; }
            get { return _tb_salesorderdetail_id; }
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
        public int tb_SalesSubOrder_Id
        {
            set { _tb_salessuborder_id = value; }
            get { return _tb_salessuborder_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int tb_Material_Id
        {
            set { _tb_material_id = value; }
            get { return _tb_material_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialCode
        {
            set { _materialcode = value; }
            get { return _materialcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TempMaterialCode
        {
            set { _tempmaterialcode = value; }
            get { return _tempmaterialcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? tb_MaterialSuit_Id
        {
            set { _tb_materialsuit_id = value; }
            get { return _tb_materialsuit_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SaleQnty
        {
            set { _saleqnty = value; }
            get { return _saleqnty; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal SalePrice
        {
            set { _saleprice = value; }
            get { return _saleprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Amount
        {
            set { _amount = value; }
            get { return _amount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int OutQnty
        {
            set { _outqnty = value; }
            get { return _outqnty; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal IncomeAmount
        {
            set { _incomeamount = value; }
            get { return _incomeamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal InvoiceAmount
        {
            set { _invoiceamount = value; }
            get { return _invoiceamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal BonusRate
        {
            set { _bonusrate = value; }
            get { return _bonusrate; }
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
        public string ProjectNo
        {
            set { _projectno = value; }
            get { return _projectno; }
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
        public string Business
        {
            set { _business = value; }
            get { return _business; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Brand
        {
            set { _brand = value; }
            get { return _brand; }
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
        public string R3SaleNo
        {
            set { _r3saleno = value; }
            get { return _r3saleno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? R3SaleDate
        {
            set { _r3saledate = value; }
            get { return _r3saledate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Commision_Extra
        {
            set { _commision_extra = value; }
            get { return _commision_extra; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Commision
        {
            set { _commision = value; }
            get { return _commision; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialDescription
        {
            set { _materialdescription = value; }
            get { return _materialdescription; }
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
        public string RepairBy
        {
            set { _repairby = value; }
            get { return _repairby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DeliverBy
        {
            set { _deliverby = value; }
            get { return _deliverby; }
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
        public DateTime SaleDate
        {
            set { _saledate = value; }
            get { return _saledate; }
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
        public int? CanCreateR3Sale
        {
            set { _cancreater3sale = value; }
            get { return _cancreater3sale; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal TempCost
        {
            set { _tempcost = value; }
            get { return _tempcost; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ActualCost
        {
            set { _actualcost = value; }
            get { return _actualcost; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TicketNumber
        {
            set { _ticketnumber = value; }
            get { return _ticketnumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Old_SalesOrderDetail_Id
        {
            set { _old_salesorderdetail_id = value; }
            get { return _old_salesorderdetail_id; }
        }
        /// <summary>
        /// 最低限价
        /// </summary>
        public decimal? MateriaLowestSellPrice
        {
            set { _materialowestsellprice = value; }
            get { return _materialowestsellprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SunitsMaterialCode
        {
            set { _sunitsmaterialcode = value; }
            get { return _sunitsmaterialcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TempMediaPrice
        {
            set { _tempmediaprice = value; }
            get { return _tempmediaprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TempLowestSellPrice
        {
            set { _templowestsellprice = value; }
            get { return _templowestsellprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsService
        {
            set { _isservice = value; }
            get { return _isservice; }
        }

        /// <summary>
        /// 原销售单价
        /// </summary>
        public decimal OldSalePrice
        {
            set { _oldSalePrice = value; }
            get { return _oldSalePrice; }
        }
        /// <summary>
        /// 销售分类
        /// </summary>
        public int? SalesClass
        {
            set { _salesClass = value; }
            get { return _salesClass; }
        }

        /// <summary>
        /// 合同号
        /// </summary>
        public string ContractNO
        {
            set { _contractNO = value; }
            get { return _contractNO; }
        }

        #endregion Model
    }
}