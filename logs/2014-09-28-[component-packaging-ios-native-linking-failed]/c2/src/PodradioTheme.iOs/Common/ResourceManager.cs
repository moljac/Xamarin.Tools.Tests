using System;
using System.IO;
#if __UNIFIED__
using UIKit;
#else
using MonoTouch.UIKit;
#endif

namespace Xamarin.Themes {
	internal static class ResourceManager {

		const string ImagesFolder = "ThemeImages";

		public static UIImage ImageFromFile (string fileName)
		{
			return ImageFromFile (fileName, null);
		}

		public static UIImage TallImageFromFile (string fileName)
		{
			var originalName = fileName;

			if (DeviceInfo.IsTall)
				fileName += Attributes.IPhone5Suffix;

			return ImageFromFile (fileName, originalName);
		}

		public static UIImage TallImageFromFile (string fileName, UIEdgeInsets insets)
		{
			var originalName = fileName;

			if (DeviceInfo.IsTall)
				fileName += Attributes.IPhone5Suffix;

			return ImageFromFile (fileName, originalName, insets);
		}

		private static UIImage ImageFromFile (string fileName, string originalName)
		{
			var path = Path.Combine (ImagesFolder, (fileName + ".png"));

			var image = UIImage.FromFile (path);

			if (image == null && originalName != null) {
				path = Path.Combine (ImagesFolder, (originalName + ".png"));
				image = UIImage.FromFile (path);
			}

			return image;
		}

		private static UIImage ImageFromFile (string fileName, string originalName, UIEdgeInsets insets)
		{
			var path = Path.Combine (ImagesFolder, (fileName + ".png"));

			var image = UIImage.FromFile (path);	

			if (image == null && originalName != null) {
				path = Path.Combine (ImagesFolder, (originalName + ".png"));
				image = UIImage.FromFile (path);
			}

			if (image != null)
				image = image.CreateResizableImage (insets);

			return image;
		}
	}
}

