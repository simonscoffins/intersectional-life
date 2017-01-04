using Android.OS;
using Android.Runtime;
using Android.Views;
using IL.Core.ViewModels;
using IL.Droid.Activities;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace IL.Droid.Fragments {

    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("mvvm.droid.fragments.InsuranceFragment")]
    public class InsuranceFragment : MvxFragment<InsuranceViewModel> {

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {

            base.OnCreateView(inflater, container, savedInstanceState);

            return this.BindingInflate(Resource.Layout.InsuranceView, null);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState) {

            base.OnViewCreated(view, savedInstanceState);
            (this.Activity as MainActivity).SetCustomTitle(this.ViewModel.Title);
        }

    }
}