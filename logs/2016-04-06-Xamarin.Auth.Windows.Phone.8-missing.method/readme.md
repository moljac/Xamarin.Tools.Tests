# Xamarin.Auth Windows Phone tests

## SinglePlatform WindowsPhone [WP]

Works

	Get-Project * | UnInstall-Package Xamarin.Auth 
	Get-Project * | Install-Package Xamarin.Auth -pre
	

## MultiPlatform WindowsPhone and Xamarin.Android [WP-XA]

Works

## Issue 01: Windows Phone 8 - missing GetUI() method


Fullscreen: 

Xamarin.Android dll is picked up by Object Browser, although the Project References are
used and Path property og the Reference is correct one.

Fullscreen  

![Full Screen]
(
https://github.com/moljac/Xamarin.Tools.Tests/blob/master/logs/2016-04-06-Xamarin.Auth.Windows.Phone.8-missing.method/screensshots/Screen%20Shot%202016-04-08%20at%2013.04.51%20.pnghttps://raw.githubusercontent.com/moljac/Xamarin.Tools.Tests/master/logs/2016-04-06-Xamarin.Auth.Windows.Phone.8-missing.method/screensshots/WindowsPhone8.Sample.01-Crash%20missing%20GetUI%20Method.png 
"Fullscreen Crash"
)

Windows Phone 8 sample:

1. 	References +/ Xamarin.Auth

2. 	References +/ Xamarin.Auth +/ Properties

3.	Reference Property +/ path
	<>

4. 	References +/ Xamarin.Auth +/ View in Object Browser

5.	Assembly
	NOTE!!