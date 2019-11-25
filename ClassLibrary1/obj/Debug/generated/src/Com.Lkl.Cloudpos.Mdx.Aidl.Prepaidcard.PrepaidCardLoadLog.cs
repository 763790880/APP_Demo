using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardLoadLog", DoNotGenerateAcw=true)]
	public partial class PrepaidCardLoadLog : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardLoadLog", typeof (PrepaidCardLoadLog));
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

		protected PrepaidCardLoadLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/constructor[@name='PrepaidCardLoadLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PrepaidCardLoadLog ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/constructor[@name='PrepaidCardLoadLog' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V", "")]
		public unsafe PrepaidCardLoadLog (string putdata_p1, string putdata_p2, string before_putdata, string after_putdata, string transDate, string transTime, byte[] appTransCount)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_putdata_p1 = JNIEnv.NewString (putdata_p1);
			IntPtr native_putdata_p2 = JNIEnv.NewString (putdata_p2);
			IntPtr native_before_putdata = JNIEnv.NewString (before_putdata);
			IntPtr native_after_putdata = JNIEnv.NewString (after_putdata);
			IntPtr native_transDate = JNIEnv.NewString (transDate);
			IntPtr native_transTime = JNIEnv.NewString (transTime);
			IntPtr native_appTransCount = JNIEnv.NewArray (appTransCount);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_putdata_p1);
				__args [1] = new JniArgumentValue (native_putdata_p2);
				__args [2] = new JniArgumentValue (native_before_putdata);
				__args [3] = new JniArgumentValue (native_after_putdata);
				__args [4] = new JniArgumentValue (native_transDate);
				__args [5] = new JniArgumentValue (native_transTime);
				__args [6] = new JniArgumentValue (native_appTransCount);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_putdata_p1);
				JNIEnv.DeleteLocalRef (native_putdata_p2);
				JNIEnv.DeleteLocalRef (native_before_putdata);
				JNIEnv.DeleteLocalRef (native_after_putdata);
				JNIEnv.DeleteLocalRef (native_transDate);
				JNIEnv.DeleteLocalRef (native_transTime);
				if (appTransCount != null) {
					JNIEnv.CopyArray (native_appTransCount, appTransCount);
					JNIEnv.DeleteLocalRef (native_appTransCount);
				}
			}
		}

		static Delegate cb_getAfter_putdata;
#pragma warning disable 0169
		static Delegate GetGetAfter_putdataHandler ()
		{
			if (cb_getAfter_putdata == null)
				cb_getAfter_putdata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAfter_putdata);
			return cb_getAfter_putdata;
		}

		static IntPtr n_GetAfter_putdata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.After_putdata);
		}
#pragma warning restore 0169

		static Delegate cb_setAfter_putdata_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAfter_putdata_Ljava_lang_String_Handler ()
		{
			if (cb_setAfter_putdata_Ljava_lang_String_ == null)
				cb_setAfter_putdata_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAfter_putdata_Ljava_lang_String_);
			return cb_setAfter_putdata_Ljava_lang_String_;
		}

		static void n_SetAfter_putdata_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_after_putdata)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string after_putdata = JNIEnv.GetString (native_after_putdata, JniHandleOwnership.DoNotTransfer);
			__this.After_putdata = after_putdata;
		}
#pragma warning restore 0169

		public virtual unsafe string After_putdata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='getAfter_putdata' and count(parameter)=0]"
			[Register ("getAfter_putdata", "()Ljava/lang/String;", "GetGetAfter_putdataHandler")]
			get {
				const string __id = "getAfter_putdata.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='setAfter_putdata' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAfter_putdata", "(Ljava/lang/String;)V", "GetSetAfter_putdata_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAfter_putdata.(Ljava/lang/String;)V";
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

		static Delegate cb_getBefore_putdata;
#pragma warning disable 0169
		static Delegate GetGetBefore_putdataHandler ()
		{
			if (cb_getBefore_putdata == null)
				cb_getBefore_putdata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBefore_putdata);
			return cb_getBefore_putdata;
		}

		static IntPtr n_GetBefore_putdata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Before_putdata);
		}
#pragma warning restore 0169

		static Delegate cb_setBefore_putdata_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBefore_putdata_Ljava_lang_String_Handler ()
		{
			if (cb_setBefore_putdata_Ljava_lang_String_ == null)
				cb_setBefore_putdata_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBefore_putdata_Ljava_lang_String_);
			return cb_setBefore_putdata_Ljava_lang_String_;
		}

		static void n_SetBefore_putdata_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_before_putdata)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string before_putdata = JNIEnv.GetString (native_before_putdata, JniHandleOwnership.DoNotTransfer);
			__this.Before_putdata = before_putdata;
		}
#pragma warning restore 0169

		public virtual unsafe string Before_putdata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='getBefore_putdata' and count(parameter)=0]"
			[Register ("getBefore_putdata", "()Ljava/lang/String;", "GetGetBefore_putdataHandler")]
			get {
				const string __id = "getBefore_putdata.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='setBefore_putdata' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBefore_putdata", "(Ljava/lang/String;)V", "GetSetBefore_putdata_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBefore_putdata.(Ljava/lang/String;)V";
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

		static Delegate cb_getPutdata_p1;
#pragma warning disable 0169
		static Delegate GetGetPutdata_p1Handler ()
		{
			if (cb_getPutdata_p1 == null)
				cb_getPutdata_p1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPutdata_p1);
			return cb_getPutdata_p1;
		}

		static IntPtr n_GetPutdata_p1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Putdata_p1);
		}
#pragma warning restore 0169

		static Delegate cb_setPutdata_p1_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPutdata_p1_Ljava_lang_String_Handler ()
		{
			if (cb_setPutdata_p1_Ljava_lang_String_ == null)
				cb_setPutdata_p1_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPutdata_p1_Ljava_lang_String_);
			return cb_setPutdata_p1_Ljava_lang_String_;
		}

		static void n_SetPutdata_p1_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_putdata_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string putdata_p1 = JNIEnv.GetString (native_putdata_p1, JniHandleOwnership.DoNotTransfer);
			__this.Putdata_p1 = putdata_p1;
		}
#pragma warning restore 0169

		public virtual unsafe string Putdata_p1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='getPutdata_p1' and count(parameter)=0]"
			[Register ("getPutdata_p1", "()Ljava/lang/String;", "GetGetPutdata_p1Handler")]
			get {
				const string __id = "getPutdata_p1.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='setPutdata_p1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPutdata_p1", "(Ljava/lang/String;)V", "GetSetPutdata_p1_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPutdata_p1.(Ljava/lang/String;)V";
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

		static Delegate cb_getPutdata_p2;
#pragma warning disable 0169
		static Delegate GetGetPutdata_p2Handler ()
		{
			if (cb_getPutdata_p2 == null)
				cb_getPutdata_p2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPutdata_p2);
			return cb_getPutdata_p2;
		}

		static IntPtr n_GetPutdata_p2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Putdata_p2);
		}
#pragma warning restore 0169

		static Delegate cb_setPutdata_p2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPutdata_p2_Ljava_lang_String_Handler ()
		{
			if (cb_setPutdata_p2_Ljava_lang_String_ == null)
				cb_setPutdata_p2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPutdata_p2_Ljava_lang_String_);
			return cb_setPutdata_p2_Ljava_lang_String_;
		}

		static void n_SetPutdata_p2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_putdata_p2)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string putdata_p2 = JNIEnv.GetString (native_putdata_p2, JniHandleOwnership.DoNotTransfer);
			__this.Putdata_p2 = putdata_p2;
		}
#pragma warning restore 0169

		public virtual unsafe string Putdata_p2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='getPutdata_p2' and count(parameter)=0]"
			[Register ("getPutdata_p2", "()Ljava/lang/String;", "GetGetPutdata_p2Handler")]
			get {
				const string __id = "getPutdata_p2.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='setPutdata_p2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPutdata_p2", "(Ljava/lang/String;)V", "GetSetPutdata_p2_Ljava_lang_String_Handler")]
			set {
				const string __id = "setPutdata_p2.(Ljava/lang/String;)V";
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string transDate = JNIEnv.GetString (native_transDate, JniHandleOwnership.DoNotTransfer);
			__this.TransDate = transDate;
		}
#pragma warning restore 0169

		public virtual unsafe string TransDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='getTransDate' and count(parameter)=0]"
			[Register ("getTransDate", "()Ljava/lang/String;", "GetGetTransDateHandler")]
			get {
				const string __id = "getTransDate.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='setTransDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string transTime = JNIEnv.GetString (native_transTime, JniHandleOwnership.DoNotTransfer);
			__this.TransTime = transTime;
		}
#pragma warning restore 0169

		public virtual unsafe string TransTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='getTransTime' and count(parameter)=0]"
			[Register ("getTransTime", "()Ljava/lang/String;", "GetGetTransTimeHandler")]
			get {
				const string __id = "getTransTime.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='setTransTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAppTransCount ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='getAppTransCount' and count(parameter)=0]"
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] appTransCount = (byte[]) JNIEnv.GetArray (native_appTransCount, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetAppTransCount (appTransCount);
			if (appTransCount != null)
				JNIEnv.CopyArray (appTransCount, native_appTransCount);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='setAppTransCount' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardLoadLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardLoadLog']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
