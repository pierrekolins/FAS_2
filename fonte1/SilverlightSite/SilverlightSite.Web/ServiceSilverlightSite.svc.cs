using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Data.Linq;

namespace SilverlightSite.Web
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServiceSilverlightSite
    {
        [OperationContract]
         public List<tbAluno> RetornaDados()
        {
         List<tbAluno> dados = new List<tbAluno>();
         using (DataClasses1DataContext ctx = new DataClasses1DataContext())
         {
          var obj_dados = from d in ctx.tbAlunos select d;
          foreach (var item in obj_dados)
                {
                tbAluno aluno = new tbAluno();
                aluno.idAluno = item.idAluno;
                aluno.nome = item.nome;
                aluno.nota = item.nota.Value;
                dados.Add(aluno);
                }
            }
        return dados;
        }        

        public void DoWork()
        {
            // Add your operation implementation here
            return;
        }

        public class tbAluno
        {
            public int idAluno { get; set; }
            public String nome { get; set; }
            public float nota { get; set; }

        }
    }
        
}

       
    

