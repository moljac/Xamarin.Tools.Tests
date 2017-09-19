using System;
namespace MsBuildPreprocessorDefines.XamarinIOS
{
    public class KeyStoreUtility
    {
        public KeyStoreUtility()
        {
                #if __UNIFIED__
                    Security.SecRecord sr = null;
                #else
                    MonoTouch.Security.SecRecord.SecRecord = null;
                #endif
        }
    }
}
