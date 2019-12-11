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
   public class MSalesOutDetail
    {
        #region Model
        private int _tb_salesoutdetail_id;
        private int _tb_salesorder_id;
        private int _tb_salesorderdetail_id;
        private string _materialbarcode;
        private string _repairno;
        private string _projectno;
        private string _remarks;
        private string _r3saleno = "0";
        private DateTime? _r3saledate;
        private int _amountflg = 0;
        private decimal _tempcost = 0M;
        private decimal _actualcost = 0M;
        private string _creator;
        private DateTime? _createdate;
        private string _lastediter;
        private DateTime? _lasteditdate;
        private int? _signCode;
        /// <summary>
        /// 
        /// </summary>
        public int tb_SalesOutDetail_Id
        {
            set { _tb_salesoutdetail_id = value; }
            get { return _tb_salesoutdetail_id; }
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
        public int tb_SalesOrderDetail_Id
        {
            set { _tb_salesorderdetail_id = value; }
            get { return _tb_salesorderdetail_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialBarCode
        {
            set { _materialbarcode = value; }
            get { return _materialbarcode; }
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
        public string ProjectNo
        {
            set { _projectno = value; }
            get { return _projectno; }
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
        public int AmountFlg
        {
            set { _amountflg = value; }
            get { return _amountflg; }
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
        /// 标识列（表中不存在）
        /// </summary>
        public int? SignCode
        {
            set { _signCode = value; }
            get { return _signCode; }
        }
        #endregion Model
    }
}