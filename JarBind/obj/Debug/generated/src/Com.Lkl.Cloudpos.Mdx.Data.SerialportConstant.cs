using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='SerialportConstant']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/data/SerialportConstant", DoNotGenerateAcw=true)]
	public partial class SerialportConstant : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='SerialportConstant']/field[@name='PORT_ONE']"
		[Register ("PORT_ONE")]
		public const int PortOne = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='SerialportConstant']/field[@name='PORT_TWO']"
		[Register ("PORT_TWO")]
		public const int PortTwo = (int) 2;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/data/SerialportConstant", typeof (SerialportConstant));
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

		protected SerialportConstant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.data']/class[@name='SerialportConstant']/constructor[@name='SerialportConstant' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SerialportConstant ()
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
