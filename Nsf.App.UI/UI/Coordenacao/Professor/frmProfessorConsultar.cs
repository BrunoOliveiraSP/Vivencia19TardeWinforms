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
                api.Remover(Convert.ToInt32(professor.IdProfessor));

                MessageBox.Show(@"Atividade Removida com sucesso!");
                this.ListarTodos();
            }
        }

        private void Alterar()
        {
            ProfessorRequest modelo = dgvProfessores.CurrentRow.DataBoundItem as ProfessorRequest;

            frmProfessorCadastrar telaCadastrar = new frmProfessorCadastrar();
            telaCadastrar.CarregarCampos(modelo);

            frmInicial.Current.OpenScreen(telaCadastrar);
            this.Hide();

            frmInicial.Current.OpenScreen(new frmProfessorCadastrar());
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.ListarPorNome();
        }

        private void dgvProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                this.Alterar();
            }
            if (e.ColumnIndex == 5)
            {
                this.Deletar();
            }

        }
    }
}