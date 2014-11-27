# Podradio Theme linking error

Errors I'm getting:



Unified:

			Undefined symbols for architecture arm64:
			  "_mono_aot_module_PodradioTheme_iOs_info", referenced from:
				  _monotouch_register_modules in main.arm64.o
			ld: symbol(s) not found for architecture arm64
			clang: error: linker command failed with exit code 1 (use -v to see invocation)

			


"Component" - dll/assembly (binary) reference

Classic:

    <Reference Include="monotouch" />
    <Reference Include="PodradioTheme.iOS">
      <HintPath>..\..\lib\ios\PodradioTheme.iOS.dll</HintPath>
    </Reference>

Unified

    <Reference Include="Xamarin.iOS" />
    <Reference Include="PodradioTheme.iOS">
      <HintPath>..\..\lib\ios-unified\PodradioTheme.iOs.dll</HintPath>
    </Reference>


## Testing unpacked (before packaging)

			
1.	Solution Classic			
	samples/PodradioTheme.iOs.Sample/PodradioTheme.iOs.Component-Sample-Classic.sln
	1.	PodradioTheme.iOS.Component-Sample-Classic			
		This is project completely recreated (Project +/ new +/ iOS Unified)
		1.	Debug | Device: 	OK			
		2.	Release | Device: 	OK			
	2.	original-transformed-PodradioTheme.iOS.Component-Sample-Classic			
		This is project transformed from original classic (Project +/ new +/ iOS Unified)
		1.	Debug | Device: 	OK			
		2.	Release | Device: 	OK			
2.	Solution Unified
	samples/PodradioTheme.iOs.Sample/PodradioTheme.iOs.Component-Sample.sln
	1.	PodradioTheme.iOS.Component-Sample
		1.	Debug | Device: 	OK			
		2.	Release | Device: 	OK			
	2.	original-transformed-PodradioTheme.iOS.Component-Sample
		messes with this one a lot during tests 
		1.	Debug | Device: 	compiles, crashes during loading (some image NRE)			
		2.	Release | Device: 	compiles, crashes during loading (some image NRE)			


		
## Testing packed (after packaging)
		
### Solution Unified

podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/PodradioTheme.iOs.Component-Sample.sln

Stable channel:

Project: 

Debug:

		MTOUCHTASK: error MT0000: Unexpected error - Please file a bug report at http://bugzilla.xamarin.com

Release:

	MTOUCHTASK:  warning MT0030: The executable name (PodradioThemeiOSSample) and the app name (PodradioThemeiOSComponentSample.app) are different, this may prevent crash logs from getting symbolicated properly.
			Process exited with code 1, command:
			/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/clang  -Wl,-pie  -arch arm64 -miphoneos-version-min=5.2 -isysroot /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneOS.platform/Developer/SDKs/iPhoneOS8.1.sdk /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/PodradioThemeiOSSample.exe.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/Xamarin.iOS.dll.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/mscorlib.dll.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/System.dll.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/System.Core.dll.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/PodradioTheme.iOs.dll.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/registrar.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/main.arm64.o -o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/64/Output/PodradioThemeiOSSample -framework CoreImage -framework Foundation -framework QuartzCore -framework CoreGraphics -framework UIKit -framework CFNetwork -lz -liconv -u _monotouch_log -u _monotouch_release_managed_ref -u _monotouch_create_managed_ref -u _xamarin_get_block_descriptor /Library/Frameworks/Xamarin.iOS.framework/Versions/8.4.0.43/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libmonosgen-2.0.a /Library/Frameworks/Xamarin.iOS.framework/Versions/8.4.0.43/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libmonotouch-sgen.a /Library/Frameworks/Xamarin.iOS.framework/Versions/8.4.0.43/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libapp.a -dead_strip
			Undefined symbols for architecture arm64:
			  "_mono_aot_module_PodradioTheme_iOs_info", referenced from:
				  _monotouch_register_modules in main.arm64.o
			ld: symbol(s) not found for architecture arm64
			clang: error: linker command failed with exit code 1 (use -v to see invocation)
			
	MTOUCHTASK: error MT0000: Unexpected error - Please file a bug report at http://bugzilla.xamarin.com
			System.NullReferenceException: Object reference not set to an instance of an object
			  at MonoTouch.Target.GetMemberForSymbol (System.String symbol) [0x00000] in <filename unknown>:0 
			  at MonoTouch.Application.GetMemberForSymbol (System.String symbol) [0x00000] in <filename unknown>:0 
			  at MonoTouch.Application.ProcessNativeLinkerOutput (System.String output, IList`1 inputs, System.Collections.Generic.List`1 errors, Boolean error) [0x00000] in <filename unknown>:0 
			  at MonoTouch.Target.NativeLink () [0x00000] in <filename unknown>:0 
			  at MonoTouch.Target.BuildApp () [0x00000] in <filename unknown>:0 
			  at MonoTouch.Application.BuildApp () [0x00000] in <filename unknown>:0 
			  at MonoTouch.Application.Build () [0x00000] in <filename unknown>:0 
			  at MTouch.Main2 (System.String[] args) [0x00000] in <filename unknown>:0 
			  at MTouch.Main (System.String[] args) [0x00000] in <filename unknown>:0 
			Tool /Library/Frameworks/Xamarin.iOS.framework/Versions/Current/bin/mtouch execution finished.
		Task "MTouchTask" execution -- FAILED
		Done building target "_CompileToNative" in project "/Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/PodradioTheme.iOS.Component-Sample.csproj".-- FAILED

	

Alpha channel:

	MTOUCHTASK:  warning MT0030: The executable name (PodradioThemeiOSSample) and the app name (PodradioThemeiOSComponentSample.app) are different, this may prevent crash logs from getting symbolicated properly.
			Process exited with code 1, command:
			/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/clang  -Wl,-pie  -arch arm64 -miphoneos-version-min=5.2 -isysroot /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneOS.platform/Developer/SDKs/iPhoneOS8.1.sdk /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Debug/mtouch-cache/PodradioThemeiOSSample.exe.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Debug/mtouch-cache/mscorlib.dll.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Debug/mtouch-cache/System.dll.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Debug/mtouch-cache/System.Core.dll.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Debug/mtouch-cache/PodradioTheme.iOs.dll.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Debug/mtouch-cache/registrar.arm64.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Debug/mtouch-cache/main.arm64.o -o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Debug/mtouch-cache/64/Output/PodradioThemeiOSSample -framework CoreImage -framework Foundation -framework QuartzCore -framework CoreGraphics -framework UIKit -framework CFNetwork -lz -liconv -u _mono_pmip -u _monotouch_log -u _monotouch_release_managed_ref -u _monotouch_create_managed_ref -u _xamarin_get_block_descriptor /Library/Frameworks/Xamarin.iOS.framework/Versions/8.4.0.43/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libmonosgen-2.0.a /Library/Frameworks/Xamarin.iOS.framework/Versions/8.4.0.43/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libmonotouch-sgen-debug.a /Library/Frameworks/Xamarin.iOS.framework/Versions/8.4.0.43/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libapp.a -dead_strip
			Undefined symbols for architecture arm64:
			  "_mono_aot_module_PodradioTheme_iOs_info", referenced from:
				  _monotouch_register_modules in main.arm64.o
			ld: symbol(s) not found for architecture arm64
			clang: error: linker command failed with exit code 1 (use -v to see invocation)
			
	MTOUCHTASK: error MT0000: Unexpected error - Please file a bug report at http://bugzilla.xamarin.com
			System.NullReferenceException: Object reference not set to an instance of an object
			  at MonoTouch.Target.GetMemberForSymbol (System.String symbol) [0x00000] in <filename unknown>:0 
			  at MonoTouch.Application.GetMemberForSymbol (System.String symbol) [0x00000] in <filename unknown>:0 
			  at MonoTouch.Application.ProcessNativeLinkerOutput (System.String output, IList`1 inputs, System.Collections.Generic.List`1 errors, Boolean error) [0x00000] in <filename unknown>:0 
			  at MonoTouch.Target.NativeLink () [0x00000] in <filename unknown>:0 
			  at MonoTouch.Target.BuildApp () [0x00000] in <filename unknown>:0 
			  at MonoTouch.Application.BuildApp () [0x00000] in <filename unknown>:0 
			  at MonoTouch.Application.Build () [0x00000] in <filename unknown>:0 
			  at MTouch.Main2 (System.String[] args) [0x00000] in <filename unknown>:0 
			  at MTouch.Main (System.String[] args) [0x00000] in <filename unknown>:0 
			Tool /Library/Frameworks/Xamarin.iOS.framework/Versions/Current/bin/mtouch execution finished.
		Task "MTouchTask" execution -- FAILED
		Done building target "_CompileToNative" in project "/Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/PodradioTheme.iOS.Component-Sample.csproj".-- FAILED
	

Stable channel:

Project: original-transformed-PodradioTheme.iOS.Component-Sample

Debug and Release:

	MTOUCHTASK:  warning MT0030: The executable name (PodradioThemeiOSSample) and the app name (originaltransformedPodradioThemeiOSComponentSample.app) are different, this may prevent crash logs from getting symbolicated properly.
			Process exited with code 1, command:
			/Applications/Xcode.app/Contents/Developer/Toolchains/XcodeDefault.xctoolchain/usr/bin/clang  -Wl,-pie  -arch armv7 -miphoneos-version-min=5.2 -isysroot /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneOS.platform/Developer/SDKs/iPhoneOS8.1.sdk /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/PodradioThemeiOSSample.exe.armv7.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/Xamarin.iOS.dll.armv7.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/mscorlib.dll.armv7.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/System.dll.armv7.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/System.Core.dll.armv7.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/PodradioTheme.iOs.dll.armv7.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/registrar.armv7.o /Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/obj/unified/iPhone/Release/mtouch-cache/main.armv7.o -o bin/unified/iPhone/Release/originaltransformedPodradioThemeiOSComponentSample.app/PodradioThemeiOSSample -framework CoreImage -framework Foundation -framework QuartzCore -framework CoreGraphics -framework UIKit -framework CFNetwork -lz -liconv -u _monotouch_log -u _monotouch_release_managed_ref -u _monotouch_create_managed_ref -u _xamarin_get_block_descriptor /Library/Frameworks/Xamarin.iOS.framework/Versions/8.4.0.43/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libmonosgen-2.0.a /Library/Frameworks/Xamarin.iOS.framework/Versions/8.4.0.43/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libmonotouch-sgen.a /Library/Frameworks/Xamarin.iOS.framework/Versions/8.4.0.43/SDKs/MonoTouch.iphoneos.sdk/usr/lib/libapp.a -dead_strip
			Undefined symbols for architecture armv7:
			  "_mono_aot_module_PodradioTheme_iOs_info", referenced from:
				  _monotouch_register_modules in main.armv7.o
			ld: symbol(s) not found for architecture armv7
			clang: error: linker command failed with exit code 1 (use -v to see invocation)
			
	MTOUCHTASK: error MT5210: Native linking failed, undefined symbol: _mono_aot_module_PodradioTheme_iOs_info. Please verify that all the necessary frameworks have been referenced and native libraries are properly linked in.
	MTOUCHTASK: error MT5202: Native linking failed. Please review the build log.
			Tool /Library/Frameworks/Xamarin.iOS.framework/Versions/Current/bin/mtouch execution finished.
		Task "MTouchTask" execution -- FAILED
		Done building target "_CompileToNative" in project "/Users/moljac/Desktop/Xamarin.Test.Toolz/logs/2014-09-28-[component-packaging-ios-native-linking-failed]/c-PodradioTheme/podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample/original-transformed-PodradioTheme.iOS.Component-Sample.csproj".-- FAILED
	

	
	
### Solution Classic

podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample-Classic/PodradioTheme.iOs.Component-Sample-Classic.sln 


Stable Channel:

Project:  original-transformed-PodradioTheme.iOS.Component-Sample-Classic

		Undefined symbols for architecture armv7:
		  "_mono_aot_module_PodradioTheme_iOs_info", referenced from:
			  _monotouch_register_modules in main.armv7.o
		ld: symbol(s) not found for architecture armv7
		clang: error: linker command failed with exit code 1 (use -v to see invocation)

Note: this project compiles before packing

		
Project: PodradioTheme.iOS.Component-Sample-Classic (Debug | Device) and (Release | Device)

	Undefined symbols for architecture armv7:
	  "_mono_aot_module_PodradioTheme_iOs_info", referenced from:
		  _monotouch_register_modules in main.armv7.o
	ld: symbol(s) not found for architecture armv7
	clang: error: linker command failed with exit code 1 (use -v to see invocation)

	error MT5210: Native linking failed, undefined symbol: _mono_aot_module_PodradioTheme_iOs_info. 
	Please verify that all the necessary frameworks have been referenced and native libraries are 
	properly linked in.
	error MT5202: Native linking failed. Please review the build log.

	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	

## Analysis

Comparing 2 projects after and before xamarin-component transformation 

*	shows only whitespace changes
*	played with whitespace/tab options at the end -E -b -w


diff \
	./podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample-Classic/PodradioTheme.iOS.Component-Sample-Classic.csproj \
	./samples/PodradioTheme.iOs.Sample/PodradioTheme.iOS.Component-Sample-Classic.csproj \
	-w 

Folder structure:

* 	component sample after packaging does not contain .dSym folder (debug information)


Unpacked after component packaging:

	ls -al \
		podradiotheme-1.1/samples/PodradioTheme.iOs.Component-Sample-Classic/bin/classic/iPhone/Release/
	
	drwxr-xr-x    5 moljac  staff      170 Nov 26 12:50 .
	drwxr-xr-x    4 moljac  staff      136 Nov 26 12:50 ..
	-rwxr-xr-x    1 moljac  staff  5531648 Nov 26 11:32 PodradioTheme.iOS.dll
	drwxr-xr-x  103 moljac  staff     3502 Nov 26 12:50 PodradioThemeiOSComponentSampleClassic.app
	-rwxr-xr-x    1 moljac  staff    19456 Nov 26 12:50 PodradioThemeiOSSample.exe

Before packaging

	ls -al \
		samples/PodradioTheme.iOs.Sample/bin/classic/iPhone/Release	
	