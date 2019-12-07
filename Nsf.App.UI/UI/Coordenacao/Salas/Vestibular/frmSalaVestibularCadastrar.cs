using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmSalaVestibularCadastrar : NsfUserScreen
    {
        public frmSalaVestibularCadastrar()
        {
            InitializeComponent();
         
        }

        private void frmSalaVestibularCadastrar_Load(object sender, EventArgs e)
        {
            this.ListarTudo();
        }

        public void ListarTudo()
        {
            Nsf.App.API.Client.SalaVestibularAPI api = new App.API.Client.SalaVestibularAPI();
            List<Model.SalaVestibularModel> consultar = api.listarTudo();

            dgvSalasVestibular.AutoGenerateColumns = false;
            dgvSalasVestibular.DataSource = consultar;

        }

        private void btnVestibularBaixo_Click(object sender, EventArgs e)
        {

        }

        private void btnVestibularAdd_Click(object sender, EventArgs e)
        {
            Model.SalaVestibularModel vestibularr = new Model.SalaVestibularModel();

            vestibularr.NmLocal = cboVestibularInstituicao.Text;
            vestibularr.DsPeriodo = cboPeriodos.Text;
            vestibularr.NmSala = cboVestibularSala.Text;

            Nsf.App.API.Client.SalaVestibularAPI api = new App.API.Client.SalaVestibularAPI();
            api.Inserir(vestibularr);

            MessageBox.Show("Inserido com sucesso", "API");
        }

        private void dgvSalasVestibular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                  Model.SalaVestibularModel teste = dgvSalasVestibular.CurrentRow.DataBoundItem as Model.SalaVestibularModel;

                    cboPeriodos.Text = teste.DsPeriodo;
                    cboVestibularInstituicao.Text = teste.NmLocal;
                    cboVestibularSala.Text = teste.NmSala;

                DialogResult resp = MessageBox.Show("Deseja realmente fazer uma alteração?", "API", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {

                    teste.NmLocal = cboVestibularInstituicao.Text;
                    teste.NmSala = cboVestibularSala.Text;
                    teste.DsPeriodo = cboPeriodos.Text;

                    Nsf.App.API.Client.SalaVestibularAPI api = new App.API.Client.SalaVestibularAPI();
                    api.Alterar(teste);

                    MessageBox.Show("Alterado com sucesso", "API");

                }

            }
            if (e.ColumnIndex == 6)
            {
                Model.SalaVestibularModel teste = dgvSalasVestibular.CurrentRow.DataBoundItem as Model.SalaVestibularModel;

                DialogResult resp = MessageBox.Show("Deseja realmente excluir este dado?", "API", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {

               
                    Nsf.App.API.Client.SalaVestibularAPI api = new App.API.Client.SalaVestibularAPI();
                    api.Remover(teste.IdSalaVestibular);

                    MessageBox.Show("Excluido com sucesso", "API");

                }

            }
        }
    }
}