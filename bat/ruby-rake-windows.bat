@echo off

:: Rake (Ruby make) on WIndows
:: 
:: 
:: http://rubyforge.org/frs/?group_id=167
:: http://rubyforge.org/frs/download.php/76804/rubyinstaller-2.0.0-p0.exe

set PATH_RUBY=c:\bin\Ruby200\bin
set PATH=%PATH%;%PATH_RUBY%

::set

:: %PATH_RUBY%\ruby –v
:: %PATH_RUBY%\gem -v

ruby -v
gem
rake


pause
@IF %ERRORLEVEL% NEQ 0 PAUSE	