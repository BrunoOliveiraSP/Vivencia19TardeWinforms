using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nsf.App.UI
{
	public partial class frmMatriculaConsultar : NsfUserScreen
	{
		public frmMatriculaConsultar()
		{
			InitializeComponent();
            CarregarGrid();
		}
        Nsf.App.API.Client.MatriculaAPI MatriculaApi = new App.API.Client.MatriculaAPI();

        private void dgvCandidatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 9)
            {
                Model.MatriculaRequest matricula = dgvCandidatos.CurrentRow.DataBoundItem as Model.MatriculaRequest;

                DialogResult result = MessageBox.Show("Dejesa Remover?", "NSF", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    MatriculaApi.Deletar(matricula.Aluno.IdAluno);
                    MessageBox.Show("Registro removido", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
            }
            else if(e.ColumnIndex == 8)
            {
                Model.MatriculaRequest matricula = dgvCandidatos.CurrentRow.DataBoundItem as Model.MatriculaRequest;

                Model.MatriculaRequest novo = new Model.MatriculaRequest();

                novo.Aluno.NmAluno = matricula.Aluno.NmAluno;
                novo.Aluno.DsRg = matricula.Aluno.DsRg;
            }
        }

        private void CarregarGrid()
        {
            List<Model.MatriculaRequest> lista = MatriculaApi.ListarTodos();

            dgvCandidatos.DataSource = lista;
        }
    }
}