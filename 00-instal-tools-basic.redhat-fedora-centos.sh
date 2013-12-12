#!/bin/sh

# TODO: find a way to curl/wget first script that would start download 
#		of all other scripts

# paste this into terminal
sudo -s
apt-get install wget
apt-get install curl
apt-get install git

# git clone 
git clone https://github.com/moljac/Xamarin.Test.Toolz.git

# Download tarball
curl -o https://raw.github.com/moljac/Xamarin.Test.Toolz/master/collect_logs.sh.command

 
exit 0
