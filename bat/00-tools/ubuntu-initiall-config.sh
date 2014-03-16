#/bin/bash

sudo ufw disable
sudo /etc/init.d/networking restart

sudo reboot

exit 0