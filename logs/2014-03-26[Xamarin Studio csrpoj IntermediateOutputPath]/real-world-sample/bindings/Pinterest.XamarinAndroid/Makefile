# common definitions in here
MONOXBUILD	= /Library/Frameworks/Mono.framework/Commands/xbuild
			# xbuild # old version
BTOUCH			=/Developer/MonoTouch/usr/bin/btouch
MDTOOL			=/Applications/Xamarin\ Studio.app/Contents/MacOS/mdtool 

RM				=rm
ECHO			=echo
CP				=cp

URL				=http://s3.amazonaws.com/pinterest-ota-builds/PinItSDKAndroid.zip
DLL				=Pinterest.XamarinAndroid.dll
COMPONENT_NAME	=Pinterest
PLATFORM		=XamarinAndroid

all:		clean debug release $(COMPONENT_NAME).$(PLATFORM).dll


PrepareJar:
			curl -L \
				-o Jars/PinItSDKAndroid.zip \
				$(URL)
			unzip \
				Jars/PinItSDKAndroid.zip \
				-d Jars/
			$(CP) \
				./Jars/PinItSDK/pinit-sdk-1.0.jar \
				./Jars/
			jar xf \
				Jars/PinItSDK/pinit-sdk-1.0-javadoc.jar \
				-d Jars/PinItSDK/


$(DLL): PrepareJar release
			$(CP) 	\
				bin/Release/$(COMPONENT_NAME).$(PLATFORM).dll \
				./

	
debug:		clean PrepareJar
			$(MONOXBUILD) \
				/p:Configuration=Debug \
				/verbosity:diagnostic \
				$(COMPONENT_NAME).$(PLATFORM).csproj
	

release:	clean PrepareJar
			$(MONOXBUILD) \
				/p:Configuration=Release \
				/verbosity:diagnostic \
				$(COMPONENT_NAME).$(PLATFORM).csproj
			$(CP) ./bin/Release/Pinterest.XamarinAndroid.dll ./

clean:	
			$(ECHO) =================================================================================
			$(ECHO) cleaning up in $(shell pwd)
			-$(RM) -fr bin/ obj/
			-$(RM) -f  $(EXE) $(OBJS) $(OBJLIBS) *.xam *.suo *.user .DS_Store
			-$(RM) -rf \
				bin/ obj/ \
				Jars/PinItSDK/ Jars/__MACOSX/ \
				*.sln *.userprefs *.dll \
				*.zip  \
				Jars/pinit-sdk-1.0.jar \
				Jars/PinItSDKAndroid.zip
	