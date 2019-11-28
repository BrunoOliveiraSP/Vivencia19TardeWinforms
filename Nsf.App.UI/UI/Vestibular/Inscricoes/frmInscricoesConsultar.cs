using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nsf.App.UI
{
	public partial class frmInscricoesConsultar : NsfUserScreen
	{
		public frmInscricoesConsultar()
		{
			InitializeComponent();
            CarregarGrid();
		}

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNome.Text))
            {

            }

            else if(string.IsNullOrWhiteSpace(cboAnoLetivo.Text))
            {

            }
            else
            {

            }
        }

        private void cboAnoLetivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {

            }

            else if (string.IsNullOrWhiteSpace(cboAnoLetivo.Text))
            {

            }
            else
            {

            }
        }

        private void CarregarGrid()
        {

        }
    }
}