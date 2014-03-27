# common definitions in here
MONOXBUILD	= /Library/Frameworks/Mono.framework/Commands/xbuild
			# xbuild # old version
BTOUCH		=/Developer/MonoTouch/usr/bin/btouch
MDTOOL		=/Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool 

RM			=rm
ECHO		=echo
CP			=cp

DIRS		= src samples component



all:		clean debug release

binding:
			cd ../../bindings/Pinterest.XamarinAndroid/ && make

debug:		binding
			$(MONOXBUILD) \
				/p:Configuration=Debug \
				/verbosity:diagnostic \
				Pinterest.App.XamarinAndroid.csproj
			$(MONOXBUILD) \
				/p:Configuration=Debug \
				/verbosity:diagnostic \
				Pinterest.App.XamarinAndroid.ComponentStore.csproj
	

release:	binding
			$(MONOXBUILD) \
				/p:Configuration=Release \
				/verbosity:diagnostic \
				Pinterest.App.XamarinAndroid.csproj
			$(MONOXBUILD) \
				/p:Configuration=Release \
				/verbosity:diagnostic \
				Pinterest.App.XamarinAndroid.ComponentStore.csproj

				
clean:	
			$(ECHO) =================================================================================
			$(ECHO) cleaning up in $(shell pwd)
			-$(RM) -fr bin/ obj/
			-$(RM) -f  $(EXE) $(OBJS) $(OBJLIBS) *.xam *.suo *.user .DS_Store
	