using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Twilio.Conversations {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.twilio.conversations']/class[@name='CapturerException']"
	[global::Android.Runtime.Register ("com/twilio/conversations/CapturerException", DoNotGenerateAcw=true)]
	public partial class CapturerException : global::Java.Lang.Exception {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.twilio.conversations']/class[@name='CapturerException.ExceptionDomain']"
		[global::Android.Runtime.Register ("com/twilio/conversations/CapturerException$ExceptionDomain", DoNotGenerateAcw=true)]
		public sealed partial class ExceptionDomain : global::Java.Lang.Enum {


			static IntPtr CAMERA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.twilio.conversations']/class[@name='CapturerException.ExceptionDomain']/field[@name='CAMERA']"
			[Register ("CAMERA")]
			public static global::Twilio.Conversations.CapturerException.ExceptionDomain Camera {
				get {
					if (CAMERA_jfieldId == IntPtr.Zero)
						CAMERA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAMERA", "Lcom/twilio/conversations/CapturerException$ExceptionDomain;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAMERA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Twilio.Conversations.CapturerException.ExceptionDomain> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CAPTURER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.twilio.conversations']/class[@name='CapturerException.ExceptionDomain']/field[@name='CAPTURER']"
			[Register ("CAPTURER")]
			public static global::Twilio.Conversations.CapturerException.ExceptionDomain Capturer {
				get {
					if (CAPTURER_jfieldId == IntPtr.Zero)
						CAPTURER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAPTURER", "Lcom/twilio/conversations/CapturerException$ExceptionDomain;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAPTURER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Twilio.Conversations.CapturerException.ExceptionDomain> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/twilio/conversations/CapturerException$ExceptionDomain", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ExceptionDomain); }
			}

			internal ExceptionDomain (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.conversations']/class[@name='CapturerException.ExceptionDomain']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/twilio/conversations/CapturerException$ExceptionDomain;", "")]
			public static unsafe global::Twilio.Conversations.CapturerException.ExceptionDomain ValueOf (string nameValue)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/twilio/conversations/CapturerException$ExceptionDomain;");
				IntPtr native_nameValue = JNIEnv.NewString (nameValue);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_nameValue);
					global::Twilio.Conversations.CapturerException.ExceptionDomain __ret = global::Java.Lang.Object.GetObject<global::Twilio.Conversations.CapturerException.ExceptionDomain> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_nameValue);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.conversations']/class[@name='CapturerException.ExceptionDomain']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/twilio/conversations/CapturerException$ExceptionDomain;", "")]
			public static unsafe global::Twilio.Conversations.CapturerException.ExceptionDomain[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/twilio/conversations/CapturerException$ExceptionDomain;");
				try {
					return (global::Twilio.Conversations.CapturerException.ExceptionDomain[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Twilio.Conversations.CapturerException.ExceptionDomain));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/twilio/conversations/CapturerException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CapturerException); }
		}

		protected CapturerException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_twilio_conversations_CapturerException_ExceptionDomain_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.twilio.conversations']/class[@name='CapturerException']/constructor[@name='CapturerException' and count(parameter)=2 and parameter[1][@type='com.twilio.conversations.CapturerException.ExceptionDomain'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/twilio/conversations/CapturerException$ExceptionDomain;Ljava/lang/String;)V", "")]
		public unsafe CapturerException (global::Twilio.Conversations.CapturerException.ExceptionDomain domain, string errorMessage)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_errorMessage = JNIEnv.NewString (errorMessage);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (domain);
				__args [1] = new JValue (native_errorMessage);
				if (GetType () != typeof (CapturerException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/twilio/conversations/CapturerException$ExceptionDomain;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Lcom/twilio/conversations/CapturerException$ExceptionDomain;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_twilio_conversations_CapturerException_ExceptionDomain_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_twilio_conversations_CapturerException_ExceptionDomain_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/twilio/conversations/CapturerException$ExceptionDomain;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_twilio_conversations_CapturerException_ExceptionDomain_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lcom_twilio_conversations_CapturerException_ExceptionDomain_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_errorMessage);
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Twilio.Conversations.CapturerException __this = global::Java.Lang.Object.GetObject<global::Twilio.Conversations.CapturerException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public new override unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.twilio.conversations']/class[@name='CapturerException']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
