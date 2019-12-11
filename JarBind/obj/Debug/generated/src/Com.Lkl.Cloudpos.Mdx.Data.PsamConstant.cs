using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PsamConstant']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PsamConstant", DoNotGenerateAcw=true)]
	public partial class PsamConstant : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PsamConstant']/field[@name='PSAM_DEV_ID_1']"
		[Register ("PSAM_DEV_ID_1")]
		public const int PsamDevId1 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PsamConstant']/field[@name='PSAM_DEV_ID_2']"
		[Register ("PSAM_DEV_ID_2")]
		public const int PsamDevId2 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PsamConstant']/field[@name='PSAM_DEV_ID_3']"
		[Register ("PSAM_DEV_ID_3")]
		public const int PsamDevId3 = (int) 3;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PsamConstant", typeof (PsamConstant));
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

		protected PsamConstant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PsamConstant']/constructor[@name='PsamConstant' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PsamConstant ()
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