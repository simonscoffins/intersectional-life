using Android.App;
using Android.Widget;

namespace IL.Droid.Extensions {


    public static class ActivityExtensions {

        public static void SetCustomTitle(this Activity activity, string title) {
            var toolbar = activity.FindViewById<Toolbar>(Resource.Id.toolbar);
            var textTitle = toolbar?.FindViewById<TextView>(Resource.Id.toolbar_title);
            if (textTitle != null) {
                textTitle.Text = title;
            }
        }
    }
}