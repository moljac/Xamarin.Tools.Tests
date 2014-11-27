using System;
using System.Collections.Generic;
using System.Linq;
#if __UNIFIED__
using Foundation;
using UIKit;
#else
using MonoTouch.Foundation;
using MonoTouch.UIKit;
#endif
using Xamarin.Themes;

namespace ThemeSample {
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate {
		public override UIWindow Window { get; set; }

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			ColorSwitcher.ChangeScheme (ColorScheme.Maroon);
			PodradioTheme.Apply ();

			var idiom = UIDevice.CurrentDevice.UserInterfaceIdiom;
			if (idiom == UIUserInterfaceIdiom.Pad) 
				IPadInit ();

			return true;
		}

		void IPadInit ()
		{
			var splitViewController = Window.RootViewController as UISplitViewController;

			var ind = splitViewController.ViewControllers.Length - 1;
			var detailNav = splitViewController.ViewControllers [ind] as UINavigationController;

			var md = detailNav.ViewControllers [0];
			var sd = md;

			var masterNav = splitViewController.ViewControllers [0] as UINavigationController;
			var master = masterNav.ViewControllers [0] as MasterViewController;

			master.Detail = md as DetailThemeiPadController;
			splitViewController.WeakDelegate = sd;
		}
	}
}

