# Xamarin Components not loaded in VS and projects modified after sln reopening #


## Steps to reproduce ##

1.	New solution
1.	new project - Android App (not tested for other but it seems it would be the same)    
1.	add new Xamarin Component (ZXing in this case)    
	![Component added in VS](./screenshots/xamarin-component-vs-added-CropperCapture[23].png)   
1.	recompile OK
1. 	close solution
1.	reopen solution in VS - project modification detected   
	![Project modification - reloading](./screenshots/xamarin-component-vs-solution-reopened-CropperCapture[24].png)
1.	VS Component not available	  
	![Project modification - reloading](./screenshots/xamarin-component-vs-not-available-CropperCapture[25].png)   	
1.  reopening in XSW (Xamarin Studio Windows) no project modifications!   
	![Project modification - reloading](./screenshots/xamarin-component-xs-solution-reopened-CropperCapture[23].png)   
1.	csproj changed component not available (sse below unified diff for csproj)    
1.	VS - possible to add the same component (it is not re-downloaded)
1.	XS on Mac cannot add, cannot change - stuck!
1.	TODO! Mac ScreenShots @Iki

	


## Unified diff AndroidApplication1.csproj ##

	 .../AndroidApplication1/AndroidApplication1.csproj                 |    4 ++--
	 1 file changed, 2 insertions(+), 2 deletions(-)

	diff --git a/logs/2013-06-03[Xamarin Components not loaded in XS and projects modified after sln reopening]/AndroidApplication1/AndroidApplication1.csproj b/logs/2013-06-03[Xamarin Components not loaded in XS and projects modified after sln reopening]/AndroidApplication1/AndroidApplication1.csproj
	index 28f0c1f..08c4d18 100644
	--- a/logs/2013-06-03[Xamarin Components not loaded in XS and projects modified after sln reopening]/AndroidApplication1/AndroidApplication1.csproj	
	+++ b/logs/2013-06-03[Xamarin Components not loaded in XS and projects modified after sln reopening]/AndroidApplication1/AndroidApplication1.csproj	
	@@ -82,10 +82,10 @@
		 </XamarinComponentReference>
	   </ItemGroup>
	   <ItemGroup>
	-    <XamarinComponent Include="zxing.net.mobile">
	+    <XamarinComponentReference Include="zxing.net.mobile">
		   <Visible>False</Visible>
		   <Version>1.3.3</Version>
	-    </XamarinComponent>
	+    </XamarinComponentReference>
	   </ItemGroup>
	   <Import Project="$(MSBuildExtensionsPath)\Xamarin\Android\Xamarin.Android.CSharp.targets" />
	   <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 


## Refs ## 

* 	github	
	[https://github.com/moljac/Xamarin.Test.Toolz/tree/master/logs/2013-06-03%5BXamarin%20Components%20not%20loaded%20in%20VS%20and%20projects%20modified%20after%20sln%20reopening%5D](https://github.com/moljac/Xamarin.Test.Toolz/tree/master/logs/2013-06-03%5BXamarin%20Components%20not%20loaded%20in%20VS%20and%20projects%20modified%20after%20sln%20reopening%5D)
* 	Xamarin Forums   
	[http://forums.xamarin.com/discussion/4783/xamarin-components-not-loaded-in-vs-and-projects-modified-after-sln-reopening](http://forums.xamarin.com/discussion/4783/xamarin-components-not-loaded-in-vs-and-projects-modified-after-sln-reopening)
