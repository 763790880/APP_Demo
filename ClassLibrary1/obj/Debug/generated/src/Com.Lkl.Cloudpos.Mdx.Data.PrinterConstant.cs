using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PrinterConstant", DoNotGenerateAcw=true)]
	public partial class PrinterConstant : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.BarCodeType']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PrinterConstant$BarCodeType", DoNotGenerateAcw=true)]
		public partial class BarCodeType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.BarCodeType']/field[@name='BARCODE_TYPE_CODE128']"
			[Register ("BARCODE_TYPE_CODE128")]
			public const int BarcodeTypeCode128 = (int) 73;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.BarCodeType']/field[@name='BARCODE_TYPE_CODE39']"
			[Register ("BARCODE_TYPE_CODE39")]
			public const int BarcodeTypeCode39 = (int) 69;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.BarCodeType']/field[@name='BARCODE_TYPE_CODE93']"
			[Register ("BARCODE_TYPE_CODE93")]
			public const int BarcodeTypeCode93 = (int) 72;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.BarCodeType']/field[@name='BARCODE_TYPE_CODEBAR']"
			[Register ("BARCODE_TYPE_CODEBAR")]
			public const int BarcodeTypeCodebar = (int) 71;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.BarCodeType']/field[@name='BARCODE_TYPE_ITF']"
			[Register ("BARCODE_TYPE_ITF")]
			public const int BarcodeTypeItf = (int) 70;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.BarCodeType']/field[@name='BARCODE_TYPE_JAN13']"
			[Register ("BARCODE_TYPE_JAN13")]
			public const int BarcodeTypeJan13 = (int) 67;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.BarCodeType']/field[@name='BARCODE_TYPE_JAN8']"
			[Register ("BARCODE_TYPE_JAN8")]
			public const int BarcodeTypeJan8 = (int) 68;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.BarCodeType']/field[@name='BARCODE_TYPE_UPCA']"
			[Register ("BARCODE_TYPE_UPCA")]
			public const int BarcodeTypeUpca = (int) 65;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.BarCodeType']/field[@name='BARCODE_TYPE_UPCE']"
			[Register ("BARCODE_TYPE_UPCE")]
			public const int BarcodeTypeUpce = (int) 66;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PrinterConstant$BarCodeType", typeof (BarCodeType));
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

			protected BarCodeType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.BarCodeType']/constructor[@name='PrinterConstant.BarCodeType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe BarCodeType ()
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.FontSize']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PrinterConstant$FontSize", DoNotGenerateAcw=true)]
		public partial class FontSize : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.FontSize']/field[@name='LARGE']"
			[Register ("LARGE")]
			public static int Large {
				get {
					const string __id = "LARGE.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "LARGE.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.FontSize']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static int Normal {
				get {
					const string __id = "NORMAL.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "NORMAL.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.FontSize']/field[@name='SMALL']"
			[Register ("SMALL")]
			public static int Small {
				get {
					const string __id = "SMALL.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "SMALL.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.FontSize']/field[@name='XLARGE']"
			[Register ("XLARGE")]
			public static int Xlarge {
				get {
					const string __id = "XLARGE.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "XLARGE.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PrinterConstant$FontSize", typeof (FontSize));
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

			protected FontSize (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.FontSize']/constructor[@name='PrinterConstant.FontSize' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe FontSize ()
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.PrinterState']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PrinterConstant$PrinterState", DoNotGenerateAcw=true)]
		public partial class PrinterState : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.PrinterState']/field[@name='PRINTER_STATE_DEV_ERROR']"
			[Register ("PRINTER_STATE_DEV_ERROR")]
			public static int PrinterStateDevError {
				get {
					const string __id = "PRINTER_STATE_DEV_ERROR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "PRINTER_STATE_DEV_ERROR.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.PrinterState']/field[@name='PRINTER_STATE_HIGHTEMP']"
			[Register ("PRINTER_STATE_HIGHTEMP")]
			public static int PrinterStateHightemp {
				get {
					const string __id = "PRINTER_STATE_HIGHTEMP.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "PRINTER_STATE_HIGHTEMP.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.PrinterState']/field[@name='PRINTER_STATE_NOPAPER']"
			[Register ("PRINTER_STATE_NOPAPER")]
			public static int PrinterStateNopaper {
				get {
					const string __id = "PRINTER_STATE_NOPAPER.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "PRINTER_STATE_NOPAPER.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.PrinterState']/field[@name='PRINTER_STATE_NORMAL']"
			[Register ("PRINTER_STATE_NORMAL")]
			public static int PrinterStateNormal {
				get {
					const string __id = "PRINTER_STATE_NORMAL.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "PRINTER_STATE_NORMAL.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.PrinterState']/field[@name='PRINTER_STATE_NOT_OPEN']"
			[Register ("PRINTER_STATE_NOT_OPEN")]
			public static int PrinterStateNotOpen {
				get {
					const string __id = "PRINTER_STATE_NOT_OPEN.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "PRINTER_STATE_NOT_OPEN.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.PrinterState']/field[@name='PRINTER_STATE_UNKNOWN']"
			[Register ("PRINTER_STATE_UNKNOWN")]
			public static int PrinterStateUnknown {
				get {
					const string __id = "PRINTER_STATE_UNKNOWN.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "PRINTER_STATE_UNKNOWN.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PrinterConstant$PrinterState", typeof (PrinterState));
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

			protected PrinterState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant.PrinterState']/constructor[@name='PrinterConstant.PrinterState' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe PrinterState ()
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

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PrinterConstant", typeof (PrinterConstant));
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

		protected PrinterConstant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrinterConstant']/constructor[@name='PrinterConstant' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PrinterConstant ()
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

	}
}
