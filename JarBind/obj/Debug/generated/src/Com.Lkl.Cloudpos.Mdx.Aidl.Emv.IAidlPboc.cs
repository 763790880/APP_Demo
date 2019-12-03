using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Emv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/class[@name='AidlPboc.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/emv/AidlPboc$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlPbocStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/emv/AidlPboc$Stub", typeof (AidlPbocStub));
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

		protected AidlPbocStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/class[@name='AidlPboc.Stub']/constructor[@name='AidlPboc.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlPbocStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/class[@name='AidlPboc.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/class[@name='AidlPboc.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/emv/AidlPboc;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/emv/AidlPboc;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/class[@name='AidlPboc.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_abortPBOC;
#pragma warning disable 0169
		static Delegate GetAbortPBOCHandler ()
		{
			if (cb_abortPBOC == null)
				cb_abortPBOC = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AbortPBOC);
			return cb_abortPBOC;
		}

		static void n_AbortPBOC (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AbortPBOC ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='abortPBOC' and count(parameter)=0]"
		[Register ("abortPBOC", "()V", "GetAbortPBOCHandler")]
		public abstract void AbortPBOC ();

		static Delegate cb_cancelCheckCard;
#pragma warning disable 0169
		static Delegate GetCancelCheckCardHandler ()
		{
			if (cb_cancelCheckCard == null)
				cb_cancelCheckCard = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelCheckCard);
			return cb_cancelCheckCard;
		}

		static void n_CancelCheckCard (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelCheckCard ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='cancelCheckCard' and count(parameter)=0]"
		[Register ("cancelCheckCard", "()V", "GetCancelCheckCardHandler")]
		public abstract void CancelCheckCard ();

		static Delegate cb_checkCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_;
#pragma warning disable 0169
		static Delegate GetCheckCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_Handler ()
		{
			if (cb_checkCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_ == null)
				cb_checkCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool, bool, int, IntPtr>) n_CheckCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_);
			return cb_checkCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_;
		}

		static void n_CheckCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1, bool p2, int p3, IntPtr native_p4)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlCheckCardListener p4 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlCheckCardListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlCheckCardListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.CheckCard (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='checkCard' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int'] and parameter[5][@type='com.lkl.cloudpos.mdx.aidl.emv.AidlCheckCardListener']]"
		[Register ("checkCard", "(ZZZILcom/lkl/cloudpos/mdx/aidl/emv/AidlCheckCardListener;)V", "GetCheckCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_Handler")]
		public abstract void CheckCard (bool p0, bool p1, bool p2, int p3, global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlCheckCardListener p4);

		static Delegate cb_clearKernelICTransLog;
#pragma warning disable 0169
		static Delegate GetClearKernelICTransLogHandler ()
		{
			if (cb_clearKernelICTransLog == null)
				cb_clearKernelICTransLog = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ClearKernelICTransLog);
			return cb_clearKernelICTransLog;
		}

		static bool n_ClearKernelICTransLog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClearKernelICTransLog ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='clearKernelICTransLog' and count(parameter)=0]"
		[Register ("clearKernelICTransLog", "()Z", "GetClearKernelICTransLogHandler")]
		public abstract bool ClearKernelICTransLog ();

		static Delegate cb_endPBOC;
#pragma warning disable 0169
		static Delegate GetEndPBOCHandler ()
		{
			if (cb_endPBOC == null)
				cb_endPBOC = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndPBOC);
			return cb_endPBOC;
		}

		static void n_EndPBOC (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndPBOC ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='endPBOC' and count(parameter)=0]"
		[Register ("endPBOC", "()V", "GetEndPBOCHandler")]
		public abstract void EndPBOC ();

		static Delegate cb_importAidSelectRes_I;
#pragma warning disable 0169
		static Delegate GetImportAidSelectRes_IHandler ()
		{
			if (cb_importAidSelectRes_I == null)
				cb_importAidSelectRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_ImportAidSelectRes_I);
			return cb_importAidSelectRes_I;
		}

		static bool n_ImportAidSelectRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImportAidSelectRes (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importAidSelectRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("importAidSelectRes", "(I)Z", "GetImportAidSelectRes_IHandler")]
		public abstract bool ImportAidSelectRes (int p0);

		static Delegate cb_importAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImportAmount_Ljava_lang_String_Handler ()
		{
			if (cb_importAmount_Ljava_lang_String_ == null)
				cb_importAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ImportAmount_Ljava_lang_String_);
			return cb_importAmount_Ljava_lang_String_;
		}

		static bool n_ImportAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ImportAmount (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("importAmount", "(Ljava/lang/String;)Z", "GetImportAmount_Ljava_lang_String_Handler")]
		public abstract bool ImportAmount (string p0);

		static Delegate cb_importConfirmCardInfoRes_Z;
#pragma warning disable 0169
		static Delegate GetImportConfirmCardInfoRes_ZHandler ()
		{
			if (cb_importConfirmCardInfoRes_Z == null)
				cb_importConfirmCardInfoRes_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_ImportConfirmCardInfoRes_Z);
			return cb_importConfirmCardInfoRes_Z;
		}

		static bool n_ImportConfirmCardInfoRes_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImportConfirmCardInfoRes (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importConfirmCardInfoRes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("importConfirmCardInfoRes", "(Z)Z", "GetImportConfirmCardInfoRes_ZHandler")]
		public abstract bool ImportConfirmCardInfoRes (bool p0);

		static Delegate cb_importECashTipConfirmRes_Z;
#pragma warning disable 0169
		static Delegate GetImportECashTipConfirmRes_ZHandler ()
		{
			if (cb_importECashTipConfirmRes_Z == null)
				cb_importECashTipConfirmRes_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_ImportECashTipConfirmRes_Z);
			return cb_importECashTipConfirmRes_Z;
		}

		static bool n_ImportECashTipConfirmRes_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImportECashTipConfirmRes (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importECashTipConfirmRes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("importECashTipConfirmRes", "(Z)Z", "GetImportECashTipConfirmRes_ZHandler")]
		public abstract bool ImportECashTipConfirmRes (bool p0);

		static Delegate cb_importMsgConfirmRes_Z;
#pragma warning disable 0169
		static Delegate GetImportMsgConfirmRes_ZHandler ()
		{
			if (cb_importMsgConfirmRes_Z == null)
				cb_importMsgConfirmRes_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_ImportMsgConfirmRes_Z);
			return cb_importMsgConfirmRes_Z;
		}

		static bool n_ImportMsgConfirmRes_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImportMsgConfirmRes (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importMsgConfirmRes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("importMsgConfirmRes", "(Z)Z", "GetImportMsgConfirmRes_ZHandler")]
		public abstract bool ImportMsgConfirmRes (bool p0);

		static Delegate cb_importOnlineResp_ZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImportOnlineResp_ZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_importOnlineResp_ZLjava_lang_String_Ljava_lang_String_ == null)
				cb_importOnlineResp_ZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr, IntPtr, bool>) n_ImportOnlineResp_ZLjava_lang_String_Ljava_lang_String_);
			return cb_importOnlineResp_ZLjava_lang_String_Ljava_lang_String_;
		}

		static bool n_ImportOnlineResp_ZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ImportOnlineResp (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importOnlineResp' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("importOnlineResp", "(ZLjava/lang/String;Ljava/lang/String;)Z", "GetImportOnlineResp_ZLjava_lang_String_Ljava_lang_String_Handler")]
		public abstract bool ImportOnlineResp (bool p0, string p1, string p2);

		static Delegate cb_importPin_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImportPin_Ljava_lang_String_Handler ()
		{
			if (cb_importPin_Ljava_lang_String_ == null)
				cb_importPin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ImportPin_Ljava_lang_String_);
			return cb_importPin_Ljava_lang_String_;
		}

		static bool n_ImportPin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ImportPin (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importPin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("importPin", "(Ljava/lang/String;)Z", "GetImportPin_Ljava_lang_String_Handler")]
		public abstract bool ImportPin (string p0);

		static Delegate cb_importUserAuthRes_Z;
#pragma warning disable 0169
		static Delegate GetImportUserAuthRes_ZHandler ()
		{
			if (cb_importUserAuthRes_Z == null)
				cb_importUserAuthRes_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_ImportUserAuthRes_Z);
			return cb_importUserAuthRes_Z;
		}

		static bool n_ImportUserAuthRes_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImportUserAuthRes (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importUserAuthRes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("importUserAuthRes", "(Z)Z", "GetImportUserAuthRes_ZHandler")]
		public abstract bool ImportUserAuthRes (bool p0);

		static Delegate cb_isExistAidPublicKey;
#pragma warning disable 0169
		static Delegate GetIsExistAidPublicKeyHandler ()
		{
			if (cb_isExistAidPublicKey == null)
				cb_isExistAidPublicKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IsExistAidPublicKey);
			return cb_isExistAidPublicKey;
		}

		static int n_IsExistAidPublicKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExistAidPublicKey ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='isExistAidPublicKey' and count(parameter)=0]"
		[Register ("isExistAidPublicKey", "()I", "GetIsExistAidPublicKeyHandler")]
		public abstract int IsExistAidPublicKey ();

		static Delegate cb_parseTLV_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParseTLV_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_parseTLV_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_parseTLV_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseTLV_Ljava_lang_String_Ljava_lang_String_);
			return cb_parseTLV_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ParseTLV_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ParseTLV (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='parseTLV' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("parseTLV", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetParseTLV_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract string ParseTLV (string p0, string p1);

		static Delegate cb_processPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_;
#pragma warning disable 0169
		static Delegate GetProcessPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_Handler ()
		{
			if (cb_processPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_ == null)
				cb_processPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_);
			return cb_processPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_;
		}

		static void n_ProcessPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.EmvTransData p0 = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.EmvTransData> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocStartListener p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocStartListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocStartListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ProcessPBOC (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='processPBOC' and count(parameter)=2 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.emv.EmvTransData'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.emv.AidlPbocStartListener']]"
		[Register ("processPBOC", "(Lcom/lkl/cloudpos/mdx/aidl/emv/EmvTransData;Lcom/lkl/cloudpos/mdx/aidl/emv/AidlPbocStartListener;)V", "GetProcessPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_Handler")]
		public abstract void ProcessPBOC (global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.EmvTransData p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocStartListener p1);

		static Delegate cb_readKernelData_arrayLjava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetReadKernelData_arrayLjava_lang_String_arrayBHandler ()
		{
			if (cb_readKernelData_arrayLjava_lang_String_arrayB == null)
				cb_readKernelData_arrayLjava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ReadKernelData_arrayLjava_lang_String_arrayB);
			return cb_readKernelData_arrayLjava_lang_String_arrayB;
		}

		static int n_ReadKernelData_arrayLjava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadKernelData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='readKernelData' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='byte[]']]"
		[Register ("readKernelData", "([Ljava/lang/String;[B)I", "GetReadKernelData_arrayLjava_lang_String_arrayBHandler")]
		public abstract int ReadKernelData (string[] p0, byte[] p1);

		static Delegate cb_setTlv_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetSetTlv_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_setTlv_Ljava_lang_String_arrayB == null)
				cb_setTlv_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTlv_Ljava_lang_String_arrayB);
			return cb_setTlv_Ljava_lang_String_arrayB;
		}

		static void n_SetTlv_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetTlv (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='setTlv' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("setTlv", "(Ljava/lang/String;[B)V", "GetSetTlv_Ljava_lang_String_arrayBHandler")]
		public abstract void SetTlv (string p0, byte[] p1);

		static Delegate cb_updateAID_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateAID_ILjava_lang_String_Handler ()
		{
			if (cb_updateAID_ILjava_lang_String_ == null)
				cb_updateAID_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_UpdateAID_ILjava_lang_String_);
			return cb_updateAID_ILjava_lang_String_;
		}

		static bool n_UpdateAID_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateAID (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='updateAID' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateAID", "(ILjava/lang/String;)Z", "GetUpdateAID_ILjava_lang_String_Handler")]
		public abstract bool UpdateAID (int p0, string p1);

		static Delegate cb_updateCAPK_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateCAPK_ILjava_lang_String_Handler ()
		{
			if (cb_updateCAPK_ILjava_lang_String_ == null)
				cb_updateCAPK_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_UpdateCAPK_ILjava_lang_String_);
			return cb_updateCAPK_ILjava_lang_String_;
		}

		static bool n_UpdateCAPK_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateCAPK (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='updateCAPK' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateCAPK", "(ILjava/lang/String;)Z", "GetUpdateCAPK_ILjava_lang_String_Handler")]
		public abstract bool UpdateCAPK (int p0, string p1);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/emv/AidlPboc$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlPbocStubInvoker : AidlPbocStub {

		public AidlPbocStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/emv/AidlPboc$Stub", typeof (AidlPbocStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='abortPBOC' and count(parameter)=0]"
		[Register ("abortPBOC", "()V", "GetAbortPBOCHandler")]
		public override unsafe void AbortPBOC ()
		{
			const string __id = "abortPBOC.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='cancelCheckCard' and count(parameter)=0]"
		[Register ("cancelCheckCard", "()V", "GetCancelCheckCardHandler")]
		public override unsafe void CancelCheckCard ()
		{
			const string __id = "cancelCheckCard.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='checkCard' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int'] and parameter[5][@type='com.lkl.cloudpos.mdx.aidl.emv.AidlCheckCardListener']]"
		[Register ("checkCard", "(ZZZILcom/lkl/cloudpos/mdx/aidl/emv/AidlCheckCardListener;)V", "GetCheckCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_Handler")]
		public override unsafe void CheckCard (bool p0, bool p1, bool p2, int p3, global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlCheckCardListener p4)
		{
			const string __id = "checkCard.(ZZZILcom/lkl/cloudpos/mdx/aidl/emv/AidlCheckCardListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='clearKernelICTransLog' and count(parameter)=0]"
		[Register ("clearKernelICTransLog", "()Z", "GetClearKernelICTransLogHandler")]
		public override unsafe bool ClearKernelICTransLog ()
		{
			const string __id = "clearKernelICTransLog.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='endPBOC' and count(parameter)=0]"
		[Register ("endPBOC", "()V", "GetEndPBOCHandler")]
		public override unsafe void EndPBOC ()
		{
			const string __id = "endPBOC.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importAidSelectRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("importAidSelectRes", "(I)Z", "GetImportAidSelectRes_IHandler")]
		public override unsafe bool ImportAidSelectRes (int p0)
		{
			const string __id = "importAidSelectRes.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("importAmount", "(Ljava/lang/String;)Z", "GetImportAmount_Ljava_lang_String_Handler")]
		public override unsafe bool ImportAmount (string p0)
		{
			const string __id = "importAmount.(Ljava/lang/String;)Z";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importConfirmCardInfoRes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("importConfirmCardInfoRes", "(Z)Z", "GetImportConfirmCardInfoRes_ZHandler")]
		public override unsafe bool ImportConfirmCardInfoRes (bool p0)
		{
			const string __id = "importConfirmCardInfoRes.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importECashTipConfirmRes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("importECashTipConfirmRes", "(Z)Z", "GetImportECashTipConfirmRes_ZHandler")]
		public override unsafe bool ImportECashTipConfirmRes (bool p0)
		{
			const string __id = "importECashTipConfirmRes.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importMsgConfirmRes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("importMsgConfirmRes", "(Z)Z", "GetImportMsgConfirmRes_ZHandler")]
		public override unsafe bool ImportMsgConfirmRes (bool p0)
		{
			const string __id = "importMsgConfirmRes.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importOnlineResp' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("importOnlineResp", "(ZLjava/lang/String;Ljava/lang/String;)Z", "GetImportOnlineResp_ZLjava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe bool ImportOnlineResp (bool p0, string p1, string p2)
		{
			const string __id = "importOnlineResp.(ZLjava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importPin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("importPin", "(Ljava/lang/String;)Z", "GetImportPin_Ljava_lang_String_Handler")]
		public override unsafe bool ImportPin (string p0)
		{
			const string __id = "importPin.(Ljava/lang/String;)Z";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importUserAuthRes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("importUserAuthRes", "(Z)Z", "GetImportUserAuthRes_ZHandler")]
		public override unsafe bool ImportUserAuthRes (bool p0)
		{
			const string __id = "importUserAuthRes.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='isExistAidPublicKey' and count(parameter)=0]"
		[Register ("isExistAidPublicKey", "()I", "GetIsExistAidPublicKeyHandler")]
		public override unsafe int IsExistAidPublicKey ()
		{
			const string __id = "isExistAidPublicKey.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='parseTLV' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("parseTLV", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetParseTLV_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe string ParseTLV (string p0, string p1)
		{
			const string __id = "parseTLV.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='processPBOC' and count(parameter)=2 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.emv.EmvTransData'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.emv.AidlPbocStartListener']]"
		[Register ("processPBOC", "(Lcom/lkl/cloudpos/mdx/aidl/emv/EmvTransData;Lcom/lkl/cloudpos/mdx/aidl/emv/AidlPbocStartListener;)V", "GetProcessPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_Handler")]
		public override unsafe void ProcessPBOC (global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.EmvTransData p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocStartListener p1)
		{
			const string __id = "processPBOC.(Lcom/lkl/cloudpos/mdx/aidl/emv/EmvTransData;Lcom/lkl/cloudpos/mdx/aidl/emv/AidlPbocStartListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='readKernelData' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='byte[]']]"
		[Register ("readKernelData", "([Ljava/lang/String;[B)I", "GetReadKernelData_arrayLjava_lang_String_arrayBHandler")]
		public override unsafe int ReadKernelData (string[] p0, byte[] p1)
		{
			const string __id = "readKernelData.([Ljava/lang/String;[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='setTlv' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("setTlv", "(Ljava/lang/String;[B)V", "GetSetTlv_Ljava_lang_String_arrayBHandler")]
		public override unsafe void SetTlv (string p0, byte[] p1)
		{
			const string __id = "setTlv.(Ljava/lang/String;[B)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='updateAID' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateAID", "(ILjava/lang/String;)Z", "GetUpdateAID_ILjava_lang_String_Handler")]
		public override unsafe bool UpdateAID (int p0, string p1)
		{
			const string __id = "updateAID.(ILjava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='updateCAPK' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateCAPK", "(ILjava/lang/String;)Z", "GetUpdateCAPK_ILjava_lang_String_Handler")]
		public override unsafe bool UpdateCAPK (int p0, string p1)
		{
			const string __id = "updateCAPK.(ILjava/lang/String;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']"
	[Register ("com/lkl/cloudpos/mdx/aidl/emv/AidlPboc", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker")]
	public partial interface IAidlPboc : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='abortPBOC' and count(parameter)=0]"
		[Register ("abortPBOC", "()V", "GetAbortPBOCHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		void AbortPBOC ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='cancelCheckCard' and count(parameter)=0]"
		[Register ("cancelCheckCard", "()V", "GetCancelCheckCardHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		void CancelCheckCard ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='checkCard' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='int'] and parameter[5][@type='com.lkl.cloudpos.mdx.aidl.emv.AidlCheckCardListener']]"
		[Register ("checkCard", "(ZZZILcom/lkl/cloudpos/mdx/aidl/emv/AidlCheckCardListener;)V", "GetCheckCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		void CheckCard (bool p0, bool p1, bool p2, int p3, global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlCheckCardListener p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='clearKernelICTransLog' and count(parameter)=0]"
		[Register ("clearKernelICTransLog", "()Z", "GetClearKernelICTransLogHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		bool ClearKernelICTransLog ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='endPBOC' and count(parameter)=0]"
		[Register ("endPBOC", "()V", "GetEndPBOCHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		void EndPBOC ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importAidSelectRes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("importAidSelectRes", "(I)Z", "GetImportAidSelectRes_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		bool ImportAidSelectRes (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importAmount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("importAmount", "(Ljava/lang/String;)Z", "GetImportAmount_Ljava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		bool ImportAmount (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importConfirmCardInfoRes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("importConfirmCardInfoRes", "(Z)Z", "GetImportConfirmCardInfoRes_ZHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		bool ImportConfirmCardInfoRes (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importECashTipConfirmRes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("importECashTipConfirmRes", "(Z)Z", "GetImportECashTipConfirmRes_ZHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		bool ImportECashTipConfirmRes (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importMsgConfirmRes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("importMsgConfirmRes", "(Z)Z", "GetImportMsgConfirmRes_ZHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		bool ImportMsgConfirmRes (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importOnlineResp' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("importOnlineResp", "(ZLjava/lang/String;Ljava/lang/String;)Z", "GetImportOnlineResp_ZLjava_lang_String_Ljava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		bool ImportOnlineResp (bool p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importPin' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("importPin", "(Ljava/lang/String;)Z", "GetImportPin_Ljava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		bool ImportPin (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='importUserAuthRes' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("importUserAuthRes", "(Z)Z", "GetImportUserAuthRes_ZHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		bool ImportUserAuthRes (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='isExistAidPublicKey' and count(parameter)=0]"
		[Register ("isExistAidPublicKey", "()I", "GetIsExistAidPublicKeyHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		int IsExistAidPublicKey ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='parseTLV' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("parseTLV", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetParseTLV_Ljava_lang_String_Ljava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		string ParseTLV (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='processPBOC' and count(parameter)=2 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.emv.EmvTransData'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.emv.AidlPbocStartListener']]"
		[Register ("processPBOC", "(Lcom/lkl/cloudpos/mdx/aidl/emv/EmvTransData;Lcom/lkl/cloudpos/mdx/aidl/emv/AidlPbocStartListener;)V", "GetProcessPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		void ProcessPBOC (global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.EmvTransData p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocStartListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='readKernelData' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='byte[]']]"
		[Register ("readKernelData", "([Ljava/lang/String;[B)I", "GetReadKernelData_arrayLjava_lang_String_arrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		int ReadKernelData (string[] p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='setTlv' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("setTlv", "(Ljava/lang/String;[B)V", "GetSetTlv_Ljava_lang_String_arrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		void SetTlv (string p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='updateAID' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateAID", "(ILjava/lang/String;)Z", "GetUpdateAID_ILjava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		bool UpdateAID (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.emv']/interface[@name='AidlPboc']/method[@name='updateCAPK' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateCAPK", "(ILjava/lang/String;)Z", "GetUpdateCAPK_ILjava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocInvoker, JarBind")]
		bool UpdateCAPK (int p0, string p1);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/emv/AidlPboc", DoNotGenerateAcw=true)]
	internal class IAidlPbocInvoker : global::Java.Lang.Object, IAidlPboc {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/emv/AidlPboc", typeof (IAidlPbocInvoker));

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

		public static IAidlPboc GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlPboc> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.emv.AidlPboc"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlPbocInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_abortPBOC;
#pragma warning disable 0169
		static Delegate GetAbortPBOCHandler ()
		{
			if (cb_abortPBOC == null)
				cb_abortPBOC = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AbortPBOC);
			return cb_abortPBOC;
		}

		static void n_AbortPBOC (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AbortPBOC ();
		}
#pragma warning restore 0169

		IntPtr id_abortPBOC;
		public unsafe void AbortPBOC ()
		{
			if (id_abortPBOC == IntPtr.Zero)
				id_abortPBOC = JNIEnv.GetMethodID (class_ref, "abortPBOC", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_abortPBOC);
		}

		static Delegate cb_cancelCheckCard;
#pragma warning disable 0169
		static Delegate GetCancelCheckCardHandler ()
		{
			if (cb_cancelCheckCard == null)
				cb_cancelCheckCard = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelCheckCard);
			return cb_cancelCheckCard;
		}

		static void n_CancelCheckCard (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelCheckCard ();
		}
#pragma warning restore 0169

		IntPtr id_cancelCheckCard;
		public unsafe void CancelCheckCard ()
		{
			if (id_cancelCheckCard == IntPtr.Zero)
				id_cancelCheckCard = JNIEnv.GetMethodID (class_ref, "cancelCheckCard", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelCheckCard);
		}

		static Delegate cb_checkCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_;
#pragma warning disable 0169
		static Delegate GetCheckCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_Handler ()
		{
			if (cb_checkCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_ == null)
				cb_checkCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool, bool, int, IntPtr>) n_CheckCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_);
			return cb_checkCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_;
		}

		static void n_CheckCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1, bool p2, int p3, IntPtr native_p4)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlCheckCardListener p4 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlCheckCardListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlCheckCardListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.CheckCard (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_checkCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_;
		public unsafe void CheckCard (bool p0, bool p1, bool p2, int p3, global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlCheckCardListener p4)
		{
			if (id_checkCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_ == IntPtr.Zero)
				id_checkCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_ = JNIEnv.GetMethodID (class_ref, "checkCard", "(ZZZILcom/lkl/cloudpos/mdx/aidl/emv/AidlCheckCardListener;)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkCard_ZZZILcom_lkl_cloudpos_mdx_aidl_emv_AidlCheckCardListener_, __args);
		}

		static Delegate cb_clearKernelICTransLog;
#pragma warning disable 0169
		static Delegate GetClearKernelICTransLogHandler ()
		{
			if (cb_clearKernelICTransLog == null)
				cb_clearKernelICTransLog = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ClearKernelICTransLog);
			return cb_clearKernelICTransLog;
		}

		static bool n_ClearKernelICTransLog (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClearKernelICTransLog ();
		}
#pragma warning restore 0169

		IntPtr id_clearKernelICTransLog;
		public unsafe bool ClearKernelICTransLog ()
		{
			if (id_clearKernelICTransLog == IntPtr.Zero)
				id_clearKernelICTransLog = JNIEnv.GetMethodID (class_ref, "clearKernelICTransLog", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_clearKernelICTransLog);
		}

		static Delegate cb_endPBOC;
#pragma warning disable 0169
		static Delegate GetEndPBOCHandler ()
		{
			if (cb_endPBOC == null)
				cb_endPBOC = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndPBOC);
			return cb_endPBOC;
		}

		static void n_EndPBOC (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndPBOC ();
		}
#pragma warning restore 0169

		IntPtr id_endPBOC;
		public unsafe void EndPBOC ()
		{
			if (id_endPBOC == IntPtr.Zero)
				id_endPBOC = JNIEnv.GetMethodID (class_ref, "endPBOC", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endPBOC);
		}

		static Delegate cb_importAidSelectRes_I;
#pragma warning disable 0169
		static Delegate GetImportAidSelectRes_IHandler ()
		{
			if (cb_importAidSelectRes_I == null)
				cb_importAidSelectRes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_ImportAidSelectRes_I);
			return cb_importAidSelectRes_I;
		}

		static bool n_ImportAidSelectRes_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImportAidSelectRes (p0);
		}
#pragma warning restore 0169

		IntPtr id_importAidSelectRes_I;
		public unsafe bool ImportAidSelectRes (int p0)
		{
			if (id_importAidSelectRes_I == IntPtr.Zero)
				id_importAidSelectRes_I = JNIEnv.GetMethodID (class_ref, "importAidSelectRes", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_importAidSelectRes_I, __args);
		}

		static Delegate cb_importAmount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImportAmount_Ljava_lang_String_Handler ()
		{
			if (cb_importAmount_Ljava_lang_String_ == null)
				cb_importAmount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ImportAmount_Ljava_lang_String_);
			return cb_importAmount_Ljava_lang_String_;
		}

		static bool n_ImportAmount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ImportAmount (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_importAmount_Ljava_lang_String_;
		public unsafe bool ImportAmount (string p0)
		{
			if (id_importAmount_Ljava_lang_String_ == IntPtr.Zero)
				id_importAmount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "importAmount", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_importAmount_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_importConfirmCardInfoRes_Z;
#pragma warning disable 0169
		static Delegate GetImportConfirmCardInfoRes_ZHandler ()
		{
			if (cb_importConfirmCardInfoRes_Z == null)
				cb_importConfirmCardInfoRes_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_ImportConfirmCardInfoRes_Z);
			return cb_importConfirmCardInfoRes_Z;
		}

		static bool n_ImportConfirmCardInfoRes_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImportConfirmCardInfoRes (p0);
		}
#pragma warning restore 0169

		IntPtr id_importConfirmCardInfoRes_Z;
		public unsafe bool ImportConfirmCardInfoRes (bool p0)
		{
			if (id_importConfirmCardInfoRes_Z == IntPtr.Zero)
				id_importConfirmCardInfoRes_Z = JNIEnv.GetMethodID (class_ref, "importConfirmCardInfoRes", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_importConfirmCardInfoRes_Z, __args);
		}

		static Delegate cb_importECashTipConfirmRes_Z;
#pragma warning disable 0169
		static Delegate GetImportECashTipConfirmRes_ZHandler ()
		{
			if (cb_importECashTipConfirmRes_Z == null)
				cb_importECashTipConfirmRes_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_ImportECashTipConfirmRes_Z);
			return cb_importECashTipConfirmRes_Z;
		}

		static bool n_ImportECashTipConfirmRes_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImportECashTipConfirmRes (p0);
		}
#pragma warning restore 0169

		IntPtr id_importECashTipConfirmRes_Z;
		public unsafe bool ImportECashTipConfirmRes (bool p0)
		{
			if (id_importECashTipConfirmRes_Z == IntPtr.Zero)
				id_importECashTipConfirmRes_Z = JNIEnv.GetMethodID (class_ref, "importECashTipConfirmRes", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_importECashTipConfirmRes_Z, __args);
		}

		static Delegate cb_importMsgConfirmRes_Z;
#pragma warning disable 0169
		static Delegate GetImportMsgConfirmRes_ZHandler ()
		{
			if (cb_importMsgConfirmRes_Z == null)
				cb_importMsgConfirmRes_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_ImportMsgConfirmRes_Z);
			return cb_importMsgConfirmRes_Z;
		}

		static bool n_ImportMsgConfirmRes_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImportMsgConfirmRes (p0);
		}
#pragma warning restore 0169

		IntPtr id_importMsgConfirmRes_Z;
		public unsafe bool ImportMsgConfirmRes (bool p0)
		{
			if (id_importMsgConfirmRes_Z == IntPtr.Zero)
				id_importMsgConfirmRes_Z = JNIEnv.GetMethodID (class_ref, "importMsgConfirmRes", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_importMsgConfirmRes_Z, __args);
		}

		static Delegate cb_importOnlineResp_ZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImportOnlineResp_ZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_importOnlineResp_ZLjava_lang_String_Ljava_lang_String_ == null)
				cb_importOnlineResp_ZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr, IntPtr, bool>) n_ImportOnlineResp_ZLjava_lang_String_Ljava_lang_String_);
			return cb_importOnlineResp_ZLjava_lang_String_Ljava_lang_String_;
		}

		static bool n_ImportOnlineResp_ZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ImportOnlineResp (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_importOnlineResp_ZLjava_lang_String_Ljava_lang_String_;
		public unsafe bool ImportOnlineResp (bool p0, string p1, string p2)
		{
			if (id_importOnlineResp_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_importOnlineResp_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "importOnlineResp", "(ZLjava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_importOnlineResp_ZLjava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_importPin_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetImportPin_Ljava_lang_String_Handler ()
		{
			if (cb_importPin_Ljava_lang_String_ == null)
				cb_importPin_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ImportPin_Ljava_lang_String_);
			return cb_importPin_Ljava_lang_String_;
		}

		static bool n_ImportPin_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ImportPin (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_importPin_Ljava_lang_String_;
		public unsafe bool ImportPin (string p0)
		{
			if (id_importPin_Ljava_lang_String_ == IntPtr.Zero)
				id_importPin_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "importPin", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_importPin_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_importUserAuthRes_Z;
#pragma warning disable 0169
		static Delegate GetImportUserAuthRes_ZHandler ()
		{
			if (cb_importUserAuthRes_Z == null)
				cb_importUserAuthRes_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_ImportUserAuthRes_Z);
			return cb_importUserAuthRes_Z;
		}

		static bool n_ImportUserAuthRes_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImportUserAuthRes (p0);
		}
#pragma warning restore 0169

		IntPtr id_importUserAuthRes_Z;
		public unsafe bool ImportUserAuthRes (bool p0)
		{
			if (id_importUserAuthRes_Z == IntPtr.Zero)
				id_importUserAuthRes_Z = JNIEnv.GetMethodID (class_ref, "importUserAuthRes", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_importUserAuthRes_Z, __args);
		}

		static Delegate cb_isExistAidPublicKey;
#pragma warning disable 0169
		static Delegate GetIsExistAidPublicKeyHandler ()
		{
			if (cb_isExistAidPublicKey == null)
				cb_isExistAidPublicKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IsExistAidPublicKey);
			return cb_isExistAidPublicKey;
		}

		static int n_IsExistAidPublicKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExistAidPublicKey ();
		}
#pragma warning restore 0169

		IntPtr id_isExistAidPublicKey;
		public unsafe int IsExistAidPublicKey ()
		{
			if (id_isExistAidPublicKey == IntPtr.Zero)
				id_isExistAidPublicKey = JNIEnv.GetMethodID (class_ref, "isExistAidPublicKey", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_isExistAidPublicKey);
		}

		static Delegate cb_parseTLV_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParseTLV_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_parseTLV_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_parseTLV_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseTLV_Ljava_lang_String_Ljava_lang_String_);
			return cb_parseTLV_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ParseTLV_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ParseTLV (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_parseTLV_Ljava_lang_String_Ljava_lang_String_;
		public unsafe string ParseTLV (string p0, string p1)
		{
			if (id_parseTLV_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_parseTLV_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "parseTLV", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parseTLV_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_processPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_;
#pragma warning disable 0169
		static Delegate GetProcessPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_Handler ()
		{
			if (cb_processPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_ == null)
				cb_processPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_);
			return cb_processPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_;
		}

		static void n_ProcessPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.EmvTransData p0 = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.EmvTransData> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocStartListener p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocStartListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocStartListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ProcessPBOC (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_processPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_;
		public unsafe void ProcessPBOC (global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.EmvTransData p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPbocStartListener p1)
		{
			if (id_processPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_ == IntPtr.Zero)
				id_processPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_ = JNIEnv.GetMethodID (class_ref, "processPBOC", "(Lcom/lkl/cloudpos/mdx/aidl/emv/EmvTransData;Lcom/lkl/cloudpos/mdx/aidl/emv/AidlPbocStartListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processPBOC_Lcom_lkl_cloudpos_mdx_aidl_emv_EmvTransData_Lcom_lkl_cloudpos_mdx_aidl_emv_AidlPbocStartListener_, __args);
		}

		static Delegate cb_readKernelData_arrayLjava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetReadKernelData_arrayLjava_lang_String_arrayBHandler ()
		{
			if (cb_readKernelData_arrayLjava_lang_String_arrayB == null)
				cb_readKernelData_arrayLjava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ReadKernelData_arrayLjava_lang_String_arrayB);
			return cb_readKernelData_arrayLjava_lang_String_arrayB;
		}

		static int n_ReadKernelData_arrayLjava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadKernelData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readKernelData_arrayLjava_lang_String_arrayB;
		public unsafe int ReadKernelData (string[] p0, byte[] p1)
		{
			if (id_readKernelData_arrayLjava_lang_String_arrayB == IntPtr.Zero)
				id_readKernelData_arrayLjava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "readKernelData", "([Ljava/lang/String;[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readKernelData_arrayLjava_lang_String_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_setTlv_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetSetTlv_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_setTlv_Ljava_lang_String_arrayB == null)
				cb_setTlv_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTlv_Ljava_lang_String_arrayB);
			return cb_setTlv_Ljava_lang_String_arrayB;
		}

		static void n_SetTlv_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetTlv (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_setTlv_Ljava_lang_String_arrayB;
		public unsafe void SetTlv (string p0, byte[] p1)
		{
			if (id_setTlv_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_setTlv_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "setTlv", "(Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTlv_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateAID_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateAID_ILjava_lang_String_Handler ()
		{
			if (cb_updateAID_ILjava_lang_String_ == null)
				cb_updateAID_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_UpdateAID_ILjava_lang_String_);
			return cb_updateAID_ILjava_lang_String_;
		}

		static bool n_UpdateAID_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateAID (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateAID_ILjava_lang_String_;
		public unsafe bool UpdateAID (int p0, string p1)
		{
			if (id_updateAID_ILjava_lang_String_ == IntPtr.Zero)
				id_updateAID_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateAID", "(ILjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateAID_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_updateCAPK_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateCAPK_ILjava_lang_String_Handler ()
		{
			if (cb_updateCAPK_ILjava_lang_String_ == null)
				cb_updateCAPK_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_UpdateCAPK_ILjava_lang_String_);
			return cb_updateCAPK_ILjava_lang_String_;
		}

		static bool n_UpdateCAPK_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UpdateCAPK (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_updateCAPK_ILjava_lang_String_;
		public unsafe bool UpdateCAPK (int p0, string p1)
		{
			if (id_updateCAPK_ILjava_lang_String_ == IntPtr.Zero)
				id_updateCAPK_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateCAPK", "(ILjava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_updateCAPK_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Emv.IAidlPboc> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
