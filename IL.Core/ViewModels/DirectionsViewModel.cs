using MvvmCross.Core.ViewModels;

namespace IL.Core.ViewModels {

    public class DirectionsViewModel : MvxViewModel {

        public DirectionsViewModel() {

            Title = "Directions";
            Information = "Google Maps go here";
        }

        public string Title { get; set; }
        public string Information { get; set; }
    }
}