using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestalSerialManager.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestalSerialManager$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlPedestalSerialManagerStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManager {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestalSerialManager$Stub", typeof (AidlPedestalSerialManagerStub));
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

		protected AidlPedestalSerialManagerStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestalSerialManager.Stub']/constructor[@name='AidlPedestalSerialManager.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlPedestalSerialManagerStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalSerialManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalSerialManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestalSerialManager.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestalSerialManager.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestalSerialManager;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManager AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestalSerialManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalSerialManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalSerialManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestalSerialManager.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_enumSerialports;
#pragma warning disable 0169
		static Delegate GetEnumSerialportsHandler ()
		{
			if (cb_enumSerialports == null)
				cb_enumSerialports = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnumSerialports);
			return cb_enumSerialports;
		}

		static IntPtr n_EnumSerialports (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalSerialManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalSerialManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.EnumSerialports ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/interface[@name='AidlPedestalSerialManager']/method[@name='enumSerialports' and count(parameter)=0]"
		[Register ("enumSerialports", "()Ljava/util/List;", "GetEnumSerialportsHandler")]
		public abstract global::System.Collections.Generic.IList<string> EnumSerialports ();

		static Delegate cb_getSerialport_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSerialport_Ljava_lang_String_Handler ()
		{
			if (cb_getSerialport_Ljava_lang_String_ == null)
				cb_getSerialport_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSerialport_Ljava_lang_String_);
			return cb_getSerialport_Ljava_lang_String_;
		}

		static IntPtr n_GetSerialport_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalSerialManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalSerialManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSerialport (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/interface[@name='AidlPedestalSerialManager']/method[@name='getSerialport' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSerialport", "(Ljava/lang/String;)Landroid/os/IBinder;", "GetGetSerialport_Ljava_lang_String_Handler")]
		public abstract global::Android.OS.IBinder GetSerialport (string p0);

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalSerialManagerStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalSerialManagerStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		public abstract int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestalSerialManager.Stub']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestalSerialManager$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlPedestalSerialManagerStubInvoker : AidlPedestalSerialManagerStub {

		public AidlPedestalSerialManagerStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestalSerialManager$Stub", typeof (AidlPedestalSerialManagerStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/class[@name='AidlPedestalSerialManager.Stub']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/interface[@name='AidlPedestalSerialManager']/method[@name='enumSerialports' and count(parameter)=0]"
		[Register ("enumSerialports", "()Ljava/util/List;", "GetEnumSerialportsHandler")]
		public override unsafe global::System.Collections.Generic.IList<string> EnumSerialports ()
		{
			const string __id = "enumSerialports.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/interface[@name='AidlPedestalSerialManager']/method[@name='getSerialport' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSerialport", "(Ljava/lang/String;)Landroid/os/IBinder;", "GetGetSerialport_Ljava_lang_String_Handler")]
		public override unsafe global::Android.OS.IBinder GetSerialport (string p0)
		{
			const string __id = "getSerialport.(Ljava/lang/String;)Landroid/os/IBinder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/interface[@name='AidlPedestalSerialManager']"
	[Register ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestalSerialManager", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManagerInvoker")]
	public partial interface IAidlPedestalSerialManager : global::Android.OS.IInterface {

		int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/interface[@name='AidlPedestalSerialManager']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManagerInvoker, ClassLibrary1")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/interface[@name='AidlPedestalSerialManager']/method[@name='enumSerialports' and count(parameter)=0]"
		[Register ("enumSerialports", "()Ljava/util/List;", "GetEnumSerialportsHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManagerInvoker, ClassLibrary1")]
		global::System.Collections.Generic.IList<string> EnumSerialports ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.pedestal']/interface[@name='AidlPedestalSerialManager']/method[@name='getSerialport' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSerialport", "(Ljava/lang/String;)Landroid/os/IBinder;", "GetGetSerialport_Ljava_lang_String_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManagerInvoker, ClassLibrary1")]
		global::Android.OS.IBinder GetSerialport (string p0);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestalSerialManager", DoNotGenerateAcw=true)]
	internal class IAidlPedestalSerialManagerInvoker : global::Java.Lang.Object, IAidlPedestalSerialManager {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestalSerialManager", typeof (IAidlPedestalSerialManagerInvoker));

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

		public static IAidlPedestalSerialManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlPedestalSerialManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.pedestal.AidlPedestalSerialManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlPedestalSerialManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManager __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		IntPtr id_getCount;
		public unsafe int Count {
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
			}
		}

		static Delegate cb_enumSerialports;
#pragma warning disable 0169
		static Delegate GetEnumSerialportsHandler ()
		{
			if (cb_enumSerialports == null)
				cb_enumSerialports = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnumSerialports);
			return cb_enumSerialports;
		}

		static IntPtr n_EnumSerialports (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManager __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.EnumSerialports ());
		}
#pragma warning restore 0169

		IntPtr id_enumSerialports;
		public unsafe global::System.Collections.Generic.IList<string> EnumSerialports ()
		{
			if (id_enumSerialports == IntPtr.Zero)
				id_enumSerialports = JNIEnv.GetMethodID (class_ref, "enumSerialports", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enumSerialports), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getSerialport_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSerialport_Ljava_lang_String_Handler ()
		{
			if (cb_getSerialport_Ljava_lang_String_ == null)
				cb_getSerialport_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSerialport_Ljava_lang_String_);
			return cb_getSerialport_Ljava_lang_String_;
		}

		static IntPtr n_GetSerialport_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManager __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSerialport (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getSerialport_Ljava_lang_String_;
		public unsafe global::Android.OS.IBinder GetSerialport (string p0)
		{
			if (id_getSerialport_Ljava_lang_String_ == IntPtr.Zero)
				id_getSerialport_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSerialport", "(Ljava/lang/String;)Landroid/os/IBinder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Android.OS.IBinder __ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialport_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManager __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.IAidlPedestalSerialManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
