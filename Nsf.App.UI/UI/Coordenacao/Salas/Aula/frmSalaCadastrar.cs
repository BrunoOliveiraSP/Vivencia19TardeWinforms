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

        public void Alterar()
        {

            try
            {
                Nsf.App.Model.SalaModel sala = new Model.SalaModel();

                sala.NmSala = txtSala.Text;
                sala.NmLocal = cboInstituicao.Text;
                sala.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
                sala.BtAtivo = Convert.ToBoolean(chkAtivo.Checked);

                frmSalaCadastrar tela = new frmSalaCadastrar();

                frmInicial.Current.OpenScreen(tela);
                tela.CarregarCampos(sala);



                MessageBox.Show("Sala Alterada com sucesso.");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Erro Grave Renicie Esta Maquina");
            }
        }
        public void CarregarCampos(Model.SalaModel model)
        {
            try
            {
                Model.SalaModel sala = new Model.SalaModel();
                panelId.Visible = true;


                txtSala.Text = sala.NmSala;
                cboInstituicao.Text = sala.NmLocal;
                nudCapacidade.Value = sala.NrCapacidadeMaxima;
                chkAtivo.Checked = sala.BtAtivo;

            }
            catch (ArgumentException)
            {
                MessageBox.Show("Erro Grave Rencie A Maquina");
            }
        }
    }
}