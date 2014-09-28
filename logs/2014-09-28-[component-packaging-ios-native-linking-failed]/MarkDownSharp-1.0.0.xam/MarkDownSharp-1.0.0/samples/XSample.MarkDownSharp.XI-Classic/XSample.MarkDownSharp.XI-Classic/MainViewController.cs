using System;
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

namespace XSample.MarkDownSharp.XI
{
	public partial class MainViewController : 
		UIViewController
		//UINavigationController
	{
		MarkUpController markup_controller = null;
		
		static bool UserInterfaceIdiomIsPhone
		{
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		UIPopoverController flipsidePopoverController;

		public MainViewController()
			: base (UserInterfaceIdiomIsPhone ? "MainViewController_iPhone" : "MainViewController_iPad" , null)
		{
			// Custom initialization
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
			// Perform any additional setup after loading the view, typically from a nib.
			markup_controller = new MarkUpController();
			
			var button_markup = new UIBarButtonItem(UIBarButtonSystemItem.Play);
			button_markup.Clicked += HandleClicked;
			this.NavigationItem.RightBarButtonItem = button_markup; 

            textViewMarkDown.Text = BusinessLogicObject.MarkDown;
            
			return;
		}

		void HandleClicked (object sender, EventArgs e)
		{
			BusinessLogicObject.MarkDown = textViewMarkDown.Text;
			BusinessLogicObject.MarkUpHTML =
					BusinessLogicObject.MarkDownEngine.Transform(BusinessLogicObject.MarkDown);


			this.NavigationController.PushViewController(markup_controller, true);

			return;            
		}

		
		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);

			
			return;
		}
		
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear(animated);
			
			return;
		}

		void HandleTouchUpInside (object sender, EventArgs e)
		{            
			this.NavigationController.PushViewController(markup_controller,true);
			//this.PresentViewController(markup_controller, true, PresentViewControllerCompleted);
			
			return;
		}
		
		public void PresentViewControllerCompleted()
		{
			//System.Diagnostics.Trace.WriteLine("PresentViewControllerCompleted");
		
			return;
		}
		
	   
		public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			if (UserInterfaceIdiomIsPhone)
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

		partial void showInfo(NSObject sender)
		{
			if (UserInterfaceIdiomIsPhone)
			{
				var controller = new FlipsideViewController()
				{
					ModalTransitionStyle = UIModalTransitionStyle.FlipHorizontal,
				};
				
				controller.Done += delegate
				{
					#if __UNIFIED__
					this.DismissModalViewController(true);
					#else
					this.DismissModalViewControllerAnimated(true);
					#endif
				};
				
				this.PresentModalViewController(controller, true);
			} else
			{
				if (flipsidePopoverController == null)
				{
					var controller = new FlipsideViewController();
					flipsidePopoverController = new UIPopoverController(controller);
					controller.Done += delegate
					{
						flipsidePopoverController.Dismiss(true);
					};
				}
				
				if (flipsidePopoverController.PopoverVisible)
				{
					flipsidePopoverController.Dismiss(true);
				} else
				{
					flipsidePopoverController.PresentFromBarButtonItem((UIBarButtonItem)sender, UIPopoverArrowDirection.Any, true);
				}
			}
		}
	}
}

