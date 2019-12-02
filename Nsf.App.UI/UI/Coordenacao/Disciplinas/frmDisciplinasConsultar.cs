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
            try
            {
                string nome = txtDisciplina.Text;
                string sigla = txtSigla.Text;

                if (nome == string.Empty)
                    nome = " ";
                if (sigla == string.Empty)
                    sigla = " ";

                Nsf.App.API.Client.DisciplinaAPI api = new Nsf.App.API.Client.DisciplinaAPI();
                List<Nsf.App.Model.DisciplinaModel> lista;

                if (nome == " " && sigla == " ")
                {
                    lista = api.Listar();
                }
                else
                {
                    lista = api.Consultar(nome, sigla);
                }
                dgvDisciplinas.AutoGenerateColumns = false;
                dgvDisciplinas.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void Carregar()
        {
            try
            {
                Nsf.App.API.Client.DisciplinaAPI api = new Nsf.App.API.Client.DisciplinaAPI();

                List<Nsf.App.Model.DisciplinaModel> lista = api.Listar();

                dgvDisciplinas.AutoGenerateColumns = false;
                dgvDisciplinas.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvDisciplinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                if (e.ColumnIndex == 4)
                {
                    Model.DisciplinaModel disciplina = dgvDisciplinas.CurrentRow.DataBoundItem as Model.DisciplinaModel;

                    Nsf.App.Model.DisciplinaModel model = new Model.DisciplinaModel();


                    model.IdDisciplina = disciplina.IdDisciplina;
                    model.NmDisciplina = disciplina.NmDisciplina;
                    model.DsSigla = disciplina.DsSigla;
                    model.DtInclusao = disciplina.DtInclusao;
                    model.DtUltimaAlteracao = disciplina.DtUltimaAlteracao;
                    model.BtAtivo = disciplina.BtAtivo;

                    frmDisciplinasCadastrar tela = new frmDisciplinasCadastrar();

                    frmInicial.Current.OpenScreen(tela);
                    tela.CarregarCampos(model);
                }

                if (e.ColumnIndex == 5)
                {
                    Model.DisciplinaModel disciplina = dgvDisciplinas.CurrentRow.DataBoundItem as Model.DisciplinaModel;

                    Nsf.App.Model.DisciplinaModel model = new Model.DisciplinaModel();


                    DialogResult res = MessageBox.Show("Deseja remover essa disciplina?", "Remover",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        Nsf.App.API.Client.DisciplinaAPI api = new Nsf.App.API.Client.DisciplinaAPI();

                        api.Remover(disciplina.IdDisciplina);

                        MessageBox.Show("Removido com Sucesso");
                    }
                    Carregar();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvDisciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}