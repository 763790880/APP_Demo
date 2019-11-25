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
    public class SalesOrder
    {
        /// <summary>
        /// 
        /// </summary>
        public string SubSaleNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> ReadyPay { get; set; }
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Nullable<decimal> PayMent { get; set; }
        public Nullable<int> OnlinePay { get; set; }
        public int PayType { get; set; }//支付类型
    }
}