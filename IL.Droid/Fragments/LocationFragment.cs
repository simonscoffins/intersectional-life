using System;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using IL.Core.Model;
using IL.Core.ViewModels;
using IL.Droid.Activities;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace IL.Droid.Fragments {

    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("mvvm.droid.fragments.LocationFragment")]
    public class LocationFragment : MvxFragment<LocationViewModel>, IOnMapReadyCallback, GoogleMap.IInfoWindowAdapter  {

        private MapView _mapView;
        private GoogleMap _googleMap;
        private Location _location;
        private LatLng _mapLocation;

        private ImageButton _btnDriving;
        private ImageButton _btnWalking;
        private ImageButton _btnBicycling;
        private ImageButton _btnLocation;

        private string _geoLocation;
        private string _navigation;

        private const string Driving = "d";
        private const string Walking = "w";
        private const string Bicycling = "b";

        public LocationFragment() {
            this.RetainInstance = true;
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {

            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.LocationView, null);

            // get the map view
            _mapView = view.FindViewById<MapView>(Resource.Id.map);
            _mapView.OnCreate(savedInstanceState);

            Initialize(view);
            HandleEvents();

            return view;
        }

        private void Initialize(View view) {

            _btnDriving = view.FindViewById<ImageButton>(Resource.Id.driving);
            _btnWalking = view.FindViewById<ImageButton>(Resource.Id.walking);
            _btnBicycling = view.FindViewById<ImageButton>(Resource.Id.bicycling);
            _btnLocation = view.FindViewById<ImageButton>(Resource.Id.location);

            _location = ViewModel.Location;
            _mapLocation = new LatLng(_location.Latitude, _location.Longitude);

            SetupMapQueries();
        }


        private void HandleEvents() {
            _btnDriving.Click += BtnDrivingOnClick;
            _btnWalking.Click += BtnWalkingOnClick;
            _btnBicycling.Click += BtnBicyclingOnClick;
            _btnLocation.Click += BtnLocationOnClick;
        }

        private void BtnDrivingOnClick(object sender, EventArgs eventArgs) {
            TurnByTurnNavigation(Driving);
        }


        private void BtnBicyclingOnClick(object sender, EventArgs eventArgs) {
            TurnByTurnNavigation(Bicycling);
        }

        private void BtnWalkingOnClick(object sender, EventArgs eventArgs) {
            TurnByTurnNavigation(Walking);
        }

        private void BtnLocationOnClick(object sender, EventArgs eventArgs) {

            var uri = Android.Net.Uri.Parse(_geoLocation);
            var mapIntent = new Intent(Intent.ActionView, uri);
            mapIntent.SetPackage("com.google.android.apps.maps");
            StartActivity(mapIntent);
        }

        private void TurnByTurnNavigation(string mode) {

            var uri = Android.Net.Uri.Parse(_navigation + "&mode=" + mode);
            var mapIntent = new Intent(Intent.ActionView, uri);
            mapIntent.SetPackage("com.google.android.apps.maps");
            StartActivity(mapIntent);
        }


        private void SetupMapQueries() {

            // setup geo location
            var encodedName = Android.Net.Uri.Encode(Constants.FullName);
            _geoLocation = $"geo:{_location.Latitude},{_location.Longitude}?q={encodedName}";

            // setup navigation
            var address = $"+{Constants.Address1}+{Constants.City}+{Constants.State}+{Constants.ZipCode}";
            _navigation = ($"google.navigation:q={encodedName},{address}");
        }




        public override void OnViewCreated(View view, Bundle savedInstanceState) {

            base.OnViewCreated(view, savedInstanceState);

            (this.Activity as MainActivity)?.SetCustomTitle(this.ViewModel.Title);

            _mapView.GetMapAsync(this);
        }


        public override void OnSaveInstanceState(Bundle outState) {
            base.OnSaveInstanceState(outState);
            _mapView.OnSaveInstanceState(outState);
        }

        public override void OnResume() {
            base.OnResume();
            _mapView?.OnResume();
        }

        public override void OnLowMemory() {
            base.OnLowMemory();
            _mapView?.OnLowMemory();
        }

        public override void OnPause() {
            base.OnPause();
            _mapView?.OnPause();
        }

        public override void OnDestroy() {
            base.OnDestroy();
            _mapView?.OnDestroy();
        }




        public void OnMapReady(GoogleMap googleMap) {
            _googleMap = googleMap;
            _googleMap.UiSettings.CompassEnabled = true;

            SetLocationMarker();


            SetMapLocation();
        }


        private void SetMapLocation() {

            _location = ViewModel.Location;

            var builder = CameraPosition.InvokeBuilder();
            builder.Target(_mapLocation);
            builder.Zoom(18);
            //builder.Bearing(90);
            var cameraPosition = builder.Build();
            var cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);

            _googleMap.MoveCamera(cameraUpdate);
        }


        private void SetLocationMarker() {

            _googleMap.SetInfoWindowAdapter(this);

            var mrkrOptions = new MarkerOptions();
            mrkrOptions.SetPosition(_mapLocation);

            //var bmd = BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueRose);
            //marker.SetIcon(bmd);
            mrkrOptions.SetTitle(Constants.Name);

            var mrkr = _googleMap.AddMarker(mrkrOptions);
            mrkr.ShowInfoWindow();
        }


        public View GetInfoContents(Marker marker) {
            return null;
        }

        public View GetInfoWindow(Marker marker) {

            var view = this.Activity.LayoutInflater.Inflate(Resource.Layout.map_info_window, null, false);
            return view;
        }

    }

}