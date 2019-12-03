using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/class[@name='GetPinListener.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener$Stub", DoNotGenerateAcw=true)]
	public abstract partial class GetPinListenerStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener$Stub", typeof (GetPinListenerStub));
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

		protected GetPinListenerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/class[@name='GetPinListener.Stub']/constructor[@name='GetPinListener.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetPinListenerStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/class[@name='GetPinListener.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/class[@name='GetPinListener.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/class[@name='GetPinListener.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_onCancelKeyPress;
#pragma warning disable 0169
		static Delegate GetOnCancelKeyPressHandler ()
		{
			if (cb_onCancelKeyPress == null)
				cb_onCancelKeyPress = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancelKeyPress);
			return cb_onCancelKeyPress;
		}

		static void n_OnCancelKeyPress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelKeyPress ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onCancelKeyPress' and count(parameter)=0]"
		[Register ("onCancelKeyPress", "()V", "GetOnCancelKeyPressHandler")]
		public abstract void OnCancelKeyPress ();

		static Delegate cb_onConfirmInput_arrayB;
#pragma warning disable 0169
		static Delegate GetOnConfirmInput_arrayBHandler ()
		{
			if (cb_onConfirmInput_arrayB == null)
				cb_onConfirmInput_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfirmInput_arrayB);
			return cb_onConfirmInput_arrayB;
		}

		static void n_OnConfirmInput_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnConfirmInput (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onConfirmInput' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onConfirmInput", "([B)V", "GetOnConfirmInput_arrayBHandler")]
		public abstract void OnConfirmInput (byte[] p0);

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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler")]
		public abstract void OnError (int p0);

		static Delegate cb_onInputKey_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnInputKey_ILjava_lang_String_Handler ()
		{
			if (cb_onInputKey_ILjava_lang_String_ == null)
				cb_onInputKey_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnInputKey_ILjava_lang_String_);
			return cb_onInputKey_ILjava_lang_String_;
		}

		static void n_OnInputKey_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnInputKey (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onInputKey' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onInputKey", "(ILjava/lang/String;)V", "GetOnInputKey_ILjava_lang_String_Handler")]
		public abstract void OnInputKey (int p0, string p1);

		static Delegate cb_onStopGetPin;
#pragma warning disable 0169
		static Delegate GetOnStopGetPinHandler ()
		{
			if (cb_onStopGetPin == null)
				cb_onStopGetPin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStopGetPin);
			return cb_onStopGetPin;
		}

		static void n_OnStopGetPin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStopGetPin ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onStopGetPin' and count(parameter)=0]"
		[Register ("onStopGetPin", "()V", "GetOnStopGetPinHandler")]
		public abstract void OnStopGetPin ();

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener$Stub", DoNotGenerateAcw=true)]
	internal partial class GetPinListenerStubInvoker : GetPinListenerStub {

		public GetPinListenerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener$Stub", typeof (GetPinListenerStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onCancelKeyPress' and count(parameter)=0]"
		[Register ("onCancelKeyPress", "()V", "GetOnCancelKeyPressHandler")]
		public override unsafe void OnCancelKeyPress ()
		{
			const string __id = "onCancelKeyPress.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onConfirmInput' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onConfirmInput", "([B)V", "GetOnConfirmInput_arrayBHandler")]
		public override unsafe void OnConfirmInput (byte[] p0)
		{
			const string __id = "onConfirmInput.([B)V";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onInputKey' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onInputKey", "(ILjava/lang/String;)V", "GetOnInputKey_ILjava_lang_String_Handler")]
		public override unsafe void OnInputKey (int p0, string p1)
		{
			const string __id = "onInputKey.(ILjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onStopGetPin' and count(parameter)=0]"
		[Register ("onStopGetPin", "()V", "GetOnStopGetPinHandler")]
		public override unsafe void OnStopGetPin ()
		{
			const string __id = "onStopGetPin.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']"
	[Register ("com/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListenerInvoker")]
	public partial interface IGetPinListener : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onCancelKeyPress' and count(parameter)=0]"
		[Register ("onCancelKeyPress", "()V", "GetOnCancelKeyPressHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListenerInvoker, JarBind")]
		void OnCancelKeyPress ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onConfirmInput' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("onConfirmInput", "([B)V", "GetOnConfirmInput_arrayBHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListenerInvoker, JarBind")]
		void OnConfirmInput (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onError", "(I)V", "GetOnError_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListenerInvoker, JarBind")]
		void OnError (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onInputKey' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("onInputKey", "(ILjava/lang/String;)V", "GetOnInputKey_ILjava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListenerInvoker, JarBind")]
		void OnInputKey (int p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pinpad']/interface[@name='GetPinListener']/method[@name='onStopGetPin' and count(parameter)=0]"
		[Register ("onStopGetPin", "()V", "GetOnStopGetPinHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListenerInvoker, JarBind")]
		void OnStopGetPin ();

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener", DoNotGenerateAcw=true)]
	internal class IGetPinListenerInvoker : global::Java.Lang.Object, IGetPinListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener", typeof (IGetPinListenerInvoker));

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

		public static IGetPinListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGetPinListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.pinpad.GetPinListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGetPinListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancelKeyPress;
#pragma warning disable 0169
		static Delegate GetOnCancelKeyPressHandler ()
		{
			if (cb_onCancelKeyPress == null)
				cb_onCancelKeyPress = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancelKeyPress);
			return cb_onCancelKeyPress;
		}

		static void n_OnCancelKeyPress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelKeyPress ();
		}
#pragma warning restore 0169

		IntPtr id_onCancelKeyPress;
		public unsafe void OnCancelKeyPress ()
		{
			if (id_onCancelKeyPress == IntPtr.Zero)
				id_onCancelKeyPress = JNIEnv.GetMethodID (class_ref, "onCancelKeyPress", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancelKeyPress);
		}

		static Delegate cb_onConfirmInput_arrayB;
#pragma warning disable 0169
		static Delegate GetOnConfirmInput_arrayBHandler ()
		{
			if (cb_onConfirmInput_arrayB == null)
				cb_onConfirmInput_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfirmInput_arrayB);
			return cb_onConfirmInput_arrayB;
		}

		static void n_OnConfirmInput_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnConfirmInput (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onConfirmInput_arrayB;
		public unsafe void OnConfirmInput (byte[] p0)
		{
			if (id_onConfirmInput_arrayB == IntPtr.Zero)
				id_onConfirmInput_arrayB = JNIEnv.GetMethodID (class_ref, "onConfirmInput", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConfirmInput_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onInputKey_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnInputKey_ILjava_lang_String_Handler ()
		{
			if (cb_onInputKey_ILjava_lang_String_ == null)
				cb_onInputKey_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnInputKey_ILjava_lang_String_);
			return cb_onInputKey_ILjava_lang_String_;
		}

		static void n_OnInputKey_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnInputKey (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onInputKey_ILjava_lang_String_;
		public unsafe void OnInputKey (int p0, string p1)
		{
			if (id_onInputKey_ILjava_lang_String_ == IntPtr.Zero)
				id_onInputKey_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onInputKey", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInputKey_ILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onStopGetPin;
#pragma warning disable 0169
		static Delegate GetOnStopGetPinHandler ()
		{
			if (cb_onStopGetPin == null)
				cb_onStopGetPin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStopGetPin);
			return cb_onStopGetPin;
		}

		static void n_OnStopGetPin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStopGetPin ();
		}
#pragma warning restore 0169

		IntPtr id_onStopGetPin;
		public unsafe void OnStopGetPin ()
		{
			if (id_onStopGetPin == IntPtr.Zero)
				id_onStopGetPin = JNIEnv.GetMethodID (class_ref, "onStopGetPin", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStopGetPin);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.IGetPinListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
