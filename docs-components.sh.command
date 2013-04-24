#! /usr/bin/env bash

BROWSER="open -a "Google Chrome" --args --kiosk"
 
$BROWSER \
	--new-window \
	http://components.xamarin.com/guidelines
	
if [ "$?" -ne "0" ]; then
  echo "Error"
  read
  exit 1
fi
