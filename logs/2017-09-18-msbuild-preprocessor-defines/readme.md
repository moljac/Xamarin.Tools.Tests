# MsBuild on MacOSX with preprocessor inconsistencies


minimal sample for this issue:

[./Archive.zip](./Archive.zip)

Xamarin.Auth builds must be tested with custom preprocessor defines (`XAMARIN_AUTH_INTERNAL`)
which are used by other teams using Xamarin.Auth (Azure Mobile Services Client, etc).

Investigating errors in Cake build scripts the issue could be isolated with msbuild and
passing preprocessor constants/defines to compiler.

The msbuild preprocessor constants/defines passing system is quite unclear, mostly because
of inconsistencies. 

The isses were detected on Mac OSX, but similar behaviour is on Windows too (still comparing
msbuld versions).

Building Portable library with custom `PORTABLE` constant defined in project file:

    /Library/Frameworks/Mono.framework/Commands/msbuild \
        /target:ReBuild \
        "/p:DefineConstants=XAMARIN_AUTH_INTERNAL" \
        /verbosity:minimal \
        /consoleloggerparameters:ShowCommandLine \
        ./MsBuildPreprocessorDefines.Portable/MsBuildPreprocessorDefines.Portable.csproj 

Results in compile time error

    /Projects/Xamarin.Test.Toolz/logs/2017-09-18-msbuild-preprocessor-defines/MsBuildPreprocessorDefines.CoreShared/Account.cs(23,36): 
    error CS0234: The type or namespace name 'Formatters' does not exist in the namespace 'System.Runtime.Serialization' (are you missing an assembly reference?) [/Projects/Xamarin.Test.Toolz/logs/2017-09-18-msbuild-preprocessor-defines/MsBuildPreprocessorDefines.Portable/MsBuildPreprocessorDefines.Portable.csproj]

The cause is that custom preprocessor constan/define which is defined in project is ignored
and not passed to `csc` compiler.

Commandline used by msbuld (shorened and formatted):

    /Library/Frameworks/Mono.framework/Versions/5.2.0/lib/mono/4.5/csc.exe 
        /noconfig /nowarn:1701,1702 /nostdlib+ /errorreport:prompt /warn:4 
        /define:XAMARIN_AUTH_INTERNAL

The constant passed via commandline to msbuild is included, but not the constants from
project. 

Next sample is for Xamarin.iOS (`XAMARIN_AUTH_INTERNAL` passed):

    /Library/Frameworks/Mono.framework/Commands/msbuild \
        /target:ReBuild \
        "/p:DefineConstants=XAMARIN_AUTH_INTERNAL" \
        /verbosity:minimal \
        /consoleloggerparameters:ShowCommandLine \
        ./MsBuildPreprocessorDefines.XamarinIOS/MsBuildPreprocessorDefines.XamarinIOS.csproj 

Build fails with following error:

    KeyStoreUtility.cs(11,21): error CS0234: The type or namespace name 'Security' does not exist in the namespace 'MonoTouch' (are you missing an assembly reference?) [/Projects/Xamarin.Test.Toolz/logs/2017-09-18-msbuild-preprocessor-defines/MsBuildPreprocessorDefines.XamarinIOS/MsBuildPreprocessorDefines.XamarinIOS.csproj]

C# code failing:

```csharp
    #if __UNIFIED__
        Security.SecRecord sr = null;
    #else
        MonoTouch.Security.SecRecord.SecRecord = null;
    #endif
```

The reason is that `__UNIFIED__` constant/define is not passed to csc compiler.

NOTE: here we can discuss whether `__UNIFIED__` is default or some custom preprocessor
constant/define. Xamarin.iOS uses this constant to indicate Unified 64b code. 

This problem is obvious in next test case which builds Xamarin.Android project:

    /Library/Frameworks/Mono.framework/Commands/msbuild \
        /target:ReBuild \
        "/p:DefineConstants=XAMARIN_AUTH_INTERNAL" \
        /verbosity:minimal \
        /consoleloggerparameters:ShowCommandLine \
        ./MsBuildPreprocessorDefines.XamarinAndroid/MsBuildPreprocessorDefines.XamarinAndroid.csproj 

Xamarin.Android project compiles, because most of default constants/defines are passed
to compiler by msbuild TOGETHER WITH SOME NON-STANDARD!

Commandline used by msbuld (shorened and formatted):

    /Library/Frameworks/Mono.framework/Versions/5.2.0/lib/mono/4.5/csc.exe 
    /noconfig /nowarn:1701,1702 /nostdlib+ /errorreport:prompt /warn:4 
    /define:XAMARIN_AUTH_INTERNAL;__XAMARIN_ANDROID_v1_0__;__MOBILE__;__ANDROID__;
    __ANDROID_1__;__ANDROID_2__;__ANDROID_3__;__ANDROID_4__;__ANDROID_5__;__ANDROID_6__;
    __ANDROID_7__;__ANDROID_8__;__ANDROID_9__;__ANDROID_10__;__ANDROID_11__;__ANDROID_12__;
    __ANDROID_13__;__ANDROID_14__;__ANDROID_15__;__ANDROID_16__;__ANDROID_17__;
    __ANDROID_18__;__ANDROID_19__;__ANDROID_20__;__ANDROID_21__;__ANDROID_22__;
    __ANDROID_23__;__ANDROID_24__;__ANDROID_25__
 

It is clear that besides `XAMARIN_AUTH_INTERNAL` and Android standard defines `__ANDROID__`
and `__ANDROID_vv__` (indicating API Level) some non-standard defines are passed to csc
(`__MOBILE__` and `__XAMARIN_ANDROID_v1_0__`)

## Debug builds

In IDE the most obvious difference between Release and Debug is in `DEFINE` constant.
Logically passing `Configuration=Default` parameter from command-line would be similar
like switching Configuration in IDE, but this is not the case.

    /Library/Frameworks/Mono.framework/Commands/msbuild \
        /target:ReBuild \
        "/p:Configuration=Debug;DefineConstants=XAMARIN_AUTH_INTERNAL" \
        /verbosity:minimal \
        /consoleloggerparameters:ShowCommandLine \
        ./MsBuildPreprocessorDefines.XamarinAndroid/MsBuildPreprocessorDefines.XamarinAndroid.csproj 

Commandline used by msbuld (shorened and formatted):

    /Library/Frameworks/Mono.framework/Versions/5.2.0/lib/mono/4.5/csc.exe /noconfig
    /nowarn:1701,1702 /nostdlib+ /errorreport:prompt /warn:4 
    /define:XAMARIN_AUTH_INTERNAL;__XAMARIN_ANDROID_v1_0__;__MOBILE__;__ANDROID__;
    __ANDROID_1__;__ANDROID_2__;__ANDROID_3__;__ANDROID_4__;__ANDROID_5__;__ANDROID_6__;
    __ANDROID_7__;__ANDROID_8__;__ANDROID_9__;__ANDROID_10__;__ANDROID_11__;__ANDROID_12__;
    __ANDROID_13__;__ANDROID_14__;__ANDROID_15__;__ANDROID_16__;__ANDROID_17__;
    __ANDROID_18__;__ANDROID_19__;__ANDROID_20__;__ANDROID_21__;__ANDROID_22__;
    __ANDROID_23__;__ANDROID_24__;__ANDROID_25__ 

    
        
## Windows

    msbuild ^
        /target:ReBuild ^
        "/p:DefineConstants=XAMARIN_AUTH_INTERNAL" ^
        /verbosity:minimal ^
        /consoleloggerparameters:ShowCommandLine ^
        ./MsBuildPreprocessorDefines.Portable/MsBuildPreprocessorDefines.Portable.csproj 

Fails - `PORTABLE` define was NOT passed

Android build is OK (default defines were passed)

    msbuild ^
        /target:ReBuild ^
        "/p:DefineConstants=XAMARIN_AUTH_INTERNAL" ^
        /verbosity:minimal ^
        /consoleloggerparameters:ShowCommandLine ^
        ./MsBuildPreprocessorDefines.XamarinAndroid/MsBuildPreprocessorDefines.XamarinAndroid.csproj         



## Suggestions

1.  definition of command-line arguments passing behaviour 

    Are constants overriden/overwritten or appended?
    Are platform default and custom constants used (`__UNIFIED__` `__ANDROID__`)?
    Are platform default and project constants used or not (project templates)?

    This way user would not need to know default defines together with internals of the
    project file (specifically defines), because msbuild compiles data from projects and
    not only files (defined also in project)

2.  exact definition of default and custom defines passed to msbuild for each platform

    this would make everything more deterministic and less complex.

Currently, there are options to avoid errors, but involves internal knowledge about
each project type and platform and results in high effort of writing customized code.


## More info (for further analysis)


Some `#defines` for xplat development

    #ifdef _WIN64
    //define something for Windows (64-bit)
    #elif _WIN32
    //define something for Windows (32-bit)
    #elif __APPLE__
        #include "TargetConditionals.h"
        // TARGET_IPHONE_SIMULATOR is a subset of TARGET_OS_IPHONE
        // TARGET_OS_IPHONE is a subset of TARGET_OS_MAC.
        #if TARGET_OS_IPHONE && TARGET_IPHONE_SIMULATOR
            // define something for simulator   
        #elif TARGET_OS_IPHONE
            // define something for iphone  
        #else
            #define TARGET_OS_OSX 1
            // define something for OSX
        #endif
    #elif __ANDROID__
        // Android - Linux should be defined too
    #elif __linux__ || __linux  || linux || __linux || __gnu_linux__
        // linux
    #elif __unix || __unix__    // all unices not caught above
        // Unix
    #elif __posix
        // POSIX
    #endif

TargetConditionals.h

TARGET_OS_TV
TARGET_OS_WATCH
#define TARGET_OS_MAC               1
#define TARGET_OS_WIN32             0
#define TARGET_OS_UNIX              0
#define TARGET_OS_OSX               0
#define TARGET_OS_IPHONE            1
#define TARGET_OS_IOS               1
#define TARGET_OS_WATCH             0
#define TARGET_OS_BRIDGE            0
#define TARGET_OS_TV                0
#define TARGET_OS_SIMULATOR         0
#define TARGET_OS_EMBEDDED          1 
#define TARGET_IPHONE_SIMULATOR     TARGET_OS_SIMULATOR /* deprecated */
#define TARGET_OS_NANO              TARGET_OS_WATCH /* deprecated */