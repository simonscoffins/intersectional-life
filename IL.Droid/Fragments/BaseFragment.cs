using IL.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V4;

namespace IL.Droid.Fragments {

    public abstract class BaseFragment<TViewModel> : MvxFragment {


        public new TViewModel ViewModel {
            get { return (TViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }
    }
}