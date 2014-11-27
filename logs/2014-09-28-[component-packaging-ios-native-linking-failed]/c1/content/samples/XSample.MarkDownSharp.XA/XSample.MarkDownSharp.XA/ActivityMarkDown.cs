using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XSample.MarkDownSharp.XA
{
	[Activity(Label = "XSample.MarkDownSharp.XA", MainLauncher = true, Icon = "@drawable/icon")]
	public class ActivityMarkDown : Activity
	{

		EditText editTextMarkDown = null;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.MarkDown);

			// Get our buttonTransform from the layout resource,
			// and attach an event to it
			Button		buttonTransform = FindViewById<Button>(Resource.Id.Transform);
			editTextMarkDown = FindViewById<EditText>(Resource.Id.editTextMarkDown);
			editTextMarkDown.Text = BusinessLogicObject.MarkDown;

			buttonTransform.Click += new EventHandler(buttonTransform_Click);
		}

		void buttonTransform_Click(object sender, EventArgs e)
		{
			BusinessLogicObject.MarkDown = editTextMarkDown.Text;
			BusinessLogicObject.MarkUpHTML = 
					BusinessLogicObject.MarkDownEngine.Transform(BusinessLogicObject.MarkDown);

			Intent intent = new Intent();
			intent.SetClass(this, typeof(ActivityMarkUp));
			StartActivity(intent);

			return;
		}
	}
}

