﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace StorageDroid.Droid
{
	[Activity (Label = "StorageDroid.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

            button.Click += Button_Click;
		}

        private async void Button_Click(object sender, EventArgs e)
        {
            StorageDroid.StorageService storageSvc = new StorageService();
            await storageSvc.performBlobOperation("enmanuelreyes@live.com");           
        }
    }
}


