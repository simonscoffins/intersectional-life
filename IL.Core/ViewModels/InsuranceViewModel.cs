using MvvmCross.Core.ViewModels;

namespace IL.Core.ViewModels {

    public class InsuranceViewModel : MvxViewModel {

        public InsuranceViewModel() {

            Title = "Insurance";
            Information = "Insurance coverage information";
        }

        public string Title { get; set; }
        public string Information { get; set; }
    }
}