using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardInfo']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardInfo", DoNotGenerateAcw=true)]
	public partial class PrepaidCardInfo : global::Java.Lang.Object, global::Android.OS.IParcelable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardInfo", typeof (PrepaidCardInfo));
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

		protected PrepaidCardInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardInfo']/constructor[@name='PrepaidCardInfo' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe PrepaidCardInfo (global::Android.OS.Parcel source)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcel;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardInfo']/constructor[@name='PrepaidCardInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe PrepaidCardInfo (string cardno)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_cardno = JNIEnv.NewString (cardno);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cardno);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cardno);
			}
		}

		static Delegate cb_getCardno;
#pragma warning disable 0169
		static Delegate GetGetCardnoHandler ()
		{
			if (cb_getCardno == null)
				cb_getCardno = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardno);
			return cb_getCardno;
		}

		static IntPtr n_GetCardno (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Cardno);
		}
#pragma warning restore 0169

		static Delegate cb_setCardno_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCardno_Ljava_lang_String_Handler ()
		{
			if (cb_setCardno_Ljava_lang_String_ == null)
				cb_setCardno_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCardno_Ljava_lang_String_);
			return cb_setCardno_Ljava_lang_String_;
		}

		static void n_SetCardno_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cardno)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string cardno = JNIEnv.GetString (native_cardno, JniHandleOwnership.DoNotTransfer);
			__this.Cardno = cardno;
		}
#pragma warning restore 0169

		public virtual unsafe string Cardno {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardInfo']/method[@name='getCardno' and count(parameter)=0]"
			[Register ("getCardno", "()Ljava/lang/String;", "GetGetCardnoHandler")]
			get {
				const string __id = "getCardno.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardInfo']/method[@name='setCardno' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCardno", "(Ljava/lang/String;)V", "GetSetCardno_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCardno.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static unsafe global::Android.OS.IParcelableCreator Creator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardInfo']/method[@name='getCreator' and count(parameter)=0]"
			[Register ("getCreator", "()Landroid/os/Parcelable$Creator;", "GetGetCreatorHandler")]
			get {
				const string __id = "getCreator.()Landroid/os/Parcelable$Creator;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardInfo']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardInfo']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
