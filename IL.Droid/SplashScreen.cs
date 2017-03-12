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
    //, Icon = "@drawable/ic_launcher"
    , Theme = "@style/Theme.Splash"
    , NoHistory = true
    , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity {


        public SplashScreen() : base(Resource.Layout.SplashScreen) { }

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);
            //var textView = FindViewById<TextView>(Resource.Id.splash_text);
            //textView.Text = Constants.FullName;
        }


        protected override void TriggerFirstNavigate() {
            base.TriggerFirstNavigate();
        }
    }
}