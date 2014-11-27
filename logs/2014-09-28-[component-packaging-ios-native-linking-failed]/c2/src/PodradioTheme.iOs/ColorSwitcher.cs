using System;
using System.Collections.Generic;
#if __UNIFIED__
using UIKit;
using CoreImage;
using CoreGraphics;
using Foundation;
#else
using MonoTouch.UIKit;
using MonoTouch.CoreImage;
using MonoTouch.CoreGraphics;
using MonoTouch.Foundation;
#endif

namespace Xamarin.Themes {
	public static class ColorSwitcher {

		static Dictionary<string, UIImage> processedImages;
		static float hue;
		static float saturation;
		static ColorScheme? currentScheme;

		public static UIColor TintColor { get; private set; }

		static ColorSwitcher ()
		{
			currentScheme = null;
			processedImages = new Dictionary<string, UIImage> ();
			TintColor = UIColor.FromRGBA (150 / 255f, 198 / 255f, 255 / 255f, 1f);
		}
		/// <summary>
		/// Changes the color scheme of the theme. If the theme was applied to all view by calling PodradioTheme.Apply(), dont forget to re-Apply theme after changing the sceme
		/// </summary>
		public static void ChangeScheme (ColorScheme scheme)
		{
			if (currentScheme.HasValue && currentScheme.Value == scheme)
				return;

			currentScheme = scheme;
			processedImages.Clear ();

			switch (scheme) {
			case ColorScheme.Maroon:
				hue = 1.40322f;
				saturation = 1.782143f;
				TintColor = UIColor.FromRGBA (153 / 255f, 107 / 255f, 136 / 255f, 1f);
				break;
			case ColorScheme.Brown:
				hue = 0.713114f;
				saturation = 0.760714f;
				TintColor = UIColor.FromRGBA (106 / 255f, 65 / 255f, 12 / 255f, 1f);
				break;
			case ColorScheme.Green:
				hue = 3.14f;
				saturation = 0.760714f;
				TintColor = UIColor.FromRGBA (109 / 255f, 137 / 255f, 34 / 255f, 1f);
				break;
			case ColorScheme.Black:
			default:
				hue = 0f;
				saturation = 1f;
				TintColor = UIColor.FromRGBA (150 / 255f, 198 / 255f, 255 / 255f, 1f);
				break;
			}
		}
		/// <summary>
		/// Processes the image with the current color scheme
		/// </summary>
		internal static UIImage ProcessImage (string imgPath, UIEdgeInsets? insets = null)
		{
			UIImage existing;
			if (processedImages.TryGetValue (imgPath, out existing)) 
				return existing;

			UIImage original;
			if (insets.HasValue) 
				original = ResourceManager.TallImageFromFile (imgPath, insets.Value);
			else
				original = ResourceManager.TallImageFromFile (imgPath);

			// if we didn't set the scheme, there's no need to process current image
			if (!currentScheme.HasValue)
				return original;

			var beginImage = CIImage.FromData (original.AsPNG());

			var context = CIContext.FromOptions (null);

			var hueFilter = new CIHueAdjust ();
			hueFilter.Image = beginImage;
			hueFilter.Angle = hue;

			var outputImage = hueFilter.OutputImage;

			var saturationFilter = new CIColorControls ();
			saturationFilter.Image = outputImage;
			saturationFilter.Saturation = saturation;

			outputImage = saturationFilter.OutputImage;

			var cgimg = context.CreateCGImage (outputImage, outputImage.Extent);

			UIImage processed;
			if (UIDevice.CurrentDevice.CheckSystemVersion (4, 0) && UIScreen.MainScreen.Scale >= 2f) {
				processed = new UIImage (cgimg, 2f, UIImageOrientation.Up);
			} else {
				processed = new UIImage (cgimg);
			}

			cgimg.Dispose ();

			processedImages [imgPath] = processed;
			return processed;
		}
		/// <summary>
		/// Clears the cache of processed images.
		/// </summary>
		public static void ClearCache ()
		{
			processedImages.Clear ();
		}
	}
}

