using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Casher {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/casher/AidlCasher$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlCasherStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/casher/AidlCasher$Stub", typeof (AidlCasherStub));
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

		protected AidlCasherStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/constructor[@name='AidlCasher.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlCasherStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/casher/AidlCasher;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/casher/AidlCasher;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_autoCutPaper;
#pragma warning disable 0169
		static Delegate GetAutoCutPaperHandler ()
		{
			if (cb_autoCutPaper == null)
				cb_autoCutPaper = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AutoCutPaper);
			return cb_autoCutPaper;
		}

		static void n_AutoCutPaper (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoCutPaper ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='autoCutPaper' and count(parameter)=0]"
		[Register ("autoCutPaper", "()V", "GetAutoCutPaperHandler")]
		public abstract void AutoCutPaper ();

		static Delegate cb_getWindowDisplayScreen_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetGetWindowDisplayScreen_Landroid_os_IBinder_Handler ()
		{
			if (cb_getWindowDisplayScreen_Landroid_os_IBinder_ == null)
				cb_getWindowDisplayScreen_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetWindowDisplayScreen_Landroid_os_IBinder_);
			return cb_getWindowDisplayScreen_Landroid_os_IBinder_;
		}

		static int n_GetWindowDisplayScreen_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder p0 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetWindowDisplayScreen (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='getWindowDisplayScreen' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("getWindowDisplayScreen", "(Landroid/os/IBinder;)I", "GetGetWindowDisplayScreen_Landroid_os_IBinder_Handler")]
		public abstract int GetWindowDisplayScreen (global::Android.OS.IBinder p0);

		static Delegate cb_registerMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_;
#pragma warning disable 0169
		static Delegate GetRegisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_Handler ()
		{
			if (cb_registerMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ == null)
				cb_registerMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_);
			return cb_registerMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_;
		}

		static void n_RegisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterMessageReceiver (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='registerMessageReceiver' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.casher.AidlCasherMessageReceiver']]"
		[Register ("registerMessageReceiver", "(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/casher/AidlCasherMessageReceiver;)V", "GetRegisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_Handler")]
		public abstract void RegisterMessageReceiver (string p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver p1);

		static Delegate cb_removeAppFromSubscreen_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveAppFromSubscreen_Ljava_lang_String_Handler ()
		{
			if (cb_removeAppFromSubscreen_Ljava_lang_String_ == null)
				cb_removeAppFromSubscreen_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveAppFromSubscreen_Ljava_lang_String_);
			return cb_removeAppFromSubscreen_Ljava_lang_String_;
		}

		static void n_RemoveAppFromSubscreen_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAppFromSubscreen (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='removeAppFromSubscreen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeAppFromSubscreen", "(Ljava/lang/String;)V", "GetRemoveAppFromSubscreen_Ljava_lang_String_Handler")]
		public abstract void RemoveAppFromSubscreen (string p0);

		static Delegate cb_sendMessage_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendMessage_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendMessage_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_sendMessage_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendMessage_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("sendMessage", "(Ljava/lang/String;Landroid/os/Bundle;)V", "GetSendMessage_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract void SendMessage (string p0, global::Android.OS.Bundle p1);

		static Delegate cb_startActivityOnSubscreen_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStartActivityOnSubscreen_Landroid_content_Intent_Handler ()
		{
			if (cb_startActivityOnSubscreen_Landroid_content_Intent_ == null)
				cb_startActivityOnSubscreen_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartActivityOnSubscreen_Landroid_content_Intent_);
			return cb_startActivityOnSubscreen_Landroid_content_Intent_;
		}

		static void n_StartActivityOnSubscreen_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityOnSubscreen (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='startActivityOnSubscreen' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("startActivityOnSubscreen", "(Landroid/content/Intent;)V", "GetStartActivityOnSubscreen_Landroid_content_Intent_Handler")]
		public abstract void StartActivityOnSubscreen (global::Android.Content.Intent p0);

		static Delegate cb_startAppOnSubscreen_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartAppOnSubscreen_Ljava_lang_String_Handler ()
		{
			if (cb_startAppOnSubscreen_Ljava_lang_String_ == null)
				cb_startAppOnSubscreen_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartAppOnSubscreen_Ljava_lang_String_);
			return cb_startAppOnSubscreen_Ljava_lang_String_;
		}

		static void n_StartAppOnSubscreen_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartAppOnSubscreen (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='startAppOnSubscreen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startAppOnSubscreen", "(Ljava/lang/String;)V", "GetStartAppOnSubscreen_Ljava_lang_String_Handler")]
		public abstract void StartAppOnSubscreen (string p0);

		static Delegate cb_unregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_;
#pragma warning disable 0169
		static Delegate GetUnregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_Handler ()
		{
			if (cb_unregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ == null)
				cb_unregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_);
			return cb_unregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_;
		}

		static void n_UnregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterMessageReceiver (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='unregisterMessageReceiver' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.casher.AidlCasherMessageReceiver']]"
		[Register ("unregisterMessageReceiver", "(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/casher/AidlCasherMessageReceiver;)V", "GetUnregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_Handler")]
		public abstract void UnregisterMessageReceiver (string p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver p1);

		static Delegate cb_getAppsOnSubscreen;
#pragma warning disable 0169
		static Delegate GetGetAppsOnSubscreenHandler ()
		{
			if (cb_getAppsOnSubscreen == null)
				cb_getAppsOnSubscreen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppsOnSubscreen);
			return cb_getAppsOnSubscreen;
		}

		static IntPtr n_GetAppsOnSubscreen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.AppsOnSubscreen);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<string> AppsOnSubscreen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='getAppsOnSubscreen' and count(parameter)=0]"
			[Register ("getAppsOnSubscreen", "()Ljava/util/List;", "GetGetAppsOnSubscreenHandler")] get;
		}

		static Delegate cb_getCashbox;
#pragma warning disable 0169
		static Delegate GetGetCashboxHandler ()
		{
			if (cb_getCashbox == null)
				cb_getCashbox = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCashbox);
			return cb_getCashbox;
		}

		static IntPtr n_GetCashbox (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cashbox);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder Cashbox {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='getCashbox' and count(parameter)=0]"
			[Register ("getCashbox", "()Landroid/os/IBinder;", "GetGetCashboxHandler")] get;
		}

		static Delegate cb_getCasherScreenState;
#pragma warning disable 0169
		static Delegate GetGetCasherScreenStateHandler ()
		{
			if (cb_getCasherScreenState == null)
				cb_getCasherScreenState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCasherScreenState);
			return cb_getCasherScreenState;
		}

		static int n_GetCasherScreenState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CasherScreenState;
		}
#pragma warning restore 0169

		public abstract int CasherScreenState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='getCasherScreenState' and count(parameter)=0]"
			[Register ("getCasherScreenState", "()I", "GetGetCasherScreenStateHandler")] get;
		}

		static Delegate cb_getDigitalLineLED;
#pragma warning disable 0169
		static Delegate GetGetDigitalLineLEDHandler ()
		{
			if (cb_getDigitalLineLED == null)
				cb_getDigitalLineLED = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDigitalLineLED);
			return cb_getDigitalLineLED;
		}

		static IntPtr n_GetDigitalLineLED (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DigitalLineLED);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder DigitalLineLED {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='getDigitalLineLED' and count(parameter)=0]"
			[Register ("getDigitalLineLED", "()Landroid/os/IBinder;", "GetGetDigitalLineLEDHandler")] get;
		}

		static Delegate cb_isSubscreenFocus;
#pragma warning disable 0169
		static Delegate GetIsSubscreenFocusHandler ()
		{
			if (cb_isSubscreenFocus == null)
				cb_isSubscreenFocus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSubscreenFocus);
			return cb_isSubscreenFocus;
		}

		static bool n_IsSubscreenFocus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubscreenFocus;
		}
#pragma warning restore 0169

		static Delegate cb_setSubscreenFocus_Z;
#pragma warning disable 0169
		static Delegate GetSetSubscreenFocus_ZHandler ()
		{
			if (cb_setSubscreenFocus_Z == null)
				cb_setSubscreenFocus_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSubscreenFocus_Z);
			return cb_setSubscreenFocus_Z;
		}

		static void n_SetSubscreenFocus_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubscreenFocus = p0;
		}
#pragma warning restore 0169

		public abstract bool SubscreenFocus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='isSubscreenFocus' and count(parameter)=0]"
			[Register ("isSubscreenFocus", "()Z", "GetIsSubscreenFocusHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='setSubscreenFocus' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSubscreenFocus", "(Z)V", "GetSetSubscreenFocus_ZHandler")] set;
		}

		static Delegate cb_isSubscreenTouchable;
#pragma warning disable 0169
		static Delegate GetIsSubscreenTouchableHandler ()
		{
			if (cb_isSubscreenTouchable == null)
				cb_isSubscreenTouchable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSubscreenTouchable);
			return cb_isSubscreenTouchable;
		}

		static bool n_IsSubscreenTouchable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubscreenTouchable;
		}
#pragma warning restore 0169

		static Delegate cb_setSubscreenTouchable_Z;
#pragma warning disable 0169
		static Delegate GetSetSubscreenTouchable_ZHandler ()
		{
			if (cb_setSubscreenTouchable_Z == null)
				cb_setSubscreenTouchable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSubscreenTouchable_Z);
			return cb_setSubscreenTouchable_Z;
		}

		static void n_SetSubscreenTouchable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubscreenTouchable = p0;
		}
#pragma warning restore 0169

		public abstract bool SubscreenTouchable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='isSubscreenTouchable' and count(parameter)=0]"
			[Register ("isSubscreenTouchable", "()Z", "GetIsSubscreenTouchableHandler")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='setSubscreenTouchable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSubscreenTouchable", "(Z)V", "GetSetSubscreenTouchable_ZHandler")] set;
		}

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/casher/AidlCasher$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlCasherStubInvoker : AidlCasherStub {

		public AidlCasherStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/casher/AidlCasher$Stub", typeof (AidlCasherStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::System.Collections.Generic.IList<string> AppsOnSubscreen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='getAppsOnSubscreen' and count(parameter)=0]"
			[Register ("getAppsOnSubscreen", "()Ljava/util/List;", "GetGetAppsOnSubscreenHandler")]
			get {
				const string __id = "getAppsOnSubscreen.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder Cashbox {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='getCashbox' and count(parameter)=0]"
			[Register ("getCashbox", "()Landroid/os/IBinder;", "GetGetCashboxHandler")]
			get {
				const string __id = "getCashbox.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int CasherScreenState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='getCasherScreenState' and count(parameter)=0]"
			[Register ("getCasherScreenState", "()I", "GetGetCasherScreenStateHandler")]
			get {
				const string __id = "getCasherScreenState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder DigitalLineLED {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='getDigitalLineLED' and count(parameter)=0]"
			[Register ("getDigitalLineLED", "()Landroid/os/IBinder;", "GetGetDigitalLineLEDHandler")]
			get {
				const string __id = "getDigitalLineLED.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe bool SubscreenFocus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='isSubscreenFocus' and count(parameter)=0]"
			[Register ("isSubscreenFocus", "()Z", "GetIsSubscreenFocusHandler")]
			get {
				const string __id = "isSubscreenFocus.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='setSubscreenFocus' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSubscreenFocus", "(Z)V", "GetSetSubscreenFocus_ZHandler")]
			set {
				const string __id = "setSubscreenFocus.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe bool SubscreenTouchable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='isSubscreenTouchable' and count(parameter)=0]"
			[Register ("isSubscreenTouchable", "()Z", "GetIsSubscreenTouchableHandler")]
			get {
				const string __id = "isSubscreenTouchable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlCasher.Stub']/method[@name='setSubscreenTouchable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSubscreenTouchable", "(Z)V", "GetSetSubscreenTouchable_ZHandler")]
			set {
				const string __id = "setSubscreenTouchable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='autoCutPaper' and count(parameter)=0]"
		[Register ("autoCutPaper", "()V", "GetAutoCutPaperHandler")]
		public override unsafe void AutoCutPaper ()
		{
			const string __id = "autoCutPaper.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='getWindowDisplayScreen' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("getWindowDisplayScreen", "(Landroid/os/IBinder;)I", "GetGetWindowDisplayScreen_Landroid_os_IBinder_Handler")]
		public override unsafe int GetWindowDisplayScreen (global::Android.OS.IBinder p0)
		{
			const string __id = "getWindowDisplayScreen.(Landroid/os/IBinder;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='registerMessageReceiver' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.casher.AidlCasherMessageReceiver']]"
		[Register ("registerMessageReceiver", "(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/casher/AidlCasherMessageReceiver;)V", "GetRegisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_Handler")]
		public override unsafe void RegisterMessageReceiver (string p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver p1)
		{
			const string __id = "registerMessageReceiver.(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/casher/AidlCasherMessageReceiver;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='removeAppFromSubscreen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeAppFromSubscreen", "(Ljava/lang/String;)V", "GetRemoveAppFromSubscreen_Ljava_lang_String_Handler")]
		public override unsafe void RemoveAppFromSubscreen (string p0)
		{
			const string __id = "removeAppFromSubscreen.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("sendMessage", "(Ljava/lang/String;Landroid/os/Bundle;)V", "GetSendMessage_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendMessage (string p0, global::Android.OS.Bundle p1)
		{
			const string __id = "sendMessage.(Ljava/lang/String;Landroid/os/Bundle;)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='startActivityOnSubscreen' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("startActivityOnSubscreen", "(Landroid/content/Intent;)V", "GetStartActivityOnSubscreen_Landroid_content_Intent_Handler")]
		public override unsafe void StartActivityOnSubscreen (global::Android.Content.Intent p0)
		{
			const string __id = "startActivityOnSubscreen.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='startAppOnSubscreen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startAppOnSubscreen", "(Ljava/lang/String;)V", "GetStartAppOnSubscreen_Ljava_lang_String_Handler")]
		public override unsafe void StartAppOnSubscreen (string p0)
		{
			const string __id = "startAppOnSubscreen.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='unregisterMessageReceiver' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.casher.AidlCasherMessageReceiver']]"
		[Register ("unregisterMessageReceiver", "(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/casher/AidlCasherMessageReceiver;)V", "GetUnregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_Handler")]
		public override unsafe void UnregisterMessageReceiver (string p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver p1)
		{
			const string __id = "unregisterMessageReceiver.(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/casher/AidlCasherMessageReceiver;)V";
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

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']"
	[Register ("com/lkl/cloudpos/mdx/aidl/casher/AidlCasher", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker")]
	public partial interface IAidlCasher : global::Android.OS.IInterface {

		global::System.Collections.Generic.IList<string> AppsOnSubscreen {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='getAppsOnSubscreen' and count(parameter)=0]"
			[Register ("getAppsOnSubscreen", "()Ljava/util/List;", "GetGetAppsOnSubscreenHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")] get;
		}

		global::Android.OS.IBinder Cashbox {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='getCashbox' and count(parameter)=0]"
			[Register ("getCashbox", "()Landroid/os/IBinder;", "GetGetCashboxHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")] get;
		}

		int CasherScreenState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='getCasherScreenState' and count(parameter)=0]"
			[Register ("getCasherScreenState", "()I", "GetGetCasherScreenStateHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")] get;
		}

		global::Android.OS.IBinder DigitalLineLED {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='getDigitalLineLED' and count(parameter)=0]"
			[Register ("getDigitalLineLED", "()Landroid/os/IBinder;", "GetGetDigitalLineLEDHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")] get;
		}

		bool SubscreenFocus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='isSubscreenFocus' and count(parameter)=0]"
			[Register ("isSubscreenFocus", "()Z", "GetIsSubscreenFocusHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='setSubscreenFocus' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSubscreenFocus", "(Z)V", "GetSetSubscreenFocus_ZHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")] set;
		}

		bool SubscreenTouchable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='isSubscreenTouchable' and count(parameter)=0]"
			[Register ("isSubscreenTouchable", "()Z", "GetIsSubscreenTouchableHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='setSubscreenTouchable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSubscreenTouchable", "(Z)V", "GetSetSubscreenTouchable_ZHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='autoCutPaper' and count(parameter)=0]"
		[Register ("autoCutPaper", "()V", "GetAutoCutPaperHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")]
		void AutoCutPaper ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='getWindowDisplayScreen' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("getWindowDisplayScreen", "(Landroid/os/IBinder;)I", "GetGetWindowDisplayScreen_Landroid_os_IBinder_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")]
		int GetWindowDisplayScreen (global::Android.OS.IBinder p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='registerMessageReceiver' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.casher.AidlCasherMessageReceiver']]"
		[Register ("registerMessageReceiver", "(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/casher/AidlCasherMessageReceiver;)V", "GetRegisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")]
		void RegisterMessageReceiver (string p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='removeAppFromSubscreen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeAppFromSubscreen", "(Ljava/lang/String;)V", "GetRemoveAppFromSubscreen_Ljava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")]
		void RemoveAppFromSubscreen (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("sendMessage", "(Ljava/lang/String;Landroid/os/Bundle;)V", "GetSendMessage_Ljava_lang_String_Landroid_os_Bundle_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")]
		void SendMessage (string p0, global::Android.OS.Bundle p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='startActivityOnSubscreen' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("startActivityOnSubscreen", "(Landroid/content/Intent;)V", "GetStartActivityOnSubscreen_Landroid_content_Intent_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")]
		void StartActivityOnSubscreen (global::Android.Content.Intent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='startAppOnSubscreen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startAppOnSubscreen", "(Ljava/lang/String;)V", "GetStartAppOnSubscreen_Ljava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")]
		void StartAppOnSubscreen (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlCasher']/method[@name='unregisterMessageReceiver' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.casher.AidlCasherMessageReceiver']]"
		[Register ("unregisterMessageReceiver", "(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/casher/AidlCasherMessageReceiver;)V", "GetUnregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherInvoker, ClassLibrary1")]
		void UnregisterMessageReceiver (string p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver p1);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/casher/AidlCasher", DoNotGenerateAcw=true)]
	internal class IAidlCasherInvoker : global::Java.Lang.Object, IAidlCasher {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/casher/AidlCasher", typeof (IAidlCasherInvoker));

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

		public static IAidlCasher GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlCasher> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.casher.AidlCasher"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlCasherInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAppsOnSubscreen;
#pragma warning disable 0169
		static Delegate GetGetAppsOnSubscreenHandler ()
		{
			if (cb_getAppsOnSubscreen == null)
				cb_getAppsOnSubscreen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppsOnSubscreen);
			return cb_getAppsOnSubscreen;
		}

		static IntPtr n_GetAppsOnSubscreen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.AppsOnSubscreen);
		}
#pragma warning restore 0169

		IntPtr id_getAppsOnSubscreen;
		public unsafe global::System.Collections.Generic.IList<string> AppsOnSubscreen {
			get {
				if (id_getAppsOnSubscreen == IntPtr.Zero)
					id_getAppsOnSubscreen = JNIEnv.GetMethodID (class_ref, "getAppsOnSubscreen", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppsOnSubscreen), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCashbox;
#pragma warning disable 0169
		static Delegate GetGetCashboxHandler ()
		{
			if (cb_getCashbox == null)
				cb_getCashbox = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCashbox);
			return cb_getCashbox;
		}

		static IntPtr n_GetCashbox (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cashbox);
		}
#pragma warning restore 0169

		IntPtr id_getCashbox;
		public unsafe global::Android.OS.IBinder Cashbox {
			get {
				if (id_getCashbox == IntPtr.Zero)
					id_getCashbox = JNIEnv.GetMethodID (class_ref, "getCashbox", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCashbox), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCasherScreenState;
#pragma warning disable 0169
		static Delegate GetGetCasherScreenStateHandler ()
		{
			if (cb_getCasherScreenState == null)
				cb_getCasherScreenState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCasherScreenState);
			return cb_getCasherScreenState;
		}

		static int n_GetCasherScreenState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CasherScreenState;
		}
#pragma warning restore 0169

		IntPtr id_getCasherScreenState;
		public unsafe int CasherScreenState {
			get {
				if (id_getCasherScreenState == IntPtr.Zero)
					id_getCasherScreenState = JNIEnv.GetMethodID (class_ref, "getCasherScreenState", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCasherScreenState);
			}
		}

		static Delegate cb_getDigitalLineLED;
#pragma warning disable 0169
		static Delegate GetGetDigitalLineLEDHandler ()
		{
			if (cb_getDigitalLineLED == null)
				cb_getDigitalLineLED = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDigitalLineLED);
			return cb_getDigitalLineLED;
		}

		static IntPtr n_GetDigitalLineLED (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DigitalLineLED);
		}
#pragma warning restore 0169

		IntPtr id_getDigitalLineLED;
		public unsafe global::Android.OS.IBinder DigitalLineLED {
			get {
				if (id_getDigitalLineLED == IntPtr.Zero)
					id_getDigitalLineLED = JNIEnv.GetMethodID (class_ref, "getDigitalLineLED", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDigitalLineLED), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isSubscreenFocus;
#pragma warning disable 0169
		static Delegate GetIsSubscreenFocusHandler ()
		{
			if (cb_isSubscreenFocus == null)
				cb_isSubscreenFocus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSubscreenFocus);
			return cb_isSubscreenFocus;
		}

		static bool n_IsSubscreenFocus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubscreenFocus;
		}
#pragma warning restore 0169

		static Delegate cb_setSubscreenFocus_Z;
#pragma warning disable 0169
		static Delegate GetSetSubscreenFocus_ZHandler ()
		{
			if (cb_setSubscreenFocus_Z == null)
				cb_setSubscreenFocus_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSubscreenFocus_Z);
			return cb_setSubscreenFocus_Z;
		}

		static void n_SetSubscreenFocus_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubscreenFocus = p0;
		}
#pragma warning restore 0169

		IntPtr id_isSubscreenFocus;
		IntPtr id_setSubscreenFocus_Z;
		public unsafe bool SubscreenFocus {
			get {
				if (id_isSubscreenFocus == IntPtr.Zero)
					id_isSubscreenFocus = JNIEnv.GetMethodID (class_ref, "isSubscreenFocus", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSubscreenFocus);
			}
			set {
				if (id_setSubscreenFocus_Z == IntPtr.Zero)
					id_setSubscreenFocus_Z = JNIEnv.GetMethodID (class_ref, "setSubscreenFocus", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSubscreenFocus_Z, __args);
			}
		}

		static Delegate cb_isSubscreenTouchable;
#pragma warning disable 0169
		static Delegate GetIsSubscreenTouchableHandler ()
		{
			if (cb_isSubscreenTouchable == null)
				cb_isSubscreenTouchable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSubscreenTouchable);
			return cb_isSubscreenTouchable;
		}

		static bool n_IsSubscreenTouchable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubscreenTouchable;
		}
#pragma warning restore 0169

		static Delegate cb_setSubscreenTouchable_Z;
#pragma warning disable 0169
		static Delegate GetSetSubscreenTouchable_ZHandler ()
		{
			if (cb_setSubscreenTouchable_Z == null)
				cb_setSubscreenTouchable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSubscreenTouchable_Z);
			return cb_setSubscreenTouchable_Z;
		}

		static void n_SetSubscreenTouchable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubscreenTouchable = p0;
		}
#pragma warning restore 0169

		IntPtr id_isSubscreenTouchable;
		IntPtr id_setSubscreenTouchable_Z;
		public unsafe bool SubscreenTouchable {
			get {
				if (id_isSubscreenTouchable == IntPtr.Zero)
					id_isSubscreenTouchable = JNIEnv.GetMethodID (class_ref, "isSubscreenTouchable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSubscreenTouchable);
			}
			set {
				if (id_setSubscreenTouchable_Z == IntPtr.Zero)
					id_setSubscreenTouchable_Z = JNIEnv.GetMethodID (class_ref, "setSubscreenTouchable", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSubscreenTouchable_Z, __args);
			}
		}

		static Delegate cb_autoCutPaper;
#pragma warning disable 0169
		static Delegate GetAutoCutPaperHandler ()
		{
			if (cb_autoCutPaper == null)
				cb_autoCutPaper = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AutoCutPaper);
			return cb_autoCutPaper;
		}

		static void n_AutoCutPaper (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoCutPaper ();
		}
#pragma warning restore 0169

		IntPtr id_autoCutPaper;
		public unsafe void AutoCutPaper ()
		{
			if (id_autoCutPaper == IntPtr.Zero)
				id_autoCutPaper = JNIEnv.GetMethodID (class_ref, "autoCutPaper", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_autoCutPaper);
		}

		static Delegate cb_getWindowDisplayScreen_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetGetWindowDisplayScreen_Landroid_os_IBinder_Handler ()
		{
			if (cb_getWindowDisplayScreen_Landroid_os_IBinder_ == null)
				cb_getWindowDisplayScreen_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetWindowDisplayScreen_Landroid_os_IBinder_);
			return cb_getWindowDisplayScreen_Landroid_os_IBinder_;
		}

		static int n_GetWindowDisplayScreen_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder p0 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetWindowDisplayScreen (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getWindowDisplayScreen_Landroid_os_IBinder_;
		public unsafe int GetWindowDisplayScreen (global::Android.OS.IBinder p0)
		{
			if (id_getWindowDisplayScreen_Landroid_os_IBinder_ == IntPtr.Zero)
				id_getWindowDisplayScreen_Landroid_os_IBinder_ = JNIEnv.GetMethodID (class_ref, "getWindowDisplayScreen", "(Landroid/os/IBinder;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWindowDisplayScreen_Landroid_os_IBinder_, __args);
			return __ret;
		}

		static Delegate cb_registerMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_;
#pragma warning disable 0169
		static Delegate GetRegisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_Handler ()
		{
			if (cb_registerMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ == null)
				cb_registerMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_);
			return cb_registerMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_;
		}

		static void n_RegisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterMessageReceiver (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_registerMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_;
		public unsafe void RegisterMessageReceiver (string p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver p1)
		{
			if (id_registerMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ == IntPtr.Zero)
				id_registerMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ = JNIEnv.GetMethodID (class_ref, "registerMessageReceiver", "(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/casher/AidlCasherMessageReceiver;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_removeAppFromSubscreen_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveAppFromSubscreen_Ljava_lang_String_Handler ()
		{
			if (cb_removeAppFromSubscreen_Ljava_lang_String_ == null)
				cb_removeAppFromSubscreen_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveAppFromSubscreen_Ljava_lang_String_);
			return cb_removeAppFromSubscreen_Ljava_lang_String_;
		}

		static void n_RemoveAppFromSubscreen_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAppFromSubscreen (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeAppFromSubscreen_Ljava_lang_String_;
		public unsafe void RemoveAppFromSubscreen (string p0)
		{
			if (id_removeAppFromSubscreen_Ljava_lang_String_ == IntPtr.Zero)
				id_removeAppFromSubscreen_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeAppFromSubscreen", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAppFromSubscreen_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_sendMessage_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendMessage_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendMessage_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_sendMessage_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendMessage_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_sendMessage_Ljava_lang_String_Landroid_os_Bundle_;
		public unsafe void SendMessage (string p0, global::Android.OS.Bundle p1)
		{
			if (id_sendMessage_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_sendMessage_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Ljava_lang_String_Landroid_os_Bundle_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_startActivityOnSubscreen_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStartActivityOnSubscreen_Landroid_content_Intent_Handler ()
		{
			if (cb_startActivityOnSubscreen_Landroid_content_Intent_ == null)
				cb_startActivityOnSubscreen_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartActivityOnSubscreen_Landroid_content_Intent_);
			return cb_startActivityOnSubscreen_Landroid_content_Intent_;
		}

		static void n_StartActivityOnSubscreen_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityOnSubscreen (p0);
		}
#pragma warning restore 0169

		IntPtr id_startActivityOnSubscreen_Landroid_content_Intent_;
		public unsafe void StartActivityOnSubscreen (global::Android.Content.Intent p0)
		{
			if (id_startActivityOnSubscreen_Landroid_content_Intent_ == IntPtr.Zero)
				id_startActivityOnSubscreen_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "startActivityOnSubscreen", "(Landroid/content/Intent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startActivityOnSubscreen_Landroid_content_Intent_, __args);
		}

		static Delegate cb_startAppOnSubscreen_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartAppOnSubscreen_Ljava_lang_String_Handler ()
		{
			if (cb_startAppOnSubscreen_Ljava_lang_String_ == null)
				cb_startAppOnSubscreen_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartAppOnSubscreen_Ljava_lang_String_);
			return cb_startAppOnSubscreen_Ljava_lang_String_;
		}

		static void n_StartAppOnSubscreen_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartAppOnSubscreen (p0);
		}
#pragma warning restore 0169

		IntPtr id_startAppOnSubscreen_Ljava_lang_String_;
		public unsafe void StartAppOnSubscreen (string p0)
		{
			if (id_startAppOnSubscreen_Ljava_lang_String_ == IntPtr.Zero)
				id_startAppOnSubscreen_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "startAppOnSubscreen", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startAppOnSubscreen_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_unregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_;
#pragma warning disable 0169
		static Delegate GetUnregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_Handler ()
		{
			if (cb_unregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ == null)
				cb_unregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UnregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_);
			return cb_unregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_;
		}

		static void n_UnregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterMessageReceiver (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_unregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_;
		public unsafe void UnregisterMessageReceiver (string p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasherMessageReceiver p1)
		{
			if (id_unregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ == IntPtr.Zero)
				id_unregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_ = JNIEnv.GetMethodID (class_ref, "unregisterMessageReceiver", "(Ljava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/casher/AidlCasherMessageReceiver;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterMessageReceiver_Ljava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_casher_AidlCasherMessageReceiver_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlCasher> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
