using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Widget;
using IL.Core.Model;
using MvvmCross.Droid.Views;

namespace IL.Droid {

    [Activity(
    Label = "@string/ApplicationName"
    , MainLauncher = true
    , Theme = "@style/Theme.Splash"
    , NoHistory = true
    , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity {


        public SplashScreen() : base(Resource.Layout.SplashScreen) { }
    }
}