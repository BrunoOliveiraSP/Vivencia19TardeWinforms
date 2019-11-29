using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.UI.Models
{
    class InscricaoModel
    {
        public int IdInscricao { get; set; }
        public int IdAnoLetivo { get; set; }
        public string NmInscrito { get; set; }
        public DateTime DtNascimento { get; set; }
        public string MyProDsRgperty { get; set; }
        public DateTime DtEmissao { get; set; }
        public string DsOrgao { get; set; }
        public string DsSexo { get; set; }
        public string DsCpf { get; set; }
        public string DsNascimentoCidade { get; set; }
        public string DsNascimentoEstado { get; set; }
        public string DsNascimentoPais { get; set; }
        public string DsResidenciaEndereco { get; set; }
        public int NrResidenciaEndereco { get; set; }
        public string DsResidenciaComplelemento { get; set; }
        public string DsResidenciaBairro { get; set; }
        public string DsResidenciaCidade { get; set; }
        public string DsResidenciaEstado { get; set; }
        public string DsResidenciaCep { get; set; }
        public string DsEmail { get; set; }
        public string DsTelefone { get; set; }
        public string DsTelefone2 { get; set; }
        public string NmContato { get; set; }
        public string DsResponsavelNome { get; set; }
        public string DsResponsavelEmail { get; set; }
        public string DsResponsavelTelefone { get; set; }
        public string DsResponsavelParentesco { get; set; }
        public int IdCurso { get; set; }
        public string DsCursoPeriodo { get; set; }
        public int IdCurso2 { get; set; }
        public string DsCurso2Periodo { get; set; }
        public string DsEscolaridade { get; set; }
        public string NmEscola { get; set; }
        public string TpEscola { get; set; }
        public decimal VlRenda { get; set; }
        public string DsComoConheceu { get; set; }
        public int QtMoramCasa { get; set; }
        public int QtTrabalhamCasa { get; set; }
        public string DsCorPele { get; set; }
        public bool BtPendenteRg { get; set; }
        public bool BtPendenteCpf { get; set; }
        public bool BtPendenteEscolaridade { get; set; }
        public bool BtPendentePagamento { get; set; }
        public string DsObservacao { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime DtUltimaAlteracao { get; set; }
        public int IdFuncionarioAlteracao { get; set; }
        public decimal VlNota { get; set; }
        public int IdSalaVestibular { get; set; }
        public string DsSituacao { get; set; }
        public bool BtMatriculado { get; set; }
        public bool BtPendenteComprovresid { get; set; }
        public string DsResponsavelCpf { get; set; }
        public string DsResponsavelRg { get; set; }
        public int CdInscricao { get; set; }
        public string ds_email_inscrito { get; set; }


        //Falta colocar as tabelas aqui também
    }
}
