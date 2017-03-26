using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using IL.Core.ViewModels;
using IL.Droid.Activities;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace IL.Droid.Fragments {

    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("mvvm.droid.fragments.InsuranceFragment")]
    public class InsuranceFragment : MvxFragment<InsuranceViewModel> {


        private ListView _insuranceListView;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {

            base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.InsuranceView, null);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState) {

            base.OnViewCreated(view, savedInstanceState);
            (this.Activity as MainActivity).SetCustomTitle(this.ViewModel.Title);

            FindViews();
            WireEvents();
        }

        private void FindViews() {
            _insuranceListView = View.FindViewById<ListView>(Resource.Id.insurance_list);
        }

        private void WireEvents() {
            _insuranceListView.ItemClick += _insuranceListView_ItemClick;
        }

        private void _insuranceListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e) {

            var insuranceItem = this.ViewModel.InsuranceList[e.Position];

            var uri = Android.Net.Uri.Parse(insuranceItem.WebSite);
            var intent = new Intent(Intent.ActionView, uri);
            StartActivity(intent);
        }
 
    }
}