// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
#if __UNIFIED__
using UIKit;
using Foundation;
#else
using MonoTouch.UIKit;
using MonoTouch.Foundation;
#endif

namespace ThemeSample
{
	[Register ("MasterViewController")]
	partial class MasterViewController
	{
		[Outlet]
		UIToolbar ToolbarBottom { get; set; }

		[Outlet]
		UITableView TracksTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ToolbarBottom != null) {
				ToolbarBottom.Dispose ();
				ToolbarBottom = null;
			}

			if (TracksTableView != null) {
				TracksTableView.Dispose ();
				TracksTableView = null;
			}
		}
	}
}
