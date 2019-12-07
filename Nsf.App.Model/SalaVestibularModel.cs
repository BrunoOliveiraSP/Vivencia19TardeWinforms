using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class SalaVestibularModel
    {
        public int IdSalaVestibular { get; set; }
        public int IdSala { get; set; }
        public string DsPeriodo { get; set; }
        public int NrOrdem { get; set; }
        public int QtInscritos { get; set; }

        public string NmSala { get; set; }
        public string NmLocal { get; set; }
    }
}
