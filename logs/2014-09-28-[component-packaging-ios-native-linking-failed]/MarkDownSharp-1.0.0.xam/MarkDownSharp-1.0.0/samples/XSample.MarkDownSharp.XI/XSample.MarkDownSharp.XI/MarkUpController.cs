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


using XSample.MarkDownSharp;

namespace XSample.MarkDownDeep.XI
{
	public partial class MarkUpController : UIViewController
	{
		static bool UserInterfaceIdiomIsPhone
		{
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public MarkUpController()
			: base (UserInterfaceIdiomIsPhone ? "MarkUpController_iPhone" : "MarkUpController_iPad", null)
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
			// Perform any additional setup after loading the view, typically from a nib.

			return;
		}
			
		 public override void ViewWillAppear(bool animated)
        {        
            webViewMarkUp.LoadHtmlString(BusinessLogicObject.MarkUpHTML, null);

            return;
        }

		void HandleTouchUpInside (object sender, EventArgs e)
		{
			//this.DismissViewController(true, Aa);
			#if __UNIFIED__
			this.NavigationController.PopViewController(true);
			#else
			this.NavigationController.PopViewControllerAnimated(true);
			#endif

			return;
		}
		
		public void Aa()
		{
		
		}
	}
}

