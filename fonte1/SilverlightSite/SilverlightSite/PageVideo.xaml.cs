﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace SilverlightSite
{
    public partial class Page1 : Page
    {
        Boolean teste = true; // está em "play"

        public Page1()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void btnPlayPause_Click(object sender, RoutedEventArgs e)
        {
            if (teste)
            {
                media.Pause();
                teste = false;
            }
            else
            {
                media.Play();
                teste = true;
            }


        }

        private void btnReload_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
            media.Play();
            teste = true;
        }      

    }
}
