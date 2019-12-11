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
        App.API.Client.MatriculaAPI MatriculaApi = new App.API.Client.MatriculaAPI();

        private void dgvCandidatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 9)
            {
                Model.MatriculaRequest matricula = dgvCandidatos.CurrentRow.DataBoundItem as Model.MatriculaRequest;

                DialogResult result = MessageBox.Show("Dejesa Remover?", "NSF", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        MatriculaApi.Deletar(matricula.Aluno.IdAluno);
                        MessageBox.Show("Registro removido", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarGrid();
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if(e.ColumnIndex == 8)
            {
                Model.MatriculaRequest matricula = dgvCandidatos.CurrentRow.DataBoundItem as Model.MatriculaRequest;

                Model.MatriculaRequest novo = new Model.MatriculaRequest();

                frmMatriculaNovo tela = new frmMatriculaNovo();
                tela.CarregarTela(matricula);

                frmInicial.Current.OpenScreen(tela);
                Hide();
            }
        }

        private void CarregarGrid()
        {
            try
            {
                
                List<Model.MatriculaResponse> lista = MatriculaApi.ListarTodos();
                dgvCandidatos.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ra = txtRA.Text;
            string nome = txtNome.Text;
            string curso = cboCurso.Text;
            string turma = cboTurma.Text;

            try
            {
                List<Model.MatriculaRequest> lista = MatriculaApi.ConsultarPorParametros(nome, ra, curso, turma);
                dgvCandidatos.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro removido", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ra = txtRA.Text;
            string nome = txtNome.Text;
            string curso = cboCurso.Text;
            string turma = cboTurma.Text;

            try
            {
                List<Model.MatriculaRequest> lista = MatriculaApi.ConsultarPorParametros(nome, ra, curso, turma);
                dgvCandidatos.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro removido", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string ra = txtRA.Text;
            string nome = txtNome.Text;
            string curso = cboCurso.Text;
            string turma = cboTurma.Text;

            try
            {
                List<Model.MatriculaRequest> lista = MatriculaApi.ConsultarPorParametros(nome, ra, curso, turma);
                dgvCandidatos.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception )
            {
                MessageBox.Show("Registro removido", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtRA_TextChanged(object sender, EventArgs e)
        {
            string ra = txtRA.Text;
            string nome = txtNome.Text;
            string curso = cboCurso.Text;
            string turma = cboTurma.Text;

            try
            {
                List<Model.MatriculaRequest> lista = MatriculaApi.ConsultarPorParametros(nome, ra, curso, turma);
                dgvCandidatos.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro removido", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}