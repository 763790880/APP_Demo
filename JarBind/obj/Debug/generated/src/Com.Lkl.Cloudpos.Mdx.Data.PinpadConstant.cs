using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PinpadConstant", DoNotGenerateAcw=true)]
	public partial class PinpadConstant : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.EncType']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PinpadConstant$EncType", DoNotGenerateAcw=true)]
		public partial class EncType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.EncType']/field[@name='TYPE_CBC']"
			[Register ("TYPE_CBC")]
			public const int TypeCbc = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.EncType']/field[@name='TYPE_ECB']"
			[Register ("TYPE_ECB")]
			public const int TypeEcb = (int) 0;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PinpadConstant$EncType", typeof (EncType));
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

			protected EncType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.EncType']/constructor[@name='PinpadConstant.EncType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe EncType ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.KeyboardMode']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PinpadConstant$KeyboardMode", DoNotGenerateAcw=true)]
		public partial class KeyboardMode : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.KeyboardMode']/field[@name='MODE_FIXED']"
			[Register ("MODE_FIXED")]
			public const int ModeFixed = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.KeyboardMode']/field[@name='MODE_RANDOM']"
			[Register ("MODE_RANDOM")]
			public const int ModeRandom = (int) 1;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PinpadConstant$KeyboardMode", typeof (KeyboardMode));
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

			protected KeyboardMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.KeyboardMode']/constructor[@name='PinpadConstant.KeyboardMode' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe KeyboardMode ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.MacType']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PinpadConstant$MacType", DoNotGenerateAcw=true)]
		public partial class MacType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.MacType']/field[@name='TYPE_CUP_ECB']"
			[Register ("TYPE_CUP_ECB")]
			public const int TypeCupEcb = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.MacType']/field[@name='TYPE_X919']"
			[Register ("TYPE_X919")]
			public const int TypeX919 = (int) 0;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PinpadConstant$MacType", typeof (MacType));
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

			protected MacType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.MacType']/constructor[@name='PinpadConstant.MacType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe MacType ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.PinpadId']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PinpadConstant$PinpadId", DoNotGenerateAcw=true)]
		public partial class PinpadId : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.PinpadId']/field[@name='BUILTIN']"
			[Register ("BUILTIN")]
			public const int Builtin = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.PinpadId']/field[@name='EXTERNAL']"
			[Register ("EXTERNAL")]
			public const int External = (int) 1;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PinpadConstant$PinpadId", typeof (PinpadId));
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

			protected PinpadId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.PinpadId']/constructor[@name='PinpadConstant.PinpadId' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe PinpadId ()
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.PinType']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PinpadConstant$PinType", DoNotGenerateAcw=true)]
		public partial class PinType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.PinType']/field[@name='INLINE_TYPE']"
			[Register ("INLINE_TYPE")]
			public const int InlineType = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.PinType']/field[@name='OUTLINE_TYPE']"
			[Register ("OUTLINE_TYPE")]
			public const int OutlineType = (int) 1;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PinpadConstant$PinType", typeof (PinType));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.PinType']/constructor[@name='PinpadConstant.PinType' and count(parameter)=0]"
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.WKeyType']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PinpadConstant$WKeyType", DoNotGenerateAcw=true)]
		public partial class WKeyType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.WKeyType']/field[@name='WKEY_TYPE_MAK']"
			[Register ("WKEY_TYPE_MAK")]
			public const int WkeyTypeMak = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.WKeyType']/field[@name='WKEY_TYPE_PIK']"
			[Register ("WKEY_TYPE_PIK")]
			public const int WkeyTypePik = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.WKeyType']/field[@name='WKEY_TYPE_TDK']"
			[Register ("WKEY_TYPE_TDK")]
			public const int WkeyTypeTdk = (int) 2;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PinpadConstant$WKeyType", typeof (WKeyType));
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

			protected WKeyType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant.WKeyType']/constructor[@name='PinpadConstant.WKeyType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe WKeyType ()
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PinpadConstant", typeof (PinpadConstant));
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

		protected PinpadConstant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PinpadConstant']/constructor[@name='PinpadConstant' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PinpadConstant ()
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
