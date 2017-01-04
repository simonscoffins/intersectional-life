using Android.OS;
using Android.Runtime;
using Android.Views;
using Mvvm.Core.ViewModels;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace Mvvm.Droid.Fragments {

    [MvxFragment(typeof(MainViewModel), Resource.Id.frame_two, true)]
    [Register("mvvm.droid.fragments.TwoFragment")]
    public class TwoFragment : MvxFragment<TwoViewModel> {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {

            base.OnCreateView(inflater, container, savedInstanceState);

            return this.BindingInflate(Resource.Layout.TwoView, null);
        }
    }
}