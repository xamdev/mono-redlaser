﻿/*
 * Updated 24/8/2010, Chris Branson, updated to RedLaser SDK 2.8.2
 * 
 * Updated 16/2/2011, Chris Branson, updated to RedLaser SDK 2.9.2
 *
 * Updated 19/4/2011, Chris Branson, updated to RedLaser SDK 3.0.0
 *
 * Updated 29/7/2011, Chris Branson, updated to RedLaser SDK 3.1.1
 * 
 * This is the public API for the RedLaser SDK.
 *
*/

namespace Ebay.RedLaser
{
	public enum RLBarcodeType {
		EAN13 = 0x1,
		UPCE = 0x2,
		EAN8 = 0x4,
		QRCODE = 0x10,
		Code128 = 0x20,
		Code39 = 0x40,
		DataMatrix = 0x80,
		ITF = 0x100,
		EAN5 = 0x200,
		EAN2 = 0x400,
        TypeCodabar = 0x800,
        CODE93 = 0x1000,
        PDF417 = 0x2000,
        GS1Databar = 0x4000,
        GS1DatabarExpanded = 0x8000,
        Aztec = 0x10000,
	}

	public enum RedLaserStatus {
		EvalModeReady = 1,
		LicensedModeReady = 2,

		MissingOSLibraries = -1,
		NoCamera = -2,
		BadLicense = -3,
		ScanLimitReached = -4,
        NoKeychainAccess = -5,
        NoVideoAuthorization = -6,
	}
}
