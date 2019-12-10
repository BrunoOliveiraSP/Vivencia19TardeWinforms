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
            CarregarCombo();
            CarregarGrid();
        }

        API.Client.InscricaoAPI InscricaoAPI = new API.Client.InscricaoAPI();
        private void txtNome_TextChanged(object sender, EventArgs e)
       {
            try
          {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    dgvCandidatos.AutoGenerateColumns = false;
                    dgvCandidatos.DataSource = InscricaoAPI.ConsultarTodos();
                }
                else
                {
                    var func = cboAnoLetivo.SelectedItem as Model.AnoLetivoModel;
                    API.Client.InscricaoAPI inscricao = new API.Client.InscricaoAPI();
                    dgvCandidatos.AutoGenerateColumns = false;
                    dgvCandidatos.DataSource = inscricao.ConsultarNome(txtNome.Text, func.IdAnoLetivo);
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboAnoLetivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                API.Client.InscricaoAPI inscricao = new API.Client.InscricaoAPI();
                dgvCandidatos.AutoGenerateColumns = false;
                var func = cboAnoLetivo.SelectedItem as Model.AnoLetivoModel;
                dgvCandidatos.DataSource = inscricao.ConsultarNome(txtNome.Text, func.IdAnoLetivo);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
               MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarCombo()
        {
            API.Client.AnoLetivoApi anoLetivoApi = new App.API.Client.AnoLetivoApi();
            cboAnoLetivo.ValueMember = nameof(Model.AnoLetivoModel.NrAno);
            cboAnoLetivo.DataSource = anoLetivoApi.ListarTodos();
        }
        private void dgvCandidatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    Model.InscricaoResponse inscricao = dgvCandidatos.CurrentRow.DataBoundItem as Model.InscricaoResponse;
                    frmInicial.Current.OpenScreen(new frmInscricoesNovo(inscricao));
                }

                if (e.ColumnIndex == 8)
                {
                    Model.InscricaoResponse inscricao = dgvCandidatos.CurrentRow.DataBoundItem as Model.InscricaoResponse;

                    DialogResult result = MessageBox.Show("Dejesa remover essa inscrição?", "NSF", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        InscricaoAPI.Remover(inscricao.IdInscricao);
                        MessageBox.Show("Inscrição removido.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(string.IsNullOrWhiteSpace(txtNome.Text))
                        {
                            CarregarGrid();
                        }
                        else
                        {
                            var func = cboAnoLetivo.SelectedItem as Model.AnoLetivoModel;
                            dgvCandidatos.AutoGenerateColumns = false;
                            dgvCandidatos.DataSource = InscricaoAPI.ConsultarNome(txtNome.Text, func.IdAnoLetivo);
                        }
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}