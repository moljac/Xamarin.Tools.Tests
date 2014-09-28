// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
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
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UITextView textViewMarkDown { get; set; }

		[Action ("showInfo:")]
		partial void showInfo (NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (textViewMarkDown != null) {
				textViewMarkDown.Dispose ();
				textViewMarkDown = null;
			}
		}
	}
}
