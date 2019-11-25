using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Printer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='AidlPrinter.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/printer/AidlPrinter$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlPrinterStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/printer/AidlPrinter$Stub", typeof (AidlPrinterStub));
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

		protected AidlPrinterStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='AidlPrinter.Stub']/constructor[@name='AidlPrinter.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlPrinterStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='AidlPrinter.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='AidlPrinter.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinter;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='AidlPrinter.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_printBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
#pragma warning disable 0169
		static Delegate GetPrintBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler ()
		{
			if (cb_printBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ == null)
				cb_printBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, IntPtr, IntPtr>) n_PrintBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_);
			return cb_printBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
		}

		static void n_PrintBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p5 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.PrintBarCode (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='printBarCode' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.lkl.cloudpos.mdx.aidl.printer.AidlPrinterListener']]"
		[Register ("printBarCode", "(IIIILjava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V", "GetPrintBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler")]
		public abstract void PrintBarCode (int p0, int p1, int p2, int p3, string p4, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p5);

		static Delegate cb_printBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
#pragma warning disable 0169
		static Delegate GetPrintBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler ()
		{
			if (cb_printBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ == null)
				cb_printBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, IntPtr, IntPtr>) n_PrintBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_);
			return cb_printBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
		}

		static void n_PrintBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p3 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p4 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.PrintBmp (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='printBmp' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.graphics.Bitmap'] and parameter[5][@type='com.lkl.cloudpos.mdx.aidl.printer.AidlPrinterListener']]"
		[Register ("printBmp", "(IIILandroid/graphics/Bitmap;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V", "GetPrintBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler")]
		public abstract void PrintBmp (int p0, int p1, int p2, global::Android.Graphics.Bitmap p3, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p4);

		static Delegate cb_printText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
#pragma warning disable 0169
		static Delegate GetPrintText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler ()
		{
			if (cb_printText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ == null)
				cb_printText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PrintText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_);
			return cb_printText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
		}

		static void n_PrintText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintText (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='printText' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.lkl.cloudpos.mdx.aidl.printer.PrintItemObj&gt;'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.printer.AidlPrinterListener']]"
		[Register ("printText", "(Ljava/util/List;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V", "GetPrintText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler")]
		public abstract void PrintText (global::System.Collections.Generic.IList<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p1);

		static Delegate cb_setPrinterGray_I;
#pragma warning disable 0169
		static Delegate GetSetPrinterGray_IHandler ()
		{
			if (cb_setPrinterGray_I == null)
				cb_setPrinterGray_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPrinterGray_I);
			return cb_setPrinterGray_I;
		}

		static void n_SetPrinterGray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPrinterGray (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='setPrinterGray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPrinterGray", "(I)V", "GetSetPrinterGray_IHandler")]
		public abstract void SetPrinterGray (int p0);

		static Delegate cb_getPrinterState;
#pragma warning disable 0169
		static Delegate GetGetPrinterStateHandler ()
		{
			if (cb_getPrinterState == null)
				cb_getPrinterState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPrinterState);
			return cb_getPrinterState;
		}

		static int n_GetPrinterState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrinterState;
		}
#pragma warning restore 0169

		public abstract int PrinterState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='AidlPrinter.Stub']/method[@name='getPrinterState' and count(parameter)=0]"
			[Register ("getPrinterState", "()I", "GetGetPrinterStateHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/printer/AidlPrinter$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlPrinterStubInvoker : AidlPrinterStub {

		public AidlPrinterStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/printer/AidlPrinter$Stub", typeof (AidlPrinterStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int PrinterState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/class[@name='AidlPrinter.Stub']/method[@name='getPrinterState' and count(parameter)=0]"
			[Register ("getPrinterState", "()I", "GetGetPrinterStateHandler")]
			get {
				const string __id = "getPrinterState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='printBarCode' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.lkl.cloudpos.mdx.aidl.printer.AidlPrinterListener']]"
		[Register ("printBarCode", "(IIIILjava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V", "GetPrintBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler")]
		public override unsafe void PrintBarCode (int p0, int p1, int p2, int p3, string p4, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p5)
		{
			const string __id = "printBarCode.(IIIILjava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V";
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='printBmp' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.graphics.Bitmap'] and parameter[5][@type='com.lkl.cloudpos.mdx.aidl.printer.AidlPrinterListener']]"
		[Register ("printBmp", "(IIILandroid/graphics/Bitmap;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V", "GetPrintBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler")]
		public override unsafe void PrintBmp (int p0, int p1, int p2, global::Android.Graphics.Bitmap p3, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p4)
		{
			const string __id = "printBmp.(IIILandroid/graphics/Bitmap;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='printText' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.lkl.cloudpos.mdx.aidl.printer.PrintItemObj&gt;'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.printer.AidlPrinterListener']]"
		[Register ("printText", "(Ljava/util/List;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V", "GetPrintText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler")]
		public override unsafe void PrintText (global::System.Collections.Generic.IList<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p1)
		{
			const string __id = "printText.(Ljava/util/List;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='setPrinterGray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPrinterGray", "(I)V", "GetSetPrinterGray_IHandler")]
		public override unsafe void SetPrinterGray (int p0)
		{
			const string __id = "setPrinterGray.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']"
	[Register ("com/lkl/cloudpos/mdx/aidl/printer/AidlPrinter", "", "Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterInvoker")]
	public partial interface IAidlPrinter : global::Android.OS.IInterface {

		int PrinterState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='getPrinterState' and count(parameter)=0]"
			[Register ("getPrinterState", "()I", "GetGetPrinterStateHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterInvoker, ClassLibrary1")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='printBarCode' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='com.lkl.cloudpos.mdx.aidl.printer.AidlPrinterListener']]"
		[Register ("printBarCode", "(IIIILjava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V", "GetPrintBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterInvoker, ClassLibrary1")]
		void PrintBarCode (int p0, int p1, int p2, int p3, string p4, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='printBmp' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.graphics.Bitmap'] and parameter[5][@type='com.lkl.cloudpos.mdx.aidl.printer.AidlPrinterListener']]"
		[Register ("printBmp", "(IIILandroid/graphics/Bitmap;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V", "GetPrintBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterInvoker, ClassLibrary1")]
		void PrintBmp (int p0, int p1, int p2, global::Android.Graphics.Bitmap p3, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='printText' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.lkl.cloudpos.mdx.aidl.printer.PrintItemObj&gt;'] and parameter[2][@type='com.lkl.cloudpos.mdx.aidl.printer.AidlPrinterListener']]"
		[Register ("printText", "(Ljava/util/List;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V", "GetPrintText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler:Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterInvoker, ClassLibrary1")]
		void PrintText (global::System.Collections.Generic.IList<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.printer']/interface[@name='AidlPrinter']/method[@name='setPrinterGray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPrinterGray", "(I)V", "GetSetPrinterGray_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterInvoker, ClassLibrary1")]
		void SetPrinterGray (int p0);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/printer/AidlPrinter", DoNotGenerateAcw=true)]
	internal class IAidlPrinterInvoker : global::Java.Lang.Object, IAidlPrinter {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/printer/AidlPrinter", typeof (IAidlPrinterInvoker));

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

		public static IAidlPrinter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlPrinter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.printer.AidlPrinter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlPrinterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPrinterState;
#pragma warning disable 0169
		static Delegate GetGetPrinterStateHandler ()
		{
			if (cb_getPrinterState == null)
				cb_getPrinterState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPrinterState);
			return cb_getPrinterState;
		}

		static int n_GetPrinterState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrinterState;
		}
#pragma warning restore 0169

		IntPtr id_getPrinterState;
		public unsafe int PrinterState {
			get {
				if (id_getPrinterState == IntPtr.Zero)
					id_getPrinterState = JNIEnv.GetMethodID (class_ref, "getPrinterState", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPrinterState);
			}
		}

		static Delegate cb_printBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
#pragma warning disable 0169
		static Delegate GetPrintBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler ()
		{
			if (cb_printBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ == null)
				cb_printBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, IntPtr, IntPtr>) n_PrintBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_);
			return cb_printBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
		}

		static void n_PrintBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p5 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.PrintBarCode (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_printBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
		public unsafe void PrintBarCode (int p0, int p1, int p2, int p3, string p4, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p5)
		{
			if (id_printBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ == IntPtr.Zero)
				id_printBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ = JNIEnv.GetMethodID (class_ref, "printBarCode", "(IIIILjava/lang/String;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V");
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printBarCode_IIIILjava_lang_String_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_, __args);
			JNIEnv.DeleteLocalRef (native_p4);
		}

		static Delegate cb_printBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
#pragma warning disable 0169
		static Delegate GetPrintBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler ()
		{
			if (cb_printBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ == null)
				cb_printBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, IntPtr, IntPtr>) n_PrintBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_);
			return cb_printBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
		}

		static void n_PrintBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p3 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p4 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.PrintBmp (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_printBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
		public unsafe void PrintBmp (int p0, int p1, int p2, global::Android.Graphics.Bitmap p3, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p4)
		{
			if (id_printBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ == IntPtr.Zero)
				id_printBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ = JNIEnv.GetMethodID (class_ref, "printBmp", "(IIILandroid/graphics/Bitmap;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printBmp_IIILandroid_graphics_Bitmap_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_, __args);
		}

		static Delegate cb_printText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
#pragma warning disable 0169
		static Delegate GetPrintText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_Handler ()
		{
			if (cb_printText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ == null)
				cb_printText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PrintText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_);
			return cb_printText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
		}

		static void n_PrintText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p1 = (global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener)global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.PrintText (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_printText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_;
		public unsafe void PrintText (global::System.Collections.Generic.IList<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj> p0, global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinterListener p1)
		{
			if (id_printText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ == IntPtr.Zero)
				id_printText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_ = JNIEnv.GetMethodID (class_ref, "printText", "(Ljava/util/List;Lcom/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.PrintItemObj>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_printText_Ljava_util_List_Lcom_lkl_cloudpos_mdx_aidl_printer_AidlPrinterListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setPrinterGray_I;
#pragma warning disable 0169
		static Delegate GetSetPrinterGray_IHandler ()
		{
			if (cb_setPrinterGray_I == null)
				cb_setPrinterGray_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPrinterGray_I);
			return cb_setPrinterGray_I;
		}

		static void n_SetPrinterGray_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPrinterGray (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPrinterGray_I;
		public unsafe void SetPrinterGray (int p0)
		{
			if (id_setPrinterGray_I == IntPtr.Zero)
				id_setPrinterGray_I = JNIEnv.GetMethodID (class_ref, "setPrinterGray", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrinterGray_I, __args);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Printer.IAidlPrinter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
