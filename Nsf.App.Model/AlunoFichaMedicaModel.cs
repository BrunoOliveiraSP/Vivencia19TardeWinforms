using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class AlunoFichaMedicaModel
    {
        public  int IdAlunoFIchaMedica { get; set; }
        public int IdAluno { get; set; }
        public string DsAlergias { get; set; }
        public string DsCongenitas { get; set; }
        public string DsTratamento { get; set; }
        public string DsAcompanhamento { get; set; }
        public string DsMedicacao { get; set; }
        public string DsObservacao { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtUltimaAlteracao { get; set; }
    }
}
