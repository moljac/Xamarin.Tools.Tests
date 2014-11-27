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
	[Register ("DetailThemeiPadController")]
	partial class DetailThemeiPadController
	{
		[Outlet]
		UIToolbar ToolbarBottom { get; set; }

		[Outlet]
		UILabel TrackLabel { get; set; }

		[Outlet]
		UILabel GenreLabel { get; set; }

		[Outlet]
		UILabel ArtistLabel { get; set; }

		[Outlet]
		UIImageView AlbumImageView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ToolbarBottom != null) {
				ToolbarBottom.Dispose ();
				ToolbarBottom = null;
			}

			if (TrackLabel != null) {
				TrackLabel.Dispose ();
				TrackLabel = null;
			}

			if (GenreLabel != null) {
				GenreLabel.Dispose ();
				GenreLabel = null;
			}

			if (ArtistLabel != null) {
				ArtistLabel.Dispose ();
				ArtistLabel = null;
			}

			if (AlbumImageView != null) {
				AlbumImageView.Dispose ();
				AlbumImageView = null;
			}
		}
	}
}
