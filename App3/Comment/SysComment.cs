
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using App3.LKLModel;
using Com.Lkl.Cloudpos.Mdx.Aidl.System;
using System.Collections.Generic;

namespace App3.Comment
{
    public class SysComment:BaseActivity
    {
        private IAidlSystem systemInf = null;
        private TextView _textView;
        private new BookServiceConnection _bookServiceConnection;
        public void aa(PackageManager package)
        {
            BindRemoteService(package);
            InvokeRemoteService();
        }
        private void BindRemoteService(PackageManager package)//绑定远程服务
        {
            Intent intent = new Intent("lkl_cloudpos_mdx_service");
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)//（在Android5.0及以上系统中需要显式声明Intent才能启动Service）
            {
                intent = CreateExplicitFromImplicitIntent(package, intent);
            }

            if (_bookServiceConnection == null)
            {
                _bookServiceConnection = new BookServiceConnection();
            }
            this.BindService(intent, _bookServiceConnection, Bind.AutoCreate);
            Toast.MakeText(this, "绑定远程服务", ToastLength.Short).Show();
        }
        private void InvokeRemoteService()//调用远程服务
        {
            if (_bookServiceConnection != null)
            {
                string str= _bookServiceConnection.IAidlSystem.SerialNo;
                Toast.MakeText(this, str, ToastLength.Short).Show();
            }
        }

        private void UnBindRemoteService()//解绑远程服务
        {
            if (_bookServiceConnection != null)
            {
                this.UnbindService(_bookServiceConnection);
                _bookServiceConnection = null;
                Toast.MakeText(this, "解绑远程服务", ToastLength.Short).Show();
            }
        }

        //从隐式声明的Intent中创建一个显式声明的Intent（在Android5.0及以上系统中需要显式声明Intent才能启动Service）
        private Intent CreateExplicitFromImplicitIntent(PackageManager package, Intent implicitIntent)
        {

            //查出所有的能匹配这个隐式意图的服务列表
            IList<ResolveInfo> resolveInfo = package.QueryIntentServices(implicitIntent, 0);
            if (resolveInfo == null || resolveInfo.Count != 1)
            {
                return null;
            }

            ResolveInfo serviceInfo = resolveInfo[0];
            string packageName = serviceInfo.ServiceInfo.PackageName;//取出包名
            string className = serviceInfo.ServiceInfo.Name;//取出服务名
            ComponentName component = new ComponentName(packageName, className);//用包名和服务名来创建一个ComponentName对象

            //拿隐式意图对象implicitIntent作为构造参数，来创建一个新的显示的意图
            Intent explicitIntent = new Intent(implicitIntent);
            explicitIntent.SetComponent(component);//设置显示意图的组件名对象

            return explicitIntent;
        }
        public class BookServiceConnection : Java.Lang.Object, IServiceConnection
        {
            public IAidlSystem IAidlSystem { get; private set; }
            public void OnServiceConnected(ComponentName name, IBinder service)
            {
                IAidlSystem = AidlSystemStub.AsInterface(service);
            }

            public void OnServiceDisconnected(ComponentName name)
            {
            }
        }  
    }
}