#! /usr/bin/env bash

echo "Collecting Logs"
TIME=$(date "+%Y-%m-%d-%HH-%MM-%SS")
echo "TIME = " $TIME 

PATH_PREFIX=$HOME/Desktop/Xamarin.Test.Toolz/logs

echo "Creating folder " $TIME " in " $PATH_PREFIX

VERSION=4.0
PATH_XAMARIN_STUDIO_LOGS=~/Library/Logs/XamarinStudio-$VERSION/

ls -al $PATH_XAMARIN_STUDIO_LOGS

mkdir -p $PATH_PREFIX/$TIME

mv  $PATH_XAMARIN_STUDIO_LOGS $PATH_PREFIX/$TIME



if [ "$?" -ne "0" ]; then
  echo "Error press any key to exit"
  read
  exit 1
fi
