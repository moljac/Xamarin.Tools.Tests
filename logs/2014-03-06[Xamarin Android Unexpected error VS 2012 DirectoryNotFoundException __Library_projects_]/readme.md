# VS 2012 DirectoryNotFoundException: Debug\__Library_projects_

Exception during Android project building. Either long paths (VMWare fusion shared folder) or 
permissions.

In the root of the disk (d:\) and short folder - no error.


## Exception
	
obj\Debug\__library_projects__\Pinterest.SDK.BindingLibrary.XamarinAndroid\library_project_imports\Pinterest.SDK.BindingLibrary.XamarinAndroid.Jars.pinit-sdk-1.0.jar


	Error	30	
		Could not find a part of the path 'Pinterest.SDK.BindingLibrary.XamarinAndroid.Jars.pinit-sdk-1.0.jar'.	
		C:\Program Files (x86)\MSBuild\Xamarin\Android\Xamarin.Android.Common.targets	1479	2	
		Pinterest.App.XamarinAndroid
	Error	31	
		Unexpected error - Please file a bug report at http://bugzilla.xamarin.com. 
		Reason: System.IO.DirectoryNotFoundException: Could not find a part of the path 
		"\\vmware-host\Shared Folders\Projects\Xamarin\components\Pinterest\samples\Pinterest.App.XamarinAndroid\obj\Debug\__library_projects__\Pinterest.SDK.BindingLibrary.XamarinAndroid\library_project_imports\Pinterest.SDK.BindingLibrary.XamarinAndroid.Jars.pinit-sdk-1.0.jar"	C:\Program Files (x86)\MSBuild\Xamarin\Android\Xamarin.Android.Common.targets	640	2	
		Pinterest.App.XamarinAndroid
	
		
## Isolated test


	Error	29	
		Unexpected error - Please file a bug report at http://bugzilla.xamarin.com. 
		Reason: System.IO.DirectoryNotFoundException: Could not find a part of the path 
		"\\vmware-host\Shared Folders\Desktop\Xamarin.Test.Toolz\logs\2014-03-06[Xamarin Android Unexpected error]\Pinterest.App.XamarinAndroid\obj\Debug\__library_projects__\Pinterest.SDK.BindingLibrary.XamarinAndroid\library_project_imports\Pinterest.SDK.BindingLibrary.XamarinAndroid.Jars.pinit-sdk-1.0.jar"	C:\Program Files (x86)\MSBuild\Xamarin\Android\Xamarin.Android.Common.targets	640	2	
		Pinterest.App.XamarinAndroid

		
		
		
		
		
## Environment data
		
		
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
	
	Portions of International CorrectSpell™ spelling correction system © 1993 by Lernout & Hauspie Speech Products N.V. All rights reserved.
	
	The American Heritage® Dictionary of the English Language, Third Edition Copyright © 1992 Houghton Mifflin Company. Electronic version licensed from Lernout & Hauspie Speech Products N.V. All rights reserved.
	
	Visual Studio 2012 SharePoint Developer Tools   04940-004-0038003-02864
	Microsoft Visual Studio 2012 SharePoint Developer Tools
	
	AlignAssignments   1.0
	Command for aligning assignments.
	
	AnkhSVN - Subversion Support for Visual Studio   2.5.12266.473
	AnkhSVN - Subversion Support for Visual Studio 2.5.12266.473 
	* Ankh.Package 2.5.12266.473
	* Subversion 1.8.4 via SharpSvn 1.8004.2605.15365
	
	SharpSvn is linked to: Apr 1.4.8, Apr-util 1.5.2, Cyrus Sasl 2.1.23, OpenSSL 1.0.1e 11 Feb 2013, serf 1.3.2, SQLite 3.7.17, Subversion 1.8.4-SharpSvn-1.8.4, ZLib 1.2.8
	SharpSvn is optionally linked to: Berkeley DB 4.4.20, SharpPlink 1.8004.2605.15365
	
	ASP.NET and Web Tools   2013.1.41108
	Microsoft Web Developer Tools contains the following components:
	Support for creating and opening ASP.NET web projects
	Browser Link: A communication channel between Visual Studio and browsers
	Editor extensions for HTML, CSS, and JavaScript
	Page Inspector: Inspection tool for ASP.NET web projects
	Scaffolding: A framework for building and running code generators
	Server Explorer extensions for Windows Azure Web Sites
	Web publishing: Extensions for publishing ASP.NET web projects to hosting providers, on-premises servers, or Windows Azure
	
	ASP.NET Web Frameworks and Tools 2013.1   5.0.11113.0
	For additional information, visit http://www.asp.net/
	
	AutoBraceComplete   1.0
	auto brace complete
	
	CustomDocWell   1.0
	Provides configurable behavior for the document well in Visual Studio 2012.
	
	Git Source Control Provider   1.0.0.0
	
	
	Microsoft Practices Project Linker   1.0
	Microsoft patterns & practices project linker
	
	NuGet Package Manager   2.8.50126.400
	NuGet Package Manager in Visual Studio. For more information about NuGet, visit http://docs.nuget.org/.
	
	OptionsPageImpl   1.0
	Information about my package
	
	PowerCommands for Visual Studio 2010   1.0
	A set of power commands for Visual Studio 2010
	
	PreEmptive Analytics Visualizer   1.0
	Microsoft Visual Studio extension to visualize aggregated summaries from the PreEmptive Analytics product.
	
	Quick Launch Tasks   1.0
	Microsoft Quick LaunchTasks package adds accessibility and settings tasks to the Quick Launch tool.
	
	SQL Server Data Tools   11.1.20627.00
	Microsoft SQL Server Data Tools
	
	Visual Studio 11 Editor Extension   1.0
	Information about my package
	
	VSCommands11   12.0
	VSCommands 11
	
	VSPackage1   1.0
	Information about my package
	
	Xamarin.Android   4.12.00028 (98634deb)
	Visual Studio plugin to enable development for Xamarin.Android.
	
	Xamarin.iOS   1.10.39 (e0334707)
	Visual Studio extension to enable development for Xamarin.iOS
	
	XamlSpyPowerTools   1.0
	XAML Spy Power Tools for Visual Studio
	
	VisualStudio2012AddIn - No Name provided.
	For more information about , see the  website at
	http://holisticware.net
	For customer support, call +385 1 777 5555.
	Copyright (c) 2014  Inc.
		