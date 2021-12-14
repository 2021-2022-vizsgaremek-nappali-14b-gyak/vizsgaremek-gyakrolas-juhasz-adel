﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VizsgaremekProjekt.Navigation
{
    public static class Navigate
    {
        //  eltároljuk a MainWindow, hogy tudjunk váltani ablakot (pages)
        public static MainWindow mainWindow;

        public static void Navigation(UserControl userControl)
        {
            mainWindow.PageContent.Children.Add(userControl);
        }
    }
}
