# Android Application created on MacOSX cannot be opened in Visual Studio

Android Application creation in XS on Mac and Windows shows that project has different
ProjectType GUIDs - actually different number of GUIDs.

## Symptoms of the issue

Android Application Project created in XS on MacOSX

*	cannot be opened in VS (2010, 2012)
*	cann be opened in XS@Windows

### Screenshots

* ![](url "Visual Studio message")
* ![](url "Visual Studio Soluton")


## Analysis


### Generated ProjectTypeGUIDS

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