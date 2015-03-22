/*
 * Updated 24/8/2010, Chris Branson, updated to RedLaser SDK 2.8.2
 * 
 * Updated 16/2/2011, Chris Branson, updated to RedLaser SDK 2.9.2
 *
 * Updated 19/4/2011, Chris Branson, updated to RedLaser SDK 3.0.0
 *
 * Updated 29/7/2011, Chris Branson, updated to RedLaser SDK 3.1.1
 *
 * Updated 13/10/2011, Jeffrey Stedfast, updated to RedLaser SDK 3.1.2
 *
 * This is the public API for the RedLaser SDK.
 *
*/

using System;
using Foundation;
using UIKit;
using ObjCRuntime;
using CoreGraphics;

namespace Ebay.RedLaser
{
	/*******************************************************************************
		RL_CheckReadyStatus()
	
		This function returns information about whether the SDK can be used. It 
		doesn't give dynamic state information about what the SDK is currently doing.
	
		Generally, positive values mean you can scan, negative values mean you 
		can't. The returned value *can* change from one call to the next. 
	
		If this function returns a negative value, it's usually best to design your
		app so that it won't attempt to scan at all. If this function returns
		MissingOSLibraries this is especially important, as the SDK will probably 
		crash if used. See the documentation. 
	*/


	/*******************************************************************************
	BarcodeResult

	The return type of the recognizer is a NSSet of Barcode objects.	
		*/
    [BaseType (typeof (NSObject))]
	 interface BarcodeResult 
	{
        //[Export ("init")]
        //public BarcodeResult ();

		[Export ("barcodeType")]
		RLBarcodeType BarcodeType { get; }

		[Export ("barcodeString")]
		string BarcodeString { get; }

		[Export ("extendedBarcodeString", ArgumentSemantic.Copy)]
		string ExtendedBarcodeString { get; }

		[Export ("associatedBarcode")]
		BarcodeResult AssociatedBarcode { get; }

		[Export ("firstScanTime", ArgumentSemantic.Retain)]
		NSDate FirstScanTime { get; }

		[Export ("mostRecentScanTime", ArgumentSemantic.Retain)]
		NSDate MostRecentScanTime { get; }

		[Export ("barcodeLocation", ArgumentSemantic.Retain)]
		NSObject[] BarcodeLocation { get; }
	}
		

	/*******************************************************************************
		BarcodePickerControllerDelegate

		The delegate receives messages about the results of a scan.
	*/
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
    interface IBarcodePickerControllerDelegate
    {
		// - (void) barcodePickerController:(BarcodePickerController*)picker returnResults:(NSSet *)results;
		[Export ("barcodePickerController:returnResults:")]
		void ReturnResults (BarcodePickerController picker, NSSet results);
	}

	/*******************************************************************************
		CameraOverlayViewController

		An optional overlay view that is placed on top of the camera view.
		This view controller receives status updates about the scanning state, and
		can update the user interface.	
	*/
	[BaseType (typeof (UIViewController))]
	interface CameraOverlayViewController {
		//@property (readonly, assign) BarcodePickerController *parentPicker;
		[Export ("parentPicker", ArgumentSemantic.Assign)]
		BarcodePickerController ParentPicker { get; }

		// - (void)barcodePickerController:(BarcodePickerController*)picker statusUpdated:(NSDictionary*)status;
		[Export ("barcodePickerController:statusUpdated:")]
		void StatusUpdated (BarcodePickerController picker, NSDictionary status);
	}

	/*******************************************************************************
		BarcodePickerController

		This ViewController subclass runs the RedLaser scanner, detects barcodes, and
		notifies its delegate of what it found.
	*/
    [BaseType(typeof(BarcodePickerController2))]
	interface BarcodePickerController {

        [Export("overlay", ArgumentSemantic.Retain)]
        CameraOverlayViewController Overlay { get; set; }

		[Export ("scanUPCE", ArgumentSemantic.Assign)]
		bool ScanUPCE { get; set; }

		[Export ("scanEAN8", ArgumentSemantic.Assign)]
		bool ScanEAN8 { get; set; }

		[Export ("scanEAN13", ArgumentSemantic.Assign)]
		bool ScanEAN13 { get; set; }

		[Export ("scanQRCODE", ArgumentSemantic.Assign)]
		bool ScanQRCODE { get; set; }

		[Export ("scanCODE128", ArgumentSemantic.Assign)]
		bool ScanCODE128 { get; set; }

		[Export ("scanCODE39", ArgumentSemantic.Assign)]
		bool ScanCODE39 { get; set; }

		[Export ("scanDATAMATRIX", ArgumentSemantic.Assign)]
		bool ScanDATAMATRIX { get; set; }

		[Export ("scanITF", ArgumentSemantic.Assign)]
		bool ScanITF { get; set; }

		[Export ("scanEAN5", ArgumentSemantic.Assign)]
		bool ScanEAN5 { get; set; }

		[Export ("scanEAN2", ArgumentSemantic.Assign)]
		bool ScanEAN2 { get; set; }

		[Export ("activeRegion", ArgumentSemantic.Assign)]
        CGRect ActiveRegion { get; set; }

		[Export ("orientation", ArgumentSemantic.Assign)]
		UIImageOrientation Orientation { get; set; }

		[Export ("torchState", ArgumentSemantic.Assign)]
		bool TorchState { get; set; }

        [Export("scanCODABAR", ArgumentSemantic.Assign)]
        bool ScanCODABAR { get; set; }

        [Export("scanCODE93", ArgumentSemantic.Assign)]
        bool ScanCODE93 { get; set; }

        [Export("scanGS1Databar", ArgumentSemantic.Assign)]
        bool ScanGS1Databar { get; set; }

        [Export("scanGS1DatabarExpanded", ArgumentSemantic.Assign)]
        bool ScanGS1DatabarExpanded { get; set; }

        [Export("scanPDF417", ArgumentSemantic.Assign)]
        bool ScanPDF417 { get; set; }

        //[Export ("returnBarcode:withInfo:")]
        //void ReturnBarcode (string ean, NSDictionary info);

        //[Export ("hasFlash")]
        //bool FlashEnabled { get; [Bind ("turnFlash:")] set; }



        //[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
        //NSObject WeakDelegate { get; set; }

        //[Wrap ("WeakDelegate")]
        //BarcodePickerControllerDelegate Delegate { get; set; }
	}

    
    
    [BaseType(typeof(UIViewController))]
    interface BarcodePickerController2
    {
        [Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
        IBarcodePickerControllerDelegate Delegate {get;set;}

        [Export("exposureLock", ArgumentSemantic.Assign)]
        bool ExposureLock {get;set;}

        [Export("isFocusing", ArgumentSemantic.Assign)]
        bool IsFocusing {get;}

        [Export("useFrontCamera", ArgumentSemantic.Assign)]
        bool UseFrontCamera {get;set;}

        //
        // Methods
        //
        [Export("canFocus")]
       bool CanFocus();

        [Export("clearResultsSet")]
        void ClearResultsSet();

        
        [Export("doneScanning")]
        void DoneScanning();

        [Export("hasTorch")]
        bool HasTorch();

        [Export("isTorchOn")]
        bool IsTorchOn();

        [Export("pauseScanning")]
        void PauseScanning();

        [Export("prepareToScan")]
        void PrepareToScan();

        [Export("reportUnwantedBarcode:")]
        void ReportUnwantedBarcode(BarcodeResult barcode);

        [Export("requestCameraSnapshot:")]
        void RequestCameraSnapshot(bool stillPictureSized);

        [Export("resumeScanning")]
        void ResumeScanning();

        [Export("startCollectingLocationData")]
        void StartCollectingLocationData();

        [Export("statusUpdated:")]
        void StatusUpdated(NSDictionary status);

        [Export("turnTorch:")]
        void TurnTorch(bool value);
    }
    
}
