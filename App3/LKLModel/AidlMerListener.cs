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
using Com.Lkl.Cloudpos.Mdx.Aidl.System;

namespace App3.LKLModel
{
    public class AidlMerListener : AidlMerListenerStub
    {
        public string mesP { get; set; }
        public string mesP1 { get; set; }
        public override void OnFail(int p0)
        {
            throw new NotImplementedException();
        }

        public override void OnSuccess(string p0, string p1)
        {
            mesP = p0;
            mesP1 = p1;
        }
    }
}