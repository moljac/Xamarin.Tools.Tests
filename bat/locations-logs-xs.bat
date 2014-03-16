@echo off

explorer "%USERPROFILE%\AppData\Local\Xamarin\Log\"
explorer "%USERPROFILE%\AppData\Local\XamarinStudio-4.0\Logs"
explorer "%USERPROFILE%\AppData\Local\Xamarin\Log\"
explorer "%USERPROFILE%\AppData\Local\Xamarin\Universal"

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