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
                Latitude = 40.040898,
                Longitude = -76.303913
            };

            this.Address = new Address {
                Address1 = "135 North Duke Street",
                Address2 = "Suite 1",
                City = "Lancaster",
                State = "PA",
                ZipCode = "17602"
            };
        }

        public string Title { get; set; }
        public Location Location { get; set; }
        public Address Address { get; set; }
    }
}