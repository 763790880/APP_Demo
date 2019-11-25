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
    [Serializable]
    public class SalesOrderInfo: ResultInfo
    {
        /// <summary>
        /// 操作的其他结果集
        /// </summary>
        public SalesOrder Data { get; set; }
    }
}