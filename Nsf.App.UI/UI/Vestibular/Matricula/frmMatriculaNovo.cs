using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nsf.App.Utils;
using Nsf.App.Utils.APIs;
using System.IO;

namespace Nsf.App.UI
{
	public partial class frmMatriculaNovo : NsfUserScreen
	{
		public frmMatriculaNovo()
		{
			InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
         

        }

        
        private void ALterar()
        {

        }

        private void Inserir()
        {

        }

        private Model.MatriculaRequest CarregarModelo()
        {
            //AlunoModel

            Nsf.App.Model.AlunoModel aluno = new Model.AlunoModel();
            aluno.NmAluno = txtNome.Text;
            aluno.DsCelular = txtCelular.Text;
            aluno.DsComoConheceu = cboComoConheceu.Text;
            aluno.DsCpf = txtCpf.Text;
            aluno.DsEmail = txtAlunoEmail.Text;
            aluno.DsEscolaridade = cboEscolaridade.Text;
            aluno.DsEtinia = txtEtnia.Text;
            aluno.DsObservacao = txtObservacoes.Text;
            aluno.DsOrgao = txtRgOrgao.Text;
            aluno.DsRg = txtRG.Text;
            aluno.DsSexo = cboSexo.Text;
            aluno.DtEmissao = dtpRgEmissao.Value;
            aluno.DtInclusao = DateTime.Now;
            aluno.DtNascimento = dtpNascimentoData.Value;
            aluno.DtUltimaAlteracao = DateTime.Now;
            aluno.NmEscola = txtNomeDaEscola.Text;
            aluno.QtMoramCasa = Convert.ToInt32(nudPessoasMoramCasa.Value);
            aluno.QtTrabalhamCasa = Convert.ToInt32(nudPessoasTrabalhamCasa.Value);
            aluno.TpEscola = cboTipoDeEscola.Text;
            aluno.VlRenda = Convert.ToDecimal(nudRenda.Value);

            //Aluno Responsavel Model

            Nsf.App.Model.AlunoResponsavel responsavel1 = new Model.AlunoResponsavel();

            responsavel1.DsEmail = txtResponsavel1Email.Text;
            responsavel1.DsParentesco = cboGrauParentesco1.Text;
            responsavel1.DsTelefone1 = txtResponsavel1Telefone1.Text;
            responsavel1.DsTelefone2 = txtResponsavel1Telefone2.Text;
            responsavel1.DtInclusao = DateTime.Now;
            responsavel1.DtUltimaAlteracao = DateTime.Now;
            responsavel1.NmResponsavel = txtResponsavel1.Text;

            // Aluno responsavel 2 

            Nsf.App.Model.AlunoResponsavel responsavel2 = new Model.AlunoResponsavel();

            responsavel2.DsEmail = txtResponsavel2Email.Text;
            responsavel2.DsParentesco = cboGrauParentesco2.Text;
            responsavel2.DsTelefone1 = txtResponsavel2Telefone1.Text;
            responsavel2.DsTelefone2 = txtResponsavel2Telefone2.Text;
            responsavel2.DtInclusao = DateTime.Now;
            responsavel2.DtUltimaAlteracao = DateTime.Now;
            responsavel2.NmResponsavel = txtResponsavel2.Text;

            // Aluno responsavel 3

            Nsf.App.Model.AlunoResponsavel responsavel3 = new Model.AlunoResponsavel();

            responsavel3.DsEmail = txtResponsavel3Email.Text;
            responsavel3.DsParentesco = cboGrauParentesco3.Text;
            responsavel3.DsTelefone1 = txtResponsavel3Telefone1.Text;
            responsavel3.DsTelefone2 = txtResponsavel3Telefone2.Text;
            responsavel3.DtInclusao = DateTime.Now;
            responsavel3.DtUltimaAlteracao = DateTime.Now;
            responsavel3.NmResponsavel = txtResponsavel3.Text;

            // Aluno Localizacao 

            Nsf.App.Model.AlunoLocalizacaoModel alunoLocalizacao = new Model.AlunoLocalizacaoModel();
            alunoLocalizacao.DsNascimentoCidade = txtNascimentoCidade.Text;
            alunoLocalizacao.DsNascimentoPais = txtNascimentoPais.Text;
            alunoLocalizacao.DsResidenciaBairro = txtBairro.Text;
            alunoLocalizacao.DsResidenciaCep = txtCep.Text;
            alunoLocalizacao.DsResidenciaCidade = txtCidade.Text;
            alunoLocalizacao.DsResidenciaComplelemento = txtComplemento.Text;
            alunoLocalizacao.DsResidenciaEndereco = txtEndereco.Text;
            alunoLocalizacao.DtInclusao = DateTime.Now;
            alunoLocalizacao.DtUltimaAlteracao = DateTime.Now;

            // aluno Ficha Medica

            Nsf.App.Model.AlunoFichaMedicaModel alunoFicha = new Model.AlunoFichaMedicaModel();

            alunoFicha.DsAcompanhamento = txtAcompanhamento.Text;
            alunoFicha.DsAlergias = txtAlergias.Text;
            alunoFicha.DsCongenitas = txtCongenitas.Text;
            alunoFicha.DsMedicacao = txtMedicacao.Text;
            alunoFicha.DsObservacao = txtObservacoesMedicas.Text;
            alunoFicha.DsTratamento = txtTratamento.Text;
            alunoFicha.DtInclusao = DateTime.Now;
            alunoFicha.DtUltimaAlteracao = DateTime.Now;

            //AlunoCarometro

            Nsf.App.Model.AlunoCarometroModel alunoCarometro = new Model.AlunoCarometroModel();

            // alunoCarometro.DsImagem = imgAluno.Image; ???


            //Matricula 

            Nsf.App.Model.MatriculaRequest matricula = new Model.MatriculaRequest();

            matricula.Aluno = aluno;
            matricula.FichaMedica = alunoFicha;
            matricula.Localizacao = alunoLocalizacao;
            matricula.Responsavel1 = responsavel1;
            matricula.Responsavel2 = responsavel2;
            matricula.Responsavel3 = responsavel3;
            matricula.Carometro = alunoCarometro;

            return matricula;
        }

    }
}