using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using App3.Comment;
using Newtonsoft.Json;

namespace App3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class SetUpTheActivity:BaseActivity
    {
        private Model.DatabaseTXT databaseTXT=new Model.DatabaseTXT();
        List<Model.Orgnization> engineerGroup;
        Spinner spinnerGroup;
        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            UserDialogs.Init(this);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.SetUpThe);
            base.OnCreate(savedInstanceState);
            #region
            var task = Task.Run(() => {
                var typesSpinner = FindViewById<Spinner>(Resource.Id.spinnerInvoice);
                List<Model.Orgnization> engineers = GetInvoice().Result;
                typesSpinner.Adapter = new SetUpTheAdapter(this, engineers);
                typesSpinner.ItemSelected += Invoice_ItemSelected;
                //----------------------------------------------------------------
                spinnerGroup = FindViewById<Spinner>(Resource.Id.spinnerGroup);
                engineerGroup=GetGroup("Y00").Result;
                if (engineerGroup == null)
                    engineerGroup = new List<Model.Orgnization>();
                spinnerGroup.Adapter = new SetUpTheAdapterG(this, engineerGroup);
                spinnerGroup.ItemSelected += Group_ItemSelected;
            });
            task.Wait();
            #endregion
            #region
            Button btnSubOrder = this.FindViewById<Button>(Resource.Id.butSub);//确认设置
            btnSubOrder.Click += (s, e) =>
            {
                Task.Run(() =>
                {
                    var json = JsonConvert.SerializeObject(databaseTXT); 
                    var b = CreateTXT(json);
                    if (b)
                    {
                        this.RunOnUi(() =>
                        {
                            //ShowToast("设置成功");
                            ShowActivity<MainActivity>();
                        });

                    }
                    else
                    {
                        this.RunOnUi(() =>
                        {
                            ShowToast("设置失败");
                        });
                    }

                });

            };
            #endregion

        }
        private async Task<List<Model.Orgnization>> GetInvoice()
        {
            try
            {
                var result = await Get(url + "/api/Orgnization/GetOrInvoice", "");//token.Token
                var _engineerInfo = ByteToModel<Model.OrgnizationInfo>(result);
                return _engineerInfo.Data;
            }
            catch (Exception ex)
            {
                return new List<Model.Orgnization>();
            }
        }
        private int one=0;
        private void Invoice_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            var toast = spinner.GetItemAtPosition(e.Position);
            var model = toast.Cast<Model.Orgnization>();
            databaseTXT.InvoiceID = model.tb_Orgnization_Id;
            databaseTXT.InvoiceCode = model.OrgnizationNumber;
            databaseTXT.InvoiceName = model.OrgnizationName;
            if (one > 0)
                Task.Run(() => {//不能直接赋值   --刷新后没有选中新值
                    var data = GetGroup(model.OrgnizationNumber).Result;
                    engineerGroup.Clear();
                    foreach (var item in data)
                    {
                        engineerGroup.Add(item);
                    }
                    new SetUpTheAdapterG(this, engineerGroup).NotifyDataSetChanged();
                    //spinnerGroup.ItemSelected += Group_ItemSelected;
                    //new SetUpTheAdapterG(this, engineerGroup).GetView(1, null, null);
                });
            else
                one++;
        }
        private void Group_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            var toast = spinner.GetItemAtPosition(e.Position);
            var model = toast.Cast<Model.Orgnization>();
            databaseTXT.GroupID = model.tb_Orgnization_Id;
            databaseTXT.GroupCode = model.OrgnizationNumber;
            databaseTXT.GroupName = model.OrgnizationName;
            ShowToast(model.OrgnizationName);
        }
        private void SetGroup(string orgnizationNumber)
        {
            var spinnerGroup = FindViewById<Spinner>(Resource.Id.spinnerGroup);
            engineerGroup = GetGroup(orgnizationNumber).Result;
            if (engineerGroup == null)
                engineerGroup = new List<Model.Orgnization>();
            spinnerGroup.Adapter = new SetUpTheAdapterG(this, engineerGroup);
            spinnerGroup.ItemSelected += Group_ItemSelected;
        }
        private async Task<List<Model.Orgnization>> GetGroup(string orgnizationNumber)
        {
            try
            {
                var result = await Get(url + "/api/Orgnization/GetGroup?OrgnizationNumber=" + orgnizationNumber, "");//token.Token
                var _engineerInfo = ByteToModel<Model.OrgnizationInfo>(result);
                return _engineerInfo.Data;
            }
            catch (Exception ex)
            {
                return new List<Model.Orgnization>();
            }
        }

        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                ShowActivity<MainActivity>();
            }
            return base.OnKeyDown(keyCode, e);
        }
    }
}