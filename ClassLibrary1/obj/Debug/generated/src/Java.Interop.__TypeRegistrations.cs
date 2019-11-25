using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/lkl/cloudpos/mdx/aidl",
						"com/lkl/cloudpos/mdx/aidl/camera",
						"com/lkl/cloudpos/mdx/aidl/casher",
						"com/lkl/cloudpos/mdx/aidl/cpucard",
						"com/lkl/cloudpos/mdx/aidl/emv",
						"com/lkl/cloudpos/mdx/aidl/iccard",
						"com/lkl/cloudpos/mdx/aidl/magcard",
						"com/lkl/cloudpos/mdx/aidl/pedestal",
						"com/lkl/cloudpos/mdx/aidl/pinpad",
						"com/lkl/cloudpos/mdx/aidl/prepaidcard",
						"com/lkl/cloudpos/mdx/aidl/printer",
						"com/lkl/cloudpos/mdx/aidl/psam",
						"com/lkl/cloudpos/mdx/aidl/rfcard",
						"com/lkl/cloudpos/mdx/aidl/serialport",
						"com/lkl/cloudpos/mdx/aidl/system",
					},
					new Converter<string, Type>[]{
						lookup_com_lkl_cloudpos_mdx_aidl_package,
						lookup_com_lkl_cloudpos_mdx_aidl_camera_package,
						lookup_com_lkl_cloudpos_mdx_aidl_casher_package,
						lookup_com_lkl_cloudpos_mdx_aidl_cpucard_package,
						lookup_com_lkl_cloudpos_mdx_aidl_emv_package,
						lookup_com_lkl_cloudpos_mdx_aidl_iccard_package,
						lookup_com_lkl_cloudpos_mdx_aidl_magcard_package,
						lookup_com_lkl_cloudpos_mdx_aidl_pedestal_package,
						lookup_com_lkl_cloudpos_mdx_aidl_pinpad_package,
						lookup_com_lkl_cloudpos_mdx_aidl_prepaidcard_package,
						lookup_com_lkl_cloudpos_mdx_aidl_printer_package,
						lookup_com_lkl_cloudpos_mdx_aidl_psam_package,
						lookup_com_lkl_cloudpos_mdx_aidl_rfcard_package,
						lookup_com_lkl_cloudpos_mdx_aidl_serialport_package,
						lookup_com_lkl_cloudpos_mdx_aidl_system_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/AidlDeviceService$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.AidlDeviceServiceStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_camera_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_camera_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_camera_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_camera_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/camera/AidlCameraManager$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlCameraManagerStub",
					"com/lkl/cloudpos/mdx/aidl/camera/AidlCameraScanCodeListener$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlCameraScanCodeListenerStub",
					"com/lkl/cloudpos/mdx/aidl/camera/AidlFacingbackCamera$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Camera.AidlFacingbackCameraStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_camera_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_casher_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_casher_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_casher_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_casher_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/casher/AidlCashbox$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCashboxStub",
					"com/lkl/cloudpos/mdx/aidl/casher/AidlCasher$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherStub",
					"com/lkl/cloudpos/mdx/aidl/casher/AidlCasherMessageReceiver$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlCasherMessageReceiverStub",
					"com/lkl/cloudpos/mdx/aidl/casher/AidlDigitalLineLED$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Casher.AidlDigitalLineLEDStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_casher_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_cpucard_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_cpucard_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_cpucard_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_cpucard_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/cpucard/AidlCPUCard$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Cpucard.AidlCPUCardStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_cpucard_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_emv_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_emv_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_emv_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_emv_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/emv/AidlCheckCardListener$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlCheckCardListenerStub",
					"com/lkl/cloudpos/mdx/aidl/emv/AidlPboc$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStub",
					"com/lkl/cloudpos/mdx/aidl/emv/AidlPbocStartListener$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Emv.AidlPbocStartListenerStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_emv_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_iccard_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_iccard_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_iccard_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_iccard_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/iccard/AidlICCard$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Iccard.AidlICCardStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_iccard_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_magcard_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_magcard_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_magcard_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_magcard_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/magcard/AidlMagCard$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.AidlMagCardStub",
					"com/lkl/cloudpos/mdx/aidl/magcard/EncryptMagCardListener$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.EncryptMagCardListenerStub",
					"com/lkl/cloudpos/mdx/aidl/magcard/MagCardListener$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Magcard.MagCardListenerStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_magcard_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_pedestal_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_pedestal_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_pedestal_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_pedestal_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestal$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalStub",
					"com/lkl/cloudpos/mdx/aidl/pedestal/AidlPedestalSerialManager$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Pedestal.AidlPedestalSerialManagerStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_pedestal_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_pinpad_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_pinpad_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_pinpad_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_pinpad_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/pinpad/AidlPinpad$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.AidlPinpadStub",
					"com/lkl/cloudpos/mdx/aidl/pinpad/GetPinListener$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Pinpad.GetPinListenerStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_pinpad_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_prepaidcard_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_prepaidcard_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_prepaidcard_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_prepaidcard_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCard$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardStub",
					"com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardCheckCardListener$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardCheckCardListenerStub",
					"com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardEmv$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardEmvStub",
					"com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPbocStartListener$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPbocStartListenerStub",
					"com/lkl/cloudpos/mdx/aidl/prepaidcard/AidlPrepaidCardPinPad$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.AidlPrepaidCardPinPadStub",
					"com/lkl/cloudpos/mdx/aidl/prepaidcard/PrepaidCardGetPinListener$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Prepaidcard.PrepaidCardGetPinListenerStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_prepaidcard_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_printer_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_printer_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_printer_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_printer_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/printer/AidlPrinter$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterStub",
					"com/lkl/cloudpos/mdx/aidl/printer/AidlPrinterListener$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Printer.AidlPrinterListenerStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_printer_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_psam_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_psam_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_psam_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_psam_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/psam/AidlPsam$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Psam.AidlPsamStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_psam_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_rfcard_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_rfcard_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_rfcard_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_rfcard_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/rfcard/AidlRFCard$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Rfcard.AidlRFCardStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_rfcard_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_serialport_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_serialport_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_serialport_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_serialport_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/serialport/AidlSerialport$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.Serialport.AidlSerialportStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_serialport_mappings, klass);
		}

		static string[] package_com_lkl_cloudpos_mdx_aidl_system_mappings;
		static Type lookup_com_lkl_cloudpos_mdx_aidl_system_package (string klass)
		{
			if (package_com_lkl_cloudpos_mdx_aidl_system_mappings == null) {
				package_com_lkl_cloudpos_mdx_aidl_system_mappings = new string[]{
					"com/lkl/cloudpos/mdx/aidl/system/AidlMerListener$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlMerListenerStub",
					"com/lkl/cloudpos/mdx/aidl/system/AidlSystem$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.System.AidlSystemStub",
					"com/lkl/cloudpos/mdx/aidl/system/InstallAppObserver$Stub:Com.Lkl.Cloudpos.Mdx.Aidl.System.InstallAppObserverStub",
				};
			}

			return Lookup (package_com_lkl_cloudpos_mdx_aidl_system_mappings, klass);
		}
	}
}
