using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Twilio.IPMessaging {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']"
	[global::Android.Runtime.Register ("com/twilio/ipmessaging/IPMessagingClient", DoNotGenerateAcw=true)]
	public abstract partial class IPMessagingClient : global::Java.Lang.Object {


		static IntPtr channelMap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/field[@name='channelMap']"
		[Register ("channelMap")]
		public global::System.Collections.IDictionary ChannelMap {
			get {
				if (channelMap_jfieldId == IntPtr.Zero)
					channelMap_jfieldId = JNIEnv.GetFieldID (class_ref, "channelMap", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, channelMap_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (channelMap_jfieldId == IntPtr.Zero)
					channelMap_jfieldId = JNIEnv.GetFieldID (class_ref, "channelMap", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, channelMap_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr endpointPlatform_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/field[@name='endpointPlatform']"
		[Register ("endpointPlatform")]
		protected string EndpointPlatform {
			get {
				if (endpointPlatform_jfieldId == IntPtr.Zero)
					endpointPlatform_jfieldId = JNIEnv.GetFieldID (class_ref, "endpointPlatform", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, endpointPlatform_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (endpointPlatform_jfieldId == IntPtr.Zero)
					endpointPlatform_jfieldId = JNIEnv.GetFieldID (class_ref, "endpointPlatform", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, endpointPlatform_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ipMessagingListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/field[@name='ipMessagingListener']"
		[Register ("ipMessagingListener")]
		private global::Twilio.IPMessaging.IPMessagingClientListener IpMessagingListener {
			get {
				if (ipMessagingListener_jfieldId == IntPtr.Zero)
					ipMessagingListener_jfieldId = JNIEnv.GetFieldID (class_ref, "ipMessagingListener", "Lcom/twilio/ipmessaging/IPMessagingClientListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ipMessagingListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClientListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ipMessagingListener_jfieldId == IntPtr.Zero)
					ipMessagingListener_jfieldId = JNIEnv.GetFieldID (class_ref, "ipMessagingListener", "Lcom/twilio/ipmessaging/IPMessagingClientListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ipMessagingListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.Properties']"
		[global::Android.Runtime.Register ("com/twilio/ipmessaging/IPMessagingClient$Properties", DoNotGenerateAcw=true)]
		public partial class Properties : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.Properties.Builder']"
			[global::Android.Runtime.Register ("com/twilio/ipmessaging/IPMessagingClient$Properties$Builder", DoNotGenerateAcw=true)]
			public partial class Builder : global::Java.Lang.Object {

				internal static IntPtr java_class_handle;
				internal static IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/twilio/ipmessaging/IPMessagingClient$Properties$Builder", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Builder); }
				}

				protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_ctor;
				// Metadata.xml XPath constructor reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.Properties.Builder']/constructor[@name='IPMessagingClient.Properties.Builder' and count(parameter)=0]"
				[Register (".ctor", "()V", "")]
				public unsafe Builder ()
					: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
				{
					if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
						return;

					try {
						if (GetType () != typeof (Builder)) {
							SetHandle (
									global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
									JniHandleOwnership.TransferLocalRef);
							global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
							return;
						}

						if (id_ctor == IntPtr.Zero)
							id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
								JniHandleOwnership.TransferLocalRef);
						JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
					} finally {
					}
				}

				static Delegate cb_createProperties;
#pragma warning disable 0169
				static Delegate GetCreatePropertiesHandler ()
				{
					if (cb_createProperties == null)
						cb_createProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateProperties);
					return cb_createProperties;
				}

				static IntPtr n_CreateProperties (IntPtr jnienv, IntPtr native__this)
				{
					global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle (__this.CreateProperties ());
				}
#pragma warning restore 0169

				static IntPtr id_createProperties;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.Properties.Builder']/method[@name='createProperties' and count(parameter)=0]"
				[Register ("createProperties", "()Lcom/twilio/ipmessaging/IPMessagingClient$Properties;", "GetCreatePropertiesHandler")]
				public virtual unsafe global::Twilio.IPMessaging.IPMessagingClient.Properties CreateProperties ()
				{
					if (id_createProperties == IntPtr.Zero)
						id_createProperties = JNIEnv.GetMethodID (class_ref, "createProperties", "()Lcom/twilio/ipmessaging/IPMessagingClient$Properties;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createProperties), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createProperties", "()Lcom/twilio/ipmessaging/IPMessagingClient$Properties;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}

				static Delegate cb_setInitialMessageCount_I;
#pragma warning disable 0169
				static Delegate GetSetInitialMessageCount_IHandler ()
				{
					if (cb_setInitialMessageCount_I == null)
						cb_setInitialMessageCount_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetInitialMessageCount_I);
					return cb_setInitialMessageCount_I;
				}

				static IntPtr n_SetInitialMessageCount_I (IntPtr jnienv, IntPtr native__this, int initialMessageCount)
				{
					global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return JNIEnv.ToLocalJniHandle (__this.SetInitialMessageCount (initialMessageCount));
				}
#pragma warning restore 0169

				static IntPtr id_setInitialMessageCount_I;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.Properties.Builder']/method[@name='setInitialMessageCount' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("setInitialMessageCount", "(I)Lcom/twilio/ipmessaging/IPMessagingClient$Properties$Builder;", "GetSetInitialMessageCount_IHandler")]
				public virtual unsafe global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder SetInitialMessageCount (int initialMessageCount)
				{
					if (id_setInitialMessageCount_I == IntPtr.Zero)
						id_setInitialMessageCount_I = JNIEnv.GetMethodID (class_ref, "setInitialMessageCount", "(I)Lcom/twilio/ipmessaging/IPMessagingClient$Properties$Builder;");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (initialMessageCount);

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setInitialMessageCount_I, __args), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInitialMessageCount", "(I)Lcom/twilio/ipmessaging/IPMessagingClient$Properties$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}

				static Delegate cb_setRegion_Ljava_lang_String_;
#pragma warning disable 0169
				static Delegate GetSetRegion_Ljava_lang_String_Handler ()
				{
					if (cb_setRegion_Ljava_lang_String_ == null)
						cb_setRegion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRegion_Ljava_lang_String_);
					return cb_setRegion_Ljava_lang_String_;
				}

				static IntPtr n_SetRegion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_region)
				{
					global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					string region = JNIEnv.GetString (native_region, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRegion (region));
					return __ret;
				}
#pragma warning restore 0169

				static IntPtr id_setRegion_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.Properties.Builder']/method[@name='setRegion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setRegion", "(Ljava/lang/String;)Lcom/twilio/ipmessaging/IPMessagingClient$Properties$Builder;", "GetSetRegion_Ljava_lang_String_Handler")]
				public virtual unsafe global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder SetRegion (string region)
				{
					if (id_setRegion_Ljava_lang_String_ == IntPtr.Zero)
						id_setRegion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRegion", "(Ljava/lang/String;)Lcom/twilio/ipmessaging/IPMessagingClient$Properties$Builder;");
					IntPtr native_region = JNIEnv.NewString (region);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_region);

						global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder __ret;
						if (GetType () == ThresholdType)
							__ret = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setRegion_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
						else
							__ret = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegion", "(Ljava/lang/String;)Lcom/twilio/ipmessaging/IPMessagingClient$Properties$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
						return __ret;
					} finally {
						JNIEnv.DeleteLocalRef (native_region);
					}
				}

				static Delegate cb_setSynchronizationStrategy_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_;
#pragma warning disable 0169
				static Delegate GetSetSynchronizationStrategy_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_Handler ()
				{
					if (cb_setSynchronizationStrategy_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_ == null)
						cb_setSynchronizationStrategy_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSynchronizationStrategy_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_);
					return cb_setSynchronizationStrategy_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_;
				}

				static IntPtr n_SetSynchronizationStrategy_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_synchStrategy)
				{
					global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy synchStrategy = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy> (native_synchStrategy, JniHandleOwnership.DoNotTransfer);
					IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSynchronizationStrategy (synchStrategy));
					return __ret;
				}
#pragma warning restore 0169

				static IntPtr id_setSynchronizationStrategy_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.Properties.Builder']/method[@name='setSynchronizationStrategy' and count(parameter)=1 and parameter[1][@type='com.twilio.ipmessaging.IPMessagingClient.SynchronizationStrategy']]"
				[Register ("setSynchronizationStrategy", "(Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;)Lcom/twilio/ipmessaging/IPMessagingClient$Properties$Builder;", "GetSetSynchronizationStrategy_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_Handler")]
				public virtual unsafe global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder SetSynchronizationStrategy (global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy synchStrategy)
				{
					if (id_setSynchronizationStrategy_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_ == IntPtr.Zero)
						id_setSynchronizationStrategy_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_ = JNIEnv.GetMethodID (class_ref, "setSynchronizationStrategy", "(Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;)Lcom/twilio/ipmessaging/IPMessagingClient$Properties$Builder;");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (synchStrategy);

						global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder __ret;
						if (GetType () == ThresholdType)
							__ret = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSynchronizationStrategy_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_, __args), JniHandleOwnership.TransferLocalRef);
						else
							__ret = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties.Builder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSynchronizationStrategy", "(Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;)Lcom/twilio/ipmessaging/IPMessagingClient$Properties$Builder;"), __args), JniHandleOwnership.TransferLocalRef);
						return __ret;
					} finally {
					}
				}

			}

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/twilio/ipmessaging/IPMessagingClient$Properties", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Properties); }
			}

			protected Properties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_ILjava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.Properties']/constructor[@name='IPMessagingClient.Properties' and count(parameter)=3 and parameter[1][@type='com.twilio.ipmessaging.IPMessagingClient.SynchronizationStrategy'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
			[Register (".ctor", "(Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;ILjava/lang/String;)V", "")]
			protected unsafe Properties (global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy synchronizationStrategy, int initialMessageCount, string region)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_region = JNIEnv.NewString (region);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (synchronizationStrategy);
					__args [1] = new JValue (initialMessageCount);
					__args [2] = new JValue (native_region);
					if (GetType () != typeof (Properties)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;ILjava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;ILjava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_ILjava_lang_String_ == IntPtr.Zero)
						id_ctor_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;ILjava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_ILjava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_twilio_ipmessaging_IPMessagingClient_SynchronizationStrategy_ILjava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_region);
				}
			}

			static Delegate cb_getInitialMessageCount;
#pragma warning disable 0169
			static Delegate GetGetInitialMessageCountHandler ()
			{
				if (cb_getInitialMessageCount == null)
					cb_getInitialMessageCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInitialMessageCount);
				return cb_getInitialMessageCount;
			}

			static int n_GetInitialMessageCount (IntPtr jnienv, IntPtr native__this)
			{
				global::Twilio.IPMessaging.IPMessagingClient.Properties __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.InitialMessageCount;
			}
#pragma warning restore 0169

			static IntPtr id_getInitialMessageCount;
			public virtual unsafe int InitialMessageCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.Properties']/method[@name='getInitialMessageCount' and count(parameter)=0]"
				[Register ("getInitialMessageCount", "()I", "GetGetInitialMessageCountHandler")]
				get {
					if (id_getInitialMessageCount == IntPtr.Zero)
						id_getInitialMessageCount = JNIEnv.GetMethodID (class_ref, "getInitialMessageCount", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInitialMessageCount);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInitialMessageCount", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getRegion;
#pragma warning disable 0169
			static Delegate GetGetRegionHandler ()
			{
				if (cb_getRegion == null)
					cb_getRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegion);
				return cb_getRegion;
			}

			static IntPtr n_GetRegion (IntPtr jnienv, IntPtr native__this)
			{
				global::Twilio.IPMessaging.IPMessagingClient.Properties __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Region);
			}
#pragma warning restore 0169

			static IntPtr id_getRegion;
			public virtual unsafe string Region {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.Properties']/method[@name='getRegion' and count(parameter)=0]"
				[Register ("getRegion", "()Ljava/lang/String;", "GetGetRegionHandler")]
				get {
					if (id_getRegion == IntPtr.Zero)
						id_getRegion = JNIEnv.GetMethodID (class_ref, "getRegion", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRegion), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getSynchronizationStrategy;
#pragma warning disable 0169
			static Delegate GetGetSynchronizationStrategyHandler ()
			{
				if (cb_getSynchronizationStrategy == null)
					cb_getSynchronizationStrategy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSynchronizationStrategy);
				return cb_getSynchronizationStrategy;
			}

			static IntPtr n_GetSynchronizationStrategy (IntPtr jnienv, IntPtr native__this)
			{
				global::Twilio.IPMessaging.IPMessagingClient.Properties __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.Properties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SynchronizationStrategy);
			}
#pragma warning restore 0169

			static IntPtr id_getSynchronizationStrategy;
			public virtual unsafe global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy SynchronizationStrategy {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.Properties']/method[@name='getSynchronizationStrategy' and count(parameter)=0]"
				[Register ("getSynchronizationStrategy", "()Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;", "GetGetSynchronizationStrategyHandler")]
				get {
					if (id_getSynchronizationStrategy == IntPtr.Zero)
						id_getSynchronizationStrategy = JNIEnv.GetMethodID (class_ref, "getSynchronizationStrategy", "()Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSynchronizationStrategy), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSynchronizationStrategy", "()Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStatus']"
		[global::Android.Runtime.Register ("com/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus", DoNotGenerateAcw=true)]
		public sealed partial class SynchronizationStatus : global::Java.Lang.Enum {


			static IntPtr CHANNELS_COMPLETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStatus']/field[@name='CHANNELS_COMPLETED']"
			[Register ("CHANNELS_COMPLETED")]
			public static global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus ChannelsCompleted {
				get {
					if (CHANNELS_COMPLETED_jfieldId == IntPtr.Zero)
						CHANNELS_COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHANNELS_COMPLETED", "Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHANNELS_COMPLETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMPLETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStatus']/field[@name='COMPLETED']"
			[Register ("COMPLETED")]
			public static global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus Completed {
				get {
					if (COMPLETED_jfieldId == IntPtr.Zero)
						COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED", "Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FAILED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStatus']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus Failed {
				get {
					if (FAILED_jfieldId == IntPtr.Zero)
						FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED", "Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STARTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStatus']/field[@name='STARTED']"
			[Register ("STARTED")]
			public static global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus Started {
				get {
					if (STARTED_jfieldId == IntPtr.Zero)
						STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STARTED", "Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STARTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SynchronizationStatus); }
			}

			internal SynchronizationStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStatus']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
					try {
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
					} finally {
					}
				}
			}

			static IntPtr id_fromInt_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStatus']/method[@name='fromInt' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromInt", "(I)Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus;", "")]
			public static unsafe global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus FromInt (int value)
			{
				if (id_fromInt_I == IntPtr.Zero)
					id_fromInt_I = JNIEnv.GetStaticMethodID (class_ref, "fromInt", "(I)Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromInt_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus;", "")]
			public static unsafe global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus __ret = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus;", "")]
			public static unsafe global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStatus;");
				try {
					return (global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStatus));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStrategy']"
		[global::Android.Runtime.Register ("com/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy", DoNotGenerateAcw=true)]
		public sealed partial class SynchronizationStrategy : global::Java.Lang.Enum {


			static IntPtr ALL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStrategy']/field[@name='ALL']"
			[Register ("ALL")]
			public static global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy All {
				get {
					if (ALL_jfieldId == IntPtr.Zero)
						ALL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL", "Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CHANNELS_LIST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStrategy']/field[@name='CHANNELS_LIST']"
			[Register ("CHANNELS_LIST")]
			public static global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy ChannelsList {
				get {
					if (CHANNELS_LIST_jfieldId == IntPtr.Zero)
						CHANNELS_LIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHANNELS_LIST", "Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHANNELS_LIST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SynchronizationStrategy); }
			}

			internal SynchronizationStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStrategy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;", "")]
			public static unsafe global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy __ret = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient.SynchronizationStrategy']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;", "")]
			public static unsafe global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/twilio/ipmessaging/IPMessagingClient$SynchronizationStrategy;");
				try {
					return (global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Twilio.IPMessaging.IPMessagingClient.SynchronizationStrategy));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/twilio/ipmessaging/IPMessagingClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPMessagingClient); }
		}

		protected IPMessagingClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getChannels;
#pragma warning disable 0169
		static Delegate GetGetChannelsHandler ()
		{
			if (cb_getChannels == null)
				cb_getChannels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannels);
			return cb_getChannels;
		}

		static IntPtr n_GetChannels (IntPtr jnienv, IntPtr native__this)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Channels);
		}
#pragma warning restore 0169

		static IntPtr id_getChannels;
		public virtual unsafe global::Twilio.IPMessaging.Channels Channels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='getChannels' and count(parameter)=0]"
			[Register ("getChannels", "()Lcom/twilio/ipmessaging/Channels;", "GetGetChannelsHandler")]
			get {
				if (id_getChannels == IntPtr.Zero)
					id_getChannels = JNIEnv.GetMethodID (class_ref, "getChannels", "()Lcom/twilio/ipmessaging/Channels;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.Channels> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannels), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.Channels> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannels", "()Lcom/twilio/ipmessaging/Channels;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInternalListener;
#pragma warning disable 0169
		static Delegate GetGetInternalListenerHandler ()
		{
			if (cb_getInternalListener == null)
				cb_getInternalListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInternalListener);
			return cb_getInternalListener;
		}

		static IntPtr n_GetInternalListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InternalListener);
		}
#pragma warning restore 0169

		static IntPtr id_getInternalListener;
		protected virtual unsafe global::Com.Twilio.Ipmessaging.Internal.ClientListener InternalListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='getInternalListener' and count(parameter)=0]"
			[Register ("getInternalListener", "()Lcom/twilio/ipmessaging/internal/ClientListener;", "GetGetInternalListenerHandler")]
			get {
				if (id_getInternalListener == IntPtr.Zero)
					id_getInternalListener = JNIEnv.GetMethodID (class_ref, "getInternalListener", "()Lcom/twilio/ipmessaging/internal/ClientListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Twilio.Ipmessaging.Internal.ClientListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInternalListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Twilio.Ipmessaging.Internal.ClientListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInternalListener", "()Lcom/twilio/ipmessaging/internal/ClientListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isReachabilityEnabled;
#pragma warning disable 0169
		static Delegate GetIsReachabilityEnabledHandler ()
		{
			if (cb_isReachabilityEnabled == null)
				cb_isReachabilityEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReachabilityEnabled);
			return cb_isReachabilityEnabled;
		}

		static bool n_IsReachabilityEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReachabilityEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isReachabilityEnabled;
		public virtual unsafe bool IsReachabilityEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='isReachabilityEnabled' and count(parameter)=0]"
			[Register ("isReachabilityEnabled", "()Z", "GetIsReachabilityEnabledHandler")]
			get {
				if (id_isReachabilityEnabled == IntPtr.Zero)
					id_isReachabilityEnabled = JNIEnv.GetMethodID (class_ref, "isReachabilityEnabled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReachabilityEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReachabilityEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getListener;
#pragma warning disable 0169
		static Delegate GetGetListenerHandler ()
		{
			if (cb_getListener == null)
				cb_getListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetListener);
			return cb_getListener;
		}

		static IntPtr n_GetListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Listener);
		}
#pragma warning restore 0169

		static Delegate cb_setListener_Lcom_twilio_ipmessaging_IPMessagingClientListener_;
#pragma warning disable 0169
		static Delegate GetSetListener_Lcom_twilio_ipmessaging_IPMessagingClientListener_Handler ()
		{
			if (cb_setListener_Lcom_twilio_ipmessaging_IPMessagingClientListener_ == null)
				cb_setListener_Lcom_twilio_ipmessaging_IPMessagingClientListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetListener_Lcom_twilio_ipmessaging_IPMessagingClientListener_);
			return cb_setListener_Lcom_twilio_ipmessaging_IPMessagingClientListener_;
		}

		static void n_SetListener_Lcom_twilio_ipmessaging_IPMessagingClientListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Twilio.IPMessaging.IPMessagingClientListener listener = (global::Twilio.IPMessaging.IPMessagingClientListener)global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClientListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.Listener = listener;
		}
#pragma warning restore 0169

		static IntPtr id_getListener;
		static IntPtr id_setListener_Lcom_twilio_ipmessaging_IPMessagingClientListener_;
		public virtual unsafe global::Twilio.IPMessaging.IPMessagingClientListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lcom/twilio/ipmessaging/IPMessagingClientListener;", "GetGetListenerHandler")]
			get {
				if (id_getListener == IntPtr.Zero)
					id_getListener = JNIEnv.GetMethodID (class_ref, "getListener", "()Lcom/twilio/ipmessaging/IPMessagingClientListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClientListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClientListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getListener", "()Lcom/twilio/ipmessaging/IPMessagingClientListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.twilio.ipmessaging.IPMessagingClientListener']]"
			[Register ("setListener", "(Lcom/twilio/ipmessaging/IPMessagingClientListener;)V", "GetSetListener_Lcom_twilio_ipmessaging_IPMessagingClientListener_Handler")]
			set {
				if (id_setListener_Lcom_twilio_ipmessaging_IPMessagingClientListener_ == IntPtr.Zero)
					id_setListener_Lcom_twilio_ipmessaging_IPMessagingClientListener_ = JNIEnv.GetMethodID (class_ref, "setListener", "(Lcom/twilio/ipmessaging/IPMessagingClientListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setListener_Lcom_twilio_ipmessaging_IPMessagingClientListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setListener", "(Lcom/twilio/ipmessaging/IPMessagingClientListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMyUserInfo;
#pragma warning disable 0169
		static Delegate GetGetMyUserInfoHandler ()
		{
			if (cb_getMyUserInfo == null)
				cb_getMyUserInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMyUserInfo);
			return cb_getMyUserInfo;
		}

		static IntPtr n_GetMyUserInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MyUserInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getMyUserInfo;
		public virtual unsafe global::Twilio.IPMessaging.UserInfo MyUserInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='getMyUserInfo' and count(parameter)=0]"
			[Register ("getMyUserInfo", "()Lcom/twilio/ipmessaging/UserInfo;", "GetGetMyUserInfoHandler")]
			get {
				if (id_getMyUserInfo == IntPtr.Zero)
					id_getMyUserInfo = JNIEnv.GetMethodID (class_ref, "getMyUserInfo", "()Lcom/twilio/ipmessaging/UserInfo;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.UserInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMyUserInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.UserInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMyUserInfo", "()Lcom/twilio/ipmessaging/UserInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSdkVersion;
		public static unsafe string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler")]
			get {
				if (id_getSdkVersion == IntPtr.Zero)
					id_getSdkVersion = JNIEnv.GetStaticMethodID (class_ref, "getSdkVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSdkVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_removeListener;
#pragma warning disable 0169
		static Delegate GetRemoveListenerHandler ()
		{
			if (cb_removeListener == null)
				cb_removeListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveListener);
			return cb_removeListener;
		}

		static void n_RemoveListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener ();
		}
#pragma warning restore 0169

		static IntPtr id_removeListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='removeListener' and count(parameter)=0]"
		[Register ("removeListener", "()V", "GetRemoveListenerHandler")]
		public virtual unsafe void RemoveListener ()
		{
			if (id_removeListener == IntPtr.Zero)
				id_removeListener = JNIEnv.GetMethodID (class_ref, "removeListener", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeListener);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeListener", "()V"));
			} finally {
			}
		}

		static Delegate cb_setIncomingIntent_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetSetIncomingIntent_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_setIncomingIntent_Landroid_app_PendingIntent_ == null)
				cb_setIncomingIntent_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIncomingIntent_Landroid_app_PendingIntent_);
			return cb_setIncomingIntent_Landroid_app_PendingIntent_;
		}

		static void n_SetIncomingIntent_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.PendingIntent intent = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.SetIncomingIntent (intent);
		}
#pragma warning restore 0169

		static IntPtr id_setIncomingIntent_Landroid_app_PendingIntent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='setIncomingIntent' and count(parameter)=1 and parameter[1][@type='android.app.PendingIntent']]"
		[Register ("setIncomingIntent", "(Landroid/app/PendingIntent;)V", "GetSetIncomingIntent_Landroid_app_PendingIntent_Handler")]
		public virtual unsafe void SetIncomingIntent (global::Android.App.PendingIntent intent)
		{
			if (id_setIncomingIntent_Landroid_app_PendingIntent_ == IntPtr.Zero)
				id_setIncomingIntent_Landroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "setIncomingIntent", "(Landroid/app/PendingIntent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (intent);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIncomingIntent_Landroid_app_PendingIntent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIncomingIntent", "(Landroid/app/PendingIntent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleNotification_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetHandleNotification_Ljava_util_Map_Handler ()
		{
			if (cb_handleNotification_Ljava_util_Map_ == null)
				cb_handleNotification_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleNotification_Ljava_util_Map_);
			return cb_handleNotification_Ljava_util_Map_;
		}

		static void n_HandleNotification_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_map)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var map = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_map, JniHandleOwnership.DoNotTransfer);
			__this.HandleNotification (map);
		}
#pragma warning restore 0169

		static IntPtr id_handleNotification_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='handleNotification' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("handleNotification", "(Ljava/util/Map;)V", "GetHandleNotification_Ljava_util_Map_Handler")]
		public virtual unsafe void HandleNotification (global::System.Collections.Generic.IDictionary<string, string> map)
		{
			if (id_handleNotification_Ljava_util_Map_ == IntPtr.Zero)
				id_handleNotification_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "handleNotification", "(Ljava/util/Map;)V");
			IntPtr native_map = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (map);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_map);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleNotification_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleNotification", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler ()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown (IntPtr jnienv, IntPtr native__this)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown ();
		}
#pragma warning restore 0169

		static IntPtr id_shutdown;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='shutdown' and count(parameter)=0]"
		[Register ("shutdown", "()V", "GetShutdownHandler")]
		public virtual unsafe void Shutdown ()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID (class_ref, "shutdown", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutdown);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutdown", "()V"));
			} finally {
			}
		}

		static Delegate cb_handleIncomingInvite_Lcom_twilio_ipmessaging_Channel_;
#pragma warning disable 0169
		static Delegate GetHandleIncomingInvite_Lcom_twilio_ipmessaging_Channel_Handler ()
		{
			if (cb_handleIncomingInvite_Lcom_twilio_ipmessaging_Channel_ == null)
				cb_handleIncomingInvite_Lcom_twilio_ipmessaging_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleIncomingInvite_Lcom_twilio_ipmessaging_Channel_);
			return cb_handleIncomingInvite_Lcom_twilio_ipmessaging_Channel_;
		}

		static void n_HandleIncomingInvite_Lcom_twilio_ipmessaging_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_channel)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Twilio.IPMessaging.Channel channel = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.Channel> (native_channel, JniHandleOwnership.DoNotTransfer);
			__this.HandleIncomingInvite (channel);
		}
#pragma warning restore 0169

		static IntPtr id_handleIncomingInvite_Lcom_twilio_ipmessaging_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='handleIncomingInvite' and count(parameter)=1 and parameter[1][@type='com.twilio.ipmessaging.Channel']]"
		[Register ("handleIncomingInvite", "(Lcom/twilio/ipmessaging/Channel;)V", "GetHandleIncomingInvite_Lcom_twilio_ipmessaging_Channel_Handler")]
		public virtual unsafe void HandleIncomingInvite (global::Twilio.IPMessaging.Channel channel)
		{
			if (id_handleIncomingInvite_Lcom_twilio_ipmessaging_Channel_ == IntPtr.Zero)
				id_handleIncomingInvite_Lcom_twilio_ipmessaging_Channel_ = JNIEnv.GetMethodID (class_ref, "handleIncomingInvite", "(Lcom/twilio/ipmessaging/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (channel);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleIncomingInvite_Lcom_twilio_ipmessaging_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleIncomingInvite", "(Lcom/twilio/ipmessaging/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleChannelAddEvent_Lcom_twilio_ipmessaging_Channel_;
#pragma warning disable 0169
		static Delegate GetHandleChannelAddEvent_Lcom_twilio_ipmessaging_Channel_Handler ()
		{
			if (cb_handleChannelAddEvent_Lcom_twilio_ipmessaging_Channel_ == null)
				cb_handleChannelAddEvent_Lcom_twilio_ipmessaging_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleChannelAddEvent_Lcom_twilio_ipmessaging_Channel_);
			return cb_handleChannelAddEvent_Lcom_twilio_ipmessaging_Channel_;
		}

		static void n_HandleChannelAddEvent_Lcom_twilio_ipmessaging_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_channel)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Twilio.IPMessaging.Channel channel = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.Channel> (native_channel, JniHandleOwnership.DoNotTransfer);
			__this.HandleChannelAddEvent (channel);
		}
#pragma warning restore 0169

		static IntPtr id_handleChannelAddEvent_Lcom_twilio_ipmessaging_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='handleChannelAddEvent' and count(parameter)=1 and parameter[1][@type='com.twilio.ipmessaging.Channel']]"
		[Register ("handleChannelAddEvent", "(Lcom/twilio/ipmessaging/Channel;)V", "GetHandleChannelAddEvent_Lcom_twilio_ipmessaging_Channel_Handler")]
		public virtual unsafe void HandleChannelAddEvent (global::Twilio.IPMessaging.Channel channel)
		{
			if (id_handleChannelAddEvent_Lcom_twilio_ipmessaging_Channel_ == IntPtr.Zero)
				id_handleChannelAddEvent_Lcom_twilio_ipmessaging_Channel_ = JNIEnv.GetMethodID (class_ref, "handleChannelAddEvent", "(Lcom/twilio/ipmessaging/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (channel);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleChannelAddEvent_Lcom_twilio_ipmessaging_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleChannelAddEvent", "(Lcom/twilio/ipmessaging/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleChannelCreate_Lcom_twilio_ipmessaging_Channel_;
#pragma warning disable 0169
		static Delegate GetHandleChannelCreate_Lcom_twilio_ipmessaging_Channel_Handler ()
		{
			if (cb_handleChannelCreate_Lcom_twilio_ipmessaging_Channel_ == null)
				cb_handleChannelCreate_Lcom_twilio_ipmessaging_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleChannelCreate_Lcom_twilio_ipmessaging_Channel_);
			return cb_handleChannelCreate_Lcom_twilio_ipmessaging_Channel_;
		}

		static void n_HandleChannelCreate_Lcom_twilio_ipmessaging_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_channel)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Twilio.IPMessaging.Channel channel = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.Channel> (native_channel, JniHandleOwnership.DoNotTransfer);
			__this.HandleChannelCreate (channel);
		}
#pragma warning restore 0169

		static IntPtr id_handleChannelCreate_Lcom_twilio_ipmessaging_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='handleChannelCreate' and count(parameter)=1 and parameter[1][@type='com.twilio.ipmessaging.Channel']]"
		[Register ("handleChannelCreate", "(Lcom/twilio/ipmessaging/Channel;)V", "GetHandleChannelCreate_Lcom_twilio_ipmessaging_Channel_Handler")]
		public virtual unsafe void HandleChannelCreate (global::Twilio.IPMessaging.Channel channel)
		{
			if (id_handleChannelCreate_Lcom_twilio_ipmessaging_Channel_ == IntPtr.Zero)
				id_handleChannelCreate_Lcom_twilio_ipmessaging_Channel_ = JNIEnv.GetMethodID (class_ref, "handleChannelCreate", "(Lcom/twilio/ipmessaging/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (channel);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleChannelCreate_Lcom_twilio_ipmessaging_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleChannelCreate", "(Lcom/twilio/ipmessaging/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleChannelChanged_Lcom_twilio_ipmessaging_Channel_;
#pragma warning disable 0169
		static Delegate GetHandleChannelChanged_Lcom_twilio_ipmessaging_Channel_Handler ()
		{
			if (cb_handleChannelChanged_Lcom_twilio_ipmessaging_Channel_ == null)
				cb_handleChannelChanged_Lcom_twilio_ipmessaging_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleChannelChanged_Lcom_twilio_ipmessaging_Channel_);
			return cb_handleChannelChanged_Lcom_twilio_ipmessaging_Channel_;
		}

		static void n_HandleChannelChanged_Lcom_twilio_ipmessaging_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_channel)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Twilio.IPMessaging.Channel channel = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.Channel> (native_channel, JniHandleOwnership.DoNotTransfer);
			__this.HandleChannelChanged (channel);
		}
#pragma warning restore 0169

		static IntPtr id_handleChannelChanged_Lcom_twilio_ipmessaging_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='handleChannelChanged' and count(parameter)=1 and parameter[1][@type='com.twilio.ipmessaging.Channel']]"
		[Register ("handleChannelChanged", "(Lcom/twilio/ipmessaging/Channel;)V", "GetHandleChannelChanged_Lcom_twilio_ipmessaging_Channel_Handler")]
		public virtual unsafe void HandleChannelChanged (global::Twilio.IPMessaging.Channel channel)
		{
			if (id_handleChannelChanged_Lcom_twilio_ipmessaging_Channel_ == IntPtr.Zero)
				id_handleChannelChanged_Lcom_twilio_ipmessaging_Channel_ = JNIEnv.GetMethodID (class_ref, "handleChannelChanged", "(Lcom/twilio/ipmessaging/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (channel);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleChannelChanged_Lcom_twilio_ipmessaging_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleChannelChanged", "(Lcom/twilio/ipmessaging/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleChannelDeleted_Lcom_twilio_ipmessaging_Channel_;
#pragma warning disable 0169
		static Delegate GetHandleChannelDeleted_Lcom_twilio_ipmessaging_Channel_Handler ()
		{
			if (cb_handleChannelDeleted_Lcom_twilio_ipmessaging_Channel_ == null)
				cb_handleChannelDeleted_Lcom_twilio_ipmessaging_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleChannelDeleted_Lcom_twilio_ipmessaging_Channel_);
			return cb_handleChannelDeleted_Lcom_twilio_ipmessaging_Channel_;
		}

		static void n_HandleChannelDeleted_Lcom_twilio_ipmessaging_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_channel)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Twilio.IPMessaging.Channel channel = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.Channel> (native_channel, JniHandleOwnership.DoNotTransfer);
			__this.HandleChannelDeleted (channel);
		}
#pragma warning restore 0169

		static IntPtr id_handleChannelDeleted_Lcom_twilio_ipmessaging_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='handleChannelDeleted' and count(parameter)=1 and parameter[1][@type='com.twilio.ipmessaging.Channel']]"
		[Register ("handleChannelDeleted", "(Lcom/twilio/ipmessaging/Channel;)V", "GetHandleChannelDeleted_Lcom_twilio_ipmessaging_Channel_Handler")]
		public virtual unsafe void HandleChannelDeleted (global::Twilio.IPMessaging.Channel channel)
		{
			if (id_handleChannelDeleted_Lcom_twilio_ipmessaging_Channel_ == IntPtr.Zero)
				id_handleChannelDeleted_Lcom_twilio_ipmessaging_Channel_ = JNIEnv.GetMethodID (class_ref, "handleChannelDeleted", "(Lcom/twilio/ipmessaging/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (channel);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleChannelDeleted_Lcom_twilio_ipmessaging_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleChannelDeleted", "(Lcom/twilio/ipmessaging/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleOnChannelSync_Lcom_twilio_ipmessaging_Channel_;
#pragma warning disable 0169
		static Delegate GetHandleOnChannelSync_Lcom_twilio_ipmessaging_Channel_Handler ()
		{
			if (cb_handleOnChannelSync_Lcom_twilio_ipmessaging_Channel_ == null)
				cb_handleOnChannelSync_Lcom_twilio_ipmessaging_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleOnChannelSync_Lcom_twilio_ipmessaging_Channel_);
			return cb_handleOnChannelSync_Lcom_twilio_ipmessaging_Channel_;
		}

		static void n_HandleOnChannelSync_Lcom_twilio_ipmessaging_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_channel)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Twilio.IPMessaging.Channel channel = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.Channel> (native_channel, JniHandleOwnership.DoNotTransfer);
			__this.HandleOnChannelSync (channel);
		}
#pragma warning restore 0169

		static IntPtr id_handleOnChannelSync_Lcom_twilio_ipmessaging_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='handleOnChannelSync' and count(parameter)=1 and parameter[1][@type='com.twilio.ipmessaging.Channel']]"
		[Register ("handleOnChannelSync", "(Lcom/twilio/ipmessaging/Channel;)V", "GetHandleOnChannelSync_Lcom_twilio_ipmessaging_Channel_Handler")]
		public virtual unsafe void HandleOnChannelSync (global::Twilio.IPMessaging.Channel channel)
		{
			if (id_handleOnChannelSync_Lcom_twilio_ipmessaging_Channel_ == IntPtr.Zero)
				id_handleOnChannelSync_Lcom_twilio_ipmessaging_Channel_ = JNIEnv.GetMethodID (class_ref, "handleOnChannelSync", "(Lcom/twilio/ipmessaging/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (channel);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleOnChannelSync_Lcom_twilio_ipmessaging_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleOnChannelSync", "(Lcom/twilio/ipmessaging/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleOnError_Lcom_twilio_ipmessaging_ErrorInfo_;
#pragma warning disable 0169
		static Delegate GetHandleOnError_Lcom_twilio_ipmessaging_ErrorInfo_Handler ()
		{
			if (cb_handleOnError_Lcom_twilio_ipmessaging_ErrorInfo_ == null)
				cb_handleOnError_Lcom_twilio_ipmessaging_ErrorInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HandleOnError_Lcom_twilio_ipmessaging_ErrorInfo_);
			return cb_handleOnError_Lcom_twilio_ipmessaging_ErrorInfo_;
		}

		static void n_HandleOnError_Lcom_twilio_ipmessaging_ErrorInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_error_info)
		{
			global::Twilio.IPMessaging.IPMessagingClient __this = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.IPMessagingClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Twilio.IPMessaging.ErrorInfo error_info = global::Java.Lang.Object.GetObject<global::Twilio.IPMessaging.ErrorInfo> (native_error_info, JniHandleOwnership.DoNotTransfer);
			__this.HandleOnError (error_info);
		}
#pragma warning restore 0169

		static IntPtr id_handleOnError_Lcom_twilio_ipmessaging_ErrorInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='handleOnError' and count(parameter)=1 and parameter[1][@type='com.twilio.ipmessaging.ErrorInfo']]"
		[Register ("handleOnError", "(Lcom/twilio/ipmessaging/ErrorInfo;)V", "GetHandleOnError_Lcom_twilio_ipmessaging_ErrorInfo_Handler")]
		public virtual unsafe void HandleOnError (global::Twilio.IPMessaging.ErrorInfo error_info)
		{
			if (id_handleOnError_Lcom_twilio_ipmessaging_ErrorInfo_ == IntPtr.Zero)
				id_handleOnError_Lcom_twilio_ipmessaging_ErrorInfo_ = JNIEnv.GetMethodID (class_ref, "handleOnError", "(Lcom/twilio/ipmessaging/ErrorInfo;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (error_info);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleOnError_Lcom_twilio_ipmessaging_ErrorInfo_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleOnError", "(Lcom/twilio/ipmessaging/ErrorInfo;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setLogLevel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.ipmessaging']/class[@name='IPMessagingClient']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLogLevel", "(I)V", "")]
		public static unsafe void SetLogLevel (int level)
		{
			if (id_setLogLevel_I == IntPtr.Zero)
				id_setLogLevel_I = JNIEnv.GetStaticMethodID (class_ref, "setLogLevel", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (level);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogLevel_I, __args);
			} finally {
			}
		}

#region "Event implementation for Twilio.IPMessaging.IPMessagingClientListener"

		global::Twilio.IPMessaging.IPMessagingClientListenerImplementor __CreateIPMessagingClientListenerImplementor ()
		{
			return new global::Twilio.IPMessaging.IPMessagingClientListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/twilio/ipmessaging/IPMessagingClient", DoNotGenerateAcw=true)]
	internal partial class IPMessagingClientInvoker : IPMessagingClient {

		public IPMessagingClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPMessagingClientInvoker); }
		}

	}

}
