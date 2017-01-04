using Android.App;
using Android.Content.PM;
using Android.OS;
using Mvvm.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Mvvm.Droid.Activities {

    [Activity(Label = "Main Activity", LaunchMode = LaunchMode.SingleTop, Icon = "@drawable/ic_launcher")]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel> {

        public new MainViewModel ViewModel {
            get { return (MainViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }


        protected override void OnCreate(Bundle savedInstanceState) {

            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.MainView);

            ViewModel.ShowOneViewModel();
            ViewModel.ShowTwoViewModel();
            ViewModel.ShowThreeViewModel();
        }
    }
}