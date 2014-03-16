@set echo off

:: http://docs.xamarin.com/guides/android/deployment%2c_testing%2c_and_metrics/diagnostics#Diagnostic_MSBuild_Output

::set ADB="C:\Program Files (x86)\Android\android-sdk\platform-tools\adb.exe"
set ADB="%PROGRAMFILES%\Android\android-sdk\platform-tools\adb.exe"

%ADB% shell setprop debug.mono.env "'MONO_LOG_LEVEL=info|MONO_LOG_MASK=asm'"
%ADB% shell setprop debug.mono.log "all,gc,gref,lref"

%ADB% shell setprop debug.mono.trace E:all
::%ADB% shell setprop debug.mono.trace ""

cmd /C %ADB% shell setprop debug.mono.trace E:all
cmd /K %ADB% logcat
