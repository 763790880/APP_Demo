using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.System {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/system/AidlSystem$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlSystemStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/system/AidlSystem$Stub", typeof (AidlSystemStub));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected AidlSystemStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/constructor[@name='AidlSystem.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlSystemStub ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/system/AidlSystem;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/system/AidlSystem;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags)
		{
			const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [2] = new JniArgumentValue ((reply == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reply).Handle);
				__args [3] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_;
#pragma warning disable 0169
		static Delegate GetGetMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_Handler ()
		{
			if (cb_getMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_ == null)
				cb_getMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_);
			return cb_getMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_;
		}

		static void n_GetMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener p0 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetMerMsg (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getMerMsg' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.system.AidlMerListener']]"
		[Register ("getMerMsg", "(Lcom/lkl/cloudpos/mdx/aidl/system/AidlMerListener;)V", "GetGetMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_Handler")]
		public abstract void GetMerMsg (global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener p0);

		static Delegate cb_installApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_;
#pragma warning disable 0169
		static Delegate GetInstallApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_Handler ()
		{
			if (cb_installApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_ == null)
				cb_installApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InstallApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_);
			return cb_installApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_;
		}

		static void n_InstallApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InstallApp (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='installApp' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.system.InstallAppObserver']]"
		[Register ("installApp", "(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/system/InstallAppObserver;)V", "GetInstallApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_Handler")]
		public abstract void InstallApp (string p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver p1);

		static Delegate cb_reboot;
#pragma warning disable 0169
		static Delegate GetRebootHandler ()
		{
			if (cb_reboot == null)
				cb_reboot = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reboot);
			return cb_reboot;
		}

		static void n_Reboot (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reboot ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='reboot' and count(parameter)=0]"
		[Register ("reboot", "()V", "GetRebootHandler")]
		public abstract void Reboot ();

		static Delegate cb_update_I;
#pragma warning disable 0169
		static Delegate GetUpdate_IHandler ()
		{
			if (cb_update_I == null)
				cb_update_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Update_I);
			return cb_update_I;
		}

		static void n_Update_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='update' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("update", "(I)V", "GetUpdate_IHandler")]
		public abstract void Update (int p0);

		static Delegate cb_updateSysTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateSysTime_Ljava_lang_String_Handler ()
		{
			if (cb_updateSysTime_Ljava_lang_String_ == null)
				cb_updateSysTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdateSysTime_Ljava_lang_String_);
			return cb_updateSysTime_Ljava_lang_String_;
		}

		static bool n_UpdateSysTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateSysTime (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='updateSysTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateSysTime", "(Ljava/lang/String;)Z", "GetUpdateSysTime_Ljava_lang_String_Handler")]
		public abstract bool UpdateSysTime (string p0);

		static Delegate cb_getAndroidKernelVersion;
#pragma warning disable 0169
		static Delegate GetGetAndroidKernelVersionHandler ()
		{
			if (cb_getAndroidKernelVersion == null)
				cb_getAndroidKernelVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAndroidKernelVersion);
			return cb_getAndroidKernelVersion;
		}

		static IntPtr n_GetAndroidKernelVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AndroidKernelVersion);
		}
#pragma warning restore 0169

		public abstract string AndroidKernelVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getAndroidKernelVersion' and count(parameter)=0]"
			[Register ("getAndroidKernelVersion", "()Ljava/lang/String;", "GetGetAndroidKernelVersionHandler")] get;
		}

		static Delegate cb_getAndroidOsVersion;
#pragma warning disable 0169
		static Delegate GetGetAndroidOsVersionHandler ()
		{
			if (cb_getAndroidOsVersion == null)
				cb_getAndroidOsVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAndroidOsVersion);
			return cb_getAndroidOsVersion;
		}

		static IntPtr n_GetAndroidOsVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AndroidOsVersion);
		}
#pragma warning restore 0169

		public abstract string AndroidOsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getAndroidOsVersion' and count(parameter)=0]"
			[Register ("getAndroidOsVersion", "()Ljava/lang/String;", "GetGetAndroidOsVersionHandler")] get;
		}

		static Delegate cb_getCurSdkVersion;
#pragma warning disable 0169
		static Delegate GetGetCurSdkVersionHandler ()
		{
			if (cb_getCurSdkVersion == null)
				cb_getCurSdkVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurSdkVersion);
			return cb_getCurSdkVersion;
		}

		static IntPtr n_GetCurSdkVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurSdkVersion);
		}
#pragma warning restore 0169

		public abstract string CurSdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getCurSdkVersion' and count(parameter)=0]"
			[Register ("getCurSdkVersion", "()Ljava/lang/String;", "GetGetCurSdkVersionHandler")] get;
		}

		static Delegate cb_getDriverVersion;
#pragma warning disable 0169
		static Delegate GetGetDriverVersionHandler ()
		{
			if (cb_getDriverVersion == null)
				cb_getDriverVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDriverVersion);
			return cb_getDriverVersion;
		}

		static IntPtr n_GetDriverVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DriverVersion);
		}
#pragma warning restore 0169

		public abstract string DriverVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getDriverVersion' and count(parameter)=0]"
			[Register ("getDriverVersion", "()Ljava/lang/String;", "GetGetDriverVersionHandler")] get;
		}

		static Delegate cb_getHardWireVersion;
#pragma warning disable 0169
		static Delegate GetGetHardWireVersionHandler ()
		{
			if (cb_getHardWireVersion == null)
				cb_getHardWireVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHardWireVersion);
			return cb_getHardWireVersion;
		}

		static IntPtr n_GetHardWireVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HardWireVersion);
		}
#pragma warning restore 0169

		public abstract string HardWireVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getHardWireVersion' and count(parameter)=0]"
			[Register ("getHardWireVersion", "()Ljava/lang/String;", "GetGetHardWireVersionHandler")] get;
		}

		static Delegate cb_getIMEI;
#pragma warning disable 0169
		static Delegate GetGetIMEIHandler ()
		{
			if (cb_getIMEI == null)
				cb_getIMEI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIMEI);
			return cb_getIMEI;
		}

		static IntPtr n_GetIMEI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IMEI);
		}
#pragma warning restore 0169

		public abstract string IMEI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getIMEI' and count(parameter)=0]"
			[Register ("getIMEI", "()Ljava/lang/String;", "GetGetIMEIHandler")] get;
		}

		static Delegate cb_getIMSI;
#pragma warning disable 0169
		static Delegate GetGetIMSIHandler ()
		{
			if (cb_getIMSI == null)
				cb_getIMSI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIMSI);
			return cb_getIMSI;
		}

		static IntPtr n_GetIMSI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IMSI);
		}
#pragma warning restore 0169

		public abstract string IMSI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getIMSI' and count(parameter)=0]"
			[Register ("getIMSI", "()Ljava/lang/String;", "GetGetIMSIHandler")] get;
		}

		static Delegate cb_getKsn;
#pragma warning disable 0169
		static Delegate GetGetKsnHandler ()
		{
			if (cb_getKsn == null)
				cb_getKsn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKsn);
			return cb_getKsn;
		}

		static IntPtr n_GetKsn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ksn);
		}
#pragma warning restore 0169

		public abstract string Ksn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getKsn' and count(parameter)=0]"
			[Register ("getKsn", "()Ljava/lang/String;", "GetGetKsnHandler")] get;
		}

		static Delegate cb_getLKLOSSpecsVersion;
#pragma warning disable 0169
		static Delegate GetGetLKLOSSpecsVersionHandler ()
		{
			if (cb_getLKLOSSpecsVersion == null)
				cb_getLKLOSSpecsVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLKLOSSpecsVersion);
			return cb_getLKLOSSpecsVersion;
		}

		static IntPtr n_GetLKLOSSpecsVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LKLOSSpecsVersion);
		}
#pragma warning restore 0169

		public abstract string LKLOSSpecsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getLKLOSSpecsVersion' and count(parameter)=0]"
			[Register ("getLKLOSSpecsVersion", "()Ljava/lang/String;", "GetGetLKLOSSpecsVersionHandler")] get;
		}

		static Delegate cb_getManufacture;
#pragma warning disable 0169
		static Delegate GetGetManufactureHandler ()
		{
			if (cb_getManufacture == null)
				cb_getManufacture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetManufacture);
			return cb_getManufacture;
		}

		static IntPtr n_GetManufacture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Manufacture);
		}
#pragma warning restore 0169

		public abstract string Manufacture {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getManufacture' and count(parameter)=0]"
			[Register ("getManufacture", "()Ljava/lang/String;", "GetGetManufactureHandler")] get;
		}

		static Delegate cb_getModel;
#pragma warning disable 0169
		static Delegate GetGetModelHandler ()
		{
			if (cb_getModel == null)
				cb_getModel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModel);
			return cb_getModel;
		}

		static IntPtr n_GetModel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Model);
		}
#pragma warning restore 0169

		public abstract string Model {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getModel' and count(parameter)=0]"
			[Register ("getModel", "()Ljava/lang/String;", "GetGetModelHandler")] get;
		}

		static Delegate cb_getRomVersion;
#pragma warning disable 0169
		static Delegate GetGetRomVersionHandler ()
		{
			if (cb_getRomVersion == null)
				cb_getRomVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRomVersion);
			return cb_getRomVersion;
		}

		static IntPtr n_GetRomVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RomVersion);
		}
#pragma warning restore 0169

		public abstract string RomVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getRomVersion' and count(parameter)=0]"
			[Register ("getRomVersion", "()Ljava/lang/String;", "GetGetRomVersionHandler")] get;
		}

		static Delegate cb_getSecurityDriverVersion;
#pragma warning disable 0169
		static Delegate GetGetSecurityDriverVersionHandler ()
		{
			if (cb_getSecurityDriverVersion == null)
				cb_getSecurityDriverVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecurityDriverVersion);
			return cb_getSecurityDriverVersion;
		}

		static IntPtr n_GetSecurityDriverVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecurityDriverVersion);
		}
#pragma warning restore 0169

		public abstract string SecurityDriverVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getSecurityDriverVersion' and count(parameter)=0]"
			[Register ("getSecurityDriverVersion", "()Ljava/lang/String;", "GetGetSecurityDriverVersionHandler")] get;
		}

		static Delegate cb_getSerialNo;
#pragma warning disable 0169
		static Delegate GetGetSerialNoHandler ()
		{
			if (cb_getSerialNo == null)
				cb_getSerialNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialNo);
			return cb_getSerialNo;
		}

		static IntPtr n_GetSerialNo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SerialNo);
		}
#pragma warning restore 0169

		public abstract string SerialNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getSerialNo' and count(parameter)=0]"
			[Register ("getSerialNo", "()Ljava/lang/String;", "GetGetSerialNoHandler")] get;
		}

		static Delegate cb_getStoragePath;
#pragma warning disable 0169
		static Delegate GetGetStoragePathHandler ()
		{
			if (cb_getStoragePath == null)
				cb_getStoragePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStoragePath);
			return cb_getStoragePath;
		}

		static IntPtr n_GetStoragePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StoragePath);
		}
#pragma warning restore 0169

		public abstract string StoragePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getStoragePath' and count(parameter)=0]"
			[Register ("getStoragePath", "()Ljava/lang/String;", "GetGetStoragePathHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/system/AidlSystem$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlSystemStubInvoker : AidlSystemStub {

		public AidlSystemStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/system/AidlSystem$Stub", typeof (AidlSystemStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe string AndroidKernelVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getAndroidKernelVersion' and count(parameter)=0]"
			[Register ("getAndroidKernelVersion", "()Ljava/lang/String;", "GetGetAndroidKernelVersionHandler")]
			get {
				const string __id = "getAndroidKernelVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string AndroidOsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getAndroidOsVersion' and count(parameter)=0]"
			[Register ("getAndroidOsVersion", "()Ljava/lang/String;", "GetGetAndroidOsVersionHandler")]
			get {
				const string __id = "getAndroidOsVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string CurSdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getCurSdkVersion' and count(parameter)=0]"
			[Register ("getCurSdkVersion", "()Ljava/lang/String;", "GetGetCurSdkVersionHandler")]
			get {
				const string __id = "getCurSdkVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string DriverVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getDriverVersion' and count(parameter)=0]"
			[Register ("getDriverVersion", "()Ljava/lang/String;", "GetGetDriverVersionHandler")]
			get {
				const string __id = "getDriverVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string HardWireVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getHardWireVersion' and count(parameter)=0]"
			[Register ("getHardWireVersion", "()Ljava/lang/String;", "GetGetHardWireVersionHandler")]
			get {
				const string __id = "getHardWireVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string IMEI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getIMEI' and count(parameter)=0]"
			[Register ("getIMEI", "()Ljava/lang/String;", "GetGetIMEIHandler")]
			get {
				const string __id = "getIMEI.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string IMSI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getIMSI' and count(parameter)=0]"
			[Register ("getIMSI", "()Ljava/lang/String;", "GetGetIMSIHandler")]
			get {
				const string __id = "getIMSI.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string Ksn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getKsn' and count(parameter)=0]"
			[Register ("getKsn", "()Ljava/lang/String;", "GetGetKsnHandler")]
			get {
				const string __id = "getKsn.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string LKLOSSpecsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getLKLOSSpecsVersion' and count(parameter)=0]"
			[Register ("getLKLOSSpecsVersion", "()Ljava/lang/String;", "GetGetLKLOSSpecsVersionHandler")]
			get {
				const string __id = "getLKLOSSpecsVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string Manufacture {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getManufacture' and count(parameter)=0]"
			[Register ("getManufacture", "()Ljava/lang/String;", "GetGetManufactureHandler")]
			get {
				const string __id = "getManufacture.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string Model {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getModel' and count(parameter)=0]"
			[Register ("getModel", "()Ljava/lang/String;", "GetGetModelHandler")]
			get {
				const string __id = "getModel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string RomVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getRomVersion' and count(parameter)=0]"
			[Register ("getRomVersion", "()Ljava/lang/String;", "GetGetRomVersionHandler")]
			get {
				const string __id = "getRomVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string SecurityDriverVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getSecurityDriverVersion' and count(parameter)=0]"
			[Register ("getSecurityDriverVersion", "()Ljava/lang/String;", "GetGetSecurityDriverVersionHandler")]
			get {
				const string __id = "getSecurityDriverVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string SerialNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getSerialNo' and count(parameter)=0]"
			[Register ("getSerialNo", "()Ljava/lang/String;", "GetGetSerialNoHandler")]
			get {
				const string __id = "getSerialNo.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string StoragePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlSystem.Stub']/method[@name='getStoragePath' and count(parameter)=0]"
			[Register ("getStoragePath", "()Ljava/lang/String;", "GetGetStoragePathHandler")]
			get {
				const string __id = "getStoragePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getMerMsg' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.system.AidlMerListener']]"
		[Register ("getMerMsg", "(Lcom/lkl/cloudpos/mdx/aidl/system/AidlMerListener;)V", "GetGetMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_Handler")]
		public override unsafe void GetMerMsg (global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener p0)
		{
			const string __id = "getMerMsg.(Lcom/lkl/cloudpos/mdx/aidl/system/AidlMerListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='installApp' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.system.InstallAppObserver']]"
		[Register ("installApp", "(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/system/InstallAppObserver;)V", "GetInstallApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_Handler")]
		public override unsafe void InstallApp (string p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver p1)
		{
			const string __id = "installApp.(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/system/InstallAppObserver;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='reboot' and count(parameter)=0]"
		[Register ("reboot", "()V", "GetRebootHandler")]
		public override unsafe void Reboot ()
		{
			const string __id = "reboot.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='update' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("update", "(I)V", "GetUpdate_IHandler")]
		public override unsafe void Update (int p0)
		{
			const string __id = "update.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='updateSysTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateSysTime", "(Ljava/lang/String;)Z", "GetUpdateSysTime_Ljava_lang_String_Handler")]
		public override unsafe bool UpdateSysTime (string p0)
		{
			const string __id = "updateSysTime.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']"
	[Register ("com/lkl/cloudpos/mdx/aidl/system/AidlSystem", "", "Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker")]
	public partial interface IAidlSystem : global::Android.OS.IInterface {

		string AndroidKernelVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getAndroidKernelVersion' and count(parameter)=0]"
			[Register ("getAndroidKernelVersion", "()Ljava/lang/String;", "GetGetAndroidKernelVersionHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string AndroidOsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getAndroidOsVersion' and count(parameter)=0]"
			[Register ("getAndroidOsVersion", "()Ljava/lang/String;", "GetGetAndroidOsVersionHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string CurSdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getCurSdkVersion' and count(parameter)=0]"
			[Register ("getCurSdkVersion", "()Ljava/lang/String;", "GetGetCurSdkVersionHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string DriverVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getDriverVersion' and count(parameter)=0]"
			[Register ("getDriverVersion", "()Ljava/lang/String;", "GetGetDriverVersionHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string HardWireVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getHardWireVersion' and count(parameter)=0]"
			[Register ("getHardWireVersion", "()Ljava/lang/String;", "GetGetHardWireVersionHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string IMEI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getIMEI' and count(parameter)=0]"
			[Register ("getIMEI", "()Ljava/lang/String;", "GetGetIMEIHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string IMSI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getIMSI' and count(parameter)=0]"
			[Register ("getIMSI", "()Ljava/lang/String;", "GetGetIMSIHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string Ksn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getKsn' and count(parameter)=0]"
			[Register ("getKsn", "()Ljava/lang/String;", "GetGetKsnHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string LKLOSSpecsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getLKLOSSpecsVersion' and count(parameter)=0]"
			[Register ("getLKLOSSpecsVersion", "()Ljava/lang/String;", "GetGetLKLOSSpecsVersionHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string Manufacture {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getManufacture' and count(parameter)=0]"
			[Register ("getManufacture", "()Ljava/lang/String;", "GetGetManufactureHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string Model {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getModel' and count(parameter)=0]"
			[Register ("getModel", "()Ljava/lang/String;", "GetGetModelHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string RomVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getRomVersion' and count(parameter)=0]"
			[Register ("getRomVersion", "()Ljava/lang/String;", "GetGetRomVersionHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string SecurityDriverVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getSecurityDriverVersion' and count(parameter)=0]"
			[Register ("getSecurityDriverVersion", "()Ljava/lang/String;", "GetGetSecurityDriverVersionHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string SerialNo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getSerialNo' and count(parameter)=0]"
			[Register ("getSerialNo", "()Ljava/lang/String;", "GetGetSerialNoHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		string StoragePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getStoragePath' and count(parameter)=0]"
			[Register ("getStoragePath", "()Ljava/lang/String;", "GetGetStoragePathHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='getMerMsg' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.system.AidlMerListener']]"
		[Register ("getMerMsg", "(Lcom/lkl/cloudpos/mdx/aidl/system/AidlMerListener;)V", "GetGetMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")]
		void GetMerMsg (global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='installApp' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.system.InstallAppObserver']]"
		[Register ("installApp", "(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/system/InstallAppObserver;)V", "GetInstallApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")]
		void InstallApp (string p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='reboot' and count(parameter)=0]"
		[Register ("reboot", "()V", "GetRebootHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")]
		void Reboot ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='update' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("update", "(I)V", "GetUpdate_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")]
		void Update (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlSystem']/method[@name='updateSysTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateSysTime", "(Ljava/lang/String;)Z", "GetUpdateSysTime_Ljava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystemInvoker, ClassLibrary1")]
		bool UpdateSysTime (string p0);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/system/AidlSystem", DoNotGenerateAcw=true)]
	internal class IAidlSystemInvoker : global::Java.Lang.Object, IAidlSystem {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/system/AidlSystem", typeof (IAidlSystemInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IAidlSystem GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlSystem> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.system.AidlSystem"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlSystemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAndroidKernelVersion;
#pragma warning disable 0169
		static Delegate GetGetAndroidKernelVersionHandler ()
		{
			if (cb_getAndroidKernelVersion == null)
				cb_getAndroidKernelVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAndroidKernelVersion);
			return cb_getAndroidKernelVersion;
		}

		static IntPtr n_GetAndroidKernelVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AndroidKernelVersion);
		}
#pragma warning restore 0169

		IntPtr id_getAndroidKernelVersion;
		public unsafe string AndroidKernelVersion {
			get {
				if (id_getAndroidKernelVersion == IntPtr.Zero)
					id_getAndroidKernelVersion = JNIEnv.GetMethodID (class_ref, "getAndroidKernelVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAndroidKernelVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAndroidOsVersion;
#pragma warning disable 0169
		static Delegate GetGetAndroidOsVersionHandler ()
		{
			if (cb_getAndroidOsVersion == null)
				cb_getAndroidOsVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAndroidOsVersion);
			return cb_getAndroidOsVersion;
		}

		static IntPtr n_GetAndroidOsVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AndroidOsVersion);
		}
#pragma warning restore 0169

		IntPtr id_getAndroidOsVersion;
		public unsafe string AndroidOsVersion {
			get {
				if (id_getAndroidOsVersion == IntPtr.Zero)
					id_getAndroidOsVersion = JNIEnv.GetMethodID (class_ref, "getAndroidOsVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAndroidOsVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurSdkVersion;
#pragma warning disable 0169
		static Delegate GetGetCurSdkVersionHandler ()
		{
			if (cb_getCurSdkVersion == null)
				cb_getCurSdkVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurSdkVersion);
			return cb_getCurSdkVersion;
		}

		static IntPtr n_GetCurSdkVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurSdkVersion);
		}
#pragma warning restore 0169

		IntPtr id_getCurSdkVersion;
		public unsafe string CurSdkVersion {
			get {
				if (id_getCurSdkVersion == IntPtr.Zero)
					id_getCurSdkVersion = JNIEnv.GetMethodID (class_ref, "getCurSdkVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurSdkVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDriverVersion;
#pragma warning disable 0169
		static Delegate GetGetDriverVersionHandler ()
		{
			if (cb_getDriverVersion == null)
				cb_getDriverVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDriverVersion);
			return cb_getDriverVersion;
		}

		static IntPtr n_GetDriverVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DriverVersion);
		}
#pragma warning restore 0169

		IntPtr id_getDriverVersion;
		public unsafe string DriverVersion {
			get {
				if (id_getDriverVersion == IntPtr.Zero)
					id_getDriverVersion = JNIEnv.GetMethodID (class_ref, "getDriverVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDriverVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHardWireVersion;
#pragma warning disable 0169
		static Delegate GetGetHardWireVersionHandler ()
		{
			if (cb_getHardWireVersion == null)
				cb_getHardWireVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHardWireVersion);
			return cb_getHardWireVersion;
		}

		static IntPtr n_GetHardWireVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HardWireVersion);
		}
#pragma warning restore 0169

		IntPtr id_getHardWireVersion;
		public unsafe string HardWireVersion {
			get {
				if (id_getHardWireVersion == IntPtr.Zero)
					id_getHardWireVersion = JNIEnv.GetMethodID (class_ref, "getHardWireVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHardWireVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIMEI;
#pragma warning disable 0169
		static Delegate GetGetIMEIHandler ()
		{
			if (cb_getIMEI == null)
				cb_getIMEI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIMEI);
			return cb_getIMEI;
		}

		static IntPtr n_GetIMEI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IMEI);
		}
#pragma warning restore 0169

		IntPtr id_getIMEI;
		public unsafe string IMEI {
			get {
				if (id_getIMEI == IntPtr.Zero)
					id_getIMEI = JNIEnv.GetMethodID (class_ref, "getIMEI", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIMEI), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getIMSI;
#pragma warning disable 0169
		static Delegate GetGetIMSIHandler ()
		{
			if (cb_getIMSI == null)
				cb_getIMSI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIMSI);
			return cb_getIMSI;
		}

		static IntPtr n_GetIMSI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IMSI);
		}
#pragma warning restore 0169

		IntPtr id_getIMSI;
		public unsafe string IMSI {
			get {
				if (id_getIMSI == IntPtr.Zero)
					id_getIMSI = JNIEnv.GetMethodID (class_ref, "getIMSI", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIMSI), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getKsn;
#pragma warning disable 0169
		static Delegate GetGetKsnHandler ()
		{
			if (cb_getKsn == null)
				cb_getKsn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKsn);
			return cb_getKsn;
		}

		static IntPtr n_GetKsn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ksn);
		}
#pragma warning restore 0169

		IntPtr id_getKsn;
		public unsafe string Ksn {
			get {
				if (id_getKsn == IntPtr.Zero)
					id_getKsn = JNIEnv.GetMethodID (class_ref, "getKsn", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKsn), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLKLOSSpecsVersion;
#pragma warning disable 0169
		static Delegate GetGetLKLOSSpecsVersionHandler ()
		{
			if (cb_getLKLOSSpecsVersion == null)
				cb_getLKLOSSpecsVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLKLOSSpecsVersion);
			return cb_getLKLOSSpecsVersion;
		}

		static IntPtr n_GetLKLOSSpecsVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LKLOSSpecsVersion);
		}
#pragma warning restore 0169

		IntPtr id_getLKLOSSpecsVersion;
		public unsafe string LKLOSSpecsVersion {
			get {
				if (id_getLKLOSSpecsVersion == IntPtr.Zero)
					id_getLKLOSSpecsVersion = JNIEnv.GetMethodID (class_ref, "getLKLOSSpecsVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLKLOSSpecsVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getManufacture;
#pragma warning disable 0169
		static Delegate GetGetManufactureHandler ()
		{
			if (cb_getManufacture == null)
				cb_getManufacture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetManufacture);
			return cb_getManufacture;
		}

		static IntPtr n_GetManufacture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Manufacture);
		}
#pragma warning restore 0169

		IntPtr id_getManufacture;
		public unsafe string Manufacture {
			get {
				if (id_getManufacture == IntPtr.Zero)
					id_getManufacture = JNIEnv.GetMethodID (class_ref, "getManufacture", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getManufacture), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getModel;
#pragma warning disable 0169
		static Delegate GetGetModelHandler ()
		{
			if (cb_getModel == null)
				cb_getModel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModel);
			return cb_getModel;
		}

		static IntPtr n_GetModel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Model);
		}
#pragma warning restore 0169

		IntPtr id_getModel;
		public unsafe string Model {
			get {
				if (id_getModel == IntPtr.Zero)
					id_getModel = JNIEnv.GetMethodID (class_ref, "getModel", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModel), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRomVersion;
#pragma warning disable 0169
		static Delegate GetGetRomVersionHandler ()
		{
			if (cb_getRomVersion == null)
				cb_getRomVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRomVersion);
			return cb_getRomVersion;
		}

		static IntPtr n_GetRomVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RomVersion);
		}
#pragma warning restore 0169

		IntPtr id_getRomVersion;
		public unsafe string RomVersion {
			get {
				if (id_getRomVersion == IntPtr.Zero)
					id_getRomVersion = JNIEnv.GetMethodID (class_ref, "getRomVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRomVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSecurityDriverVersion;
#pragma warning disable 0169
		static Delegate GetGetSecurityDriverVersionHandler ()
		{
			if (cb_getSecurityDriverVersion == null)
				cb_getSecurityDriverVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecurityDriverVersion);
			return cb_getSecurityDriverVersion;
		}

		static IntPtr n_GetSecurityDriverVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecurityDriverVersion);
		}
#pragma warning restore 0169

		IntPtr id_getSecurityDriverVersion;
		public unsafe string SecurityDriverVersion {
			get {
				if (id_getSecurityDriverVersion == IntPtr.Zero)
					id_getSecurityDriverVersion = JNIEnv.GetMethodID (class_ref, "getSecurityDriverVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecurityDriverVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSerialNo;
#pragma warning disable 0169
		static Delegate GetGetSerialNoHandler ()
		{
			if (cb_getSerialNo == null)
				cb_getSerialNo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialNo);
			return cb_getSerialNo;
		}

		static IntPtr n_GetSerialNo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SerialNo);
		}
#pragma warning restore 0169

		IntPtr id_getSerialNo;
		public unsafe string SerialNo {
			get {
				if (id_getSerialNo == IntPtr.Zero)
					id_getSerialNo = JNIEnv.GetMethodID (class_ref, "getSerialNo", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialNo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStoragePath;
#pragma warning disable 0169
		static Delegate GetGetStoragePathHandler ()
		{
			if (cb_getStoragePath == null)
				cb_getStoragePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStoragePath);
			return cb_getStoragePath;
		}

		static IntPtr n_GetStoragePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StoragePath);
		}
#pragma warning restore 0169

		IntPtr id_getStoragePath;
		public unsafe string StoragePath {
			get {
				if (id_getStoragePath == IntPtr.Zero)
					id_getStoragePath = JNIEnv.GetMethodID (class_ref, "getStoragePath", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStoragePath), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_;
#pragma warning disable 0169
		static Delegate GetGetMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_Handler ()
		{
			if (cb_getMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_ == null)
				cb_getMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_);
			return cb_getMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_;
		}

		static void n_GetMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener p0 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetMerMsg (p0);
		}
#pragma warning restore 0169

		IntPtr id_getMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_;
		public unsafe void GetMerMsg (global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener p0)
		{
			if (id_getMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_ == IntPtr.Zero)
				id_getMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_ = JNIEnv.GetMethodID (class_ref, "getMerMsg", "(Lcom/lkl/cloudpos/mdx/aidl/system/AidlMerListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getMerMsg_Lcom_lkl_cloudpos_mdx_aidl_system_AidlMerListener_, __args);
		}

		static Delegate cb_installApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_;
#pragma warning disable 0169
		static Delegate GetInstallApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_Handler ()
		{
			if (cb_installApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_ == null)
				cb_installApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InstallApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_);
			return cb_installApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_;
		}

		static void n_InstallApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InstallApp (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_installApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_;
		public unsafe void InstallApp (string p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver p1)
		{
			if (id_installApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_ == IntPtr.Zero)
				id_installApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_ = JNIEnv.GetMethodID (class_ref, "installApp", "(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/system/InstallAppObserver;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_installApp_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_system_InstallAppObserver_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_reboot;
#pragma warning disable 0169
		static Delegate GetRebootHandler ()
		{
			if (cb_reboot == null)
				cb_reboot = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reboot);
			return cb_reboot;
		}

		static void n_Reboot (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reboot ();
		}
#pragma warning restore 0169

		IntPtr id_reboot;
		public unsafe void Reboot ()
		{
			if (id_reboot == IntPtr.Zero)
				id_reboot = JNIEnv.GetMethodID (class_ref, "reboot", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reboot);
		}

		static Delegate cb_update_I;
#pragma warning disable 0169
		static Delegate GetUpdate_IHandler ()
		{
			if (cb_update_I == null)
				cb_update_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Update_I);
			return cb_update_I;
		}

		static void n_Update_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0);
		}
#pragma warning restore 0169

		IntPtr id_update_I;
		public unsafe void Update (int p0)
		{
			if (id_update_I == IntPtr.Zero)
				id_update_I = JNIEnv.GetMethodID (class_ref, "update", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_update_I, __args);
		}

		static Delegate cb_updateSysTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateSysTime_Ljava_lang_String_Handler ()
		{
			if (cb_updateSysTime_Ljava_lang_String_ == null)
				cb_updateSysTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_UpdateSysTime_Ljava_lang_String_);
			return cb_updateSysTime_Ljava_lang_String_;
		}

		static bool n_UpdateSysTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateSysTime (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateSysTime_Ljava_lang_String_;
		public unsafe bool UpdateSysTime (string p0)
		{
			if (id_updateSysTime_Ljava_lang_String_ == IntPtr.Zero)
				id_updateSysTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateSysTime", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateSysTime_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlSystem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
