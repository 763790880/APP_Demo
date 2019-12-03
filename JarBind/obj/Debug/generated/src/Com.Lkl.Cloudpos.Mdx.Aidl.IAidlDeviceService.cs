using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Lkl.Cloudpos.Mdx.Aidl {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']"
	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/AidlDeviceService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class AidlDeviceServiceStub : global::Android.OS.Binder, global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/lkl/cloudpos/mdx/aidl/AidlDeviceService$Stub", typeof (AidlDeviceServiceStub));
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

		protected AidlDeviceServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/constructor[@name='AidlDeviceService.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AidlDeviceServiceStub ()
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='asBinder' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/AidlDeviceService;", "")]
		public static unsafe global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/lkl/cloudpos/mdx/aidl/AidlDeviceService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
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

		static Delegate cb_getPSAMReader_I;
#pragma warning disable 0169
		static Delegate GetGetPSAMReader_IHandler ()
		{
			if (cb_getPSAMReader_I == null)
				cb_getPSAMReader_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPSAMReader_I);
			return cb_getPSAMReader_I;
		}

		static IntPtr n_GetPSAMReader_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPSAMReader (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getPSAMReader' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPSAMReader", "(I)Landroid/os/IBinder;", "GetGetPSAMReader_IHandler")]
		public abstract global::Android.OS.IBinder GetPSAMReader (int p0);

		static Delegate cb_getPinPad_I;
#pragma warning disable 0169
		static Delegate GetGetPinPad_IHandler ()
		{
			if (cb_getPinPad_I == null)
				cb_getPinPad_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPinPad_I);
			return cb_getPinPad_I;
		}

		static IntPtr n_GetPinPad_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPinPad (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getPinPad' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPinPad", "(I)Landroid/os/IBinder;", "GetGetPinPad_IHandler")]
		public abstract global::Android.OS.IBinder GetPinPad (int p0);

		static Delegate cb_getSerialPort_I;
#pragma warning disable 0169
		static Delegate GetGetSerialPort_IHandler ()
		{
			if (cb_getSerialPort_I == null)
				cb_getSerialPort_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetSerialPort_I);
			return cb_getSerialPort_I;
		}

		static IntPtr n_GetSerialPort_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSerialPort (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getSerialPort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSerialPort", "(I)Landroid/os/IBinder;", "GetGetSerialPort_IHandler")]
		public abstract global::Android.OS.IBinder GetSerialPort (int p0);

		static Delegate cb_getCPUCard;
#pragma warning disable 0169
		static Delegate GetGetCPUCardHandler ()
		{
			if (cb_getCPUCard == null)
				cb_getCPUCard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCPUCard);
			return cb_getCPUCard;
		}

		static IntPtr n_GetCPUCard (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CPUCard);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder CPUCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getCPUCard' and count(parameter)=0]"
			[Register ("getCPUCard", "()Landroid/os/IBinder;", "GetGetCPUCardHandler")] get;
		}

		static Delegate cb_getCameraManager;
#pragma warning disable 0169
		static Delegate GetGetCameraManagerHandler ()
		{
			if (cb_getCameraManager == null)
				cb_getCameraManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCameraManager);
			return cb_getCameraManager;
		}

		static IntPtr n_GetCameraManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CameraManager);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder CameraManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getCameraManager' and count(parameter)=0]"
			[Register ("getCameraManager", "()Landroid/os/IBinder;", "GetGetCameraManagerHandler")] get;
		}

		static Delegate cb_getCasher;
#pragma warning disable 0169
		static Delegate GetGetCasherHandler ()
		{
			if (cb_getCasher == null)
				cb_getCasher = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCasher);
			return cb_getCasher;
		}

		static IntPtr n_GetCasher (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Casher);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder Casher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getCasher' and count(parameter)=0]"
			[Register ("getCasher", "()Landroid/os/IBinder;", "GetGetCasherHandler")] get;
		}

		static Delegate cb_getEMVL2;
#pragma warning disable 0169
		static Delegate GetGetEMVL2Handler ()
		{
			if (cb_getEMVL2 == null)
				cb_getEMVL2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEMVL2);
			return cb_getEMVL2;
		}

		static IntPtr n_GetEMVL2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EMVL2);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder EMVL2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getEMVL2' and count(parameter)=0]"
			[Register ("getEMVL2", "()Landroid/os/IBinder;", "GetGetEMVL2Handler")] get;
		}

		static Delegate cb_getInsertCardReader;
#pragma warning disable 0169
		static Delegate GetGetInsertCardReaderHandler ()
		{
			if (cb_getInsertCardReader == null)
				cb_getInsertCardReader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInsertCardReader);
			return cb_getInsertCardReader;
		}

		static IntPtr n_GetInsertCardReader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InsertCardReader);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder InsertCardReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getInsertCardReader' and count(parameter)=0]"
			[Register ("getInsertCardReader", "()Landroid/os/IBinder;", "GetGetInsertCardReaderHandler")] get;
		}

		static Delegate cb_getMagCardReader;
#pragma warning disable 0169
		static Delegate GetGetMagCardReaderHandler ()
		{
			if (cb_getMagCardReader == null)
				cb_getMagCardReader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagCardReader);
			return cb_getMagCardReader;
		}

		static IntPtr n_GetMagCardReader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MagCardReader);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder MagCardReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getMagCardReader' and count(parameter)=0]"
			[Register ("getMagCardReader", "()Landroid/os/IBinder;", "GetGetMagCardReaderHandler")] get;
		}

		static Delegate cb_getPedestal;
#pragma warning disable 0169
		static Delegate GetGetPedestalHandler ()
		{
			if (cb_getPedestal == null)
				cb_getPedestal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPedestal);
			return cb_getPedestal;
		}

		static IntPtr n_GetPedestal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pedestal);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder Pedestal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getPedestal' and count(parameter)=0]"
			[Register ("getPedestal", "()Landroid/os/IBinder;", "GetGetPedestalHandler")] get;
		}

		static Delegate cb_getPrepaidCard;
#pragma warning disable 0169
		static Delegate GetGetPrepaidCardHandler ()
		{
			if (cb_getPrepaidCard == null)
				cb_getPrepaidCard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrepaidCard);
			return cb_getPrepaidCard;
		}

		static IntPtr n_GetPrepaidCard (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PrepaidCard);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder PrepaidCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getPrepaidCard' and count(parameter)=0]"
			[Register ("getPrepaidCard", "()Landroid/os/IBinder;", "GetGetPrepaidCardHandler")] get;
		}

		static Delegate cb_getPrinter;
#pragma warning disable 0169
		static Delegate GetGetPrinterHandler ()
		{
			if (cb_getPrinter == null)
				cb_getPrinter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrinter);
			return cb_getPrinter;
		}

		static IntPtr n_GetPrinter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Printer);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder Printer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getPrinter' and count(parameter)=0]"
			[Register ("getPrinter", "()Landroid/os/IBinder;", "GetGetPrinterHandler")] get;
		}

		static Delegate cb_getRFIDReader;
#pragma warning disable 0169
		static Delegate GetGetRFIDReaderHandler ()
		{
			if (cb_getRFIDReader == null)
				cb_getRFIDReader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRFIDReader);
			return cb_getRFIDReader;
		}

		static IntPtr n_GetRFIDReader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RFIDReader);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder RFIDReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getRFIDReader' and count(parameter)=0]"
			[Register ("getRFIDReader", "()Landroid/os/IBinder;", "GetGetRFIDReaderHandler")] get;
		}

		static Delegate cb_getShellMonitor;
#pragma warning disable 0169
		static Delegate GetGetShellMonitorHandler ()
		{
			if (cb_getShellMonitor == null)
				cb_getShellMonitor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShellMonitor);
			return cb_getShellMonitor;
		}

		static IntPtr n_GetShellMonitor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShellMonitor);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder ShellMonitor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getShellMonitor' and count(parameter)=0]"
			[Register ("getShellMonitor", "()Landroid/os/IBinder;", "GetGetShellMonitorHandler")] get;
		}

		static Delegate cb_getSystemService;
#pragma warning disable 0169
		static Delegate GetGetSystemServiceHandler ()
		{
			if (cb_getSystemService == null)
				cb_getSystemService = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSystemService);
			return cb_getSystemService;
		}

		static IntPtr n_GetSystemService (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SystemService);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.IBinder SystemService {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getSystemService' and count(parameter)=0]"
			[Register ("getSystemService", "()Landroid/os/IBinder;", "GetGetSystemServiceHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/AidlDeviceService$Stub", DoNotGenerateAcw=true)]
	internal partial class AidlDeviceServiceStubInvoker : AidlDeviceServiceStub {

		public AidlDeviceServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/AidlDeviceService$Stub", typeof (AidlDeviceServiceStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::Android.OS.IBinder CPUCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getCPUCard' and count(parameter)=0]"
			[Register ("getCPUCard", "()Landroid/os/IBinder;", "GetGetCPUCardHandler")]
			get {
				const string __id = "getCPUCard.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder CameraManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getCameraManager' and count(parameter)=0]"
			[Register ("getCameraManager", "()Landroid/os/IBinder;", "GetGetCameraManagerHandler")]
			get {
				const string __id = "getCameraManager.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder Casher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getCasher' and count(parameter)=0]"
			[Register ("getCasher", "()Landroid/os/IBinder;", "GetGetCasherHandler")]
			get {
				const string __id = "getCasher.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder EMVL2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getEMVL2' and count(parameter)=0]"
			[Register ("getEMVL2", "()Landroid/os/IBinder;", "GetGetEMVL2Handler")]
			get {
				const string __id = "getEMVL2.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder InsertCardReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getInsertCardReader' and count(parameter)=0]"
			[Register ("getInsertCardReader", "()Landroid/os/IBinder;", "GetGetInsertCardReaderHandler")]
			get {
				const string __id = "getInsertCardReader.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder MagCardReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getMagCardReader' and count(parameter)=0]"
			[Register ("getMagCardReader", "()Landroid/os/IBinder;", "GetGetMagCardReaderHandler")]
			get {
				const string __id = "getMagCardReader.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder Pedestal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getPedestal' and count(parameter)=0]"
			[Register ("getPedestal", "()Landroid/os/IBinder;", "GetGetPedestalHandler")]
			get {
				const string __id = "getPedestal.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder PrepaidCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getPrepaidCard' and count(parameter)=0]"
			[Register ("getPrepaidCard", "()Landroid/os/IBinder;", "GetGetPrepaidCardHandler")]
			get {
				const string __id = "getPrepaidCard.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder Printer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getPrinter' and count(parameter)=0]"
			[Register ("getPrinter", "()Landroid/os/IBinder;", "GetGetPrinterHandler")]
			get {
				const string __id = "getPrinter.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder RFIDReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getRFIDReader' and count(parameter)=0]"
			[Register ("getRFIDReader", "()Landroid/os/IBinder;", "GetGetRFIDReaderHandler")]
			get {
				const string __id = "getRFIDReader.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder ShellMonitor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getShellMonitor' and count(parameter)=0]"
			[Register ("getShellMonitor", "()Landroid/os/IBinder;", "GetGetShellMonitorHandler")]
			get {
				const string __id = "getShellMonitor.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.IBinder SystemService {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/class[@name='AidlDeviceService.Stub']/method[@name='getSystemService' and count(parameter)=0]"
			[Register ("getSystemService", "()Landroid/os/IBinder;", "GetGetSystemServiceHandler")]
			get {
				const string __id = "getSystemService.()Landroid/os/IBinder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getPSAMReader' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPSAMReader", "(I)Landroid/os/IBinder;", "GetGetPSAMReader_IHandler")]
		public override unsafe global::Android.OS.IBinder GetPSAMReader (int p0)
		{
			const string __id = "getPSAMReader.(I)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getPinPad' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPinPad", "(I)Landroid/os/IBinder;", "GetGetPinPad_IHandler")]
		public override unsafe global::Android.OS.IBinder GetPinPad (int p0)
		{
			const string __id = "getPinPad.(I)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getSerialPort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSerialPort", "(I)Landroid/os/IBinder;", "GetGetSerialPort_IHandler")]
		public override unsafe global::Android.OS.IBinder GetSerialPort (int p0)
		{
			const string __id = "getSerialPort.(I)Landroid/os/IBinder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']"
	[Register ("com/lkl/cloudpos/mdx/aidl/AidlDeviceService", "", "Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker")]
	public partial interface IAidlDeviceService : global::Android.OS.IInterface {

		global::Android.OS.IBinder CPUCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getCPUCard' and count(parameter)=0]"
			[Register ("getCPUCard", "()Landroid/os/IBinder;", "GetGetCPUCardHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")] get;
		}

		global::Android.OS.IBinder CameraManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getCameraManager' and count(parameter)=0]"
			[Register ("getCameraManager", "()Landroid/os/IBinder;", "GetGetCameraManagerHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")] get;
		}

		global::Android.OS.IBinder Casher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getCasher' and count(parameter)=0]"
			[Register ("getCasher", "()Landroid/os/IBinder;", "GetGetCasherHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")] get;
		}

		global::Android.OS.IBinder EMVL2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getEMVL2' and count(parameter)=0]"
			[Register ("getEMVL2", "()Landroid/os/IBinder;", "GetGetEMVL2Handler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")] get;
		}

		global::Android.OS.IBinder InsertCardReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getInsertCardReader' and count(parameter)=0]"
			[Register ("getInsertCardReader", "()Landroid/os/IBinder;", "GetGetInsertCardReaderHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")] get;
		}

		global::Android.OS.IBinder MagCardReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getMagCardReader' and count(parameter)=0]"
			[Register ("getMagCardReader", "()Landroid/os/IBinder;", "GetGetMagCardReaderHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")] get;
		}

		global::Android.OS.IBinder Pedestal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getPedestal' and count(parameter)=0]"
			[Register ("getPedestal", "()Landroid/os/IBinder;", "GetGetPedestalHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")] get;
		}

		global::Android.OS.IBinder PrepaidCard {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getPrepaidCard' and count(parameter)=0]"
			[Register ("getPrepaidCard", "()Landroid/os/IBinder;", "GetGetPrepaidCardHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")] get;
		}

		global::Android.OS.IBinder Printer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getPrinter' and count(parameter)=0]"
			[Register ("getPrinter", "()Landroid/os/IBinder;", "GetGetPrinterHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")] get;
		}

		global::Android.OS.IBinder RFIDReader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getRFIDReader' and count(parameter)=0]"
			[Register ("getRFIDReader", "()Landroid/os/IBinder;", "GetGetRFIDReaderHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")] get;
		}

		global::Android.OS.IBinder ShellMonitor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getShellMonitor' and count(parameter)=0]"
			[Register ("getShellMonitor", "()Landroid/os/IBinder;", "GetGetShellMonitorHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")] get;
		}

		global::Android.OS.IBinder SystemService {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getSystemService' and count(parameter)=0]"
			[Register ("getSystemService", "()Landroid/os/IBinder;", "GetGetSystemServiceHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getPSAMReader' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPSAMReader", "(I)Landroid/os/IBinder;", "GetGetPSAMReader_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")]
		global::Android.OS.IBinder GetPSAMReader (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getPinPad' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPinPad", "(I)Landroid/os/IBinder;", "GetGetPinPad_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")]
		global::Android.OS.IBinder GetPinPad (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.lkl.cloudpos.mdx.aidl']/interface[@name='AidlDeviceService']/method[@name='getSerialPort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSerialPort", "(I)Landroid/os/IBinder;", "GetGetSerialPort_IHandler:Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceServiceInvoker, JarBind")]
		global::Android.OS.IBinder GetSerialPort (int p0);

	}

	[global::Android.Runtime.Register ("com/lkl/cloudpos/mdx/aidl/AidlDeviceService", DoNotGenerateAcw=true)]
	internal class IAidlDeviceServiceInvoker : global::Java.Lang.Object, IAidlDeviceService {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/lkl/cloudpos/mdx/aidl/AidlDeviceService", typeof (IAidlDeviceServiceInvoker));

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

		public static IAidlDeviceService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAidlDeviceService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.lkl.cloudpos.mdx.aidl.AidlDeviceService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAidlDeviceServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCPUCard;
#pragma warning disable 0169
		static Delegate GetGetCPUCardHandler ()
		{
			if (cb_getCPUCard == null)
				cb_getCPUCard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCPUCard);
			return cb_getCPUCard;
		}

		static IntPtr n_GetCPUCard (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CPUCard);
		}
#pragma warning restore 0169

		IntPtr id_getCPUCard;
		public unsafe global::Android.OS.IBinder CPUCard {
			get {
				if (id_getCPUCard == IntPtr.Zero)
					id_getCPUCard = JNIEnv.GetMethodID (class_ref, "getCPUCard", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCPUCard), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCameraManager;
#pragma warning disable 0169
		static Delegate GetGetCameraManagerHandler ()
		{
			if (cb_getCameraManager == null)
				cb_getCameraManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCameraManager);
			return cb_getCameraManager;
		}

		static IntPtr n_GetCameraManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CameraManager);
		}
#pragma warning restore 0169

		IntPtr id_getCameraManager;
		public unsafe global::Android.OS.IBinder CameraManager {
			get {
				if (id_getCameraManager == IntPtr.Zero)
					id_getCameraManager = JNIEnv.GetMethodID (class_ref, "getCameraManager", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCameraManager), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCasher;
#pragma warning disable 0169
		static Delegate GetGetCasherHandler ()
		{
			if (cb_getCasher == null)
				cb_getCasher = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCasher);
			return cb_getCasher;
		}

		static IntPtr n_GetCasher (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Casher);
		}
#pragma warning restore 0169

		IntPtr id_getCasher;
		public unsafe global::Android.OS.IBinder Casher {
			get {
				if (id_getCasher == IntPtr.Zero)
					id_getCasher = JNIEnv.GetMethodID (class_ref, "getCasher", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCasher), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEMVL2;
#pragma warning disable 0169
		static Delegate GetGetEMVL2Handler ()
		{
			if (cb_getEMVL2 == null)
				cb_getEMVL2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEMVL2);
			return cb_getEMVL2;
		}

		static IntPtr n_GetEMVL2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EMVL2);
		}
#pragma warning restore 0169

		IntPtr id_getEMVL2;
		public unsafe global::Android.OS.IBinder EMVL2 {
			get {
				if (id_getEMVL2 == IntPtr.Zero)
					id_getEMVL2 = JNIEnv.GetMethodID (class_ref, "getEMVL2", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEMVL2), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getInsertCardReader;
#pragma warning disable 0169
		static Delegate GetGetInsertCardReaderHandler ()
		{
			if (cb_getInsertCardReader == null)
				cb_getInsertCardReader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInsertCardReader);
			return cb_getInsertCardReader;
		}

		static IntPtr n_GetInsertCardReader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InsertCardReader);
		}
#pragma warning restore 0169

		IntPtr id_getInsertCardReader;
		public unsafe global::Android.OS.IBinder InsertCardReader {
			get {
				if (id_getInsertCardReader == IntPtr.Zero)
					id_getInsertCardReader = JNIEnv.GetMethodID (class_ref, "getInsertCardReader", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInsertCardReader), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMagCardReader;
#pragma warning disable 0169
		static Delegate GetGetMagCardReaderHandler ()
		{
			if (cb_getMagCardReader == null)
				cb_getMagCardReader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagCardReader);
			return cb_getMagCardReader;
		}

		static IntPtr n_GetMagCardReader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MagCardReader);
		}
#pragma warning restore 0169

		IntPtr id_getMagCardReader;
		public unsafe global::Android.OS.IBinder MagCardReader {
			get {
				if (id_getMagCardReader == IntPtr.Zero)
					id_getMagCardReader = JNIEnv.GetMethodID (class_ref, "getMagCardReader", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMagCardReader), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPedestal;
#pragma warning disable 0169
		static Delegate GetGetPedestalHandler ()
		{
			if (cb_getPedestal == null)
				cb_getPedestal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPedestal);
			return cb_getPedestal;
		}

		static IntPtr n_GetPedestal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pedestal);
		}
#pragma warning restore 0169

		IntPtr id_getPedestal;
		public unsafe global::Android.OS.IBinder Pedestal {
			get {
				if (id_getPedestal == IntPtr.Zero)
					id_getPedestal = JNIEnv.GetMethodID (class_ref, "getPedestal", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPedestal), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPrepaidCard;
#pragma warning disable 0169
		static Delegate GetGetPrepaidCardHandler ()
		{
			if (cb_getPrepaidCard == null)
				cb_getPrepaidCard = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrepaidCard);
			return cb_getPrepaidCard;
		}

		static IntPtr n_GetPrepaidCard (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PrepaidCard);
		}
#pragma warning restore 0169

		IntPtr id_getPrepaidCard;
		public unsafe global::Android.OS.IBinder PrepaidCard {
			get {
				if (id_getPrepaidCard == IntPtr.Zero)
					id_getPrepaidCard = JNIEnv.GetMethodID (class_ref, "getPrepaidCard", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrepaidCard), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPrinter;
#pragma warning disable 0169
		static Delegate GetGetPrinterHandler ()
		{
			if (cb_getPrinter == null)
				cb_getPrinter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrinter);
			return cb_getPrinter;
		}

		static IntPtr n_GetPrinter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Printer);
		}
#pragma warning restore 0169

		IntPtr id_getPrinter;
		public unsafe global::Android.OS.IBinder Printer {
			get {
				if (id_getPrinter == IntPtr.Zero)
					id_getPrinter = JNIEnv.GetMethodID (class_ref, "getPrinter", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrinter), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRFIDReader;
#pragma warning disable 0169
		static Delegate GetGetRFIDReaderHandler ()
		{
			if (cb_getRFIDReader == null)
				cb_getRFIDReader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRFIDReader);
			return cb_getRFIDReader;
		}

		static IntPtr n_GetRFIDReader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RFIDReader);
		}
#pragma warning restore 0169

		IntPtr id_getRFIDReader;
		public unsafe global::Android.OS.IBinder RFIDReader {
			get {
				if (id_getRFIDReader == IntPtr.Zero)
					id_getRFIDReader = JNIEnv.GetMethodID (class_ref, "getRFIDReader", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRFIDReader), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getShellMonitor;
#pragma warning disable 0169
		static Delegate GetGetShellMonitorHandler ()
		{
			if (cb_getShellMonitor == null)
				cb_getShellMonitor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShellMonitor);
			return cb_getShellMonitor;
		}

		static IntPtr n_GetShellMonitor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShellMonitor);
		}
#pragma warning restore 0169

		IntPtr id_getShellMonitor;
		public unsafe global::Android.OS.IBinder ShellMonitor {
			get {
				if (id_getShellMonitor == IntPtr.Zero)
					id_getShellMonitor = JNIEnv.GetMethodID (class_ref, "getShellMonitor", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShellMonitor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSystemService;
#pragma warning disable 0169
		static Delegate GetGetSystemServiceHandler ()
		{
			if (cb_getSystemService == null)
				cb_getSystemService = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSystemService);
			return cb_getSystemService;
		}

		static IntPtr n_GetSystemService (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SystemService);
		}
#pragma warning restore 0169

		IntPtr id_getSystemService;
		public unsafe global::Android.OS.IBinder SystemService {
			get {
				if (id_getSystemService == IntPtr.Zero)
					id_getSystemService = JNIEnv.GetMethodID (class_ref, "getSystemService", "()Landroid/os/IBinder;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSystemService), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPSAMReader_I;
#pragma warning disable 0169
		static Delegate GetGetPSAMReader_IHandler ()
		{
			if (cb_getPSAMReader_I == null)
				cb_getPSAMReader_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPSAMReader_I);
			return cb_getPSAMReader_I;
		}

		static IntPtr n_GetPSAMReader_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPSAMReader (p0));
		}
#pragma warning restore 0169

		IntPtr id_getPSAMReader_I;
		public unsafe global::Android.OS.IBinder GetPSAMReader (int p0)
		{
			if (id_getPSAMReader_I == IntPtr.Zero)
				id_getPSAMReader_I = JNIEnv.GetMethodID (class_ref, "getPSAMReader", "(I)Landroid/os/IBinder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPSAMReader_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getPinPad_I;
#pragma warning disable 0169
		static Delegate GetGetPinPad_IHandler ()
		{
			if (cb_getPinPad_I == null)
				cb_getPinPad_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPinPad_I);
			return cb_getPinPad_I;
		}

		static IntPtr n_GetPinPad_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPinPad (p0));
		}
#pragma warning restore 0169

		IntPtr id_getPinPad_I;
		public unsafe global::Android.OS.IBinder GetPinPad (int p0)
		{
			if (id_getPinPad_I == IntPtr.Zero)
				id_getPinPad_I = JNIEnv.GetMethodID (class_ref, "getPinPad", "(I)Landroid/os/IBinder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPinPad_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getSerialPort_I;
#pragma warning disable 0169
		static Delegate GetGetSerialPort_IHandler ()
		{
			if (cb_getSerialPort_I == null)
				cb_getSerialPort_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetSerialPort_I);
			return cb_getSerialPort_I;
		}

		static IntPtr n_GetSerialPort_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSerialPort (p0));
		}
#pragma warning restore 0169

		IntPtr id_getSerialPort_I;
		public unsafe global::Android.OS.IBinder GetSerialPort (int p0)
		{
			if (id_getSerialPort_I == IntPtr.Zero)
				id_getSerialPort_I = JNIEnv.GetMethodID (class_ref, "getSerialPort", "(I)Landroid/os/IBinder;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialPort_I, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService __this = global::Java.Lang.Object.GetObject<global::Com.Lkl.Cloudpos.Mdx.Aidl.IAidlDeviceService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
