using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1
{
	[Application]
	public class Application : Android.App.Application
	{
		public Application(IntPtr javaReference, JniHandleOwnership transfer)
			: base(javaReference, transfer)
		{
			return;
		}

		public override void OnCreate()
		{
			base.OnCreate();

			XUbertestersSDK.XUbertesters
				.Initialize
						(
						  this
				//, UbertestersSDK.Common.Models.LockingMode.LockingModeLockAppIfBuildNotExist
						);

			return;
		}
	}
}