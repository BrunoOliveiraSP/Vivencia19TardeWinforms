using System;

namespace Nsf.App.Model.Matricula
{
    public class FichaMedicaModel
    {
        public int IdAlunoFichaMedica { get; set; }
        public int IdAluno { get; set; }
        public string DsAlergias { get; set; }
        public string DsCongenitas { get; set; }
        public string DsTratamento { get; set; }
        public string DsAcompanhamento { get; set; }
        public string DsMedicacao { get; set; }
        public string DsObservacao { get; set; }
        public DateTime DtInclusao{ get; set; }
        public DateTime DtUltimaAlteracao { get; set; }
        public int IdFuncionarioAlteracao { get; set; }
    }
}