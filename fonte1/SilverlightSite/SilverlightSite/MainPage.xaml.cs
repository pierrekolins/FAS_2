using System;
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

namespace SilverlightSite
{
    public partial class MainPage : UserControl
    {

        Page6 _carrossel;
        public MainPage()
        {
            InitializeComponent();

            // add the controls to the back
            _carrossel = new Page6();
            LayoutRoot.Children.Insert(0, _carrossel);

            // click para remover o cover
            Cover.MouseLeftButtonDown += new MouseButtonEventHandler(Cover_MouseLeftButtonDown);
          
        }

        void Cover_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LayoutRoot.Children.Remove(Cover);
            _carrossel.Start();
        }

        private void btnPrincipal_Click(object sender, RoutedEventArgs e)
        {
            MainPage mp = new MainPage();
            LayoutRoot.Children.Clear();
            LayoutRoot.Children.Add(mp);
        }

    }
}
