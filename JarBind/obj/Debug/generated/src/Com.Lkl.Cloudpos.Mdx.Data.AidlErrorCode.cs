using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/AidlErrorCode", DoNotGenerateAcw=true)]
	public partial class AidlErrorCode : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Camera']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/AidlErrorCode$Camera", DoNotGenerateAcw=true)]
		public partial class Camera : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Camera']/field[@name='SCANCODE_HARDWARE_ERROR']"
			[Register ("SCANCODE_HARDWARE_ERROR")]
			public const int ScancodeHardwareError = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Camera']/field[@name='SCANCODE_UNKNOWN_CODE']"
			[Register ("SCANCODE_UNKNOWN_CODE")]
			public const int ScancodeUnknownCode = (int) 2;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/AidlErrorCode$Camera", typeof (Camera));
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

			protected Camera (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Camera']/constructor[@name='AidlErrorCode.Camera' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Camera ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.CPUCard']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/AidlErrorCode$CPUCard", DoNotGenerateAcw=true)]
		public partial class CPUCard : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.CPUCard']/field[@name='CARD_NOT_SUPPORTED']"
			[Register ("CARD_NOT_SUPPORTED")]
			public const int CardNotSupported = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.CPUCard']/field[@name='OPEN_FAILED']"
			[Register ("OPEN_FAILED")]
			public const int OpenFailed = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.CPUCard']/field[@name='OPEN_SUCCEED']"
			[Register ("OPEN_SUCCEED")]
			public const int OpenSucceed = (int) 0;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/AidlErrorCode$CPUCard", typeof (CPUCard));
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

			protected CPUCard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.CPUCard']/constructor[@name='AidlErrorCode.CPUCard' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CPUCard ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/AidlErrorCode$EMV", DoNotGenerateAcw=true)]
		public partial class EMV : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']/field[@name='EMV_AID_NULL']"
			[Register ("EMV_AID_NULL")]
			public static int EmvAidNull {
				get {
					const string __id = "EMV_AID_NULL.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "EMV_AID_NULL.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']/field[@name='EMV_ILLIGAL_PARAMETER_ERROR']"
			[Register ("EMV_ILLIGAL_PARAMETER_ERROR")]
			public static int EmvIlligalParameterError {
				get {
					const string __id = "EMV_ILLIGAL_PARAMETER_ERROR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "EMV_ILLIGAL_PARAMETER_ERROR.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']/field[@name='EMV_KERNEL_COMMUNICATE_ERROR']"
			[Register ("EMV_KERNEL_COMMUNICATE_ERROR")]
			public static int EmvKernelCommunicateError {
				get {
					const string __id = "EMV_KERNEL_COMMUNICATE_ERROR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "EMV_KERNEL_COMMUNICATE_ERROR.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']/field[@name='EMV_KERNEL_EXCUTE_ERROR']"
			[Register ("EMV_KERNEL_EXCUTE_ERROR")]
			public static int EmvKernelExcuteError {
				get {
					const string __id = "EMV_KERNEL_EXCUTE_ERROR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "EMV_KERNEL_EXCUTE_ERROR.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']/field[@name='EMV_KERNEL_UNKNOWN_EVENTID_ERROR']"
			[Register ("EMV_KERNEL_UNKNOWN_EVENTID_ERROR")]
			public static int EmvKernelUnknownEventidError {
				get {
					const string __id = "EMV_KERNEL_UNKNOWN_EVENTID_ERROR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "EMV_KERNEL_UNKNOWN_EVENTID_ERROR.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']/field[@name='EMV_PUBLICKEY_AID_NULL']"
			[Register ("EMV_PUBLICKEY_AID_NULL")]
			public static int EmvPublickeyAidNull {
				get {
					const string __id = "EMV_PUBLICKEY_AID_NULL.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "EMV_PUBLICKEY_AID_NULL.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']/field[@name='EMV_PUBLICKEY_NULL']"
			[Register ("EMV_PUBLICKEY_NULL")]
			public static int EmvPublickeyNull {
				get {
					const string __id = "EMV_PUBLICKEY_NULL.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "EMV_PUBLICKEY_NULL.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']/field[@name='EMV_READ_KERNEL_DATA_FAIL']"
			[Register ("EMV_READ_KERNEL_DATA_FAIL")]
			public static int EmvReadKernelDataFail {
				get {
					const string __id = "EMV_READ_KERNEL_DATA_FAIL.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "EMV_READ_KERNEL_DATA_FAIL.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']/field[@name='ERROR_CHECK_ICCARD_ERROR']"
			[Register ("ERROR_CHECK_ICCARD_ERROR")]
			public static int ErrorCheckIccardError {
				get {
					const string __id = "ERROR_CHECK_ICCARD_ERROR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_CHECK_ICCARD_ERROR.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']/field[@name='ERROR_CHECK_MAGCARD_ERROR']"
			[Register ("ERROR_CHECK_MAGCARD_ERROR")]
			public static int ErrorCheckMagcardError {
				get {
					const string __id = "ERROR_CHECK_MAGCARD_ERROR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_CHECK_MAGCARD_ERROR.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']/field[@name='ERROR_CHECK_RFCARD_ERROR']"
			[Register ("ERROR_CHECK_RFCARD_ERROR")]
			public static int ErrorCheckRfcardError {
				get {
					const string __id = "ERROR_CHECK_RFCARD_ERROR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_CHECK_RFCARD_ERROR.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/AidlErrorCode$EMV", typeof (EMV));
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

			protected EMV (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.EMV']/constructor[@name='AidlErrorCode.EMV' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe EMV ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.MagCard']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/AidlErrorCode$MagCard", DoNotGenerateAcw=true)]
		public partial class MagCard : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.MagCard']/field[@name='DEVICE_IS_BUSY']"
			[Register ("DEVICE_IS_BUSY")]
			public const int DeviceIsBusy = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.MagCard']/field[@name='OTHER_ERROR']"
			[Register ("OTHER_ERROR")]
			public const int OtherError = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.MagCard']/field[@name='TRACK_DATA_ERR']"
			[Register ("TRACK_DATA_ERR")]
			public const int TrackDataErr = (int) 1;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/AidlErrorCode$MagCard", typeof (MagCard));
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

			protected MagCard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.MagCard']/constructor[@name='AidlErrorCode.MagCard' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MagCard ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.MerchantMsg']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/AidlErrorCode$MerchantMsg", DoNotGenerateAcw=true)]
		public partial class MerchantMsg : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.MerchantMsg']/field[@name='ERROR_AUTHAPP']"
			[Register ("ERROR_AUTHAPP")]
			public static int ErrorAuthapp {
				get {
					const string __id = "ERROR_AUTHAPP.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_AUTHAPP.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.MerchantMsg']/field[@name='ERROR_AUTHBINDFAIL']"
			[Register ("ERROR_AUTHBINDFAIL")]
			public static int ErrorAuthbindfail {
				get {
					const string __id = "ERROR_AUTHBINDFAIL.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_AUTHBINDFAIL.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.MerchantMsg']/field[@name='ERROR_MSGFAIL']"
			[Register ("ERROR_MSGFAIL")]
			public static int ErrorMsgfail {
				get {
					const string __id = "ERROR_MSGFAIL.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_MSGFAIL.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.MerchantMsg']/field[@name='ERROR_PARAMETER']"
			[Register ("ERROR_PARAMETER")]
			public static int ErrorParameter {
				get {
					const string __id = "ERROR_PARAMETER.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_PARAMETER.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/AidlErrorCode$MerchantMsg", typeof (MerchantMsg));
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

			protected MerchantMsg (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.MerchantMsg']/constructor[@name='AidlErrorCode.MerchantMsg' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MerchantMsg ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Pinpad']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/AidlErrorCode$Pinpad", DoNotGenerateAcw=true)]
		public partial class Pinpad : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Pinpad']/field[@name='ERROR_ENCRYPT']"
			[Register ("ERROR_ENCRYPT")]
			public static int ErrorEncrypt {
				get {
					const string __id = "ERROR_ENCRYPT.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_ENCRYPT.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Pinpad']/field[@name='ERROR_INPUTTIMES']"
			[Register ("ERROR_INPUTTIMES")]
			public static int ErrorInputtimes {
				get {
					const string __id = "ERROR_INPUTTIMES.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_INPUTTIMES.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Pinpad']/field[@name='ERROR_KEYTYPE']"
			[Register ("ERROR_KEYTYPE")]
			public static int ErrorKeytype {
				get {
					const string __id = "ERROR_KEYTYPE.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_KEYTYPE.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Pinpad']/field[@name='ERROR_MAC']"
			[Register ("ERROR_MAC")]
			public static int ErrorMac {
				get {
					const string __id = "ERROR_MAC.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_MAC.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Pinpad']/field[@name='ERROR_NODEV']"
			[Register ("ERROR_NODEV")]
			public static int ErrorNodev {
				get {
					const string __id = "ERROR_NODEV.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_NODEV.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Pinpad']/field[@name='ERROR_TIMEOUT']"
			[Register ("ERROR_TIMEOUT")]
			public static int ErrorTimeout {
				get {
					const string __id = "ERROR_TIMEOUT.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_TIMEOUT.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Pinpad']/field[@name='ERROR_UNKNOWN']"
			[Register ("ERROR_UNKNOWN")]
			public static int ErrorUnknown {
				get {
					const string __id = "ERROR_UNKNOWN.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_UNKNOWN.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/AidlErrorCode$Pinpad", typeof (Pinpad));
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

			protected Pinpad (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Pinpad']/constructor[@name='AidlErrorCode.Pinpad' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Pinpad ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.PREPAIDCARD']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/AidlErrorCode$PREPAIDCARD", DoNotGenerateAcw=true)]
		public partial class PREPAIDCARD : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.PREPAIDCARD']/field[@name='PREPAID_CARD_NOT_SUPPORT']"
			[Register ("PREPAID_CARD_NOT_SUPPORT")]
			public static int PrepaidCardNotSupport {
				get {
					const string __id = "PREPAID_CARD_NOT_SUPPORT.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "PREPAID_CARD_NOT_SUPPORT.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/AidlErrorCode$PREPAIDCARD", typeof (PREPAIDCARD));
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

			protected PREPAIDCARD (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.PREPAIDCARD']/constructor[@name='AidlErrorCode.PREPAIDCARD' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe PREPAIDCARD ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/AidlErrorCode$Printer", DoNotGenerateAcw=true)]
		public partial class Printer : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']/field[@name='ERROR_DEV_IS_BUSY']"
			[Register ("ERROR_DEV_IS_BUSY")]
			public static int ErrorDevIsBusy {
				get {
					const string __id = "ERROR_DEV_IS_BUSY.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_DEV_IS_BUSY.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']/field[@name='ERROR_DEV_NOT_OPEN']"
			[Register ("ERROR_DEV_NOT_OPEN")]
			public static int ErrorDevNotOpen {
				get {
					const string __id = "ERROR_DEV_NOT_OPEN.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_DEV_NOT_OPEN.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']/field[@name='ERROR_PRINT_BARCODE_OTHER']"
			[Register ("ERROR_PRINT_BARCODE_OTHER")]
			public static int ErrorPrintBarcodeOther {
				get {
					const string __id = "ERROR_PRINT_BARCODE_OTHER.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_PRINT_BARCODE_OTHER.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']/field[@name='ERROR_PRINT_BITMAP_OTHER']"
			[Register ("ERROR_PRINT_BITMAP_OTHER")]
			public static int ErrorPrintBitmapOther {
				get {
					const string __id = "ERROR_PRINT_BITMAP_OTHER.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_PRINT_BITMAP_OTHER.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']/field[@name='ERROR_PRINT_BITMAP_WIDTH_OVERFLOW']"
			[Register ("ERROR_PRINT_BITMAP_WIDTH_OVERFLOW")]
			public static int ErrorPrintBitmapWidthOverflow {
				get {
					const string __id = "ERROR_PRINT_BITMAP_WIDTH_OVERFLOW.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_PRINT_BITMAP_WIDTH_OVERFLOW.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']/field[@name='ERROR_PRINT_DATA_MAC']"
			[Register ("ERROR_PRINT_DATA_MAC")]
			public static int ErrorPrintDataMac {
				get {
					const string __id = "ERROR_PRINT_DATA_MAC.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_PRINT_DATA_MAC.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']/field[@name='ERROR_PRINT_HOT']"
			[Register ("ERROR_PRINT_HOT")]
			public static int ErrorPrintHot {
				get {
					const string __id = "ERROR_PRINT_HOT.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_PRINT_HOT.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']/field[@name='ERROR_PRINT_ILLIGALARGUMENT']"
			[Register ("ERROR_PRINT_ILLIGALARGUMENT")]
			public static int ErrorPrintIlligalargument {
				get {
					const string __id = "ERROR_PRINT_ILLIGALARGUMENT.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_PRINT_ILLIGALARGUMENT.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']/field[@name='ERROR_PRINT_NOPAPER']"
			[Register ("ERROR_PRINT_NOPAPER")]
			public static int ErrorPrintNopaper {
				get {
					const string __id = "ERROR_PRINT_NOPAPER.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_PRINT_NOPAPER.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']/field[@name='ERROR_PRINT_TEXT_OTHER']"
			[Register ("ERROR_PRINT_TEXT_OTHER")]
			public static int ErrorPrintTextOther {
				get {
					const string __id = "ERROR_PRINT_TEXT_OTHER.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_PRINT_TEXT_OTHER.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']/field[@name='ERROR_PRINT_UNKNOWN']"
			[Register ("ERROR_PRINT_UNKNOWN")]
			public static int ErrorPrintUnknown {
				get {
					const string __id = "ERROR_PRINT_UNKNOWN.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_PRINT_UNKNOWN.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/AidlErrorCode$Printer", typeof (Printer));
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

			protected Printer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.Printer']/constructor[@name='AidlErrorCode.Printer' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Printer ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/AidlErrorCode$RFCard", DoNotGenerateAcw=true)]
		public partial class RFCard : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_ADD_FAIL']"
			[Register ("ERROR_ADD_FAIL")]
			public const int ErrorAddFail = (int) -9;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_AUTH_FAIL']"
			[Register ("ERROR_AUTH_FAIL")]
			public const int ErrorAuthFail = (int) -5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_DELIVERY_FAIL']"
			[Register ("ERROR_DELIVERY_FAIL")]
			public const int ErrorDeliveryFail = (int) -11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_IS_BUSY']"
			[Register ("ERROR_IS_BUSY")]
			public const int ErrorIsBusy = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_KEY_LENTH']"
			[Register ("ERROR_KEY_LENTH")]
			public const int ErrorKeyLenth = (int) -2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_KEY_TYPE']"
			[Register ("ERROR_KEY_TYPE")]
			public const int ErrorKeyType = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_NOT_OPEN']"
			[Register ("ERROR_NOT_OPEN")]
			public const int ErrorNotOpen = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_READ_FAIL']"
			[Register ("ERROR_READ_FAIL")]
			public const int ErrorReadFail = (int) -6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_REDUCE_FAIL']"
			[Register ("ERROR_REDUCE_FAIL")]
			public const int ErrorReduceFail = (int) -10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_RESET_DATA']"
			[Register ("ERROR_RESET_DATA")]
			public const int ErrorResetData = (int) -3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_SELECT_FAIL']"
			[Register ("ERROR_SELECT_FAIL")]
			public const int ErrorSelectFail = (int) -8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_UNKNOWN']"
			[Register ("ERROR_UNKNOWN")]
			public const int ErrorUnknown = (int) -4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/field[@name='ERROR_WRITE_FAIL']"
			[Register ("ERROR_WRITE_FAIL")]
			public const int ErrorWriteFail = (int) -7;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/AidlErrorCode$RFCard", typeof (RFCard));
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

			protected RFCard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.RFCard']/constructor[@name='AidlErrorCode.RFCard' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe RFCard ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.SerialPort']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/AidlErrorCode$SerialPort", DoNotGenerateAcw=true)]
		public partial class SerialPort : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.SerialPort']/field[@name='DEVICE_IS_BUSY']"
			[Register ("DEVICE_IS_BUSY")]
			public static int DeviceIsBusy {
				get {
					const string __id = "DEVICE_IS_BUSY.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "DEVICE_IS_BUSY.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.SerialPort']/field[@name='DEVICE_NOT_OPEN']"
			[Register ("DEVICE_NOT_OPEN")]
			public static int DeviceNotOpen {
				get {
					const string __id = "DEVICE_NOT_OPEN.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "DEVICE_NOT_OPEN.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.SerialPort']/field[@name='ERROR_NODEV']"
			[Register ("ERROR_NODEV")]
			public static int ErrorNodev {
				get {
					const string __id = "ERROR_NODEV.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "ERROR_NODEV.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.SerialPort']/field[@name='READ_ERROR']"
			[Register ("READ_ERROR")]
			public static int ReadError {
				get {
					const string __id = "READ_ERROR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "READ_ERROR.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/AidlErrorCode$SerialPort", typeof (SerialPort));
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

			protected SerialPort (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.SerialPort']/constructor[@name='AidlErrorCode.SerialPort' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SerialPort ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/AidlErrorCode$System", DoNotGenerateAcw=true)]
		public partial class System : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_ALREADY_EXISTS']"
			[Register ("INSTALL_FAILED_ALREADY_EXISTS")]
			public const int InstallFailedAlreadyExists = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_CONFLICTING_PROVIDER']"
			[Register ("INSTALL_FAILED_CONFLICTING_PROVIDER")]
			public const int InstallFailedConflictingProvider = (int) -13;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_CONTAINER_ERROR']"
			[Register ("INSTALL_FAILED_CONTAINER_ERROR")]
			public const int InstallFailedContainerError = (int) -18;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_CPU_ABI_INCOMPATIBLE']"
			[Register ("INSTALL_FAILED_CPU_ABI_INCOMPATIBLE")]
			public const int InstallFailedCpuAbiIncompatible = (int) -16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_DEXOPT']"
			[Register ("INSTALL_FAILED_DEXOPT")]
			public const int InstallFailedDexopt = (int) -11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_DUPLICATE_PACKAGE']"
			[Register ("INSTALL_FAILED_DUPLICATE_PACKAGE")]
			public const int InstallFailedDuplicatePackage = (int) -5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_INSUFFICIENT_STORAGE']"
			[Register ("INSTALL_FAILED_INSUFFICIENT_STORAGE")]
			public const int InstallFailedInsufficientStorage = (int) -4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_INTERNAL_ERROR']"
			[Register ("INSTALL_FAILED_INTERNAL_ERROR")]
			public const int InstallFailedInternalError = (int) -110;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_INVALID_APK']"
			[Register ("INSTALL_FAILED_INVALID_APK")]
			public const int InstallFailedInvalidApk = (int) -2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_INVALID_INSTALL_LOCATION']"
			[Register ("INSTALL_FAILED_INVALID_INSTALL_LOCATION")]
			public const int InstallFailedInvalidInstallLocation = (int) -19;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_INVALID_URI']"
			[Register ("INSTALL_FAILED_INVALID_URI")]
			public const int InstallFailedInvalidUri = (int) -3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_MEDIA_UNAVAILABLE']"
			[Register ("INSTALL_FAILED_MEDIA_UNAVAILABLE")]
			public const int InstallFailedMediaUnavailable = (int) -20;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_MISSING_FEATURE']"
			[Register ("INSTALL_FAILED_MISSING_FEATURE")]
			public const int InstallFailedMissingFeature = (int) -17;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_MISSING_SHARED_LIBRARY']"
			[Register ("INSTALL_FAILED_MISSING_SHARED_LIBRARY")]
			public const int InstallFailedMissingSharedLibrary = (int) -9;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_NEWER_SDK']"
			[Register ("INSTALL_FAILED_NEWER_SDK")]
			public const int InstallFailedNewerSdk = (int) -14;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_NO_SHARED_USER']"
			[Register ("INSTALL_FAILED_NO_SHARED_USER")]
			public const int InstallFailedNoSharedUser = (int) -6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_OLDER_SDK']"
			[Register ("INSTALL_FAILED_OLDER_SDK")]
			public const int InstallFailedOlderSdk = (int) -12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_PACKAGE_CHANGED']"
			[Register ("INSTALL_FAILED_PACKAGE_CHANGED")]
			public const int InstallFailedPackageChanged = (int) -23;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_REPLACE_COULDNT_DELETE']"
			[Register ("INSTALL_FAILED_REPLACE_COULDNT_DELETE")]
			public const int InstallFailedReplaceCouldntDelete = (int) -10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_SHARED_USER_INCOMPATIBLE']"
			[Register ("INSTALL_FAILED_SHARED_USER_INCOMPATIBLE")]
			public const int InstallFailedSharedUserIncompatible = (int) -8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_TEST_ONLY']"
			[Register ("INSTALL_FAILED_TEST_ONLY")]
			public const int InstallFailedTestOnly = (int) -15;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_UID_CHANGED']"
			[Register ("INSTALL_FAILED_UID_CHANGED")]
			public const int InstallFailedUidChanged = (int) -24;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_UPDATE_INCOMPATIBLE']"
			[Register ("INSTALL_FAILED_UPDATE_INCOMPATIBLE")]
			public const int InstallFailedUpdateIncompatible = (int) -7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_VERIFICATION_FAILURE']"
			[Register ("INSTALL_FAILED_VERIFICATION_FAILURE")]
			public const int InstallFailedVerificationFailure = (int) -22;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_VERIFICATION_TIMEOUT']"
			[Register ("INSTALL_FAILED_VERIFICATION_TIMEOUT")]
			public const int InstallFailedVerificationTimeout = (int) -21;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_FAILED_VERSION_DOWNGRADE']"
			[Register ("INSTALL_FAILED_VERSION_DOWNGRADE")]
			public const int InstallFailedVersionDowngrade = (int) -25;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_PARSE_FAILED_BAD_MANIFEST']"
			[Register ("INSTALL_PARSE_FAILED_BAD_MANIFEST")]
			public const int InstallParseFailedBadManifest = (int) -101;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_PARSE_FAILED_BAD_PACKAGE_NAME']"
			[Register ("INSTALL_PARSE_FAILED_BAD_PACKAGE_NAME")]
			public const int InstallParseFailedBadPackageName = (int) -106;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_PARSE_FAILED_BAD_SHARED_USER_ID']"
			[Register ("INSTALL_PARSE_FAILED_BAD_SHARED_USER_ID")]
			public const int InstallParseFailedBadSharedUserId = (int) -107;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_PARSE_FAILED_CERTIFICATE_ENCODING']"
			[Register ("INSTALL_PARSE_FAILED_CERTIFICATE_ENCODING")]
			public const int InstallParseFailedCertificateEncoding = (int) -105;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_PARSE_FAILED_INCONSISTENT_CERTIFICATES']"
			[Register ("INSTALL_PARSE_FAILED_INCONSISTENT_CERTIFICATES")]
			public const int InstallParseFailedInconsistentCertificates = (int) -104;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_PARSE_FAILED_MANIFEST_EMPTY']"
			[Register ("INSTALL_PARSE_FAILED_MANIFEST_EMPTY")]
			public const int InstallParseFailedManifestEmpty = (int) -109;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_PARSE_FAILED_MANIFEST_MALFORMED']"
			[Register ("INSTALL_PARSE_FAILED_MANIFEST_MALFORMED")]
			public const int InstallParseFailedManifestMalformed = (int) -108;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_PARSE_FAILED_NOT_APK']"
			[Register ("INSTALL_PARSE_FAILED_NOT_APK")]
			public const int InstallParseFailedNotApk = (int) -100;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_PARSE_FAILED_NO_CERTIFICATES']"
			[Register ("INSTALL_PARSE_FAILED_NO_CERTIFICATES")]
			public const int InstallParseFailedNoCertificates = (int) -103;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_PARSE_FAILED_UNEXPECTED_EXCEPTION']"
			[Register ("INSTALL_PARSE_FAILED_UNEXPECTED_EXCEPTION")]
			public const int InstallParseFailedUnexpectedException = (int) -102;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/field[@name='INSTALL_SUCCESS']"
			[Register ("INSTALL_SUCCESS")]
			public const int InstallSuccess = (int) 0;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/AidlErrorCode$System", typeof (System));
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

			protected System (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode.System']/constructor[@name='AidlErrorCode.System' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe System ()
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/AidlErrorCode", typeof (AidlErrorCode));
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

		protected AidlErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='AidlErrorCode']/constructor[@name='AidlErrorCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlErrorCode ()
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
