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

        App.API.Client.InscricaoAPI InscricaoAPI = new App.API.Client.InscricaoAPI();

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
            try
            {
               // dgvCandidatos.AutoGenerateColumns = false;
                dgvCandidatos.DataSource = InscricaoAPI.ConsultarTodos();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Matrículas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
            }
        }
    }
}