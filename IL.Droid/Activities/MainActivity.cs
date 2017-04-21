using Android.App;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Views;
using IL.Core.ViewModels;
using MvvmCross.Droid.Shared.Caching;
using MvvmCross.Droid.Support.V7.AppCompat;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using IL.Droid.Wibble;
using System.Collections.Generic;

namespace IL.Droid.Activities {

    [Activity(
        //Label = "Main Activity",
        Theme = "@style/AppTheme",
        LaunchMode = LaunchMode.SingleTop, 
        Icon = "@mipmap/ic_launcher")]
    //public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel> {
    public class MainActivity : Wibble<MainViewModel> {

    private DrawerLayout _drawerLayout;
        private MvxActionBarDrawerToggle _drawerToggle;
        private Toolbar _toolbar;


        public DrawerLayout DrawerLayout {
            get { return _drawerLayout; }
        }

        public new MainViewModel ViewModel {
            get { return (MainViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle savedInstanceState) {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainView);

            _toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            _toolbar.Title = string.Empty;
            this.SetSupportActionBar(_toolbar);
            //this.SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            //this.SupportActionBar.SetHomeButtonEnabled(true);


            _drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

            _drawerToggle = new MvxActionBarDrawerToggle(this, _drawerLayout, _toolbar, Resource.String.drawer_open, Resource.String.drawer_close);
            _drawerLayout.AddDrawerListener(_drawerToggle);


            var navigationView = FindViewById<NavigationView>(Resource.Id.navigation_view);


            navigationView.NavigationItemSelected += (sender, e) => {

                //e.MenuItem.SetCheckable(true);
                e.MenuItem.SetChecked(true);

                switch (e.MenuItem.ItemId) {

                    case Resource.Id.nav_about:
                        ViewModel.ShowAbout();
                        break;

                    case Resource.Id.nav_insurance:
                        ViewModel.ShowInsurance();
                        break;

                    case Resource.Id.nav_location:
                        ViewModel.ShowDirections();
                        break;

                    case Resource.Id.nav_specializedfocus:
                        ViewModel.ShowSpecializedFocus();
                        break;

                    case Resource.Id.nav_contact:
                        ViewModel.ShowContact();
                        break;
                }

                _drawerLayout.CloseDrawers();
            };

            // first time start
            if (savedInstanceState == null) {
                navigationView.SetCheckedItem(Resource.Id.nav_about);
                ViewModel.ShowAbout();
            }

        }


        public override void OnSaveInstanceState(Bundle outState, PersistableBundle outPersistentState) {
            base.OnSaveInstanceState(outState, outPersistentState);


            

        }

        public override bool OnOptionsItemSelected(IMenuItem item) {

            switch (item.ItemId) {
                case Android.Resource.Id.Home:
                    DrawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }


        protected override void OnPostCreate(Bundle savedInstanceState) {
            base.OnPostCreate(savedInstanceState);
            _drawerToggle.SyncState();
        }

        public override void OnConfigurationChanged(Configuration newConfig) {
            base.OnConfigurationChanged(newConfig);
            _drawerToggle.SyncState();
        }

        public void SetCustomTitle(string title) {
            _toolbar.Title = title;
        }

        //bool _first = true;
        public override void OnBeforeFragmentChanging(IMvxCachedFragmentInfo fragmentInfo, Android.Support.V4.App.FragmentTransaction transaction) {

            var currentFrag = SupportFragmentManager.FindFragmentById(Resource.Id.content_frame) as MvvmCross.Droid.Support.V4.MvxFragment;

            base.OnBeforeFragmentChanging(fragmentInfo, transaction);
        }

        public override void OnFragmentChanging(IMvxCachedFragmentInfo fragmentInfo, Android.Support.V4.App.FragmentTransaction transaction) {

            var currentFrag = SupportFragmentManager.FindFragmentById(Resource.Id.content_frame) as MvvmCross.Droid.Support.V4.MvxFragment;

            base.OnFragmentChanging(fragmentInfo, transaction);
        }

        public override void OnFragmentChanged(IMvxCachedFragmentInfo fragmentInfo) {

            base.OnFragmentChanged(fragmentInfo);
        }

        public override void OnFragmentPopped(IList<IMvxCachedFragmentInfo> currentFragmentsInfo) {

            base.OnFragmentPopped(currentFragmentsInfo);
        }

        public override void OnFragmentCreated(IMvxCachedFragmentInfo fragmentInfo, Android.Support.V4.App.FragmentTransaction transaction) {

            var currentFrag = SupportFragmentManager.FindFragmentById(Resource.Id.content_frame) as MvvmCross.Droid.Support.V4.MvxFragment;

            base.OnFragmentCreated(fragmentInfo, transaction);
        }

        public override void OnBackPressed() {

            var currentFrag = SupportFragmentManager.FindFragmentById(Resource.Id.content_frame) as MvvmCross.Droid.Support.V4.MvxFragment;

            if (DrawerLayout != null && DrawerLayout.IsDrawerOpen(GravityCompat.Start)) {
                DrawerLayout.CloseDrawers();

            } else {

                if (currentFrag != null && currentFrag.ViewModel.GetType() == typeof(AboutViewModel)) {
                    Finish();
                } else {
                    ViewModel.ShowAbout();
                }
            }
            //Finish();
            //base.OnBackPressed();
        }


    }
}