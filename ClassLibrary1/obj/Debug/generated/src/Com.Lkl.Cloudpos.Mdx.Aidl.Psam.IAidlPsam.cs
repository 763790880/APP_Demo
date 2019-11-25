using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Psam {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/class[@name='AidlPsam.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/psam/AidlPsam$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlPsamStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/psam/AidlPsam$Stub", typeof (AidlPsamStub));
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

		protected AidlPsamStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/class[@name='AidlPsam.Stub']/constructor[@name='AidlPsam.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlPsamStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/class[@name='AidlPsam.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/class[@name='AidlPsam.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/psam/AidlPsam;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/psam/AidlPsam;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/class[@name='AidlPsam.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.ApduComm (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='apduComm' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("apduComm", "([B)[B", "GetApduComm_arrayBHandler")]
		public abstract byte[] ApduComm (byte[] p0);

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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()Z", "GetCloseHandler")]
		public abstract bool Close ();

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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()Z", "GetOpenHandler")]
		public abstract bool Open ();

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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Reset (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reset", "(I)[B", "GetReset_IHandler")]
		public abstract byte[] Reset (int p0);

		static Delegate cb_setETU_B;
#pragma warning disable 0169
		static Delegate GetSetETU_BHandler ()
		{
			if (cb_setETU_B == null)
				cb_setETU_B = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, bool>) n_SetETU_B);
			return cb_setETU_B;
		}

		static bool n_SetETU_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetETU (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='setETU' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("setETU", "(B)Z", "GetSetETU_BHandler")]
		public abstract bool SetETU (sbyte p0);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/psam/AidlPsam$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlPsamStubInvoker : AidlPsamStub {

		public AidlPsamStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/psam/AidlPsam$Stub", typeof (AidlPsamStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='apduComm' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='close' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='open' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='setETU' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("setETU", "(B)Z", "GetSetETU_BHandler")]
		public override unsafe bool SetETU (sbyte p0)
		{
			const string __id = "setETU.(B)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']"
	[Register ("com/lkl/cloudpos/mdx/aidl/psam/AidlPsam", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsamInvoker")]
	public partial interface IAidlPsam : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='apduComm' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("apduComm", "([B)[B", "GetApduComm_arrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsamInvoker, ClassLibrary1")]
		byte[] ApduComm (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()Z", "GetCloseHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsamInvoker, ClassLibrary1")]
		bool Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()Z", "GetOpenHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsamInvoker, ClassLibrary1")]
		bool Open ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reset", "(I)[B", "GetReset_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsamInvoker, ClassLibrary1")]
		byte[] Reset (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.psam']/interface[@name='AidlPsam']/method[@name='setETU' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("setETU", "(B)Z", "GetSetETU_BHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsamInvoker, ClassLibrary1")]
		bool SetETU (sbyte p0);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/psam/AidlPsam", DoNotGenerateAcw=true)]
	internal class IAidlPsamInvoker : global::Java.Lang.Object, IAidlPsam {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/psam/AidlPsam", typeof (IAidlPsamInvoker));

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

		public static IAidlPsam GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlPsam> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.psam.AidlPsam"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlPsamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_setETU_B;
#pragma warning disable 0169
		static Delegate GetSetETU_BHandler ()
		{
			if (cb_setETU_B == null)
				cb_setETU_B = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, bool>) n_SetETU_B);
			return cb_setETU_B;
		}

		static bool n_SetETU_B (IntPtr jnienv, IntPtr native__this, sbyte p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetETU (p0);
		}
#pragma warning restore 0169

		IntPtr id_setETU_B;
		public unsafe bool SetETU (sbyte p0)
		{
			if (id_setETU_B == IntPtr.Zero)
				id_setETU_B = JNIEnv.GetMethodID (class_ref, "setETU", "(B)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setETU_B, __args);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Psam.IAidlPsam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
