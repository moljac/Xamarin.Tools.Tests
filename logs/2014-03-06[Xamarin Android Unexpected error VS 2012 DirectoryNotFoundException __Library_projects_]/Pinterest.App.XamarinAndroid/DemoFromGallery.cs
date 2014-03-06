using System;


using Android.Widget;
using Android.App;
using Com.Pinterest.Pinit;
using Android.OS;
using Android.Content;
using Android.Graphics;
using Java.IO;
using Android.Provider;

namespace Pinterest.App.XamarinAndroid
{
	[Activity]
	public class DemoFromGallery : Activity
	{
	    private static readonly String TAG = DemoMainActivity.TAG;
	    private static readonly String WEB_URL = 
							//"http://placekitten.com"
							"http://holisticware.net"
							;
	    private static readonly String DEFAULT_DESCRIPTION = "This image is from gallery";
	    private static readonly int IMAGE_SELECT = 801;
	
	    private ImageView mImage;
	    private Button mButton;
	    private TextView mDescriptEt;
	    private PinItButton mPinIt;
	    private TextView mUriTv;
	
	    private Android.Net.Uri mImageUri;
		
		
		
	    // @Override
	    protected override void OnCreate(Bundle savedInstanceState) 
		{
	        base.OnCreate(savedInstanceState);
	        SetContentView(Resource.Layout.activity_demo_from_gallery);
	
	        mButton = FindViewById<Button>(Resource.Id.gallery_bt);
	        //mButton.setOnClickListener(mButtonClicked);
			mButton.Click += HandleClick;
	        mImage = FindViewById<ImageView>(Resource.Id.source_iv);
	        mUriTv = FindViewById<TextView>(Resource.Id.uri_tv);
	        mDescriptEt = FindViewById<TextView>(Resource.Id.desc_tv);
	        mDescriptEt.Text = DEFAULT_DESCRIPTION;
	
			mPinIt = FindViewById<PinItButton>(Resource.Id.pin_bt);
	
	        PinItButton.DebugMode = true;
	        PinItButton.PartnerId = "myApp";
	        mPinIt.Url = WEB_URL;
	        mPinIt.Description = DEFAULT_DESCRIPTION;
	        PinItButton.PartnerId = DemoMainActivity.CLIENT_ID;
			
			return;
	    }

	    void HandleClick (object sender, EventArgs e)
	    {
            Intent intent = new Intent
									(
									  Intent.ActionPick
									, MediaStore.Images.Media.ExternalContentUri
									);
            StartActivityForResult(intent, IMAGE_SELECT);

			return;
	    }

		// @Override
	    protected override void OnActivityResult(int requestCode, Result resultCode, Intent data) 
		{
	        base.OnActivityResult(requestCode, resultCode, data);
			if (resultCode == Result.Ok && requestCode == IMAGE_SELECT) 
			{
	            // Check for returned image from gallery
	            if (data == null)
	                return;
	
				Android.Net.Uri imageUri = data.Data;
	            SetImageUri(imageUri);	
	        }
			
			return;
	    }

	    public void SetImageUri(Android.Net.Uri imageUri) 
		{
	        if (imageUri == null)
	            return;
	
	        mImageUri = imageUri;
	        mUriTv.Text = imageUri.ToString();
	        mPinIt.ImageUri = mImageUri;
	        try 
			{
	            Bitmap pinthumb = ImageFromUri(this, mImageUri, 400, 300);
	            mImage.SetImageBitmap(pinthumb);
	        } 
			catch (IOException ignored) 
			{
	        }
			
			return;
	    }

	    /**
	     * Get the image from Uri. If the image is too large, sample it.
	     * @param context
	     * @param uri
	     * @param width
	     * @param height
	     * @return
	     * @throws IOException
	     */
		public static Bitmap ImageFromUri (Context context, Android.Net.Uri uri, int width, int height)
		{
			ContentResolver resolver = context.ContentResolver;
			System.IO.Stream input = resolver.OpenInputStream (uri);
	
			// Just get some info
			BitmapFactory.Options onlyBoundsOptions = new BitmapFactory.Options ();
			onlyBoundsOptions.InJustDecodeBounds = true;
			onlyBoundsOptions.InDensity = Bitmap.DensityNone;
			onlyBoundsOptions.InPurgeable = true;
			onlyBoundsOptions.InInputShareable = true;
			BitmapFactory.DecodeStream (input, null, onlyBoundsOptions);
			input.Close ();
			int xSample = 0, ySample = 0;
			if ((onlyBoundsOptions.OutWidth == -1) || (onlyBoundsOptions.OutHeight == -1))
			{
	            return null;
			}
	        else 
			{
	            xSample = (int) Math.Floor(onlyBoundsOptions.OutWidth / (double)width);
	            ySample = (int) Math.Floor(onlyBoundsOptions.OutHeight / (double)height);
	        }
	
	        // Decode
	        BitmapFactory.Options bitmapOptions = new BitmapFactory.Options();
	        bitmapOptions.InPreferredConfig = Bitmap.Config.Argb8888;
	        bitmapOptions.InDensity = Bitmap.DensityNone;
	        bitmapOptions.InPurgeable = true;
	        bitmapOptions.InInputShareable = true;
	        bitmapOptions.InSampleSize = Math.Min(xSample, ySample);
	
	        input = context.ContentResolver.OpenInputStream(uri);
	        Bitmap bitmap = BitmapFactory.DecodeStream(input, null, bitmapOptions);
	        input.Close();
	
	        return bitmap;
	    }
	}
}

