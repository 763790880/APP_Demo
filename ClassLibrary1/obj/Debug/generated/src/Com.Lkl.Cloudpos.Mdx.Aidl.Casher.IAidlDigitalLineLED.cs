using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Casher {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlDigitalLineLED.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/casher/AidlDigitalLineLED$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlDigitalLineLEDStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLED {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/casher/AidlDigitalLineLED$Stub", typeof (AidlDigitalLineLEDStub));
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

		protected AidlDigitalLineLEDStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlDigitalLineLED.Stub']/constructor[@name='AidlDigitalLineLED.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlDigitalLineLEDStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlDigitalLineLEDStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlDigitalLineLEDStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlDigitalLineLED.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlDigitalLineLED.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/casher/AidlDigitalLineLED;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLED AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/casher/AidlDigitalLineLED;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLED> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlDigitalLineLEDStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlDigitalLineLEDStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlDigitalLineLED.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_EraseLine_I;
#pragma warning disable 0169
		static Delegate GetEraseLine_IHandler ()
		{
			if (cb_EraseLine_I == null)
				cb_EraseLine_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_EraseLine_I);
			return cb_EraseLine_I;
		}

		static bool n_EraseLine_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlDigitalLineLEDStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlDigitalLineLEDStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EraseLine (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlDigitalLineLED']/method[@name='EraseLine' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("EraseLine", "(I)Z", "GetEraseLine_IHandler")]
		public abstract bool EraseLine (int p0);

		static Delegate cb_displayAmt_IZF;
#pragma warning disable 0169
		static Delegate GetDisplayAmt_IZFHandler ()
		{
			if (cb_displayAmt_IZF == null)
				cb_displayAmt_IZF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, float, bool>) n_DisplayAmt_IZF);
			return cb_displayAmt_IZF;
		}

		static bool n_DisplayAmt_IZF (IntPtr jnienv, IntPtr native__this, int p0, bool p1, float p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlDigitalLineLEDStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlDigitalLineLEDStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayAmt (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlDigitalLineLED']/method[@name='displayAmt' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='float']]"
		[Register ("displayAmt", "(IZF)Z", "GetDisplayAmt_IZFHandler")]
		public abstract bool DisplayAmt (int p0, bool p1, float p2);

		static Delegate cb_getLineCount;
#pragma warning disable 0169
		static Delegate GetGetLineCountHandler ()
		{
			if (cb_getLineCount == null)
				cb_getLineCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLineCount);
			return cb_getLineCount;
		}

		static int n_GetLineCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlDigitalLineLEDStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlDigitalLineLEDStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineCount;
		}
#pragma warning restore 0169

		public abstract int LineCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlDigitalLineLED.Stub']/method[@name='getLineCount' and count(parameter)=0]"
			[Register ("getLineCount", "()I", "GetGetLineCountHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/casher/AidlDigitalLineLED$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlDigitalLineLEDStubInvoker : AidlDigitalLineLEDStub {

		public AidlDigitalLineLEDStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/casher/AidlDigitalLineLED$Stub", typeof (AidlDigitalLineLEDStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int LineCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/class[@name='AidlDigitalLineLED.Stub']/method[@name='getLineCount' and count(parameter)=0]"
			[Register ("getLineCount", "()I", "GetGetLineCountHandler")]
			get {
				const string __id = "getLineCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlDigitalLineLED']/method[@name='EraseLine' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("EraseLine", "(I)Z", "GetEraseLine_IHandler")]
		public override unsafe bool EraseLine (int p0)
		{
			const string __id = "EraseLine.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlDigitalLineLED']/method[@name='displayAmt' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='float']]"
		[Register ("displayAmt", "(IZF)Z", "GetDisplayAmt_IZFHandler")]
		public override unsafe bool DisplayAmt (int p0, bool p1, float p2)
		{
			const string __id = "displayAmt.(IZF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlDigitalLineLED']"
	[Register ("com/lkl/cloudpos/mdx/aidl/casher/AidlDigitalLineLED", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLEDInvoker")]
	public partial interface IAidlDigitalLineLED : global::Android.OS.IInterface {

		int LineCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlDigitalLineLED']/method[@name='getLineCount' and count(parameter)=0]"
			[Register ("getLineCount", "()I", "GetGetLineCountHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLEDInvoker, ClassLibrary1")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlDigitalLineLED']/method[@name='EraseLine' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("EraseLine", "(I)Z", "GetEraseLine_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLEDInvoker, ClassLibrary1")]
		bool EraseLine (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.casher']/interface[@name='AidlDigitalLineLED']/method[@name='displayAmt' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='float']]"
		[Register ("displayAmt", "(IZF)Z", "GetDisplayAmt_IZFHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLEDInvoker, ClassLibrary1")]
		bool DisplayAmt (int p0, bool p1, float p2);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/casher/AidlDigitalLineLED", DoNotGenerateAcw=true)]
	internal class IAidlDigitalLineLEDInvoker : global::Java.Lang.Object, IAidlDigitalLineLED {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/casher/AidlDigitalLineLED", typeof (IAidlDigitalLineLEDInvoker));

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

		public static IAidlDigitalLineLED GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlDigitalLineLED> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.casher.AidlDigitalLineLED"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlDigitalLineLEDInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getLineCount;
#pragma warning disable 0169
		static Delegate GetGetLineCountHandler ()
		{
			if (cb_getLineCount == null)
				cb_getLineCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLineCount);
			return cb_getLineCount;
		}

		static int n_GetLineCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLED __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLED> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineCount;
		}
#pragma warning restore 0169

		IntPtr id_getLineCount;
		public unsafe int LineCount {
			get {
				if (id_getLineCount == IntPtr.Zero)
					id_getLineCount = JNIEnv.GetMethodID (class_ref, "getLineCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLineCount);
			}
		}

		static Delegate cb_EraseLine_I;
#pragma warning disable 0169
		static Delegate GetEraseLine_IHandler ()
		{
			if (cb_EraseLine_I == null)
				cb_EraseLine_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_EraseLine_I);
			return cb_EraseLine_I;
		}

		static bool n_EraseLine_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLED __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLED> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EraseLine (p0);
		}
#pragma warning restore 0169

		IntPtr id_EraseLine_I;
		public unsafe bool EraseLine (int p0)
		{
			if (id_EraseLine_I == IntPtr.Zero)
				id_EraseLine_I = JNIEnv.GetMethodID (class_ref, "EraseLine", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_EraseLine_I, __args);
		}

		static Delegate cb_displayAmt_IZF;
#pragma warning disable 0169
		static Delegate GetDisplayAmt_IZFHandler ()
		{
			if (cb_displayAmt_IZF == null)
				cb_displayAmt_IZF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, float, bool>) n_DisplayAmt_IZF);
			return cb_displayAmt_IZF;
		}

		static bool n_DisplayAmt_IZF (IntPtr jnienv, IntPtr native__this, int p0, bool p1, float p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLED __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLED> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayAmt (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_displayAmt_IZF;
		public unsafe bool DisplayAmt (int p0, bool p1, float p2)
		{
			if (id_displayAmt_IZF == IntPtr.Zero)
				id_displayAmt_IZF = JNIEnv.GetMethodID (class_ref, "displayAmt", "(IZF)Z");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_displayAmt_IZF, __args);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLED __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Casher.IAidlDigitalLineLED> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
