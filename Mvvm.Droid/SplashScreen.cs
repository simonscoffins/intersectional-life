using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Mvvm.Droid {

    //[Activity(
    //    MainLauncher = true,
    //    Label = "@string/ApplicationName",
    //    Theme = "@style/Theme.Splash", NoHistory = true,
    //    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
    //    ScreenOrientation = ScreenOrientation.Portrait)]


    [Activity(
    Label = "@string/ApplicationName"
    , MainLauncher = true
    , Icon = "@drawable/ic_launcher"
    //, Theme = "@style/Theme.Splash"
    , NoHistory = true
    , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity {

        public SplashScreen() : base(Resource.Layout.SplashScreen) {}
    }
}