using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/class[@name='AidlFacingbackCamera.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/camera/AidlFacingbackCamera$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlFacingbackCameraStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/camera/AidlFacingbackCamera$Stub", typeof (AidlFacingbackCameraStub));
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

		protected AidlFacingbackCameraStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/class[@name='AidlFacingbackCamera.Stub']/constructor[@name='AidlFacingbackCamera.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlFacingbackCameraStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/class[@name='AidlFacingbackCamera.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/class[@name='AidlFacingbackCamera.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/camera/AidlFacingbackCamera;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/camera/AidlFacingbackCamera;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/class[@name='AidlFacingbackCamera.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public abstract void Close ();

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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()Z", "GetOpenHandler")]
		public abstract bool Open ();

		static Delegate cb_scanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_;
#pragma warning disable 0169
		static Delegate GetScanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_Handler ()
		{
			if (cb_scanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_ == null)
				cb_scanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ScanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_);
			return cb_scanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_;
		}

		static void n_ScanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlCameraScanCodeListener p0 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlCameraScanCodeListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlCameraScanCodeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ScanCode (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']/method[@name='scanCode' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.camera.AidlCameraScanCodeListener']]"
		[Register ("scanCode", "(Lcom/lkl/cloudpos/mdx/aidl/camera/AidlCameraScanCodeListener;)V", "GetScanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_Handler")]
		public abstract void ScanCode (global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlCameraScanCodeListener p0);

		static Delegate cb_setTimeout_J;
#pragma warning disable 0169
		static Delegate GetSetTimeout_JHandler ()
		{
			if (cb_setTimeout_J == null)
				cb_setTimeout_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimeout_J);
			return cb_setTimeout_J;
		}

		static void n_SetTimeout_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeout (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setTimeout", "(J)V", "GetSetTimeout_JHandler")]
		public abstract void SetTimeout (long p0);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/camera/AidlFacingbackCamera$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlFacingbackCameraStubInvoker : AidlFacingbackCameraStub {

		public AidlFacingbackCameraStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/camera/AidlFacingbackCamera$Stub", typeof (AidlFacingbackCameraStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public override unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']/method[@name='open' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']/method[@name='scanCode' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.camera.AidlCameraScanCodeListener']]"
		[Register ("scanCode", "(Lcom/lkl/cloudpos/mdx/aidl/camera/AidlCameraScanCodeListener;)V", "GetScanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_Handler")]
		public override unsafe void ScanCode (global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlCameraScanCodeListener p0)
		{
			const string __id = "scanCode.(Lcom/lkl/cloudpos/mdx/aidl/camera/AidlCameraScanCodeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setTimeout", "(J)V", "GetSetTimeout_JHandler")]
		public override unsafe void SetTimeout (long p0)
		{
			const string __id = "setTimeout.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']"
	[Register ("com/lkl/cloudpos/mdx/aidl/camera/AidlFacingbackCamera", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCameraInvoker")]
	public partial interface IAidlFacingbackCamera : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCameraInvoker, ClassLibrary1")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()Z", "GetOpenHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCameraInvoker, ClassLibrary1")]
		bool Open ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']/method[@name='scanCode' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.camera.AidlCameraScanCodeListener']]"
		[Register ("scanCode", "(Lcom/lkl/cloudpos/mdx/aidl/camera/AidlCameraScanCodeListener;)V", "GetScanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCameraInvoker, ClassLibrary1")]
		void ScanCode (global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlCameraScanCodeListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.camera']/interface[@name='AidlFacingbackCamera']/method[@name='setTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setTimeout", "(J)V", "GetSetTimeout_JHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCameraInvoker, ClassLibrary1")]
		void SetTimeout (long p0);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/camera/AidlFacingbackCamera", DoNotGenerateAcw=true)]
	internal class IAidlFacingbackCameraInvoker : global::Java.Lang.Object, IAidlFacingbackCamera {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/camera/AidlFacingbackCamera", typeof (IAidlFacingbackCameraInvoker));

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

		public static IAidlFacingbackCamera GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlFacingbackCamera> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.camera.AidlFacingbackCamera"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlFacingbackCameraInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_scanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_;
#pragma warning disable 0169
		static Delegate GetScanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_Handler ()
		{
			if (cb_scanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_ == null)
				cb_scanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ScanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_);
			return cb_scanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_;
		}

		static void n_ScanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlCameraScanCodeListener p0 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlCameraScanCodeListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlCameraScanCodeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ScanCode (p0);
		}
#pragma warning restore 0169

		IntPtr id_scanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_;
		public unsafe void ScanCode (global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlCameraScanCodeListener p0)
		{
			if (id_scanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_ == IntPtr.Zero)
				id_scanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_ = JNIEnv.GetMethodID (class_ref, "scanCode", "(Lcom/lkl/cloudpos/mdx/aidl/camera/AidlCameraScanCodeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scanCode_Lcom_lkl_cloudpos_mdx_aidl_camera_AidlCameraScanCodeListener_, __args);
		}

		static Delegate cb_setTimeout_J;
#pragma warning disable 0169
		static Delegate GetSetTimeout_JHandler ()
		{
			if (cb_setTimeout_J == null)
				cb_setTimeout_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimeout_J);
			return cb_setTimeout_J;
		}

		static void n_SetTimeout_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeout (p0);
		}
#pragma warning restore 0169

		IntPtr id_setTimeout_J;
		public unsafe void SetTimeout (long p0)
		{
			if (id_setTimeout_J == IntPtr.Zero)
				id_setTimeout_J = JNIEnv.GetMethodID (class_ref, "setTimeout", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeout_J, __args);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Camera.IAidlFacingbackCamera> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
