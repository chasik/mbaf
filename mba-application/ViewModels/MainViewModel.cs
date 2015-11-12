﻿using DevExpress.Mvvm;
using mba_application.MBAComponents;
using mba_application.MBAPermissionsService;
using System.Collections.ObjectModel;
using System.Windows;

namespace mba_application.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public Employee CurrentEmployee { get; set; }
        public ObservableCollection<PermissionDC> UserPermissions { get; set; }

        private INavigationService NavigationService { get { return GetService<INavigationService>(); } }

        public MainViewModel()
        {
            CurrentEmployee = new Employee();
            UserPermissions = new ObservableCollection<PermissionDC>();
        }
        public void OnViewLoaded()
        {
            NavigationService.Navigate("RegistryAddView", null, this);
        }
        public void OnInitMainView()
        {
            if (CurrentEmployee.TryEnter())
            {
                foreach (var p in CurrentEmployee.Permissions.PermissionsHashSet)
                {
                    UserPermissions.Add(p);
                }
            }
            else
            {

            }
        }
        public void MenuItemClick()
        {
            MessageBox.Show("!");
        }
    }
}