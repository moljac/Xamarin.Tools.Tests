using System;

using System.Collections.Generic;
using Android.OS;
using Android.Widget;
using Android.App;
using Android.Graphics;

namespace Pinterest.App.XamarinAndroid
{
	[Activity]
	public class DemoListView : Activity
	{
		
	    private static readonly String TAG = DemoMainActivity.TAG;
	    private static readonly String IMAGE_SOURCE_BASE = 
						"http://xamarin.com"
						//"http://placekitten.com/"
						;
	
	    // Total number in list view.
	    private static readonly int N = 20;
	    private List<Point> mSource = new List<Point>();
	    private Random mRandom = new Random();

	    //@Override
	    protected override void OnCreate(Bundle savedInstanceState) 
			{
				base.OnCreate(savedInstanceState);
				SetContentView(Resource.Layout.activity_demo_listview);
				
				initSource();
				ListView list = FindViewById<ListView>(Resource.Id.list);
				DemoListAdapter adapter = new DemoListAdapter(this, mSource);
				list.Adapter = adapter;
			}

	    private void initSource() 
		{
	        int w, h;
	        for (int i = 0; i < N; i++) 
			{
	            // Generate w, h range from [1,5] and [1,4] respectively.
	            w = mRandom.Next(5) + 1;
	            h = mRandom.Next(4) + 1;
	            w *= 100;
	            h *= 100;
	            mSource.Add(new Point(w, h));
				
				return;
	        }
	    }
	}
}

