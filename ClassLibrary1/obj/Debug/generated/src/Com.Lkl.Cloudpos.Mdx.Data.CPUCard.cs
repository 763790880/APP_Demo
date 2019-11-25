using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/CPUCard", DoNotGenerateAcw=true)]
	public sealed partial class CPUCard : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']"
		[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/CPUCard$CPUCardType", DoNotGenerateAcw=true)]
		public sealed partial class CPUCardType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='AT24CXX']"
			[Register ("AT24CXX")]
			public const int At24cxx = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='AT45D041']"
			[Register ("AT45D041")]
			public const int At45d041 = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='AT88SC102']"
			[Register ("AT88SC102")]
			public const int At88sc102 = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='AT88SC1604']"
			[Register ("AT88SC1604")]
			public const int At88sc1604 = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='AT88SC1604B']"
			[Register ("AT88SC1604B")]
			public const int At88sc1604b = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='AT88SC1608']"
			[Register ("AT88SC1608")]
			public const int At88sc1608 = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='AT93C46']"
			[Register ("AT93C46")]
			public const int At93c46 = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='AT93C46A']"
			[Register ("AT93C46A")]
			public const int At93c46a = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='SLE4404']"
			[Register ("SLE4404")]
			public const int Sle4404 = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='SLE4406']"
			[Register ("SLE4406")]
			public const int Sle4406 = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='SLE4418']"
			[Register ("SLE4418")]
			public const int Sle4418 = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='SLE4428']"
			[Register ("SLE4428")]
			public const int Sle4428 = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='SLE4432']"
			[Register ("SLE4432")]
			public const int Sle4432 = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='SLE4442']"
			[Register ("SLE4442")]
			public const int Sle4442 = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/field[@name='SSF1101']"
			[Register ("SSF1101")]
			public const int Ssf1101 = (int) 15;
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/CPUCard$CPUCardType", typeof (CPUCardType));
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

			internal CPUCardType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard.CPUCardType']/constructor[@name='CPUCard.CPUCardType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe CPUCardType ()
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/CPUCard", typeof (CPUCard));
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

		internal CPUCard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='CPUCard']/constructor[@name='CPUCard' and count(parameter)=0]"
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
}
