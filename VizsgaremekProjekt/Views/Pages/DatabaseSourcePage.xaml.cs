﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VizsgaremekProjekt.Navigation;
using VizsgaremekProjekt.Pages;

namespace VizsgaremekProjekt.Views.Pages
{
    /// <summary>
    /// Interaction logic for DatabaseSourcePage.xaml
    /// </summary>
    public partial class DatabaseSourcePage : UserControl
    {
        public DatabaseSourcePage()
        {
            InitializeComponent();
        }

        private void Image_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            WelcomePage welcomePage = new WelcomePage();
            Navigate.Navigation(welcomePage);
        }
    }
}
