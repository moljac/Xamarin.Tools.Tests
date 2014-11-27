using System;
using System.Drawing;
#if __UNIFIED__
using UIKit;
#else
using MonoTouch.UIKit;
#endif

namespace Xamarin.Themes {
	internal sealed class DefaultTheme : ITheme {

		const string PadPrefix = "ipad-";

		public UIStatusBarStyle StatusBarStyle {
			get { return UIStatusBarStyle.BlackOpaque; }
		}

		/// <summary>
		/// Gets the main theme color.
		/// </summary>
		public UIColor MainColor {
			get { return UIColor.FromRGBA (150/255f, 198 / 255f, 255 / 255f, 1f); }
		}

		/// <summary>
		/// Gets the main color of the background.
		/// </summary>
		public UIColor BackgroundColor {
			get { return UIColor.DarkTextColor; }
		}

		/// <summary>
		/// Gets the background image for a text field
		/// </summary>
		public UIImage TextFieldBackground {
			get { return ResourceManager.TallImageFromFile ("text-input");}
		}

		/// <summary>
		/// Gets the view background image.
		/// </summary>
		public UIImage ViewBackground {
			get {
				var name = "background";
				if (DeviceInfo.IsPad)
					name = PadPrefix + name;
				return ColorSwitcher.ProcessImage (name);
			}
		}

		/// <summary>
		/// Gets the slider minimum track image.
		/// </summary>
		public UIImage SliderMinTrack {
			get { return ResourceManager.TallImageFromFile ("slider-fill", new UIEdgeInsets (11, 4, 0, 4)); }
		}

		/// <summary>
		/// Gets the slider max track image.
		/// </summary>
		public UIImage SliderMaxTrack {
			get { return ResourceManager.TallImageFromFile ("slider-track", new UIEdgeInsets (0, 4, 0, 4)); }
		}

		/// <summary>
		/// Gets the green button image.
		/// </summary>
		public UIImage GreenButtonImage {
			get {
				return ResourceManager.ImageFromFile ("green-button");
			}
		}

		/// <summary>
		/// Gets the red button image.
		/// </summary>
		public UIImage RedButtonImage {
			get {
				return ResourceManager.ImageFromFile ("red-button");
			}
		}

		/// <summary>
		/// Gets the blue button image.
		/// </summary>
		public UIImage BlueButtonImage {
			get { return ResourceManager.ImageFromFile ("blue-button"); }
		}

		/// <summary>
		/// Gets the tab bar background image.
		/// </summary>
		public UIImage TabBarBackground {
			get { return ColorSwitcher.ProcessImage ("tabbar"); }
		}

		/// <summary>
		/// Gets the tab bar selection image.
		/// </summary>
		public UIImage TabBarSelectionIndicator {
			get { return ResourceManager.TallImageFromFile ("selection-tab"); }
		}

		/// <summary>
		/// Gets the progress track image.
		/// </summary>
		public UIImage ProgressTrackImage {
			get { return ResourceManager.TallImageFromFile ("progress-track"); }
		}

		/// <summary>
		/// Gets the progress fill image.
		/// </summary>
		public UIImage ProgressFillImage {
			get { return ResourceManager.TallImageFromFile ("progress-fill"); }
		}

		/// <summary>
		/// Gets the main font for this theme.
		/// </summary>
		public UIFont MainFont {
			get { return UIFont.BoldSystemFontOfSize(20);}
		}

		/// <summary>
		/// Gets background image for navigation bar.
		/// </summary>
		/// <param name="metrics">UIBarMetrics</param>
		public UIImage NavigationBackgroundForBarMetrics (UIBarMetrics metrics)
		{
			return ColorSwitcher.ProcessImage ("menu-bar").CreateResizableImage(new UIEdgeInsets(0,0,0,0), UIImageResizingMode.Stretch);
		}

		/// <summary>
		/// Gets backgroung image for ipad tabbar
		/// </summary>
		public UIImage NavigationBackgroundForSplitView (bool isMasterView = false)
		{
			var name = "ipad-menubar-" + (isMasterView ? "left" : "right");
			UIEdgeInsets? insets = isMasterView ? default(UIEdgeInsets?) : new UIEdgeInsets(10,10,10,10);


			return ColorSwitcher.ProcessImage (name, insets).CreateResizableImage(new UIEdgeInsets(0,0,0,0), UIImageResizingMode.Stretch);;

		}

		/// <summary>
		/// Gets background image for bar buttons.
		/// </summary>
		/// <param name="state">UIControlState</param>
		/// <param name="style">UIBarButtonItemStyle</param>
		/// <param name="metrics">UIBarMetrics</param>
		public UIImage BarButtonBackgroundForState (UIControlState state, UIBarButtonItemStyle style, UIBarMetrics metrics)
		{
			var name = "menubar-button";

			return ResourceManager.TallImageFromFile (name, new UIEdgeInsets (0, 5, 0, 5));
		}

		/// <summary>
		/// Gets background image for back bar button.
		/// </summary>
		/// <param name="state">UIControlState</param>
		/// <param name="metrics">UIBarMetrics</param>
		public UIImage BackBackgroundForState (UIControlState state, UIBarMetrics metrics)
		{
			var name = "back";

			return ResourceManager.TallImageFromFile (name, new UIEdgeInsets (10, 10, 10, 5));
		}

		/// <summary>
		/// Gets background image for ipad toolbars
		/// </summary>
		/// <returns>The background for I pad.</returns>
		/// <param name="isMasterView">If set to <c>true</c> is master view.</param>
		public UIImage ToolbarBackgroundForSplitView (bool isMasterView = false)
		{
			var name = "ipad-tabbar-" + (isMasterView ? "left" : "right");

			return ColorSwitcher.ProcessImage (name);
		}

		/// <summary>
		/// Gets image of slider thumb.
		/// </summary>
		/// <param name="state">UIControlState</param>
		public UIImage SliderThumbForState (UIControlState state)
		{
			return ResourceManager.TallImageFromFile ("slider-handle");			
		}
	}
}


