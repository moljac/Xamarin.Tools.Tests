using System;
using System.Drawing;

#if __UNIFIED__
using UIKit;
#else
using MonoTouch.UIKit;
#endif

namespace Xamarin.Themes {
	public interface ITheme {
		UIStatusBarStyle StatusBarStyle { get; }
		UIColor MainColor { get; }
		UIColor BackgroundColor { get; }	
		UIImage TextFieldBackground { get; }
		UIImage ViewBackground { get; }
		UIImage SliderMinTrack { get; }
		UIImage SliderMaxTrack { get; }
		UIImage TabBarBackground { get; }
		UIImage TabBarSelectionIndicator { get; }
		UIImage GreenButtonImage { get; }
		UIImage RedButtonImage { get; }
		UIImage BlueButtonImage { get; }
		UIImage ProgressTrackImage { get; }
		UIImage ProgressFillImage { get; }
		UIFont MainFont { get; }

		UIImage NavigationBackgroundForBarMetrics (UIBarMetrics metrics);
		UIImage NavigationBackgroundForSplitView (bool isMasterView = false);
		UIImage BarButtonBackgroundForState (UIControlState state, UIBarButtonItemStyle style, UIBarMetrics metrics);
		UIImage BackBackgroundForState (UIControlState state, UIBarMetrics metrics);
		UIImage ToolbarBackgroundForSplitView (bool isMasterView = false);
		UIImage SliderThumbForState (UIControlState state);
	}
}


