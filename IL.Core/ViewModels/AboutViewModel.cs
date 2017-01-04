using MvvmCross.Core.ViewModels;

namespace IL.Core.ViewModels {

    public class AboutViewModel : MvxViewModel {

        public AboutViewModel() {
            Title = "About";
            Information = "Intersectional Life Information";
        }

        public string Title { get; set; }
        public string Information { get; set; }
    }
}