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



            public Model.AlunoModel aluno { get; set; }
            public Model.TurmaAluno turmaAluno { get; set; }
            public Model.AlunoDocumentoModel alunodocumentomodel {get ; set ; }
            public Model.AlunoFichaMedicaModel alunofichamedicaModel {get ; set ; }
            public Model.AlunoLocalizacaoModel alunolocalizacaomodel{ get ; set ; }
            public Model.AlunoResponsavel alunoresponsavel1model{get ; set ; }
            public Model.AlunoResponsavel alunoresponsavel2model{get ; set ; }
            public Model.AlunoResponsavel alunoresponsavel3model{get ; set ; }


            public List<Model.AlunoDocumentoModel> documentos { get; set; }
            public List<Model.AlunoFichaMedicaModel> fichaMedica { get; set; }
            public List<Model.AlunoCarometroModel> localizacao { get; set; }
            public List<Model.AlunoResponsavel> responsavel { get; set; }

        }
    }

