using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

/*
	Pinterest SDK Demo ported 1:1 by miljenko.cvjetko@xamarin.com
	
	java final keyword 
		replaced with
			c# readonly
*/
using System.Collections.Generic;


namespace Pinterest.App.XamarinAndroid
{
	[Activity(Label = "Pinterest.XamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
	public class DemoMainActivity : Activity
	{
		public static readonly string TAG = "Demo Activity";
		/**
		 * Please generate your Client ID at http://developers.pinterest.com/manage/ , and put it here.
		 */
		public static readonly string CLIENT_ID = "1234"; // "Please use your own Client ID"

		private ListView mList;
		private ArrayAdapter<string> mAdapter;

		// Create and populate a List of planet names.
		private static readonly string[] EXAMPLES = new string[] 
		{
			"1. Simple PinIt Demo", 
			"2. PinIt from Gallery", 
			"3. PinIt in ListView"
		};

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_demo);
			
			List<string> examples = new List<string>(EXAMPLES);
			mList = FindViewById<ListView>(Resource.Id.list);
	
			// Create ArrayAdapter using the list.
			mAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, examples);
			mList.Adapter= mAdapter;
			mList.ItemClick += HandleItemClick;  
				//setOnItemClickListener(mListener);

			PinterestSDK.PinIt.PinItButton.DebugMode = true;
			PinterestSDK.PinIt.PinItButton.PartnerId = CLIENT_ID;

			return;
		}

		void HandleItemClick (object sender, AdapterView.ItemClickEventArgs e)
		{
			// mc++ hardcoded until 2 samples are not implemented
			var arg2 = e.Position;
			
			Intent intent = null;
			Activity activity = this;
			switch (arg2) 
			{
				case 0:
					intent = new Intent(activity, typeof(DemoSimple));
					break;
				case 1:
					intent = new Intent(activity, typeof(DemoFromGallery));
					break;
				case 2:
					intent = new Intent(activity, typeof(DemoListView));
					break;
				default:
					return;
			}
			activity.StartActivity(intent);
			
			return;
		}

	}
}

