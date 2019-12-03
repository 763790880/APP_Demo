using System;
using System.Threading.Tasks;
using Android.Content;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using ZXing.Mobile;

namespace App3.ActivityFun
{
    public class ScanOrder:BaseActivity
    {
        #region 扫描获取订单
        /// <summary>
        /// 扫描动画
        /// </summary>
       public void AutoScan()
        {
            try
            {
                if (!IsFirst)
                {
                    var vb = new SystemFun().CheckVersion();
                    if (!vb)
                    {
                        this.RunOnUi(() => { this.ShowAlert("当前版本需要升级", false); });
                        return;
                    }
                    else
                        IsFirst = true;
                }
                verticalAnimation.StartNow();
                // 播放动画
                ivScanning.Animation = verticalAnimation;
                var result = scanner.Scan(this, mbs).Result;
                HandleScanResultAsync(result);
            }
            catch (Exception ex)
            {
                new Log().SendLog("扫描对象出现异常" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("扫描对象出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

        }
        /// <summary>
        /// 创建扫描对象
        /// </summary>
        public void CreateScan()
        {
            try
            {
                scanner = new MobileBarcodeScanner();
                zxingOverlay = LayoutInflater.FromContext(this).Inflate(Resource.Layout.ZxingOverlay, null);
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
                zxingOverlay.Measure(MeasureSpecMode.Unspecified.GetHashCode(), MeasureSpecMode.Unspecified.GetHashCode());
                scanner.CustomOverlay = zxingOverlay;


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

                ivScanning = zxingOverlay.FindViewById<ImageView>(Resource.Id.ivScanning);
                // 从上到下的平移动画
                verticalAnimation = new TranslateAnimation(0, 0, 0, 800)
                {
                    Duration = 3000, // 动画持续时间
                    RepeatCount = Animation.Infinite // 无限循环
                };
            }
            catch (Exception ex)
            {
                new Log().SendLog("创建扫描对象出现异常" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("创建扫描对象出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

        }
        /// <summary>
        /// 扫描回调
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
       public async Task HandleScanResultAsync(ZXing.Result result)
        {
            try
            {
                new Log().SendLog("进入扫描回调HandleScanResultAsync！&时间=" + DateTime.Now.ToString());
                if (result != null && !string.IsNullOrEmpty(result.Text))
                {
                    if (result.Text != null && result.Text.Trim().Length > 5)
                    {
                        new Log().SendLog("HandleScanResultAsync扫描结果！Text=" + result.Text + "&时间=" + DateTime.Now.ToString());
                        //截取销售单号
                        var saleOrder = ParsingSaleOrder(result.Text);

                        if (string.IsNullOrWhiteSpace(saleOrder))
                        {
                            this.RunOnUi(() => { this.ShowAlert("没有发现订单号", false); });
                        }
                        //SO单号处理
                        else if (saleOrder.Contains("SO"))
                        {
                            new GetOrder().ManageSO(saleOrder);
                        }
                        //RE单号处理
                        else if (saleOrder.Contains("RE"))
                        {
                            new GetOrder().ManageRE(saleOrder);
                        }
                        else
                        {
                            this.RunOnUi(() => { this.ShowToast("未识别"); });
                        }
                    }
                    else
                    {

                        this.RunOnUi(() => { this.ShowToast("扫描无数据"); });
                        //new Java.Lang.String("扫描无数据");
                    }

                }
                else
                {
                    this.RunOnUi(this.CloseFloatWindow);
                    //this.RunOnUi(() => { this.ShowToast("扫描取消"); });
                    //new Java.Lang.String("扫描取消");
                }
            }
            catch (Exception ex)
            {

                new Log().SendLog("扫描回调出现异常！" + ex.Message);
                this.RunOnUi(() =>
                {
                    this.ShowAlert("扫描回调出现异常-请联系管理员", false, (d) =>
                    {
                        Close();
                    });
                });
            }

            //CloseFloatWindow();
        }

        /// <summary>
        /// 截取销售子单号
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string ParsingSaleOrder(string url)
        {
            try
            {
                new Log().SendLog("开始截取地址中得销售单号！url:" + url + "&时间=" + DateTime.Now.ToString());
                int IndexofA = url.IndexOf("oid=");
                int IndexofB = url.IndexOf("&", IndexofA);
                var saleOrder = url.Substring(IndexofA + 4, IndexofB - IndexofA - 4);
                new Log().SendLog("截取销售单号结束！截取结果为:" + saleOrder + "&时间=" + DateTime.Now.ToString());
                return saleOrder;
            }
            catch (Exception ex)
            {
                new Log().SendLog("截取销售单号中发现异常！Exception:" + ex.Message + "&时间=" + DateTime.Now.ToString());
                return "";
            }

        }
        #endregion
    }
}