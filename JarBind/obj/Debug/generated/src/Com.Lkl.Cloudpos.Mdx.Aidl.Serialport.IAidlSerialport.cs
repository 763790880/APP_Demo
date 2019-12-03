using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Serialport {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/class[@name='AidlSerialport.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/serialport/AidlSerialport$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlSerialportStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/serialport/AidlSerialport$Stub", typeof (AidlSerialportStub));
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

		protected AidlSerialportStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/class[@name='AidlSerialport.Stub']/constructor[@name='AidlSerialport.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlSerialportStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/class[@name='AidlSerialport.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/class[@name='AidlSerialport.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/serialport/AidlSerialport;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/serialport/AidlSerialport;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/class[@name='AidlSerialport.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()Z", "GetCloseHandler")]
		public abstract bool Close ();

		static Delegate cb_init_IBBB;
#pragma warning disable 0169
		static Delegate GetInit_IBBBHandler ()
		{
			if (cb_init_IBBB == null)
				cb_init_IBBB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte, sbyte, sbyte, bool>) n_Init_IBBB);
			return cb_init_IBBB;
		}

		static bool n_Init_IBBB (IntPtr jnienv, IntPtr native__this, int p0, sbyte p1, sbyte p2, sbyte p3)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Init (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='init' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte']]"
		[Register ("init", "(IBBB)Z", "GetInit_IBBBHandler")]
		public abstract bool Init (int p0, sbyte p1, sbyte p2, sbyte p3);

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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()Z", "GetOpenHandler")]
		public abstract bool Open ();

		static Delegate cb_readData_I;
#pragma warning disable 0169
		static Delegate GetReadData_IHandler ()
		{
			if (cb_readData_I == null)
				cb_readData_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ReadData_I);
			return cb_readData_I;
		}

		static IntPtr n_ReadData_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadData (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='readData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readData", "(I)[B", "GetReadData_IHandler")]
		public abstract byte[] ReadData (int p0);

		static Delegate cb_sendData_arrayBI;
#pragma warning disable 0169
		static Delegate GetSendData_arrayBIHandler ()
		{
			if (cb_sendData_arrayBI == null)
				cb_sendData_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_SendData_arrayBI);
			return cb_sendData_arrayBI;
		}

		static bool n_SendData_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SendData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='sendData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("sendData", "([BI)Z", "GetSendData_arrayBIHandler")]
		public abstract bool SendData (byte[] p0, int p1);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/serialport/AidlSerialport$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlSerialportStubInvoker : AidlSerialportStub {

		public AidlSerialportStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/serialport/AidlSerialport$Stub", typeof (AidlSerialportStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='close' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='init' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte']]"
		[Register ("init", "(IBBB)Z", "GetInit_IBBBHandler")]
		public override unsafe bool Init (int p0, sbyte p1, sbyte p2, sbyte p3)
		{
			const string __id = "init.(IBBB)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='open' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='readData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readData", "(I)[B", "GetReadData_IHandler")]
		public override unsafe byte[] ReadData (int p0)
		{
			const string __id = "readData.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='sendData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("sendData", "([BI)Z", "GetSendData_arrayBIHandler")]
		public override unsafe bool SendData (byte[] p0, int p1)
		{
			const string __id = "sendData.([BI)Z";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']"
	[Register ("com/lkl/cloudpos/mdx/aidl/serialport/AidlSerialport", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialportInvoker")]
	public partial interface IAidlSerialport : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()Z", "GetCloseHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialportInvoker, JarBind")]
		bool Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='init' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte']]"
		[Register ("init", "(IBBB)Z", "GetInit_IBBBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialportInvoker, JarBind")]
		bool Init (int p0, sbyte p1, sbyte p2, sbyte p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()Z", "GetOpenHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialportInvoker, JarBind")]
		bool Open ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='readData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readData", "(I)[B", "GetReadData_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialportInvoker, JarBind")]
		byte[] ReadData (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.serialport']/interface[@name='AidlSerialport']/method[@name='sendData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("sendData", "([BI)Z", "GetSendData_arrayBIHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialportInvoker, JarBind")]
		bool SendData (byte[] p0, int p1);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/serialport/AidlSerialport", DoNotGenerateAcw=true)]
	internal class IAidlSerialportInvoker : global::Java.Lang.Object, IAidlSerialport {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/serialport/AidlSerialport", typeof (IAidlSerialportInvoker));

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

		public static IAidlSerialport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlSerialport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.serialport.AidlSerialport"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlSerialportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_init_IBBB;
#pragma warning disable 0169
		static Delegate GetInit_IBBBHandler ()
		{
			if (cb_init_IBBB == null)
				cb_init_IBBB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, sbyte, sbyte, sbyte, bool>) n_Init_IBBB);
			return cb_init_IBBB;
		}

		static bool n_Init_IBBB (IntPtr jnienv, IntPtr native__this, int p0, sbyte p1, sbyte p2, sbyte p3)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Init (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_init_IBBB;
		public unsafe bool Init (int p0, sbyte p1, sbyte p2, sbyte p3)
		{
			if (id_init_IBBB == IntPtr.Zero)
				id_init_IBBB = JNIEnv.GetMethodID (class_ref, "init", "(IBBB)Z");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_init_IBBB, __args);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_readData_I;
#pragma warning disable 0169
		static Delegate GetReadData_IHandler ()
		{
			if (cb_readData_I == null)
				cb_readData_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ReadData_I);
			return cb_readData_I;
		}

		static IntPtr n_ReadData_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadData (p0));
		}
#pragma warning restore 0169

		IntPtr id_readData_I;
		public unsafe byte[] ReadData (int p0)
		{
			if (id_readData_I == IntPtr.Zero)
				id_readData_I = JNIEnv.GetMethodID (class_ref, "readData", "(I)[B");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readData_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_sendData_arrayBI;
#pragma warning disable 0169
		static Delegate GetSendData_arrayBIHandler ()
		{
			if (cb_sendData_arrayBI == null)
				cb_sendData_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_SendData_arrayBI);
			return cb_sendData_arrayBI;
		}

		static bool n_SendData_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.SendData (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_sendData_arrayBI;
		public unsafe bool SendData (byte[] p0, int p1)
		{
			if (id_sendData_arrayBI == IntPtr.Zero)
				id_sendData_arrayBI = JNIEnv.GetMethodID (class_ref, "sendData", "([BI)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_sendData_arrayBI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.IAidlSerialport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
