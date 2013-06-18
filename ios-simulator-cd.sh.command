#! /usr/bin/env bash

PATH_IOS_SIMLULATOR=~/Library/Application\ Support\
 
# cd ~/Library/Application\ Support\
cd $PATH_IOS_SIMLULATOR
pwd
ls -al

	
if [ "$?" -ne "0" ]; then
  echo "Error press any key to exit"
  read
  exit 1
fi
