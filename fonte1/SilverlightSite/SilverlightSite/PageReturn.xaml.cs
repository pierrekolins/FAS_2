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
using System.Windows.Navigation;

namespace SilverlightSite
{
    public partial class PageReturn : Page
    {
        Page6 _carrossel;

        public PageReturn()
        {
            InitializeComponent();
            
            _carrossel = new Page6();            
            LayoutRoot.Children.Insert(0, _carrossel); // insere o carrossel
            _carrossel.Start();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        private void btnPrincipal_Click(object sender, RoutedEventArgs e)
        {            
            // limpa children 
            PageReturn pr = new PageReturn();
            LayoutRoot.Children.Clear();
            LayoutRoot.Children.Add(pr);            
        }
    }
}
