using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardEmvTransData", DoNotGenerateAcw=true)]
	public partial class PrepaidCardEmvTransData : global::Java.Lang.Object, global::Android.OS.IParcelable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardEmvTransData", typeof (PrepaidCardEmvTransData));
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

		protected PrepaidCardEmvTransData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/constructor[@name='PrepaidCardEmvTransData' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe PrepaidCardEmvTransData (global::Android.OS.Parcel source)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/constructor[@name='PrepaidCardEmvTransData' and count(parameter)=8 and parameter[1][@type='byte'] and parameter[2][@type='byte'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='byte'] and parameter[7][@type='byte'] and parameter[8][@type='byte[]']]"
		[Register (".ctor", "(BBZZZBB[B)V", "")]
		public unsafe PrepaidCardEmvTransData (sbyte transtype, sbyte requestAmtPosition, bool isEcashEnable, bool isSmEnable, bool isForceOnline, sbyte emvFlow, sbyte slotType, byte[] reserv)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(BBZZZBB[B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_reserv = JNIEnv.NewArray (reserv);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (transtype);
				__args [1] = new JniArgumentValue (requestAmtPosition);
				__args [2] = new JniArgumentValue (isEcashEnable);
				__args [3] = new JniArgumentValue (isSmEnable);
				__args [4] = new JniArgumentValue (isForceOnline);
				__args [5] = new JniArgumentValue (emvFlow);
				__args [6] = new JniArgumentValue (slotType);
				__args [7] = new JniArgumentValue (native_reserv);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (reserv != null) {
					JNIEnv.CopyArray (native_reserv, reserv);
					JNIEnv.DeleteLocalRef (native_reserv);
				}
			}
		}

		public static unsafe global::Android.OS.IParcelableCreator Creator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='getCreator' and count(parameter)=0]"
			[Register ("getCreator", "()Landroid/os/Parcelable$Creator;", "GetGetCreatorHandler")]
			get {
				const string __id = "getCreator.()Landroid/os/Parcelable$Creator;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEcashEnable;
#pragma warning disable 0169
		static Delegate GetIsEcashEnableHandler ()
		{
			if (cb_isEcashEnable == null)
				cb_isEcashEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEcashEnable);
			return cb_isEcashEnable;
		}

		static bool n_IsEcashEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EcashEnable;
		}
#pragma warning restore 0169

		static Delegate cb_setEcashEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetEcashEnable_ZHandler ()
		{
			if (cb_setEcashEnable_Z == null)
				cb_setEcashEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEcashEnable_Z);
			return cb_setEcashEnable_Z;
		}

		static void n_SetEcashEnable_Z (IntPtr jnienv, IntPtr native__this, bool isEcashEnable)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EcashEnable = isEcashEnable;
		}
#pragma warning restore 0169

		public virtual unsafe bool EcashEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='isEcashEnable' and count(parameter)=0]"
			[Register ("isEcashEnable", "()Z", "GetIsEcashEnableHandler")]
			get {
				const string __id = "isEcashEnable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='setEcashEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEcashEnable", "(Z)V", "GetSetEcashEnable_ZHandler")]
			set {
				const string __id = "setEcashEnable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEmvFlow;
#pragma warning disable 0169
		static Delegate GetGetEmvFlowHandler ()
		{
			if (cb_getEmvFlow == null)
				cb_getEmvFlow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetEmvFlow);
			return cb_getEmvFlow;
		}

		static sbyte n_GetEmvFlow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EmvFlow;
		}
#pragma warning restore 0169

		static Delegate cb_setEmvFlow_B;
#pragma warning disable 0169
		static Delegate GetSetEmvFlow_BHandler ()
		{
			if (cb_setEmvFlow_B == null)
				cb_setEmvFlow_B = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte>) n_SetEmvFlow_B);
			return cb_setEmvFlow_B;
		}

		static void n_SetEmvFlow_B (IntPtr jnienv, IntPtr native__this, sbyte emvFlow)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EmvFlow = emvFlow;
		}
#pragma warning restore 0169

		public virtual unsafe sbyte EmvFlow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='getEmvFlow' and count(parameter)=0]"
			[Register ("getEmvFlow", "()B", "GetGetEmvFlowHandler")]
			get {
				const string __id = "getEmvFlow.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='setEmvFlow' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("setEmvFlow", "(B)V", "GetSetEmvFlow_BHandler")]
			set {
				const string __id = "setEmvFlow.(B)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isForceOnline;
#pragma warning disable 0169
		static Delegate GetIsForceOnlineHandler ()
		{
			if (cb_isForceOnline == null)
				cb_isForceOnline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsForceOnline);
			return cb_isForceOnline;
		}

		static bool n_IsForceOnline (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ForceOnline;
		}
#pragma warning restore 0169

		static Delegate cb_setForceOnline_Z;
#pragma warning disable 0169
		static Delegate GetSetForceOnline_ZHandler ()
		{
			if (cb_setForceOnline_Z == null)
				cb_setForceOnline_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetForceOnline_Z);
			return cb_setForceOnline_Z;
		}

		static void n_SetForceOnline_Z (IntPtr jnienv, IntPtr native__this, bool isForceOnline)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForceOnline = isForceOnline;
		}
#pragma warning restore 0169

		public virtual unsafe bool ForceOnline {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='isForceOnline' and count(parameter)=0]"
			[Register ("isForceOnline", "()Z", "GetIsForceOnlineHandler")]
			get {
				const string __id = "isForceOnline.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='setForceOnline' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setForceOnline", "(Z)V", "GetSetForceOnline_ZHandler")]
			set {
				const string __id = "setForceOnline.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestAmtPosition;
#pragma warning disable 0169
		static Delegate GetGetRequestAmtPositionHandler ()
		{
			if (cb_getRequestAmtPosition == null)
				cb_getRequestAmtPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetRequestAmtPosition);
			return cb_getRequestAmtPosition;
		}

		static sbyte n_GetRequestAmtPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestAmtPosition;
		}
#pragma warning restore 0169

		static Delegate cb_setRequestAmtPosition_B;
#pragma warning disable 0169
		static Delegate GetSetRequestAmtPosition_BHandler ()
		{
			if (cb_setRequestAmtPosition_B == null)
				cb_setRequestAmtPosition_B = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte>) n_SetRequestAmtPosition_B);
			return cb_setRequestAmtPosition_B;
		}

		static void n_SetRequestAmtPosition_B (IntPtr jnienv, IntPtr native__this, sbyte requestAmtPosition)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestAmtPosition = requestAmtPosition;
		}
#pragma warning restore 0169

		public virtual unsafe sbyte RequestAmtPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='getRequestAmtPosition' and count(parameter)=0]"
			[Register ("getRequestAmtPosition", "()B", "GetGetRequestAmtPositionHandler")]
			get {
				const string __id = "getRequestAmtPosition.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='setRequestAmtPosition' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("setRequestAmtPosition", "(B)V", "GetSetRequestAmtPosition_BHandler")]
			set {
				const string __id = "setRequestAmtPosition.(B)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSlotType;
#pragma warning disable 0169
		static Delegate GetGetSlotTypeHandler ()
		{
			if (cb_getSlotType == null)
				cb_getSlotType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetSlotType);
			return cb_getSlotType;
		}

		static sbyte n_GetSlotType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SlotType;
		}
#pragma warning restore 0169

		static Delegate cb_setSlotType_B;
#pragma warning disable 0169
		static Delegate GetSetSlotType_BHandler ()
		{
			if (cb_setSlotType_B == null)
				cb_setSlotType_B = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte>) n_SetSlotType_B);
			return cb_setSlotType_B;
		}

		static void n_SetSlotType_B (IntPtr jnienv, IntPtr native__this, sbyte slotType)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SlotType = slotType;
		}
#pragma warning restore 0169

		public virtual unsafe sbyte SlotType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='getSlotType' and count(parameter)=0]"
			[Register ("getSlotType", "()B", "GetGetSlotTypeHandler")]
			get {
				const string __id = "getSlotType.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='setSlotType' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("setSlotType", "(B)V", "GetSetSlotType_BHandler")]
			set {
				const string __id = "setSlotType.(B)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSmEnable;
#pragma warning disable 0169
		static Delegate GetIsSmEnableHandler ()
		{
			if (cb_isSmEnable == null)
				cb_isSmEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSmEnable);
			return cb_isSmEnable;
		}

		static bool n_IsSmEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SmEnable;
		}
#pragma warning restore 0169

		static Delegate cb_setSmEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetSmEnable_ZHandler ()
		{
			if (cb_setSmEnable_Z == null)
				cb_setSmEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSmEnable_Z);
			return cb_setSmEnable_Z;
		}

		static void n_SetSmEnable_Z (IntPtr jnienv, IntPtr native__this, bool isSmEnable)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SmEnable = isSmEnable;
		}
#pragma warning restore 0169

		public virtual unsafe bool SmEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='isSmEnable' and count(parameter)=0]"
			[Register ("isSmEnable", "()Z", "GetIsSmEnableHandler")]
			get {
				const string __id = "isSmEnable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='setSmEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSmEnable", "(Z)V", "GetSetSmEnable_ZHandler")]
			set {
				const string __id = "setSmEnable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTranstype;
#pragma warning disable 0169
		static Delegate GetGetTranstypeHandler ()
		{
			if (cb_getTranstype == null)
				cb_getTranstype = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetTranstype);
			return cb_getTranstype;
		}

		static sbyte n_GetTranstype (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Transtype;
		}
#pragma warning restore 0169

		static Delegate cb_setTranstype_B;
#pragma warning disable 0169
		static Delegate GetSetTranstype_BHandler ()
		{
			if (cb_setTranstype_B == null)
				cb_setTranstype_B = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, sbyte>) n_SetTranstype_B);
			return cb_setTranstype_B;
		}

		static void n_SetTranstype_B (IntPtr jnienv, IntPtr native__this, sbyte transtype)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Transtype = transtype;
		}
#pragma warning restore 0169

		public virtual unsafe sbyte Transtype {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='getTranstype' and count(parameter)=0]"
			[Register ("getTranstype", "()B", "GetGetTranstypeHandler")]
			get {
				const string __id = "getTranstype.()B";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='setTranstype' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("setTranstype", "(B)V", "GetSetTranstype_BHandler")]
			set {
				const string __id = "setTranstype.(B)V";
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getReserv;
#pragma warning disable 0169
		static Delegate GetGetReservHandler ()
		{
			if (cb_getReserv == null)
				cb_getReserv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReserv);
			return cb_getReserv;
		}

		static IntPtr n_GetReserv (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetReserv ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='getReserv' and count(parameter)=0]"
		[Register ("getReserv", "()[B", "GetGetReservHandler")]
		public virtual unsafe byte[] GetReserv ()
		{
			const string __id = "getReserv.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setReserv_arrayB;
#pragma warning disable 0169
		static Delegate GetSetReserv_arrayBHandler ()
		{
			if (cb_setReserv_arrayB == null)
				cb_setReserv_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReserv_arrayB);
			return cb_setReserv_arrayB;
		}

		static void n_SetReserv_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_reserv)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] reserv = (byte[]) JNIEnv.GetArray (native_reserv, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetReserv (reserv);
			if (reserv != null)
				JNIEnv.CopyArray (reserv, native_reserv);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='setReserv' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setReserv", "([B)V", "GetSetReserv_arrayBHandler")]
		public virtual unsafe void SetReserv (byte[] reserv)
		{
			const string __id = "setReserv.([B)V";
			IntPtr native_reserv = JNIEnv.NewArray (reserv);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_reserv);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (reserv != null) {
					JNIEnv.CopyArray (native_reserv, reserv);
					JNIEnv.DeleteLocalRef (native_reserv);
				}
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardEmvTransData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl.prepaidcard']/class[@name='PrepaidCardEmvTransData']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
