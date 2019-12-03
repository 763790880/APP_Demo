using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrepaidCardConstant']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/PrepaidCardConstant", DoNotGenerateAcw=true)]
	public partial class PrepaidCardConstant : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrepaidCardConstant']/field[@name='PREPAID_CARD_KEY_ID']"
		[Register ("PREPAID_CARD_KEY_ID")]
		public const int PrepaidCardKeyId = (int) 5;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/PrepaidCardConstant", typeof (PrepaidCardConstant));
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

		protected PrepaidCardConstant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='PrepaidCardConstant']/constructor[@name='PrepaidCardConstant' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PrepaidCardConstant ()
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
