# Packaging Project File Diffs

command:

	diff \
		MarkDownSharp-1.0.0.xam/MarkDownSharp-1.0.0/samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI.csproj \
		content/samples/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI/XSample.MarkDownSharp.XI.csproj

diff:
		
	24c24,25
	<     <MtouchI18n></MtouchI18n>
	---
	>     <MtouchI18n>
	>     </MtouchI18n>
	51,52c52,55
	<     <IpaPackageName></IpaPackageName>
	<     <MtouchI18n></MtouchI18n>
	---
	>     <IpaPackageName>
	>     </IpaPackageName>
	>     <MtouchI18n>
	>     </MtouchI18n>

	
	
*	In package file		
	MarkDownSharp-1.0.0.xam\MarkDownSharp-1.0.0\samples\XSample.MarkDownSharp.XI\XSample.MarkDownSharp.XI\XSample.MarkDownSharp.XI.csproj		
	newlines are removed in <IpaPackageName /> and <MtouchI18n/>