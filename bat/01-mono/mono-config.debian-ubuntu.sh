#!/bin/sh

# http://stackoverflow.com/questions/13365158/installing-mono-3-0

APPFOLDWER=
USERNAME=


# After the installation of mod_mono, the file mod_mono.conf 
# *as been added to your apache2 folder(/etc/apache2)*

echo "-----------------------------------------------------------------"
echo Configuring apache2

echo ".........................................."
echo Configure the default site of apache ### (optional*)**

# vim /etc/apache2/sites-available/default
# Modify the line "DocumentRoot /var/www" by "DocumentRoot /var/www/YourFolder"
#  (YourFolder is the folder where you publishing your website!)
# Configure the rights to YourFolder (optional*)**

# cd /var/www/YourFolder
sudo chown -R root:www-data .
sudo chmod -R 774 .
sudo usermod -a -G www-data $USERNAME

# Adding the mod_mono include in apache2.conf

# vim /etc/apache2/apache2.conf
# Add "Include /etc/apache2/mod_mono.conf" at the end of the file (without quotes!)
# Adding the pointer to ASP .NET 4.0 in mod_mono.conf

# vim /etc/apache2/mod_mono.conf
# Add "MonoServerPath /usr/bin/mod-mono-server4" (without quotes!) 
# 	under the "If Modules condition"
# Restart the apache2 server 
sudo /etc/init.d/apache2 restart