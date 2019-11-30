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
        }

        private void cboAnoLetivo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CarregarGrid()
        {
            try
            {
                dgvCandidatos.AutoGenerateColumns = false;
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

        private void dgvCandidatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}