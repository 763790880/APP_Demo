using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ZXing;
using ZXing.Mobile;

namespace App3.Comment
{
    class ScanBase : MobileBarcodeScannerBase
    {
        public override bool IsTorchOn => throw new NotImplementedException();

        public override void AutoFocus()
        {
            throw new NotImplementedException();
        }

        public override void Cancel()
        {
            throw new NotImplementedException();
        }

        public override void PauseAnalysis()
        {
            throw new NotImplementedException();
        }

        public override void ResumeAnalysis()
        {
            throw new NotImplementedException();
        }

        public override Task<ZXing.Result> Scan(MobileBarcodeScanningOptions options)
        {
            throw new NotImplementedException();
        }

        public override void ScanContinuously(MobileBarcodeScanningOptions options, Action<ZXing.Result> scanHandler)
        {
            throw new NotImplementedException();
        }

        public override void ToggleTorch()
        {
            throw new NotImplementedException();
        }

        public override void Torch(bool on)
        {
            throw new NotImplementedException();
        }
    }
}