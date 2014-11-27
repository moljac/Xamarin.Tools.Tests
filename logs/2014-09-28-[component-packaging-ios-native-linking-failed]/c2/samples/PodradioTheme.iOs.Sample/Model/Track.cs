using System;
#if __UNIFIED__
using UIKit;
#else
using MonoTouch.UIKit;
#endif

namespace ThemeSample.Model {
	sealed class Track {

		public string Name { get; set; }

		public string Artist { get; set; }

		public UIImage Image { get; set; }

		public UIImage LargeImage { get; set; }

		public string Length { get; set; }

		public string Genre { get; set; }
	}
}

