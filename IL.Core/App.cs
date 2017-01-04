﻿using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace IL.Core {

    public class App : MvxApplication {

        public override void Initialize() {

            base.Initialize();

            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ViewModels.MainViewModel>();
        }
    }
}