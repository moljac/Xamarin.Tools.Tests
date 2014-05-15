# Java binding warning about hiding inherited member in Visual Studio and error in Xamarin Studio

## Visual Studio

After cleaning errors and warnings - remaining warning:

  'SamsungSDK.Accessory.API.DeathCallbackStub.OnTransact(int, Android.OS.Parcel, Android.OS.Parcel, int)' 
  hides inherited member 'Android.OS.Binder.OnTransact(int, Android.OS.Parcel, Android.OS.Parcel, int)'. 
  To make the current member override that implementation, add the override keyword. Otherwise add the new keyword.	


## Xamarin Studio

*	Building in VS and doing only build in XS - no error
*	rebuilding in XS error

Metadata.xml can be empty - always the same result 15 warnings and 1 error (very long
error with JARTOXML warnings).

At the end suspicious error:

Exception in thread "main" java.lang.ClassFormatError:
StackMapTable format error: access beyond the end of attribute


Error content:

	/Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Android/Xamarin.Android.Bindings.targets: Error: Tool exited with code: 1. Output: java.lang.ArrayIndexOutOfBoundsException: 12
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/ISAFrameworkManager$Stub : java.lang.ArrayIndexOutOfBoundsException: 12
	java.lang.ArrayIndexOutOfBoundsException: 3
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/SAAdapter$1 : java.lang.ArrayIndexOutOfBoundsException: 3
	java.lang.ArrayIndexOutOfBoundsException: 7
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/SAAdapter$CapexReceiver : java.lang.ArrayIndexOutOfBoundsException: 7
	java.lang.ArrayIndexOutOfBoundsException: 3
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/SAAdapter$ConnectionReceiver : java.lang.ArrayIndexOutOfBoundsException: 3
	java.lang.ArrayIndexOutOfBoundsException: 6
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/SAAdapter$IncrUpdateReceiver : java.lang.ArrayIndexOutOfBoundsException: 6
	java.lang.ArrayIndexOutOfBoundsException: 5
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/SAAdapter : java.lang.ArrayIndexOutOfBoundsException: 5
	java.lang.ArrayIndexOutOfBoundsException: 2
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/f : java.lang.ArrayIndexOutOfBoundsException: 2
	java.lang.ArrayIndexOutOfBoundsException: 3
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1894)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/accessory/api/SAServiceChannel$EventCallBackResultReceiver : java.lang.ArrayIndexOutOfBoundsException: 3
	java.lang.NoClassDefFoundError: com/samsung/android/sdk/SsdkInterface
	at java.lang.ClassLoader.defineClass1(Native Method)
	at java.lang.ClassLoader.defineClass(ClassLoader.java:760)
	at java.security.SecureClassLoader.defineClass(SecureClassLoader.java:142)
	at java.net.URLClassLoader.defineClass(URLClassLoader.java:455)
	at java.net.URLClassLoader.access$100(URLClassLoader.java:73)
	at java.net.URLClassLoader$1.run(URLClassLoader.java:367)
	at java.net.URLClassLoader$1.run(URLClassLoader.java:361)
	at java.security.AccessController.doPrivileged(Native Method)
	at java.net.URLClassLoader.findClass(URLClassLoader.java:360)
	at java.lang.ClassLoader.loadClass(ClassLoader.java:424)
	at java.lang.ClassLoader.loadClass(ClassLoader.java:357)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:86)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	Caused by: java.lang.ClassNotFoundException: com.samsung.android.sdk.SsdkInterface
	at java.net.URLClassLoader$1.run(URLClassLoader.java:372)
	at java.net.URLClassLoader$1.run(URLClassLoader.java:361)
	at java.security.AccessController.doPrivileged(Native Method)
	at java.net.URLClassLoader.findClass(URLClassLoader.java:360)
	at java.lang.ClassLoader.loadClass(ClassLoader.java:424)
	at java.lang.ClassLoader.loadClass(ClassLoader.java:357)
	... 14 more
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/SA : java.lang.NoClassDefFoundError: com/samsung/android/sdk/SsdkInterface
	java.lang.ArrayIndexOutOfBoundsException: 3
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1894)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/SAAgent$4 : java.lang.ArrayIndexOutOfBoundsException: 3
	java.lang.ArrayIndexOutOfBoundsException: 5
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/SAAgent : java.lang.ArrayIndexOutOfBoundsException: 5
	java.lang.ArrayIndexOutOfBoundsException: 2
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/c : java.lang.ArrayIndexOutOfBoundsException: 2
	java.lang.ArrayIndexOutOfBoundsException: 3
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/SASocket$a : java.lang.ArrayIndexOutOfBoundsException: 3
	java.lang.ArrayIndexOutOfBoundsException: 14
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/SASocket : java.lang.ArrayIndexOutOfBoundsException: 14
	java.lang.ArrayIndexOutOfBoundsException: 6
	at org.objectweb.asm.ClassReader.readFrameType(ClassReader.java:1915)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:1389)
	at org.objectweb.asm.ClassReader.accept(ClassReader.java:533)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:83)
	at jar2xml.JavaArchive.getPackages(JavaArchive.java:64)
	at jar2xml.Start.main(Start.java:126)
	warning J2X9001: Couldn't load class com/samsung/android/sdk/accessory/ServiceConnectionIndicationBroadcastReceiver : java.lang.ArrayIndexOutOfBoundsException: 6
	Exception in thread "main" java.lang.ClassFormatError: StackMapTable format error: access beyond the end of attribute
	at java.lang.Class.getDeclaredConstructors0(Native Method)
	at java.lang.Class.privateGetDeclaredConstructors(Class.java:2658)
	at java.lang.Class.getDeclaredConstructors(Class.java:2007)
	at jar2xml.JavaClass.doAppendToDocument(JavaClass.java:627)
	at jar2xml.JavaClass.appendToDocument(JavaClass.java:559)
	at jar2xml.JavaPackage.appendToDocument(JavaPackage.java:72)
	at jar2xml.Start.main(Start.java:127)
	(BindingLibrary1)




## Links

### Couldn't load class java.lang.ArrayIndexOutOfBoundsException

*	[https://forums.xamarin.com/discussion/973/problems-binding-jar](https://forums.xamarin.com/discussion/973/problems-binding-jar)
*	[https://forums.xamarin.com/discussion/5781/arrayindexoutofbounds-java-binding](https://forums.xamarin.com/discussion/5781/arrayindexoutofbounds-java-binding)
*	bunch of java related issues (reports, bounties etc)




