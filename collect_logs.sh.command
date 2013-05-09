#! /usr/bin/env bash

echo "Collecting Logs"
TIME=$(date "+%Y-%m-%d-%HH-%MM-%SS")
echo "TIME = " $TIME 

PATH_PREFIX=$HOME/Desktop/Xamarin.Test.Toolz

echo "Creating folder " $TIME " in " $PATH_PREFIX

mkdir  $PATH_PREFIX/$TIME

read
