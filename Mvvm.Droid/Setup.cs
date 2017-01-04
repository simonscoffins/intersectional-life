using Android.Content;
using Mvvm.Core;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Shared.Presenter;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;

namespace Mvvm.Droid {

    public class Setup : MvxAndroidSetup{

        public Setup(Context applicationContext) : base(applicationContext) {}

        protected override IMvxApplication CreateApp() {

            return new Core.App();
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter() {

            var mvxFragmentsPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);
            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentsPresenter);
            return mvxFragmentsPresenter;
        }
    }
}