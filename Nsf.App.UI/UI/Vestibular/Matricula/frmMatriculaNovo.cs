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
using Nsf.App.API.Client;
using System.IO;
using Nsf.App.Utils.APIs;

namespace Nsf.App.UI
{
	public partial class frmMatriculaNovo : NsfUserScreen
	{
		public frmMatriculaNovo()
		{
			InitializeComponent();
            API.Client.AnoLetivoApi ano = new AnoLetivoApi();
            CursoAPI curso = new CursoAPI();
            List<Model.CursoModel> cursos = curso.ConsultarTodos();
            List<Model.AnoLetivoModel> anos = ano.ListarTodos();

            cboAnoLetivo.DisplayMember = nameof(Model.AnoLetivoModel.NrAno);
            cboAnoLetivo.DataSource = anos;

            cboCurso.DisplayMember = nameof(Model.CursoModel.NmCurso);
            cboCurso.DataSource = cursos;
        }
        Model.MatriculaRequest matricula;
        MatriculaAPI Api = new MatriculaAPI();


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (matricula == null || matricula.Aluno.IdAluno == 0)
                {
                    matricula = CarregarModelo();
                    Api.Inserir(matricula);
                }
                else if (matricula.Aluno.IdAluno > 0)
                {
                    matricula = CarregarModelo();
                    Api.Alterar(matricula);
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregarTela(Model.MatriculaRequest matricula)
        {
            //Aluno responsavel 1
            txtResponsavel1.Text = matricula.Responsavel1.NmResponsavel;
            cboGrauParentesco1.Text = matricula.Responsavel1.DsTelefone1;
            txtResponsavel1Email.Text= matricula.Responsavel1.DsParentesco;
            txtResponsavel1Telefone1.Text= matricula.Responsavel1.DsTelefone1;
            txtResponsavel1Telefone2.Text= matricula.Responsavel1.DsTelefone2;

            // Aluno responsavel 2 
            txtResponsavel2Email.Text = matricula.Responsavel1.DsEmail;
            txtResponsavel2.Text = matricula.Responsavel1.NmResponsavel;
            cboGrauParentesco2.Text = matricula.Responsavel1.DsParentesco;
            txtResponsavel2Telefone1.Text = matricula.Responsavel1.DsTelefone1;
            txtResponsavel2Telefone2.Text = matricula.Responsavel1.DsTelefone2;

            //Aluno Responsavel 3

            txtResponsavel3Email.Text = matricula.Responsavel3.DsEmail;
            txtResponsavel3.Text = matricula.Responsavel3.NmResponsavel;
            cboGrauParentesco3.Text = matricula.Responsavel3.DsParentesco;
            txtResponsavel3Telefone1.Text = matricula.Responsavel3.DsTelefone1;
            txtResponsavel3Telefone2.Text = matricula.Responsavel3.DsTelefone2;

            //Aluno

            txtRG.Text = matricula.Aluno.DsRg;
            txtCpf.Text = matricula.Aluno.DsCpf;
            cboSexo.Text = matricula.Aluno.DsSexo;
            txtNome.Text = matricula.Aluno.NmAluno;
            txtEtnia.Text = matricula.Aluno.DsEtinia;
            nudRenda.Value = matricula.Aluno.VlRenda;
            txtRgOrgao.Text = matricula.Aluno.DsOrgao;
            txtCelular.Text = matricula.Aluno.DsCelular;
            txtAlunoEmail.Text = matricula.Aluno.DsEmail;
            dtpRgEmissao.Value = matricula.Aluno.DtEmissao;
            cboTipoDeEscola.Text = matricula.Aluno.TpEscola;
            txtNomeDaEscola.Text = matricula.Aluno.NmEscola;
            txtObservacoes.Text = matricula.Aluno.DsObservacao;
            cboComoConheceu.Text = matricula.Aluno.DsComoConheceu;
            cboEscolaridade.Text = matricula.Aluno.DsEscolaridade;
            dtpNascimentoData.Value = matricula.Aluno.DtNascimento;
            nudPessoasMoramCasa.Value = matricula.Aluno.QtMoramCasa;
            nudPessoasTrabalhamCasa.Value = matricula.Aluno.QtTrabalhamCasa;

            //Localização

            txtCep.Text = matricula.Localizacao.DsResidenciaCep;
            txtBairro.Text = matricula.Localizacao.DsResidenciaBairro;
            txtCidade.Text = matricula.Localizacao.DsResidenciaCidade;
            txtEndereco.Text = matricula.Localizacao.DsResidenciaEndereco;
            txtNascimentoPais.Text = matricula.Localizacao.DsNascimentoPais;
            txtNascimentoCidade.Text = matricula.Localizacao.DsNascimentoCidade;
            txtComplemento.Text = matricula.Localizacao.DsResidenciaComplelemento;

            //Aluno Ficha Medica

            txtAlergias.Text = matricula.FichaMedica.DsAlergias;
            txtMedicacao.Text = matricula.FichaMedica.DsMedicacao;
            txtCongenitas.Text = matricula.FichaMedica.DsCongenitas;
            txtTratamento.Text = matricula.FichaMedica.DsTratamento;
            txtObservacoesMedicas.Text = matricula.FichaMedica.DsObservacao;
            txtAcompanhamento.Text = matricula.FichaMedica.DsAcompanhamento;


        }

        public Model.MatriculaRequest CarregarModelo()
        {
            //AlunoModel

            Nsf.App.Model.AlunoModel aluno = new Model.AlunoModel();

            aluno.DsRg = txtRG.Text;
            aluno.DsCpf = txtCpf.Text;
            aluno.DsSexo = cboSexo.Text;
            aluno.NmAluno = txtNome.Text;
            aluno.DsEtinia = txtEtnia.Text;
            aluno.DsOrgao = txtRgOrgao.Text;
            aluno.DtInclusao = DateTime.Now;
            aluno.DsCelular = txtCelular.Text;
            aluno.DsEmail = txtAlunoEmail.Text;
            aluno.DtEmissao = dtpRgEmissao.Value;
            aluno.TpEscola = cboTipoDeEscola.Text;
            aluno.NmEscola = txtNomeDaEscola.Text;
            aluno.DtUltimaAlteracao = DateTime.Now;
            aluno.DsObservacao = txtObservacoes.Text;
            aluno.DsComoConheceu = cboComoConheceu.Text;
            aluno.DsEscolaridade = cboEscolaridade.Text;
            aluno.DtNascimento = dtpNascimentoData.Value;
            aluno.VlRenda = Convert.ToDecimal(nudRenda.Value);
            aluno.QtMoramCasa = Convert.ToInt32(nudPessoasMoramCasa.Value);
            aluno.QtTrabalhamCasa = Convert.ToInt32(nudPessoasTrabalhamCasa.Value);

            //Aluno Responsavel Model

            Nsf.App.Model.AlunoResponsavel responsavel1 = new Model.AlunoResponsavel();

            responsavel1.DtInclusao = DateTime.Now;
            responsavel1.DtUltimaAlteracao = DateTime.Now;
            responsavel1.DsEmail = txtResponsavel1Email.Text;
            responsavel1.NmResponsavel = txtResponsavel1.Text;
            responsavel1.DsParentesco = cboGrauParentesco1.Text;
            responsavel1.DsTelefone1 = txtResponsavel1Telefone1.Text;
            responsavel1.DsTelefone2 = txtResponsavel1Telefone2.Text;

            // Aluno responsavel 2 

            Nsf.App.Model.AlunoResponsavel responsavel2 = new Model.AlunoResponsavel();

            responsavel2.DtInclusao = DateTime.Now;
            responsavel2.DtUltimaAlteracao = DateTime.Now;
            responsavel2.DsEmail = txtResponsavel2Email.Text;
            responsavel2.NmResponsavel = txtResponsavel2.Text;
            responsavel2.DsParentesco = cboGrauParentesco2.Text;
            responsavel2.DsTelefone1 = txtResponsavel2Telefone1.Text;
            responsavel2.DsTelefone2 = txtResponsavel2Telefone2.Text;

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
            alunoLocalizacao.DsResidenciaCep = txtCep.Text;
            alunoLocalizacao.DsResidenciaCidade = txtCidade.Text;
            alunoLocalizacao.DsResidenciaBairro = txtBairro.Text;
            alunoLocalizacao.DsResidenciaEndereco = txtEndereco.Text;
            alunoLocalizacao.DsNascimentoPais = txtNascimentoPais.Text;
            alunoLocalizacao.DsNascimentoCidade = txtNascimentoCidade.Text;
            alunoLocalizacao.DsResidenciaComplelemento = txtComplemento.Text;

            // aluno Ficha Medica

            Nsf.App.Model.AlunoFichaMedicaModel alunoFicha = new Model.AlunoFichaMedicaModel();

            alunoFicha.DtInclusao = DateTime.Now;
            alunoFicha.DsAlergias = txtAlergias.Text;
            alunoFicha.DsMedicacao = txtMedicacao.Text;
            alunoFicha.DtUltimaAlteracao = DateTime.Now;
            alunoFicha.DsTratamento = txtTratamento.Text;
            alunoFicha.DsCongenitas = txtCongenitas.Text;
            alunoFicha.DsAcompanhamento = txtAcompanhamento.Text;
            alunoFicha.DsObservacao = txtObservacoesMedicas.Text;

            //AlunoCarometro

            Nsf.App.Model.AlunoCarometroModel alunoCarometro = new Model.AlunoCarometroModel();

            // alunoCarometro.DsImagem = imgAluno.Image; ???


            //Matricula 

            Nsf.App.Model.MatriculaRequest matricula = new Model.MatriculaRequest();

            matricula.Aluno = aluno;
            matricula.FichaMedica = alunoFicha;
            matricula.Carometro = alunoCarometro;
            matricula.Responsavel1 = responsavel1;
            matricula.Responsavel2 = responsavel2;
            matricula.Responsavel3 = responsavel3;
            matricula.Localizacao = alunoLocalizacao;

            return matricula;
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            string cep = txtCep.Text;

            CorreioResponse response;

            Nsf.App.Utils.APIs.CorreioApi api = new Utils.APIs.CorreioApi();
            if (api.BuscarAPICorreio(cep, out response))
            {
                txtBairro.Text = response.bairro;
                cboUf.Text = response.uf;
                txtEndereco.Text = response.logradouro;
                txtCidade.Text = response.localidade;
            }
        }
    }
}