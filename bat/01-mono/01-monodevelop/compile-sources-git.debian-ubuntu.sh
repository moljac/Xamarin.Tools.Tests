#!/bin/sh

# added repository: 
cat «deb http://ubuntu.mirror.cambrium.nl/ubuntu/ lucid main» >> /etc/apt/sources.list

# installed prerequisites - packages:
apt-get install \
	libglib2.0-cil \
	gnome-sharp2 \
	gtk-sharp2 \
	libmono-addins-cil-dev \
	libmono-addins-gui-cil-dev \
	libmono-addins-msbuild-cil-dev

# sources from git
git clone git://github.com/mono/monodevelop.git
# sources from git for dependencies (submodules_
cd monodevelop && git submodule init && git submodule update


./configure

# it is recommended «It looks like you need to install gtk-sharp 2.12.x»
# http://article.gmane.org/gmane.comp.gnome.mono.monodevelop.general/14338
# check if installed:
find /usr/lib/mono/gac -xdev -iname "*Sharp.dll" | grep "3c99f" | grep -v "policy"

# tried this advice:
# http://www.mono-project.com/Parallel_Mono_Environments#Tip:
# _MONO_GAC_PREFIX
# and add 
# MONO_GAC_PREFIX into ~/.bashrc
echo $MONO_GAC_PREFIX


# PATHs setup
export PATH="/home/opensim/bin/mono-2.10.9/bin:$PATH"
export PKG_CONFIG_PATH="/home/opensim/bin/mono-2.10.9/lib/pkgconfig:$PKG_CONFIG_PATH"
export MANPATH="/home/opensim/bin/mono-2.10.9/share/man:$MANPATH"
export LD_LIBRARY_PATH="/home/opensim/bin/mono-2.10.9/lib:$LD_LIBRARY_PATH"
export MONO_THREADS_PER_CPU=100


exit 0