using MvvmCross.Core.ViewModels;

namespace IL.Core.ViewModels {

    public class SpecializedFocusViewModel : MvxViewModel {

        public SpecializedFocusViewModel() {

            Title = "Specialized Focus";
            Information = "Areas of specialized focus";
        }

        public string Title { get; set; }
        public string Information { get; set; }
    }
}