using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
   
        public class MatriculaResponse
        {
            //tb_Aluno
            public int IdAluno { get; set; }
            public string NmAluno { get; set; }
            public string DsRg { get; set; }

            // Tb_Curso
            public string NmCurso { get; set; }

            // Tb_Turma
            public string NmTurma { get; set; }
            public string TpPeriudo { get; set; }

            //Tb_Turma_Aluno
            public string CdRa { get; set; }
            public string DsStatus { get; set; }



            public Model.AlunoModel Aluno { get; set; }
            public Model.TurmaAluno TurmaAluno { get; set; }

            public List<Model.AlunoDocumentoModel> Documentos { get; set; }
            public List<Model.AlunoFichaMedicaModel> FichaMedica { get; set; }
            public List<Model.AlunoCarometroModel> Localizacao { get; set; }
            public List<Model.AlunoResponsavel> Responsavel { get; set; }

        }
    }

