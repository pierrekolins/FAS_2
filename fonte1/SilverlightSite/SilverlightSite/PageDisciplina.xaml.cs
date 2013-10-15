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
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
            DisciplinaGrid.ItemsSource = DadosDisciplina();
        }

        public class Disciplina
        {
            public string nome { get; set; }
            public int hora_classe { get; set; }
            public int credito { get; set; }
            public string modulo { get; set; }
            public string curso { get; set; }
        }

        // Coleção de aluno
        public List<Disciplina> DadosDisciplina()
        {
            List<Disciplina> disciplina = new List<Disciplina>();
            disciplina.Add(new Disciplina()
            {
                nome = "Bancos de Dados",
                hora_classe = 15,
                credito = 1,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Concepção e Elaboração de Software I",
                hora_classe = 30,
                credito = 2,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Concepção e Elaboração de Software II",
                hora_classe = 30,
                credito = 2,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Construção e Implantação de Software I",
                hora_classe = 15,
                credito = 1,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Construção e Implantação de Software II",
                hora_classe = 15,
                credito = 1,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Fundamentos de Arquitetura de Software I",
                hora_classe = 30,
                credito = 2,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Fundamentos de Arquitetura de Software II",
                hora_classe = 30,
                credito = 2,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Gerência de Configuração de Software",
                hora_classe = 15,
                credito = 1,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Gerência de Projetos",
                hora_classe = 15,
                credito = 1,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Interação Homem-Computador",
                hora_classe = 15,
                credito = 1,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Laboratório de Engenharia de Software I",
                hora_classe = 15,
                credito = 1,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Laboratório de Engenharia de Software II",
                hora_classe = 15,
                credito = 1,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Laboratório de Engenharia de Software III",
                hora_classe = 30,
                credito = 2,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Metodologia do Trabalho Científico",
                hora_classe = 15,
                credito = 1,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Processo de Desenvolvimento de Software",
                hora_classe = 15,
                credito = 1,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Programação Orientada a Objetos",
                hora_classe = 30,
                credito = 2,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Qualidade de Software",
                hora_classe = 15,
                credito = 1,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            disciplina.Add(new Disciplina()
            {
                nome = "Tecnologias Aplicadas a Inteligência de Negócio",
                hora_classe = 15,
                credito = 1,
                modulo = "Módulo 1 - 2013",
                curso = "Engenharia de Software"
            });
            return disciplina;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

    }
}
