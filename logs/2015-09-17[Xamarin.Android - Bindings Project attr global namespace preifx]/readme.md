# Xamarin.Android Bindings Project global namespace prefix

Using global:: namespace prefix for managedReturn causes exception.

	<attr
		path="/api/package[@name='com.brightcove.player.event']/class[@name='RegisteringEventEmitter']/method[@name='build']"
		name="managedReturn"
		>
		global::Java.Lang.Object
	</attr>

Code not causing exception:

	<attr
		path="/api/package[@name='com.brightcove.player.event']/class[@name='RegisteringEventEmitter']/method[@name='build']"
		name="managedReturn"
		>
		Java.Lang.Object
	</attr>
	
	
## Exception Details

		Unhandled Exception:
		System.Exception: global::Java.Lang.Object
		  at MonoDroid.Generation.CodeGenerationOptions.GetOutputName (System.String s) [0x00000] in <filename unknown>:0 
		  at MonoDroid.Generation.Method.Generate (System.IO.StreamWriter sw, System.String indent, MonoDroid.Generation.CodeGenerationOptions opt, MonoDroid.Generation.GenBase type, Boolean generate_callbacks) [0x00000] in <filename unknown>:0 
		  at MonoDroid.Generation.ClassGen.GenMethods (System.IO.StreamWriter sw, System.String indent, MonoDroid.Generation.CodeGenerationOptions opt) [0x00000] in <filename unknown>:0 
		  at MonoDroid.Generation.ClassGen.Generate (System.IO.StreamWriter sw, System.String indent, MonoDroid.Generation.CodeGenerationOptions opt, MonoDroid.Generation.GenerationInfo gen_info) [0x00000] in <filename unknown>:0 
		  at MonoDroid.Generation.ClassGen.Generate (MonoDroid.Generation.CodeGenerationOptions opt, MonoDroid.Generation.GenerationInfo gen_info) [0x00000] in <filename unknown>:0 
		  at Xamarin.Android.Binder.CodeGenerator.Run (Xamarin.Android.Binder.CodeGeneratorOptions options) [0x00000] in <filename unknown>:0 
		  at Xamarin.Android.Binder.CodeGenerator.Main (System.String[] args) [0x00000] in <filename unknown>:0 
		[ERROR] FATAL UNHANDLED EXCEPTION: System.Exception: global::Java.Lang.Object
		  at MonoDroid.Generation.CodeGenerationOptions.GetOutputName (System.String s) [0x00000] in <filename unknown>:0 
		  at MonoDroid.Generation.Method.Generate (System.IO.StreamWriter sw, System.String indent, MonoDroid.Generation.CodeGenerationOptions opt, MonoDroid.Generation.GenBase type, Boolean generate_callbacks) [0x00000] in <filename unknown>:0 
		  at MonoDroid.Generation.ClassGen.GenMethods (System.IO.StreamWriter sw, System.String indent, MonoDroid.Generation.CodeGenerationOptions opt) [0x00000] in <filename unknown>:0 
		  at MonoDroid.Generation.ClassGen.Generate (System.IO.StreamWriter sw, System.String indent, MonoDroid.Generation.CodeGenerationOptions opt, MonoDroid.Generation.GenerationInfo gen_info) [0x00000] in <filename unknown>:0 
		  at MonoDroid.Generation.ClassGen.Generate (MonoDroid.Generation.CodeGenerationOptions opt, MonoDroid.Generation.GenerationInfo gen_info) [0x00000] in <filename unknown>:0 
		  at Xamarin.Android.Binder.CodeGenerator.Run (Xamarin.Android.Binder.CodeGeneratorOptions options) [0x00000] in <filename unknown>:0 
		  at Xamarin.Android.Binder.CodeGenerator.Main (System.String[] args) [0x00000] in <filename unknown>:0 
		 (BindingsMinimalSample)  
	
## Tools affected

all
	
## References/Links

	
	
## Further Information

*	[]()
	
