using System;
using System.Windows.Forms;

namespace Nsf.App.UI
{
	public partial class frmSalaCadastrar : NsfUserScreen
	{
		public frmSalaCadastrar()
		{
			InitializeComponent();
		}

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Model.SalaModel sala = new Model.SalaModel();

            sala.NmSala = txtSala.Text;
            sala.NmLocal = cboInstituicao.Text;
            sala.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
            sala.BtAtivo = Convert.ToBoolean(chkAtivo.Checked);
            Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
            api.inserir(sala);

            MessageBox.Show("Cadastrado com sucesso");
        }
    }
}