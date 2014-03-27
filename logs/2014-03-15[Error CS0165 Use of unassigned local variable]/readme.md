# Mono 3.2.7 compile error for unassigned variable vs csc (.net 4.5) no errors.

## Description

During handport of one library from desktop to mobile profiles encountered following
error. 

Mono 3.2.7 compile error for unassigned variable. csc (.net 4.5) no errors.

This is the reduced sample - could not reduce it more and to stay reproducible. Sorry.

I'm not sure which behaviour is correct.


Related and possible duplicates:

*	[https://bugzilla.xamarin.com/show_bug.cgi?id=17519](https://bugzilla.xamarin.com/show_bug.cgi?id=17519)
*	[https://bugzilla.xamarin.com/show_bug.cgi?id=8388](https://bugzilla.xamarin.com/show_bug.cgi?id=8388)


## Mac OSX

$ mcs Program.cs 
Program.cs(13,9): warning CS0219: The variable `b' is assigned but its value is never used
Program.cs(30,24): error CS0165: Use of unassigned local variable `m'
Compilation failed: 1 error(s), 1 warnings
$ which mcs
/Library/Frameworks/Mono.framework/Versions/3.2.7/bin/mcs

## Windows 7

\\vmware-host\Shared Folders\Desktop\Xamarin.Test.Toolz\logs\Error CS0165 Use of unassigned local variable\ConsoleApplic
ation1>c:\Windows\Microsoft.NET\Framework\v4.0.30319\csc Program.cs
Microsoft (R) Visual C# Compiler version 4.0.30319.18408
for Microsoft (R) .NET Framework 4.5
Copyright (C) Microsoft Corporation. All rights reserved.

Program.cs(21,9): warning CS0219: The variable 'b_const' is assigned but its value is never used

\\vmware-host\Shared Folders\Desktop\Xamarin.Test.Toolz\logs\Error CS0165 Use of unassigned local variable\ConsoleApplic
ation1>

## Sample

	#define ERROR
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	namespace ConsoleApplication1
	{
		class Program
		{
			static void Main(string[] args)
			{
				bool b = SomeMethod();

			}

			private static bool SomeMethod()
			{
				int m;
				int n = 2;
				bool b_const = true;
				
				// XS use of unassigned variable !!
				// VS 2012 OK.
				bool b = 
						F( 
							() => 
								F1(n, out m) 
								&&  
								Ferror( n + 1 + m )
						)
					#if ERROR
					// Error CS0165: Use of unassigned local variable `m' (CS0165)
						&&
						true
					#endif
						;

				return b;
			}

			protected static bool F(Func<bool> rule) // (join) 
			{
				return true;
			}

			private static bool F1(int j, out int m)
			{
				m = 2;

				return true;
			}

			private static bool Ferror(int i)
			{
				return true;
			}

			private static bool Fouter()
			{
				return true;
			}
		}
	}


