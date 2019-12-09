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
		}

        private void dgvCandidatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 9)
            {
                Nsf.App.API.Client.MatriculaAPI api = new App.API.Client.MatriculaAPI();

                Model.MatriculaRequest matricula = 

                api.Deletar()
            }
        }
    }
}