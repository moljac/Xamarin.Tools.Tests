#! /usr/bin/env bash

PATH_IOS_SIMLULATOR='~/Library/Application\ Support/iPhone\ Simulator'
 
ls -al $PATH_IOS_SIMLULATOR/*

rm -fr $PATH_IOS_SIMLULATOR/*

ls -al $PATH_IOS_SIMLULATOR/*
	
if [ "$?" -ne "0" ]; then
  echo "Error press any key to exit"
  read
  exit 1
fi
