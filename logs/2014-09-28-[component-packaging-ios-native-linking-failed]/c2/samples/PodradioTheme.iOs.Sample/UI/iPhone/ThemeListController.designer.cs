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
	[Register ("ThemeListController")]
	partial class ThemeListController
	{
		[Outlet]
		UITableView tableListView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tableListView != null) {
				tableListView.Dispose ();
				tableListView = null;
			}
		}
	}
}
