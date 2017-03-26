using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using IL.Core.Model;

namespace IL.Core.ViewModels {

    public class InsuranceViewModel : MvxViewModel {

        public InsuranceViewModel() {

            Initialize();
        }

        private void Initialize() {
            this.Title = "Insurance Coverage";

            this.InsuranceList = new ObservableCollection<InsuranceCompany> {
                new InsuranceCompany { Name = "BlueCross", Logo = "bc", WebSite = "https://www.bcbs.com/"},
                new InsuranceCompany { Name = "BlueCross BlueShield", Logo = "bcbs", WebSite = "https://www.bcbs.com/"},
                new InsuranceCompany { Name = "Highmark", Logo = "highmark", WebSite = "https://www.highmark.com/"},
                new InsuranceCompany { Name = "Magellan Behavioral Health", Logo = "magellan", WebSite = "https://www.magellanassist.com"},
                new InsuranceCompany { Name = "Mazzitti & Sullivan EAP", Logo = "mazzitti_sullivan", WebSite = "https://www.mazzittiandsullivan.com/" },
                new InsuranceCompany { Name = "Quest EAP", Logo = "quest", WebSite = "https://www.questbh.com/"},
                new InsuranceCompany { Name = "United Health Care", Logo = "unitedhealthcare", WebSite = "https://www.uhc.com/"},
                new InsuranceCompany { Name = "Independence / BCBS", Logo = "independence", WebSite = "https://www.ibx.com"},
            };
        }

        public string Title { get; set; }
        public ObservableCollection<InsuranceCompany> InsuranceList { get; set; }

    }
}