# Android Application created on MacOSX cannot be opened in Visual Studio

Android Application creation in XS on Mac and Windows shows that project has different
ProjectType GUIDs - actually different number of GUIDs.

## Symptoms of the issue

Android Application Project created in XS on MacOSX

*	cannot be opened in VS (2010, 2012)		
	VS tries to convert project
*	cann be opened in XS@Windows

Exception:

	Unsupported		
	This version of Visual Studio does not have the following project types installed or does not support them. You can still open these projects in the version of Visual Studio in which they were originally created.		
	 - AndroidApp.XS_4_3_0_XA_4_10_1_MacOSX, "D:\Xamarin.Test.Toolz\logs\2013-10-28[Xamarin.Android application project created in XS.mac cannot be opened in VS]\AndroidApp.XS_4_3_0_XA_4_10_1_MacOSX\AndroidApp.XS_4_3_0_XA_4_10_1_MacOSX.csproj"		
			
	No changes required				
	These projects can be opened in this version of Visual Studio without changing them. They will continue to open in Visual Studio 2010 SP1 and in this version of Visual Studio.		
	- New Microsoft Visual Studio Solution, "D:\Xamarin.Test.Toolz\logs\2013-10-28[Xamarin.Android application project created in XS.mac cannot be opened in VS]\New Microsoft Visual Studio Solution.sln"


### Screenshots

* ![](url "Visual Studio message")
* ![](https://raw.github.com/moljac/Xamarin.Test.Toolz/master/logs/2013-10-28%5BXamarin.Android%20application%20project%20created%20in%20XS.mac%20cannot%20be%20opened%20in%20VS%5D/screenshots/VS2010%5D.png "Visual Studio Soluton")


### IDE Data

#### XS MacOSX

#### XS Windows 7

	=== Xamarin Studio ===

	Version 4.2 (build 2)
	Installation UUID: 592b4009-4f3b-45a2-b03b-78ea92b1608b
	Runtime:
		Microsoft .NET 4.0.30319.18052
		GTK+ 2.24.20 theme: MS-Windows
		GTK# (2.12.0.0)

	=== Xamarin.Android ===

	Version: 4.10.1 (Starter Edition)
	Android SDK: C:\Program Files (x86)\Android\android-sdk
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
	Java SDK: C:\Program Files\Java\jdk1.7.0_40
	java version "1.7.0_40"
	Java(TM) SE Runtime Environment (build 1.7.0_40-b43)
	Java HotSpot(TM) 64-Bit Server VM (build 24.0-b56, mixed mode)

	=== Build Information ===

	Release ID: 402000002
	a37a8e0cda771d222cabe1f9af29c4d586e7fc7d
	Build date: 2013-11-11 11:38:58Z
	Xamarin addins: 2f88a112110098d5c6964bce4251c617c2e8a968

	=== Operating System ===

	Windows 6.1.7601.65536 (64-bit)




## Analysis


### Generated ProjectTypeGuids

### Xamarin Studio MacOSX

`
{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{F278D4AB-4730-4720-B08E-FE5E31564D9E};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}
`

3 instead of 2!

### Xamarin Studio Windows

`
{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}  
`

## Solution Attempts

### Attempt 01: Changing order - does not help

To see if order makes a difference (maybe VS ignores extra GUIDs that may be vital for XS):

`
{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC};{F278D4AB-4730-4720-B08E-FE5E31564D9E}
`


## Solution Working

### Removal of ;{F278D4AB-4730-4720-B08E-FE5E31564D9E}

In order to open project in VS project GUID was removed
`
{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}
`
[https://github.com/moljac/Xamarin.Test.Toolz/tree/master/logs/2013-10-28%5BXamarin.Android%20application%20project%20created%20in%20XS.mac%20cannot%20be%20opened%20in%20VS%5D](https://github.com/moljac/Xamarin.Test.Toolz/tree/master/logs/2013-10-28%5BXamarin.Android%20application%20project%20created%20in%20XS.mac%20cannot%20be%20opened%20in%20VS%5D)


To file bug report ot not?


thanks

Mel