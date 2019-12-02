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
    }
}