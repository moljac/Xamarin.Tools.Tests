#! /usr/bin/env bash

# BROWSER=$(/Applications/Google\ Chrome.app/Contents/MacOS/Google\ Chrome --user-data-dir=/tmp/)
BROWSER=`/Applications/Google\ Chrome.app/Contents/MacOS/Google\ Chrome --user-data-dir=/tmp/`
 
$BROWSER --new-window http://components.xamarin.com/guidelines




#/Applications/Google\ Chrome.app/Contents/MacOS/Google\ Chrome --user-data-dir=/tmp/ \
#	--new-window \
#	http://components.xamarin.com/guidelines


	
if [ "$?" -ne "0" ]; then
  echo "Error press any key to exit"
  read
  exit 1
fi