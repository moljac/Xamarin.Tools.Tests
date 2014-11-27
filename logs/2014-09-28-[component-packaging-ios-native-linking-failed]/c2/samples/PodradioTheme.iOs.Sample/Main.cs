#if __UNIFIED__
using UIKit;
#else
using MonoTouch.UIKit;
#endif

namespace ThemeSample {
	public static class Application {
		static void Main (string[] args)
		{
			UIApplication.Main (args, null, "AppDelegate");
		}
	}
}
