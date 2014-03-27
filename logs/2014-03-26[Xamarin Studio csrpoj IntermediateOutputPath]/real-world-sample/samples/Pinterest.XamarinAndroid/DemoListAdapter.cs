using System;

using System.Collections.Generic;
using Android.Widget;
using Android.Graphics;
using Android.App;
using Android.Views;
using PinterestSDK.PinIt;
using Android.Content.Res;

namespace Pinterest.App.XamarinAndroid
{
	public class DemoListAdapter : BaseAdapter
	{
		private static readonly String TAG = DemoMainActivity.TAG;
		private static readonly String WEB_URL = "http://placekitten.com";
		private static readonly String IMAGE_SOURCE_BASE = "http://placekitten.com/";
	
		private List<Point> mSource = new List<Point>();
		private Activity mActivity;
		private LayoutInflater mInflater;
	
		readonly String mDescription;
		//private HashMap<String, Bitmap> mCache = new HashMap<String, Bitmap>(20);
		private Dictionary<String, Bitmap> mCache = new Dictionary<String, Bitmap>(20);

		public DemoListAdapter(Activity activity, List<Point> source) 
		{
			mSource = source;
			mActivity = activity;
			mInflater = activity.LayoutInflater;
	
			Resources res = activity.Resources;
			mDescription = res.GetString(Resource.String.pin_desc_kitten);
			
			return;
		}

		//@Override
		public override int Count
		{
			get
			{
				return mSource.Count;
			}
		}

		//@Override
		public override Java.Lang.Object GetItem (int position)
		{
			return mSource[position];
		}

		//@Override
		public override long GetItemId(int position) 
		{
			return position;
		}

		static  ViewHolder holder;
		
		//@Override
		public override View GetView(int position, View convertView, ViewGroup parent) 
		{
			if (convertView == null) 
			{
				convertView = mInflater.Inflate(Resource.Layout.listview_item, null);
				holder = new ViewHolder();
				holder.mImage = convertView.FindViewById<ImageView>(Resource.Id.source_iv);
				holder.mText = convertView.FindViewById<TextView>(Resource.Id.desc_tv);
				holder.mPinIt = convertView.FindViewById<PinItButton>(Resource.Id.pin_bt);
				convertView.Tag = (Java.Lang.Object) holder;
				
			} 
			else 
			{
				holder = (ViewHolder) convertView.Tag;
			}
			Point size = (Point) GetItem(position);
	
			String url = IMAGE_SOURCE_BASE + size.X + "/" + size.Y;
			setDisplayImage(holder.mImage, url);
	
			String desc = mDescription + " with size " + size.X + " X " + size.Y;
			
			holder.mText.Text = desc;
	
			holder.mPinIt.ImageUrl = url;
			holder.mPinIt.Description = desc;
			holder.mPinIt.Url = WEB_URL;

			return convertView;
		}

		private void setDisplayImage(/*final*/ ImageView iv, /*final*/ String url) 
		{
			// Show the remote image in ImageView.
			if (GetFromCache(url) != null) 
			{
				iv.SetImageBitmap(GetFromCache(url));
			} 
			else 
			{
				DemoHelper.RemoteImageTask rit = new DemoHelper.RemoteImageTask 
							(
							  iv 		// ImageView to be filled (placeholder)
							, url
							);
				rit.Execute();
			}
		}

		class ViewHolder : Java.Lang.Object
		{
			public ImageView mImage;
			public TextView mText;
			public PinItButton mPinIt;
		};

		// Get and put from the memory cache.
		private Bitmap GetFromCache (String key)
		{
			// return mCache[key];
			Bitmap bmp = null;
			bool bmp_exists = mCache.TryGetValue (key, out bmp);
						
			return bmp;
		}

		private void PutToCache(String key, Bitmap bmp) 
		{
			if (GetFromCache(key) == null)
			{
				mCache[key] = bmp;
			}
		}
	}
}

