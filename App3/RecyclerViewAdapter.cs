using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace App3
{
    public class RecyclerViewAdapter : RecyclerView.Adapter
    {
        private List<Model.SalesOrderDetails> data;
        private List<Model.SalesOrderDetails> modelData = new List<Model.SalesOrderDetails>();
        private Context _context;
        private TextView orderPrice;
        public RecyclerViewAdapter(List<Model.SalesOrderDetails> list, Context context)
        {
            data = list;
            if (list != null && list.Count > 0)
            {
                var str = list.GroupBy(f => f.Code);
                foreach (var item in str)
                {
                    Model.SalesOrderDetails salesOrder = new Model.SalesOrderDetails();
                    var code = item.Key;
                    salesOrder.Code = item.Key;
                    salesOrder.Money = list.Where(f=>f.Code==code).Sum(f => f.Money);
                    salesOrder.Description = list.Where(f => f.Code == code).Max(f => f.Description);
                    salesOrder.Number = list.Where(f => f.Code == code).Count();
                    modelData.Add(salesOrder);
                }
            }
        
            //modelData= (from n in list group n by n.Code into g select new Model.SalesOrderDetails() { Code=g.Key,Description=g.GetEnumerator(). }).ToList()
            _context = context;
        }
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MyViewHolder myViewHolder = holder as MyViewHolder;
            myViewHolder.tvTitle.Text = data[position].Description+"("+ data[position].Code+ ")\n"+ data[position].Barcode;
            myViewHolder.orderPrice.Text = data[position].Money.ToString();
            myViewHolder.orderPrice.FocusChange += (s,e)=> { ChangeVal(position, Convert.ToDecimal(myViewHolder.orderPrice.Text)); };
        }
        public void ChangeVal(int position,decimal money)
        {
            data[position].Money = money;
            //var code = modelData[position].Code;
            //foreach (var item in data.Where(f => f.Code == code))
            //{
            //    item.Money = money;
            //}
            if (orderPrice != null) { 
            //var orderList = LayoutInflater.FromContext(_context2).Inflate(Resource.Layout.OrderList, null);
            //TextView orderPrice = orderList.FindViewById<TextView>(Resource.Id.orderPrice);//金额
            orderPrice.Text = "金额："+data.Sum(f=>f.Money).ToString();
            }
        }
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewItem)
        {
            View view = LayoutInflater.From(_context).Inflate(Resource.Layout.Item_OrderList, parent, false);
            MyViewHolder holder = new MyViewHolder(view);
            return holder;
        }
        public override int ItemCount
        {
            get
            {
                return data.Count;
            }
        }
        public List<Model.SalesOrderDetails> GetData
        {
            get
            {
                return data;
            }
        }
        public bool SetContext(TextView context)
        {
            orderPrice = context;
            return true;
        }
        public override void OnViewRecycled(Java.Lang.Object holder)
        {
            base.OnViewRecycled(holder);
            MyViewHolder myViewHolder = holder as MyViewHolder;
        }
    }
    public class MyViewHolder : RecyclerView.ViewHolder
    {
        public TextView tvTitle;
        public TextView orderPrice;
        public MyViewHolder(View itemView) : base(itemView)
        {
            tvTitle = itemView.FindViewById<TextView>(Resource.Id.orderDescribe);
            //tvTitle.LineHeight = 19;
            orderPrice = itemView.FindViewById<TextView>(Resource.Id.orderPrice);
        }
    }
}