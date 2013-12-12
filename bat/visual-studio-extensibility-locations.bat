@echo off

SET PATH_TEMPLATES="%USERPROFILE%\Documents\Visual Studio 2010\Templates\"
SET PATH_SNIPPETS="%USERPROFILE%\Documents\Visual Studio 2010\Snippets\"
SET PATH_ADDINS="%USERPROFILE%\Documents\Visual Studio 2010\Addins\"


explorer %PATH_TEMPLATES%
explorer %PATH_ADDINS%
explorer %PATH_SNIPPETS%

@IF %ERRORLEVEL% NEQ 0 PAUSE	
