using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using System;
using ZXing.Mobile;

namespace App3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class ScanOrderActivity:BaseActivity
    {
        protected static MobileBarcodeScanningOptions mbs;
        protected MobileBarcodeScanner scanner;
        protected static ImageView ivScanning;
        protected GridLayout gridview;
        // 从上到下的平移动画
        protected static Animation verticalAnimation;
        [Obsolete]
        protected override void OnCreate(Bundle menu)
        {
            Xamarin.Essentials.Platform.Init(this, menu);
            SetContentView(Resource.Layout.CreateOrder);
            base.OnCreate(menu);
            gridview = this.FindControl<GridLayout>("goodsview");
            CreateScan();


        }
        /// <summary>
        /// 创建扫描对象
        /// </summary>
        public void CreateScan()
        {
            try
            {
                scanner = new MobileBarcodeScanner();
                var createOrder = LayoutInflater.FromContext(this).Inflate(Resource.Layout.CreateOrder, null);
                scanner.UseCustomOverlay = true;
                //Button btnCancelScan = zxingOverlay.FindViewById<Button>(Resource.Id.btnCancelScan);//取消扫描
                //btnCancelScan.Click += (s, e) =>
                //{
                //    if (scanner != null)
                //    {
                //        scanner.Cancel();
                //    }
                //};
                //<Button
                //android: id = "@+id/btnCancelScan"
                //android: textAppearance = "?android:textAppearanceMedium"
                //android: layout_width = "fill_parent"
                //android: layout_height = "wrap_content"
                //android: text = "取消扫描"
                //android: textColor = "#ffffffff"
                //android: background = "#aa000000"
                //android: gravity = "center" />
                createOrder.Measure(MeasureSpecMode.Unspecified.GetHashCode(), MeasureSpecMode.Unspecified.GetHashCode());
                scanner.CustomOverlay = createOrder;


                mbs = MobileBarcodeScanningOptions.Default;
                mbs.AssumeGS1 = true;
                mbs.AutoRotate = true;
                mbs.DisableAutofocus = false;
                mbs.PureBarcode = false;
                mbs.TryInverted = true;
                mbs.TryHarder = true;
                mbs.UseCode39ExtendedMode = true;
                mbs.UseFrontCameraIfAvailable = false;
                mbs.UseNativeScanning = true;

                ivScanning = createOrder.FindViewById<ImageView>(Resource.Id.ivScanning);
                // 从上到下的平移动画
                verticalAnimation = new TranslateAnimation(0, 0, 0, 800)
                {
                    Duration = 3000, // 动画持续时间
                    RepeatCount = Animation.Infinite // 无限循环
                };
                verticalAnimation.StartNow();
                // 播放动画
                ivScanning.Animation = verticalAnimation;
                var result = scanner.Scan(this, mbs).Result;
                CreteView(result.Text);
            }
            catch (Exception ex)
            {
                SendLog("创建扫描对象出现异常" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("创建扫描对象出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

        }
        public void CreteView(string val)
        {
            var gridview = this.FindControl<GridLayout>("goodsview");
            TextView text = new TextView(this);
            text.Text = "商品一号";
            gridview.AddView(text);
        }
    }
}