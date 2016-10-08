using Android.App;
using Android.Widget;
using Android.OS;
using IL.Core;

namespace IL.Android {

    [Activity(Label = "Intersectional Life", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity {


        private TextView _description;

        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            FindViews();

            _description.Text = Data.Description;
        }

        private void FindViews() {

            _description = FindViewById<TextView>(Resource.Id.description);
        }

    }
}

