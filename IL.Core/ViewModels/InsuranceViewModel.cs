using MvvmCross.Core.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using IL.Core.Model;

namespace IL.Core.ViewModels {

    public class InsuranceViewModel : MvxViewModel {

        public InsuranceViewModel() {

            Initialize();
        }

        private void Initialize() {
            this.Title = "Insurance Coverage";
            this.Heading = "Insurance Boards In-Network";

            this.Content = new ObservableCollection<InsuranceCompany> {
                new InsuranceCompany { Name = "Highmark", Logo = "ic_directions_car_black_36dp"},
                new InsuranceCompany { Name = "Independence / BCBS", Logo = "ic_directions_walk_black_36dp"},
                new InsuranceCompany { Name = "United Health Care", Logo = "ic_directions_bike_black_36dp"},
                new InsuranceCompany { Name = "Quest EAP", Logo = "ic_location_on_black_36dp"},
                new InsuranceCompany { Name = "Mazzitti & Sullivan EAP"}
            };
        }

        public string Title { get; set; }
        public string Heading { get; set; }
        public ObservableCollection<InsuranceCompany> Content { get; set; }

    }
}