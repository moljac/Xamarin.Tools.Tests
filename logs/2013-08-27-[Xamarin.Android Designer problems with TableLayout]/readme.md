## Xamarin.Android Desinger Problems With TableLayout


### Error

Android designer in Visual Studio and Xamarin Studio displays TableLayout with
additional column.

#### Android Layout (sample)

	<?xml version="1.0" encoding="utf-8"?>
	<TableLayout xmlns:p1="http://schemas.android.com/apk/res/android"
		p1:minWidth="25px"
		p1:minHeight="25px"
		p1:layout_width="fill_parent"
		p1:layout_height="fill_parent"
		p1:stretchColumns="*"
		p1:id="@+id/tableLayout1">
		<TableRow
			p1:id="@+id/tableRow1"
			p1:layout_width="fill_parent">
			<TextView
				p1:text="Arg 1:"
				p1:textAppearance="?android:attr/textAppearanceMedium"
				p1:layout_column="0"
				p1:id="@+id/textViewArg1"
				p1:layout_width="fill_parent" />
			<EditText
				p1:inputType="number"
				p1:layout_column="1"
				p1:id="@+id/editTextArg1"
				p1:layout_width="fill_parent" />
		</TableRow>
		<TableRow
			p1:id="@+id/tableRow2">
			<TextView
				p1:text="Arg 2:"
				p1:textAppearance="?android:attr/textAppearanceMedium"
				p1:layout_column="0"
				p1:id="@+id/textViewArg2"
				p1:layout_width="fill_parent" />
			<EditText
				p1:inputType="number"
				p1:layout_column="1"
				p1:id="@+id/editTextArg2"
				p1:layout_width="fill_parent" />
		</TableRow>
		<TableRow
			p1:id="@+id/tableRow3">
			<Button
				p1:text="+"
				p1:textAppearance="?android:attr/textAppearanceMedium"
				p1:layout_column="0"
				p1:id="@+id/buttonAddition"
				p1:layout_width="fill_parent" />
			<Button
				p1:text="-"
				p1:textAppearance="?android:attr/textAppearanceMedium"
				p1:layout_column="1"
				p1:id="@+id/buttonSubstraction"
				p1:layout_width="fill_parent" />
		</TableRow>
		<TableRow
			p1:id="@+id/tableRow4">
			<Button
				p1:text="*"
				p1:textAppearance="?android:attr/textAppearanceMedium"
				p1:layout_column="0"
				p1:id="@+id/buttonMultiplication"
				p1:layout_width="fill_parent" />
			<Button
				p1:text="/"
				p1:textAppearance="?android:attr/textAppearanceMedium"
				p1:layout_column="1"
				p1:id="@+id/buttonDivision"
				p1:layout_width="fill_parent" />
		</TableRow>
		<TableRow
			p1:id="@+id/tableRow5"
			p1:layout_width="fill_parent">
			<TextView
				p1:text="Result:"
				p1:textAppearance="?android:attr/textAppearanceMedium"
				p1:layout_column="0"
				p1:id="@+id/textViewResult"
				p1:layout_width="fill_parent" />
			<TextView
				p1:text="...."
				p1:textAppearance="?android:attr/textAppearanceMedium"
				p1:layout_column="1"
				p1:id="@+id/textViewResultObtained"
				p1:layout_width="fill_parent" />
		</TableRow>
		<TableRow
			p1:id="@+id/tableRow6"
			p1:layout_width="fill_parent">
			<TextView
				p1:text="XML-RPC Url:"
				p1:textAppearance="?android:attr/textAppearanceMedium"
				p1:layout_column="0"
				p1:layout_span="2"
				p1:id="@+id/textViewUrl"
				p1:layout_width="fill_parent" />
		</TableRow>
		<TableRow
			p1:id="@+id/tableRow7"
			p1:layout_width="fill_parent">
			<EditText
				p1:inputType="text"
				p1:layout_column="0"
				p1:layout_span="2"
				p1:id="@+id/editTextUrl"
				p1:layout_width="fill_parent" />
		</TableRow>
	</TableLayout>

### Images / Screenshots 

1.	Android Designer in Visual Studio  
	![Android Designer in Visual Studio](https://github.com/moljac/Xamarin.Test.Toolz/tree/master/logs/2013-08-27-%5BXamarin.Android%20Designer%20problems%20with%20TableLayout%5D/screenshots/Xamarin.Android-Designer-TableLayout-VS-CropperCapture[43].png)
1.	Android Designer in Visual Studio  
	![Android Designer in Visual Studio](https://github.com/moljac/Xamarin.Test.Toolz/tree/master/logs/2013-08-27-%5BXamarin.Android%20Designer%20problems%20with%20TableLayout%5D/screenshots/Xamarin.Android-Designer-TableLayout--XS-CropperCapture[47].png)
1.	Layout in emulator (OK)  
	![Android Designer in Visual Studio](https://github.com/moljac/Xamarin.Test.Toolz/tree/master/logs/2013-08-27-%5BXamarin.Android%20Designer%20problems%20with%20TableLayout%5D/screenshots/Xamarin.Android-Designer-TableLayout-layout-emulator-CropperCapture[44].png)

### Environment ###

#### Visual Studio Data 

	Microsoft Visual Studio 2010
	Version 10.0.40219.1 SP1Rel
	Microsoft .NET Framework
	Version 4.5.50709 SP1Rel

	Xamarin.Android   4.6.04000 (03814ac5)
	Visual Studio plugin to enable development for Xamarin.Android.

	Xamarin.iOS   1.1.200 (7d63692c)
	Visual Studio extension to enable development for Xamarin.iOS

#### Xamarin Studio Data

	Xamarin Studio
	Version 4.1.9 (build 6)
	Installation UUID: 44e4f747-b02b-430b-bd63-3e33a4f2653c
	Runtime:
		Microsoft .NET 4.0.30319.18052
		GTK+ 2.24.20 theme: MS-Windows
		GTK# (2.12.0.0)

	Xamarin.Android
	Version: 4.8.2 (Business Edition)
	Android SDK: C:\Program Files\Android\android-sdk
		Supported Android versions:
			1.6   (API level 4)
			2.1   (API level 7)
			2.2   (API level 8)
			2.3   (API level 10)
			3.1   (API level 12)
			3.2   (API level 13)
			4.0   (API level 14)
			4.0.3 (API level 15)
			4.1   (API level 16)
			4.2   (API level 17)
			4.3   (API level 18)
	Java SDK: C:\Program Files\Java\jdk1.6.0_39
	java version "1.6.0_39"
	Java(TM) SE Runtime Environment (build 1.6.0_39-b04)
	Java HotSpot(TM) Client VM (build 20.14-b01, mixed mode, sharing)

	Build Information
	Release ID: 401090006
	123fc693ab9ba2690f93fcfe2cd3499335049ff4
	Build date: 2013-08-06 13:13:03Z
	Xamarin addins: ad4a498b75333e43547e87574c1ec8c7cae05de0

	Operating System
	Windows 6.0.6002.131072

	
### References/Links

* 	[Details on github](https://github.com/moljac/Xamarin.Test.Toolz/tree/master/logs/2013-08-27-%5BXamarin.Android%20Designer%20problems%20with%20TableLayout%5D)
* 	[Forum](http://forums.xamarin.com/discussion/7479/xamarin-android-desinger-problems-with-tablelayout/p1)
*	[Bugzila](https://bugzilla.xamarin.com/show_bug.cgi?id=14320)
