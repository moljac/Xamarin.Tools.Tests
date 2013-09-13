## Android Architeture ABIs in project file csproj

This problem surfaced for second time during component submission, the Android sample 
for MarkDownDeep seems to be having the same error as SharpSerializer had, in that when 
tested on the release configuration it’s throwing the error 

	‘The package does not support the device architecture (armeabi-v7a/armeabi).’ 

### Steps

#### Visual Studio new Solution   

#### Studio new Android application

##### Bare new project - Release

Screenshot Visual Studio - all ABIs included -  not in csproj.

![Visual Studio - no ability to select Configuration it should apply to all (Debug, Release)](https://github.com/moljac/Xamarin.Test.Toolz/tree/master/logs/2013-08-19-[Xamarin Android Project targets]/screenshots/vs-android-app-properties-application-abis.png)

	  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
		<DebugType>pdbonly</DebugType>
		<Optimize>true</Optimize>
		<OutputPath>bin\Release\</OutputPath>
		<DefineConstants>TRACE</DefineConstants>
		<ErrorReport>prompt</ErrorReport>
		<WarningLevel>4</WarningLevel>
		<AndroidUseSharedRuntime>False</AndroidUseSharedRuntime>
		<AndroidStoreUncompressedFileExtensions>
		</AndroidStoreUncompressedFileExtensions>
		<JavaMaximumHeapSize>
		</JavaMaximumHeapSize>
		<JavaOptions>
		</JavaOptions>
	  </PropertyGroup>

Edit csproj excerpt:

	  <PropertyGroup>
		<Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
		<Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
		<ProductVersion>8.0.30703</ProductVersion>
		<SchemaVersion>2.0</SchemaVersion>
		<ProjectGuid>{7EC81EAC-F45A-43CB-AF32-FF98DD8FE531}</ProjectGuid>
		<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
		<OutputType>Library</OutputType>
		<AppDesignerFolder>Properties</AppDesignerFolder>
		<RootNamespace>AndroidApplication1</RootNamespace>
		<AssemblyName>AndroidApplication1</AssemblyName>
		<FileAlignment>512</FileAlignment>
		<AndroidApplication>true</AndroidApplication>
		<AndroidResgenFile>Resources\Resource.Designer.cs</AndroidResgenFile>
		<GenerateSerializationAssemblies>Off</GenerateSerializationAssemblies>
		<AndroidManifest>Properties\AndroidManifest.xml</AndroidManifest>
	  </PropertyGroup>
	  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
		<DebugSymbols>true</DebugSymbols>
		<DebugType>full</DebugType>
		<Optimize>false</Optimize>
		<OutputPath>bin\Debug\</OutputPath>
		<DefineConstants>DEBUG;TRACE</DefineConstants>
		<ErrorReport>prompt</ErrorReport>
		<WarningLevel>4</WarningLevel>
		<AndroidUseSharedRuntime>True</AndroidUseSharedRuntime>
		<AndroidLinkMode>None</AndroidLinkMode>
	  </PropertyGroup>
	  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
		<DebugType>pdbonly</DebugType>
		<Optimize>true</Optimize>
		<OutputPath>bin\Release\</OutputPath>
		<DefineConstants>TRACE</DefineConstants>
		<ErrorReport>prompt</ErrorReport>
		<WarningLevel>4</WarningLevel>
		<AndroidUseSharedRuntime>False</AndroidUseSharedRuntime>
		<AndroidLinkMode>SdkOnly</AndroidLinkMode>
	  </PropertyGroup>
	  
	  
#### Xamarin Studio fix to ad ABIs to Release

*	To set it for release mode - go to Xamarin Studio    
*	Android application Project +/ Options +/ Build +/ Android Build +/ Advanced    
*	Check all ABIs for Release and Debug configurations   

project file after editing:

	  <PropertyGroup>
		<Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
		<Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
		<ProductVersion>8.0.30703</ProductVersion>
		<SchemaVersion>2.0</SchemaVersion>
		<ProjectGuid>{7EC81EAC-F45A-43CB-AF32-FF98DD8FE531}</ProjectGuid>
		<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
		<OutputType>Library</OutputType>
		<AppDesignerFolder>Properties</AppDesignerFolder>
		<RootNamespace>AndroidApplication1</RootNamespace>
		<AssemblyName>AndroidApplication1</AssemblyName>
		<FileAlignment>512</FileAlignment>
		<AndroidApplication>true</AndroidApplication>
		<AndroidResgenFile>Resources\Resource.Designer.cs</AndroidResgenFile>
		<GenerateSerializationAssemblies>Off</GenerateSerializationAssemblies>
		<AndroidManifest>Properties\AndroidManifest.xml</AndroidManifest>
	  </PropertyGroup>
	  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
		<DebugSymbols>true</DebugSymbols>
		<DebugType>full</DebugType>
		<Optimize>false</Optimize>
		<OutputPath>bin\Debug\</OutputPath>
		<DefineConstants>DEBUG;TRACE</DefineConstants>
		<ErrorReport>prompt</ErrorReport>
		<WarningLevel>4</WarningLevel>
		<AndroidLinkMode>None</AndroidLinkMode>
		<AndroidSupportedAbis>armeabi,armeabi-v7a,x86</AndroidSupportedAbis>
	  </PropertyGroup>
	  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
		<DebugType>pdbonly</DebugType>
		<Optimize>true</Optimize>
		<OutputPath>bin\Release\</OutputPath>
		<DefineConstants>TRACE</DefineConstants>
		<ErrorReport>prompt</ErrorReport>
		<WarningLevel>4</WarningLevel>
		<AndroidUseSharedRuntime>False</AndroidUseSharedRuntime>
		<AndroidSupportedAbis>armeabi,armeabi-v7a,x86</AndroidSupportedAbis>
	  </PropertyGroup>


#### Project file after - Xamarin Studio

	 <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
		<DebugType>pdbonly</DebugType>
		<Optimize>true</Optimize>
		<OutputPath>bin\Release\</OutputPath>
		<DefineConstants>TRACE</DefineConstants>
		<ErrorReport>prompt</ErrorReport>
		<WarningLevel>4</WarningLevel>
		<AndroidUseSharedRuntime>False</AndroidUseSharedRuntime>
		<AndroidSupportedAbis>armeabi,armeabi-v7a,x86</AndroidSupportedAbis>
	  </PropertyGroup>
	 
	  
### Other Problems - AndroidSupportedAbis - character separator

This issue was observed during the investigation of above problems.
Note character separators in csproject file for AndroidSupportedAbis xml element:


* 	%3b == ';'
*	',' == %2c


This is not critical, but just to be noted. It is uncertain which tool added which data VS addin
or Xamarin Studio/Monodevelop (Comparison with projects generated with older VS addins)


	  <PropertyGroup>
		<Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
		<Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
		<ProductVersion>8.0.30703</ProductVersion>
		<SchemaVersion>2.0</SchemaVersion>
		<ProjectGuid>{91B7D53D-EE07-4CE8-AE20-CB8275293788}</ProjectGuid>
		<ProjectTypeGuids>{EFBA0AD7-5A72-4C68-AF49-83D382785DCF};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
		<OutputType>Library</OutputType>
		<AppDesignerFolder>Properties</AppDesignerFolder>
		<RootNamespace>MarkDownDeep.Android</RootNamespace>
		<AssemblyName>MarkDownDeep.Android</AssemblyName>
		<FileAlignment>512</FileAlignment>
		<AndroidApplication>true</AndroidApplication>
		<AndroidResgenFile>Resources\Resource.Designer.cs</AndroidResgenFile>
		<GenerateSerializationAssemblies>Off</GenerateSerializationAssemblies>
		<AndroidManifest>Properties\AndroidManifest.xml</AndroidManifest>
		<AndroidSupportedAbis>armeabi%3barmeabi-v7a%3bx86</AndroidSupportedAbis>
		<MandroidI18n />
		<AndroidStoreUncompressedFileExtensions />
		<JavaMaximumHeapSize />
		<JavaOptions />
	  </PropertyGroup>
	  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
		<DebugSymbols>true</DebugSymbols>
		<DebugType>full</DebugType>
		<Optimize>false</Optimize>
		<OutputPath>bin\Debug\</OutputPath>
		<DefineConstants>DEBUG;TRACE</DefineConstants>
		<ErrorReport>prompt</ErrorReport>
		<WarningLevel>4</WarningLevel>
		<AndroidLinkMode>None</AndroidLinkMode>
		<AndroidSupportedAbis>armeabi,armeabi-v7a,x86</AndroidSupportedAbis>
	  </PropertyGroup>
	  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
		<DebugType>pdbonly</DebugType>
		<Optimize>true</Optimize>
		<OutputPath>bin\Release\</OutputPath>
		<DefineConstants>TRACE</DefineConstants>
		<ErrorReport>prompt</ErrorReport>
		<WarningLevel>4</WarningLevel>
		<AndroidUseSharedRuntime>False</AndroidUseSharedRuntime>
		<AndroidStoreUncompressedFileExtensions>
		</AndroidStoreUncompressedFileExtensions>
		<JavaMaximumHeapSize>
		</JavaMaximumHeapSize>
		<JavaOptions>
		</JavaOptions>
	  </PropertyGroup>
	  