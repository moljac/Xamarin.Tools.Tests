#/bin/bash

ADB=/Users/moljac/Downloads/adt-bundle-mac-x86_64-20131030/sdk/platform-tools/adb
JAVAWS=/usr/bin/javaws
JAVAWS=/System/Library/Java/JavaVirtualMachines/1.6.0.jdk/Contents/Home/bin/javaws

$ADB devices
cd ~/Desktop/Xamarin.Test.Toolz/bat/android/screencast
$JAVAWS androidscreencast.jnlp




