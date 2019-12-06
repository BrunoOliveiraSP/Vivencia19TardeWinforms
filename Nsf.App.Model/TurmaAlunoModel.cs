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
        public int CdRa { get; set; }
        public int TpStatus { get; set; }
        public int BtAtivo { get; set; }
        public int BtPermissaoAtraso { get; set; }
        public int DsObservacao { get; set; }

    }
}
