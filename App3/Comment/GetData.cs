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
using App3.Model;
using Newtonsoft.Json;

namespace App3.Comment
{
   public class GetData:BaseActivity
    {
        /// <summary>
        /// 未知疑问--方法集成在类中 无法调取--待解决
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public Member GetMember(string number)
        {
            try
            {
                var model=Get(url + "/api/Customer/GetMemberInfoByServiceCardNo?ServiceCardNo=" + number, "").Result;
                var resulr=JsonConvert.DeserializeObject<MemberInfo>(model);
                if (resulr.ResultCode != 1)
                {
                    this.RunOnUi(() => { this.ShowToast(resulr.ResultMess); });
                    return null;
                }
                return resulr.Data;
            }
            catch (Exception ex)
            {
                RunOnUi(() => { ShowAlert("日志书写错误"); });
            }
            return new Member();
        }
    }
}