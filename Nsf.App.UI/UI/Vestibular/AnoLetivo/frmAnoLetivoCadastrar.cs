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

        int id = 0;

        public void CarregarTela(Model.AnoLetivoModel model)
        {
           ulong botaoAberto = Convert.ToUInt32(rdnAberto.Checked);

            id = model.IdAnoLetivo;
            nudAno.Value = model.NrAno;
            dtpInicio.Value = model.DtInicio;
            dtpFim.Value = model.DtFim;
            cboStatus.Text = model.TpStatus;
            botaoAberto = model.BtAtivo;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Model.AnoLetivoModel add = new Model.AnoLetivoModel();
            add.NrAno = Convert.ToInt32(nudAno.Value);
            add.DtInicio = dtpInicio.Value;
            add.DtFim = dtpFim.Value;
            add.TpStatus = cboStatus.Text;
            add.BtAtivo = Convert.ToUInt32(rdnAberto.Checked);

            Nsf.App.API.Client.AnoLetivoApi api = new App.API.Client.AnoLetivoApi();
           
            if(id > 0)
            {
                add.IdAnoLetivo = id;
                api.Alterar(add);

                MessageBox.Show("Alterado com sucesso.");
            }
            else
            {
                api.CadastrarAnoLetivo(add);

                MessageBox.Show("Cadastrado com sucesso.");

                UI.frmAnoLetivoConsultar tela = new frmAnoLetivoConsultar();
                tela.Show();
                this.Hide();
            }

        }

      

    }
}