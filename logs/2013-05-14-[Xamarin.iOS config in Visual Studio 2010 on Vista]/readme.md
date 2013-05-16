# Xamarin.iOS config in Visual Studio 2010 on Vista #

[http://forums.xamarin.com/discussion/4113/xamarin-ios-config-in-visual-studio-2010-on-vista/p1](http://forums.xamarin.com/discussion/4113/xamarin-ios-config-in-visual-studio-2010-on-vista/p1)

Visual Studio

 
	Microsoft Visual Studio 2010
	Version 10.0.40219.1 SP1Rel
	Microsoft .NET Framework
	Version 4.5.50709 SP1Rel

	Xamarin.Android   4.6.04000 (03814ac5)
	Visual Studio plugin to enable development for Xamarin.Android.

	Xamarin.iOS   1.1.200 (7d63692c)
	Visual Studio extension to enable development for Xamarin.iOS

Notes:

Some folders in %SYSTEMDRIVE% (c:)

	C:\VS2012_EXTENSIONS_DIR
	C:\VS2012_ITEMTEMPLATES_DIR
	C:\VS2012_PROJECTTEMPLATES_DIR
	C:\VS2012_ROOT_FOLDER
	
Exception

	Mono.IOS.VisualStudio.MonoTouchPackage Warning: 0 : Initializing Mono.IOS.VisualStudio.MonoTouchPackage
	Mono.IOS.VisualStudio.MonoTouchPackage Warning: 0 : Activation Check
	Mono.IOS.VisualStudio.MonoTouchPackage Warning: 0 : Trial Ended : False. Start Upgrade : False.  Start Expired : False. Start Invalid : False.  Business Features : True.
	
	Mono.IOS.VisualStudio.BuildServerAddressProvider.BuildServerAddressProvider Warning: 0 : Failed to show Connection Wizard
	System.Windows.Markup.XamlParseException: Initialization of 'Xceed.Wpf.Toolkit.BusyIndicator' threw an exception. ---> System.Xaml.XamlObjectWriterException: Set property 'System.Windows.ResourceDictionary.Source' threw an exception. ---> System.IO.IOException: Cannot locate resource 'zoombox/themes/generic.xaml'.
	at MS.Internal.AppModel.ResourcePart.GetStreamCore(FileMode mode, FileAccess access)
	at System.IO.Packaging.PackagePart.GetStream(FileMode mode, FileAccess access)
	at System.IO.Packaging.PackWebResponse.CachedResponse.GetResponseStream()
	at System.IO.Packaging.PackWebResponse.GetResponseStream()
	at System.IO.Packaging.PackWebResponse.get_ContentType()
	at MS.Internal.WpfWebRequestHelper.GetContentType(WebResponse response)
	at MS.Internal.WpfWebRequestHelper.GetResponseStream(WebRequest request, ContentType& contentType)
	at System.Windows.ResourceDictionary.set_Source(Uri value)
	at System.Windows.Baml2006.WpfSharedBamlSchemaContext.<Create_BamlProperty_ResourceDictionary_Source>b__1c4(Object target, Object value)
	at System.Windows.Baml2006.WpfKnownMemberInvoker.SetValue(Object instance, Object value)
	at MS.Internal.Xaml.Runtime.ClrObjectRuntime.SetValue(XamlMember member, Object obj, Object value)
	at MS.Internal.Xaml.Runtime.ClrObjectRuntime.SetValue(Object inst, XamlMember property, Object value)
	--- End of inner exception stack trace ---
	at MS.Internal.Xaml.Runtime.ClrObjectRuntime.SetValue(Object inst, XamlMember property, Object value)
	at MS.Internal.Xaml.Runtime.PartialTrustTolerantRuntime.SetValue(Object obj, XamlMember property, Object value)
	at System.Xaml.XamlObjectWriter.Logic_ApplyPropertyValue(ObjectWriterContext ctx, XamlMember prop, Object value, Boolean onParent)
	at System.Xaml.XamlObjectWriter.Logic_DoAssignmentToParentProperty(ObjectWriterContext ctx)
	at System.Xaml.XamlObjectWriter.Logic_AssignProvidedValue(ObjectWriterContext ctx)
	at System.Xaml.XamlObjectWriter.WriteEndMember()
	at System.Xaml.XamlWriter.WriteNode(XamlReader reader)
	at System.Xaml.XamlServices.Transform(XamlReader xamlReader, XamlWriter xamlWriter, Boolean closeWriter)
	at System.Xaml.XamlServices.Transform(XamlReader xamlReader, XamlWriter xamlWriter)
	at System.Windows.SystemResources.ResourceDictionaries.LoadDictionary(Assembly assembly, String assemblyName, String resourceName, Boolean isTraceEnabled)
	at System.Windows.SystemResources.ResourceDictionaries.LoadGenericDictionary(Boolean isTraceEnabled)
	at System.Windows.SystemResources.FindDictionaryResource(Object key, Type typeKey, ResourceKey resourceKey, Boolean isTraceEnabled, Boolean allowDeferredResourceReference, Boolean mustReturnDeferredResourceReference, Boolean& canCache)
	at System.Windows.SystemResources.FindResourceInternal(Object key, Boolean allowDeferredResourceReference, Boolean mustReturnDeferredResourceReference)
	at System.Windows.StyleHelper.GetThemeStyle(FrameworkElement fe, FrameworkContentElement fce)
	at System.Windows.FrameworkElement.UpdateThemeStyleProperty()
	at System.Windows.FrameworkElement.OnInitialized(EventArgs e)
	at System.Windows.FrameworkElement.TryFireInitialized()
	at System.Windows.FrameworkElement.EndInit()
	at MS.Internal.Xaml.Runtime.ClrObjectRuntime.InitializationGuard(XamlType xamlType, Object obj, Boolean begin)
	--- End of inner exception stack trace ---
	at System.Windows.Markup.WpfXamlLoader.Load(XamlReader xamlReader, IXamlObjectWriterFactory writerFactory, Boolean skipJournaledProperties, Object rootObject, XamlObjectWriterSettings settings, Uri baseUri)
	at System.Windows.Markup.WpfXamlLoader.LoadBaml(XamlReader xamlReader, Boolean skipJournaledProperties, Object rootObject, XamlAccessLevel accessLevel, Uri baseUri)
	at System.Windows.Markup.XamlReader.LoadBaml(Stream stream, ParserContext parserContext, Object parent, Boolean closeStream)
	at System.Windows.Application.LoadComponent(Object component, Uri resourceLocator)
	at Mono.IOS.VisualStudio.Wizard.ConnectionWizardDialog.InitializeComponent()
	at Mono.IOS.VisualStudio.Wizard.ConnectionWizardDialog..ctor()
	at Mono.IOS.VisualStudio.BuildServerAddressProvider.BuildServerAddressProvider.ShowExplorer()
	at Mono.IOS.VisualStudio.BuildServerAddressProvider.BuildServerAddressProvider.Start(BuildServerAddressContext context)

	
Activity Log


