using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/class[@name='AidlPinpad.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/pinpad/AidlPinpad$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlPinpadStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/pinpad/AidlPinpad$Stub", typeof (AidlPinpadStub));
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

		protected AidlPinpadStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/class[@name='AidlPinpad.Stub']/constructor[@name='AidlPinpad.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlPinpadStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/class[@name='AidlPinpad.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/class[@name='AidlPinpad.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/pinpad/AidlPinpad;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/pinpad/AidlPinpad;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/class[@name='AidlPinpad.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_confirmGetPin;
#pragma warning disable 0169
		static Delegate GetConfirmGetPinHandler ()
		{
			if (cb_confirmGetPin == null)
				cb_confirmGetPin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConfirmGetPin);
			return cb_confirmGetPin;
		}

		static void n_ConfirmGetPin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConfirmGetPin ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='confirmGetPin' and count(parameter)=0]"
		[Register ("confirmGetPin", "()V", "GetConfirmGetPinHandler")]
		public abstract void ConfirmGetPin ();

		static Delegate cb_display_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisplay_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_display_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_display_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Display_Ljava_lang_String_Ljava_lang_String_);
			return cb_display_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Display_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Display (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='display' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetDisplay_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract bool Display (string p0, string p1);

		static Delegate cb_encryptByTdk_IBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetEncryptByTdk_IBarrayBarrayBarrayBHandler ()
		{
			if (cb_encryptByTdk_IBarrayBarrayBarrayB == null)
				cb_encryptByTdk_IBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte, IntPtr, IntPtr, IntPtr, int>) n_EncryptByTdk_IBarrayBarrayBarrayB);
			return cb_encryptByTdk_IBarrayBarrayBarrayB;
		}

		static int n_EncryptByTdk_IBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, sbyte p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.EncryptByTdk (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='encryptByTdk' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("encryptByTdk", "(IB[B[B[B)I", "GetEncryptByTdk_IBarrayBarrayBarrayBHandler")]
		public abstract int EncryptByTdk (int p0, sbyte p1, byte[] p2, byte[] p3, byte[] p4);

		static Delegate cb_getMac_Landroid_os_Bundle_arrayB;
#pragma warning disable 0169
		static Delegate GetGetMac_Landroid_os_Bundle_arrayBHandler ()
		{
			if (cb_getMac_Landroid_os_Bundle_arrayB == null)
				cb_getMac_Landroid_os_Bundle_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_GetMac_Landroid_os_Bundle_arrayB);
			return cb_getMac_Landroid_os_Bundle_arrayB;
		}

		static int n_GetMac_Landroid_os_Bundle_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetMac (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='getMac' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='byte[]']]"
		[Register ("getMac", "(Landroid/os/Bundle;[B)I", "GetGetMac_Landroid_os_Bundle_arrayBHandler")]
		public abstract int GetMac (global::Android.OS.Bundle p0, byte[] p1);

		static Delegate cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_;
#pragma warning disable 0169
		static Delegate GetGetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_Handler ()
		{
			if (cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_ == null)
				cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_);
			return cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_;
		}

		static void n_GetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetPin (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='getPin' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.pinpad.GetPinListener']]"
		[Register ("getPin", "(Landroid/os/Bundle;Lcom/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener;)V", "GetGetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_Handler")]
		public abstract void GetPin (global::Android.OS.Bundle p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener p1);

		static Delegate cb_getRandom;
#pragma warning disable 0169
		static Delegate GetGetRandomHandler ()
		{
			if (cb_getRandom == null)
				cb_getRandom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRandom);
			return cb_getRandom;
		}

		static IntPtr n_GetRandom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRandom ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='getRandom' and count(parameter)=0]"
		[Register ("getRandom", "()[B", "GetGetRandomHandler")]
		public abstract byte[] GetRandom ();

		static Delegate cb_loadEncryptMainkey_IIarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadEncryptMainkey_IIarrayBarrayBHandler ()
		{
			if (cb_loadEncryptMainkey_IIarrayBarrayB == null)
				cb_loadEncryptMainkey_IIarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr, bool>) n_LoadEncryptMainkey_IIarrayBarrayB);
			return cb_loadEncryptMainkey_IIarrayBarrayB;
		}

		static bool n_LoadEncryptMainkey_IIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadEncryptMainkey (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadEncryptMainkey' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("loadEncryptMainkey", "(II[B[B)Z", "GetLoadEncryptMainkey_IIarrayBarrayBHandler")]
		public abstract bool LoadEncryptMainkey (int p0, int p1, byte[] p2, byte[] p3);

		static Delegate cb_loadMainkey_IarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadMainkey_IarrayBarrayBHandler ()
		{
			if (cb_loadMainkey_IarrayBarrayB == null)
				cb_loadMainkey_IarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_LoadMainkey_IarrayBarrayB);
			return cb_loadMainkey_IarrayBarrayB;
		}

		static bool n_LoadMainkey_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadMainkey (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadMainkey' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("loadMainkey", "(I[B[B)Z", "GetLoadMainkey_IarrayBarrayBHandler")]
		public abstract bool LoadMainkey (int p0, byte[] p1, byte[] p2);

		static Delegate cb_loadTEK_IarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadTEK_IarrayBarrayBHandler ()
		{
			if (cb_loadTEK_IarrayBarrayB == null)
				cb_loadTEK_IarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_LoadTEK_IarrayBarrayB);
			return cb_loadTEK_IarrayBarrayB;
		}

		static bool n_LoadTEK_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadTEK (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadTEK' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("loadTEK", "(I[B[B)Z", "GetLoadTEK_IarrayBarrayBHandler")]
		public abstract bool LoadTEK (int p0, byte[] p1, byte[] p2);

		static Delegate cb_loadTWK_IIIarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadTWK_IIIarrayBarrayBHandler ()
		{
			if (cb_loadTWK_IIIarrayBarrayB == null)
				cb_loadTWK_IIIarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, IntPtr, bool>) n_LoadTWK_IIIarrayBarrayB);
			return cb_loadTWK_IIIarrayBarrayB;
		}

		static bool n_LoadTWK_IIIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadTWK (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadTWK' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("loadTWK", "(III[B[B)Z", "GetLoadTWK_IIIarrayBarrayBHandler")]
		public abstract bool LoadTWK (int p0, int p1, int p2, byte[] p3, byte[] p4);

		static Delegate cb_loadWorkKey_IIIarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadWorkKey_IIIarrayBarrayBHandler ()
		{
			if (cb_loadWorkKey_IIIarrayBarrayB == null)
				cb_loadWorkKey_IIIarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, IntPtr, bool>) n_LoadWorkKey_IIIarrayBarrayB);
			return cb_loadWorkKey_IIIarrayBarrayB;
		}

		static bool n_LoadWorkKey_IIIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadWorkKey (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadWorkKey' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("loadWorkKey", "(III[B[B)Z", "GetLoadWorkKey_IIIarrayBarrayBHandler")]
		public abstract bool LoadWorkKey (int p0, int p1, int p2, byte[] p3, byte[] p4);

		static Delegate cb_setPinKeyboardMode_I;
#pragma warning disable 0169
		static Delegate GetSetPinKeyboardMode_IHandler ()
		{
			if (cb_setPinKeyboardMode_I == null)
				cb_setPinKeyboardMode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetPinKeyboardMode_I);
			return cb_setPinKeyboardMode_I;
		}

		static bool n_SetPinKeyboardMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetPinKeyboardMode (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='setPinKeyboardMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPinKeyboardMode", "(I)Z", "GetSetPinKeyboardMode_IHandler")]
		public abstract bool SetPinKeyboardMode (int p0);

		static Delegate cb_stopGetPin;
#pragma warning disable 0169
		static Delegate GetStopGetPinHandler ()
		{
			if (cb_stopGetPin == null)
				cb_stopGetPin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopGetPin);
			return cb_stopGetPin;
		}

		static void n_StopGetPin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopGetPin ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='stopGetPin' and count(parameter)=0]"
		[Register ("stopGetPin", "()V", "GetStopGetPinHandler")]
		public abstract void StopGetPin ();

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/pinpad/AidlPinpad$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlPinpadStubInvoker : AidlPinpadStub {

		public AidlPinpadStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/pinpad/AidlPinpad$Stub", typeof (AidlPinpadStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='confirmGetPin' and count(parameter)=0]"
		[Register ("confirmGetPin", "()V", "GetConfirmGetPinHandler")]
		public override unsafe void ConfirmGetPin ()
		{
			const string __id = "confirmGetPin.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='display' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetDisplay_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe bool Display (string p0, string p1)
		{
			const string __id = "display.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='encryptByTdk' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("encryptByTdk", "(IB[B[B[B)I", "GetEncryptByTdk_IBarrayBarrayBarrayBHandler")]
		public override unsafe int EncryptByTdk (int p0, sbyte p1, byte[] p2, byte[] p3, byte[] p4)
		{
			const string __id = "encryptByTdk.(IB[B[B[B)I";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='getMac' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='byte[]']]"
		[Register ("getMac", "(Landroid/os/Bundle;[B)I", "GetGetMac_Landroid_os_Bundle_arrayBHandler")]
		public override unsafe int GetMac (global::Android.OS.Bundle p0, byte[] p1)
		{
			const string __id = "getMac.(Landroid/os/Bundle;[B)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='getPin' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.pinpad.GetPinListener']]"
		[Register ("getPin", "(Landroid/os/Bundle;Lcom/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener;)V", "GetGetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_Handler")]
		public override unsafe void GetPin (global::Android.OS.Bundle p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener p1)
		{
			const string __id = "getPin.(Landroid/os/Bundle;Lcom/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='getRandom' and count(parameter)=0]"
		[Register ("getRandom", "()[B", "GetGetRandomHandler")]
		public override unsafe byte[] GetRandom ()
		{
			const string __id = "getRandom.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadEncryptMainkey' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("loadEncryptMainkey", "(II[B[B)Z", "GetLoadEncryptMainkey_IIarrayBarrayBHandler")]
		public override unsafe bool LoadEncryptMainkey (int p0, int p1, byte[] p2, byte[] p3)
		{
			const string __id = "loadEncryptMainkey.(II[B[B)Z";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadMainkey' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("loadMainkey", "(I[B[B)Z", "GetLoadMainkey_IarrayBarrayBHandler")]
		public override unsafe bool LoadMainkey (int p0, byte[] p1, byte[] p2)
		{
			const string __id = "loadMainkey.(I[B[B)Z";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadTEK' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("loadTEK", "(I[B[B)Z", "GetLoadTEK_IarrayBarrayBHandler")]
		public override unsafe bool LoadTEK (int p0, byte[] p1, byte[] p2)
		{
			const string __id = "loadTEK.(I[B[B)Z";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadTWK' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("loadTWK", "(III[B[B)Z", "GetLoadTWK_IIIarrayBarrayBHandler")]
		public override unsafe bool LoadTWK (int p0, int p1, int p2, byte[] p3, byte[] p4)
		{
			const string __id = "loadTWK.(III[B[B)Z";
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadWorkKey' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("loadWorkKey", "(III[B[B)Z", "GetLoadWorkKey_IIIarrayBarrayBHandler")]
		public override unsafe bool LoadWorkKey (int p0, int p1, int p2, byte[] p3, byte[] p4)
		{
			const string __id = "loadWorkKey.(III[B[B)Z";
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='setPinKeyboardMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPinKeyboardMode", "(I)Z", "GetSetPinKeyboardMode_IHandler")]
		public override unsafe bool SetPinKeyboardMode (int p0)
		{
			const string __id = "setPinKeyboardMode.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='stopGetPin' and count(parameter)=0]"
		[Register ("stopGetPin", "()V", "GetStopGetPinHandler")]
		public override unsafe void StopGetPin ()
		{
			const string __id = "stopGetPin.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']"
	[Register ("com/lkl/cloudpos/mdx/aidl/pinpad/AidlPinpad", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker")]
	public partial interface IAidlPinpad : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='confirmGetPin' and count(parameter)=0]"
		[Register ("confirmGetPin", "()V", "GetConfirmGetPinHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		void ConfirmGetPin ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='display' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("display", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetDisplay_Ljava_lang_String_Ljava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		bool Display (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='encryptByTdk' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("encryptByTdk", "(IB[B[B[B)I", "GetEncryptByTdk_IBarrayBarrayBarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		int EncryptByTdk (int p0, sbyte p1, byte[] p2, byte[] p3, byte[] p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='getMac' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='byte[]']]"
		[Register ("getMac", "(Landroid/os/Bundle;[B)I", "GetGetMac_Landroid_os_Bundle_arrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		int GetMac (global::Android.OS.Bundle p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='getPin' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.pinpad.GetPinListener']]"
		[Register ("getPin", "(Landroid/os/Bundle;Lcom/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener;)V", "GetGetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		void GetPin (global::Android.OS.Bundle p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='getRandom' and count(parameter)=0]"
		[Register ("getRandom", "()[B", "GetGetRandomHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		byte[] GetRandom ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadEncryptMainkey' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("loadEncryptMainkey", "(II[B[B)Z", "GetLoadEncryptMainkey_IIarrayBarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		bool LoadEncryptMainkey (int p0, int p1, byte[] p2, byte[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadMainkey' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("loadMainkey", "(I[B[B)Z", "GetLoadMainkey_IarrayBarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		bool LoadMainkey (int p0, byte[] p1, byte[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadTEK' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("loadTEK", "(I[B[B)Z", "GetLoadTEK_IarrayBarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		bool LoadTEK (int p0, byte[] p1, byte[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadTWK' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("loadTWK", "(III[B[B)Z", "GetLoadTWK_IIIarrayBarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		bool LoadTWK (int p0, int p1, int p2, byte[] p3, byte[] p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='loadWorkKey' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte[]']]"
		[Register ("loadWorkKey", "(III[B[B)Z", "GetLoadWorkKey_IIIarrayBarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		bool LoadWorkKey (int p0, int p1, int p2, byte[] p3, byte[] p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='setPinKeyboardMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPinKeyboardMode", "(I)Z", "GetSetPinKeyboardMode_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		bool SetPinKeyboardMode (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='AidlPinpad']/method[@name='stopGetPin' and count(parameter)=0]"
		[Register ("stopGetPin", "()V", "GetStopGetPinHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpadInvoker, JarBind")]
		void StopGetPin ();

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/pinpad/AidlPinpad", DoNotGenerateAcw=true)]
	internal class IAidlPinpadInvoker : global::Java.Lang.Object, IAidlPinpad {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/pinpad/AidlPinpad", typeof (IAidlPinpadInvoker));

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

		public static IAidlPinpad GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlPinpad> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.pinpad.AidlPinpad"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlPinpadInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_confirmGetPin;
#pragma warning disable 0169
		static Delegate GetConfirmGetPinHandler ()
		{
			if (cb_confirmGetPin == null)
				cb_confirmGetPin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConfirmGetPin);
			return cb_confirmGetPin;
		}

		static void n_ConfirmGetPin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConfirmGetPin ();
		}
#pragma warning restore 0169

		IntPtr id_confirmGetPin;
		public unsafe void ConfirmGetPin ()
		{
			if (id_confirmGetPin == IntPtr.Zero)
				id_confirmGetPin = JNIEnv.GetMethodID (class_ref, "confirmGetPin", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_confirmGetPin);
		}

		static Delegate cb_display_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisplay_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_display_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_display_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Display_Ljava_lang_String_Ljava_lang_String_);
			return cb_display_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_Display_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Display (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_display_Ljava_lang_String_Ljava_lang_String_;
		public unsafe bool Display (string p0, string p1)
		{
			if (id_display_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_display_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "display", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_display_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_encryptByTdk_IBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetEncryptByTdk_IBarrayBarrayBarrayBHandler ()
		{
			if (cb_encryptByTdk_IBarrayBarrayBarrayB == null)
				cb_encryptByTdk_IBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte, IntPtr, IntPtr, IntPtr, int>) n_EncryptByTdk_IBarrayBarrayBarrayB);
			return cb_encryptByTdk_IBarrayBarrayBarrayB;
		}

		static int n_EncryptByTdk_IBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, sbyte p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.EncryptByTdk (p0, p1, p2, p3, p4);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_encryptByTdk_IBarrayBarrayBarrayB;
		public unsafe int EncryptByTdk (int p0, sbyte p1, byte[] p2, byte[] p3, byte[] p4)
		{
			if (id_encryptByTdk_IBarrayBarrayBarrayB == IntPtr.Zero)
				id_encryptByTdk_IBarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "encryptByTdk", "(IB[B[B[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_encryptByTdk_IBarrayBarrayBarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate cb_getMac_Landroid_os_Bundle_arrayB;
#pragma warning disable 0169
		static Delegate GetGetMac_Landroid_os_Bundle_arrayBHandler ()
		{
			if (cb_getMac_Landroid_os_Bundle_arrayB == null)
				cb_getMac_Landroid_os_Bundle_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_GetMac_Landroid_os_Bundle_arrayB);
			return cb_getMac_Landroid_os_Bundle_arrayB;
		}

		static int n_GetMac_Landroid_os_Bundle_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetMac (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMac_Landroid_os_Bundle_arrayB;
		public unsafe int GetMac (global::Android.OS.Bundle p0, byte[] p1)
		{
			if (id_getMac_Landroid_os_Bundle_arrayB == IntPtr.Zero)
				id_getMac_Landroid_os_Bundle_arrayB = JNIEnv.GetMethodID (class_ref, "getMac", "(Landroid/os/Bundle;[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMac_Landroid_os_Bundle_arrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_;
#pragma warning disable 0169
		static Delegate GetGetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_Handler ()
		{
			if (cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_ == null)
				cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_);
			return cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_;
		}

		static void n_GetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetPin (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_;
		public unsafe void GetPin (global::Android.OS.Bundle p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener p1)
		{
			if (id_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_ == IntPtr.Zero)
				id_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_ = JNIEnv.GetMethodID (class_ref, "getPin", "(Landroid/os/Bundle;Lcom/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_pinpad_GetPinListener_, __args);
		}

		static Delegate cb_getRandom;
#pragma warning disable 0169
		static Delegate GetGetRandomHandler ()
		{
			if (cb_getRandom == null)
				cb_getRandom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRandom);
			return cb_getRandom;
		}

		static IntPtr n_GetRandom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRandom ());
		}
#pragma warning restore 0169

		IntPtr id_getRandom;
		public unsafe byte[] GetRandom ()
		{
			if (id_getRandom == IntPtr.Zero)
				id_getRandom = JNIEnv.GetMethodID (class_ref, "getRandom", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRandom), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_loadEncryptMainkey_IIarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadEncryptMainkey_IIarrayBarrayBHandler ()
		{
			if (cb_loadEncryptMainkey_IIarrayBarrayB == null)
				cb_loadEncryptMainkey_IIarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr, bool>) n_LoadEncryptMainkey_IIarrayBarrayB);
			return cb_loadEncryptMainkey_IIarrayBarrayB;
		}

		static bool n_LoadEncryptMainkey_IIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadEncryptMainkey (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadEncryptMainkey_IIarrayBarrayB;
		public unsafe bool LoadEncryptMainkey (int p0, int p1, byte[] p2, byte[] p3)
		{
			if (id_loadEncryptMainkey_IIarrayBarrayB == IntPtr.Zero)
				id_loadEncryptMainkey_IIarrayBarrayB = JNIEnv.GetMethodID (class_ref, "loadEncryptMainkey", "(II[B[B)Z");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_loadEncryptMainkey_IIarrayBarrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			return __ret;
		}

		static Delegate cb_loadMainkey_IarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadMainkey_IarrayBarrayBHandler ()
		{
			if (cb_loadMainkey_IarrayBarrayB == null)
				cb_loadMainkey_IarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_LoadMainkey_IarrayBarrayB);
			return cb_loadMainkey_IarrayBarrayB;
		}

		static bool n_LoadMainkey_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadMainkey (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadMainkey_IarrayBarrayB;
		public unsafe bool LoadMainkey (int p0, byte[] p1, byte[] p2)
		{
			if (id_loadMainkey_IarrayBarrayB == IntPtr.Zero)
				id_loadMainkey_IarrayBarrayB = JNIEnv.GetMethodID (class_ref, "loadMainkey", "(I[B[B)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_loadMainkey_IarrayBarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_loadTEK_IarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadTEK_IarrayBarrayBHandler ()
		{
			if (cb_loadTEK_IarrayBarrayB == null)
				cb_loadTEK_IarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_LoadTEK_IarrayBarrayB);
			return cb_loadTEK_IarrayBarrayB;
		}

		static bool n_LoadTEK_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadTEK (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadTEK_IarrayBarrayB;
		public unsafe bool LoadTEK (int p0, byte[] p1, byte[] p2)
		{
			if (id_loadTEK_IarrayBarrayB == IntPtr.Zero)
				id_loadTEK_IarrayBarrayB = JNIEnv.GetMethodID (class_ref, "loadTEK", "(I[B[B)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_loadTEK_IarrayBarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_loadTWK_IIIarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadTWK_IIIarrayBarrayBHandler ()
		{
			if (cb_loadTWK_IIIarrayBarrayB == null)
				cb_loadTWK_IIIarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, IntPtr, bool>) n_LoadTWK_IIIarrayBarrayB);
			return cb_loadTWK_IIIarrayBarrayB;
		}

		static bool n_LoadTWK_IIIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadTWK (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadTWK_IIIarrayBarrayB;
		public unsafe bool LoadTWK (int p0, int p1, int p2, byte[] p3, byte[] p4)
		{
			if (id_loadTWK_IIIarrayBarrayB == IntPtr.Zero)
				id_loadTWK_IIIarrayBarrayB = JNIEnv.GetMethodID (class_ref, "loadTWK", "(III[B[B)Z");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_loadTWK_IIIarrayBarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate cb_loadWorkKey_IIIarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadWorkKey_IIIarrayBarrayBHandler ()
		{
			if (cb_loadWorkKey_IIIarrayBarrayB == null)
				cb_loadWorkKey_IIIarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr, IntPtr, bool>) n_LoadWorkKey_IIIarrayBarrayB);
			return cb_loadWorkKey_IIIarrayBarrayB;
		}

		static bool n_LoadWorkKey_IIIarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadWorkKey (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadWorkKey_IIIarrayBarrayB;
		public unsafe bool LoadWorkKey (int p0, int p1, int p2, byte[] p3, byte[] p4)
		{
			if (id_loadWorkKey_IIIarrayBarrayB == IntPtr.Zero)
				id_loadWorkKey_IIIarrayBarrayB = JNIEnv.GetMethodID (class_ref, "loadWorkKey", "(III[B[B)Z");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_loadWorkKey_IIIarrayBarrayB, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate cb_setPinKeyboardMode_I;
#pragma warning disable 0169
		static Delegate GetSetPinKeyboardMode_IHandler ()
		{
			if (cb_setPinKeyboardMode_I == null)
				cb_setPinKeyboardMode_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_SetPinKeyboardMode_I);
			return cb_setPinKeyboardMode_I;
		}

		static bool n_SetPinKeyboardMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetPinKeyboardMode (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPinKeyboardMode_I;
		public unsafe bool SetPinKeyboardMode (int p0)
		{
			if (id_setPinKeyboardMode_I == IntPtr.Zero)
				id_setPinKeyboardMode_I = JNIEnv.GetMethodID (class_ref, "setPinKeyboardMode", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setPinKeyboardMode_I, __args);
		}

		static Delegate cb_stopGetPin;
#pragma warning disable 0169
		static Delegate GetStopGetPinHandler ()
		{
			if (cb_stopGetPin == null)
				cb_stopGetPin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopGetPin);
			return cb_stopGetPin;
		}

		static void n_StopGetPin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopGetPin ();
		}
#pragma warning restore 0169

		IntPtr id_stopGetPin;
		public unsafe void StopGetPin ()
		{
			if (id_stopGetPin == IntPtr.Zero)
				id_stopGetPin = JNIEnv.GetMethodID (class_ref, "stopGetPin", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopGetPin);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IAidlPinpad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
