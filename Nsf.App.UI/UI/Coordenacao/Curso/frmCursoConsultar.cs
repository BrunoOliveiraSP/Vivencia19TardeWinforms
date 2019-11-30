using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmCursoConsultar : NsfUserScreen
    {
        public frmCursoConsultar()
        {
            InitializeComponent();
            this.Carregar();
        }

        private void txtCurso_TextChanged(object sender, EventArgs e)
        {
            Nsf.App.UI.API.CursoAPI curso = new API.CursoAPI();
            List<Nsf.App.Model.CursoModel> lista = curso.ConsultarPorCurso(txtCurso.Text);

            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = lista;
        }

        private void txtSigla_TextChanged(object sender, EventArgs e)
        {
            Nsf.App.UI.API.CursoAPI curso = new API.CursoAPI();
            List<Nsf.App.Model.CursoModel> lista = curso.ConsultarPorSigla(txtSigla.Text);

            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = lista;
        }

        private void Carregar()
        {
            Nsf.App.UI.API.CursoAPI curso = new API.CursoAPI();
            List<Nsf.App.Model.CursoModel> lista = curso.ConsultarTodos();

            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = lista;
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Model.CursoModel curso = dgvCursos.CurrentRow.DataBoundItem as Model.CursoModel;
                




            }

                if (e.ColumnIndex == 5)
            {
                Model.CursoModel curso = dgvCursos.CurrentRow.DataBoundItem as Model.CursoModel;

                DialogResult r = MessageBox.Show("Deseja remover?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(r == DialogResult.Yes)
                {
                    API.CursoAPI api = new API.CursoAPI();
                    api.Remover(curso.IdCurso);

                    MessageBox.Show("Removido com sucesso");
                    Carregar();
                }
           
            }

        }
    }
}