using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AndroidHUD;
using Plugin.Media;

namespace Facepy.Droid
{
    [Activity(Label = "Facepy", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        Button btnTakePic;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            btnTakePic = FindViewById<Button>(Resource.Id.btnTakePic);

            btnTakePic.Click += BtnTakePic_Click;
            AndHUD.Shared.Show(this, "Initializing");
            AndHUD.Shared.Dismiss();
        }

        async void BtnTakePic_Click(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsPickPhotoSupported)
            {
                btnTakePic.Text = string.Format("{0} clicks!", count++);
            }
        }
    }
}


