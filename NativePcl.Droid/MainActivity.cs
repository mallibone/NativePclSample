using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using NativePcl.Core.ViewModel;

namespace NativePcl.Droid
{
    [Activity(Label = "NativePcl.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        #region UI Controls

        private TextView OSVersion => FindViewById<TextView>(Resource.Id.OSVersion);

        #endregion

        private MainViewModel VM => Locator.Instance.Main;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            OSVersion.Text = VM.OSVersion;
            //OSVersion.Text = "hello world";
        }
    }
}

