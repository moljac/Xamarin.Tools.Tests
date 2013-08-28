#! /usr/bin/env bash

VERSION=4.0
PATH_XAMARIN_STUDIO_LOGS=~/Library/Logs/XamarinStudio-$VERSION/

ls -al $PATH_XAMARIN_STUDIO_LOGS
rm -fr $PATH_XAMARIN_STUDIO_LOGS/*
ls -al $PATH_XAMARIN_STUDIO_LOGS


	
if [ "$?" -ne "0" ]; then
  echo "Error press any key to exit"
  read
  exit 1
fi
