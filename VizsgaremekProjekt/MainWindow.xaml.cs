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
using VizsgaremekProjekt.ViewModels;

namespace VizsgaremekProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel mainWindowViewModel;
        DatabaseSourceViewModel databaseSourceViewModel;
        

        public MainWindow()
        {
            // Különböző ablakok adatai
            mainWindowViewModel = new MainWindowViewModel();
            databaseSourceViewModel = new DatabaseSourceViewModel();
            mainWindowViewModel.SelectedSource = databaseSourceViewModel.SelectedDatabaseSource;

            // Feliratkozunk az eseményre. Ha változik az adat az adott osztályba tudni fogunk róla!
            databaseSourceViewModel.ChangeDatabaseSource += DatabaseSourceViewModel_ChangeDatabaseSource;

            InitializeComponent();
            // A MainWidow ablakban megjelenő adatok a MainWindowViewModelben vannak
            this.DataContext = mainWindowViewModel;
            // Statikus osztály a Navigate
            // Eltárolja a nyitó ablakt, hogy azon tudjuk módosítani a "page"-ket
            Navigate.mainWindow = this;
            // Létrehozzuk a nyitó "UserControl" (WelcomPage)
            WelcomePage welcomePage = new WelcomePage();
            // Megjelnítjük a WelcomePage-t
            Navigate.Navigation(welcomePage);
        }

        private void DatabaseSourceViewModel_ChangeDatabaseSource(object sender, EventArgs e)
        {
            DatabaseSourceEventArg dsea = (DatabaseSourceEventArg) e;
            mainWindowViewModel.SelectedSource = dsea.DatabaseSource;
        }


        /// <summary>
        /// ListView elemen bal egér gomb fel lett engedve
        /// </summary>
        /// <param name="sender">ListView amin megnyomtuk a bal egér gombot</param>
        /// <param name="e"></param>
        private void ListView_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ListView lvMenu = sender as ListView;
            ListViewItem lvMenuItem = lvMenu.SelectedItem as ListViewItem;
            //ListViewItem lvMenuItem = (ListViewItem) lvMenu.SelectedItem;

            if (lvMenuItem != null)
            {
                // x:Name tulajdonságot vizsgáljuk
                switch (lvMenuItem.Name)
                {
                    case "lviExit":
                        Close();
                        break;
                    case "lviDatabaseSourceSelection":
                        DatabaseSorurcePage databaseSorurcePage = new DatabaseSorurcePage(databaseSourceViewModel);
                        Navigate.Navigation(databaseSorurcePage);
                        break;

                    case "lviProgramVersion":
                        ProgramInfo programVersion = new ProgramInfo();
                        Navigate.Navigation(programVersion);
                        break;
                }

            }
        }
    }
}
