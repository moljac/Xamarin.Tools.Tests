using System;
#if __UNIFIED__
using UIKit;
#else
using MonoTouch.UIKit;
#endif

namespace Xamarin.Themes.Extensions {
	internal static class UIViewExtensions {
		#region UINavigationBar

		[System.ComponentModel.EditorBrowsable (System.ComponentModel.EditorBrowsableState.Never)]
		public static void SetBackground (this UINavigationBar @this, UIImage image, UIBarMetrics metrics)
		{
			if (image == null)
				return;

			@this.SetBackgroundImage (image, metrics);
		}

		#endregion

		#region UIBarButtonItem

		[System.ComponentModel.EditorBrowsable (System.ComponentModel.EditorBrowsableState.Never)]
		public static void SetBackground (this UIBarButtonItem @this, UIImage image, UIControlState state, UIBarMetrics metrics)
		{
			if (image == null)
				return;

			@this.SetBackgroundImage (image, state, metrics);
		}

		[System.ComponentModel.EditorBrowsable (System.ComponentModel.EditorBrowsableState.Never)]
		public static void SetBackButtonBackground (this UIBarButtonItem @this, UIImage image, UIControlState state, UIBarMetrics metrics)
		{
			if (image == null)
				return;

			@this.SetBackButtonBackgroundImage (image, state, metrics);
		}

		#endregion

		#region UISlider

		[System.ComponentModel.EditorBrowsable (System.ComponentModel.EditorBrowsableState.Never)]
		public static void SetThumb (this UISlider @this, UIImage image, UIControlState state)
		{
			if (image == null)
				return;

			@this.SetThumbImage (image, state);
		}

		[System.ComponentModel.EditorBrowsable (System.ComponentModel.EditorBrowsableState.Never)]
		public static void SetMinTrack (this UISlider @this, UIImage image, UIControlState state)
		{
			if (image == null)
				return;

			@this.SetMinTrackImage (image, state);
		}

		[System.ComponentModel.EditorBrowsable (System.ComponentModel.EditorBrowsableState.Never)]
		public static void SetMaxTrack (this UISlider @this, UIImage image, UIControlState state)
		{
			if (image == null)
				return;

			@this.SetMaxTrackImage (image, state);
		}

		#endregion
	}
}