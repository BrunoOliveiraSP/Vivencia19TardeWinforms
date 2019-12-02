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
            string nmcurso = txtCurso.Text;

            Nsf.App.UI.API.CursoAPI curso = new API.CursoAPI();
            List<Nsf.App.Model.CursoModel> lista = curso.ConsultarPorCurso(nmcurso);

            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = lista;
        }

        private void txtSigla_TextChanged(object sender, EventArgs e)
        {
            string sigla = txtSigla.Text;

            Nsf.App.UI.API.CursoAPI curso = new API.CursoAPI();
            List<Nsf.App.Model.CursoModel> lista = curso.ConsultarPorSigla(sigla);

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
            if (e.ColumnIndex == 4)
            {
                Model.CursoModel curso = dgvCursos.CurrentRow.DataBoundItem as Model.CursoModel;

                Nsf.App.Model.CursoModel model = new Model.CursoModel();


                model.IdCurso = curso.IdCurso;
                model.NmCurso = curso.NmCurso;
                model.NrCapacidadeMaxima = curso.NrCapacidadeMaxima;
                model.DsSigla = curso.DsSigla;
                model.DsCategoria = curso.DsCategoria;
                model.BtAtivo = curso.BtAtivo;

                frmCursoCadastrar tela = new frmCursoCadastrar();

                frmInicial.Current.OpenScreen(tela);
                tela.AlterarInformacao(model);
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