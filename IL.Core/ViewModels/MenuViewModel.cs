using System;
using System.Collections.ObjectModel;
using IL.Core.Utility;
using MvvmCross.Core.ViewModels;

namespace IL.Core.ViewModels {

    public class MenuViewModel : BaseViewModel {


        public MenuViewModel()  {
            this.MenuItems = new ObservableCollection<MenuItemViewModel>();
            CreateMenuItems();
        }


    public MvxCommand<MenuItemViewModel> MenuItemSelectCommand => new MvxCommand<MenuItemViewModel>(OnMenuEntrySelect);


        public ObservableCollection<MenuItemViewModel> MenuItems { get; }

        public event EventHandler CloseMenu;


        private void CreateMenuItems() {
            MenuItems.Add(new MenuItemViewModel {
                Title = "Menu Option #1",
                //ViewModelType = typeof(SearchJourneyViewModel),
                Option = MenuOption.MenuOption1,
                IsSelected = true
            });

            MenuItems.Add(new MenuItemViewModel {
                Title = "Menu Option #2",
//                ViewModelType = typeof(SavedJourneysViewModel),
                Option = MenuOption.MenuOption2,
                IsSelected = false
            });

            MenuItems.Add(new MenuItemViewModel {
                Title = "Menu Option #3",
 //               ViewModelType = typeof(SettingsViewModel),
                Option = MenuOption.MenuOption3,
                IsSelected = false
            });

            MenuItems.Add(new MenuItemViewModel {
                Title = "Menu Option #4",
//               ViewModelType = typeof(SettingsViewModel),
                Option = MenuOption.MenuOption4,
                IsSelected = false
            });
        }

        private void OnMenuEntrySelect(MenuItemViewModel item) {
            ShowViewModel(item.ViewModelType);
            RaiseCloseMenu();
        }

        private void RaiseCloseMenu() {
            CloseMenu?.Invoke(this, EventArgs.Empty);
        }
    }
}
