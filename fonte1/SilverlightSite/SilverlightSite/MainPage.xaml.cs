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

        PageReturn _pagereturn;

        public MainPage()
        {
            InitializeComponent();

            // click para remover o cover

            Cover.MouseLeftButtonDown += new MouseButtonEventHandler(Cover_MouseLeftButtonDown);           
          
        }
   
        void Cover_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _pagereturn = new PageReturn();
            LayoutRoot.Children.Remove(Cover);
            LayoutRoot.Children.Remove(imagemInicial);
            LayoutRoot.Children.Remove(lbAcesse);
            LayoutRoot.Children.Add(_pagereturn);
        }
               

    }
}
