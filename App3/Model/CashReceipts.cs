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
   public class CashReceipts
    {
        public string ITcode { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public int Orgnization_Id { get; set; }
        public decimal ReceiptAmount { get; set; }
        public string SysKey { get; set; }
    }
}