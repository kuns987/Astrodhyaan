using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Webkit;
using Android.Graphics;
using Plugin.Messaging;

namespace Astrodhyaan.Droid
{
    [Activity(Label = "Astrodhaam", Icon = "@drawable/sunrayslogo", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            var webLoadingIcon = this.FindViewById<WebView>(Resource.Id.webLoadingIcon);
            // expects to find the 'loading_icon_small.gif' file in the 'root' of the assets folder, compiled as AndroidAsset.
            //webLoadingIcon.LoadUrl(string.Format("file:////android_asset/sunrays1.gif"));
            // this makes it transparent so you can load it over a background
            //webLoadingIcon.SetBackgroundColor(new Color(0, 0, 0, 0));
            //webLoadingIcon.SetLayerType(LayerType.Software, null);
            Xamarin.Forms.Forms.SetFlags("Expander_Experimental");
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            Window.ClearFlags(WindowManagerFlags.TranslucentStatus);
            Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            Window.SetStatusBarColor(Color.ParseColor("#fff0db"));
            Window.SetNavigationBarColor(Color.ParseColor("#fff0db"));
            Window.SetTitleColor(Color.DarkGray);
            CrossMessaging.Current.Settings().Phone.AutoDial = true;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        
    }
    
            


}