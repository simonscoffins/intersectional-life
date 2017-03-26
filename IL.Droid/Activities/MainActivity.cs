using Android.App;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using IL.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace IL.Droid.Activities {

    [Activity(
        //Label = "Main Activity",
        Theme = "@style/AppTheme",
        LaunchMode = LaunchMode.SingleTop, 
        Icon = "@mipmap/ic_launcher")]
    public class MainActivity : MvxCachingFragmentCompatActivity<MainViewModel> {

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

            _drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);

            //_drawerLayout.SetDrawerShadow(Resource.Drawable.drawer_shadow_light, (int)GravityFlags.Start);

            _drawerToggle = new MvxActionBarDrawerToggle(this, _drawerLayout, _toolbar, Resource.String.drawer_open, Resource.String.drawer_close);

            //_drawerToggle.DrawerClosed += _drawerToggle_DrawerClosed;
            //_drawerToggle.DrawerOpened += _drawerToggle_DrawerOpened;

            //SupportActionBar.SetDisplayShowTitleEnabled(false);
            //SupportActionBar.SetDisplayHomeAsUpEnabled(true);

            //_drawerToggle.DrawerIndicatorEnabled = true;
            _drawerLayout.AddDrawerListener(_drawerToggle);


            //ViewModel.ShowMenu();
            ViewModel.ShowAbout();

            var navigationView = FindViewById<NavigationView>(Resource.Id.navigation_view);

            
            navigationView.NavigationItemSelected += (sender, e) => {
                
                e.MenuItem.SetCheckable(true);
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

        }

        public override bool OnOptionsItemSelected(IMenuItem item) {

            switch (item.ItemId) {
                case Android.Resource.Id.Home:
                    DrawerLayout.OpenDrawer(Android.Support.V4.View.GravityCompat.Start);
                    return true;
            }
            return base.OnOptionsItemSelected(item);
        }


        //private void ShowBackButton() {
        //    //TODO Tell the toggle to set the indicator off
        //    //this.DrawerToggle.DrawerIndicatorEnabled = false;

        //    //Block the menu slide gesture
        //    DrawerLayout.SetDrawerLockMode(DrawerLayout.LockModeLockedClosed);
        //}

        //private void ShowHamburguerMenu() {
        //    //TODO set toggle indicator as enabled 
        //    //this.DrawerToggle.DrawerIndicatorEnabled = true;

        //    //Unlock the menu sliding gesture
        //    DrawerLayout.SetDrawerLockMode(DrawerLayout.LockModeUnlocked);
        //}

        //public override void OnBackPressed() {
        //    if (DrawerLayout != null && DrawerLayout.IsDrawerOpen(Android.Support.V4.View.GravityCompat.Start))
        //        DrawerLayout.CloseDrawers();
        //    else
        //        base.OnBackPressed();
        //}

        //public void HideSoftKeyboard() {
        //    if (CurrentFocus == null) return;

        //    var inputMethodManager = (Android.Views.InputMethods.InputMethodManager)GetSystemService(InputMethodService);
        //    inputMethodManager.HideSoftInputFromWindow(CurrentFocus.WindowToken, 0);

        //    CurrentFocus.ClearFocus();
        //        }

        protected override void OnPostCreate(Bundle savedInstanceState) {
            base.OnPostCreate(savedInstanceState);
            _drawerToggle.SyncState();
        }

        public override void OnConfigurationChanged(Configuration newConfig) {
            base.OnConfigurationChanged(newConfig);
            _drawerToggle.SyncState();
        }

        //private void _drawerToggle_DrawerOpened(object sender, ActionBarDrawerEventArgs e) {
        //    InvalidateOptionsMenu();
        //}

        //private void _drawerToggle_DrawerClosed(object sender, ActionBarDrawerEventArgs e) {
        //    InvalidateOptionsMenu();
        //}



        //internal void CloseDrawerMenu() {
        //    _drawerLayout.CloseDrawers();
        //}


        public void SetCustomTitle(string title) {
            _toolbar.Title = title;
        }

    }
}