# Xamarin.Android Bindings Generator class-parse not generating [static] method[s]

Case where jar2xml does not generate output and class-parse generates C# class,
but misses some [static] methods.


*   jar2xml 
    *   does not surface class - IPMessagingClient
    *   workaround      
        Metadata.add-node.IPMessagingClient.xml
    *   steps to test 
        *   turn on jar2xml generator in Twilio.IPMessaging.Android.csproj      
            by commenting out:          
            *   <AndroidClassParser>class-parse</AndroidClassParser>
        *   set BuildAction to None for         
            Metadata.add-node.IPMessagingClient.xml
        *   delete nuke bin/ and obj/ folders
        *   compile
        *   result -  6 errors - missing IPMessagingClient
*   class-parse
    does emit IPMessagingClient, but misses some methods
    *   steps to test 
        *   turn on class-parse generator in Twilio.IPMessaging.Android.csproj      
            by adding:          
            *   <AndroidClassParser>class-parse</AndroidClassParser>
        *   set BuildAction to None for         
            Metadata.add-node.IPMessagingClient.xml
        *   IPMessagingClient is generated api.xml line 2321
        *   IPMessagingClient.create method is generated in api.xml 2329
        *   IPMessagingClient.Create method is not generated in:        
            ./obj/Debug/generated/src/Twilio.IPMessaging.IPMessagingClient.cs

			
## System Environment

### Mac OS X 10.11.6 + Xamarin.Studio 6.1

	=== Xamarin Studio Community ===

	Version 6.1 (build 5441)
	Installation UUID: b6f79059-4277-41e4-bd3b-d2384db0ee80
	Runtime:
		Mono 4.6.0 (mono-4.6.0-branch/746756c) (64-bit)
		GTK+ 2.24.23 (Raleigh theme)

		Package version: 406000245

	=== NuGet ===

	Version: 3.4.3.0

	=== Xamarin.Profiler ===

	Not Installed

	=== Apple Developer Tools ===

	Xcode 8.0 (11246)
	Build 8A218a

	=== Xamarin.iOS ===

	Version: 10.0.0.6 (Xamarin Studio Community)
	Hash: 6c3fee4
	Branch: xcode8
	Build date: 2016-09-09 13:01:32-0400

	=== Xamarin.Android ===

	Version: 7.0.0.18 (Xamarin Studio Community)
	Android SDK: /Users/moljac/Library/Developer/Xamarin/android-sdk-macosx
		Supported Android versions:
			2.3    (API level 10)
			4.0.3  (API level 15)
			4.1    (API level 16)
			4.2    (API level 17)
			4.3    (API level 18)
			4.4    (API level 19)
			4.4.87 (API level 20)
			5.0    (API level 21)
			5.1    (API level 22)
			6.0    (API level 23)
			7.0    (API level 24)

	SDK Tools Version: 25.1.7
	SDK Platform Tools Version: 24.0.1
	SDK Build Tools Version: 24.0.1

	Java SDK: /usr
	java version "1.8.0_91"
	Java(TM) SE Runtime Environment (build 1.8.0_91-b14)
	Java HotSpot(TM) 64-Bit Server VM (build 25.91-b14, mixed mode)

	Android Designer EPL code available here:
	https://github.com/xamarin/AndroidDesigner.EPL

	=== Xamarin Android Player ===

	Version: 0.6.5
	Location: /Applications/Xamarin Android Player.app

	=== Xamarin.Mac ===

	Version: 2.10.0.99 (Xamarin Studio Community)

	=== Xamarin Inspector ===

	Version: 0.10.0.0
	Hash: e931a52
	Branch: master
	Build date: Thu, 18 Aug 2016 17:46:46 GMT

	=== Build Information ===

	Release ID: 601005441
	Git revision: 68292d1ab289911c815ddc715dd7cc29a9752f9f
	Build date: 2016-09-09 04:43:23-04
	Xamarin addins: ed25d008672663eeb9db55f1ccecb3c24d2fd3b2
	Build lane: monodevelop-lion-cycle8

	=== Operating System ===

	Mac OS X 10.11.6
	Darwin Miljenkos-MBP 15.6.0 Darwin Kernel Version 15.6.0
		Mon Aug 29 20:21:34 PDT 2016
		root:xnu-3248.60.11~1/RELEASE_X86_64 x86_64

	=== Enabled user installed addins ===

	Xamarin Inspector 0.10.0.0


### Windows 10 Pro Viusal Studio 2015 Community

	Microsoft Visual Studio Community 2015
	Version 14.0.25431.01 Update 3
	Microsoft .NET Framework
	Version 4.6.01586

	Installed Version: Community

	Visual Basic 2015   00322-20000-00000-AA901
	Microsoft Visual Basic 2015

	Visual C# 2015   00322-20000-00000-AA901
	Microsoft Visual C# 2015

	Visual C++ 2015   00322-20000-00000-AA901
	Microsoft Visual C++ 2015

	Application Insights Tools for Visual Studio Package   7.7.10922.3
	Application Insights Tools for Visual Studio

	ASP.NET and Web Tools 2015.1   14.1.20907.0
	ASP.NET and Web Tools 2015.1

	ASP.NET Web Frameworks and Tools 2012.2   4.1.41102.0
	For additional information, visit http://go.microsoft.com/fwlink/?LinkID=309563

	ASP.NET Web Frameworks and Tools 2013   5.2.40314.0
	For additional information, visit http://www.asp.net/

	Azure App Service Tools v2.9.5   14.0.20810.0
	Azure App Service Tools v2.9.5

	Azure Data Lake Node   1.0
	This package contains the Data Lake integration nodes for Server Explorer.

	Azure Data Lake Tools for Visual Studio   2.1.0000.0
	Microsoft Azure Data Lake Tools for Visual Studio

	Command Bus, Event Stream and Async Manager   Merq
	Provides ICommandBus, IEventStream and IAsyncManager MEF services for loosely coupled Visual Studio extension components communication and integration.

	Common Azure Tools   1.8
	Provides common services for use by Azure Mobile Services and Microsoft Azure Tools.

	JavaScript Language Service   2.0
	JavaScript Language Service

	JavaScript Project System   2.0
	JavaScript Project System

	Microsoft .NET Core Tools (Preview 2)   14.1.20907.0
	Microsoft .NET Core Tools (Preview 2)

	Microsoft Azure Hive Query Language Service   2.1.0000.0
	Language service for Hive query

	Microsoft Azure Mobile Services Tools   1.4
	Microsoft Azure Mobile Services Tools

	Microsoft Azure Tools   2.9
	Microsoft Azure Tools for Microsoft Visual Studio 2015 - v2.9.40715.2

	NuGet Package Manager   3.5.0
	NuGet Package Manager in Visual Studio. For more information about NuGet, visit http://docs.nuget.org/.

	PreEmptive Analytics Visualizer   1.2
	Microsoft Visual Studio extension to visualize aggregated summaries from the PreEmptive Analytics product.

	SQL Server Data Tools   14.0.60519.0
	Microsoft SQL Server Data Tools

	ToolWindowHostedEditor   1.0
	Hosting json editor into a tool window

	TypeScript   1.8.36.0
	TypeScript tools for Visual Studio

	Xamarin   4.2.0.680 (c4382f5)
	Visual Studio extension to enable development for Xamarin.iOS and Xamarin.Android.

	Xamarin Inspector Support   0.10.0.0 (e931a52)
	Adds support for inspecting Xamarin and WPF apps.

	Xamarin.Android   7.0.0.18 (0e59c36)
	Visual Studio extension to enable development for Xamarin.Android.

	Xamarin.iOS   10.0.0.6 (6c3fee4)
	Visual Studio extension to enable development for Xamarin.iOS.			