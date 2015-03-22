//
// extra.cs
//
// Authors:
//  Chris Hardy (chrisntr@xamarin.com)
//
// Copyright 2011 Xamarin Inc.
//

using System;
using System.Runtime.InteropServices;

using Foundation;
using UIKit;

namespace Ebay.RedLaser
{
//	public partial class RedLaser : NSObject
//	{
//		[DllImport ("__Internal")]
//		extern static IntPtr RL_GetRedLaserSDKVersion ();
//
//		public static string SdkVersion {
//			get 
//			{
//				string val = Marshal.PtrToStringAuto (RL_GetRedLaserSDKVersion ());
//				return (string) new NSString (val);
//			}
//		}
//
//		[DllImport ("__Internal")]
//		extern static RedLaserStatus RL_CheckReadyStatus ();
//
//		public static RedLaserStatus CheckReadyStatus ()
//		{
//			return RL_CheckReadyStatus();
//		}
//
//		[DllImport ("__Internal")]
//		extern static IntPtr FindBarcodesInUIImage (IntPtr inputImage);
//
//		public static BarcodeResult[] FindBarcodes (UIImage image)
//		{
//			if (image == null)
//				throw new ArgumentNullException ("image");
//
//			IntPtr result = FindBarcodesInUIImage (image.Handle);
//			if (result == IntPtr.Zero)
//				return null;
//
//			NSSet aset = new NSSet (result);
//			BarcodeResult[] results = aset.ToArray<BarcodeResult> ();
//			aset.Dispose ();
//
//			return results;
//		}
//	}
}
