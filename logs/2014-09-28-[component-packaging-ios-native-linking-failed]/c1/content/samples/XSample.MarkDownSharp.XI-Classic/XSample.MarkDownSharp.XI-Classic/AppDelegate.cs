using System;
using System.Collections.Generic;
using System.Linq;
#if __UNIFIED__
using UIKit;
using Foundation;
using CoreAnimation;
using CoreGraphics;
#else
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreGraphics;

using System.Drawing;
using CGRect = global::System.Drawing.RectangleF;
using CGPoint = global::System.Drawing.PointF;
using CGSize = global::System.Drawing.SizeF;
using nfloat = global::System.Single;
using nint = global::System.Int32;
using nuint = global::System.UInt32;
#endif

namespace XSample.MarkDownSharp.XI
{
    /// The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register ("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        UIWindow window;
        MainViewController mainViewController;
        UINavigationController root_navigation_controller;
        
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // create a new window instance based on the screen size
            window = new UIWindow(UIScreen.MainScreen.Bounds);
            root_navigation_controller = new UINavigationController();
            
            mainViewController = new MainViewController();
            root_navigation_controller.PushViewController(mainViewController, true);
            
                       
            window.RootViewController = root_navigation_controller;
            window.MakeKeyAndVisible();
		
            //System.Diagnostics.Trace.Listeners.Add(new System.Diagnostics.DefaultTraceListener());
            	
            return true;
        }
    }
}

