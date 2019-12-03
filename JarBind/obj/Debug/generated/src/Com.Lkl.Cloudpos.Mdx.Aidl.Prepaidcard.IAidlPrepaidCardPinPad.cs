using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCardPinPad.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPinPad$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlPrepaidCardPinPadStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPinPad$Stub", typeof (AidlPrepaidCardPinPadStub));
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

		protected AidlPrepaidCardPinPadStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCardPinPad.Stub']/constructor[@name='AidlPrepaidCardPinPad.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlPrepaidCardPinPadStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCardPinPad.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCardPinPad.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPinPad;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPinPad;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCardPinPad.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConfirmGetPin ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='confirmGetPin' and count(parameter)=0]"
		[Register ("confirmGetPin", "()V", "GetConfirmGetPinHandler")]
		public abstract void ConfirmGetPin ();

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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetMac (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='getMac' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='byte[]']]"
		[Register ("getMac", "(Landroid/os/Bundle;[B)I", "GetGetMac_Landroid_os_Bundle_arrayBHandler")]
		public abstract int GetMac (global::Android.OS.Bundle p0, byte[] p1);

		static Delegate cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_;
#pragma warning disable 0169
		static Delegate GetGetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_Handler ()
		{
			if (cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_ == null)
				cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_);
			return cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_;
		}

		static void n_GetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IPrepaidCardGetPinListener p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IPrepaidCardGetPinListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IPrepaidCardGetPinListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetPin (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='getPin' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.prepaidcard.PrepaidCardGetPinListener']]"
		[Register ("getPin", "(Landroid/os/Bundle;Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardGetPinListener;)V", "GetGetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_Handler")]
		public abstract void GetPin (global::Android.OS.Bundle p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IPrepaidCardGetPinListener p1);

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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRandom ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='getRandom' and count(parameter)=0]"
		[Register ("getRandom", "()[B", "GetGetRandomHandler")]
		public abstract byte[] GetRandom ();

		static Delegate cb_loadMainkey_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadMainkey_arrayBarrayBHandler ()
		{
			if (cb_loadMainkey_arrayBarrayB == null)
				cb_loadMainkey_arrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_LoadMainkey_arrayBarrayB);
			return cb_loadMainkey_arrayBarrayB;
		}

		static bool n_LoadMainkey_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadMainkey (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='loadMainkey' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("loadMainkey", "([B[B)Z", "GetLoadMainkey_arrayBarrayBHandler")]
		public abstract bool LoadMainkey (byte[] p0, byte[] p1);

		static Delegate cb_loadWorkKey_IarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadWorkKey_IarrayBarrayBHandler ()
		{
			if (cb_loadWorkKey_IarrayBarrayB == null)
				cb_loadWorkKey_IarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_LoadWorkKey_IarrayBarrayB);
			return cb_loadWorkKey_IarrayBarrayB;
		}

		static bool n_LoadWorkKey_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadWorkKey (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='loadWorkKey' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("loadWorkKey", "(I[B[B)Z", "GetLoadWorkKey_IarrayBarrayBHandler")]
		public abstract bool LoadWorkKey (int p0, byte[] p1, byte[] p2);

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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopGetPin ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='stopGetPin' and count(parameter)=0]"
		[Register ("stopGetPin", "()V", "GetStopGetPinHandler")]
		public abstract void StopGetPin ();

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPinPad$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlPrepaidCardPinPadStubInvoker : AidlPrepaidCardPinPadStub {

		public AidlPrepaidCardPinPadStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPinPad$Stub", typeof (AidlPrepaidCardPinPadStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='confirmGetPin' and count(parameter)=0]"
		[Register ("confirmGetPin", "()V", "GetConfirmGetPinHandler")]
		public override unsafe void ConfirmGetPin ()
		{
			const string __id = "confirmGetPin.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='getMac' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='byte[]']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='getPin' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.prepaidcard.PrepaidCardGetPinListener']]"
		[Register ("getPin", "(Landroid/os/Bundle;Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardGetPinListener;)V", "GetGetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_Handler")]
		public override unsafe void GetPin (global::Android.OS.Bundle p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IPrepaidCardGetPinListener p1)
		{
			const string __id = "getPin.(Landroid/os/Bundle;Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardGetPinListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='getRandom' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='loadMainkey' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("loadMainkey", "([B[B)Z", "GetLoadMainkey_arrayBarrayBHandler")]
		public override unsafe bool LoadMainkey (byte[] p0, byte[] p1)
		{
			const string __id = "loadMainkey.([B[B)Z";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='loadWorkKey' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("loadWorkKey", "(I[B[B)Z", "GetLoadWorkKey_IarrayBarrayBHandler")]
		public override unsafe bool LoadWorkKey (int p0, byte[] p1, byte[] p2)
		{
			const string __id = "loadWorkKey.(I[B[B)Z";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='stopGetPin' and count(parameter)=0]"
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


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']"
	[Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPinPad", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPadInvoker")]
	public partial interface IAidlPrepaidCardPinPad : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='confirmGetPin' and count(parameter)=0]"
		[Register ("confirmGetPin", "()V", "GetConfirmGetPinHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPadInvoker, JarBind")]
		void ConfirmGetPin ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='getMac' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='byte[]']]"
		[Register ("getMac", "(Landroid/os/Bundle;[B)I", "GetGetMac_Landroid_os_Bundle_arrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPadInvoker, JarBind")]
		int GetMac (global::Android.OS.Bundle p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='getPin' and count(parameter)=2 and parameter[1][@type='android.os.Bundle'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.prepaidcard.PrepaidCardGetPinListener']]"
		[Register ("getPin", "(Landroid/os/Bundle;Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardGetPinListener;)V", "GetGetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPadInvoker, JarBind")]
		void GetPin (global::Android.OS.Bundle p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IPrepaidCardGetPinListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='getRandom' and count(parameter)=0]"
		[Register ("getRandom", "()[B", "GetGetRandomHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPadInvoker, JarBind")]
		byte[] GetRandom ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='loadMainkey' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("loadMainkey", "([B[B)Z", "GetLoadMainkey_arrayBarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPadInvoker, JarBind")]
		bool LoadMainkey (byte[] p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='loadWorkKey' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("loadWorkKey", "(I[B[B)Z", "GetLoadWorkKey_IarrayBarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPadInvoker, JarBind")]
		bool LoadWorkKey (int p0, byte[] p1, byte[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCardPinPad']/method[@name='stopGetPin' and count(parameter)=0]"
		[Register ("stopGetPin", "()V", "GetStopGetPinHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPadInvoker, JarBind")]
		void StopGetPin ();

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPinPad", DoNotGenerateAcw=true)]
	internal class IAidlPrepaidCardPinPadInvoker : global::Java.Lang.Object, IAidlPrepaidCardPinPad {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPinPad", typeof (IAidlPrepaidCardPinPadInvoker));

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

		public static IAidlPrepaidCardPinPad GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlPrepaidCardPinPad> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.prepaidcard.AidlPrepaidCardPinPad"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlPrepaidCardPinPadInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_;
#pragma warning disable 0169
		static Delegate GetGetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_Handler ()
		{
			if (cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_ == null)
				cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_);
			return cb_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_;
		}

		static void n_GetPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IPrepaidCardGetPinListener p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IPrepaidCardGetPinListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IPrepaidCardGetPinListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetPin (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_;
		public unsafe void GetPin (global::Android.OS.Bundle p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IPrepaidCardGetPinListener p1)
		{
			if (id_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_ == IntPtr.Zero)
				id_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_ = JNIEnv.GetMethodID (class_ref, "getPin", "(Landroid/os/Bundle;Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardGetPinListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getPin_Landroid_os_Bundle_Lcom_lkl_cloudpos_mdx_aidl_prepaidcard_PrepaidCardGetPinListener_, __args);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_loadMainkey_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadMainkey_arrayBarrayBHandler ()
		{
			if (cb_loadMainkey_arrayBarrayB == null)
				cb_loadMainkey_arrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_LoadMainkey_arrayBarrayB);
			return cb_loadMainkey_arrayBarrayB;
		}

		static bool n_LoadMainkey_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadMainkey (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadMainkey_arrayBarrayB;
		public unsafe bool LoadMainkey (byte[] p0, byte[] p1)
		{
			if (id_loadMainkey_arrayBarrayB == IntPtr.Zero)
				id_loadMainkey_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "loadMainkey", "([B[B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_loadMainkey_arrayBarrayB, __args);
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

		static Delegate cb_loadWorkKey_IarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadWorkKey_IarrayBarrayBHandler ()
		{
			if (cb_loadWorkKey_IarrayBarrayB == null)
				cb_loadWorkKey_IarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_LoadWorkKey_IarrayBarrayB);
			return cb_loadWorkKey_IarrayBarrayB;
		}

		static bool n_LoadWorkKey_IarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.LoadWorkKey (p0, p1, p2);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_loadWorkKey_IarrayBarrayB;
		public unsafe bool LoadWorkKey (int p0, byte[] p1, byte[] p2)
		{
			if (id_loadWorkKey_IarrayBarrayB == IntPtr.Zero)
				id_loadWorkKey_IarrayBarrayB = JNIEnv.GetMethodID (class_ref, "loadWorkKey", "(I[B[B)Z");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_loadWorkKey_IarrayBarrayB, __args);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardPinPad> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
