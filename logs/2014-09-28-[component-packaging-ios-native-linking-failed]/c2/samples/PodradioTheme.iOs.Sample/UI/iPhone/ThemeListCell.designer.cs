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
	[Register ("ThemeListCell")]
	partial class ThemeListCell
	{
		[Outlet]
		UILabel TrackLabel { get; set; }

		[Outlet]
		UILabel ArtistLabel { get; set; }

		[Outlet]
		UILabel LengthLabel { get; set; }

		[Outlet]
		UIImageView AlbumImageView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TrackLabel != null) {
				TrackLabel.Dispose ();
				TrackLabel = null;
			}

			if (ArtistLabel != null) {
				ArtistLabel.Dispose ();
				ArtistLabel = null;
			}

			if (LengthLabel != null) {
				LengthLabel.Dispose ();
				LengthLabel = null;
			}

			if (AlbumImageView != null) {
				AlbumImageView.Dispose ();
				AlbumImageView = null;
			}
		}
	}
}
