using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nsf.App.UI
{
	public partial class frmSalaConsultar : NsfUserScreen
	{
		public frmSalaConsultar()
		{
			InitializeComponent();
		}

        public void Consultar()
        {
            try
            {
                Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
                List<Model.SalaModel> teste = api.ListarTudo();

                DataGridSalas.AutoGenerateColumns = false;
                DataGridSalas.DataSource = teste;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }

        }

        private void frmSalaConsultar_Load(object sender, EventArgs e)
        {
            this.Consultar();

        }

        private void DataGridSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    Model.SalaModel teste = DataGridSalas.CurrentRow.DataBoundItem as Model.SalaModel;

                    DialogResult resp = MessageBox.Show("Deseja realmente excluir este dado?", "NSF", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
                        api.Remover(teste.IdSala);

                        MessageBox.Show("Removido com sucesso!", "NSF");

                        this.Consultar();
                    }
                }

                if (e.ColumnIndex == 4)
                {
                    Model.SalaModel sala = DataGridSalas.CurrentRow.DataBoundItem as Model.SalaModel;

                    Nsf.App.Model.SalaModel model = new Model.SalaModel();

                    model.NrCapacidadeMaxima = sala.NrCapacidadeMaxima;
                    model.DtAlteracao = sala.DtAlteracao;
                    model.DtInclusao = sala.DtInclusao;
                    model.NmLocal = sala.NmLocal;
                    model.BtAtivo = sala.BtAtivo;
                    model.IdSala = sala.IdSala;
                    model.NmSala = sala.NmSala;

                    Consultar();

                    frmSalaCadastrar tela = new frmSalaCadastrar();

                    frmInicial.Current.OpenScreen(tela);
                    tela.CarregarCampos(model);

                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        private void txtInstituicao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string insti = txtInstituicao.Text;

                Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
                List<Model.SalaModel> teste = api.ConsultaPorInstituicao(insti);

                DataGridSalas.AutoGenerateColumns = false;
                DataGridSalas.DataSource = teste;

                if (txtInstituicao.Text == String.Empty)
                {
                    this.Consultar();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }
    }
}