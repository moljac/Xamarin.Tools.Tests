@echo off

echo "%PROGRAMFILES%\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"
explorer ^
	/select,"%PROGRAMFILES%\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"

explorer ^
	"%USERPROFILE%\AppData\Roaming\Microsoft\VisualStudio\10.0"
explorer  ^
	/select,"%USERPROFILE%\AppData\Roaming\Microsoft\VisualStudio\10.0\ActivityLog.xml"

explorer  ^
	"%USERPROFILE%\Application Data\Microsoft\Visual Studio\10.0\"

explorer "%USERPROFILE%\Documents\Visual Studio 2010"

echo "devenv.exe /log <log path>"
echo "if <log path> omitted see:"
echo 	"%USERPROFILE%\AppData\Roaming\Microsoft\VisualStudio\10.0\ActivityLog.xml"

echo "%PROGRAMFILES%\Microsoft Visual Studio 10.0\Common7\Tools\vsvars32.bat"


@IF %ERRORLEVEL% NEQ 0 PAUSE	


:: Syntax
:: 
:: EXPLORER.EXE [/n][/e][,/root,<object>][[,/select],<sub object>]
:: Switches
:: 
:: /n:  Opens a new window in single-paned (My Computer) view for each item
::      selected, even if the new window duplicates a window that is
::      already open.
:: 
:: /e:  Uses Windows Explorer view. Windows Explorer view is most similar
::      to File Manager in Windows version 3.x. Note that the default view
::      is Open view.
:: 
:: /root,<object>:  Specifies the root level of the specified view. The
::                  default is to use the normal namespace root (the
::                  desktop). Whatever is specified is the root for the
::                  display.
:: 
:: /select,<sub object>:  Specifies the folder to receive the initial
::                        focus. If "/select" is used, the parent folder
::                        is opened and the specified object is selected.


:: Examples
:: 
:: To open a Windows Explorer view to explore only objects on \\<server name>, 
:: use the following syntax:
:: explorer /e,/root,\\<server name>
:: To view the C:\WINDOWS folder and select CALC.EXE, use the following syntax:
:: explorer /select,c:\windows\calc.exe