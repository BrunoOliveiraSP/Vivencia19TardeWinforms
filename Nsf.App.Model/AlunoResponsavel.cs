using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class AlunoResponsavel
    {
        public int IdAlunoResponsavel { get; set; }
        public int IdAluno { get; set; }
        public string NmResponsavel { get; set; }
        public string DsEmail { get; set; }
        public string DsTelefone1 { get; set; }
        public string DsTelefone2 { get; set; }
        public string DsParentesco { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtUltimaAlteracao { get; set; }
        public int IdFuncionarioAlteracao { get; set; }

    }
}
