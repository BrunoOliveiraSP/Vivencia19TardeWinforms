using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmDisciplinasConsultar : NsfUserScreen
    {


        public frmDisciplinasConsultar()
        {
            InitializeComponent();

            this.Carregar();
        }
  
        private void txtSigla_TextChanged(object sender, EventArgs e)
        {
            this.Consultar();
        }

        private void txtDisciplina_TextChanged(object sender, EventArgs e)
        {
            this.Consultar();
        }

        public void Consultar()
        {
            string nome = txtDisciplina.Text;
            string sigla = txtSigla.Text;
            

            Nsf.App.API.Client.DisciplinaAPI api = new Nsf.App.API.Client.DisciplinaAPI();

            List<Nsf.App.Model.DisciplinaModel> lista = api.Consultar(nome, sigla);

            dgvDisciplinas.AutoGenerateColumns = false;
            dgvDisciplinas.DataSource = lista;
        }

        public void Carregar()
        { 

            Nsf.App.API.Client.DisciplinaAPI api = new Nsf.App.API.Client.DisciplinaAPI();

            List<Nsf.App.Model.DisciplinaModel> lista = api.Listar();

            dgvDisciplinas.AutoGenerateColumns = false;
            dgvDisciplinas.DataSource = lista;

        }

        private void dgvDisciplinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6 )
            {
                Model.DisciplinaModel disciplina = dgvDisciplinas.CurrentRow.DataBoundItem as Model.DisciplinaModel;

                Nsf.App.Model.DisciplinaModel model = new Model.DisciplinaModel();


                model.IdDisciplina = disciplina.IdDisciplina;
                model.NmDisciplina = disciplina.NmDisciplina;
                model.DsSigla = disciplina.DsSigla;
                model.DtInclusao = disciplina.DtInclusao;
                model.DtUltimaAlteracao = disciplina.DtUltimaAlteracao;
                model.BtAtivo = disciplina.BtAtivo;


                Nsf.App.API.Client.DisciplinaAPI api = new Nsf.App.API.Client.DisciplinaAPI();

                api.Alterar(model);

                MessageBox.Show("Alterado com Sucesso");

            }

            if (e.ColumnIndex == 7)
            {
                Model.DisciplinaModel disciplina = dgvDisciplinas.CurrentRow.DataBoundItem as Model.DisciplinaModel;

                Nsf.App.Model.DisciplinaModel model = new Model.DisciplinaModel();


                DialogResult res = MessageBox.Show("Deseja remover essa disciplina?", "Remover",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res ==DialogResult.Yes)
                {
                    Nsf.App.API.Client.DisciplinaAPI api = new Nsf.App.API.Client.DisciplinaAPI();

                    api.Remover(disciplina.IdDisciplina);

                    MessageBox.Show("Removido com Sucesso");
                }
            }
        }

        private void dgvDisciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}