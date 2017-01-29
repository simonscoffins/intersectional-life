using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Runtime;
using Android.Views;
using IL.Core.Model;
using IL.Core.ViewModels;
using IL.Droid.Activities;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V4;

namespace IL.Droid.Fragments {

    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("mvvm.droid.fragments.LocationFragment")]
    public class LocationFragment : MvxFragment<LocationViewModel>, IOnMapReadyCallback, GoogleMap.IInfoWindowAdapter  {

        private MapView _mapView;
        private GoogleMap _googleMap;
        private Location _location;
        private LatLng _mapLocation;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {

            base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.LocationView, null);

            // get the map view
            _mapView = view.FindViewById<MapView>(Resource.Id.map);
            _mapView.OnCreate(savedInstanceState);

            Initialize();

            return view;
        }

        private void Initialize() {

            _location = ViewModel.Location;
            _mapLocation = new LatLng(_location.Latitude, _location.Longitude);
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