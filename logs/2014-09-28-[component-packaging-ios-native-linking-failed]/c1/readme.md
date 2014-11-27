# MarkDownSharp linker errors after packing - missing symbols



## 


Stable:

### Project: XSample.MarkDownSharp.XI	

Configuration: Debug | Device

			Undefined symbols for architecture armv7:
			  "_mono_aot_module_MarkDownSharp_iOS_info", referenced from:
				  _monotouch_register_modules in main.armv7.o
			ld: symbol(s) not found for architecture armv7
			clang: error: linker command failed with exit code 1 (use -v to see invocation)
		
	MTOUCHTASK: error MT5210: Native linking failed, undefined symbol: _mono_aot_module_MarkDownSharp_iOS_info. 
	Please verify that all the necessary frameworks have been referenced and native libraries are properly 
	linked in.

		
### Project XSample.MarkDownSharp.XI-Classic    


Configuration: Debug | Device

		Undefined symbols for architecture armv7:
		  "_mono_aot_module_MarkDownSharp_iOS_info", referenced from:
			  _monotouch_register_modules in main.armv7.o
		ld: symbol(s) not found for architecture armv7
		clang: error: linker command failed with exit code 1 (use -v to see invocation)

		error MT5210: Native linking failed, undefined symbol: _mono_aot_module_MarkDownSharp_iOS_info. 
		Please verify that all the necessary frameworks have been referenced and native libraries are 
		properly linked in.
		error MT5202: Native linking failed. Please review the build log.

### Project: 

Configuration: Release | Device	
				
		Undefined symbols for architecture armv7:
		  "_mono_aot_module_MarkDownSharp_iOS_info", referenced from:
			  _monotouch_register_modules in main.armv7.o
		ld: symbol(s) not found for architecture armv7
		clang: error: linker command failed with exit code 1 (use -v to see invocation)

		error MT5210: Native linking failed, undefined symbol: _mono_aot_module_MarkDownSharp_iOS_info. 
		Please verify that all the necessary frameworks have been referenced and native libraries are 
		properly linked in.
		error MT5202: Native linking failed. Please review the build log.

