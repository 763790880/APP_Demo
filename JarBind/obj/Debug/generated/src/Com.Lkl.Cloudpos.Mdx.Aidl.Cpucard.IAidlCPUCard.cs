using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/class[@name='AidlCPUCard.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/cpucard/AidlCPUCard$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlCPUCardStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/cpucard/AidlCPUCard$Stub", typeof (AidlCPUCardStub));
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

		protected AidlCPUCardStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/class[@name='AidlCPUCard.Stub']/constructor[@name='AidlCPUCard.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlCPUCardStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/class[@name='AidlCPUCard.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/class[@name='AidlCPUCard.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/cpucard/AidlCPUCard;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/cpucard/AidlCPUCard;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/class[@name='AidlCPUCard.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_changePassword_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetChangePassword_arrayBarrayBHandler ()
		{
			if (cb_changePassword_arrayBarrayB == null)
				cb_changePassword_arrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ChangePassword_arrayBarrayB);
			return cb_changePassword_arrayBarrayB;
		}

		static bool n_ChangePassword_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.ChangePassword (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='changePassword' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("changePassword", "([B[B)Z", "GetChangePassword_arrayBarrayBHandler")]
		public abstract bool ChangePassword (byte[] p0, byte[] p1);

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public abstract void Close ();

		static Delegate cb_open_I;
#pragma warning disable 0169
		static Delegate GetOpen_IHandler ()
		{
			if (cb_open_I == null)
				cb_open_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Open_I);
			return cb_open_I;
		}

		static int n_Open_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='open' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("open", "(I)I", "GetOpen_IHandler")]
		public abstract int Open (int p0);

		static Delegate cb_openWithATRVerification_IarrayB;
#pragma warning disable 0169
		static Delegate GetOpenWithATRVerification_IarrayBHandler ()
		{
			if (cb_openWithATRVerification_IarrayB == null)
				cb_openWithATRVerification_IarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_OpenWithATRVerification_IarrayB);
			return cb_openWithATRVerification_IarrayB;
		}

		static int n_OpenWithATRVerification_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.OpenWithATRVerification (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='openWithATRVerification' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("openWithATRVerification", "(I[B)I", "GetOpenWithATRVerification_IarrayBHandler")]
		public abstract int OpenWithATRVerification (int p0, byte[] p1);

		static Delegate cb_read_arrayBII;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIIHandler ()
		{
			if (cb_read_arrayBII == null)
				cb_read_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Read_arrayBII);
			return cb_read_arrayBII;
		}

		static IntPtr n_Read_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Read (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)[B", "GetRead_arrayBIIHandler")]
		public abstract byte[] Read (byte[] p0, int p1, int p2);

		static Delegate cb_write_arrayBIarrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBIarrayBHandler ()
		{
			if (cb_write_arrayBIarrayB == null)
				cb_write_arrayBIarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_Write_arrayBIarrayB);
			return cb_write_arrayBIarrayB;
		}

		static bool n_Write_arrayBIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Write (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("write", "([BI[B)Z", "GetWrite_arrayBIarrayBHandler")]
		public abstract bool Write (byte[] p0, int p1, byte[] p2);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/cpucard/AidlCPUCard$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlCPUCardStubInvoker : AidlCPUCardStub {

		public AidlCPUCardStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/cpucard/AidlCPUCard$Stub", typeof (AidlCPUCardStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='changePassword' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("changePassword", "([B[B)Z", "GetChangePassword_arrayBarrayBHandler")]
		public override unsafe bool ChangePassword (byte[] p0, byte[] p1)
		{
			const string __id = "changePassword.([B[B)Z";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='open' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("open", "(I)I", "GetOpen_IHandler")]
		public override unsafe int Open (int p0)
		{
			const string __id = "open.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='openWithATRVerification' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("openWithATRVerification", "(I[B)I", "GetOpenWithATRVerification_IarrayBHandler")]
		public override unsafe int OpenWithATRVerification (int p0, byte[] p1)
		{
			const string __id = "openWithATRVerification.(I[B)I";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)[B", "GetRead_arrayBIIHandler")]
		public override unsafe byte[] Read (byte[] p0, int p1, int p2)
		{
			const string __id = "read.([BII)[B";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("write", "([BI[B)Z", "GetWrite_arrayBIarrayBHandler")]
		public override unsafe bool Write (byte[] p0, int p1, byte[] p2)
		{
			const string __id = "write.([BI[B)Z";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']"
	[Register ("com/lkl/cloudpos/mdx/aidl/cpucard/AidlCPUCard", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCardInvoker")]
	public partial interface IAidlCPUCard : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='changePassword' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("changePassword", "([B[B)Z", "GetChangePassword_arrayBarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCardInvoker, JarBind")]
		bool ChangePassword (byte[] p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCardInvoker, JarBind")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='open' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("open", "(I)I", "GetOpen_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCardInvoker, JarBind")]
		int Open (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='openWithATRVerification' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("openWithATRVerification", "(I[B)I", "GetOpenWithATRVerification_IarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCardInvoker, JarBind")]
		int OpenWithATRVerification (int p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)[B", "GetRead_arrayBIIHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCardInvoker, JarBind")]
		byte[] Read (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.cpucard']/interface[@name='AidlCPUCard']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("write", "([BI[B)Z", "GetWrite_arrayBIarrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCardInvoker, JarBind")]
		bool Write (byte[] p0, int p1, byte[] p2);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/cpucard/AidlCPUCard", DoNotGenerateAcw=true)]
	internal class IAidlCPUCardInvoker : global::Java.Lang.Object, IAidlCPUCard {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/cpucard/AidlCPUCard", typeof (IAidlCPUCardInvoker));

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

		public static IAidlCPUCard GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlCPUCard> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.cpucard.AidlCPUCard"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlCPUCardInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_changePassword_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetChangePassword_arrayBarrayBHandler ()
		{
			if (cb_changePassword_arrayBarrayB == null)
				cb_changePassword_arrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ChangePassword_arrayBarrayB);
			return cb_changePassword_arrayBarrayB;
		}

		static bool n_ChangePassword_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.ChangePassword (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_changePassword_arrayBarrayB;
		public unsafe bool ChangePassword (byte[] p0, byte[] p1)
		{
			if (id_changePassword_arrayBarrayB == IntPtr.Zero)
				id_changePassword_arrayBarrayB = JNIEnv.GetMethodID (class_ref, "changePassword", "([B[B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_changePassword_arrayBarrayB, __args);
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

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_open_I;
#pragma warning disable 0169
		static Delegate GetOpen_IHandler ()
		{
			if (cb_open_I == null)
				cb_open_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Open_I);
			return cb_open_I;
		}

		static int n_Open_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open (p0);
		}
#pragma warning restore 0169

		IntPtr id_open_I;
		public unsafe int Open (int p0)
		{
			if (id_open_I == IntPtr.Zero)
				id_open_I = JNIEnv.GetMethodID (class_ref, "open", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_open_I, __args);
		}

		static Delegate cb_openWithATRVerification_IarrayB;
#pragma warning disable 0169
		static Delegate GetOpenWithATRVerification_IarrayBHandler ()
		{
			if (cb_openWithATRVerification_IarrayB == null)
				cb_openWithATRVerification_IarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_OpenWithATRVerification_IarrayB);
			return cb_openWithATRVerification_IarrayB;
		}

		static int n_OpenWithATRVerification_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.OpenWithATRVerification (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_openWithATRVerification_IarrayB;
		public unsafe int OpenWithATRVerification (int p0, byte[] p1)
		{
			if (id_openWithATRVerification_IarrayB == IntPtr.Zero)
				id_openWithATRVerification_IarrayB = JNIEnv.GetMethodID (class_ref, "openWithATRVerification", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_openWithATRVerification_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_read_arrayBII;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIIHandler ()
		{
			if (cb_read_arrayBII == null)
				cb_read_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Read_arrayBII);
			return cb_read_arrayBII;
		}

		static IntPtr n_Read_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Read (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_arrayBII;
		public unsafe byte[] Read (byte[] p0, int p1, int p2)
		{
			if (id_read_arrayBII == IntPtr.Zero)
				id_read_arrayBII = JNIEnv.GetMethodID (class_ref, "read", "([BII)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBII, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_write_arrayBIarrayB;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBIarrayBHandler ()
		{
			if (cb_write_arrayBIarrayB == null)
				cb_write_arrayBIarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_Write_arrayBIarrayB);
			return cb_write_arrayBIarrayB;
		}

		static bool n_Write_arrayBIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.Write (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_write_arrayBIarrayB;
		public unsafe bool Write (byte[] p0, int p1, byte[] p2)
		{
			if (id_write_arrayBIarrayB == IntPtr.Zero)
				id_write_arrayBIarrayB = JNIEnv.GetMethodID (class_ref, "write", "([BI[B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_write_arrayBIarrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.IAidlCPUCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
