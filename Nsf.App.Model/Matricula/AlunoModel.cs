using System;

namespace Nsf.App.Model.Matricula
{
	public class AlunoModel
	{
        public int IdAluno { get; set; }
        public string NmAluno { get; set; }
        public DateTime DtNascimento { get; set; }
        public string DsRg { get; set; }
        public DateTime DtEmissao { get; set; }
        public string DsOrgao { get; set; }
        public string DsSexo { get; set; }
        public string DsCpf { get; set; }
        public string DsEtinia { get; set; }
        public string DsEmail { get; set; }
        public string DsCelular { get; set; }
        public string DsEscolaridade { get; set; }
        public string NmEscola { get; set; }
        public string tTpEscola { get; set; }
        public string DsComoConheceu { get; set; }
        public int QtMoramCasa { get; set; }
        public int QtTrabalhamCasa { get; set; }
        public decimal VlRenda { get; set; }
        public string DsObservacao { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtUltimaAlteracao { get; set; }
        public int IdFuncionarioAlteracao { get; set; }
    }
}
