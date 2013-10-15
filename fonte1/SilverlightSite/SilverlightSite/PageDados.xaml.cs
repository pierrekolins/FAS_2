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

namespace SilverlightSite
{
    public partial class PageDados : Page
    {
        public PageDados()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

    }
   // Classe para armazenar informação de frequencia
 public class DadosFrequencia
 {
     public string mes { get; set; }
     public int total { get; set; }
 }
 // Coleção de frequencia
 public class Frequencia : IEnumerable<DadosFrequencia>
 {
     public IEnumerator<DadosFrequencia> GetEnumerator()
     {
         yield return new DadosFrequencia { mes = "Janeiro", total = 0 };
         yield return new DadosFrequencia { mes = "Fevereiro", total = 85 };
         yield return new DadosFrequencia { mes = "Março", total = 95 };
         yield return new DadosFrequencia { mes = "Abril", total = 73 };
         yield return new DadosFrequencia { mes = "Maio", total = 98 };
         yield return new DadosFrequencia { mes = "Junho", total = 80 };
         yield return new DadosFrequencia { mes = "Julho", total = 70 };
         yield return new DadosFrequencia { mes = "Agosto", total = 95 };
         yield return new DadosFrequencia { mes = "Setembro", total = 70 };
         yield return new DadosFrequencia { mes = "Outubro", total = 100 };
         yield return new DadosFrequencia { mes = "Novembro", total = 85 };
         yield return new DadosFrequencia { mes = "Dezembro", total = 70 };
     }
     IEnumerator IEnumerable.GetEnumerator()
     {
         return ((IEnumerable<DadosFrequencia>)this).GetEnumerator();
     }
 }
    
}
