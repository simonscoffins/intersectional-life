using System;
using IL.Core.Utility;
using MvvmCross.Core.ViewModels;

namespace IL.Core.ViewModels {


    public class MenuItemViewModel : MvxViewModel {

        private bool _isSelected;

        public string Title { get; set; }
        public Type ViewModelType { get; set; }
        public MenuOption Option { get; set; }

        public bool IsSelected {
            get {
                return _isSelected;
            }
            set {
                _isSelected = value;
                RaisePropertyChanged(() => IsSelected);
            }
        }




    }
}