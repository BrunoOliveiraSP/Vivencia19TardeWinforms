using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class TurmaAluno
    {
        public int IdTurmaAluno { get; set; }
        public int IdTurma { get; set; }
        public int IdAluno { get; set; }
        public int NrChamada { get; set; }
        public String CdRa { get; set; }
        public string TpStatus { get; set; }
        public bool BtAtivo { get; set; }
        public bool BtPermicaoAtraso { get; set; }
        public string DsObservacao { get; set; }
    }
}
