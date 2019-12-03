﻿using System;
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
            Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
            List<Model.SalaModel> teste = api.ListarTudo();

            DataGridSalas.AutoGenerateColumns = false;
            DataGridSalas.DataSource = teste;
        }

        private void frmSalaConsultar_Load(object sender, EventArgs e)
        {
            this.Consultar();
           
        }

        private void DataGridSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)
            {
                Model.SalaModel teste = DataGridSalas.CurrentRow.DataBoundItem as Model.SalaModel;

                DialogResult resp = MessageBox.Show("Deseja realmente excluir este dado?", "NSF", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
                    api.Remover(teste.IdSala);

                    MessageBox.Show("Removido com sucesso!","NSF");

                }
            }
        }

        private void txtInstituicao_TextChanged(object sender, EventArgs e)
        {
            string insti = txtInstituicao.Text;

            Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
            List<Model.SalaModel> teste = api.ConsultaPorInstituicao(insti);

            DataGridSalas.AutoGenerateColumns = false;
            DataGridSalas.DataSource = teste;

            if(txtInstituicao.Text == String.Empty)
            {
                this.Consultar();
            }
        }
    }
}