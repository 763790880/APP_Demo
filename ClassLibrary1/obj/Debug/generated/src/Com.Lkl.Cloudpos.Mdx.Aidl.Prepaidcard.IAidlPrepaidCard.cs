using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCard.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCard$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlPrepaidCardStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCard {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCard$Stub", typeof (AidlPrepaidCardStub));
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

		protected AidlPrepaidCardStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCard.Stub']/constructor[@name='AidlPrepaidCard.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlPrepaidCardStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCard.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCard.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCard;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCard AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCard;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCard> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCard.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_getPrepaidCardPinPad_I;
#pragma warning disable 0169
		static Delegate GetGetPrepaidCardPinPad_IHandler ()
		{
			if (cb_getPrepaidCardPinPad_I == null)
				cb_getPrepaidCardPinPad_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPrepaidCardPinPad_I);
			return cb_getPrepaidCardPinPad_I;
		}

		static IntPtr n_GetPrepaidCardPinPad_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPrepaidCardPinPad (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCard']/method[@name='getPrepaidCardPinPad' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPrepaidCardPinPad", "(I)Landroid/os/IBinder;", "GetGetPrepaidCardPinPad_IHandler")]
		public abstract global::Android.OS.IBinder GetPrepaidCardPinPad (int p0);

		static Delegate cb_getPrepaidCardEMV;
#pragma warning disable 0169
		static Delegate GetGetPrepaidCardEMVHandler ()
		{
			if (cb_getPrepaidCardEMV == null)
				cb_getPrepaidCardEMV = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrepaidCardEMV);
			return cb_getPrepaidCardEMV;
		}

		static IntPtr n_GetPrepaidCardEMV (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PrepaidCardEMV);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder PrepaidCardEMV {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCard.Stub']/method[@name='getPrepaidCardEMV' and count(parameter)=0]"
			[Register ("getPrepaidCardEMV", "()Landroid/os/IBinder;", "GetGetPrepaidCardEMVHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCard$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlPrepaidCardStubInvoker : AidlPrepaidCardStub {

		public AidlPrepaidCardStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCard$Stub", typeof (AidlPrepaidCardStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::Android.OS.IBinder PrepaidCardEMV {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='AidlPrepaidCard.Stub']/method[@name='getPrepaidCardEMV' and count(parameter)=0]"
			[Register ("getPrepaidCardEMV", "()Landroid/os/IBinder;", "GetGetPrepaidCardEMVHandler")]
			get {
				const string __id = "getPrepaidCardEMV.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCard']/method[@name='getPrepaidCardPinPad' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPrepaidCardPinPad", "(I)Landroid/os/IBinder;", "GetGetPrepaidCardPinPad_IHandler")]
		public override unsafe global::Android.OS.IBinder GetPrepaidCardPinPad (int p0)
		{
			const string __id = "getPrepaidCardPinPad.(I)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCard']"
	[Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCard", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardInvoker")]
	public partial interface IAidlPrepaidCard : global::Android.OS.IInterface {

		global::Android.OS.IBinder PrepaidCardEMV {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCard']/method[@name='getPrepaidCardEMV' and count(parameter)=0]"
			[Register ("getPrepaidCardEMV", "()Landroid/os/IBinder;", "GetGetPrepaidCardEMVHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardInvoker, ClassLibrary1")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/interface[@name='AidlPrepaidCard']/method[@name='getPrepaidCardPinPad' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPrepaidCardPinPad", "(I)Landroid/os/IBinder;", "GetGetPrepaidCardPinPad_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCardInvoker, ClassLibrary1")]
		global::Android.OS.IBinder GetPrepaidCardPinPad (int p0);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCard", DoNotGenerateAcw=true)]
	internal class IAidlPrepaidCardInvoker : global::Java.Lang.Object, IAidlPrepaidCard {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCard", typeof (IAidlPrepaidCardInvoker));

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

		public static IAidlPrepaidCard GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlPrepaidCard> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.prepaidcard.AidlPrepaidCard"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlPrepaidCardInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPrepaidCardEMV;
#pragma warning disable 0169
		static Delegate GetGetPrepaidCardEMVHandler ()
		{
			if (cb_getPrepaidCardEMV == null)
				cb_getPrepaidCardEMV = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrepaidCardEMV);
			return cb_getPrepaidCardEMV;
		}

		static IntPtr n_GetPrepaidCardEMV (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PrepaidCardEMV);
		}
#pragma warning restore 0169

		IntPtr id_getPrepaidCardEMV;
		public unsafe global::Android.OS.IBinder PrepaidCardEMV {
			get {
				if (id_getPrepaidCardEMV == IntPtr.Zero)
					id_getPrepaidCardEMV = JNIEnv.GetMethodID (class_ref, "getPrepaidCardEMV", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrepaidCardEMV), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPrepaidCardPinPad_I;
#pragma warning disable 0169
		static Delegate GetGetPrepaidCardPinPad_IHandler ()
		{
			if (cb_getPrepaidCardPinPad_I == null)
				cb_getPrepaidCardPinPad_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPrepaidCardPinPad_I);
			return cb_getPrepaidCardPinPad_I;
		}

		static IntPtr n_GetPrepaidCardPinPad_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPrepaidCardPinPad (p0));
		}
#pragma warning restore 0169

		IntPtr id_getPrepaidCardPinPad_I;
		public unsafe global::Android.OS.IBinder GetPrepaidCardPinPad (int p0)
		{
			if (id_getPrepaidCardPinPad_I == IntPtr.Zero)
				id_getPrepaidCardPinPad_I = JNIEnv.GetMethodID (class_ref, "getPrepaidCardPinPad", "(I)Landroid/os/IBinder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrepaidCardPinPad_I, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.IAidlPrepaidCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
