using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    
        public class DisciplinaModel
        {
            public int IdDisciplina { get; set; }
            public string NmDisciplina { get; set; }
            public string DsSigla { get; set; }
            public DateTime DtUltimaAlteracao { get; set; }
            public DateTime DtInclusao { get; set; }
            public bool BtAtivo { get; set; }
            public int IdFuncionarioAlteracao { get; set; }
    }
    
}
