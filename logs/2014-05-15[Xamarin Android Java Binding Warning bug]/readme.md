# Java binding warning about hiding inherited member in Visual Studio and error in Xamarin Studio

## Visual Studio

After cleaning errors and warnings - remaining warning:

  'SamsungSDK.Accessory.API.DeathCallbackStub.OnTransact(int, Android.OS.Parcel, Android.OS.Parcel, int)' 
  hides inherited member 'Android.OS.Binder.OnTransact(int, Android.OS.Parcel, Android.OS.Parcel, int)'. 
  To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.	


## Xamarin Studio

*	Building in VS and doing only build in XS - no error
*	rebuilding in XS error

Metadata.xml can be empty - always the same result 15 warnings and 1 error (very long
error with JARTOXML warnings).

At the end suspicious error:

Exception in thread "main" java.lang.ClassFormatError:
StackMapTable format error: access beyond the end of attribute


Error content:

	/Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Android/Xamarin.Android.Bindings.targets: Error: Tool exited with code: 1. Output: java.lang.ArrayIndexOutOfBoundsException: 12
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/ISAFrameworkManager$Stub : java.lang.ArrayIndexOutOfBoundsException: 12
	java.lang.ArrayIndexOutOfBoundsException: 3
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/SAAdapter$1 : java.lang.ArrayIndexOutOfBoundsException: 3
	java.lang.ArrayIndexOutOfBoundsException: 7
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/SAAdapter$CapexReceiver : java.lang.ArrayIndexOutOfBoundsException: 7
	java.lang.ArrayIndexOutOfBoundsException: 3
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/SAAdapter$ConnectionReceiver : java.lang.ArrayIndexOutOfBoundsException: 3
	java.lang.ArrayIndexOutOfBoundsException: 6
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/SAAdapter$IncrUpdateReceiver : java.lang.ArrayIndexOutOfBoundsException: 6
	java.lang.ArrayIndexOutOfBoundsException: 5
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/SAAdapter : java.lang.ArrayIndexOutOfBoundsException: 5
	java.lang.ArrayIndexOutOfBoundsException: 2
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/f : java.lang.ArrayIndexOutOfBoundsException: 2
	java.lang.ArrayIndexOutOfBoundsException: 3
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1894)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/SAServiceChannel$EventCallBackResultReceiver : java.lang.ArrayIndexOutOfBoundsException: 3
	java.lang.NoClassDefFoundError: com/samsung/android/sdk/SsdkInterface
	at java.lang.ClassLoader.defineClass1(Native Method)
	at java.lang.ClassLoader.defineClass(ClassLoader.java:760)
	at java.security.SecureClassLoader.defineClass(SecureClassLoader.java:142)
	at java.net.URLClassLoader.defineClass(URLClassLoader.java:455)
	at java.net.URLClassLoader.access$100(URLClassLoader.java:73)
	at java.net.URLClassLoader$1.run(URLClassLoader.java:367)
	at java.net.URLClassLoader$1.run(URLClassLoader.java:361)
	at java.security.AccessController.doPrivileged(Native Method)
	at java.net.URLClassLoader.findClass(URLClassLoader.java:360)
	at java.lang.ClassLoader.loadClass(ClassLoader.java:424)
	at java.lang.ClassLoader.loadClass(ClassLoader.java:357)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:86)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	Caused by: java.lang.ClassNotFoundException: com.samsung.android.sdk.SsdkInterface
	at java.net.URLClassLoader$1.run(URLClassLoader.java:372)
	at java.net.URLClassLoader$1.run(URLClassLoader.java:361)
	at java.security.AccessController.doPrivileged(Native Method)
	at java.net.URLClassLoader.findClass(URLClassLoader.java:360)
	at java.lang.ClassLoader.loadClass(ClassLoader.java:424)
	at java.lang.ClassLoader.loadClass(ClassLoader.java:357)
	... 14 more
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/SA : java.lang.NoClassDefFoundError: com/samsung/android/sdk/SsdkInterface
	java.lang.ArrayIndexOutOfBoundsException: 3
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1894)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/SAAgent$4 : java.lang.ArrayIndexOutOfBoundsException: 3
	java.lang.ArrayIndexOutOfBoundsException: 5
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/SAAgent : java.lang.ArrayIndexOutOfBoundsException: 5
	java.lang.ArrayIndexOutOfBoundsException: 2
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/c : java.lang.ArrayIndexOutOfBoundsException: 2
	java.lang.ArrayIndexOutOfBoundsException: 3
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/SASocket$a : java.lang.ArrayIndexOutOfBoundsException: 3
	java.lang.ArrayIndexOutOfBoundsException: 14
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/SASocket : java.lang.ArrayIndexOutOfBoundsException: 14
	java.lang.ArrayIndexOutOfBoundsException: 6
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/ServiceConnectionIndicationBroadcastReceiver : java.lang.ArrayIndexOutOfBoundsException: 6
	Exception in thread "main" java.lang.ClassFormatError: StackMapTable format error: access beyond the end of attribute
	at java.lang.Class.getDeclaredConstructors0(Native Method)
	at java.lang.Class.privateGetDeclaredConstructors(Class.java:2658)
	at java.lang.Class.getDeclaredConstructors(Class.java:2007)
	at jar2xml.JavaClass.doAppendToDocument(JavaClass.java:627)
	at jar2xml.JavaClass.appendToDocument(JavaClass.java:559)
	at jar2xml.JavaPackage.appendToDocument(JavaPackage.java:72)
	at jar2xml.Start.main(Start.java:127)
	(BindingLibrary1)




## Links

### Couldn't load class java.lang.ArrayIndexOutOfBoundsException

*	[https://forums.xamarin.com/discussion/973/problems-binding-jar](https://forums.xamarin.com/discussion/973/problems-binding-jar)
*	[https://forums.xamarin.com/discussion/5781/arrayindexoutofbounds-java-binding](https://forums.xamarin.com/discussion/5781/arrayindexoutofbounds-java-binding)
*	bunch of java related issues (reports, bounties etc)


## Version Info

### Xamarin Studio Information

	=== Xamarin Studio ===

	Version 5.0 (build 866)
	Installation UUID: 7f42cd6c-f6c2-47c4-960b-ba19ea98bebf
	Runtime:
		Mono 3.4.0 ((no/c3fc3ba)
		GTK+ 2.24.23 (Raleigh theme)

		Package version: 304000204

	=== Apple Developer Tools ===

	Xcode 5.1.1 (5085)
	Build 5B1008

	=== Xamarin.iOS ===

	Version: 7.2.3.35 (Business Edition)
	Hash: 9e24c88
	Branch: 
	Build date: 2014-05-12 19:42:16-0400

	=== Xamarin.Android ===

	Version: 4.12.4 (Business Edition)
	Android SDK: /Users/user/Downloads/adt-bundle-mac-x86_64-20131030/sdk
		Supported Android versions:
			1.6   (API level 4)
			2.1   (API level 7)
			2.2   (API level 8)
			2.3   (API level 10)
			3.1   (API level 12)
			3.2   (API level 13)
			4.0   (API level 14)
			4.0.3 (API level 15)
			4.1   (API level 16)
			4.2   (API level 17)
			4.3   (API level 18)
			4.4   (API level 19)
	Java SDK: /usr
	java version "1.8.0_05"
	Java(TM) SE Runtime Environment (build 1.8.0_05-b13)
	Java HotSpot(TM) 64-Bit Server VM (build 25.5-b02, mixed mode)

	=== Xamarin.Mac ===

	Xamarin.Mac: Not Installed

	=== Build Information ===

	Release ID: 500000866
	Git revision: 89cfcdd28a9a64d4ddc606f8c4f8e6aaafad610a
	Build date: 2014-05-12 14:59:13-04
	Xamarin addins: e92a35a9280dede5cbdceaaec0c40c06c163546e

	=== Operating System ===

	Mac OS X 10.9.2
	Darwin miljenkos-mbp 13.1.0 Darwin Kernel Version 13.1.0
		Wed Apr  2 23:52:02 PDT 2014
		root:xnu-2422.92.1~2/RELEASE_X86_64 x86_64

		
### Visual Studio Info

	Microsoft Visual Studio Ultimate 2012
	Version 11.0.61030.00 Update 4
	Microsoft .NET Framework
	Version 4.5.50938

	Installed Version: Ultimate

	Architecture and Modeling Tools   04940-004-0038003-02864
	Microsoft Architecture and Modeling Tools
		
	UML® and Unified Modeling Language™ are trademarks or registered trademarks of the Object Management Group, Inc. in the United States and other countries.

	LightSwitch for Visual Studio 2012   04940-004-0038003-02864
	Microsoft LightSwitch for Visual Studio 2012

	Office Developer Tools   04940-004-0038003-02864
	Microsoft Office Developer Tools

	Team Explorer for Visual Studio 2012   04940-004-0038003-02864
	Microsoft Team Explorer for Visual Studio 2012

	Visual Basic 2012   04940-004-0038003-02864
	Microsoft Visual Basic 2012

	Visual C# 2012   04940-004-0038003-02864
	Microsoft Visual C# 2012

	Visual C++ 2012   04940-004-0038003-02864
	Microsoft Visual C++ 2012

	Visual F# 2012   04940-004-0038003-02864
	Microsoft Visual F# 2012

	Visual Studio 2012 Code Analysis Spell Checker   04940-004-0038003-02864
	Microsoft® Visual Studio® 2012 Code Analysis Spell Checker


	Git Source Control Provider   1.0.0.0


	Microsoft Practices Project Linker   1.0
	Microsoft patterns & practices project linker

	NuGet Package Manager   2.8.50313.31
	NuGet Package Manager in Visual Studio. For more information about NuGet, visit http://docs.nuget.org/.


	Xamarin for Visual Studio   2.0.100.0 (f93045f440e07b63a01af7fc1937e1fb9698461e)
	Visual Studio extension to enable development for Xamarin.iOS and Xamarin.Android

	Xamarin.Android   4.12.4.12 (5e0ae4045013640a02bc8389e24ba654a3feb546)
	Visual Studio plugin to enable development for Xamarin.Android.

	Xamarin.iOS   2.0.100.0 (f93045f440e07b63a01af7fc1937e1fb9698461e)
	Visual Studio extension to enable development for Xamarin.iOS



