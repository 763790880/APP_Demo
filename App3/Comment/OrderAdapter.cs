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
using Java.Lang;

namespace App3.Comment
{
    public class OrderAdapter : BaseAdapter<Engineer>
    {
        private readonly List<Engineer> engineers;
        private readonly Activity action;
        public OrderAdapter(Activity action, List<Engineer> engineers)
        {
            this.engineers = engineers;
            this.action = action;
        }
        public override Engineer this[int position]
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
            View view = convertView;
            if (view == null)
            {
                //LayoutInflater
                view = this.action.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);
            }
                view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = this.engineers[position].Account+"-"+this.engineers[position].UserName.ToString();
            return view;
        }
    }
}