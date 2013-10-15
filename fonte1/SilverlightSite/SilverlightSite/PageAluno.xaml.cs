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
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
            AlunoGrid.ItemsSource = DadosAlunos(); // Cria o Grid

        }

        public class Aluno
        {
            public string nome { get; set; }
            public int media { get; set; }
            public string curso { get; set; }
            public string turma { get; set; }
            public string pagamento { get; set; }
        }

            // Coleção de aluno
            public List<Aluno> DadosAlunos()
            {
                List<Aluno> aluno = new List<Aluno>();
                aluno.Add(new Aluno()
                {
                    nome = "Aluno_01",
                    media = 75,
                    curso = "Engenharia de Software",
                    turma = "T-27",
                    pagamento = "Pago"
                });
                aluno.Add(new Aluno()
                {
                    nome = "Aluno_02",
                    media = 80,
                    curso = "Engenharia de Software",
                    turma = "T-27",
                    pagamento = "Atrasado"
                });
                aluno.Add(new Aluno()
                {
                    nome = "Aluno_03",
                    media = 90,
                    curso = "Engenharia de Software",
                    turma = "T-27",
                    pagamento = "Atrasado"
                });
                aluno.Add(new Aluno()
                {
                    nome = "Aluno_04",
                    media = 85,
                    curso = "Engenharia de Software",
                    turma = "T-27",
                    pagamento = "Pago"
                });
                aluno.Add(new Aluno()
                {
                    nome = "Aluno_05",
                    media = 70,
                    curso = "Engenharia de Software",
                    turma = "T-27",
                    pagamento = "Pago"
                });
                return aluno;
            }
        
        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

    }
}
