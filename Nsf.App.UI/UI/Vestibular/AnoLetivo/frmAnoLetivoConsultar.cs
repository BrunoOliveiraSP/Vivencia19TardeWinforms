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

        public void Carregar()
        {
            Nsf.App.API.Client.AnoLetivoApi api = new App.API.Client.AnoLetivoApi();
            List<Model.AnoLetivoModel> lista = api.ListarTodos();

            dgvAnosLetivos.AutoGenerateColumns = false;
            dgvAnosLetivos.DataSource = lista;
        }

        private void dgvAnosLetivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void  CarregarGrid()
        {
            frmAnoLetivoCadastrar listar = new frmAnoLetivoCadastrar();
           // List<Model.AnoLetivoModel> list =  listar.CarregarGrid();
        }

       
    }
}