using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.System {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='InstallAppObserver.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/system/InstallAppObserver$Stub", DoNotGenerateAcw=true)]
	public abstract partial class InstallAppObserverStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/system/InstallAppObserver$Stub", typeof (InstallAppObserverStub));
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

		protected InstallAppObserverStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='InstallAppObserver.Stub']/constructor[@name='InstallAppObserver.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstallAppObserverStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.InstallAppObserverStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.InstallAppObserverStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='InstallAppObserver.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='InstallAppObserver.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/system/InstallAppObserver;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/system/InstallAppObserver;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.InstallAppObserverStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.InstallAppObserverStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='InstallAppObserver.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_onInstallError_I;
#pragma warning disable 0169
		static Delegate GetOnInstallError_IHandler ()
		{
			if (cb_onInstallError_I == null)
				cb_onInstallError_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnInstallError_I);
			return cb_onInstallError_I;
		}

		static void n_OnInstallError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.InstallAppObserverStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.InstallAppObserverStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInstallError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='InstallAppObserver']/method[@name='onInstallError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onInstallError", "(I)V", "GetOnInstallError_IHandler")]
		public abstract void OnInstallError (int p0);

		static Delegate cb_onInstallFinished;
#pragma warning disable 0169
		static Delegate GetOnInstallFinishedHandler ()
		{
			if (cb_onInstallFinished == null)
				cb_onInstallFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInstallFinished);
			return cb_onInstallFinished;
		}

		static void n_OnInstallFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.InstallAppObserverStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.InstallAppObserverStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInstallFinished ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='InstallAppObserver']/method[@name='onInstallFinished' and count(parameter)=0]"
		[Register ("onInstallFinished", "()V", "GetOnInstallFinishedHandler")]
		public abstract void OnInstallFinished ();

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/system/InstallAppObserver$Stub", DoNotGenerateAcw=true)]
	internal partial class InstallAppObserverStubInvoker : InstallAppObserverStub {

		public InstallAppObserverStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/system/InstallAppObserver$Stub", typeof (InstallAppObserverStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='InstallAppObserver']/method[@name='onInstallError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onInstallError", "(I)V", "GetOnInstallError_IHandler")]
		public override unsafe void OnInstallError (int p0)
		{
			const string __id = "onInstallError.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='InstallAppObserver']/method[@name='onInstallFinished' and count(parameter)=0]"
		[Register ("onInstallFinished", "()V", "GetOnInstallFinishedHandler")]
		public override unsafe void OnInstallFinished ()
		{
			const string __id = "onInstallFinished.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='InstallAppObserver']"
	[Register ("com/lkl/cloudpos/mdx/aidl/system/InstallAppObserver", "", "Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserverInvoker")]
	public partial interface IInstallAppObserver : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='InstallAppObserver']/method[@name='onInstallError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onInstallError", "(I)V", "GetOnInstallError_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserverInvoker, ClassLibrary1")]
		void OnInstallError (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='InstallAppObserver']/method[@name='onInstallFinished' and count(parameter)=0]"
		[Register ("onInstallFinished", "()V", "GetOnInstallFinishedHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserverInvoker, ClassLibrary1")]
		void OnInstallFinished ();

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/system/InstallAppObserver", DoNotGenerateAcw=true)]
	internal class IInstallAppObserverInvoker : global::Java.Lang.Object, IInstallAppObserver {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/system/InstallAppObserver", typeof (IInstallAppObserverInvoker));

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

		public static IInstallAppObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInstallAppObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.system.InstallAppObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInstallAppObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onInstallError_I;
#pragma warning disable 0169
		static Delegate GetOnInstallError_IHandler ()
		{
			if (cb_onInstallError_I == null)
				cb_onInstallError_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnInstallError_I);
			return cb_onInstallError_I;
		}

		static void n_OnInstallError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInstallError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onInstallError_I;
		public unsafe void OnInstallError (int p0)
		{
			if (id_onInstallError_I == IntPtr.Zero)
				id_onInstallError_I = JNIEnv.GetMethodID (class_ref, "onInstallError", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInstallError_I, __args);
		}

		static Delegate cb_onInstallFinished;
#pragma warning disable 0169
		static Delegate GetOnInstallFinishedHandler ()
		{
			if (cb_onInstallFinished == null)
				cb_onInstallFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInstallFinished);
			return cb_onInstallFinished;
		}

		static void n_OnInstallFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInstallFinished ();
		}
#pragma warning restore 0169

		IntPtr id_onInstallFinished;
		public unsafe void OnInstallFinished ()
		{
			if (id_onInstallFinished == IntPtr.Zero)
				id_onInstallFinished = JNIEnv.GetMethodID (class_ref, "onInstallFinished", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInstallFinished);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IInstallAppObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
