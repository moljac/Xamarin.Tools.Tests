#!/bin/sh

# Add appropriate rights:
chmod +x /etc/init.d/mono-service

#And install the script:
update-rc.d monoserve defaults

exit 0