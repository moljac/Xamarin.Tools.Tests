using System;
using System.Drawing;
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

namespace XSample.MarkDownDeep.XI
{
    public partial class FlipsideViewController : UIViewController
    {
        public FlipsideViewController() : base ("FlipsideViewController", null)
        {
            this.ContentSizeForViewInPopover = new SizeF(320f, 480f);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
			
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            // Return true for supported orientations
            if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone)
            {
                return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
            } else
            {
                return true;
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
			
            // Release any cached data, images, etc that aren't in use.
        }

        partial void done(UIBarButtonItem sender)
        {
            if (Done != null)
                Done(this, EventArgs.Empty);
        }

        public event EventHandler Done;
    }
}

