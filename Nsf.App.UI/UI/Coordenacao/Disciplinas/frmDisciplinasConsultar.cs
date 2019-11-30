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

        private void frmDisciplinasConsultar_Load(object sender, EventArgs e)
        {

        }

 
    }
}