using Android.OS;
using Android.Runtime;
using Android.Views;
using IL.Core.ViewModels;
using IL.Droid.Activities;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;
using System;
using System.Threading.Tasks;
using Android.Support.Design.Widget;

namespace IL.Droid.Fragments {

    [MvxFragment(typeof(MainViewModel), Resource.Id.navigation_frame, true)]
    [Register("mvvm.droid.fragments.MenuFragment")]
    public class MenuFragment : MvxFragment<MenuViewModel> {

        //private NavigationView _navigationView;
        //private IMenuItem _previousMenuItem;


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {

            base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(Resource.Layout.MenuView, null);

            //_navigationView = view.FindViewById<NavigationView>(Resource.Id.navigation_view);
            //_navigationView.SetNavigationItemSelectedListener(this);
            //_navigationView.Menu.FindItem(Resource.Id.nav_about).SetChecked(true);

            return view;

        }


        //public override void OnStart() {
        //    base.OnStart();
        //    this.ViewModel.CloseMenu += OnCloseMenu;
        //}


        //public override void OnStop() {
        //    base.OnStop();
        //    ViewModel.CloseMenu -= OnCloseMenu;
        //}


        //private void OnCloseMenu(object sender, EventArgs e) {

        //    (Activity as MainActivity)?.CloseDrawerMenu();
        //}


        //public bool OnNavigationItemSelected(IMenuItem menuItem) {
        //    return true;
        //}

        //public bool OnNavigationItemSelected(IMenuItem item) {
        //    if (item != _previousMenuItem) {
        //        _previousMenuItem?.SetChecked(false);
        //    }

        //    item.SetCheckable(true);
        //    item.SetChecked(true);

        //    _previousMenuItem = item;

        //    Navigate(item.ItemId);

        //    return true;
        //}


        //private async Task Navigate(int itemId) {
        //    ((MainActivity)Activity).DrawerLayout.CloseDrawers();

        //    // add a small delay to prevent any UI issues
        //    //await Task.Delay(TimeSpan.FromMilliseconds(250));

        //    //switch (itemId) {
        //    //    case Resource.Id.nav_home:
        //    //        ViewModel.ShowHomeCommand.Execute();
        //    //        break;
        //    //    case Resource.Id.nav_viewpager:
        //    //        ViewModel.ShowViewPagerCommand.Execute();
        //    //        break;
        //    //    case Resource.Id.nav_recyclerview:
        //    //        ViewModel.ShowRecyclerCommand.Execute();
        //    //        break;
        //    //    case Resource.Id.nav_settings:
        //    //        ViewModel.ShowSettingCommand.Execute();
        //    //        break;
        //    //    case Resource.Id.nav_helpfeedback:
        //    //        ViewModel.ShowHelpCommand.Execute();
        //    //        break;
        //    //}
        //}


    }


}