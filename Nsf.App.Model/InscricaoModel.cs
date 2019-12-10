using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsf.App.Model
{
    public class InscricaoModel
    {
        public int idInscricao { get; set; }
        public int idAnoLetivo { get; set; }
        public string nmInscrito { get; set; }
        public DateTime dtNascimento { get; set; }
        public string dsRg { get; set; }
        public DateTime dtEmissao { get; set; }
        public string dsOrgao { get; set; }
        public string dsSexo { get; set; }
        public string dsCpf { get; set; }
        public string dsNascimentoCidade { get; set; }
        public string dsNascimentoEstado { get; set; }
        public string dsNascimentoPais { get; set; }
        public string dsResidenciaEndereco { get; set; }
        public int nrResidenciaEndereco { get; set; }
        public string dsResidenciaComplelemento { get; set; }
        public string dsResidenciaBairro { get; set; }
        public string dsResidenciaCidade { get; set; }
        public string dsResidenciaEstado { get; set; }
        public string dsResidenciaCep { get; set; }
        public string dsEmail { get; set; }
        public string dsTelefone { get; set; }
        public string dsTelefone2 { get; set; }
        public string nmContato { get; set; }
        public string dsResponsavelNome { get; set; }
        public string dsResponsavelEmail { get; set; }
        public string dsResponsavelTelefone { get; set; }
        public string dsResponsavelTelefone2 { get; set; }
        public string dsResponsavelParentesco { get; set; }
        public int idCurso { get; set; }
        public string dsCursoPeriodo { get; set; }
        public int idCurso2 { get; set; }
        public string dsCurso2Periodo { get; set; }
        public string dsEscolaridade { get; set; }
        public string nmEscola { get; set; }
        public string tpEscola { get; set; }
        public decimal vlRenda { get; set; }
        public string dsComoConheceu { get; set; }
        public int qtMoramCasa { get; set; }
        public int qtTrabalhamCasa { get; set; }
        public string dsCorPele { get; set; }
        public bool btPendenteRg { get; set; }
        public bool btPendenteCpf { get; set; }
        public bool btPendenteEscolaridade { get; set; }
        public bool btPendentePagamento { get; set; }
        public string dsObservacao { get; set; }
        public DateTime dtInclusao { get; set; }
        public DateTime dtUltimaAlteracao { get; set; }
        public int idFuncionarioAlteracao { get; set; }
        public decimal vlNota { get; set; }
        public int idSalaVestibular { get; set; }
        public string dsSituacao { get; set; }
        public bool btMatriculado { get; set; }
        public bool btPendenteComprovresid { get; set; }
        public string dsResponsavelCpf { get; set; }
        public string dsResponsavelRg { get; set; }
        public int cdInscricao { get; set; }
        public string dsEmailInscrito { get; set; }
        //public object idAnoLetivoNavigation { get; set; }
        //public object idCurso2Navigation { get; set; }
        //public object idCursoNavigation { get; set; }
        //public object idSalaVestibularNavigation { get; set; }
        //public List<object> tbInscritoAprovado { get; set; }
        //public List<object> tbTurmaInscricaoTransicao { get; set; }
    }

    public class InscricaoResponse
    {
        public int IdInscricao { get; set; }
        public int IdAnoLetivo { get; set; }
        public string NmInscrito { get; set; }
        public DateTime DtNascimento { get; set; }
        public string DsRg { get; set; }
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
        public string DsResponsavelTelefone2 { get; set; }
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
        public string DsEmailInscrito { get; set; }



        //Tabela de Sala Vestibular
        public string NmSala { get; set; }
        public string NmLocal { get; set; }
        public string DsPeriodo { get; set; }



        // Tabela de Curso
        public string NmCurso { get; set; }
    }
}

