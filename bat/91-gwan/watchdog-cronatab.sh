#!/bin/sh

# absolute name
EXECUTABLE=$HOME/gwan-linux32/gwan
EXECUTABLE=scriptname.sh

ps -ef | grep $EXECUTABLE | grep -v grep 1>/dev/null  || { bash $EXECUTABLE &}
ps -ef | grep $EXECUTABLE 1>/dev/null  || { bash /abosolute/path/of/script &}

exit 0
