#/bin/bash

# if "" used do not use \ before space
rm -f ~/bin/sublime
ln -s \
	"/Applications/Sublime Text 2.app/Contents/SharedSupport/bin/subl" \
	~/bin/sublime

# NO GO with link
# workaround xs as shell script not link	
# rm -f ~/bin/xs
# ln -s \
# 	"/Applications/Xamarin Studio.app/Contents/MacOS/XamarinStudio" \
# 	~/bin/xs