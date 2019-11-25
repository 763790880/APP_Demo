using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardTransLog", DoNotGenerateAcw=true)]
	public partial class PrepaidCardTransLog : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardTransLog", typeof (PrepaidCardTransLog));
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

		protected PrepaidCardTransLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/constructor[@name='PrepaidCardTransLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PrepaidCardTransLog ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/constructor[@name='PrepaidCardTransLog' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='int'] and parameter[9][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I[B)V", "")]
		public unsafe PrepaidCardTransLog (string transDate, string transTime, string amt, string otheramt, string countryCode, string moneyCode, string merchantName, int transtype, byte[] appTransCount)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_transDate = JNIEnv.NewString (transDate);
			IntPtr native_transTime = JNIEnv.NewString (transTime);
			IntPtr native_amt = JNIEnv.NewString (amt);
			IntPtr native_otheramt = JNIEnv.NewString (otheramt);
			IntPtr native_countryCode = JNIEnv.NewString (countryCode);
			IntPtr native_moneyCode = JNIEnv.NewString (moneyCode);
			IntPtr native_merchantName = JNIEnv.NewString (merchantName);
			IntPtr native_appTransCount = JNIEnv.NewArray (appTransCount);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_transDate);
				__args [1] = new JniArgumentValue (native_transTime);
				__args [2] = new JniArgumentValue (native_amt);
				__args [3] = new JniArgumentValue (native_otheramt);
				__args [4] = new JniArgumentValue (native_countryCode);
				__args [5] = new JniArgumentValue (native_moneyCode);
				__args [6] = new JniArgumentValue (native_merchantName);
				__args [7] = new JniArgumentValue (transtype);
				__args [8] = new JniArgumentValue (native_appTransCount);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_transDate);
				JNIEnv.DeleteLocalRef (native_transTime);
				JNIEnv.DeleteLocalRef (native_amt);
				JNIEnv.DeleteLocalRef (native_otheramt);
				JNIEnv.DeleteLocalRef (native_countryCode);
				JNIEnv.DeleteLocalRef (native_moneyCode);
				JNIEnv.DeleteLocalRef (native_merchantName);
				if (appTransCount != null) {
					JNIEnv.CopyArray (native_appTransCount, appTransCount);
					JNIEnv.DeleteLocalRef (native_appTransCount);
				}
			}
		}

		static Delegate cb_getAmt;
#pragma warning disable 0169
		static Delegate GetGetAmtHandler ()
		{
			if (cb_getAmt == null)
				cb_getAmt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAmt);
			return cb_getAmt;
		}

		static IntPtr n_GetAmt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Amt);
		}
#pragma warning restore 0169

		static Delegate cb_setAmt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAmt_Ljava_lang_String_Handler ()
		{
			if (cb_setAmt_Ljava_lang_String_ == null)
				cb_setAmt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAmt_Ljava_lang_String_);
			return cb_setAmt_Ljava_lang_String_;
		}

		static void n_SetAmt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_amt)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string amt = JNIEnv.GetString (native_amt, JniHandleOwnership.DoNotTransfer);
			__this.Amt = amt;
		}
#pragma warning restore 0169

		public virtual unsafe string Amt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='getAmt' and count(parameter)=0]"
			[Register ("getAmt", "()Ljava/lang/String;", "GetGetAmtHandler")]
			get {
				const string __id = "getAmt.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='setAmt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAmt", "(Ljava/lang/String;)V", "GetSetAmt_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAmt.(Ljava/lang/String;)V";
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

		static Delegate cb_getCountryCode;
#pragma warning disable 0169
		static Delegate GetGetCountryCodeHandler ()
		{
			if (cb_getCountryCode == null)
				cb_getCountryCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountryCode);
			return cb_getCountryCode;
		}

		static IntPtr n_GetCountryCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CountryCode);
		}
#pragma warning restore 0169

		static Delegate cb_setCountryCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCountryCode_Ljava_lang_String_Handler ()
		{
			if (cb_setCountryCode_Ljava_lang_String_ == null)
				cb_setCountryCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCountryCode_Ljava_lang_String_);
			return cb_setCountryCode_Ljava_lang_String_;
		}

		static void n_SetCountryCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_countryCode)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string countryCode = JNIEnv.GetString (native_countryCode, JniHandleOwnership.DoNotTransfer);
			__this.CountryCode = countryCode;
		}
#pragma warning restore 0169

		public virtual unsafe string CountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='getCountryCode' and count(parameter)=0]"
			[Register ("getCountryCode", "()Ljava/lang/String;", "GetGetCountryCodeHandler")]
			get {
				const string __id = "getCountryCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='setCountryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCountryCode", "(Ljava/lang/String;)V", "GetSetCountryCode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCountryCode.(Ljava/lang/String;)V";
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

		static Delegate cb_getMerchantName;
#pragma warning disable 0169
		static Delegate GetGetMerchantNameHandler ()
		{
			if (cb_getMerchantName == null)
				cb_getMerchantName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMerchantName);
			return cb_getMerchantName;
		}

		static IntPtr n_GetMerchantName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MerchantName);
		}
#pragma warning restore 0169

		static Delegate cb_setMerchantName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMerchantName_Ljava_lang_String_Handler ()
		{
			if (cb_setMerchantName_Ljava_lang_String_ == null)
				cb_setMerchantName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMerchantName_Ljava_lang_String_);
			return cb_setMerchantName_Ljava_lang_String_;
		}

		static void n_SetMerchantName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_merchantName)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string merchantName = JNIEnv.GetString (native_merchantName, JniHandleOwnership.DoNotTransfer);
			__this.MerchantName = merchantName;
		}
#pragma warning restore 0169

		public virtual unsafe string MerchantName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='getMerchantName' and count(parameter)=0]"
			[Register ("getMerchantName", "()Ljava/lang/String;", "GetGetMerchantNameHandler")]
			get {
				const string __id = "getMerchantName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='setMerchantName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMerchantName", "(Ljava/lang/String;)V", "GetSetMerchantName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMerchantName.(Ljava/lang/String;)V";
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

		static Delegate cb_getMoneyCode;
#pragma warning disable 0169
		static Delegate GetGetMoneyCodeHandler ()
		{
			if (cb_getMoneyCode == null)
				cb_getMoneyCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMoneyCode);
			return cb_getMoneyCode;
		}

		static IntPtr n_GetMoneyCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MoneyCode);
		}
#pragma warning restore 0169

		static Delegate cb_setMoneyCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMoneyCode_Ljava_lang_String_Handler ()
		{
			if (cb_setMoneyCode_Ljava_lang_String_ == null)
				cb_setMoneyCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMoneyCode_Ljava_lang_String_);
			return cb_setMoneyCode_Ljava_lang_String_;
		}

		static void n_SetMoneyCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_moneyCode)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string moneyCode = JNIEnv.GetString (native_moneyCode, JniHandleOwnership.DoNotTransfer);
			__this.MoneyCode = moneyCode;
		}
#pragma warning restore 0169

		public virtual unsafe string MoneyCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='getMoneyCode' and count(parameter)=0]"
			[Register ("getMoneyCode", "()Ljava/lang/String;", "GetGetMoneyCodeHandler")]
			get {
				const string __id = "getMoneyCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='setMoneyCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMoneyCode", "(Ljava/lang/String;)V", "GetSetMoneyCode_Ljava_lang_String_Handler")]
			set {
				const string __id = "setMoneyCode.(Ljava/lang/String;)V";
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

		static Delegate cb_getOtheramt;
#pragma warning disable 0169
		static Delegate GetGetOtheramtHandler ()
		{
			if (cb_getOtheramt == null)
				cb_getOtheramt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOtheramt);
			return cb_getOtheramt;
		}

		static IntPtr n_GetOtheramt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Otheramt);
		}
#pragma warning restore 0169

		static Delegate cb_setOtheramt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOtheramt_Ljava_lang_String_Handler ()
		{
			if (cb_setOtheramt_Ljava_lang_String_ == null)
				cb_setOtheramt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOtheramt_Ljava_lang_String_);
			return cb_setOtheramt_Ljava_lang_String_;
		}

		static void n_SetOtheramt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_otheramt)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string otheramt = JNIEnv.GetString (native_otheramt, JniHandleOwnership.DoNotTransfer);
			__this.Otheramt = otheramt;
		}
#pragma warning restore 0169

		public virtual unsafe string Otheramt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='getOtheramt' and count(parameter)=0]"
			[Register ("getOtheramt", "()Ljava/lang/String;", "GetGetOtheramtHandler")]
			get {
				const string __id = "getOtheramt.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='setOtheramt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOtheramt", "(Ljava/lang/String;)V", "GetSetOtheramt_Ljava_lang_String_Handler")]
			set {
				const string __id = "setOtheramt.(Ljava/lang/String;)V";
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

		static Delegate cb_getTransDate;
#pragma warning disable 0169
		static Delegate GetGetTransDateHandler ()
		{
			if (cb_getTransDate == null)
				cb_getTransDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransDate);
			return cb_getTransDate;
		}

		static IntPtr n_GetTransDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransDate);
		}
#pragma warning restore 0169

		static Delegate cb_setTransDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransDate_Ljava_lang_String_Handler ()
		{
			if (cb_setTransDate_Ljava_lang_String_ == null)
				cb_setTransDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransDate_Ljava_lang_String_);
			return cb_setTransDate_Ljava_lang_String_;
		}

		static void n_SetTransDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transDate)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string transDate = JNIEnv.GetString (native_transDate, JniHandleOwnership.DoNotTransfer);
			__this.TransDate = transDate;
		}
#pragma warning restore 0169

		public virtual unsafe string TransDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='getTransDate' and count(parameter)=0]"
			[Register ("getTransDate", "()Ljava/lang/String;", "GetGetTransDateHandler")]
			get {
				const string __id = "getTransDate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='setTransDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransDate", "(Ljava/lang/String;)V", "GetSetTransDate_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTransDate.(Ljava/lang/String;)V";
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

		static Delegate cb_getTransTime;
#pragma warning disable 0169
		static Delegate GetGetTransTimeHandler ()
		{
			if (cb_getTransTime == null)
				cb_getTransTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransTime);
			return cb_getTransTime;
		}

		static IntPtr n_GetTransTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransTime);
		}
#pragma warning restore 0169

		static Delegate cb_setTransTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransTime_Ljava_lang_String_Handler ()
		{
			if (cb_setTransTime_Ljava_lang_String_ == null)
				cb_setTransTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransTime_Ljava_lang_String_);
			return cb_setTransTime_Ljava_lang_String_;
		}

		static void n_SetTransTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transTime)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string transTime = JNIEnv.GetString (native_transTime, JniHandleOwnership.DoNotTransfer);
			__this.TransTime = transTime;
		}
#pragma warning restore 0169

		public virtual unsafe string TransTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='getTransTime' and count(parameter)=0]"
			[Register ("getTransTime", "()Ljava/lang/String;", "GetGetTransTimeHandler")]
			get {
				const string __id = "getTransTime.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='setTransTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransTime", "(Ljava/lang/String;)V", "GetSetTransTime_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTransTime.(Ljava/lang/String;)V";
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

		static Delegate cb_getTranstype;
#pragma warning disable 0169
		static Delegate GetGetTranstypeHandler ()
		{
			if (cb_getTranstype == null)
				cb_getTranstype = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTranstype);
			return cb_getTranstype;
		}

		static int n_GetTranstype (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Transtype;
		}
#pragma warning restore 0169

		static Delegate cb_setTranstype_I;
#pragma warning disable 0169
		static Delegate GetSetTranstype_IHandler ()
		{
			if (cb_setTranstype_I == null)
				cb_setTranstype_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTranstype_I);
			return cb_setTranstype_I;
		}

		static void n_SetTranstype_I (IntPtr jnienv, IntPtr native__this, int transtype)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Transtype = transtype;
		}
#pragma warning restore 0169

		public virtual unsafe int Transtype {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='getTranstype' and count(parameter)=0]"
			[Register ("getTranstype", "()I", "GetGetTranstypeHandler")]
			get {
				const string __id = "getTranstype.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='setTranstype' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTranstype", "(I)V", "GetSetTranstype_IHandler")]
			set {
				const string __id = "setTranstype.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getAppTransCount;
#pragma warning disable 0169
		static Delegate GetGetAppTransCountHandler ()
		{
			if (cb_getAppTransCount == null)
				cb_getAppTransCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppTransCount);
			return cb_getAppTransCount;
		}

		static IntPtr n_GetAppTransCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAppTransCount ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='getAppTransCount' and count(parameter)=0]"
		[Register ("getAppTransCount", "()[B", "GetGetAppTransCountHandler")]
		public virtual unsafe byte[] GetAppTransCount ()
		{
			const string __id = "getAppTransCount.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setAppTransCount_arrayB;
#pragma warning disable 0169
		static Delegate GetSetAppTransCount_arrayBHandler ()
		{
			if (cb_setAppTransCount_arrayB == null)
				cb_setAppTransCount_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppTransCount_arrayB);
			return cb_setAppTransCount_arrayB;
		}

		static void n_SetAppTransCount_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_appTransCount)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] appTransCount = (byte[]) JNIEnv.GetArray (native_appTransCount, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetAppTransCount (appTransCount);
			if (appTransCount != null)
				JNIEnv.CopyArray (appTransCount, native_appTransCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='setAppTransCount' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setAppTransCount", "([B)V", "GetSetAppTransCount_arrayBHandler")]
		public virtual unsafe void SetAppTransCount (byte[] appTransCount)
		{
			const string __id = "setAppTransCount.([B)V";
			IntPtr native_appTransCount = JNIEnv.NewArray (appTransCount);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_appTransCount);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (appTransCount != null) {
					JNIEnv.CopyArray (native_appTransCount, appTransCount);
					JNIEnv.DeleteLocalRef (native_appTransCount);
				}
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardTransLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardTransLog']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
