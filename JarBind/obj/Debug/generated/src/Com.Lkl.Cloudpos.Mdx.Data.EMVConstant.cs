using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/EMVConstant", DoNotGenerateAcw=true)]
	public partial class EMVConstant : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.AccountType']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/EMVConstant$AccountType", DoNotGenerateAcw=true)]
		public partial class AccountType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.AccountType']/field[@name='ACCOUNT_TYPE_CHEQUEORDEBIT']"
			[Register ("ACCOUNT_TYPE_CHEQUEORDEBIT")]
			public const int AccountTypeChequeordebit = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.AccountType']/field[@name='ACCOUNT_TYPE_CREDIT']"
			[Register ("ACCOUNT_TYPE_CREDIT")]
			public const int AccountTypeCredit = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.AccountType']/field[@name='ACCOUNT_TYPE_DEFAULT']"
			[Register ("ACCOUNT_TYPE_DEFAULT")]
			public const int AccountTypeDefault = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.AccountType']/field[@name='ACCOUNT_TYPE_SAVING']"
			[Register ("ACCOUNT_TYPE_SAVING")]
			public const int AccountTypeSaving = (int) 2;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/EMVConstant$AccountType", typeof (AccountType));
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

			protected AccountType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.AccountType']/constructor[@name='EMVConstant.AccountType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AccountType ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.AidCapkOptFlag']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/EMVConstant$AidCapkOptFlag", DoNotGenerateAcw=true)]
		public partial class AidCapkOptFlag : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.AidCapkOptFlag']/field[@name='AID_CAPK_OPT_ADDORUPDATE_FLAG']"
			[Register ("AID_CAPK_OPT_ADDORUPDATE_FLAG")]
			public const int AidCapkOptAddorupdateFlag = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.AidCapkOptFlag']/field[@name='AID_CAPK_OPT_REMOVEALL_FLAG']"
			[Register ("AID_CAPK_OPT_REMOVEALL_FLAG")]
			public const int AidCapkOptRemoveallFlag = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.AidCapkOptFlag']/field[@name='AID_CAPK_OPT_REMOVE_FLAG']"
			[Register ("AID_CAPK_OPT_REMOVE_FLAG")]
			public const int AidCapkOptRemoveFlag = (int) 2;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/EMVConstant$AidCapkOptFlag", typeof (AidCapkOptFlag));
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

			protected AidCapkOptFlag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.AidCapkOptFlag']/constructor[@name='EMVConstant.AidCapkOptFlag' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe AidCapkOptFlag ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.CertType']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/EMVConstant$CertType", DoNotGenerateAcw=true)]
		public partial class CertType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.CertType']/field[@name='CERT_TYPE_ENTER_COUNTRY']"
			[Register ("CERT_TYPE_ENTER_COUNTRY")]
			public const int CertTypeEnterCountry = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.CertType']/field[@name='CERT_TYPE_ID']"
			[Register ("CERT_TYPE_ID")]
			public const int CertTypeId = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.CertType']/field[@name='CERT_TYPE_OFFICER']"
			[Register ("CERT_TYPE_OFFICER")]
			public const int CertTypeOfficer = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.CertType']/field[@name='CERT_TYPE_OTHER']"
			[Register ("CERT_TYPE_OTHER")]
			public const int CertTypeOther = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.CertType']/field[@name='CERT_TYPE_PASSPORT']"
			[Register ("CERT_TYPE_PASSPORT")]
			public const int CertTypePassport = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.CertType']/field[@name='CERT_TYPE_TEMP_ID']"
			[Register ("CERT_TYPE_TEMP_ID")]
			public const int CertTypeTempId = (int) 4;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/EMVConstant$CertType", typeof (CertType));
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

			protected CertType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.CertType']/constructor[@name='EMVConstant.CertType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CertType ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.PinType']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/EMVConstant$PinType", DoNotGenerateAcw=true)]
		public partial class PinType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.PinType']/field[@name='PINTYPE_OFFLINE']"
			[Register ("PINTYPE_OFFLINE")]
			public const int PintypeOffline = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.PinType']/field[@name='PINTYPE_OFFLINE_LASTTIME']"
			[Register ("PINTYPE_OFFLINE_LASTTIME")]
			public const int PintypeOfflineLasttime = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.PinType']/field[@name='PINTYPE_ONLINE']"
			[Register ("PINTYPE_ONLINE")]
			public const int PintypeOnline = (int) 3;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/EMVConstant$PinType", typeof (PinType));
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

			protected PinType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.PinType']/constructor[@name='EMVConstant.PinType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe PinType ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.ReadCardLoadLogType']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/EMVConstant$ReadCardLoadLogType", DoNotGenerateAcw=true)]
		public partial class ReadCardLoadLogType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.ReadCardLoadLogType']/field[@name='ONE_BY_ONE_TYPE']"
			[Register ("ONE_BY_ONE_TYPE")]
			public const int OneByOneType = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.ReadCardLoadLogType']/field[@name='ONE_OFF_TYPE']"
			[Register ("ONE_OFF_TYPE")]
			public const int OneOffType = (int) 1;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/EMVConstant$ReadCardLoadLogType", typeof (ReadCardLoadLogType));
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

			protected ReadCardLoadLogType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.ReadCardLoadLogType']/constructor[@name='EMVConstant.ReadCardLoadLogType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ReadCardLoadLogType ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.SlotType']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/EMVConstant$SlotType", DoNotGenerateAcw=true)]
		public partial class SlotType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.SlotType']/field[@name='SLOT_TYPE_IC']"
			[Register ("SLOT_TYPE_IC")]
			public const int SlotTypeIc = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.SlotType']/field[@name='SLOT_TYPE_RF']"
			[Register ("SLOT_TYPE_RF")]
			public const int SlotTypeRf = (int) 1;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/EMVConstant$SlotType", typeof (SlotType));
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

			protected SlotType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant.SlotType']/constructor[@name='EMVConstant.SlotType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SlotType ()
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/EMVConstant", typeof (EMVConstant));
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

		protected EMVConstant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='EMVConstant']/constructor[@name='EMVConstant' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EMVConstant ()
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
