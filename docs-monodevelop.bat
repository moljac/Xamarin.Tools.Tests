@echo off

::set BROWSER="%USERPROFILE%\AppData\Local\Google\Chrome\Application\chrome.exe"
set BROWSER="%PROGRAMFILES%\Google\Chrome\Application\chrome.exe"

%BROWSER% ^
	-new-window ^
	http://mjhutchinson.com/ ^
	https://github.com/mrward/monodevelop-nuget-addin/network ^
	https://github.com/InfinitiesLoop/VSNewFile
	


@IF %ERRORLEVEL% NEQ 0 PAUSE	
