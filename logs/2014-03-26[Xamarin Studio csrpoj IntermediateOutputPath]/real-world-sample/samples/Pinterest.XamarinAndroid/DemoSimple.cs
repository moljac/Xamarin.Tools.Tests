using System;

using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.Res;

using PinterestSDK.PinIt;

namespace Pinterest.App.XamarinAndroid
{
	[Activity]
	public class DemoSimple : Activity
	{
		private static readonly String TAG = DemoMainActivity.TAG;
		private static readonly String IMAGE_SOURCE = "https://vsipprogram.com/content/upload/logo/Xamarin%20Inc..zpoh_xamarin-logo-hexagon-blue.png";
		private static readonly String WEB_URL =  "http://xamarin.com";
	
		private ImageView mImage;

		protected override void OnCreate (Bundle savedInstanceState)
		{			
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.activity_demo_simple);

			Resources res = this.Resources;
			string description = res.GetString (Resource.String.pin_desc_kitten);
			(FindViewById<TextView> (Resource.Id.desc_tv)).Text = description;
			mImage = FindViewById<ImageView> (Resource.Id.source_iv);

			// Show the remote image in ImageView.
			// TODo: not working
			DemoHelper.RemoteImageTask rit = new DemoHelper.RemoteImageTask 
						(
						  mImage 		// ImageView to be filled (placeholder)
						, IMAGE_SOURCE
						);
			rit.Execute();

			PinItButton pinIt = FindViewById<PinItButton> (Resource.Id.pin_bt);
			pinIt.ImageUrl = IMAGE_SOURCE;
			pinIt.Url  = WEB_URL;
			pinIt.Description  = description;
			pinIt.Listener = _listener;

			// works
			//mImage.SetImageResource(Resource.Drawable.xamarin_x);
			//mImage.SetImageBitmap(rit.BitMapShown);
			mImage = rit.ImageViewShown;

			return;
		}
		
		PinItListenerForDemo _listener = new PinItListenerForDemo() ;
			
		internal class PinItListenerForDemo : PinterestSDK.PinIt.PinItListener
		{

			// @Override
			public override void OnStart() 
			{
				base.OnStart();
				Android.Util.Log.Info(TAG, "PinItListener.onStart");
			}

			// @Override
			public override void OnComplete(bool completed) 
			{
				base.OnComplete(completed);
				Android.Util.Log.Info(TAG, "PinItListener.onComplete");
			}

			// @Override
			public override void OnException(Java.Lang.Exception e) 
			{
				base.OnException(e);
				Android.Util.Log.Info(TAG, "PinItListener.onException");
			}
		}
	}
}
