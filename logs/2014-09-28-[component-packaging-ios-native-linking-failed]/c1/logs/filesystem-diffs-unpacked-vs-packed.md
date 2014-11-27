# Filesystem comparison Unpacked content vs packed (component)

## Unpacked

find content/ -type f | xargs grep 'mono_aot_module_Xamarin_iOS_info';

	Binary file content//samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/bin/unified/iPhone/Debug/XSampleMarkDownSharpXI.app/XSampleMarkDownSharpXI matches
	Binary file content//samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/bin/unified/iPhone/Debug/XSampleMarkDownSharpXI.app.dSYM/Contents/Resources/DWARF/XSampleMarkDownSharpXI matches
	content//samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/main.armv7.m:extern void *mono_aot_module_Xamarin_iOS_info;
	content//samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/main.armv7.m:	mono_aot_register_module (mono_aot_module_Xamarin_iOS_info);
	Binary file content//samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/main.armv7.o matches
	Binary file content//samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.armv7.o matches
	content//samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.armv7.s:	.globl _mono_aot_module_Xamarin_iOS_info
	content//samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.armv7.s:_mono_aot_module_Xamarin_iOS_info:

### shortened paths:

	Binary file XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/bin/unified/iPhone/Debug/XSampleMarkDownSharpXI.app/XSampleMarkDownSharpXI matches
	Binary file XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/bin/unified/iPhone/Debug/XSampleMarkDownSharpXI.app.dSYM/Contents/Resources/DWARF/XSampleMarkDownSharpXI matches
	XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/main.armv7.m:extern void *mono_aot_module_Xamarin_iOS_info;
	XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/main.armv7.m:	mono_aot_register_module (mono_aot_module_Xamarin_iOS_info);
	Binary file XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/main.armv7.o matches
	Binary file XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.armv7.o matches
	XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.armv7.s:	.globl _mono_aot_module_Xamarin_iOS_info
	XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.armv7.s:_mono_aot_module_Xamarin_iOS_info:


## packed

find MarkDownSharp-1.0.0.xam -type f | xargs grep 'mono_aot_module_Xamarin_iOS_info';

	MarkDownSharp-1.0.0.xam/MarkDownSharp-1.0.0/samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/main.armv7.m:extern void *mono_aot_module_Xamarin_iOS_info;
	MarkDownSharp-1.0.0.xam/MarkDownSharp-1.0.0/samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/main.armv7.m:	mono_aot_register_module (mono_aot_module_Xamarin_iOS_info);
	Binary file MarkDownSharp-1.0.0.xam/MarkDownSharp-1.0.0/samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/main.armv7.o matches
	Binary file MarkDownSharp-1.0.0.xam/MarkDownSharp-1.0.0/samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.armv7.o matches
	MarkDownSharp-1.0.0.xam/MarkDownSharp-1.0.0/samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.armv7.s:	.globl _mono_aot_module_Xamarin_iOS_info
	MarkDownSharp-1.0.0.xam/MarkDownSharp-1.0.0/samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.armv7.s:_mono_aot_module_Xamarin_iOS_info:

### shortened paths:

	XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/main.armv7.m:extern void *mono_aot_module_Xamarin_iOS_info;
	XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/main.armv7.m:	mono_aot_register_module (mono_aot_module_Xamarin_iOS_info);
	Binary file XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/main.armv7.o matches
	Binary file XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.armv7.o matches
	XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.armv7.s:	.globl _mono_aot_module_Xamarin_iOS_info
	XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/obj/unified/iPhone/Debug/mtouch-cache/Xamarin.iOS.dll.armv7.s:_mono_aot_module_Xamarin_iOS_info:


## Differences

*	original unpacked sample contains 2 extra files:

Binary file XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/bin/unified/iPhone/Debug/XSampleMarkDownSharpXI.app/XSampleMarkDownSharpXI matches
Binary file XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/bin/unified/iPhone/Debug/XSampleMarkDownSharpXI.app.dSYM/Contents/Resources/DWARF/XSampleMarkDownSharpXI matches
