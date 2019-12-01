using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmAnoLetivoCadastrar : NsfUserScreen
    {
        public frmAnoLetivoCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Model.AnoLetivoModel add = new Model.AnoLetivoModel();
            add.NrAno = Convert.ToInt32(nudAno.Value);
            add.DtInicio = dtpInicio.Value;
            add.DtFim = dtpFim.Value;
            add.TpStatus = cboStatus.Text;
            add.BtAtivo = Convert.ToUInt32(rdnAberto.Checked);

            Nsf.App.API.Client.AnoLetivoApi Add = new App.API.Client.AnoLetivoApi();
            Add.CadastrarAnoLetivo(add);

            MessageBox.Show("Cadastro realizado com sucesso.");
            UI.frmAnoLetivoConsultar tela = new frmAnoLetivoConsultar();
            tela.Show();
            this.Hide();
        }

        public void CarregarGrid(Model.AnoLetivoModel carregar)
        {
            Model.AnoLetivoModel add = new Model.AnoLetivoModel();
            add.NrAno = Convert.ToInt32(nudAno.Value);
            add.DtInicio = dtpInicio.Value;
            add.DtFim = dtpFim.Value;
            add.TpStatus = cboStatus.Text;
            add.BtAtivo = Convert.ToUInt32(rdnAberto.Checked);
        }
    }
}