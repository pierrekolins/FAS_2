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
using System.Globalization;
using System.Collections;
using System.Collections.ObjectModel;

namespace SilverlightSite
{
    public partial class Page5 : Page
    {
        ObservableCollection<Prof> MinhaColecao;
        public Page5()
        {
            InitializeComponent();
            LayoutProf.Children.Remove(GridAux);
            LayoutProf.Children.Remove(GridAux2);
            
            //Cria coleção
            MinhaColecao = new ObservableCollection<Prof>();

            //Create each object in the collection
            Prof Marco = new Prof("Marco", "marco.jpg");
            Prof Pasteur = new Prof("Pasteur", "pasteur.jpg");
           
            //Add the objects to the collection
            MinhaColecao.Add(Marco);
            MinhaColecao.Add(Pasteur);
           
            //LayoutRoot is the name of the root Grid
            LayoutProf.DataContext = MinhaColecao;

            
        }

    
        private void CB1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = CB1.SelectedIndex;
            Object selectedItem = CB1.SelectedItem;
            
            if (CB1.SelectedIndex == 0)
            {
                try
                {
                    LayoutProf.Children.Remove(GridAux2);
                }
                catch
                { 
                }
                LayoutProf.Children.Add(GridAux); // marco
            }
            else if (CB1.SelectedIndex == 1)
            {
                try
                {
                    LayoutProf.Children.Remove(GridAux);
                }
                catch
                {
                }
                LayoutProf.Children.Add(GridAux2); // pasteur
            }
        }
        
        
    }




    public class Prof
    {
        public Prof(string title, string imageUri)
        {
            this.Title = title;
            this.Foto = "/imagem/marco.jpg";
        }

        public string Foto { get; set; }
        public string Title { get; set; }
        
    }
    
}
