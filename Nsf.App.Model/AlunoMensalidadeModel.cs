using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class AlunoMensalidadeModel
    {
        public int TbAlunoMensalidade { get; set; }
        public int IdAluno { get; set; }
        public int IdAnoLetivo { get; set; }
        public string DsMesref { get; set; }
        public int NrOrdem { get; set; }
        public bool BtPago { get; set; }
        public bool BtIsento { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtUltimaAlteracao { get; set; }
        public int IdFuncionarioAlteracao { get; set; }
        public string NrFolhaCarne { get; set; }
        public string DsObservacao { get; set; }
        public decimal VlMensalidade { get; set; }
        public DateTime DtPagamento { get; set; }
        public string TpPagamento { get; set; }
        public int NrParcelaMyProperty { get; set; }
    }
}
