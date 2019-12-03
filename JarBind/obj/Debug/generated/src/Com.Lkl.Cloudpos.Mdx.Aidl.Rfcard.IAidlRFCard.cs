using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/class[@name='AidlRFCard.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/rfcard/AidlRFCard$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlRFCardStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/rfcard/AidlRFCard$Stub", typeof (AidlRFCardStub));
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

		protected AidlRFCardStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/class[@name='AidlRFCard.Stub']/constructor[@name='AidlRFCard.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlRFCardStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/class[@name='AidlRFCard.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/class[@name='AidlRFCard.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/rfcard/AidlRFCard;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/rfcard/AidlRFCard;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/class[@name='AidlRFCard.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_addValue_BarrayB;
#pragma warning disable 0169
		static Delegate GetAddValue_BarrayBHandler ()
		{
			if (cb_addValue_BarrayB == null)
				cb_addValue_BarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, IntPtr, int>) n_AddValue_BarrayB);
			return cb_addValue_BarrayB;
		}

		static int n_AddValue_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.AddValue (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='addValue' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("addValue", "(B[B)I", "GetAddValue_BarrayBHandler")]
		public abstract int AddValue (sbyte p0, byte[] p1);

		static Delegate cb_apduComm_arrayB;
#pragma warning disable 0169
		static Delegate GetApduComm_arrayBHandler ()
		{
			if (cb_apduComm_arrayB == null)
				cb_apduComm_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ApduComm_arrayB);
			return cb_apduComm_arrayB;
		}

		static IntPtr n_ApduComm_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.ApduComm (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='apduComm' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("apduComm", "([B)[B", "GetApduComm_arrayBHandler")]
		public abstract byte[] ApduComm (byte[] p0);

		static Delegate cb_auth_IBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetAuth_IBarrayBarrayBHandler ()
		{
			if (cb_auth_IBarrayBarrayB == null)
				cb_auth_IBarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte, IntPtr, IntPtr, int>) n_Auth_IBarrayBarrayB);
			return cb_auth_IBarrayBarrayB;
		}

		static int n_Auth_IBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, sbyte p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Auth (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='auth' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("auth", "(IB[B[B)I", "GetAuth_IBarrayBarrayBHandler")]
		public abstract int Auth (int p0, sbyte p1, byte[] p2, byte[] p3);

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Close);
			return cb_close;
		}

		static bool n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()Z", "GetCloseHandler")]
		public abstract bool Close ();

		static Delegate cb_getCardCode;
#pragma warning disable 0169
		static Delegate GetGetCardCodeHandler ()
		{
			if (cb_getCardCode == null)
				cb_getCardCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardCode);
			return cb_getCardCode;
		}

		static IntPtr n_GetCardCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCardCode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='getCardCode' and count(parameter)=0]"
		[Register ("getCardCode", "()[B", "GetGetCardCodeHandler")]
		public abstract byte[] GetCardCode ();

		static Delegate cb_halt;
#pragma warning disable 0169
		static Delegate GetHaltHandler ()
		{
			if (cb_halt == null)
				cb_halt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Halt);
			return cb_halt;
		}

		static int n_Halt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Halt ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='halt' and count(parameter)=0]"
		[Register ("halt", "()I", "GetHaltHandler")]
		public abstract int Halt ();

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Open);
			return cb_open;
		}

		static bool n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()Z", "GetOpenHandler")]
		public abstract bool Open ();

		static Delegate cb_readBlock_BarrayB;
#pragma warning disable 0169
		static Delegate GetReadBlock_BarrayBHandler ()
		{
			if (cb_readBlock_BarrayB == null)
				cb_readBlock_BarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, IntPtr, int>) n_ReadBlock_BarrayB);
			return cb_readBlock_BarrayB;
		}

		static int n_ReadBlock_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadBlock (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='readBlock' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("readBlock", "(B[B)I", "GetReadBlock_BarrayBHandler")]
		public abstract int ReadBlock (sbyte p0, byte[] p1);

		static Delegate cb_readBlockX_B;
#pragma warning disable 0169
		static Delegate GetReadBlockX_BHandler ()
		{
			if (cb_readBlockX_B == null)
				cb_readBlockX_B = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, IntPtr>) n_ReadBlockX_B);
			return cb_readBlockX_B;
		}

		static IntPtr n_ReadBlockX_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadBlockX (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='readBlockX' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("readBlockX", "(B)[B", "GetReadBlockX_BHandler")]
		public abstract byte[] ReadBlockX (sbyte p0);

		static Delegate cb_reduceValue_BarrayB;
#pragma warning disable 0169
		static Delegate GetReduceValue_BarrayBHandler ()
		{
			if (cb_reduceValue_BarrayB == null)
				cb_reduceValue_BarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, IntPtr, int>) n_ReduceValue_BarrayB);
			return cb_reduceValue_BarrayB;
		}

		static int n_ReduceValue_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReduceValue (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='reduceValue' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("reduceValue", "(B[B)I", "GetReduceValue_BarrayBHandler")]
		public abstract int ReduceValue (sbyte p0, byte[] p1);

		static Delegate cb_reset_I;
#pragma warning disable 0169
		static Delegate GetReset_IHandler ()
		{
			if (cb_reset_I == null)
				cb_reset_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Reset_I);
			return cb_reset_I;
		}

		static IntPtr n_Reset_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Reset (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reset", "(I)[B", "GetReset_IHandler")]
		public abstract byte[] Reset (int p0);

		static Delegate cb_writeBlock_BarrayB;
#pragma warning disable 0169
		static Delegate GetWriteBlock_BarrayBHandler ()
		{
			if (cb_writeBlock_BarrayB == null)
				cb_writeBlock_BarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, IntPtr, int>) n_WriteBlock_BarrayB);
			return cb_writeBlock_BarrayB;
		}

		static int n_WriteBlock_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteBlock (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='writeBlock' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("writeBlock", "(B[B)I", "GetWriteBlock_BarrayBHandler")]
		public abstract int WriteBlock (sbyte p0, byte[] p1);

		static Delegate cb_getCardType;
#pragma warning disable 0169
		static Delegate GetGetCardTypeHandler ()
		{
			if (cb_getCardType == null)
				cb_getCardType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCardType);
			return cb_getCardType;
		}

		static int n_GetCardType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CardType;
		}
#pragma warning restore 0169

		public abstract int CardType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/class[@name='AidlRFCard.Stub']/method[@name='getCardType' and count(parameter)=0]"
			[Register ("getCardType", "()I", "GetGetCardTypeHandler")] get;
		}

		static Delegate cb_isExist;
#pragma warning disable 0169
		static Delegate GetIsExistHandler ()
		{
			if (cb_isExist == null)
				cb_isExist = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExist);
			return cb_isExist;
		}

		static bool n_IsExist (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExist;
		}
#pragma warning restore 0169

		public abstract bool IsExist {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/class[@name='AidlRFCard.Stub']/method[@name='isExist' and count(parameter)=0]"
			[Register ("isExist", "()Z", "GetIsExistHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/rfcard/AidlRFCard$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlRFCardStubInvoker : AidlRFCardStub {

		public AidlRFCardStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/rfcard/AidlRFCard$Stub", typeof (AidlRFCardStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int CardType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/class[@name='AidlRFCard.Stub']/method[@name='getCardType' and count(parameter)=0]"
			[Register ("getCardType", "()I", "GetGetCardTypeHandler")]
			get {
				const string __id = "getCardType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsExist {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/class[@name='AidlRFCard.Stub']/method[@name='isExist' and count(parameter)=0]"
			[Register ("isExist", "()Z", "GetIsExistHandler")]
			get {
				const string __id = "isExist.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='addValue' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("addValue", "(B[B)I", "GetAddValue_BarrayBHandler")]
		public override unsafe int AddValue (sbyte p0, byte[] p1)
		{
			const string __id = "addValue.(B[B)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='apduComm' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("apduComm", "([B)[B", "GetApduComm_arrayBHandler")]
		public override unsafe byte[] ApduComm (byte[] p0)
		{
			const string __id = "apduComm.([B)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='auth' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("auth", "(IB[B[B)I", "GetAuth_IBarrayBarrayBHandler")]
		public override unsafe int Auth (int p0, sbyte p1, byte[] p2, byte[] p3)
		{
			const string __id = "auth.(IB[B[B)I";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
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
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()Z", "GetCloseHandler")]
		public override unsafe bool Close ()
		{
			const string __id = "close.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='getCardCode' and count(parameter)=0]"
		[Register ("getCardCode", "()[B", "GetGetCardCodeHandler")]
		public override unsafe byte[] GetCardCode ()
		{
			const string __id = "getCardCode.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='halt' and count(parameter)=0]"
		[Register ("halt", "()I", "GetHaltHandler")]
		public override unsafe int Halt ()
		{
			const string __id = "halt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()Z", "GetOpenHandler")]
		public override unsafe bool Open ()
		{
			const string __id = "open.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='readBlock' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("readBlock", "(B[B)I", "GetReadBlock_BarrayBHandler")]
		public override unsafe int ReadBlock (sbyte p0, byte[] p1)
		{
			const string __id = "readBlock.(B[B)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='readBlockX' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("readBlockX", "(B)[B", "GetReadBlockX_BHandler")]
		public override unsafe byte[] ReadBlockX (sbyte p0)
		{
			const string __id = "readBlockX.(B)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='reduceValue' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("reduceValue", "(B[B)I", "GetReduceValue_BarrayBHandler")]
		public override unsafe int ReduceValue (sbyte p0, byte[] p1)
		{
			const string __id = "reduceValue.(B[B)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reset", "(I)[B", "GetReset_IHandler")]
		public override unsafe byte[] Reset (int p0)
		{
			const string __id = "reset.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='writeBlock' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("writeBlock", "(B[B)I", "GetWriteBlock_BarrayBHandler")]
		public override unsafe int WriteBlock (sbyte p0, byte[] p1)
		{
			const string __id = "writeBlock.(B[B)I";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
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

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']"
	[Register ("com/lkl/cloudpos/mdx/aidl/rfcard/AidlRFCard", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker")]
	public partial interface IAidlRFCard : global::Android.OS.IInterface {

		int CardType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='getCardType' and count(parameter)=0]"
			[Register ("getCardType", "()I", "GetGetCardTypeHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")] get;
		}

		bool IsExist {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='isExist' and count(parameter)=0]"
			[Register ("isExist", "()Z", "GetIsExistHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='addValue' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("addValue", "(B[B)I", "GetAddValue_BarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")]
		int AddValue (sbyte p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='apduComm' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("apduComm", "([B)[B", "GetApduComm_arrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")]
		byte[] ApduComm (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='auth' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("auth", "(IB[B[B)I", "GetAuth_IBarrayBarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")]
		int Auth (int p0, sbyte p1, byte[] p2, byte[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()Z", "GetCloseHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")]
		bool Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='getCardCode' and count(parameter)=0]"
		[Register ("getCardCode", "()[B", "GetGetCardCodeHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")]
		byte[] GetCardCode ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='halt' and count(parameter)=0]"
		[Register ("halt", "()I", "GetHaltHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")]
		int Halt ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()Z", "GetOpenHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")]
		bool Open ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='readBlock' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("readBlock", "(B[B)I", "GetReadBlock_BarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")]
		int ReadBlock (sbyte p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='readBlockX' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("readBlockX", "(B)[B", "GetReadBlockX_BHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")]
		byte[] ReadBlockX (sbyte p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='reduceValue' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("reduceValue", "(B[B)I", "GetReduceValue_BarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")]
		int ReduceValue (sbyte p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reset", "(I)[B", "GetReset_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")]
		byte[] Reset (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.rfcard']/interface[@name='AidlRFCard']/method[@name='writeBlock' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register ("writeBlock", "(B[B)I", "GetWriteBlock_BarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCardInvoker, JarBind")]
		int WriteBlock (sbyte p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/rfcard/AidlRFCard", DoNotGenerateAcw=true)]
	internal class IAidlRFCardInvoker : global::Java.Lang.Object, IAidlRFCard {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/rfcard/AidlRFCard", typeof (IAidlRFCardInvoker));

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

		public static IAidlRFCard GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlRFCard> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.rfcard.AidlRFCard"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlRFCardInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCardType;
#pragma warning disable 0169
		static Delegate GetGetCardTypeHandler ()
		{
			if (cb_getCardType == null)
				cb_getCardType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCardType);
			return cb_getCardType;
		}

		static int n_GetCardType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CardType;
		}
#pragma warning restore 0169

		IntPtr id_getCardType;
		public unsafe int CardType {
			get {
				if (id_getCardType == IntPtr.Zero)
					id_getCardType = JNIEnv.GetMethodID (class_ref, "getCardType", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCardType);
			}
		}

		static Delegate cb_isExist;
#pragma warning disable 0169
		static Delegate GetIsExistHandler ()
		{
			if (cb_isExist == null)
				cb_isExist = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExist);
			return cb_isExist;
		}

		static bool n_IsExist (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExist;
		}
#pragma warning restore 0169

		IntPtr id_isExist;
		public unsafe bool IsExist {
			get {
				if (id_isExist == IntPtr.Zero)
					id_isExist = JNIEnv.GetMethodID (class_ref, "isExist", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExist);
			}
		}

		static Delegate cb_addValue_BarrayB;
#pragma warning disable 0169
		static Delegate GetAddValue_BarrayBHandler ()
		{
			if (cb_addValue_BarrayB == null)
				cb_addValue_BarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, IntPtr, int>) n_AddValue_BarrayB);
			return cb_addValue_BarrayB;
		}

		static int n_AddValue_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.AddValue (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addValue_BarrayB;
		public unsafe int AddValue (sbyte p0, byte[] p1)
		{
			if (id_addValue_BarrayB == IntPtr.Zero)
				id_addValue_BarrayB = JNIEnv.GetMethodID (class_ref, "addValue", "(B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_addValue_BarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_apduComm_arrayB;
#pragma warning disable 0169
		static Delegate GetApduComm_arrayBHandler ()
		{
			if (cb_apduComm_arrayB == null)
				cb_apduComm_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ApduComm_arrayB);
			return cb_apduComm_arrayB;
		}

		static IntPtr n_ApduComm_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.ApduComm (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apduComm_arrayB;
		public unsafe byte[] ApduComm (byte[] p0)
		{
			if (id_apduComm_arrayB == IntPtr.Zero)
				id_apduComm_arrayB = JNIEnv.GetMethodID (class_ref, "apduComm", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apduComm_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_auth_IBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetAuth_IBarrayBarrayBHandler ()
		{
			if (cb_auth_IBarrayBarrayB == null)
				cb_auth_IBarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte, IntPtr, IntPtr, int>) n_Auth_IBarrayBarrayB);
			return cb_auth_IBarrayBarrayB;
		}

		static int n_Auth_IBarrayBarrayB (IntPtr jnienv, IntPtr native__this, int p0, sbyte p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Auth (p0, p1, p2, p3);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_auth_IBarrayBarrayB;
		public unsafe int Auth (int p0, sbyte p1, byte[] p2, byte[] p3)
		{
			if (id_auth_IBarrayBarrayB == IntPtr.Zero)
				id_auth_IBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "auth", "(IB[B[B)I");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_auth_IBarrayBarrayB, __args);
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

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Close);
			return cb_close;
		}

		static bool n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe bool Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_getCardCode;
#pragma warning disable 0169
		static Delegate GetGetCardCodeHandler ()
		{
			if (cb_getCardCode == null)
				cb_getCardCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardCode);
			return cb_getCardCode;
		}

		static IntPtr n_GetCardCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCardCode ());
		}
#pragma warning restore 0169

		IntPtr id_getCardCode;
		public unsafe byte[] GetCardCode ()
		{
			if (id_getCardCode == IntPtr.Zero)
				id_getCardCode = JNIEnv.GetMethodID (class_ref, "getCardCode", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardCode), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_halt;
#pragma warning disable 0169
		static Delegate GetHaltHandler ()
		{
			if (cb_halt == null)
				cb_halt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Halt);
			return cb_halt;
		}

		static int n_Halt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Halt ();
		}
#pragma warning restore 0169

		IntPtr id_halt;
		public unsafe int Halt ()
		{
			if (id_halt == IntPtr.Zero)
				id_halt = JNIEnv.GetMethodID (class_ref, "halt", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_halt);
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Open);
			return cb_open;
		}

		static bool n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		IntPtr id_open;
		public unsafe bool Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_open);
		}

		static Delegate cb_readBlock_BarrayB;
#pragma warning disable 0169
		static Delegate GetReadBlock_BarrayBHandler ()
		{
			if (cb_readBlock_BarrayB == null)
				cb_readBlock_BarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, IntPtr, int>) n_ReadBlock_BarrayB);
			return cb_readBlock_BarrayB;
		}

		static int n_ReadBlock_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReadBlock (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readBlock_BarrayB;
		public unsafe int ReadBlock (sbyte p0, byte[] p1)
		{
			if (id_readBlock_BarrayB == IntPtr.Zero)
				id_readBlock_BarrayB = JNIEnv.GetMethodID (class_ref, "readBlock", "(B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readBlock_BarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_readBlockX_B;
#pragma warning disable 0169
		static Delegate GetReadBlockX_BHandler ()
		{
			if (cb_readBlockX_B == null)
				cb_readBlockX_B = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, IntPtr>) n_ReadBlockX_B);
			return cb_readBlockX_B;
		}

		static IntPtr n_ReadBlockX_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadBlockX (p0));
		}
#pragma warning restore 0169

		IntPtr id_readBlockX_B;
		public unsafe byte[] ReadBlockX (sbyte p0)
		{
			if (id_readBlockX_B == IntPtr.Zero)
				id_readBlockX_B = JNIEnv.GetMethodID (class_ref, "readBlockX", "(B)[B");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readBlockX_B, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_reduceValue_BarrayB;
#pragma warning disable 0169
		static Delegate GetReduceValue_BarrayBHandler ()
		{
			if (cb_reduceValue_BarrayB == null)
				cb_reduceValue_BarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, IntPtr, int>) n_ReduceValue_BarrayB);
			return cb_reduceValue_BarrayB;
		}

		static int n_ReduceValue_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ReduceValue (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_reduceValue_BarrayB;
		public unsafe int ReduceValue (sbyte p0, byte[] p1)
		{
			if (id_reduceValue_BarrayB == IntPtr.Zero)
				id_reduceValue_BarrayB = JNIEnv.GetMethodID (class_ref, "reduceValue", "(B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_reduceValue_BarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_reset_I;
#pragma warning disable 0169
		static Delegate GetReset_IHandler ()
		{
			if (cb_reset_I == null)
				cb_reset_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Reset_I);
			return cb_reset_I;
		}

		static IntPtr n_Reset_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Reset (p0));
		}
#pragma warning restore 0169

		IntPtr id_reset_I;
		public unsafe byte[] Reset (int p0)
		{
			if (id_reset_I == IntPtr.Zero)
				id_reset_I = JNIEnv.GetMethodID (class_ref, "reset", "(I)[B");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_reset_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_writeBlock_BarrayB;
#pragma warning disable 0169
		static Delegate GetWriteBlock_BarrayBHandler ()
		{
			if (cb_writeBlock_BarrayB == null)
				cb_writeBlock_BarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, IntPtr, int>) n_WriteBlock_BarrayB);
			return cb_writeBlock_BarrayB;
		}

		static int n_WriteBlock_BarrayB (IntPtr jnienv, IntPtr native__this, sbyte p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.WriteBlock (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_writeBlock_BarrayB;
		public unsafe int WriteBlock (sbyte p0, byte[] p1)
		{
			if (id_writeBlock_BarrayB == IntPtr.Zero)
				id_writeBlock_BarrayB = JNIEnv.GetMethodID (class_ref, "writeBlock", "(B[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_writeBlock_BarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.IAidlRFCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
