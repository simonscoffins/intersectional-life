using MvvmCross.Core.ViewModels;

namespace Mvvm.Core.ViewModels {

    public class TwoViewModel : MvxViewModel {

        public TwoViewModel() {
            this.Message = "View Model #2";
        }

        public string Message { get; set; }             
    }
}