


## Visual Studio 2015

Exception

	An exception of type 'System.Exception' occurred in System.Windows.ni.dll 
	but was not handled in user code

	Additional information: 
	Error HRESULT E_FAIL has been returned from a call to a COM component.

Exception details:
	
	System.Exception was unhandled by user code
	  HResult=-2146233088
	  Message=Error HRESULT E_FAIL has been returned from a call to a COM component.
	  Source=System.Windows
	  StackTrace:
		   at MS.Internal.XcpImports.CheckHResult(UInt32 hr)
		   at MS.Internal.XcpImports.SetValue(IManagedPeerBase obj, DependencyProperty property, String s)
		   at MS.Internal.XcpImports.SetValue(IManagedPeerBase doh, DependencyProperty property, Object obj)
		   at System.Windows.DependencyObject.SetObjectValueToCore(DependencyProperty dp, Object value)
		   at System.Windows.DependencyObject.SetEffectiveValue(DependencyProperty property, EffectiveValueEntry& newEntry, Object newValue)
		   at System.Windows.DependencyObject.UpdateEffectiveValue(DependencyProperty property, EffectiveValueEntry oldEntry, EffectiveValueEntry& newEntry, ValueOperation operation)
		   at System.Windows.DependencyObject.SetValueInternal(DependencyProperty dp, Object value, Boolean allowReadOnlySet)
		   at System.Windows.ResourceDictionary.set_Source(Uri value)
		   at Xamarin.Forms.Forms.Init()
		   at In2.KamApp.WinPhone.MainPage..ctor()
	  InnerException: 

Output:	  
	  
	'TaskHost.exe' (CoreCLR: DefaultDomain): Loaded 'C:\windows\system32\mscorlib.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.Windows.RuntimeHost.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.Windows.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.Net.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.Xml.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\Data\Programs\{EC495A32-938E-4528-8F1E-5344E2EA1343}\Install\In2.KamApp.WinPhone.DLL'. Symbols loaded.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\Microsoft.Phone.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\Microsoft.Phone.Interop.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\WinMetadata\Windows.winmd'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\Data\Programs\{EC495A32-938E-4528-8F1E-5344E2EA1343}\Install\Xamarin.Forms.Platform.WP8.DLL'. Module was built without symbols.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\Data\Programs\{EC495A32-938E-4528-8F1E-5344E2EA1343}\Install\In2.KamApp.DLL'. Symbols loaded.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\Data\Programs\{EC495A32-938E-4528-8F1E-5344E2EA1343}\Install\Xamarin.Forms.Core.DLL'. Module was built without symbols.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.Runtime.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.ObjectModel.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.Collections.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.Linq.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.Core.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\Data\Programs\{EC495A32-938E-4528-8F1E-5344E2EA1343}\Install\System.Windows.Interactivity.DLL'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.Threading.Tasks.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.IO.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.Reflection.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\System.Linq.Expressions.ni.dll'. Skipped loading symbols. Module is optimized and the debugger option 'Just My Code' is enabled.
	'TaskHost.exe' (CoreCLR: Silverlight AppDomain): Loaded 'C:\windows\system32\en-US\mscorlib.debug.resources.dll'. Module was built without symbols.
	Exception thrown: 'System.Exception' in System.Windows.ni.dll

IDE info:

	Microsoft Visual Studio Community 2015
	Version 14.0.23107.0 D14REL
	Microsoft .NET Framework
	Version 4.6.00081

	Installed Version: Community

	Visual Basic 2015   00322-20000-00000-AA727
	Microsoft Visual Basic 2015

	Visual C# 2015   00322-20000-00000-AA727
	Microsoft Visual C# 2015

	Visual C++ 2015   00322-20000-00000-AA727
	Microsoft Visual C++ 2015

	Visual F# 2015 RC   00322-20000-00000-AA727
	Microsoft Visual F# 2015 RC

	Windows Phone SDK 8.0 - ENU   00322-20000-00000-AA727
	Windows Phone SDK 8.0 - ENU

	ASP.NET and Web Tools   14.0.20626.0
	ASP.NET and Web Tools

	ASP.NET Web Frameworks and Tools 2013   5.2.30624.0
	For additional information, visit http://www.asp.net/

	Common Azure Tools   1.5
	Provides common services for use by Azure Mobile Services and Microsoft Azure Tools.

	GenerateUnitTest   1.0
	Generates unit test code for methods in classes under test.

	GitHub.VisualStudio   1.0
	A Visual Studio Extension that brings the GitHub Flow into Visual Studio.

	Microsoft Azure Mobile Services Tools   1.4
	Microsoft Azure Mobile Services Tools

	Microsoft MI-Based Debugger   1.0
	Provides support for connecting Visual Studio to MI compatible debuggers

	NuGet Package Manager   3.0.0
	NuGet Package Manager in Visual Studio. For more information about NuGet, visit http://docs.nuget.org/.

	PreEmptive Analytics Visualizer   1.2
	Microsoft Visual Studio extension to visualize aggregated summaries from the PreEmptive Analytics product.

	Python Tools for Visual Studio   2.2.30718.00
	Python Tools for Visual Studio provides IntelliSense, projects, templates, Interactive windows, and other support for Python developers.

	Python Tools for Visual Studio - Django Integration   2.2.30718.00
	Provides templates and integration for the Django web framework.

	Python Tools for Visual Studio - Profiling Support   2.2.30718.00
	Profiling support for Python projects.

	SQL Server Data Tools   14.0.50616.0
	Microsoft SQL Server Data Tools

	Visual C++ for Cross Platform Mobile Development   1.0
	Visual C++ for Cross Platform Mobile Development

	Visual C++ for Cross Platform Mobile Development   1.0
	Visual C++ for Cross Platform Mobile Development

	VsEssentials   1.1
	Essential features missing in Visual Studio.

	Xamarin   4.0.0.1111 (a1dc0d5)
	Visual Studio extension to enable development for Xamarin.iOS and Xamarin.Android.

	Xamarin.Android   5.1.99.653 (cfa43bb)
	Visual Studio plugin to enable development for Xamarin.Android.

	Xamarin.iOS   8.13.0.122 (2c6a530)
	Visual Studio extension to enable development for Xamarin.iOS.
	
	
  