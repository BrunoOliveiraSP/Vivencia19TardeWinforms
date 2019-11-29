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
            API.AnoLetivoApi api = new API.AnoLetivoApi();
            List<Models.AnoLetivoModel> lista = api.ListarTodos();

            dgvAnosLetivos.AutoGenerateColumns = false;
            dgvAnosLetivos.DataSource = lista;
        }
    }
}