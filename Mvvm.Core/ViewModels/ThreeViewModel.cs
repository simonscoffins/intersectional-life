using MvvmCross.Core.ViewModels;

namespace Mvvm.Core.ViewModels {

    public class ThreeViewModel : MvxViewModel {

        public ThreeViewModel() {
            this.Message = "View Model #3";
        }

        public string Message { get; set; }             
    }
}