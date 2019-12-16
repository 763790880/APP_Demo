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
using Java.Lang;

namespace App3.Model
{
    [Serializable]
    public class Engineer
    {
        public string Account { get; set; }
        public string UserName { get; set; }
        public string ORName { get; set; }
        public int ORID { get; set; }
        public string ORCode { get; set; }

        public override string ToString()
        {
            return Account;
        }
    }
}