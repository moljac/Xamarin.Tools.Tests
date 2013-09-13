## Android Architeture

### Steps

1.	Visual Studio new Solution   
1.	Visual Studio new Android application
1.  Edit csproj excerpt:
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
1. 	compared with some projects probably generated with older VS addins   
	Several issues:     
	AndroidSupportedAbis has separator once ',' (urlencoded %2C) and once %3b which is ';'   
	AndroidSupportedAbis in release is not set (though in UI it is impossible to check configuration)   
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
1.	To set it for release mode - go to Xamarin Studio    
	Android application Project +/ Options +/ Build +/ Android Build +/ Advanced    
	Check all ABIs for Release and Debug configurations   
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


### Issues

1.	in Visual Studio - no ability to select Configuration   
	it should apply to all (Debug, Release)
2.	Xamarin Studio - explicilty go to Release and add all architectures   
	
2.  values separation

