using MvvmCross.Core.ViewModels;

namespace IL.Core.ViewModels {

    public interface IMainViewModel {}

    public class MainViewModel : MvxViewModel, IMainViewModel {


        public void ShowMenu() {
            ShowViewModel<MenuViewModel>();
        }


    }
}