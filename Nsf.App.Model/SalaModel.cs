using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
   public class SalaModel
   {
        public int IdSala { get; set; }

        public string NmLocal { get; set; }

        public string NmSala { get; set; }

        public int NrCapacidadeMaxima { get; set; }

        public ulong BtAtivo { get; set; }

        public DateTime DtInclusao { get; set; }

        public DateTime DtAlteracao { get; set; }

        public int IdFuncionarioAlteracao { get; set; }
    }
}
