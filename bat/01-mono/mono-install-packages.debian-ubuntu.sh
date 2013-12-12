#!/bin/sh

sudo apt-get -y install \
	apache2 apache2-doc apache2-utils
	
sudo service apache2 restart
sudo service apache2 reload

exit 0