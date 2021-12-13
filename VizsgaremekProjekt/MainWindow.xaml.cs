using System;
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

namespace VizsgaremekProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Statikus osztály a Navigate
            // Eltárolja a nyitó ablakot, hogy azon tudjuk módosítani a "page"-ket.
            Navigate.mainWindow = this;
            // Létrehozzuk a nyitó "UserControl (WelcomePage)
            WelcomePage welcomePage = new WelcomePage();
            // Megjelenítjük a WelcomePage-t
            Navigate.Navigation(welcomePage);
        }
    }
}
