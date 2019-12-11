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
using App3.Model;

namespace App3.Comment
{
    public class SetUpTheAdapter : BaseAdapter<Orgnization>
    {
        private readonly List<Orgnization> engineers;
        private readonly Activity action;
        public SetUpTheAdapter(Activity action, List<Orgnization> engineers)
        {
            this.engineers = engineers;
            this.action = action;
        }
        public override Orgnization this[int position]
        {
            get
            {
                return this.engineers[position];
            }
        }

        public override int Count => engineers.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //入口 position值为-1 异常
            View view = convertView;
            if (view == null)
            {
                //LayoutInflater
                view = this.action.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            }
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = this.engineers[position].OrgnizationName;
            return view;
        }
    }
}