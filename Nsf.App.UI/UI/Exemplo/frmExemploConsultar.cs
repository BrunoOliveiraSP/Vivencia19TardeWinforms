using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmExemploConsultar : NsfUserScreen
    {
        public frmExemploConsultar()
        {
            InitializeComponent();
            Carregar();
        }

        public void Carregar()
        {
            Nsf.App.API.Client.ExemploAPI api = new Nsf.App.API.Client.ExemploAPI();
            
            List<Nsf.App.Model.ExemploModel> lista = api.Listar();

            dgvExemplo.AutoGenerateColumns = false;
            dgvExemplo.DataSource = lista;
        }

        private void txtCurso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}