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

    public static class CarregarInscrições
    {
        public static int idInscricao { get; set; }
        public static int idAnoLetivo { get; set; }
        public static string nmInscrito { get; set; }
        public static DateTime dtNascimento { get; set; }
        public static string dsRg { get; set; }
        public static DateTime dtEmissao { get; set; }
        public static string dsOrgao { get; set; }
        public static string dsSexo { get; set; }
        public static string dsCpf { get; set; }
        public static string dsNascimentoCidade { get; set; }
        public static string dsNascimentoEstado { get; set; }
        public static string dsNascimentoPais { get; set; }
        public static string dsResidenciaEndereco { get; set; }
        public static int nrResidenciaEndereco { get; set; }
        public static string dsResidenciaComplelemento { get; set; }
        public static string dsResidenciaBairro { get; set; }
        public static string dsResidenciaCidade { get; set; }
        public static string dsResidenciaEstado { get; set; }
        public static string dsResidenciaCep { get; set; }
        public static string dsEmail { get; set; }
        public static string dsTelefone { get; set; }
        public static string dsTelefone2 { get; set; }
        public static string nmContato { get; set; }
        public static string dsResponsavelNome { get; set; }
        public static string dsResponsavelEmail { get; set; }
        public static string dsResponsavelTelefone { get; set; }
        public static string dsResponsavelTelefone2 { get; set; }
        public static string dsResponsavelParentesco { get; set; }
        public static int idCurso { get; set; }
        public static string dsCursoPeriodo { get; set; }
        public static int idCurso2 { get; set; }
        public static string dsCurso2Periodo { get; set; }
        public static string dsEscolaridade { get; set; }
        public static string nmEscola { get; set; }
        public static string tpEscola { get; set; }
        public static decimal vlRenda { get; set; }
        public static string dsComoConheceu { get; set; }
        public static int qtMoramCasa { get; set; }
        public static int qtTrabalhamCasa { get; set; }
        public static string dsCorPele { get; set; }
        public static bool btPendenteRg { get; set; }
        public static bool btPendenteCpf { get; set; }
        public static bool btPendenteEscolaridade { get; set; }
        public static bool btPendentePagamento { get; set; }
        public static string dsObservacao { get; set; }
        public static DateTime dtInclusao { get; set; }
        public static DateTime dtUltimaAlteracao { get; set; }
        public static int idFuncionarioAlteracao { get; set; }
        public static decimal vlNota { get; set; }
        public static int idSalaVestibular { get; set; }
        public static string dsSituacao { get; set; }
        public static bool btMatriculado { get; set; }
        public static bool btPendenteComprovresid { get; set; }
        public static string dsResponsavelCpf { get; set; }
        public static string dsResponsavelRg { get; set; }
        public static int cdInscricao { get; set; }
        public static string dsEmailInscrito { get; set; }
    }
   
}

