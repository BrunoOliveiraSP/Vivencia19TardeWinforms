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
            List<ProfessorResponse> list = api.ListarPorNome(txtNome.Text);

            dgvProfessores.AutoGenerateColumns = false;
            dgvProfessores.DataSource = list;
            
        }

        private void ListarTodos()
        {
            ProfessorAPI api = new ProfessorAPI();
            List<ProfessorResponse> lista = api.ListarTodos();
            
            dgvProfessores.AutoGenerateColumns = false;
            dgvProfessores.DataSource = lista;
            
        }

        private void Deletar()
        {
            ProfessorResponse professor = dgvProfessores.CurrentRow.DataBoundItem as ProfessorResponse;

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
            ProfessorResponse professor = dgvProfessores.CurrentRow.DataBoundItem as ProfessorResponse;                    

            frmProfessorCadastrar tela = new frmProfessorCadastrar();
            

            frmInicial.Current.OpenScreen(tela);
            tela.CarregarCampos(professor);

            this.Hide();    
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.ListarPorNome();
        }


        private void dgvProfessores_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
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