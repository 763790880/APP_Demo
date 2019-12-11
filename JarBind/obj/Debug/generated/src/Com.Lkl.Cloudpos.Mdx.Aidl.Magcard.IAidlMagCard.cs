using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Magcard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='AidlMagCard.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/magcard/AidlMagCard$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlMagCardStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCard {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/magcard/AidlMagCard$Stub", typeof (AidlMagCardStub));
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

		protected AidlMagCardStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='AidlMagCard.Stub']/constructor[@name='AidlMagCard.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlMagCardStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.AidlMagCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.AidlMagCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='AidlMagCard.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='AidlMagCard.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/magcard/AidlMagCard;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCard AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/magcard/AidlMagCard;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCard> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.AidlMagCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.AidlMagCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='AidlMagCard.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_searchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_;
#pragma warning disable 0169
		static Delegate GetSearchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_Handler ()
		{
			if (cb_searchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_ == null)
				cb_searchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SearchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_);
			return cb_searchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_;
		}

		static void n_SearchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.AidlMagCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.AidlMagCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IMagCardListener p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IMagCardListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IMagCardListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SearchCard (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='AidlMagCard']/method[@name='searchCard' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.magcard.MagCardListener']]"
		[Register ("searchCard", "(ILcom/lkl/cloudpos/mdx/aidl/magcard/MagCardListener;)V", "GetSearchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_Handler")]
		public abstract void SearchCard (int p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IMagCardListener p1);

		static Delegate cb_searchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_;
#pragma warning disable 0169
		static Delegate GetSearchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_Handler ()
		{
			if (cb_searchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_ == null)
				cb_searchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, sbyte, sbyte, IntPtr, sbyte, IntPtr>) n_SearchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_);
			return cb_searchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_;
		}

		static void n_SearchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_ (IntPtr jnienv, IntPtr native__this, int p0, sbyte p1, sbyte p2, IntPtr native_p3, sbyte p4, IntPtr native_p5)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.AidlMagCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.AidlMagCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener p5 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.SearchEncryptCard (p0, p1, p2, p3, p4, p5);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='AidlMagCard']/method[@name='searchEncryptCard' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte'] and parameter[6][@type='com.lkl.cloudpos.mdx.aidl.magcard.EncryptMagCardListener']]"
		[Register ("searchEncryptCard", "(IBB[BBLcom/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener;)V", "GetSearchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_Handler")]
		public abstract void SearchEncryptCard (int p0, sbyte p1, sbyte p2, byte[] p3, sbyte p4, global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener p5);

		static Delegate cb_stopSearch;
#pragma warning disable 0169
		static Delegate GetStopSearchHandler ()
		{
			if (cb_stopSearch == null)
				cb_stopSearch = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopSearch);
			return cb_stopSearch;
		}

		static void n_StopSearch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.AidlMagCardStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.AidlMagCardStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopSearch ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='AidlMagCard']/method[@name='stopSearch' and count(parameter)=0]"
		[Register ("stopSearch", "()V", "GetStopSearchHandler")]
		public abstract void StopSearch ();

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/magcard/AidlMagCard$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlMagCardStubInvoker : AidlMagCardStub {

		public AidlMagCardStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/magcard/AidlMagCard$Stub", typeof (AidlMagCardStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='AidlMagCard']/method[@name='searchCard' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.magcard.MagCardListener']]"
		[Register ("searchCard", "(ILcom/lkl/cloudpos/mdx/aidl/magcard/MagCardListener;)V", "GetSearchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_Handler")]
		public override unsafe void SearchCard (int p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IMagCardListener p1)
		{
			const string __id = "searchCard.(ILcom/lkl/cloudpos/mdx/aidl/magcard/MagCardListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='AidlMagCard']/method[@name='searchEncryptCard' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte'] and parameter[6][@type='com.lkl.cloudpos.mdx.aidl.magcard.EncryptMagCardListener']]"
		[Register ("searchEncryptCard", "(IBB[BBLcom/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener;)V", "GetSearchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_Handler")]
		public override unsafe void SearchEncryptCard (int p0, sbyte p1, sbyte p2, byte[] p3, sbyte p4, global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener p5)
		{
			const string __id = "searchEncryptCard.(IBB[BBLcom/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener;)V";
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='AidlMagCard']/method[@name='stopSearch' and count(parameter)=0]"
		[Register ("stopSearch", "()V", "GetStopSearchHandler")]
		public override unsafe void StopSearch ()
		{
			const string __id = "stopSearch.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='AidlMagCard']"
	[Register ("com/lkl/cloudpos/mdx/aidl/magcard/AidlMagCard", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCardInvoker")]
	public partial interface IAidlMagCard : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='AidlMagCard']/method[@name='searchCard' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.magcard.MagCardListener']]"
		[Register ("searchCard", "(ILcom/lkl/cloudpos/mdx/aidl/magcard/MagCardListener;)V", "GetSearchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCardInvoker, JarBind")]
		void SearchCard (int p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IMagCardListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='AidlMagCard']/method[@name='searchEncryptCard' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='byte'] and parameter[3][@type='byte'] and parameter[4][@type='byte[]'] and parameter[5][@type='byte'] and parameter[6][@type='com.lkl.cloudpos.mdx.aidl.magcard.EncryptMagCardListener']]"
		[Register ("searchEncryptCard", "(IBB[BBLcom/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener;)V", "GetSearchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCardInvoker, JarBind")]
		void SearchEncryptCard (int p0, sbyte p1, sbyte p2, byte[] p3, sbyte p4, global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/interface[@name='AidlMagCard']/method[@name='stopSearch' and count(parameter)=0]"
		[Register ("stopSearch", "()V", "GetStopSearchHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCardInvoker, JarBind")]
		void StopSearch ();

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/magcard/AidlMagCard", DoNotGenerateAcw=true)]
	internal class IAidlMagCardInvoker : global::Java.Lang.Object, IAidlMagCard {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/magcard/AidlMagCard", typeof (IAidlMagCardInvoker));

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

		public static IAidlMagCard GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlMagCard> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.magcard.AidlMagCard"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlMagCardInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_searchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_;
#pragma warning disable 0169
		static Delegate GetSearchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_Handler ()
		{
			if (cb_searchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_ == null)
				cb_searchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SearchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_);
			return cb_searchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_;
		}

		static void n_SearchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IMagCardListener p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IMagCardListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IMagCardListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SearchCard (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_searchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_;
		public unsafe void SearchCard (int p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IMagCardListener p1)
		{
			if (id_searchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_ == IntPtr.Zero)
				id_searchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_ = JNIEnv.GetMethodID (class_ref, "searchCard", "(ILcom/lkl/cloudpos/mdx/aidl/magcard/MagCardListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_searchCard_ILcom_lkl_cloudpos_mdx_aidl_magcard_MagCardListener_, __args);
		}

		static Delegate cb_searchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_;
#pragma warning disable 0169
		static Delegate GetSearchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_Handler ()
		{
			if (cb_searchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_ == null)
				cb_searchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, sbyte, sbyte, IntPtr, sbyte, IntPtr>) n_SearchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_);
			return cb_searchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_;
		}

		static void n_SearchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_ (IntPtr jnienv, IntPtr native__this, int p0, sbyte p1, sbyte p2, IntPtr native_p3, sbyte p4, IntPtr native_p5)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener p5 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.SearchEncryptCard (p0, p1, p2, p3, p4, p5);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_searchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_;
		public unsafe void SearchEncryptCard (int p0, sbyte p1, sbyte p2, byte[] p3, sbyte p4, global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IEncryptMagCardListener p5)
		{
			if (id_searchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_ == IntPtr.Zero)
				id_searchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_ = JNIEnv.GetMethodID (class_ref, "searchEncryptCard", "(IBB[BBLcom/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener;)V");
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_searchEncryptCard_IBBarrayBBLcom_lkl_cloudpos_mdx_aidl_magcard_EncryptMagCardListener_, __args);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_stopSearch;
#pragma warning disable 0169
		static Delegate GetStopSearchHandler ()
		{
			if (cb_stopSearch == null)
				cb_stopSearch = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopSearch);
			return cb_stopSearch;
		}

		static void n_StopSearch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopSearch ();
		}
#pragma warning restore 0169

		IntPtr id_stopSearch;
		public unsafe void StopSearch ()
		{
			if (id_stopSearch == IntPtr.Zero)
				id_stopSearch = JNIEnv.GetMethodID (class_ref, "stopSearch", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopSearch);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCard __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.IAidlMagCard> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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