#!/bin/bash

# http://www.davidpashley.com/articles/writing-robust-shell-scripts/#id2382181

# exit the script if any statement returns a non-true return value. 
# The benefit of using -e is that it prevents errors snowballing into serious 
# issues when they could have been caught earlier. 
# Again, for readability: use set -o errexit.
# set -e 
set -o errexit

cd "`dirname "$0"`"

echo DIRNAME=$DIRANME


./component-create-yaml.sh


if [ "$?"-ne 0]; then 
	echo "command failed"; 
	pause;
	exit 1; 
fi	

