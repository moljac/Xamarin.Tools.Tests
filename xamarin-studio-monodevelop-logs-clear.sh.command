#! /usr/bin/env bash

PATH_XAMARIN_STUDIO=~/Library/Logs/XamarinStudio-{VERSION}/

ls -al $PATH_XAMARIN_STUDIO


	
if [ "$?" -ne "0" ]; then
  echo "Error press any key to exit"
  read
  exit 1
fi
