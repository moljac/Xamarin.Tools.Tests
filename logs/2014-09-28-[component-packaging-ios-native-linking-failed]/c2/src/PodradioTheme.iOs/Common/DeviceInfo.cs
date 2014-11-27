#if __UNIFIED__
using UIKit;
#else
using MonoTouch.UIKit;
#endif

namespace Xamarin.Themes {
	internal static class DeviceInfo {
		public static UIUserInterfaceIdiom Idiom { 
			get { 
				return UIDevice.CurrentDevice.UserInterfaceIdiom; 
			} 
		}

		public static bool IsPhone { 
			get { 
				return Idiom == UIUserInterfaceIdiom.Phone; 
			} 
		}

		public static bool IsPad {
			get {
				return Idiom == UIUserInterfaceIdiom.Pad;
			}
		}

		public static bool IsTall {
			get {
				return IsPhone && UIScreen.MainScreen.Bounds.Size.Height == 568;
			}
		}
	}
}

