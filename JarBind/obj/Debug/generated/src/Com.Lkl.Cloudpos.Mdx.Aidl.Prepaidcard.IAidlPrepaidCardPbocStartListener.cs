using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCardPbocStartListener.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPbocStartListener$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlPrepaidCardPbocStartListenerStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPbocStartListener$Stub", typeof (AidlPrepaidCardPbocStartListenerStub));
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

		protected AidlPrepaidCardPbocStartListenerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCardPbocStartListener.Stub']/constructor[@name='AidlPrepaidCardPbocStartListener.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlPrepaidCardPbocStartListenerStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCardPbocStartListener.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCardPbocStartListener.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPbocStartListener;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPbocStartListener;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCardPbocStartListener.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_onConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_;
#pragma warning disable 0169
		static Delegate GetOnConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_Handler ()
		{
			if (cb_onConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_ == null)
				cb_onConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_);
			return cb_onConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_;
		}

		static void n_OnConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConfirmCardInfo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onConfirmCardInfo' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.prepaidcard.PrepaidCardInfo']]"
		[Register ("onConfirmCardInfo", "(Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardInfo;)V", "GetOnConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_Handler")]
		public abstract void OnConfirmCardInfo (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo p0);

		static Delegate cb_onError_I;
#pragma warning disable 0169
		static Delegate GetOnError_IHandler ()
		{
			if (cb_onError_I == null)
				cb_onError_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnError_I);
			return cb_onError_I;
		}

		static void n_OnError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler")]
		public abstract void OnError (int p0);

		static Delegate cb_onReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_;
#pragma warning disable 0169
		static Delegate GetOnReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_Handler ()
		{
			if (cb_onReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_ == null)
				cb_onReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_);
			return cb_onReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_;
		}

		static void n_OnReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog[] p2 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog));
			__this.OnReadCardLoadLog (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onReadCardLoadLog' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.lkl.cloudpos.mdx.aidl.prepaidcard.PrepaidCardLoadLog[]']]"
		[Register ("onReadCardLoadLog", "(Ljava/lang/String;Ljava/lang/String;[Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardLoadLog;)V", "GetOnReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_Handler")]
		public abstract void OnReadCardLoadLog (string p0, string p1, global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog[] p2);

		static Delegate cb_onReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_onReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnReadCardOffLineBalance (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onReadCardOffLineBalance' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onReadCardOffLineBalance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void OnReadCardOffLineBalance (string p0, string p1, string p2, string p3);

		static Delegate cb_onReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_;
#pragma warning disable 0169
		static Delegate GetOnReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_Handler ()
		{
			if (cb_onReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_ == null)
				cb_onReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_);
			return cb_onReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_;
		}

		static void n_OnReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog[] p0 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog));
			__this.OnReadCardTransLog (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onReadCardTransLog' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.prepaidcard.PrepaidCardTransLog[]']]"
		[Register ("onReadCardTransLog", "([Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardTransLog;)V", "GetOnReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_Handler")]
		public abstract void OnReadCardTransLog (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog[] p0);

		static Delegate cb_onRequestOnline;
#pragma warning disable 0169
		static Delegate GetOnRequestOnlineHandler ()
		{
			if (cb_onRequestOnline == null)
				cb_onRequestOnline = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRequestOnline);
			return cb_onRequestOnline;
		}

		static void n_OnRequestOnline (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestOnline ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onRequestOnline' and count(parameter)=0]"
		[Register ("onRequestOnline", "()V", "GetOnRequestOnlineHandler")]
		public abstract void OnRequestOnline ();

		static Delegate cb_onTransResult_I;
#pragma warning disable 0169
		static Delegate GetOnTransResult_IHandler ()
		{
			if (cb_onTransResult_I == null)
				cb_onTransResult_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnTransResult_I);
			return cb_onTransResult_I;
		}

		static void n_OnTransResult_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTransResult (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onTransResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTransResult", "(I)V", "GetOnTransResult_IHandler")]
		public abstract void OnTransResult (int p0);

		static Delegate cb_requestAidSelect_IarrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequestAidSelect_IarrayLjava_lang_String_Handler ()
		{
			if (cb_requestAidSelect_IarrayLjava_lang_String_ == null)
				cb_requestAidSelect_IarrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_RequestAidSelect_IarrayLjava_lang_String_);
			return cb_requestAidSelect_IarrayLjava_lang_String_;
		}

		static void n_RequestAidSelect_IarrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.RequestAidSelect (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestAidSelect' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("requestAidSelect", "(I[Ljava/lang/String;)V", "GetRequestAidSelect_IarrayLjava_lang_String_Handler")]
		public abstract void RequestAidSelect (int p0, string[] p1);

		static Delegate cb_requestEcashTipsConfirm;
#pragma warning disable 0169
		static Delegate GetRequestEcashTipsConfirmHandler ()
		{
			if (cb_requestEcashTipsConfirm == null)
				cb_requestEcashTipsConfirm = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestEcashTipsConfirm);
			return cb_requestEcashTipsConfirm;
		}

		static void n_RequestEcashTipsConfirm (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestEcashTipsConfirm ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestEcashTipsConfirm' and count(parameter)=0]"
		[Register ("requestEcashTipsConfirm", "()V", "GetRequestEcashTipsConfirmHandler")]
		public abstract void RequestEcashTipsConfirm ();

		static Delegate cb_requestImportAmount_I;
#pragma warning disable 0169
		static Delegate GetRequestImportAmount_IHandler ()
		{
			if (cb_requestImportAmount_I == null)
				cb_requestImportAmount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RequestImportAmount_I);
			return cb_requestImportAmount_I;
		}

		static void n_RequestImportAmount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestImportAmount (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestImportAmount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestImportAmount", "(I)V", "GetRequestImportAmount_IHandler")]
		public abstract void RequestImportAmount (int p0);

		static Delegate cb_requestImportPin_IZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequestImportPin_IZLjava_lang_String_Handler ()
		{
			if (cb_requestImportPin_IZLjava_lang_String_ == null)
				cb_requestImportPin_IZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool, IntPtr>) n_RequestImportPin_IZLjava_lang_String_);
			return cb_requestImportPin_IZLjava_lang_String_;
		}

		static void n_RequestImportPin_IZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, bool p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RequestImportPin (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestImportPin' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String']]"
		[Register ("requestImportPin", "(IZLjava/lang/String;)V", "GetRequestImportPin_IZLjava_lang_String_Handler")]
		public abstract void RequestImportPin (int p0, bool p1, string p2);

		static Delegate cb_requestTipsConfirm_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequestTipsConfirm_Ljava_lang_String_Handler ()
		{
			if (cb_requestTipsConfirm_Ljava_lang_String_ == null)
				cb_requestTipsConfirm_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestTipsConfirm_Ljava_lang_String_);
			return cb_requestTipsConfirm_Ljava_lang_String_;
		}

		static void n_RequestTipsConfirm_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestTipsConfirm (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestTipsConfirm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("requestTipsConfirm", "(Ljava/lang/String;)V", "GetRequestTipsConfirm_Ljava_lang_String_Handler")]
		public abstract void RequestTipsConfirm (string p0);

		static Delegate cb_requestUserAuth_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequestUserAuth_ILjava_lang_String_Handler ()
		{
			if (cb_requestUserAuth_ILjava_lang_String_ == null)
				cb_requestUserAuth_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_RequestUserAuth_ILjava_lang_String_);
			return cb_requestUserAuth_ILjava_lang_String_;
		}

		static void n_RequestUserAuth_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RequestUserAuth (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestUserAuth' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("requestUserAuth", "(ILjava/lang/String;)V", "GetRequestUserAuth_ILjava_lang_String_Handler")]
		public abstract void RequestUserAuth (int p0, string p1);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPbocStartListener$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlPrepaidCardPbocStartListenerStubInvoker : AidlPrepaidCardPbocStartListenerStub {

		public AidlPrepaidCardPbocStartListenerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPbocStartListener$Stub", typeof (AidlPrepaidCardPbocStartListenerStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onConfirmCardInfo' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.prepaidcard.PrepaidCardInfo']]"
		[Register ("onConfirmCardInfo", "(Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardInfo;)V", "GetOnConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_Handler")]
		public override unsafe void OnConfirmCardInfo (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo p0)
		{
			const string __id = "onConfirmCardInfo.(Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler")]
		public override unsafe void OnError (int p0)
		{
			const string __id = "onError.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onReadCardLoadLog' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.lkl.cloudpos.mdx.aidl.prepaidcard.PrepaidCardLoadLog[]']]"
		[Register ("onReadCardLoadLog", "(Ljava/lang/String;Ljava/lang/String;[Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardLoadLog;)V", "GetOnReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_Handler")]
		public override unsafe void OnReadCardLoadLog (string p0, string p1, global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog[] p2)
		{
			const string __id = "onReadCardLoadLog.(Ljava/lang/String;Ljava/lang/String;[Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardLoadLog;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onReadCardOffLineBalance' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onReadCardOffLineBalance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void OnReadCardOffLineBalance (string p0, string p1, string p2, string p3)
		{
			const string __id = "onReadCardOffLineBalance.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onReadCardTransLog' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.prepaidcard.PrepaidCardTransLog[]']]"
		[Register ("onReadCardTransLog", "([Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardTransLog;)V", "GetOnReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_Handler")]
		public override unsafe void OnReadCardTransLog (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog[] p0)
		{
			const string __id = "onReadCardTransLog.([Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardTransLog;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onRequestOnline' and count(parameter)=0]"
		[Register ("onRequestOnline", "()V", "GetOnRequestOnlineHandler")]
		public override unsafe void OnRequestOnline ()
		{
			const string __id = "onRequestOnline.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onTransResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTransResult", "(I)V", "GetOnTransResult_IHandler")]
		public override unsafe void OnTransResult (int p0)
		{
			const string __id = "onTransResult.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestAidSelect' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("requestAidSelect", "(I[Ljava/lang/String;)V", "GetRequestAidSelect_IarrayLjava_lang_String_Handler")]
		public override unsafe void RequestAidSelect (int p0, string[] p1)
		{
			const string __id = "requestAidSelect.(I[Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestEcashTipsConfirm' and count(parameter)=0]"
		[Register ("requestEcashTipsConfirm", "()V", "GetRequestEcashTipsConfirmHandler")]
		public override unsafe void RequestEcashTipsConfirm ()
		{
			const string __id = "requestEcashTipsConfirm.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestImportAmount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestImportAmount", "(I)V", "GetRequestImportAmount_IHandler")]
		public override unsafe void RequestImportAmount (int p0)
		{
			const string __id = "requestImportAmount.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestImportPin' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String']]"
		[Register ("requestImportPin", "(IZLjava/lang/String;)V", "GetRequestImportPin_IZLjava_lang_String_Handler")]
		public override unsafe void RequestImportPin (int p0, bool p1, string p2)
		{
			const string __id = "requestImportPin.(IZLjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestTipsConfirm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("requestTipsConfirm", "(Ljava/lang/String;)V", "GetRequestTipsConfirm_Ljava_lang_String_Handler")]
		public override unsafe void RequestTipsConfirm (string p0)
		{
			const string __id = "requestTipsConfirm.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestUserAuth' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("requestUserAuth", "(ILjava/lang/String;)V", "GetRequestUserAuth_ILjava_lang_String_Handler")]
		public override unsafe void RequestUserAuth (int p0, string p1)
		{
			const string __id = "requestUserAuth.(ILjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']"
	[Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPbocStartListener", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker")]
	public partial interface IAidlPrepaidCardPbocStartListener : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onConfirmCardInfo' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.prepaidcard.PrepaidCardInfo']]"
		[Register ("onConfirmCardInfo", "(Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardInfo;)V", "GetOnConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void OnConfirmCardInfo (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void OnError (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onReadCardLoadLog' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.lkl.cloudpos.mdx.aidl.prepaidcard.PrepaidCardLoadLog[]']]"
		[Register ("onReadCardLoadLog", "(Ljava/lang/String;Ljava/lang/String;[Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardLoadLog;)V", "GetOnReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void OnReadCardLoadLog (string p0, string p1, global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onReadCardOffLineBalance' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("onReadCardOffLineBalance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void OnReadCardOffLineBalance (string p0, string p1, string p2, string p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onReadCardTransLog' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.prepaidcard.PrepaidCardTransLog[]']]"
		[Register ("onReadCardTransLog", "([Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardTransLog;)V", "GetOnReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void OnReadCardTransLog (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onRequestOnline' and count(parameter)=0]"
		[Register ("onRequestOnline", "()V", "GetOnRequestOnlineHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void OnRequestOnline ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='onTransResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onTransResult", "(I)V", "GetOnTransResult_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void OnTransResult (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestAidSelect' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("requestAidSelect", "(I[Ljava/lang/String;)V", "GetRequestAidSelect_IarrayLjava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void RequestAidSelect (int p0, string[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestEcashTipsConfirm' and count(parameter)=0]"
		[Register ("requestEcashTipsConfirm", "()V", "GetRequestEcashTipsConfirmHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void RequestEcashTipsConfirm ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestImportAmount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("requestImportAmount", "(I)V", "GetRequestImportAmount_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void RequestImportAmount (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestImportPin' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String']]"
		[Register ("requestImportPin", "(IZLjava/lang/String;)V", "GetRequestImportPin_IZLjava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void RequestImportPin (int p0, bool p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestTipsConfirm' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("requestTipsConfirm", "(Ljava/lang/String;)V", "GetRequestTipsConfirm_Ljava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void RequestTipsConfirm (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPbocStartListener']/method[@name='requestUserAuth' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("requestUserAuth", "(ILjava/lang/String;)V", "GetRequestUserAuth_ILjava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListenerInvoker, JarBind")]
		void RequestUserAuth (int p0, string p1);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPbocStartListener", DoNotGenerateAcw=true)]
	internal class IAidlPrepaidCardPbocStartListenerInvoker : global::Java.Lang.Object, IAidlPrepaidCardPbocStartListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPbocStartListener", typeof (IAidlPrepaidCardPbocStartListenerInvoker));

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

		public static IAidlPrepaidCardPbocStartListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlPrepaidCardPbocStartListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.prepaidcard.AidlPrepaidCardPbocStartListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlPrepaidCardPbocStartListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_;
#pragma warning disable 0169
		static Delegate GetOnConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_Handler ()
		{
			if (cb_onConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_ == null)
				cb_onConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_);
			return cb_onConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_;
		}

		static void n_OnConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConfirmCardInfo (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_;
		public unsafe void OnConfirmCardInfo (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo p0)
		{
			if (id_onConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_ == IntPtr.Zero)
				id_onConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_ = JNIEnv.GetMethodID (class_ref, "onConfirmCardInfo", "(Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConfirmCardInfo_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardInfo_, __args);
		}

		static Delegate cb_onError_I;
#pragma warning disable 0169
		static Delegate GetOnError_IHandler ()
		{
			if (cb_onError_I == null)
				cb_onError_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnError_I);
			return cb_onError_I;
		}

		static void n_OnError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_I;
		public unsafe void OnError (int p0)
		{
			if (id_onError_I == IntPtr.Zero)
				id_onError_I = JNIEnv.GetMethodID (class_ref, "onError", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_I, __args);
		}

		static Delegate cb_onReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_;
#pragma warning disable 0169
		static Delegate GetOnReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_Handler ()
		{
			if (cb_onReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_ == null)
				cb_onReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_);
			return cb_onReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_;
		}

		static void n_OnReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog[] p2 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog));
			__this.OnReadCardLoadLog (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_onReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_;
		public unsafe void OnReadCardLoadLog (string p0, string p1, global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog[] p2)
		{
			if (id_onReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_ == IntPtr.Zero)
				id_onReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_ = JNIEnv.GetMethodID (class_ref, "onReadCardLoadLog", "(Ljava/lang/String;Ljava/lang/String;[Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardLoadLog;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadCardLoadLog_Ljava_lang_String_Ljava_lang_String_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardLoadLog_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_onReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_onReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnReadCardOffLineBalance (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnReadCardOffLineBalance (string p0, string p1, string p2, string p3)
		{
			if (id_onReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReadCardOffLineBalance", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadCardOffLineBalance_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

		static Delegate cb_onReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_;
#pragma warning disable 0169
		static Delegate GetOnReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_Handler ()
		{
			if (cb_onReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_ == null)
				cb_onReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_);
			return cb_onReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_;
		}

		static void n_OnReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog[] p0 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog));
			__this.OnReadCardTransLog (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_;
		public unsafe void OnReadCardTransLog (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog[] p0)
		{
			if (id_onReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_ == IntPtr.Zero)
				id_onReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_ = JNIEnv.GetMethodID (class_ref, "onReadCardTransLog", "([Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardTransLog;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadCardTransLog_arrayLcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardTransLog_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onRequestOnline;
#pragma warning disable 0169
		static Delegate GetOnRequestOnlineHandler ()
		{
			if (cb_onRequestOnline == null)
				cb_onRequestOnline = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRequestOnline);
			return cb_onRequestOnline;
		}

		static void n_OnRequestOnline (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRequestOnline ();
		}
#pragma warning restore 0169

		IntPtr id_onRequestOnline;
		public unsafe void OnRequestOnline ()
		{
			if (id_onRequestOnline == IntPtr.Zero)
				id_onRequestOnline = JNIEnv.GetMethodID (class_ref, "onRequestOnline", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRequestOnline);
		}

		static Delegate cb_onTransResult_I;
#pragma warning disable 0169
		static Delegate GetOnTransResult_IHandler ()
		{
			if (cb_onTransResult_I == null)
				cb_onTransResult_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnTransResult_I);
			return cb_onTransResult_I;
		}

		static void n_OnTransResult_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTransResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTransResult_I;
		public unsafe void OnTransResult (int p0)
		{
			if (id_onTransResult_I == IntPtr.Zero)
				id_onTransResult_I = JNIEnv.GetMethodID (class_ref, "onTransResult", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTransResult_I, __args);
		}

		static Delegate cb_requestAidSelect_IarrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequestAidSelect_IarrayLjava_lang_String_Handler ()
		{
			if (cb_requestAidSelect_IarrayLjava_lang_String_ == null)
				cb_requestAidSelect_IarrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_RequestAidSelect_IarrayLjava_lang_String_);
			return cb_requestAidSelect_IarrayLjava_lang_String_;
		}

		static void n_RequestAidSelect_IarrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.RequestAidSelect (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_requestAidSelect_IarrayLjava_lang_String_;
		public unsafe void RequestAidSelect (int p0, string[] p1)
		{
			if (id_requestAidSelect_IarrayLjava_lang_String_ == IntPtr.Zero)
				id_requestAidSelect_IarrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "requestAidSelect", "(I[Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestAidSelect_IarrayLjava_lang_String_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_requestEcashTipsConfirm;
#pragma warning disable 0169
		static Delegate GetRequestEcashTipsConfirmHandler ()
		{
			if (cb_requestEcashTipsConfirm == null)
				cb_requestEcashTipsConfirm = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestEcashTipsConfirm);
			return cb_requestEcashTipsConfirm;
		}

		static void n_RequestEcashTipsConfirm (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestEcashTipsConfirm ();
		}
#pragma warning restore 0169

		IntPtr id_requestEcashTipsConfirm;
		public unsafe void RequestEcashTipsConfirm ()
		{
			if (id_requestEcashTipsConfirm == IntPtr.Zero)
				id_requestEcashTipsConfirm = JNIEnv.GetMethodID (class_ref, "requestEcashTipsConfirm", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestEcashTipsConfirm);
		}

		static Delegate cb_requestImportAmount_I;
#pragma warning disable 0169
		static Delegate GetRequestImportAmount_IHandler ()
		{
			if (cb_requestImportAmount_I == null)
				cb_requestImportAmount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RequestImportAmount_I);
			return cb_requestImportAmount_I;
		}

		static void n_RequestImportAmount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestImportAmount (p0);
		}
#pragma warning restore 0169

		IntPtr id_requestImportAmount_I;
		public unsafe void RequestImportAmount (int p0)
		{
			if (id_requestImportAmount_I == IntPtr.Zero)
				id_requestImportAmount_I = JNIEnv.GetMethodID (class_ref, "requestImportAmount", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestImportAmount_I, __args);
		}

		static Delegate cb_requestImportPin_IZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequestImportPin_IZLjava_lang_String_Handler ()
		{
			if (cb_requestImportPin_IZLjava_lang_String_ == null)
				cb_requestImportPin_IZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool, IntPtr>) n_RequestImportPin_IZLjava_lang_String_);
			return cb_requestImportPin_IZLjava_lang_String_;
		}

		static void n_RequestImportPin_IZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, bool p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.RequestImportPin (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_requestImportPin_IZLjava_lang_String_;
		public unsafe void RequestImportPin (int p0, bool p1, string p2)
		{
			if (id_requestImportPin_IZLjava_lang_String_ == IntPtr.Zero)
				id_requestImportPin_IZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "requestImportPin", "(IZLjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestImportPin_IZLjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_requestTipsConfirm_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequestTipsConfirm_Ljava_lang_String_Handler ()
		{
			if (cb_requestTipsConfirm_Ljava_lang_String_ == null)
				cb_requestTipsConfirm_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestTipsConfirm_Ljava_lang_String_);
			return cb_requestTipsConfirm_Ljava_lang_String_;
		}

		static void n_RequestTipsConfirm_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestTipsConfirm (p0);
		}
#pragma warning restore 0169

		IntPtr id_requestTipsConfirm_Ljava_lang_String_;
		public unsafe void RequestTipsConfirm (string p0)
		{
			if (id_requestTipsConfirm_Ljava_lang_String_ == IntPtr.Zero)
				id_requestTipsConfirm_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "requestTipsConfirm", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestTipsConfirm_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_requestUserAuth_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequestUserAuth_ILjava_lang_String_Handler ()
		{
			if (cb_requestUserAuth_ILjava_lang_String_ == null)
				cb_requestUserAuth_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_RequestUserAuth_ILjava_lang_String_);
			return cb_requestUserAuth_ILjava_lang_String_;
		}

		static void n_RequestUserAuth_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RequestUserAuth (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_requestUserAuth_ILjava_lang_String_;
		public unsafe void RequestUserAuth (int p0, string p1)
		{
			if (id_requestUserAuth_ILjava_lang_String_ == IntPtr.Zero)
				id_requestUserAuth_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "requestUserAuth", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestUserAuth_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPbocStartListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
