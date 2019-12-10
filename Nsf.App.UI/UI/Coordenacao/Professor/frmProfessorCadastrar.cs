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

        ProfessorResponse professor = new ProfessorResponse();

        public void Inserir()
        {
            ProfessorRequest professorReq = CarregarRequest();

            ProfessorAPI api = new ProfessorAPI();
            professorReq = api.Inserir(professorReq);

            professor.IdProfessor = professorReq.Professor.IdProfessor;
            professor.IdLogin = professorReq.Login.IdLogin;


            MessageBox.Show(@"Salvo com sucesso!", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panelId.Visible = true;
            lblId.Text = professorReq.Professor.IdProfessor.ToString();      
          
        }

        public void Alterar()
        {
            ProfessorRequest professorReq = CarregarRequest();
            professorReq.Professor.IdProfessor = this.professor.IdProfessor;
            professorReq.Professor.IdLogin = this.professor.IdLogin;
            professorReq.Login.IdLogin = this.professor.IdLogin;


            ProfessorAPI api = new ProfessorAPI();
            api.Alterar(professorReq);

            MessageBox.Show(@"Alterado com sucesso!", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public ProfessorRequest CarregarRequest()
        {
            ProfessorRequest professorReq = new ProfessorRequest();
            ProfessorModel _professor = new ProfessorModel();
            LoginModel login = new LoginModel();

            _professor.NrAnoPrimeiroEmprego = Convert.ToInt32(nudPrimeiroEmprego.Value);
            _professor.DtFaculdadeInicio = dtpFaculdadeInicio.Value;
            _professor.DtFaculdadeFim = dtpFaculdadeFim.Value;
            _professor.DtNascimento = dtpNascimento.Value;
            _professor.TpContratacao = cboContrato.Text;
            _professor.DsRgEmissor = txtRGEmissao.Text;
            _professor.DsFaculdade = txtFaculdade.Text;
            _professor.DsTelefone = txtTelefone.Text;
            _professor.DsEstado = txtEstadoNasc.Text;
            _professor.DsCvLattes = txtCvLattes.Text;
            _professor.DsCelular = txtCelular.Text;
            _professor.DsRgOrgao = txtRGOrgao.Text;
            _professor.BtAtivo = chkAtivo.Checked;
            _professor.NmProfessor = txtNome.Text;
            _professor.DsCurso = txtCurso.Text;
            _professor.DsEmail = txtEmail.Text;
            _professor.NmMae = txtNome.Text;
            _professor.DsCpf = txtCpf.Text;
            _professor.NmPai = txtPai.Text;
            login.DsLogin = txtLogin.Text;
            _professor.DsRg = txtRG.Text;

            professorReq.Professor = _professor;
            professorReq.Login = login;

            return professorReq;
        }

        public void CarregarCampos(ProfessorResponse professor)
        {
            nudPrimeiroEmprego.Value = professor.NrAnoPrimeiroEmprego;
            dtpFaculdadeInicio.Value = professor.DtFaculdadeInicio;
            dtpFaculdadeFim.Value = professor.DtFaculdadeFim;
            lblId.Text = professor.IdProfessor.ToString();
            dtpNascimento.Value = professor.DtNascimento;
            cboContrato.Text = professor.TpContratacao;
            txtFaculdade.Text = professor.DsFaculdade;
            txtRGEmissao.Text = professor.DsRgEmissor;
            txtCvLattes.Text = professor.DsCvLattes;
            txtEstadoNasc.Text = professor.DsEstado;
            txtTelefone.Text = professor.DsTelefone;
            txtCelular.Text = professor.DsCelular;
            txtRGOrgao.Text = professor.DsRgOrgao;
            txtNome.Text = professor.NmProfessor;
            chkAtivo.Checked = professor.BtAtivo;
            txtCurso.Text = professor.DsCurso;
            txtEmail.Text = professor.DsEmail;
            txtLogin.Text = professor.DsLogin;
            txtPai.Text = professor.NmPai;
            txtMae.Text = professor.NmMae;
            txtCpf.Text = professor.DsCpf;
            txtRG.Text = professor.DsRg;
            panelId.Visible = true;

            this.professor = professor;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(professor.IdProfessor > 0)
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}