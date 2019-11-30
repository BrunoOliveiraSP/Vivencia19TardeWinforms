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
            string mae, string pai, string contrato, string login, string cpf, string rg,
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
            txtLogin.Text = login;
            txtCpf.Text = cpf;
            txtRG.Text = rg;
            txtRGEmissao.Text = emissao;
            txtRGOrgao.Text = orgao;


        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProfessorModel professor = new ProfessorModel();
            professor.IdProfessor = Convert.ToInt32(lblId.Text);
            professor.NmProfessor = txtNome.Text;
            professor.BtAtivo = chkAtivo.Checked;
            professor.DtNascimento = dtpNascimento.Value.Date;
            professor.DsEstado = txtEstadoNasc.Text;
            professor.DsCelular = txtCelular.Text;
            professor.DsTelefone = txtTelefone.Text;
            professor.DsEmail = txtEmail.Text;
            professor.DsCvLattes = txtCvLattes.Text;
            professor.NrAnoPrimeiroEmprego = Convert.ToInt32(nudPrimeiroEmprego.Value);
            professor.DtFaculdadeInicio = dtpFaculdadeInicio.Value.Date;
            professor.DtFaculdadeFim = dtpFaculdadeFim.Value.Date;
            professor.DsFaculdade = txtFaculdade.Text;
            professor.DsCurso = txtCurso.Text;
            professor.NmMae = txtMae.Text;
            professor.NmPai = txtPai.Text;
            professor.TpContratacao = cboContrato.Text;
            professor.DsLogin = txtLogin.Text;
            professor.DsCpf = txtCpf.Text;
            professor.DsRg = txtRG.Text;
            professor.DsRgOrgao = txtRGOrgao.Text;
            professor.DsRgEmissor = txtRGEmissao.Text;

            ProfessorAPI api = new ProfessorAPI();
            api.Salvar(professor);

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}