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
   public class Txndetail
    {
        /// <summary>
        /// 商户号
        /// </summary>
        public string merid { get; set; }
        /// <summary>
        /// 终端号
        /// </summary>
        public string termid { get; set; }
        /// <summary>
        /// 批次号
        /// </summary>
        public string batchno { get; set; }
        /// <summary>
        /// 凭证号
        /// </summary>
        public string systraceno { get; set; }
        /// <summary>
        /// 授权号
        /// </summary>
        public string authcode { get; set; }
        public string orderid_scan { get; set; }
        public string amt { get; set; }
    }
}