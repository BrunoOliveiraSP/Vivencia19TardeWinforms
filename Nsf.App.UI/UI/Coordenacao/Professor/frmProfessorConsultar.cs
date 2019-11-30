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
		}

        private void ListarPorNome()
        {
            ProfessorAPI api = new ProfessorAPI();
            List<ProfessorModel> list = api.ListarPorNome(txtNome.Text);
            dgvProfessores.DataSource = list;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            this.ListarPorNome();
        }
    }
}