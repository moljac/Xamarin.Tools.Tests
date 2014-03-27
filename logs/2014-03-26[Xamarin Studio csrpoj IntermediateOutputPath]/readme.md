# Xamarin Studio csrpoj IntermediateOutputPath

Xamarin Studio creates IntermediateOutputpath set by Visual Studio in project folder.

This is not critical for simple Android Applications (minimal-sample - AndroidApplication1), 
but breaks compilation for samples that use java binding project (real-world-sample)



Pinterest.XamarinAndroid/Pinterest.App.XamarinAndroid.csproj:    

	<IntermediateOutputPath>C:\Users\moljac\AppData\Local\Temp\vs9326.tmp\Debug\</IntermediateOutputPath>
	
Pinterest.XamarinAndroid/Pinterest.App.XamarinAndroid.csproj:    

	<IntermediateOutputPath>C:\Users\moljac\AppData\Local\Temp\vs9326.tmp\Release\</IntermediateOutputPath>

	

	
## Result 


3 errors unrelated errors caused by temp files generated within project

/Users/moljac/Projects/Xamarin/components/Pinterest/src/samples/Pinterest.XamarinAndroid/C:/Users/moljac/AppData/Local/Temp/vs9326.tmp/Debug/android/src/pinterest/app/xamarinandroid/DemoSimple_PinItListenerForDemo.java(29,29): 
Error:  
	package com.pinterest.pinit does not existextends com.pinterest.pinit.PinItListener
(Pinterest.App.XamarinAndroid)

/Users/moljac/Projects/Xamarin/components/Pinterest/src/samples/Pinterest.XamarinAndroid/C:/Users/moljac/AppData/Local/Temp/vs9326.tmp/Debug/android/src/pinterest/app/xamarinandroid/DemoSimple_PinItListenerForDemo.java(7,7): 
	Error:  cannot find symbol symbol  : method getClass()
	location: class pinterest.app.xamarinandroid.DemoSimple_PinItListenerForDemo
			if (getClass () == DemoSimple_PinItListenerForDemo.class)
			(Pinterest.App.XamarinAndroid)

/Users/moljac/Projects/Xamarin/components/Pinterest/src/samples/Pinterest.XamarinAndroid/C:/Users/moljac/AppData/Local/Temp/vs9326.tmp/Debug/android/src/pinterest/app/xamarinandroid/DemoSimple_PinItListenerForDemo.java(28,28): 
	Error:  Activate(java.lang.String,java.lang.String,java.lang.Object,java.lang.Object[]) in mono.android.TypeManager 
			cannot be applied to (java.lang.String,java.lang.String,pinterest.app.xamarinandroid.DemoSimple_PinItListenerForDemo,java.lang.Object[])
			mono.android.TypeManager.Activate ("Pinterest.App.XamarinAndroid.DemoSimple/PinItListenerForDemo, Pinterest.App.XamarinAndroid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
			(Pinterest.App.XamarinAndroid)
