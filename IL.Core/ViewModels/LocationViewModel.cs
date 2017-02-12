using IL.Core.Model;
using MvvmCross.Core.ViewModels;

namespace IL.Core.ViewModels {

    public class LocationViewModel : MvxViewModel {

        public LocationViewModel() {
            Initialise();
        }

        private void Initialise() {

            this.Title = "Location";

            this.Location = new Location {
                Latitude = Constants.Latitude,
                Longitude = Constants.Longitude
            };

            this.Address = new Address {
                Address1 = Constants.Address1,
                Address2 = Constants.Address2,
                City = Constants.City,
                State = Constants.State,
                ZipCode = Constants.ZipCode
            };
        }

        public string Title { get; set; }
        public Location Location { get; set; }
        public Address Address { get; set; }
    }
}