using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class AlunoLocalizacaoModel
    {
        public int IdAlunoLocalizacao{ get; set; }
        public int IdAluno { get; set; }
        public string DsResidenciaCep{ get; set; }
        public string DsResidenciaBairro { get; set; }
        public string DsResidenciaCidade { get; set; }
        public string DsResidenciaEstado { get; set; }
        public string DsResidenciaEndereco { get; set; }
        public string DsResidenciaComplelemento { get; set; }
        public string DsNascimentoCidade { get; set; }
        public string DsNascimentoEstado { get; set; }
        public string DsNascimentoPais { get; set; }
        public DateTime DtInclusao{ get; set; }
        public DateTime DtUltimaAlteracao{ get; set; }
        public int IdFuncionarioUltimaAlteracao { get; set; }
    }
}
