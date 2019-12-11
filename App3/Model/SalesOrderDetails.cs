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
   public class SalesOrderDetails
    {
        /// <summary>
        /// 条码
        /// </summary>
        public string Barcode { get; set; }
        /// <summary>
        /// 物料描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 物料ID
        /// </summary>
        public int CodeID { get; set; }
        /// <summary>
        /// 钱
        /// </summary>
        public decimal Money { get; set; }
        /// <summary>
        /// 当前数量
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 系统
        /// </summary>
        public string sysKey { get; set; }
    }
}