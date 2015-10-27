﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using mba_client.components;

namespace mba_client
{
    public partial class MainWindow : DevExpress.Xpf.Core.DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addRegistryMenuItem_Click(object sender, EventArgs e)
        {
            addRegistry = Registry.GetInstance(mainDockManager);
        }

        private Registry addRegistry;
    }

}
