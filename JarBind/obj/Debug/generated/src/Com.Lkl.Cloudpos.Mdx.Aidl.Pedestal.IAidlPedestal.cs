using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestal.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestal$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlPedestalStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestal {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestal$Stub", typeof (AidlPedestalStub));
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

		protected AidlPedestalStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestal.Stub']/constructor[@name='AidlPedestal.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlPedestalStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestal.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestal.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestal;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestal AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestal;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestal.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_isCoupled;
#pragma warning disable 0169
		static Delegate GetIsCoupledHandler ()
		{
			if (cb_isCoupled == null)
				cb_isCoupled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCoupled);
			return cb_isCoupled;
		}

		static bool n_IsCoupled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCoupled;
		}
#pragma warning restore 0169

		public abstract bool IsCoupled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestal.Stub']/method[@name='isCoupled' and count(parameter)=0]"
			[Register ("isCoupled", "()Z", "GetIsCoupledHandler")] get;
		}

		static Delegate cb_getSerialManager;
#pragma warning disable 0169
		static Delegate GetGetSerialManagerHandler ()
		{
			if (cb_getSerialManager == null)
				cb_getSerialManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialManager);
			return cb_getSerialManager;
		}

		static IntPtr n_GetSerialManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SerialManager);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder SerialManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestal.Stub']/method[@name='getSerialManager' and count(parameter)=0]"
			[Register ("getSerialManager", "()Landroid/os/IBinder;", "GetGetSerialManagerHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestal$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlPedestalStubInvoker : AidlPedestalStub {

		public AidlPedestalStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestal$Stub", typeof (AidlPedestalStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsCoupled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestal.Stub']/method[@name='isCoupled' and count(parameter)=0]"
			[Register ("isCoupled", "()Z", "GetIsCoupledHandler")]
			get {
				const string __id = "isCoupled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder SerialManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestal.Stub']/method[@name='getSerialManager' and count(parameter)=0]"
			[Register ("getSerialManager", "()Landroid/os/IBinder;", "GetGetSerialManagerHandler")]
			get {
				const string __id = "getSerialManager.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/interface[@name='AidlPedestal']"
	[Register ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestal", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalInvoker")]
	public partial interface IAidlPedestal : global::Android.OS.IInterface {

		bool IsCoupled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/interface[@name='AidlPedestal']/method[@name='isCoupled' and count(parameter)=0]"
			[Register ("isCoupled", "()Z", "GetIsCoupledHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalInvoker, JarBind")] get;
		}

		global::Android.OS.IBinder SerialManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/interface[@name='AidlPedestal']/method[@name='getSerialManager' and count(parameter)=0]"
			[Register ("getSerialManager", "()Landroid/os/IBinder;", "GetGetSerialManagerHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalInvoker, JarBind")] get;
		}

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestal", DoNotGenerateAcw=true)]
	internal class IAidlPedestalInvoker : global::Java.Lang.Object, IAidlPedestal {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestal", typeof (IAidlPedestalInvoker));

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

		public static IAidlPedestal GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlPedestal> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.pedestal.AidlPedestal"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlPedestalInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isCoupled;
#pragma warning disable 0169
		static Delegate GetIsCoupledHandler ()
		{
			if (cb_isCoupled == null)
				cb_isCoupled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCoupled);
			return cb_isCoupled;
		}

		static bool n_IsCoupled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestal __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCoupled;
		}
#pragma warning restore 0169

		IntPtr id_isCoupled;
		public unsafe bool IsCoupled {
			get {
				if (id_isCoupled == IntPtr.Zero)
					id_isCoupled = JNIEnv.GetMethodID (class_ref, "isCoupled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCoupled);
			}
		}

		static Delegate cb_getSerialManager;
#pragma warning disable 0169
		static Delegate GetGetSerialManagerHandler ()
		{
			if (cb_getSerialManager == null)
				cb_getSerialManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialManager);
			return cb_getSerialManager;
		}

		static IntPtr n_GetSerialManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestal __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SerialManager);
		}
#pragma warning restore 0169

		IntPtr id_getSerialManager;
		public unsafe global::Android.OS.IBinder SerialManager {
			get {
				if (id_getSerialManager == IntPtr.Zero)
					id_getSerialManager = JNIEnv.GetMethodID (class_ref, "getSerialManager", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialManager), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestal __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
