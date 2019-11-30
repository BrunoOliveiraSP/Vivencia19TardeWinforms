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
            dgvProfessores.DataSource = list;
        }

        private void ListarTodos()
        {
            ProfessorAPI api = new ProfessorAPI();
            List<ProfessorModel> lista = api.ListarTodos();

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

        private void CarregarCampos()
        {
            ProfessorModel atividade = dgvProfessores.CurrentRow.DataBoundItem as ProfessorModel;

            frmProfessorCadastrar professorCadastrar = new frmProfessorCadastrar(atividade.IdProfessor,
                atividade.NmProfessor, atividade.BtAtivo, atividade.DtNascimento, atividade.DsEstado,
                atividade.DsCelular, atividade.DsTelefone, atividade.DsEmail, atividade.DsCvLattes,
                atividade.NrAnoPrimeiroEmprego, atividade.DtFaculdadeInicio, atividade.DtFaculdadeFim,
                atividade.DsFaculdade, atividade.DsCurso, atividade.NmMae, atividade.NmPai, atividade.TpContratacao,
                atividade.DsLogin, atividade.DsCpf, atividade.DsRg, atividade.DsRgOrgao, atividade.DsRgEmissor
                );

            professorCadastrar.Show();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.ListarPorNome();
        }

        private void dgvProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                this.CarregarCampos();
            }
            if (e.ColumnIndex == 5)
            {
                this.Deletar();
            }

        }
    }
}