using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Printer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/printer/PrintItemObj", DoNotGenerateAcw=true)]
	public partial class PrintItemObj : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj.ALIGN']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN", DoNotGenerateAcw=true)]
		public sealed partial class ALIGN : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj.ALIGN']/field[@name='CENTER']"
			[Register ("CENTER")]
			public static global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN Center {
				get {
					const string __id = "CENTER.Lcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj.ALIGN']/field[@name='LEFT']"
			[Register ("LEFT")]
			public static global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN Left {
				get {
					const string __id = "LEFT.Lcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj.ALIGN']/field[@name='RIGHT']"
			[Register ("RIGHT")]
			public static global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN Right {
				get {
					const string __id = "RIGHT.Lcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN", typeof (ALIGN));
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

			internal ALIGN (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj.ALIGN']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;", "")]
			public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj.ALIGN']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;", "")]
			public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN[] Values ()
			{
				const string __id = "values.()[Lcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/printer/PrintItemObj", typeof (PrintItemObj));
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

		protected PrintItemObj (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/constructor[@name='PrintItemObj' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe PrintItemObj (global::Android.OS.Parcel source)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/constructor[@name='PrintItemObj' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe PrintItemObj (string text)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/constructor[@name='PrintItemObj' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe PrintItemObj (string text, int fontSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (fontSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/constructor[@name='PrintItemObj' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;IZ)V", "")]
		public unsafe PrintItemObj (string text, int fontSize, bool isBold)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;IZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (fontSize);
				__args [2] = new JniArgumentValue (isBold);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/constructor[@name='PrintItemObj' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='com.lkl.cloudpos.mdx.aidl.printer.PrintItemObj.ALIGN']]"
		[Register (".ctor", "(Ljava/lang/String;IZLcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;)V", "")]
		public unsafe PrintItemObj (string text, int fontSize, bool isBold, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN align)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;IZLcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (fontSize);
				__args [2] = new JniArgumentValue (isBold);
				__args [3] = new JniArgumentValue ((align == null) ? IntPtr.Zero : ((global::Java.Lang.Object) align).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/constructor[@name='PrintItemObj' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='com.lkl.cloudpos.mdx.aidl.printer.PrintItemObj.ALIGN'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;IZLcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;Z)V", "")]
		public unsafe PrintItemObj (string text, int fontSize, bool isBold, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN align, bool isUnderline)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;IZLcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (fontSize);
				__args [2] = new JniArgumentValue (isBold);
				__args [3] = new JniArgumentValue ((align == null) ? IntPtr.Zero : ((global::Java.Lang.Object) align).Handle);
				__args [4] = new JniArgumentValue (isUnderline);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/constructor[@name='PrintItemObj' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='com.lkl.cloudpos.mdx.aidl.printer.PrintItemObj.ALIGN'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;IZLcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;ZZ)V", "")]
		public unsafe PrintItemObj (string text, int fontSize, bool isBold, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN align, bool isUnderline, bool isWordWrap)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;IZLcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;ZZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (fontSize);
				__args [2] = new JniArgumentValue (isBold);
				__args [3] = new JniArgumentValue ((align == null) ? IntPtr.Zero : ((global::Java.Lang.Object) align).Handle);
				__args [4] = new JniArgumentValue (isUnderline);
				__args [5] = new JniArgumentValue (isWordWrap);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/constructor[@name='PrintItemObj' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='com.lkl.cloudpos.mdx.aidl.printer.PrintItemObj.ALIGN'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;IZLcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;ZZI)V", "")]
		public unsafe PrintItemObj (string text, int fontSize, bool isBold, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN align, bool isUnderline, bool isWordWrap, int lineHeight)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;IZLcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;ZZI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (fontSize);
				__args [2] = new JniArgumentValue (isBold);
				__args [3] = new JniArgumentValue ((align == null) ? IntPtr.Zero : ((global::Java.Lang.Object) align).Handle);
				__args [4] = new JniArgumentValue (isUnderline);
				__args [5] = new JniArgumentValue (isWordWrap);
				__args [6] = new JniArgumentValue (lineHeight);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/constructor[@name='PrintItemObj' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='com.lkl.cloudpos.mdx.aidl.printer.PrintItemObj.ALIGN'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;IZLcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;ZZII)V", "")]
		public unsafe PrintItemObj (string text, int fontSize, bool isBold, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN align, bool isUnderline, bool isWordWrap, int lineHeight, int letterSpacing)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;IZLcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;ZZII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (fontSize);
				__args [2] = new JniArgumentValue (isBold);
				__args [3] = new JniArgumentValue ((align == null) ? IntPtr.Zero : ((global::Java.Lang.Object) align).Handle);
				__args [4] = new JniArgumentValue (isUnderline);
				__args [5] = new JniArgumentValue (isWordWrap);
				__args [6] = new JniArgumentValue (lineHeight);
				__args [7] = new JniArgumentValue (letterSpacing);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/constructor[@name='PrintItemObj' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='com.lkl.cloudpos.mdx.aidl.printer.PrintItemObj.ALIGN'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;IZLcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;ZZIII)V", "")]
		public unsafe PrintItemObj (string text, int fontSize, bool isBold, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN align, bool isUnderline, bool isWordWrap, int lineHeight, int letterSpacing, int marginLeft)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;IZLcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;ZZIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_text);
				__args [1] = new JniArgumentValue (fontSize);
				__args [2] = new JniArgumentValue (isBold);
				__args [3] = new JniArgumentValue ((align == null) ? IntPtr.Zero : ((global::Java.Lang.Object) align).Handle);
				__args [4] = new JniArgumentValue (isUnderline);
				__args [5] = new JniArgumentValue (isWordWrap);
				__args [6] = new JniArgumentValue (lineHeight);
				__args [7] = new JniArgumentValue (letterSpacing);
				__args [8] = new JniArgumentValue (marginLeft);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_getAlign;
#pragma warning disable 0169
		static Delegate GetGetAlignHandler ()
		{
			if (cb_getAlign == null)
				cb_getAlign = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlign);
			return cb_getAlign;
		}

		static IntPtr n_GetAlign (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Align);
		}
#pragma warning restore 0169

		static Delegate cb_setAlign_Lcom_lkl_cloudpos_mdx_aidl_printer_PrintItemObj_ALIGN_;
#pragma warning disable 0169
		static Delegate GetSetAlign_Lcom_lkl_cloudpos_mdx_aidl_printer_PrintItemObj_ALIGN_Handler ()
		{
			if (cb_setAlign_Lcom_lkl_cloudpos_mdx_aidl_printer_PrintItemObj_ALIGN_ == null)
				cb_setAlign_Lcom_lkl_cloudpos_mdx_aidl_printer_PrintItemObj_ALIGN_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlign_Lcom_lkl_cloudpos_mdx_aidl_printer_PrintItemObj_ALIGN_);
			return cb_setAlign_Lcom_lkl_cloudpos_mdx_aidl_printer_PrintItemObj_ALIGN_;
		}

		static void n_SetAlign_Lcom_lkl_cloudpos_mdx_aidl_printer_PrintItemObj_ALIGN_ (IntPtr jnienv, IntPtr native__this, IntPtr native_align)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN align = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN> (native_align, JniHandleOwnership.DoNotTransfer);
			__this.Align = align;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN Align {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='getAlign' and count(parameter)=0]"
			[Register ("getAlign", "()Lcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;", "GetGetAlignHandler")]
			get {
				const string __id = "getAlign.()Lcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj.ALIGN> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='setAlign' and count(parameter)=1 and parameter[1][@type='com.lkl.cloudpos.mdx.aidl.printer.PrintItemObj.ALIGN']]"
			[Register ("setAlign", "(Lcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;)V", "GetSetAlign_Lcom_lkl_cloudpos_mdx_aidl_printer_PrintItemObj_ALIGN_Handler")]
			set {
				const string __id = "setAlign.(Lcom/lkl/cloudpos/mdx/aidl/printer/PrintItemObj$ALIGN;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBold;
#pragma warning disable 0169
		static Delegate GetGetBoldHandler ()
		{
			if (cb_getBold == null)
				cb_getBold = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetBold);
			return cb_getBold;
		}

		static bool n_GetBold (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bold;
		}
#pragma warning restore 0169

		static Delegate cb_setBold_Z;
#pragma warning disable 0169
		static Delegate GetSetBold_ZHandler ()
		{
			if (cb_setBold_Z == null)
				cb_setBold_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBold_Z);
			return cb_setBold_Z;
		}

		static void n_SetBold_Z (IntPtr jnienv, IntPtr native__this, bool isBold)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Bold = isBold;
		}
#pragma warning restore 0169

		public virtual unsafe bool Bold {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='getBold' and count(parameter)=0]"
			[Register ("getBold", "()Z", "GetGetBoldHandler")]
			get {
				const string __id = "getBold.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='setBold' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBold", "(Z)V", "GetSetBold_ZHandler")]
			set {
				const string __id = "setBold.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFontSize;
#pragma warning disable 0169
		static Delegate GetGetFontSizeHandler ()
		{
			if (cb_getFontSize == null)
				cb_getFontSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFontSize);
			return cb_getFontSize;
		}

		static int n_GetFontSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FontSize;
		}
#pragma warning restore 0169

		static Delegate cb_setFontSize_I;
#pragma warning disable 0169
		static Delegate GetSetFontSize_IHandler ()
		{
			if (cb_setFontSize_I == null)
				cb_setFontSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFontSize_I);
			return cb_setFontSize_I;
		}

		static void n_SetFontSize_I (IntPtr jnienv, IntPtr native__this, int fontSize)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FontSize = fontSize;
		}
#pragma warning restore 0169

		public virtual unsafe int FontSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='getFontSize' and count(parameter)=0]"
			[Register ("getFontSize", "()I", "GetGetFontSizeHandler")]
			get {
				const string __id = "getFontSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='setFontSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFontSize", "(I)V", "GetSetFontSize_IHandler")]
			set {
				const string __id = "setFontSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLetterSpacing;
#pragma warning disable 0169
		static Delegate GetGetLetterSpacingHandler ()
		{
			if (cb_getLetterSpacing == null)
				cb_getLetterSpacing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLetterSpacing);
			return cb_getLetterSpacing;
		}

		static int n_GetLetterSpacing (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LetterSpacing;
		}
#pragma warning restore 0169

		static Delegate cb_setLetterSpacing_I;
#pragma warning disable 0169
		static Delegate GetSetLetterSpacing_IHandler ()
		{
			if (cb_setLetterSpacing_I == null)
				cb_setLetterSpacing_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLetterSpacing_I);
			return cb_setLetterSpacing_I;
		}

		static void n_SetLetterSpacing_I (IntPtr jnienv, IntPtr native__this, int letterSpacing)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LetterSpacing = letterSpacing;
		}
#pragma warning restore 0169

		public virtual unsafe int LetterSpacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='getLetterSpacing' and count(parameter)=0]"
			[Register ("getLetterSpacing", "()I", "GetGetLetterSpacingHandler")]
			get {
				const string __id = "getLetterSpacing.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='setLetterSpacing' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLetterSpacing", "(I)V", "GetSetLetterSpacing_IHandler")]
			set {
				const string __id = "setLetterSpacing.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLineHeight;
#pragma warning disable 0169
		static Delegate GetGetLineHeightHandler ()
		{
			if (cb_getLineHeight == null)
				cb_getLineHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLineHeight);
			return cb_getLineHeight;
		}

		static int n_GetLineHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setLineHeight_I;
#pragma warning disable 0169
		static Delegate GetSetLineHeight_IHandler ()
		{
			if (cb_setLineHeight_I == null)
				cb_setLineHeight_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLineHeight_I);
			return cb_setLineHeight_I;
		}

		static void n_SetLineHeight_I (IntPtr jnienv, IntPtr native__this, int lineHeight)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LineHeight = lineHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int LineHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='getLineHeight' and count(parameter)=0]"
			[Register ("getLineHeight", "()I", "GetGetLineHeightHandler")]
			get {
				const string __id = "getLineHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='setLineHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLineHeight", "(I)V", "GetSetLineHeight_IHandler")]
			set {
				const string __id = "setLineHeight.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMarginLeft;
#pragma warning disable 0169
		static Delegate GetGetMarginLeftHandler ()
		{
			if (cb_getMarginLeft == null)
				cb_getMarginLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMarginLeft);
			return cb_getMarginLeft;
		}

		static int n_GetMarginLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MarginLeft;
		}
#pragma warning restore 0169

		static Delegate cb_setMarginLeft_I;
#pragma warning disable 0169
		static Delegate GetSetMarginLeft_IHandler ()
		{
			if (cb_setMarginLeft_I == null)
				cb_setMarginLeft_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMarginLeft_I);
			return cb_setMarginLeft_I;
		}

		static void n_SetMarginLeft_I (IntPtr jnienv, IntPtr native__this, int marginLeft)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarginLeft = marginLeft;
		}
#pragma warning restore 0169

		public virtual unsafe int MarginLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='getMarginLeft' and count(parameter)=0]"
			[Register ("getMarginLeft", "()I", "GetGetMarginLeftHandler")]
			get {
				const string __id = "getMarginLeft.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='setMarginLeft' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMarginLeft", "(I)V", "GetSetMarginLeft_IHandler")]
			set {
				const string __id = "setMarginLeft.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		static Delegate cb_setText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetText_Ljava_lang_String_Handler ()
		{
			if (cb_setText_Ljava_lang_String_ == null)
				cb_setText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_String_);
			return cb_setText_Ljava_lang_String_;
		}

		static void n_SetText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.Text = text;
		}
#pragma warning restore 0169

		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				const string __id = "getText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setText", "(Ljava/lang/String;)V", "GetSetText_Ljava_lang_String_Handler")]
			set {
				const string __id = "setText.(Ljava/lang/String;)V";
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

		static Delegate cb_getUnderline;
#pragma warning disable 0169
		static Delegate GetGetUnderlineHandler ()
		{
			if (cb_getUnderline == null)
				cb_getUnderline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetUnderline);
			return cb_getUnderline;
		}

		static bool n_GetUnderline (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Underline;
		}
#pragma warning restore 0169

		static Delegate cb_setUnderline_Z;
#pragma warning disable 0169
		static Delegate GetSetUnderline_ZHandler ()
		{
			if (cb_setUnderline_Z == null)
				cb_setUnderline_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUnderline_Z);
			return cb_setUnderline_Z;
		}

		static void n_SetUnderline_Z (IntPtr jnienv, IntPtr native__this, bool isUnderline)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Underline = isUnderline;
		}
#pragma warning restore 0169

		public virtual unsafe bool Underline {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='getUnderline' and count(parameter)=0]"
			[Register ("getUnderline", "()Z", "GetGetUnderlineHandler")]
			get {
				const string __id = "getUnderline.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='setUnderline' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUnderline", "(Z)V", "GetSetUnderline_ZHandler")]
			set {
				const string __id = "setUnderline.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWordWrap;
#pragma warning disable 0169
		static Delegate GetGetWordWrapHandler ()
		{
			if (cb_getWordWrap == null)
				cb_getWordWrap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWordWrap);
			return cb_getWordWrap;
		}

		static bool n_GetWordWrap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WordWrap;
		}
#pragma warning restore 0169

		static Delegate cb_setWordWrap_Z;
#pragma warning disable 0169
		static Delegate GetSetWordWrap_ZHandler ()
		{
			if (cb_setWordWrap_Z == null)
				cb_setWordWrap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetWordWrap_Z);
			return cb_setWordWrap_Z;
		}

		static void n_SetWordWrap_Z (IntPtr jnienv, IntPtr native__this, bool isWordWrap)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WordWrap = isWordWrap;
		}
#pragma warning restore 0169

		public virtual unsafe bool WordWrap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='getWordWrap' and count(parameter)=0]"
			[Register ("getWordWrap", "()Z", "GetGetWordWrapHandler")]
			get {
				const string __id = "getWordWrap.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='setWordWrap' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWordWrap", "(Z)V", "GetSetWordWrap_ZHandler")]
			set {
				const string __id = "setWordWrap.(Z)V";
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='PrintItemObj']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
