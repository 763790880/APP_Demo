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

namespace App3.ActivityFun
{
   public class Log:BaseActivity
    {
        #region 日志
      public async Task SendLog(string mess)
        {
            try
            {
                Get(url + "/api/Log/SetLogInfo?mess=【POS机】" + mess, "");
            }
            catch (Exception ex)
            {
                RunOnUi(() => { ShowAlert("日志书写错误"); });
            }

        }
        #endregion
    }
}