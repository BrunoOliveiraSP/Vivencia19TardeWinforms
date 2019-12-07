using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmAnoLetivoConsultar : NsfUserScreen
    {
        public frmAnoLetivoConsultar()
        {
            InitializeComponent();
            Carregar();
        }

        Nsf.App.API.Client.AnoLetivoApi api = new App.API.Client.AnoLetivoApi();

        public void Carregar()
        {
            List<Model.AnoLetivoModel> lista = api.ListarTodos();

            dgvAnosLetivos.AutoGenerateColumns = false;
            dgvAnosLetivos.DataSource = lista;
        }

        private void dgvAnosLetivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Model.AnoLetivoModel model = dgvAnosLetivos.CurrentRow.DataBoundItem as Model.AnoLetivoModel;

                Nsf.App.UI.frmAnoLetivoCadastrar tela = new frmAnoLetivoCadastrar();

                tela.CarregarTela(model);

                frmInicial.Current.OpenScreen(tela);

                Hide();
            }

            if (e.ColumnIndex == 5)
            {
                Model.AnoLetivoModel model = dgvAnosLetivos.CurrentRow.DataBoundItem as Model.AnoLetivoModel;

                DialogResult r = MessageBox.Show("Deseja Remover?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    Nsf.App.API.Client.AnoLetivoApi api = new App.API.Client.AnoLetivoApi();

                    api.Remover(model.IdAnoLetivo);
                    MessageBox.Show("Removido com sucesso");
                }
            }
        }

        private void dgvAnosLetivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

   

       
    