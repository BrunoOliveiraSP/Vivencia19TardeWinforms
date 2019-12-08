using Nsf.App.API.Client;
using Nsf.App.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nsf.App.UI
{
	public partial class frmProfessorConsultar : NsfUserScreen
	{

		public frmProfessorConsultar()
		{
			InitializeComponent();
            this.ListarTodos();

        }



        private void ListarPorNome()
        {
            ProfessorAPI api = new ProfessorAPI();
            List<ProfessorModel> list = api.ListarPorNome(txtNome.Text);

            dgvProfessores.AutoGenerateColumns = false;
            dgvProfessores.DataSource = list;
            
        }

        private void ListarTodos()
        {
            ProfessorAPI api = new ProfessorAPI();
            List<ProfessorModel> lista = api.ListarTodos();
            
            dgvProfessores.AutoGenerateColumns = false;
            dgvProfessores.DataSource = lista;
            
        }

        private void Deletar()
        {
            ProfessorModel professor = dgvProfessores.CurrentRow.DataBoundItem as ProfessorModel;

            DialogResult r = MessageBox.Show(@"Tem certeza que deseja remover?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                ProfessorAPI api = new ProfessorAPI();
                api.Remover(professor.IdProfessor, professor.IdLogin);

                MessageBox.Show(@"Professor Removido com sucesso!", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                this.ListarTodos();
            }
        }

        private void Alterar()
        {
            ProfessorModel professor = dgvProfessores.CurrentRow.DataBoundItem as ProfessorModel;                    

            ProfessorModel model = new ProfessorModel();

            model.IdProfessor = professor.IdProfessor;
            model.IdLogin = professor.IdLogin;
            model.BtAtivo = professor.BtAtivo;
            model.NmProfessor = professor.NmProfessor;
            model.NmPai = professor.NmPai;
            model.NmMae = professor.NmMae;
            model.DsCelular = professor.DsCelular;
            model.DsCpf = professor.DsCpf;
            model.DsCurso = professor.DsCurso;
            model.DsCvLattes = professor.DsCvLattes;
            model.DsEmail = professor.DsEmail;
            model.DsEstado = professor.DsEstado;
            model.DsFaculdade = professor.DsFaculdade;
            model.DsRg = professor.DsRg;
            model.DsRgEmissor = professor.DsRgEmissor;
            model.DsRgOrgao = professor.DsRgOrgao;
            model.DsTelefone = professor.DsTelefone;
            model.DtFaculdadeFim = professor.DtFaculdadeFim;
            model.DtFaculdadeInicio = professor.DtFaculdadeInicio;
            model.DtNascimento = professor.DtNascimento;
            model.NrAnoPrimeiroEmprego = professor.NrAnoPrimeiroEmprego;
            model.TpContratacao = professor.TpContratacao;

            frmProfessorCadastrar tela = new frmProfessorCadastrar();
            

            frmInicial.Current.OpenScreen(tela);
            tela.CarregarCampos(model);

            this.Hide();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.ListarPorNome();
        }


        private void dgvProfessores_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                this.Alterar();
            }

            if (e.ColumnIndex == 6)
            {
                this.Deletar();
            }
        }
    }
}