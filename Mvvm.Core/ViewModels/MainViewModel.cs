using MvvmCross.Core.ViewModels;

namespace Mvvm.Core.ViewModels {

    public class MainViewModel : MvxViewModel{

        public MainViewModel() {
            
        }


        public void ShowOneViewModel() {
            ShowViewModel<OneViewModel>();
        }

        public void ShowTwoViewModel() {
            ShowViewModel<TwoViewModel>();
        }

        public void ShowThreeViewModel() {
            ShowViewModel<ThreeViewModel>();
        }
    }
}