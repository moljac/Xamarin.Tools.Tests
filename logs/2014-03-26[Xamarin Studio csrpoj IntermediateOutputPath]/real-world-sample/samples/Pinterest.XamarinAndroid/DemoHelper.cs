using System;
using Android.Widget;

namespace Pinterest.App.XamarinAndroid
{
	public class DemoHelper
	{
	    private static readonly string TAG = DemoMainActivity.TAG;

		public class RemoteImageTask : Android.OS.AsyncTask
		{
			public ImageView ImageViewShown;
			public Android.Graphics.Bitmap BitMapShown;
			
	        String _imageSource;
	        TaskCallback _callback;
			
			public RemoteImageTask(ImageView image, String imageSource) 
				: this(image, imageSource, null)
			{
				return;
			}
			
			public RemoteImageTask(ImageView image, String imageSource, TaskCallback callback) 
			{
			    ImageViewShown = image;
			    _imageSource = imageSource;
			    _callback = callback;
			}

			protected override void OnPreExecute()
		    {
		    }
		
		    protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
		    {
	            Java.Net.URL url;
	            try 
				{
	                url = new Java.Net.URL(_imageSource);
	                BitMapShown = Android.Graphics.BitmapFactory.DecodeStream(url.OpenConnection().InputStream);
	            } 
				catch (Exception ignored) 
				{
	                Android.Util.Log.Error(TAG, "Exception", ignored);
	            }
	
	            return BitMapShown;
		    }
		
		    protected override void OnPostExecute
										(
										  //Android.Graphics.Bitmap bmp
										  Java.Lang.Object result
										)
		    {
				Android.Graphics.Bitmap bmp = (Android.Graphics.Bitmap) result;
	            ImageViewShown.SetImageBitmap(bmp);
	            if (_callback != null)
	                _callback.OnTaskFinished(bmp);
				
				return;
		    }
		}		
    }

    public interface TaskCallback 
	{
        /*public*/ void OnTaskFinished(Android.Graphics.Bitmap bmp);
    }
}

