#/bin/bash

open -a Terminal 















# As of Mac OS X Lion 10.7, Terminal includes exactly this functionality as a Service. 
# As with most Services, these are disabled by default, so you'll need to enable this 
# to make it appear in the Services menu.
# 
# System Preferences > Keyboard > Keyboard Shortcuts > Services
# 
# Enable New Terminal at Folder. There's also New Terminal Tab at Folder, which will 
# create a tab in the frontmost Terminal window (if any, else it will create a new window). 
# These Services work in all applications, not just Finder, and they operate on folders as
# well as absolute pathnames selected in text.
# 
# You can even assign command keys to them.
# 
# Services appear in the Services submenu of each application menu, and within the contextual 
# menu (Control-Click or Right-Click on a folder or pathname).
# 
# In addition, Lion Terminal will open a new terminal window if you drag a folder (or pathname) 
# onto the Terminal application icon, and you can also drag to the tab bar of an existing
# window  to create a new tab.
# 
# Finally, if you drag a folder or pathname onto a tab (in the tab bar) and the foreground 
# process is the shell, it will automatically execute a "cd" command. (Dragging into the 
# terminal view within the tab merely inserts the pathname on its own, as in older versions 
# of Terminal.)
# 
# 
# 
# also do this from the command line or a shell script:
# 
# open -a Terminal /path/to/folder
# This is the command-line equivalent of dragging a folder/pathname onto the Terminal 
# application icon.
# 
# On a related note, Lion Terminal also has new Services for looking up man pages: Open man 
# page in Terminal displays the selected man page topic in a new terminal window, and Search 
# man Pages in Terminal performs "apropos" on the selected text. The former also understands 
# man page references ("open(2)"), man page command line arguments ("2 open") and man page 
# URLs ("x-man-page://2/open").

