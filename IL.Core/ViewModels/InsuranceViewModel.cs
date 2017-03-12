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
                new InsuranceCompany { Name = "BlueCross", Logo = "bc"},
                new InsuranceCompany { Name = "BlueCross BlueShield", Logo = "bcbs"},
                new InsuranceCompany { Name = "Highmark", Logo = "highmark"},
                new InsuranceCompany { Name = "Magellan Behavioral Health", Logo = "magellan"},
                new InsuranceCompany { Name = "Mazzitti & Sullivan EAP", Logo = "mazzitti_sullivan"},
                new InsuranceCompany { Name = "Quest EAP", Logo = "quest"},
                new InsuranceCompany { Name = "United Health Care", Logo = "unitedhealthcare"},
                new InsuranceCompany { Name = "Independence / BCBS", Logo = "independence"},
            };
        }

        public string Title { get; set; }
        public string Heading { get; set; }
        public ObservableCollection<InsuranceCompany> Content { get; set; }

    }
}