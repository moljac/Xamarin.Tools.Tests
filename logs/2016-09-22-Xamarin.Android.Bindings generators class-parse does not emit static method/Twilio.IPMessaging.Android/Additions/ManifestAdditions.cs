using System;
using Android.App;
using Android.Runtime;

namespace Twilio.IPMessaging.Android
{
    [Register ("com/twilio/ipmessaging/TwilioIPMessagingClientService", DoNotGenerateAcw=true)]
    [Service (Name="com.twilio.ipmessaging.TwilioIPMessagingClientService")]
    internal class _InternalTwilioIPMessagingClientServiceDecl : Service
    {
        #region implemented abstract members of Service
        public override global::Android.OS.IBinder OnBind (global::Android.Content.Intent intent)
        {
            return null;
        }
        #endregion
    }
}

