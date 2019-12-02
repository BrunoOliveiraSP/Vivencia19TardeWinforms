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

        private void dgvAnosLetivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Carregar()
        {
            Nsf.App.API.Client.AnoLetivoApi api = new App.API.Client.AnoLetivoApi();
            List<Model.AnoLetivoModel> lista = api.ListarTodos();

            dgvAnosLetivos.AutoGenerateColumns = false;
            dgvAnosLetivos.DataSource = lista;
        }

        private void dgvAnosLetivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                Model.AnoLetivoModel ano = dgvAnosLetivos.CurrentRow.DataBoundItem as Model.AnoLetivoModel;

                DialogResult r = MessageBox.Show("Deseja Remover?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Nsf.App.API.Client.AnoLetivoApi api = new App.API.Client.AnoLetivoApi();
                    api.Remover(ano.IdAnoLetivo);
                    MessageBox.Show("Removido Com Sucesso");
                    Carregar();
                }


            }
            if (e.ColumnIndex == 4)
            {
                Model.AnoLetivoModel ano = dgvAnosLetivos.CurrentRow.DataBoundItem as Model.AnoLetivoModel;
                Model.AnoLetivoModel model = new Model.AnoLetivoModel();

                model.IdAnoLetivo = ano.IdAnoLetivo;
                model.DtInicio = ano.DtInicio;
                model.DtFim = ano.DtFim;
                model.NrAno = ano.NrAno;
                model.TpStatus = ano.TpStatus;
                model.BtAtivo = ano.BtAtivo;

                frmAnoLetivoCadastrar tela = new frmAnoLetivoCadastrar();

                frmInicial.Current.OpenScreen(tela);
                tela.CarregarTela(model);
            }
        }
    }
}