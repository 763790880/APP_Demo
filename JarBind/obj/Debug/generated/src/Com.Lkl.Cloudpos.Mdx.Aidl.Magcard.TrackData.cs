using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Magcard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/magcard/TrackData", DoNotGenerateAcw=true)]
	public partial class TrackData : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/magcard/TrackData", typeof (TrackData));
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

		protected TrackData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/constructor[@name='TrackData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TrackData ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/constructor[@name='TrackData' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe TrackData (global::Android.OS.Parcel des)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Parcel;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((des == null) ? IntPtr.Zero : ((global::Java.Lang.Object) des).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/constructor[@name='TrackData' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe TrackData (string cardno, string firstTrackData, string secondTrackData, string thirdTrackData, string formatTrackData, string expiryDate, string serviceCode)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_cardno = JNIEnv.NewString (cardno);
			IntPtr native_firstTrackData = JNIEnv.NewString (firstTrackData);
			IntPtr native_secondTrackData = JNIEnv.NewString (secondTrackData);
			IntPtr native_thirdTrackData = JNIEnv.NewString (thirdTrackData);
			IntPtr native_formatTrackData = JNIEnv.NewString (formatTrackData);
			IntPtr native_expiryDate = JNIEnv.NewString (expiryDate);
			IntPtr native_serviceCode = JNIEnv.NewString (serviceCode);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_cardno);
				__args [1] = new JniArgumentValue (native_firstTrackData);
				__args [2] = new JniArgumentValue (native_secondTrackData);
				__args [3] = new JniArgumentValue (native_thirdTrackData);
				__args [4] = new JniArgumentValue (native_formatTrackData);
				__args [5] = new JniArgumentValue (native_expiryDate);
				__args [6] = new JniArgumentValue (native_serviceCode);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cardno);
				JNIEnv.DeleteLocalRef (native_firstTrackData);
				JNIEnv.DeleteLocalRef (native_secondTrackData);
				JNIEnv.DeleteLocalRef (native_thirdTrackData);
				JNIEnv.DeleteLocalRef (native_formatTrackData);
				JNIEnv.DeleteLocalRef (native_expiryDate);
				JNIEnv.DeleteLocalRef (native_serviceCode);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string cardno = JNIEnv.GetString (native_cardno, JniHandleOwnership.DoNotTransfer);
			__this.Cardno = cardno;
		}
#pragma warning restore 0169

		public virtual unsafe string Cardno {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='getCardno' and count(parameter)=0]"
			[Register ("getCardno", "()Ljava/lang/String;", "GetGetCardnoHandler")]
			get {
				const string __id = "getCardno.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='setCardno' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getExpiryDate;
#pragma warning disable 0169
		static Delegate GetGetExpiryDateHandler ()
		{
			if (cb_getExpiryDate == null)
				cb_getExpiryDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpiryDate);
			return cb_getExpiryDate;
		}

		static IntPtr n_GetExpiryDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExpiryDate);
		}
#pragma warning restore 0169

		static Delegate cb_setExpiryDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExpiryDate_Ljava_lang_String_Handler ()
		{
			if (cb_setExpiryDate_Ljava_lang_String_ == null)
				cb_setExpiryDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpiryDate_Ljava_lang_String_);
			return cb_setExpiryDate_Ljava_lang_String_;
		}

		static void n_SetExpiryDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_expiryDate)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string expiryDate = JNIEnv.GetString (native_expiryDate, JniHandleOwnership.DoNotTransfer);
			__this.ExpiryDate = expiryDate;
		}
#pragma warning restore 0169

		public virtual unsafe string ExpiryDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='getExpiryDate' and count(parameter)=0]"
			[Register ("getExpiryDate", "()Ljava/lang/String;", "GetGetExpiryDateHandler")]
			get {
				const string __id = "getExpiryDate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='setExpiryDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExpiryDate", "(Ljava/lang/String;)V", "GetSetExpiryDate_Ljava_lang_String_Handler")]
			set {
				const string __id = "setExpiryDate.(Ljava/lang/String;)V";
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

		static Delegate cb_getFirstTrackData;
#pragma warning disable 0169
		static Delegate GetGetFirstTrackDataHandler ()
		{
			if (cb_getFirstTrackData == null)
				cb_getFirstTrackData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstTrackData);
			return cb_getFirstTrackData;
		}

		static IntPtr n_GetFirstTrackData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirstTrackData);
		}
#pragma warning restore 0169

		static Delegate cb_setFirstTrackData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFirstTrackData_Ljava_lang_String_Handler ()
		{
			if (cb_setFirstTrackData_Ljava_lang_String_ == null)
				cb_setFirstTrackData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFirstTrackData_Ljava_lang_String_);
			return cb_setFirstTrackData_Ljava_lang_String_;
		}

		static void n_SetFirstTrackData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_firstTrackData)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string firstTrackData = JNIEnv.GetString (native_firstTrackData, JniHandleOwnership.DoNotTransfer);
			__this.FirstTrackData = firstTrackData;
		}
#pragma warning restore 0169

		public virtual unsafe string FirstTrackData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='getFirstTrackData' and count(parameter)=0]"
			[Register ("getFirstTrackData", "()Ljava/lang/String;", "GetGetFirstTrackDataHandler")]
			get {
				const string __id = "getFirstTrackData.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='setFirstTrackData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFirstTrackData", "(Ljava/lang/String;)V", "GetSetFirstTrackData_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFirstTrackData.(Ljava/lang/String;)V";
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

		static Delegate cb_getFormatTrackData;
#pragma warning disable 0169
		static Delegate GetGetFormatTrackDataHandler ()
		{
			if (cb_getFormatTrackData == null)
				cb_getFormatTrackData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormatTrackData);
			return cb_getFormatTrackData;
		}

		static IntPtr n_GetFormatTrackData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FormatTrackData);
		}
#pragma warning restore 0169

		static Delegate cb_setFormatTrackData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFormatTrackData_Ljava_lang_String_Handler ()
		{
			if (cb_setFormatTrackData_Ljava_lang_String_ == null)
				cb_setFormatTrackData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFormatTrackData_Ljava_lang_String_);
			return cb_setFormatTrackData_Ljava_lang_String_;
		}

		static void n_SetFormatTrackData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_formatTrackData)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string formatTrackData = JNIEnv.GetString (native_formatTrackData, JniHandleOwnership.DoNotTransfer);
			__this.FormatTrackData = formatTrackData;
		}
#pragma warning restore 0169

		public virtual unsafe string FormatTrackData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='getFormatTrackData' and count(parameter)=0]"
			[Register ("getFormatTrackData", "()Ljava/lang/String;", "GetGetFormatTrackDataHandler")]
			get {
				const string __id = "getFormatTrackData.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='setFormatTrackData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFormatTrackData", "(Ljava/lang/String;)V", "GetSetFormatTrackData_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFormatTrackData.(Ljava/lang/String;)V";
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

		static Delegate cb_getSecondTrackData;
#pragma warning disable 0169
		static Delegate GetGetSecondTrackDataHandler ()
		{
			if (cb_getSecondTrackData == null)
				cb_getSecondTrackData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecondTrackData);
			return cb_getSecondTrackData;
		}

		static IntPtr n_GetSecondTrackData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecondTrackData);
		}
#pragma warning restore 0169

		static Delegate cb_setSecondTrackData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecondTrackData_Ljava_lang_String_Handler ()
		{
			if (cb_setSecondTrackData_Ljava_lang_String_ == null)
				cb_setSecondTrackData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecondTrackData_Ljava_lang_String_);
			return cb_setSecondTrackData_Ljava_lang_String_;
		}

		static void n_SetSecondTrackData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_secondTrackData)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string secondTrackData = JNIEnv.GetString (native_secondTrackData, JniHandleOwnership.DoNotTransfer);
			__this.SecondTrackData = secondTrackData;
		}
#pragma warning restore 0169

		public virtual unsafe string SecondTrackData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='getSecondTrackData' and count(parameter)=0]"
			[Register ("getSecondTrackData", "()Ljava/lang/String;", "GetGetSecondTrackDataHandler")]
			get {
				const string __id = "getSecondTrackData.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='setSecondTrackData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecondTrackData", "(Ljava/lang/String;)V", "GetSetSecondTrackData_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSecondTrackData.(Ljava/lang/String;)V";
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

		static Delegate cb_getServiceCode;
#pragma warning disable 0169
		static Delegate GetGetServiceCodeHandler ()
		{
			if (cb_getServiceCode == null)
				cb_getServiceCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServiceCode);
			return cb_getServiceCode;
		}

		static IntPtr n_GetServiceCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceCode);
		}
#pragma warning restore 0169

		static Delegate cb_setServiceCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServiceCode_Ljava_lang_String_Handler ()
		{
			if (cb_setServiceCode_Ljava_lang_String_ == null)
				cb_setServiceCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetServiceCode_Ljava_lang_String_);
			return cb_setServiceCode_Ljava_lang_String_;
		}

		static void n_SetServiceCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serviceCode)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string serviceCode = JNIEnv.GetString (native_serviceCode, JniHandleOwnership.DoNotTransfer);
			__this.ServiceCode = serviceCode;
		}
#pragma warning restore 0169

		public virtual unsafe string ServiceCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='getServiceCode' and count(parameter)=0]"
			[Register ("getServiceCode", "()Ljava/lang/String;", "GetGetServiceCodeHandler")]
			get {
				const string __id = "getServiceCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='setServiceCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServiceCode", "(Ljava/lang/String;)V", "GetSetServiceCode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setServiceCode.(Ljava/lang/String;)V";
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

		static Delegate cb_getThirdTrackData;
#pragma warning disable 0169
		static Delegate GetGetThirdTrackDataHandler ()
		{
			if (cb_getThirdTrackData == null)
				cb_getThirdTrackData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThirdTrackData);
			return cb_getThirdTrackData;
		}

		static IntPtr n_GetThirdTrackData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThirdTrackData);
		}
#pragma warning restore 0169

		static Delegate cb_setThirdTrackData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetThirdTrackData_Ljava_lang_String_Handler ()
		{
			if (cb_setThirdTrackData_Ljava_lang_String_ == null)
				cb_setThirdTrackData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetThirdTrackData_Ljava_lang_String_);
			return cb_setThirdTrackData_Ljava_lang_String_;
		}

		static void n_SetThirdTrackData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_thirdTrackData)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string thirdTrackData = JNIEnv.GetString (native_thirdTrackData, JniHandleOwnership.DoNotTransfer);
			__this.ThirdTrackData = thirdTrackData;
		}
#pragma warning restore 0169

		public virtual unsafe string ThirdTrackData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='getThirdTrackData' and count(parameter)=0]"
			[Register ("getThirdTrackData", "()Ljava/lang/String;", "GetGetThirdTrackDataHandler")]
			get {
				const string __id = "getThirdTrackData.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='setThirdTrackData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setThirdTrackData", "(Ljava/lang/String;)V", "GetSetThirdTrackData_Ljava_lang_String_Handler")]
			set {
				const string __id = "setThirdTrackData.(Ljava/lang/String;)V";
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.TrackData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.magcard']/class[@name='TrackData']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
