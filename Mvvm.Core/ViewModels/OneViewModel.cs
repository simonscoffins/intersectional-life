using MvvmCross.Core.ViewModels;

namespace Mvvm.Core.ViewModels {

    public class OneViewModel : MvxViewModel {

        public OneViewModel() {
            this.Message = "View Model #1";
        }

        public string Message { get; set; }             
    }
}