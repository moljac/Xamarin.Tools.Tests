:: component-create.bat
@echo off
setlocal ENABLEDELAYEDEXPANSION

set MONO="%PROGRAMFILES%\Mono-3.0.9\bin\mono.exe"
set XAMARIN_COMPONENT=sbin\xpkg\xamarin-component.exe
set RAKE=C:\bin\Ruby200\bin\rake

::====================================================================
:: current dir
:: CMD.EXE was started with the above path as the current directory.
:: UNC paths are not supported.  Defaulting to Windows directory.

:: check solutions in bat repo for UNC path problem
::	1.	mapping drive
::			net use ^
::				X: ^
::				"\\vmware-host\Shared Folders\Desktop\Xamarin.Test.Toolz" ^
::				/persistent:yes
::	2.	registry entries 
:: 			add the value DisableUNCCheck REG_DWORD and set the value to 0 x 1
:: 			
			c:\bin\elevate.exe ^
 				REG ADD "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Command Processor" ^
					/v DisableUNCCheck  /t REG_DWORD /d 00000001 /f
 				[HKEY_CURRENT_USER\Software\Microsoft\Command Processor]
 				net use - no trailing backslash

.\logs\component-create-yaml.bat

:: UNC path
::====================================================================

dir
set OLDDIR=%CD%
echo OLDDIR=%OLDDIR%
cd %OLDDIR%



DEL /Q *.xam *.xam.zip

dir /s .\content\bin\*.dll
dir /s .\content\lib\


%XAMARIN_COMPONENT% package .\
	

@IF %ERRORLEVEL% NEQ 0 PAUSE