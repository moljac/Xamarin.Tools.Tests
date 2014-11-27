using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XSample.MarkDownSharp.XA
{
	[Activity(Label = "XSample.MarkDownSharp.XA")]
	public class ActivityMarkUp : Activity
	{
		String html = "<html><body>Hello, World!</body></html>";
		String mime = "text/html";
		String encoding = "utf-8";

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.MarkUp);

			// Get our buttonTransform from the layout resource,
			// and attach an event to it
			Button		buttonTransform = FindViewById<Button>(Resource.Id.Transform);
			Android.Webkit.WebView browser = FindViewById<Android.Webkit.WebView>(Resource.Id.webView1);
			browser.LoadData(BusinessLogicObject.MarkUpHTML, mime, encoding);
			string html = "";
			html = BusinessLogicObject.MarkUpHTML;

			if (Android.OS.Build.VERSION.Release.StartsWith("2."))
			{
				// http://developer.android.com/guide/topics/manifest/uses-sdk-element.html
				// In 2.x platforms loadData() fails in some cases (it requires the html to be escaped), 
				// use loadDataWithBaseURL() instead and pass null for baseUrl and historyUrl:

				//html = Java.Net.URLEncoder.Encode(BusinessLogicObject.MarkUpHTML).Replace("\\+", " ");
				browser.LoadDataWithBaseURL(null, html, "text/html", "utf-8", null);

			}
			else
			{
				browser.LoadData(BusinessLogicObject.MarkUpHTML, mime, encoding);
			}

			buttonTransform.Click += new EventHandler(buttonTransform_Click);

			return;
		}

		void buttonTransform_Click(object sender, EventArgs e)
		{
			this.Finish();

			return;
		}
	}
}

