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
    public class DatabaseTXT
    {
        public int InvoiceID { get;set;}
        public string InvoiceCode { get; set; }
        public string InvoiceName { get; set; }
        public int GroupID { get; set; }
        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string Merid { get; set; }
        public string Termid { get; set; }
    }
}