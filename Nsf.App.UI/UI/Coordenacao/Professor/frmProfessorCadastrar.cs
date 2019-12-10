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

        ProfessorRequest professorReq;
        ProfessorModel _professor;
        LoginModel login;

        public void Inserir()
        {
            professorReq = new ProfessorRequest();
            _professor = new ProfessorModel();
            login = new LoginModel();

            login.DsLogin = txtLogin.Text;
            login.BtAtivo = chkAtivo.Checked;
            _professor.BtAtivo = chkAtivo.Checked;
            _professor.NmProfessor = txtNome.Text;
            _professor.NmPai = txtPai.Text;
            _professor.NmMae = txtNome.Text;
            _professor.DsCelular = txtCelular.Text;
            _professor.DsCpf = txtCpf.Text;
            _professor.DsCurso = txtCurso.Text;
            _professor.DsCvLattes = txtCvLattes.Text;
            _professor.DsEmail = txtEmail.Text;
            _professor.DsEstado = txtEstadoNasc.Text;
            _professor.DsFaculdade = txtFaculdade.Text;
            _professor.DsRg = txtRG.Text;
            _professor.DsRgEmissor = txtRGEmissao.Text;
            _professor.DsRgOrgao = txtRGOrgao.Text;
            _professor.DsTelefone = txtTelefone.Text;
            _professor.DtFaculdadeFim = dtpFaculdadeFim.Value;
            _professor.DtFaculdadeInicio = dtpFaculdadeInicio.Value;
            _professor.DtNascimento = dtpNascimento.Value;
            _professor.NrAnoPrimeiroEmprego = Convert.ToInt32(nudPrimeiroEmprego.Value);
            _professor.TpContratacao = cboContrato.Text;

            professorReq.Professor = _professor;
            professorReq.Login = login;

            ProfessorAPI api = new ProfessorAPI();
            professorReq = api.Inserir(professorReq);

            MessageBox.Show(@"Salvo com sucesso!", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panelId.Visible = true;
            lblId.Text = professorReq.Professor.IdProfessor.ToString();      
          
        }

        public void Alterar()
        {
            Model.ProfessorResponse professor = new Model.ProfessorResponse();

            login.DsLogin = txtLogin.Text;
            login.BtAtivo = chkAtivo.Checked;
            _professor.BtAtivo = chkAtivo.Checked;
            _professor.NmProfessor = txtNome.Text;
            _professor.NmPai = txtPai.Text;
            _professor.NmMae = txtNome.Text;
            _professor.DsCelular = txtCelular.Text;
            _professor.DsCpf = txtCpf.Text;
            _professor.DsCurso = txtCurso.Text;
            _professor.DsCvLattes = txtCvLattes.Text;
            _professor.DsEmail = txtEmail.Text;
            _professor.DsEstado = txtEstadoNasc.Text;
            _professor.DsFaculdade = txtFaculdade.Text;
            _professor.DsRg = txtRG.Text;
            _professor.DsRgEmissor = txtRGEmissao.Text;
            _professor.DsRgOrgao = txtRGOrgao.Text;
            _professor.DsTelefone = txtTelefone.Text;
            _professor.DtFaculdadeFim = dtpFaculdadeFim.Value;
            _professor.DtFaculdadeInicio = dtpFaculdadeInicio.Value;
            _professor.DtNascimento = dtpNascimento.Value;
            _professor.NrAnoPrimeiroEmprego = Convert.ToInt32(nudPrimeiroEmprego.Value);
            _professor.TpContratacao = cboContrato.Text;

            professor.IdProfessor = _professor.IdProfessor;

            professorReq.Professor = _professor;
            professorReq.Login = login;
            

            ProfessorAPI api = new ProfessorAPI();
            api.Alterar(professorReq);

            MessageBox.Show(@"Alterado com sucesso!", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void CarregarCampos(ProfessorModel professor)
        {
            panelId.Visible = true;
            lblId.Text = professor.IdProfessor.ToString();
            txtNome.Text = professor.NmProfessor;
            txtPai.Text = professor.NmPai;
            txtMae.Text = professor.NmMae;
            chkAtivo.Checked = professor.BtAtivo;
            txtCelular.Text = professor.DsCelular;
            txtCpf.Text = professor.DsCpf;
            txtCurso.Text = professor.DsCurso;
            txtCvLattes.Text = professor.DsCvLattes;
            txtEmail.Text = professor.DsEmail;
            txtEstadoNasc.Text = professor.DsEstado;
            txtFaculdade.Text = professor.DsFaculdade;
            txtRG.Text = professor.DsRg;
            txtRGEmissao.Text = professor.DsRgEmissor;
            txtRGOrgao.Text = professor.DsRgOrgao;
            txtTelefone.Text = professor.DsTelefone;
            dtpFaculdadeFim.Value = professor.DtFaculdadeFim;
            dtpFaculdadeInicio.Value = professor.DtFaculdadeInicio;
            dtpNascimento.Value = professor.DtNascimento;
            txtLogin.Text = professor.IdLogin.ToString();
            nudPrimeiroEmprego.Value = professor.NrAnoPrimeiroEmprego;
            cboContrato.Text = professor.TpContratacao;

            _professor = professor;
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
                if(_professor != null && professorReq.Professor.IdProfessor > 0)
                {
                    this.Alterar();
                }
                else
                {
                    this.Inserir();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //catch (Exception)
            //{
            //    MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtRGEmissao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}