using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class MatriculaRequest
    {
        public AlunoModel Aluno { get; set; }
        public AlunoCarometroModel Carometro { get; set; }
        public AlunoMensalidadeModel Mensalidade { get; set; }
        public AlunoDocumentoModel Documentos { get; set; }
        public AlunoFichaMedicaModel FichaMedica { get; set; }
        public AlunoLocalizacaoModel Localizacao { get; set; }
        public AlunoResponsavel Responsavel1 { get; set; }
        public AlunoResponsavel Responsavel2 { get; set; }
        public AlunoResponsavel Responsavel3 { get; set; }


    }
}
