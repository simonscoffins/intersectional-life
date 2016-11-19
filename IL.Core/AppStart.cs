using IL.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace IL.Core {

    public class AppStart : MvxNavigatingObject, IMvxAppStart{

        public void Start(object hint = null) {

            // application setup code goes here

            ShowViewModel<MainViewModel>();
        }
    }
}