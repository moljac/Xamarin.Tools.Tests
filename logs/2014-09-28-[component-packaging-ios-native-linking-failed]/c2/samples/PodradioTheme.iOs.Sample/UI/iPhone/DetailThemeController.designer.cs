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
	[Register ("DetailThemeController")]
	partial class DetailThemeController
	{
		[Outlet]
		UILabel trackLabel { get; set; }

		[Outlet]
		UIScrollView scrollView { get; set; }

		[Outlet]
		UILabel genreLabel { get; set; }

		[Outlet]
		UIImageView bgImageView { get; set; }

		[Outlet]
		UILabel artistLabel { get; set; }

		[Outlet]
		UIImageView albumImageView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (trackLabel != null) {
				trackLabel.Dispose ();
				trackLabel = null;
			}

			if (scrollView != null) {
				scrollView.Dispose ();
				scrollView = null;
			}

			if (genreLabel != null) {
				genreLabel.Dispose ();
				genreLabel = null;
			}

			if (bgImageView != null) {
				bgImageView.Dispose ();
				bgImageView = null;
			}

			if (artistLabel != null) {
				artistLabel.Dispose ();
				artistLabel = null;
			}

			if (albumImageView != null) {
				albumImageView.Dispose ();
				albumImageView = null;
			}
		}
	}
}
