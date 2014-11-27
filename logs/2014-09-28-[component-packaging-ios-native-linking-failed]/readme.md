# Native linking failed after packaging component

## Descriptions:

In Release (sometimes Debug) mode on the Device during component test (unpacking and testing) 
user gets:

			Undefined symbols for architecture armv7:
			  "_mono_aot_module_SOMENAME_info", referenced from:
				  _monotouch_register_modules in main.armv7.o
			ld: symbol(s) not found for architecture armv7
			clang: error: linker command failed with exit code 1 (use -v to see invocation)

Or unified iOS (less frequent than classic samples)

			Undefined symbols for architecture arm64:
			  "_mono_aot_module_SOMENAME_info", referenced from:
				  _monotouch_register_modules in main.arm64.o
			ld: symbol(s) not found for architecture arm64
			clang: error: linker command failed with exit code 1 (use -v to see invocation)
						
SOMENAME is

*	MarkDownSharp_iOS		
	in MarkDownSharp component		
*	PodradioTheme_iOs			
	in Podradio_Theme component

	
Before packaging everything works as expected.

Samples containing "Component" are samples with references to dll (to reduce possibility errors in
xamarin-component.exe transformations)

## Details

2 components 

*	c1 - MarkDownSharp
*	c2 - Podradio Theme

