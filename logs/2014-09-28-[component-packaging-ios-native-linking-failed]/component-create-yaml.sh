#!/bin/bash

# http://www.davidpashley.com/articles/writing-robust-shell-scripts/#id2382181

# exit the script if any statement returns a non-true return value. 
# The benefit of using -e is that it prevents errors snowballing into serious 
# issues when they could have been caught earlier. 
# Again, for readability: use set -o errexit.
# set -e 
set -o errexit

MONO=mono
XAMARIN_COMPONENT=~/bin/xamarin-component.exe

rm -fr *.xam *.xam.zip *.zip


find ./content/lib/ -name '*.dll' -type f
ls -alR ./content/lib/


$MONO \
	$XAMARIN_COMPONENT \
	package ./

if [ "$?"-ne 0]; then 
	echo "command failed"; 
	pause;
	exit 1; 
fi	

