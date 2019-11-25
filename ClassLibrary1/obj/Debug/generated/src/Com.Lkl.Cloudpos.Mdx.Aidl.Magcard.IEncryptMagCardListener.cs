using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Magcard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='EncryptMagCardListener.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener$Stub", DoNotGenerateAcw=true)]
	public abstract partial class EncryptMagCardListenerStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener$Stub", typeof (EncryptMagCardListenerStub));
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

		protected EncryptMagCardListenerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='EncryptMagCardListener.Stub']/constructor[@name='EncryptMagCardListener.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EncryptMagCardListenerStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='EncryptMagCardListener.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='EncryptMagCardListener.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='EncryptMagCardListener.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_onCanceled;
#pragma warning disable 0169
		static Delegate GetOnCanceledHandler ()
		{
			if (cb_onCanceled == null)
				cb_onCanceled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCanceled);
			return cb_onCanceled;
		}

		static void n_OnCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCanceled ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onCanceled' and count(parameter)=0]"
		[Register ("onCanceled", "()V", "GetOnCanceledHandler")]
		public abstract void OnCanceled ();

		static Delegate cb_onError_I;
#pragma warning disable 0169
		static Delegate GetOnError_IHandler ()
		{
			if (cb_onError_I == null)
				cb_onError_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnError_I);
			return cb_onError_I;
		}

		static void n_OnError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler")]
		public abstract void OnError (int p0);

		static Delegate cb_onGetTrackFail;
#pragma warning disable 0169
		static Delegate GetOnGetTrackFailHandler ()
		{
			if (cb_onGetTrackFail == null)
				cb_onGetTrackFail = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnGetTrackFail);
			return cb_onGetTrackFail;
		}

		static void n_OnGetTrackFail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnGetTrackFail ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onGetTrackFail' and count(parameter)=0]"
		[Register ("onGetTrackFail", "()V", "GetOnGetTrackFailHandler")]
		public abstract void OnGetTrackFail ();

		static Delegate cb_onSuccess_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_arrayLjava_lang_String_Handler ()
		{
			if (cb_onSuccess_arrayLjava_lang_String_ == null)
				cb_onSuccess_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_arrayLjava_lang_String_);
			return cb_onSuccess_arrayLjava_lang_String_;
		}

		static void n_OnSuccess_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.OnSuccess (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("onSuccess", "([Ljava/lang/String;)V", "GetOnSuccess_arrayLjava_lang_String_Handler")]
		public abstract void OnSuccess (string[] p0);

		static Delegate cb_onTimeout;
#pragma warning disable 0169
		static Delegate GetOnTimeoutHandler ()
		{
			if (cb_onTimeout == null)
				cb_onTimeout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTimeout);
			return cb_onTimeout;
		}

		static void n_OnTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTimeout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onTimeout' and count(parameter)=0]"
		[Register ("onTimeout", "()V", "GetOnTimeoutHandler")]
		public abstract void OnTimeout ();

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener$Stub", DoNotGenerateAcw=true)]
	internal partial class EncryptMagCardListenerStubInvoker : EncryptMagCardListenerStub {

		public EncryptMagCardListenerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener$Stub", typeof (EncryptMagCardListenerStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onCanceled' and count(parameter)=0]"
		[Register ("onCanceled", "()V", "GetOnCanceledHandler")]
		public override unsafe void OnCanceled ()
		{
			const string __id = "onCanceled.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler")]
		public override unsafe void OnError (int p0)
		{
			const string __id = "onError.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onGetTrackFail' and count(parameter)=0]"
		[Register ("onGetTrackFail", "()V", "GetOnGetTrackFailHandler")]
		public override unsafe void OnGetTrackFail ()
		{
			const string __id = "onGetTrackFail.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("onSuccess", "([Ljava/lang/String;)V", "GetOnSuccess_arrayLjava_lang_String_Handler")]
		public override unsafe void OnSuccess (string[] p0)
		{
			const string __id = "onSuccess.([Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onTimeout' and count(parameter)=0]"
		[Register ("onTimeout", "()V", "GetOnTimeoutHandler")]
		public override unsafe void OnTimeout ()
		{
			const string __id = "onTimeout.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']"
	[Register ("com/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListenerInvoker")]
	public partial interface IEncryptMagCardListener : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onCanceled' and count(parameter)=0]"
		[Register ("onCanceled", "()V", "GetOnCanceledHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListenerInvoker, ClassLibrary1")]
		void OnCanceled ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListenerInvoker, ClassLibrary1")]
		void OnError (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onGetTrackFail' and count(parameter)=0]"
		[Register ("onGetTrackFail", "()V", "GetOnGetTrackFailHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListenerInvoker, ClassLibrary1")]
		void OnGetTrackFail ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("onSuccess", "([Ljava/lang/String;)V", "GetOnSuccess_arrayLjava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListenerInvoker, ClassLibrary1")]
		void OnSuccess (string[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='EncryptMagCardListener']/method[@name='onTimeout' and count(parameter)=0]"
		[Register ("onTimeout", "()V", "GetOnTimeoutHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListenerInvoker, ClassLibrary1")]
		void OnTimeout ();

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener", DoNotGenerateAcw=true)]
	internal class IEncryptMagCardListenerInvoker : global::Java.Lang.Object, IEncryptMagCardListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener", typeof (IEncryptMagCardListenerInvoker));

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

		public static IEncryptMagCardListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEncryptMagCardListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.magcard.EncryptMagCardListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEncryptMagCardListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCanceled;
#pragma warning disable 0169
		static Delegate GetOnCanceledHandler ()
		{
			if (cb_onCanceled == null)
				cb_onCanceled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCanceled);
			return cb_onCanceled;
		}

		static void n_OnCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCanceled ();
		}
#pragma warning restore 0169

		IntPtr id_onCanceled;
		public unsafe void OnCanceled ()
		{
			if (id_onCanceled == IntPtr.Zero)
				id_onCanceled = JNIEnv.GetMethodID (class_ref, "onCanceled", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCanceled);
		}

		static Delegate cb_onError_I;
#pragma warning disable 0169
		static Delegate GetOnError_IHandler ()
		{
			if (cb_onError_I == null)
				cb_onError_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnError_I);
			return cb_onError_I;
		}

		static void n_OnError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_I;
		public unsafe void OnError (int p0)
		{
			if (id_onError_I == IntPtr.Zero)
				id_onError_I = JNIEnv.GetMethodID (class_ref, "onError", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_I, __args);
		}

		static Delegate cb_onGetTrackFail;
#pragma warning disable 0169
		static Delegate GetOnGetTrackFailHandler ()
		{
			if (cb_onGetTrackFail == null)
				cb_onGetTrackFail = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnGetTrackFail);
			return cb_onGetTrackFail;
		}

		static void n_OnGetTrackFail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnGetTrackFail ();
		}
#pragma warning restore 0169

		IntPtr id_onGetTrackFail;
		public unsafe void OnGetTrackFail ()
		{
			if (id_onGetTrackFail == IntPtr.Zero)
				id_onGetTrackFail = JNIEnv.GetMethodID (class_ref, "onGetTrackFail", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onGetTrackFail);
		}

		static Delegate cb_onSuccess_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_arrayLjava_lang_String_Handler ()
		{
			if (cb_onSuccess_arrayLjava_lang_String_ == null)
				cb_onSuccess_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_arrayLjava_lang_String_);
			return cb_onSuccess_arrayLjava_lang_String_;
		}

		static void n_OnSuccess_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.OnSuccess (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_arrayLjava_lang_String_;
		public unsafe void OnSuccess (string[] p0)
		{
			if (id_onSuccess_arrayLjava_lang_String_ == IntPtr.Zero)
				id_onSuccess_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_arrayLjava_lang_String_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onTimeout;
#pragma warning disable 0169
		static Delegate GetOnTimeoutHandler ()
		{
			if (cb_onTimeout == null)
				cb_onTimeout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTimeout);
			return cb_onTimeout;
		}

		static void n_OnTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTimeout ();
		}
#pragma warning restore 0169

		IntPtr id_onTimeout;
		public unsafe void OnTimeout ()
		{
			if (id_onTimeout == IntPtr.Zero)
				id_onTimeout = JNIEnv.GetMethodID (class_ref, "onTimeout", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTimeout);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
