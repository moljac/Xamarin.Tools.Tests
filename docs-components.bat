@echo off

::set BROWSER="%USERPROFILE%\AppData\Local\Google\Chrome\Application\chrome.exe"
set BROWSER="%PROGRAMFILES%\Google\Chrome\Application\chrome.exe"

%BROWSER% ^
	-new-window ^
	http://components.xamarin.com/guidelines


@IF %ERRORLEVEL% NEQ 0 PAUSE	
