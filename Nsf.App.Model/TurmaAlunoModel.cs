using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class SalaVestibularModel
    {
        public int IdTurmaAluno { get; set; }
        public int IdTurma { get; set; }
        public string IdAluno { get; set; }
        public int NmTurma { get; set; }
        public int NrChamada { get; set; }
        public string CdRa { get; set; }
        public string TpStatus { get; set; }
        public bool BtAtivo { get; set; }
        public bool BtPermissaoAtraso { get; set; }
        public string DsObservacao { get; set; }
    }
}
