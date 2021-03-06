﻿using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using mba_application.MBAComponents;
using mba_application.MBAComponents.MBAMessages;
using System.Collections.ObjectModel;

namespace mba_application.ViewModels
{
    [POCOViewModel]
    public class MainViewModel
    {
        public virtual Employee CurrentEmployee { get; set; }
        public virtual bool MbaPhoneEnable { get; set; }

        public virtual ObservableCollection<PermissionGroup> UserPermissionGroups { get; set; }
        public virtual ObservableCollection<Tool> UserTools { get; set; }

        public virtual INavigationService NavigationService => null;

        protected MainViewModel()
        {
        }

        public static MainViewModel Create()
        {
            return ViewModelSource.Create(() => new MainViewModel());
        }

        public void OnInitMainView()
        {
            CurrentEmployee = new Employee();
            if (CurrentEmployee.TryEnter())
            {
                MbaPhoneEnable = CurrentEmployee.MbaPhoneEnable;
                UserPermissionGroups = new ObservableCollection<PermissionGroup>(CurrentEmployee.PermissionGroups);
                UserTools = new ObservableCollection<Tool>(CurrentEmployee.Tools);
            }
            else
            {
                NavigationService.Navigate("TryEnterError", null, this);
            }
        }

        public void MenuItemClick(string frameName)
        {
            NavigationService.Navigate(frameName);
        }

        public void CloseMainWindow()
        {
            Messenger.Default.Send(new CloseProgramMessage());
        }
    }
}