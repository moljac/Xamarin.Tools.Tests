using System;
#if __UNIFIED__
using UIKit;
#else
using MonoTouch.UIKit;
#endif

namespace Xamarin.Themes {
	internal static class AppearanceExtensions {
		#region UINavigationBar

		public static void SetBackground (this UINavigationBar.UINavigationBarAppearance @this, UIImage image, UIBarMetrics metrics)
		{
			if (image == null)
				return;

			@this.SetBackgroundImage (image, metrics);
		}

		#endregion

		#region UIBarButtonItem

		public static void SetBackground (this UIBarButtonItem.UIBarButtonItemAppearance @this, UIImage image, UIControlState state, UIBarMetrics metrics)
		{
			if (image == null)
				return;

			@this.SetBackgroundImage (image, state, metrics);
		}

		public static void SetBackButtonBackground (this UIBarButtonItem.UIBarButtonItemAppearance @this, UIImage image, UIControlState state, UIBarMetrics metrics)
		{
			if (image == null)
				return;

			@this.SetBackButtonBackgroundImage (image, state, metrics);
		}

		#endregion

		#region UISlider

		public static void SetThumb (this UISlider.UISliderAppearance @this, UIImage image, UIControlState state)
		{
			if (image == null)
				return;

			@this.SetThumbImage (image, state);
		}

		public static void SetMinTrack (this UISlider.UISliderAppearance @this, UIImage image, UIControlState state)
		{
			if (image == null)
				return;

			@this.SetMinTrackImage (image, state);
		}

		public static void SetMaxTrack (this UISlider.UISliderAppearance @this, UIImage image, UIControlState state)
		{
			if (image == null)
				return;

			@this.SetMaxTrackImage (image, state);
		}

		#endregion
	}
}