using MvvmCross.Core.ViewModels;

namespace IL.Core.ViewModels {

    public class MainViewModel : MvxViewModel {


        //public void ShowMenu() {
        //    ShowViewModel<MenuViewModel>();
        //}

        public void ShowAbout() {
            ShowViewModel<AboutViewModel>();
        }

        public void ShowInsurance() {
            ShowViewModel<InsuranceViewModel>();
        }

        public void ShowDirections() {
            ShowViewModel<LocationViewModel>();
        }

        public void ShowSpecializedFocus() {
            ShowViewModel<SpecializedFocusViewModel>();
        }

        public void ShowContact() {
            ShowViewModel<ContactViewModel>();
        }
    }
}