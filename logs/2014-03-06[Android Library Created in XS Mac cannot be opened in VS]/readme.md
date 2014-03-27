# XS Android library projects cannot be opened in VS


This used to be case with Android apps created in XS - they cannot be opened in VS.

## Upgrade


	Unsupported
	This version of Visual Studio does not have the following project types installed or does 
	not support them. You can still open these projects in the version of Visual Studio in which 
	they were originally created.
		- AndroidLibraryProject, 
		"\\vmware-host\Shared Folders\Desktop\Xamarin.Test.Toolz\logs\2014-03-06[Android Library Created in XS Mac cannot be opened in VS]\AndroidLibraryProject\AndroidLibraryProject.csproj"
	
	
	No changes required
	These projects can be opened in this version of Visual Studio without changing them. They 
	will continue to open in Visual Studio 2010 SP1 and in this version of Visual Studio.
		- New Microsoft Visual Studio Solution, 
		"\\vmware-host\Shared Folders\Desktop\Xamarin.Test.Toolz\logs\2014-03-06[Android Library Created in XS Mac cannot be opened in VS]\New Microsoft Visual Studio Solution.sln"
	

## Workaround / possible cause

Original projects created by XS 4.3.3

1. 	AndroidHoneycombApplication		
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{F278D4AB-4730-4720-B08E-FE5E31564D9E};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>		
2. 	AndroidApplication		
    <ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{F278D4AB-4730-4720-B08E-FE5E31564D9E};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>	
3.	AndroidLibraryProject
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{F278D4AB-4730-4720-B08E-FE5E31564D9E};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
4. 	AndroidjavaBindingLibrary		
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{10368E6C-D01B-4462-8E8B-01FC667A7035};{F278D4AB-4730-4720-B08E-FE5E31564D9E};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>		 
5.	AndroidUnitTestproject
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{F278D4AB-4730-4720-B08E-FE5E31564D9E};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
6.	AndroidOpenGLApplication
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{F278D4AB-4730-4720-B08E-FE5E31564D9E};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
7. AndroidIceCreamSandwichApplication
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{F278D4AB-4730-4720-B08E-FE5E31564D9E};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
8. AndroidWebViewApplication
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{F278D4AB-4730-4720-B08E-FE5E31564D9E};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>

	
Removing {F278D4AB-4730-4720-B08E-FE5E31564D9E} projects can be opened

1. 	AndroidHoneycombApplication		
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>		
2. 	AndroidApplication		
    <ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>	
3.	AndroidLibraryProject
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
4. 	AndroidjavaBindingLibrary		
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{10368E6C-D01B-4462-8E8B-01FC667A7035};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>		 
5.	AndroidUnitTestproject
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
6.	AndroidOpenGLApplication
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
7. AndroidIceCreamSandwichApplication
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
8. AndroidWebViewApplication
	<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
	
	
Removing {F278D4AB-4730-4720-B08E-FE5E31564D9E}

Bug report:
[https://bugzilla.xamarin.com/show_bug.cgi?id=16717](https://bugzilla.xamarin.com/show_bug.cgi?id=16717)





## Environment


	=== Xamarin Studio ===
	
	Version 4.3.3 (build 2)
	Installation UUID: 7f42cd6c-f6c2-47c4-960b-ba19ea98bebf
	Runtime:
		Mono 3.2.7 ((no/40f92d5)
		GTK+ 2.24.23 (Raleigh theme)
	
		Package version: 302070000
	
	=== Apple Developer Tools ===
	
	Xcode 5.0.2 (3335.32)
	Build 5A3005
	
	=== Xamarin.Mac ===
	
	Xamarin.Mac: Not Installed
	
	=== Xamarin.Android ===
	
	Version: 4.12.1 (Business Edition)
	Android SDK: /Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk
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
	java version "1.6.0_65"
	Java(TM) SE Runtime Environment (build 1.6.0_65-b14-462-11M4609)
	Java HotSpot(TM) 64-Bit Server VM (build 20.65-b04-462, mixed mode)
	
	=== Xamarin.iOS ===
	
	Version: 7.0.6.168 (Business Edition)
	Hash: 2ed9bc9
	Branch: 
	Build date: 2014-21-01 06:33:05-0500
	
	=== Build Information ===
	
	Release ID: 403030002
	Git revision: 89301538d2f1e41888247489294fdb08a6888119
	Build date: 2014-02-23 23:26:23-05
	Xamarin addins: 21512f84ba13e6f7264bb24d505927e2b302c81c
	
	=== Operating System ===
	
	Mac OS X 10.9.2
	Darwin miljenkos-mbp 13.1.0 Darwin Kernel Version 13.1.0
		Thu Jan 16 19:40:37 PST 2014
		root:xnu-2422.90.20~2/RELEASE_X86_64 x86_64
	
	