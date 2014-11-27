using System;
using System.Drawing;
#if __UNIFIED__
using UIKit;
#else
using MonoTouch.UIKit;
#endif
using Xamarin.Themes.Extensions;

namespace Xamarin.Themes {
	public static class PodradioTheme {
		static ITheme sharedTheme;

		/// <summary>
		/// Gets a value indicating if the device is running iOS7 or greater
		/// </summary>
		/// <value><c>true</c> if is iOS 7 or greater ; otherwise, <c>false</c>.</value>
		public static bool IsIOS7
		{
			get
			{
				return (UIDevice.CurrentDevice.CheckSystemVersion (7, 0));
			}
		}

		static PodradioTheme ()
		{
			sharedTheme = new DefaultTheme ();
		}

		public static ITheme SharedTheme {
			get { return sharedTheme; }
		}

		/// <summary>
		/// Applies theme styles globally.
		/// </summary>
		public static void Apply ()
		{
			ApplyStatusBarStyle ();
			Apply (UITableView.Appearance);
			Apply (UINavigationBar.Appearance);
			Apply (UIBarButtonItem.Appearance);
			Apply (UISegmentedControl.Appearance);
			Apply (UITabBar.Appearance);
			Apply (UIToolbar.Appearance);
			Apply (UISearchBar.Appearance);
			Apply (UISlider.Appearance);
			Apply (UIProgressView.Appearance);
			Apply (UISwitch.Appearance);
		}
		#region StatusBar

		/// <summary>
		/// Applies the status bar style.
		/// </summary>
		public static void ApplyStatusBarStyle ()
		{
			UIApplication.SharedApplication.SetStatusBarStyle (sharedTheme.StatusBarStyle, false);
		}
		#endregion

		#region UIView

		/// <summary>
		/// Applies style on the specified appearance.
		/// </summary>
		/// <param name="appearance">UIViewAppearance</param>
		public static void Apply (UIView.UIViewAppearance appearance)
		{
			var backgroundImage = sharedTheme.ViewBackground;

			appearance.BackgroundColor = backgroundImage == null 
				? sharedTheme.BackgroundColor
					: UIColor.FromPatternImage (backgroundImage);
		}
		/// <summary>
		/// Applies style on the specified view.
		/// </summary>
		/// <param name="view">UIView</param>
		public static void Apply (UIView view)
		{
			var backgroundImage = sharedTheme.ViewBackground;

			view.BackgroundColor = backgroundImage == null 
				? sharedTheme.BackgroundColor
					: UIColor.FromPatternImage (backgroundImage);		
		}
		#endregion

		#region UILabel

		/// <summary>
		/// Applies style on the specified appearance.
		/// </summary>
		/// <param name="appearance">UILabelAppearance</param>
		public static void Apply (UILabel.UILabelAppearance appearance)
		{
			appearance.TextColor = sharedTheme.MainColor;
			appearance.BackgroundColor = UIColor.Clear;
			appearance.Font = sharedTheme.MainFont;
		}
		/// <summary>
		/// Applies style on the specified view.
		/// </summary>
		/// <param name="view">UILabel</param>
		public static void Apply (UILabel view)
		{
			view.TextColor = sharedTheme.MainColor;
			view.BackgroundColor = UIColor.Clear;
			view.Font = sharedTheme.MainFont;
		}
		#endregion

		#region UINavigationBar

		/// <summary>
		/// Applies style on the specified appearance.
		/// </summary>
		/// <param name="appearance">UINavigationBarAppearance</param>
		public static void Apply (UINavigationBar.UINavigationBarAppearance appearance)
		{
			var img = sharedTheme.NavigationBackgroundForBarMetrics (UIBarMetrics.Default);
			appearance.SetBackground (img, UIBarMetrics.Default);
			appearance.SetBackground (img, UIBarMetrics.LandscapePhone);	

			if (IsIOS7)
			{
				appearance.TintColor = UIColor.White;

				var textAttributes = new UITextAttributes	{
					TextColor = UIColor.White,
					TextShadowColor = UIColor.Black.ColorWithAlpha(0.8f),
					TextShadowOffset = new UIOffset(0, -1)};

				if (textAttributes != null)
					appearance.SetTitleTextAttributes(textAttributes);
			}

		}
		/// <summary>
		/// Applies style on the specified view.
		/// </summary>
		/// <param name="view">UINavigationBar</param>
		public static void Apply (UINavigationBar view)
		{
			var img = sharedTheme.NavigationBackgroundForBarMetrics (UIBarMetrics.Default);
			view.SetBackground (img, UIBarMetrics.Default);
			view.SetBackground (img, UIBarMetrics.LandscapePhone);	

			if (IsIOS7)
			{
				view.TintColor = UIColor.White;

				var textAttributes = new UITextAttributes	{
					TextColor = UIColor.White,
					TextShadowColor = UIColor.Black.ColorWithAlpha(0.8f),
					TextShadowOffset = new UIOffset(0, -1)};

				if (textAttributes != null)
					view.SetTitleTextAttributes(textAttributes);
			}
		}
		#endregion

		#region UIBarButtonItem

		/// <summary>
		/// Applies style on the specified appearance.
		/// </summary>
		/// <param name="appearance">UIBarButtonItemAppearance</param>
		public static void Apply (UIBarButtonItem.UIBarButtonItemAppearance appearance)
		{
			if (!IsIOS7)
			{
				appearance.SetBackground (
					sharedTheme.BarButtonBackgroundForState (UIControlState.Normal, UIBarButtonItemStyle.Bordered, UIBarMetrics.Default), 
					UIControlState.Normal,
					UIBarMetrics.Default);

				appearance.SetBackButtonBackground (
					sharedTheme.BackBackgroundForState (UIControlState.Normal, UIBarMetrics.Default), 
					UIControlState.Normal, 
					UIBarMetrics.Default);
			}

		}
		/// <summary>
		/// Applies style on the specified view.
		/// </summary>
		/// <param name="view">UIBarButtonItem</param>
		public static void Apply (UIBarButtonItem view)
		{
			if (!IsIOS7)
			{
				view.SetBackground (
					sharedTheme.BarButtonBackgroundForState (UIControlState.Normal, UIBarButtonItemStyle.Bordered, UIBarMetrics.Default), 
					UIControlState.Normal,
					UIBarMetrics.Default);

				view.SetBackButtonBackground (
					sharedTheme.BackBackgroundForState (UIControlState.Normal, UIBarMetrics.Default), 
					UIControlState.Normal, 
					UIBarMetrics.Default);
			}
		}
		#endregion

		#region UITabBar

		/// <summary>
		/// Applies style on the specified appearance.
		/// </summary>
		/// <param name="appearance">UITabBarAppearance</param>
		public static void Apply (UITabBar.UITabBarAppearance appearance)
		{
			appearance.BackgroundImage = sharedTheme.TabBarBackground;
			appearance.SelectionIndicatorImage = sharedTheme.TabBarSelectionIndicator;

			appearance.TintColor = UIColor.White;


		}
		/// <summary>
		/// Applies style on the specified view.
		/// </summary>
		/// <param name="view">UITabBar</param>
		public static void Apply (UITabBar view)
		{
			view.BackgroundImage = sharedTheme.TabBarBackground;
			view.SelectionIndicatorImage = sharedTheme.TabBarSelectionIndicator;

			view.TintColor = UIColor.White;
		}
		#endregion


		#region UISlider

		/// <summary>
		/// Applies style on the specified appearance.
		/// </summary>
		/// <param name="appearance">UISliderAppearance</param>
		public static void Apply (UISlider.UISliderAppearance appearance)
		{
			appearance.SetThumb (sharedTheme.SliderThumbForState (UIControlState.Normal), UIControlState.Normal);

			var thumbImage = sharedTheme.SliderThumbForState (UIControlState.Highlighted);
			appearance.SetThumb (thumbImage ?? sharedTheme.SliderThumbForState (UIControlState.Normal), UIControlState.Highlighted);

			appearance.SetMinTrack (sharedTheme.SliderMinTrack, UIControlState.Normal);			
			appearance.SetMaxTrack (sharedTheme.SliderMaxTrack, UIControlState.Normal);
		}
		/// <summary>
		/// Applies style on the specified view.
		/// </summary>
		/// <param name="view">UISlider</param>
		public static void Apply (UISlider view)
		{
			view.SetThumb (sharedTheme.SliderThumbForState (UIControlState.Normal), UIControlState.Normal);

			var thumbImage = sharedTheme.SliderThumbForState (UIControlState.Highlighted);			
			view.SetThumb (thumbImage ?? sharedTheme.SliderThumbForState (UIControlState.Normal), UIControlState.Highlighted);

			view.SetMinTrack (sharedTheme.SliderMinTrack, UIControlState.Normal);
			view.SetMaxTrack (sharedTheme.SliderMaxTrack, UIControlState.Normal);
		}
		#endregion

		#region UIProgressView

		/// <summary>
		/// Applies style on the specified appearance.
		/// </summary>
		/// <param name="appearance">UIProgressViewAppearance</param>
		public static void Apply (UIProgressView.UIProgressViewAppearance appearance)
		{
			appearance.TrackImage = sharedTheme.ProgressTrackImage;
			appearance.ProgressImage = sharedTheme.ProgressFillImage;
		}
		/// <summary>
		/// Applies style on the specified view.
		/// </summary>
		/// <param name="view">UIProgressView</param>
		public static void Apply (UIProgressView view)
		{
			view.TrackImage = sharedTheme.ProgressTrackImage;
			view.ProgressImage = sharedTheme.ProgressFillImage;
		}
		#endregion
	}
}
