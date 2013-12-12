#!/bin/sh

# The easiest way to debug mono would likely be to compile mono from source 
# http://www.mono-project.com/Compiling_Mono_From_Git
# and install it into a custom prefix.
# http://www.mono-project.com/Parallel_Mono_Environments
#
# 
# Then create a Console project in Xamarin Studio that reproduces the project.
# 
# Finally select the active runtime in Xamarin Studio 
# 	Project +/ Active Runtime +/ Select your custom prefix where your mono is installed
# 	
# Now user should be able to debug any app with the debugger and step into Mono's source code.


#=========================================================================================
# the prefix is very important for Ubuntu 12.04
# for gwan
PREFIX_CUSTOM=/usr/
# for holisticware tests
# PREFIX_CUSTOM=/opt/holisticware
#=========================================================================================
git clone git://github.com/mono/mono.git
git submodule update --init --recursive
cd mono
./autogen.sh --prefix=$PREFIX_CUSTOM
make
sudo make install
cd ..

git clone git://github.com/mono/libgdiplus.git
git submodule update --init --recursive
cd libgdiplus
./autogen.sh --prefix=$PREFIX_CUSTOM
make
sudo make install
cd ..

git clone git://github.com/mono/mod_mono.git
git submodule update --init --recursive
cd mod_mono
./autogen.sh --prefix=$PREFIX_CUSTOM
make
sudo make install
cd ..

git clone git://github.com/mono/xsp.git
git submodule update --init --recursive
cd xsp
./autogen.sh --prefix=$PREFIX_CUSTOM
make
sudo make install
cd ..



# In order to use mcs and mono binaries during the build process which do 
# not reside in user's PATH, user can set two make variables, 
# EXTERNAL_MCS and EXTERNAL_RUNTIME:

# make EXTERNAL_MCS=/foo/bar/gmcs.exe EXTERNAL_RUNTIME=/somewhere/else/mono

# without mono installed, build and install mono from a recently released tarball or run:
# ./autogen.sh must be run prior to this

# make get-monolite-latest
# make EXTERNAL_MCS="${PWD}/mcs/class/lib/monolite/gmcs.exe"

exit 0