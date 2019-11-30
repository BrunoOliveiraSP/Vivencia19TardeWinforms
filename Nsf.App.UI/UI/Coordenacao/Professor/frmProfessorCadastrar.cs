using Nsf.App.API.Client;
using Nsf.App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Nsf.App.UI
{
	public partial class frmProfessorCadastrar : NsfUserScreen
	{
		public frmProfessorCadastrar()
		{
			InitializeComponent();
		}

        public frmProfessorCadastrar(int id, string nome, bool ativo, DateTime nascimento,
            string estado, string celular, string telefone, string email, string cvLattes,
            int ano1emprego, DateTime inicio, DateTime fim, string faculdade, string curso,
            string mae, string pai, string contrato, string cpf, string rg,
            string orgao, string emissao)
        {
            InitializeComponent();

            lblId.Text = id.ToString();
            txtNome.Text = nome;
            chkAtivo.Checked = ativo;
            dtpNascimento.Value = nascimento;
            txtEstadoNasc.Text = estado;
            txtCelular.Text = celular;
            txtTelefone.Text = telefone;
            txtEmail.Text = email;
            txtCvLattes.Text = cvLattes;
            nudPrimeiroEmprego.Value = ano1emprego;
            txtFaculdade.Text = faculdade;
            dtpFaculdadeInicio.Value = inicio;
            dtpFaculdadeFim.Value = fim;
            txtCurso.Text = curso;
            txtMae.Text = mae;
            txtPai.Text = pai;
            cboContrato.Text = contrato;
 
            txtCpf.Text = cpf;
            txtRG.Text = rg;
            txtRGEmissao.Text = emissao;
            txtRGOrgao.Text = orgao;


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
            ProfessorRequest professor = new ProfessorRequest();
            professor.Professor.IdProfessor = Convert.ToInt32(lblId.Text);
            professor.Professor.NmProfessor = txtNome.Text;
            professor.Professor.BtAtivo = chkAtivo.Checked;
            professor.Professor.DtNascimento = dtpNascimento.Value.Date;
            professor.Professor.DsEstado = txtEstadoNasc.Text;
            professor.Professor.DsCelular = txtCelular.Text;
            professor.Professor.DsTelefone = txtTelefone.Text;
            professor.Professor.DsEmail = txtEmail.Text;
            professor.Professor.DsCvLattes = txtCvLattes.Text;
            professor.Professor.NrAnoPrimeiroEmprego = Convert.ToInt32(nudPrimeiroEmprego.Value);
            professor.Professor.DtFaculdadeInicio = dtpFaculdadeInicio.Value.Date;
            professor.Professor.DtFaculdadeFim = dtpFaculdadeFim.Value.Date;
            professor.Professor.DsFaculdade = txtFaculdade.Text;
            professor.Professor.DsCurso = txtCurso.Text;
            professor.Professor.NmMae = txtMae.Text;
            professor.Professor.NmPai = txtPai.Text;
            professor.Professor.TpContratacao = cboContrato.Text;      
            professor.Professor.DsCpf = txtCpf.Text;
            professor.Professor.DsRg = txtRG.Text;
            professor.Professor.DsRgOrgao = txtRGOrgao.Text;
            professor.Professor.DsRgEmissor = txtRGEmissao.Text;
            
            professor.Login.DsLogin = txtLogin.Text;


            ProfessorAPI api = new ProfessorAPI();
            api.Salvar(professor);

            this.LimparCampos();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }


    }
}