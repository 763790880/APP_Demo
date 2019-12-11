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
   public class MSalesViews
    {
        public MSalesOrder MSalesOrder { get; set; }
        public List<MSalesOrderDetail> LMSalesOrderDetail { get; set; }
        public MSalesSubOrder MSalesSubOrder { get; set; }
        public List<MSalesOutDetail> MSalesOutDetail { get; set; }
        /// <summary>
        /// 系统key
        /// </summary>
        public string sysKey { get; set; }
    }
}