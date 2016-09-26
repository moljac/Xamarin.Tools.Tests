using System;

// moljac/mel
// BuildAction:None
// remove this.....

namespace Twilio.Common
{
    public class TwilioAccessManagerListener : Java.Lang.Object, ITwilioAccessManagerListener
    {
        public Action<ITwilioAccessManager> TokenExpiredHandler { get; set; }
        public void OnTokenExpired (ITwilioAccessManager accessManager)
        {
            TokenExpiredHandler?.Invoke (accessManager);
        }

        public Action<ITwilioAccessManager, string> ErrorHandler { get; set; }
        public void OnError (ITwilioAccessManager accessManager, string msg)
        {
            ErrorHandler?.Invoke (accessManager, msg);
        }

        public Action<ITwilioAccessManager> TokenUpdatedHandler { get;set; }
        public void OnTokenUpdated (ITwilioAccessManager accessManager)
        {
            TokenUpdatedHandler?.Invoke (accessManager);
        }
    }
}

