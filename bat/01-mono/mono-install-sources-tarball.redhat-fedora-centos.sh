#/bin/bash

wget http://dl.fedoraproject.org/pub/epel/6/x86_64/epel-release-6-8.noarch.rpm
rpm -Uvh epel-release-6-8.noarch.rpm

yum -y install \
	bison gettext glib2 freetype fontconfig libpng libpng-devel libX11 \
	libX11-devel glib2-devel libgdi* libexif glibc-devel urw-fonts java unzip \
	gcc gcc-c++ automake autoconf libtool make bzip2 wget
	
# Downloading and Compiling
# 
# In some cases, one migh want to use a prefix of /opt/mono 
# this will require you to either 
# 	add this directory to your PATH environment variable, or 
# 	explicitly specify the full path to Mono when needed to run.


# Mono
VERSION=2.8.2
# VERSION=2.10.9
# VERSION=3.0.2
# VERSION=3.0.7
	
# http://gwan.com/faq => 3.0.2?!?
cd /tmp

wget http://origin-download.mono-project.com/sources/mono/mono-$VERSION.tar.bz2
#tar xvfz mono-$VERSION.tar.gz
tar xvfj mono-$VERSION.tar.bz2
cd mono-$VERSION

./configure --prefix=/usr
make; make install
mono -V

# Instead of 
# 	./configure --prefix=/usr 
# choices
# 	./configure --prefix=/opt/mono 
# 	
# 	(as discussed above). 

# If "Out of memory" errors appear while running make on memory-limited systems, 
# try running the following to allow higher virtual memory usage:

ulimit -v unlimited	

exit 0