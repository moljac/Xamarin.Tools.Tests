# metadata.xml Xpath expression with unmatched parentheses/brackets crash generator.exe

## Problem

Xpath expression with unmatched parentheses/brackets like

	path="/api/package[[@name='com.samsung.sdk']"
	path="/api/package[[@name='com.samsung.sdk']]"

results:

*	crashes generator.exe in Visual Studio 2012
*	3 errors in Xamarin Studio, but no crash

## Cause

## Workaround 

## Details

### Xamarin Studio errors

	MonoDroid.Generation.BindingGeneratorException: 
	Error BG4301: Invalid XPath specification: /api/package[[@name='com.samsung.sdk'] (BG4301) (BindingLibrary1)

	Error BG4301: Invalid XPath specification: /api/package[[@name='com.samsung.sdk'] (BG4301) (BindingLibrary1)

	[ERROR] FATAL UNHANDLED EXCEPTION: MonoDroid.Generation.BindingGeneratorException: 
	Error BG4301: Invalid XPath specification: /api/package[[@name='com.samsung.sdk'] 
	

	
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

