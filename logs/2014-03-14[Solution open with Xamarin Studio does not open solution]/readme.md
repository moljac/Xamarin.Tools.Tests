# Windows Explorer context menu / Open with solution file sln opens Xamarin studio, but not Solution

## Related and possible duplicates

*	[https://bugzilla.xamarin.com/show_bug.cgi?id=11013](https://bugzilla.xamarin.com/show_bug.cgi?id=11013)
*	[]()

## Description

Seems to be UNC paths problem passed from shell to Xamarin Studio.

This is not crucial, but for people working crossplatform with setup similar to mine: VMWare Fusion virtualised windows 7.

sample path:

\\vmware-host\Shared Folders\Projects\HolisticWare\Components\yaml\yaml-net-parser\Code\Yaml.sln


This must be somewhere in Open Solution API, because 

1. Drag & Drop sln to Xamarin Studio - works
2. File menu +/ Open +/ Location: paste UNC path




https://bugzilla.xamarin.com/show_bug.cgi?id=11013





solution .sln
right click +/ Open with
Xamarin studio opened but not Solution
UNC paths?

\\vmware-host\Shared Folders\Projects\HolisticWare\Components\yaml\yaml-net-parser\Code\Yaml.sln

Drag&Drop 									- OK
Open +/ Location +/ <paste UNC path above>	- OK
