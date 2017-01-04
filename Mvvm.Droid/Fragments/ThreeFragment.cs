using Android.OS;
using Android.Runtime;
using Android.Views;
using Mvvm.Core.ViewModels;
using Mvvm.Droid.Activities;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace Mvvm.Droid.Fragments {

    [MvxFragment(typeof(MainViewModel), Resource.Id.frame_three, true)]
    [Register("mvvm.droid.fragments.ThreeFragment")]
    public class ThreeFragment : MvxFragment<ThreeViewModel> {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {

            base.OnCreateView(inflater, container, savedInstanceState);

            return this.BindingInflate(Resource.Layout.ThreeView, null);
        }
    }
}