using System;
using ObjCRuntime;
using Foundation;

[assembly: LinkWith ("libRedLaserSDK_arm64.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, 
	Frameworks = "AudioToolbox AVFoundation CFNetwork CoreMedia CoreVideo OpenGLES Security SystemConfiguration CoreLocation", 
	ForceLoad = true,  IsCxx = true, LinkerFlags = "-lstdc++ -lz")]//LinkerFlags = "-lstdc++")]

