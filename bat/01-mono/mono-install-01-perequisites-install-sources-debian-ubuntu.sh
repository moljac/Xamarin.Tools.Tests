#/bin/bash

export DEBIAN_FRONTEND=noninteractive
# libgdiplus
#		pk-config
# mod-mono
#		apxs

sudo apt-get -y --fix-missing install \
	libtool autoconf \
	gcc g++ bison gettext make \
	pkg-config \
	git \

sudo apt-get -y --fix-missing install \
	apache2
	
echo "for missing apxs and apxs2"

sudo apt-get -y remove \
	apache2-threaded-dev
	
sudo apt-get -y --fix-missing install \
	apache2-prefork-dev 

sudo apt-get -y update

