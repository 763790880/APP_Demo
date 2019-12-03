using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.System {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlMerListener.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/system/AidlMerListener$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlMerListenerStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/system/AidlMerListener$Stub", typeof (AidlMerListenerStub));
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

		protected AidlMerListenerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlMerListener.Stub']/constructor[@name='AidlMerListener.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlMerListenerStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlMerListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlMerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlMerListener.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlMerListener.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/system/AidlMerListener;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/system/AidlMerListener;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlMerListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlMerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/class[@name='AidlMerListener.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_onFail_I;
#pragma warning disable 0169
		static Delegate GetOnFail_IHandler ()
		{
			if (cb_onFail_I == null)
				cb_onFail_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnFail_I);
			return cb_onFail_I;
		}

		static void n_OnFail_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlMerListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlMerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFail (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlMerListener']/method[@name='onFail' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onFail", "(I)V", "GetOnFail_IHandler")]
		public abstract void OnFail (int p0);

		static Delegate cb_onSuccess_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onSuccess_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_Ljava_lang_String_);
			return cb_onSuccess_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnSuccess_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlMerListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlMerListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlMerListener']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void OnSuccess (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/system/AidlMerListener$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlMerListenerStubInvoker : AidlMerListenerStub {

		public AidlMerListenerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/system/AidlMerListener$Stub", typeof (AidlMerListenerStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlMerListener']/method[@name='onFail' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onFail", "(I)V", "GetOnFail_IHandler")]
		public override unsafe void OnFail (int p0)
		{
			const string __id = "onFail.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlMerListener']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void OnSuccess (string p0, string p1)
		{
			const string __id = "onSuccess.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlMerListener']"
	[Register ("com/lkl/cloudpos/mdx/aidl/system/AidlMerListener", "", "Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListenerInvoker")]
	public partial interface IAidlMerListener : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlMerListener']/method[@name='onFail' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onFail", "(I)V", "GetOnFail_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListenerInvoker, JarBind")]
		void OnFail (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.system']/interface[@name='AidlMerListener']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onSuccess", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Ljava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListenerInvoker, JarBind")]
		void OnSuccess (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/system/AidlMerListener", DoNotGenerateAcw=true)]
	internal class IAidlMerListenerInvoker : global::Java.Lang.Object, IAidlMerListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/system/AidlMerListener", typeof (IAidlMerListenerInvoker));

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

		public static IAidlMerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlMerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.system.AidlMerListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlMerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFail_I;
#pragma warning disable 0169
		static Delegate GetOnFail_IHandler ()
		{
			if (cb_onFail_I == null)
				cb_onFail_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnFail_I);
			return cb_onFail_I;
		}

		static void n_OnFail_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFail (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFail_I;
		public unsafe void OnFail (int p0)
		{
			if (id_onFail_I == IntPtr.Zero)
				id_onFail_I = JNIEnv.GetMethodID (class_ref, "onFail", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFail_I, __args);
		}

		static Delegate cb_onSuccess_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onSuccess_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onSuccess_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_Ljava_lang_String_);
			return cb_onSuccess_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnSuccess_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnSuccess (string p0, string p1)
		{
			if (id_onSuccess_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onSuccess_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.System.IAidlMerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
