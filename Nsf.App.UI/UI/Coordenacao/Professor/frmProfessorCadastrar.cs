using Nsf.App.API.Client;
using Nsf.App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Nsf.App.UI
{
	public partial class frmProfessorCadastrar : NsfUserScreen
	{
		public frmProfessorCadastrar()
		{
			InitializeComponent();
            
		}

        public void CarregarCampos(ProfessorRequest professor)
        {

            professor.Professor.IdProfessor = professor.Professor.IdProfessor;
            txtLogin.Text = professor.Login.DsLogin;
            lblId.Text = professor.Professor.IdProfessor.ToString();
            txtNome.Text = professor.Professor.NmProfessor;
            txtPai.Text = professor.Professor.NmPai;
            txtMae.Text = professor.Professor.NmMae;
            chkAtivo.Checked = professor.Professor.BtAtivo;
            txtCelular.Text = professor.Professor.DsCelular;
            txtCpf.Text = professor.Professor.DsCpf;
            txtCurso.Text = professor.Professor.DsCurso;
            txtCvLattes.Text = professor.Professor.DsCvLattes;
            txtEmail.Text = professor.Professor.DsEmail;
            txtEstadoNasc.Text = professor.Professor.DsEstado;
            txtFaculdade.Text = professor.Professor.DsFaculdade;
            txtRG.Text = professor.Professor.DsRg;
            txtRGEmissao.Text = professor.Professor.DsRgEmissor;
            txtRGOrgao.Text = professor.Professor.DsRgOrgao;
            txtTelefone.Text = professor.Professor.DsTelefone;
            dtpFaculdadeFim.Value = professor.Professor.DtFaculdadeFim;
            dtpFaculdadeInicio.Value = professor.Professor.DtFaculdadeInicio;
            dtpNascimento.Value = professor.Professor.DtNascimento;
            txtLogin.Text = professor.Professor.IdLogin.ToString();
            nudPrimeiroEmprego.Value = professor.Professor.NrAnoPrimeiroEmprego;
            cboContrato.Text = professor.Professor.TpContratacao;
            panelId.Visible = true;
        }

        public void LimparCampos()
        {
            lblId.Text = "0";
            txtNome.Text = string.Empty;
            chkAtivo.Checked = true;
            dtpNascimento.Value = DateTime.Now;
            txtEstadoNasc.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCvLattes.Text = string.Empty;
            nudPrimeiroEmprego.Value = 1900;
            txtFaculdade.Text = string.Empty;
            dtpFaculdadeInicio.Value = DateTime.Now;
            dtpFaculdadeFim.Value = DateTime.Now;
            txtCurso.Text = string.Empty;
            txtMae.Text = string.Empty;
            txtPai.Text = string.Empty;
            cboContrato.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtRGEmissao.Text = string.Empty;
            txtRGOrgao.Text = string.Empty;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ProfessorRequest professor = new ProfessorRequest();

                if (Convert.ToInt32(lblId.Text) != 0)
                {
                    professor.Login.DsLogin = txtLogin.Text;
                    professor.Login.BtAtivo = true;
                    professor.Login.BtTrocar = false;
                    professor.Login.DsSenha = "123";
                    professor.Login.IdRole = 1;
                    professor.Login.DtUltimoLogin = DateTime.Now.Date();
                    professor.Login.DtInclusao = DateTime.Now.Date();

                    professor.Professor.IdProfessor = Convert.ToInt32(lblId.Text);
                    professor.Professor.NmProfessor = txtNome.Text;
                    professor.Professor.NmPai = txtPai.Text;
                    professor.Professor.NmMae = txtNome.Text;
                    professor.Professor.BtAtivo = chkAtivo.Checked;
                    professor.Professor.DsCelular = txtCelular.Text;
                    professor.Professor.DsCpf = txtCpf.Text;
                    professor.Professor.DsCurso = txtCurso.Text;
                    professor.Professor.DsCvLattes = txtCvLattes.Text;
                    professor.Professor.DsEmail = txtEmail.Text;
                    professor.Professor.DsEstado = txtEstadoNasc.Text;
                    professor.Professor.DsFaculdade = txtFaculdade.Text;
                    professor.Professor.DsRg = txtRG.Text;
                    professor.Professor.DsRgEmissor = txtRGEmissao.Text;
                    professor.Professor.DsRgOrgao = txtRGOrgao.Text;
                    professor.Professor.DsTelefone = txtTelefone.Text;
                    professor.Professor.DtFaculdadeFim = dtpFaculdadeFim.Value;
                    professor.Professor.DtFaculdadeInicio = dtpFaculdadeInicio.Value;
                    professor.Professor.DtNascimento = dtpNascimento.Value;
                    professor.Professor.IdLogin = Convert.ToInt32(txtLogin.Text);
                    professor.Professor.NrAnoPrimeiroEmprego = Convert.ToInt32(nudPrimeiroEmprego.Value);
                    professor.Professor.TpContratacao = cboContrato.Text;

                    ProfessorAPI api = new ProfessorAPI();
                    api.Alterar(professor);

                    MessageBox.Show(@"Alterado com sucesso!", "NSF", MessageBoxButtons.OK);

                    this.LimparCampos();
                }
                else
                {
                    Model.ProfessorModel prof = new ProfessorModel();
                    Model.LoginModel log = new LoginModel();

                    log.DsLogin = txtLogin.Text;
                    log.BtAtivo = chkAtivo.Checked;
                    prof.NmProfessor = txtNome.Text;
                    prof.NmPai = txtPai.Text;
                    prof.NmMae = txtNome.Text;
                    prof.DsCelular = txtCelular.Text;
                    prof.DsCpf = txtCpf.Text;
                    prof.DsCurso = txtCurso.Text;
                    prof.DsCvLattes = txtCvLattes.Text;
                    prof.DsEmail = txtEmail.Text;
                    prof.DsEstado = txtEstadoNasc.Text;
                    prof.DsFaculdade = txtFaculdade.Text;
                    prof.DsRg = txtRG.Text;
                    prof.DsRgEmissor = txtRGEmissao.Text;
                    prof.DsRgOrgao = txtRGOrgao.Text;
                    prof.DsTelefone = txtTelefone.Text;
                    prof.DtFaculdadeFim = dtpFaculdadeFim.Value;
                    prof.DtFaculdadeInicio = dtpFaculdadeInicio.Value;
                    prof.DtNascimento = dtpNascimento.Value;
                    prof.NrAnoPrimeiroEmprego = Convert.ToInt32(nudPrimeiroEmprego.Value);
                    prof.TpContratacao = cboContrato.Text;

                    professor.Professor = prof;
                    professor.Login = log;

                    ProfessorAPI api = new ProfessorAPI();
                    professor = api.Inserir(professor);

                    lblId.Text = professor.Professor.IdProfessor.ToString();
                    txtLogin.Text = professor.Login.IdLogin.ToString();

                    MessageBox.Show(@"Salvo com sucesso!", "NSF", MessageBoxButtons.OK);

                    this.LimparCampos();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}