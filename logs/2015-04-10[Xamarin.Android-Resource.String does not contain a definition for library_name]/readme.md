# Resource.String does not contain a definition for 'library_name'

*	Xamarin.Forms app
	* Custom Renderer for GetUI (Browser Control/View/Widget)



## Error: Resource.String does not contain a definition for library_name


Xamarin.Studio:

	XamarinAuth/XamarinAuth.Droid/Resources/Resource.Designer.cs(98,98): 
	Error CS0117: 
	`XamarinAuth.Droid.Resource.String' does not contain a definition for `library_name' 
	(CS0117)
	(XamarinAuth.Droid)

Visual Studio:

    Error	9	
    'XamarinAuth.Droid.Resource.String' does not contain a definition for 'library_name'	
    HolisticWare.Auth\samples\XamarinAuth.XamarinForms\XamarinAuth.Droid\Resources\Resource.Designer.cs	31	98	
    XamarinAuth.Droid


## Analysis

1.	searching for library_name 			

	find . -type f | xargs grep "library_name" {} \;

2.	results: [find-grep.txt](find-grep.txt)		


## IDE Data

### Xamarin.Studio

		=== Xamarin Studio ===

		Version 5.9 (build 388)
		Installation UUID: 7f42cd6c-f6c2-47c4-960b-ba19ea98bebf
		Runtime:
			Mono 4.0.0 ((detached/21d849b)
			GTK+ 2.24.23 (Raleigh theme)

			Package version: 400000121

		=== Apple Developer Tools ===

		Xcode 6.3 (7569)
		Build 6D570

		=== Xamarin.iOS ===

		Version: 8.10.0.197 (Business Edition)
		Hash: 4dac6bf
		Branch: master
		Build date: 2015-04-01 21:55:11-0400

		=== Xamarin.Android ===

		Version: 5.1.0.100 (Business Edition)
		Android SDK: /Users/moljac/Library/Developer/Xamarin/android-sdk-mac_x86
			Supported Android versions:
				2.3    (API level 10)
				4.0.3  (API level 15)
				4.1    (API level 16)
				4.2    (API level 17)
				4.3    (API level 18)
				4.4    (API level 19)
				4.4.87 (API level 20)
				5.0    (API level 21)
		Java SDK: /usr
		java version "1.7.0_55"
		Java(TM) SE Runtime Environment (build 1.7.0_55-b13)
		Java HotSpot(TM) 64-Bit Server VM (build 24.55-b03, mixed mode)

		=== Xamarin Android Player ===

		Version: Unknown version
		Location: /Applications/Xamarin Android Player.app

		=== Xamarin.Mac ===

		Not Installed

		=== Build Information ===

		Release ID: 509000388
		Git revision: 027c5efa6f92249fd2e614535965159c0a7c0fe6
		Build date: 2015-04-01 19:12:53-04
		Xamarin addins: a6779639267bbe31df3fd6958be4ecae82665b7e

		=== Operating System ===

		Mac OS X 10.10.3
		Darwin Miljenkos-MacBook-Pro.local 14.3.0 Darwin Kernel Version 14.3.0
		    Mon Mar 23 11:59:05 PDT 2015
		    root:xnu-2782.20.48~5/RELEASE_X86_64 x86_64




### Visual Studio

		Microsoft Visual Studio Ultimate 2013
		Version 12.0.31101.00 Update 4
		Microsoft .NET Framework
		Version 4.6.00007

		Installed Version: Ultimate

		Architecture and Modeling Tools   06181-004-0451047-02069
		Microsoft Architecture and Modeling Tools
		    
		UML® and Unified Modeling Language™ are trademarks or registered trademarks of the Object Management Group, Inc. in the United States and other countries.

		LightSwitch for Visual Studio 2013   06181-004-0451047-02069
		Microsoft LightSwitch for Visual Studio 2013

		Team Explorer for Visual Studio 2013   06181-004-0451047-02069
		Microsoft Team Explorer for Visual Studio 2013

		Visual Basic 2013   06181-004-0451047-02069
		Microsoft Visual Basic 2013

		Visual C# 2013   06181-004-0451047-02069
		Microsoft Visual C# 2013

		Visual C++ 2013   06181-004-0451047-02069
		Microsoft Visual C++ 2013

		Visual F# 2013   06181-004-0451047-02069
		Microsoft Visual F# 2013

		Visual Studio 2013 Code Analysis Spell Checker   06181-004-0451047-02069
		Microsoft® Visual Studio® 2013 Code Analysis Spell Checker

		Portions of International CorrectSpell™ spelling correction system © 1993 by Lernout & Hauspie Speech Products N.V. All rights reserved.

		The American Heritage® Dictionary of the English Language, Third Edition Copyright © 1992 Houghton Mifflin Company. Electronic version licensed from Lernout & Hauspie Speech Products N.V. All rights reserved.

		Windows Phone SDK 8.0 - ENU   06181-004-0451047-02069
		Windows Phone SDK 8.0 - ENU

		ASP.NET and Web Tools   12.4.51016.0
		Microsoft Web Developer Tools contains the following components:
		Support for creating and opening ASP.NET web projects
		Browser Link: A communication channel between Visual Studio and browsers
		Editor extensions for HTML, CSS, and JavaScript
		Page Inspector: Inspection tool for ASP.NET web projects
		Scaffolding: A framework for building and running code generators
		Server Explorer extensions for Microsoft Azure Websites
		Web publishing: Extensions for publishing ASP.NET web projects to hosting providers, on-premises servers, or Microsoft Azure

		ASP.NET Web Frameworks and Tools 2012.2   4.1.21001.0
		For additional information, visit http://go.microsoft.com/fwlink/?LinkID=309563

		ASP.NET Web Frameworks and Tools 2013   5.2.21010.0
		For additional information, visit http://www.asp.net/

		Common Azure Tools   1.3
		Provides common services for use by Azure Mobile Services and Microsoft Azure Tools.

		Microsoft Advertising SDK for Windows Phone   
		Microsoft Advertising SDK for Windows Phone
		Build 

		Microsoft Azure HDInsight HQL Service   2.0.0.0000
		Language service for Hive query

		Microsoft Azure HDInsight Tools for Visual Studio   2.0.0.0000
		An integrated development environment for HDInsight application development.

		Microsoft Azure Mobile Services Tools   1.3
		Microsoft Azure Mobile Services Tools

		Microsoft Azure Tools   2.4
		Microsoft Azure Tools for Microsoft Visual Studio 2013 - v2.4.20730.1601

		Microsoft Azure Tools   2.5
		Microsoft Azure Tools for Microsoft Visual Studio 2013 - v2.5.21104.1601

		NuGet Package Manager   2.8.50926.663
		NuGet Package Manager in Visual Studio. For more information about NuGet, visit http://docs.nuget.org/.

		Office Developer Tools for Visual Studio 2013 ENU   12.0.31105
		Microsoft Office Developer Tools for Visual Studio 2013 ENU

		PowerShell Tools for Visual Studio   1.0
		Information about my package

		PreEmptive Analytics Visualizer   1.2
		Microsoft Visual Studio extension to visualize aggregated summaries from the PreEmptive Analytics product.

		Release Management for Visual Studio Package   1.0
		Release Management for Visual Studio

		SQL Server Data Tools   12.0.50226.0
		Microsoft SQL Server Data Tools

		VSCommands for Visual Studio 2013   12.0
		VSCommands for Visual Studio 2013

		VSPackage1   1.0
		Information about my package

		Web Essentials 2013   2.5.3
		Adds many useful features to Visual Studio for web developers.

		Windows Phone 8.1 SDK Integration   1.0
		This package integrates the tools for the Windows Phone 8.1 SDK into the menus and controls of Visual Studio.

		Workflow Manager Tools 1.0   1.0
		This package contains the necessary Visual Studio integration components for Workflow Manager.

		Xamarin   3.11.271.0 (e36ba35)
		Visual Studio extension to enable development for Xamarin.iOS and Xamarin.Android.

		Xamarin.Android   5.1.0.99 (e81edcfee3152b5892337b8741d8da28f9ee74b1)
		Visual Studio plugin to enable development for Xamarin.Android.

		Xamarin.Forms Intellisense   1.0
		Provides intellisense for Xamarin.Forms in the XML editor.

		Xamarin.iOS   8.10.0.0 (3abf86b113ef9dd7c6aaf53c4c47bdb39ae526b9)
		Visual Studio extension to enable development for Xamarin.iOS.

		Xamarin.iOS Unified Migration   1.0
		Automated migration for Xamarin iOS Classic projects to Unified