﻿using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using Android.Content;
using Android.Support.Design.Widget;
using IL.Core;
using IL.Core.Contracts.Services;
using IL.Droid.Services;
using MvvmCross.Binding.Bindings.Target.Construction;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using MvvmCross.Droid.Shared.Presenter;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;

namespace IL.Droid {

    public class Setup : MvxAndroidSetup {

        public Setup(Android.Content.Context applicationContext) : base(applicationContext) {
        }

        protected override IMvxApplication CreateApp() {
            return new App();
        }

        protected override IMvxTrace CreateDebugTrace() {
            return new DebugTrace();
        }

        protected override void InitializeIoC() {
            base.InitializeIoC();
            Mvx.RegisterSingleton<IDialogService>(() => new DialogService());
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter() {

            var mvxFragmentsPresenter = new MvxFragmentsPresenter(AndroidViewAssemblies);

            Mvx.RegisterSingleton<IMvxAndroidViewPresenter>(mvxFragmentsPresenter);

            return mvxFragmentsPresenter;
        }

        protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies) {

            typeof(NavigationView).Assembly,
            typeof(FloatingActionButton).Assembly,
            typeof(Android.Support.V7.Widget.Toolbar).Assembly,
            typeof(Android.Support.V4.Widget.DrawerLayout).Assembly,
            typeof(Android.Support.V4.View.ViewPager).Assembly,
        };

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry) {

            MvxAppCompatSetupHelper.FillTargetFactories(registry);
            base.FillTargetFactories(registry);
        }
    }
}