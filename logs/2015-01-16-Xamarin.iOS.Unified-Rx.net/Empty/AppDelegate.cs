using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Empty
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;

		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			// If you have defined a root view controller, set it here:
			// window.RootViewController = myViewController;
			
			// make the window visible
			window.MakeKeyAndVisible ();


			/*
				Not compile clean??????

				Xamarin.Test.Toolz/logs/2015-01-16-Xamarin.iOS.Unified-Rx.net/Empty/AppDelegate.cs(9,9): 
				Error CS0411: 
				The type arguments for method `System.Linq.Enumerable.Where<TSource>(this System.Collections.Generic.IEnumerable<TSource>, System.Func<TSource,bool>)' 
				cannot be inferred from the usage. Try specifying the type arguments explicitly (CS0411) 
				(Empty)
			*/
			var oddNumbers = System.Reactive.Linq.Observable.Range (0, 10)
			    .Where (i => i % 2 == 0)
			    .Subscribe (
			        Console.WriteLine, 
			        () => Console.WriteLine ("Completed"));

			return true;
		}
	}
}

