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
            AnoLetivoApi ano = new AnoLetivoApi();
            CursoAPI curso = new CursoAPI();
            List<Model.CursoModel> cursos = curso.ConsultarTodos();
            List<Model.AnoLetivoModel> anos = ano.ListarTodos();

            cboAnoLetivo.DisplayMember = nameof(Model.AnoLetivoModel.NrAno);
            cboAnoLetivo.DataSource = anos;

            cboCurso.DisplayMember = nameof(Model.CursoModel.NmCurso);
            cboCurso.DataSource = cursos;
        }
        Model.MatriculaRequest matriculaapi;
        MatriculaAPI Api = new MatriculaAPI();


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (matriculaapi != null)
                {
                    matriculaapi = CarregarModelo();
                    Api.Alterar(matriculaapi);
                    MessageBox.Show("Alterado com sucesso");

                }
                else
                {
                    matriculaapi = new Model.MatriculaRequest();
                    matriculaapi = CarregarModelo();
                    Api.Inserir(matriculaapi);
                    MessageBox.Show("Cadastro efetuado com sucesso");
                 
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

        public void CarregarTela(Model.MatriculaResponse matricula)
        {
            matriculaapi = new Model.MatriculaRequest();

            //matricula.alunoresponsavel1model = matricula.responsavel[1];
            //matricula.alunoresponsavel2model = matricula.responsavel[1];
            //matricula.alunoresponsavel3model = matricula.responsavel[1];

            //Aluno responsavel 1
            //txtResponsavel1.Text = matricula.alunoresponsavel1model.NmResponsavel;
            //cboGrauParentesco1.Text = matricula.alunoresponsavel1model.DsTelefone1;
            //txtResponsavel1Email.Text= matricula.alunoresponsavel1model.DsParentesco;
            //txtResponsavel1Telefone1.Text= matricula.alunoresponsavel1model.DsTelefone1;
            //txtResponsavel1Telefone2.Text= matricula.alunoresponsavel1model.DsTelefone2;

            //// Aluno responsavel 2 
            //txtResponsavel2Email.Text = matricula.alunoresponsavel2model.DsEmail;
            //txtResponsavel2.Text = matricula.alunoresponsavel2model.NmResponsavel;
            //cboGrauParentesco2.Text = matricula.alunoresponsavel2model.DsParentesco;
            //txtResponsavel2Telefone1.Text = matricula.alunoresponsavel2model.DsTelefone1;
            //txtResponsavel2Telefone2.Text = matricula.alunoresponsavel2model.DsTelefone2;

            ////Aluno Responsavel 3

            //txtResponsavel3Email.Text = matricula.alunoresponsavel3model.DsEmail;
            //txtResponsavel3.Text = matricula.alunoresponsavel3model.NmResponsavel;
            //cboGrauParentesco3.Text = matricula.alunoresponsavel3model.DsParentesco;
            //txtResponsavel3Telefone1.Text = matricula.alunoresponsavel3model.DsTelefone1;
            //txtResponsavel3Telefone2.Text = matricula.alunoresponsavel3model.DsTelefone2;

            //Aluno

            txtRG.Text = matricula.aluno.DsRg;
            txtCpf.Text = matricula.aluno.DsCpf;
            cboSexo.Text = matricula.aluno.DsSexo;
            txtNome.Text = matricula.aluno.NmAluno;
            txtEtnia.Text = matricula.aluno.DsEtinia;
            nudRenda.Value = matricula.aluno.VlRenda;
            txtRgOrgao.Text = matricula.aluno.DsOrgao;
            txtCelular.Text = matricula.aluno.DsCelular;
            txtAlunoEmail.Text = matricula.aluno.DsEmail;
            dtpRgEmissao.Value = matricula.aluno.DtEmissao;
            cboTipoDeEscola.Text = matricula.aluno.TpEscola;
            txtNomeDaEscola.Text = matricula.aluno.NmEscola;
            txtObservacoes.Text = matricula.aluno.DsObservacao;
            cboComoConheceu.Text = matricula.aluno.DsComoConheceu;
            cboEscolaridade.Text = matricula.aluno.DsEscolaridade;
            dtpNascimentoData.Value = matricula.aluno.DtNascimento;
            nudPessoasMoramCasa.Value = matricula.aluno.QtMoramCasa;
            nudPessoasTrabalhamCasa.Value = matricula.aluno.QtTrabalhamCasa;

            //Localização

            //txtCep.Text = matricula.alunolocalizacaomodel.DsResidenciaCep;
            //txtBairro.Text = matricula.alunolocalizacaomodel.DsResidenciaBairro;
            //txtCidade.Text = matricula.alunolocalizacaomodel.DsResidenciaCidade;
            //txtEndereco.Text = matricula.alunolocalizacaomodel.DsResidenciaEndereco;
            //txtNascimentoPais.Text = matricula.alunolocalizacaomodel.DsNascimentoPais;
            //txtNascimentoCidade.Text = matricula.alunolocalizacaomodel.DsNascimentoCidade;
            //txtComplemento.Text = matricula.alunolocalizacaomodel.DsResidenciaComplelemento;

            //Aluno Ficha Medica

            //txtAlergias.Text = matricula.alunofichamedicaModel.DsAlergias;
            //txtMedicacao.Text = matricula.alunofichamedicaModel.DsMedicacao;
            //txtCongenitas.Text = matricula.alunofichamedicaModel.DsCongenitas;
            //txtTratamento.Text = matricula.alunofichamedicaModel.DsTratamento;
            //txtObservacoesMedicas.Text = matricula.alunofichamedicaModel.DsObservacao;
            //txtAcompanhamento.Text = matricula.alunofichamedicaModel.DsAcompanhamento;


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

            // Lista de responaveis

            List<Model.AlunoResponsavel> responsaveis = new List<Model.AlunoResponsavel>();
            responsaveis.Add(responsavel1);
            responsaveis.Add(responsavel2);
            responsaveis.Add(responsavel3);

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
            matricula.Responsaiveis = responsaveis;

            return matricula;
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            string cep = txtCep.Text;

            CorreioResponse response;

            Nsf.App.Utils.APIs.CorreioApi api = new Utils.APIs.CorreioApi();
            if (api.BuscarAPICorreio(cep, out response))
            {
                txtEndereco.Text = response.logradouro;
                txtCidade.Text = response.localidade;
                txtBairro.Text = response.bairro;
                cboUf.Text = response.uf;
            }
        }
    }
}