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
    [Register("mvvm.droid.fragments.ContactFragment")]
    public class ContactFragment : MvxFragment<ContactViewModel> {

        private LinearLayout _phoneLayoutView;
        private LinearLayout _emailLayoutView;
        private TextView _phoneNumberView;

        public override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {

            base.OnCreateView(inflater, container, savedInstanceState);
            return this.BindingInflate(Resource.Layout.ContactView, null);
        }


        public override void OnViewCreated(View view, Bundle savedInstanceState) {

            base.OnViewCreated(view, savedInstanceState);
            (this.Activity as MainActivity).SetCustomTitle(this.ViewModel.Title);

            FindViews();
            WireEvents();
        }


        private void FindViews() {
            _phoneLayoutView = View.FindViewById<LinearLayout>(Resource.Id.contact_phone_layout);
            _emailLayoutView = View.FindViewById<LinearLayout>(Resource.Id.contact_email_layout);
            _phoneNumberView = View.FindViewById<TextView>(Resource.Id.contact_phone);
        }

        private void WireEvents() {
            _phoneLayoutView.Click += _phoneLayoutView_Click;
            _emailLayoutView.Click += _emailLayoutView_Click;
        }

        private void _phoneLayoutView_Click(object sender, System.EventArgs e) {
            var uri = Android.Net.Uri.Parse($"tel: {_phoneNumberView.Text}");
            var intent = new Intent(Intent.ActionCall, uri);
            StartActivity(intent);
        }

        private void _emailLayoutView_Click(object sender, System.EventArgs e) {
            throw new System.NotImplementedException();
        }


    }
}