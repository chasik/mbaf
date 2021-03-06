﻿using System.Windows;
using DevExpress.Xpf.Core;

namespace mba_application
{
    public partial class MainView : DXWindow
    {
        public MainView()
        {
            InitializeComponent();
            Loaded += OnLoaded;
        }

        void OnLoaded(object sender, RoutedEventArgs e)
        {
            DXSplashScreen.Close();
        }
    }
}
