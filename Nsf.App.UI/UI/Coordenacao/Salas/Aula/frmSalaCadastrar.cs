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
        frmSalaConsultar tela = new frmSalaConsultar();
       
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Model.SalaModel sala = new Model.SalaModel();

                if (Convert.ToInt32(lblId.Text) == 0)
                {
                    tela.Consultar();
                    this.inserir(sala);
                }
                else if (Convert.ToInt32(lblId.Text) > 0)
                {
                    tela.Consultar();
                    this.Alterar(sala);
                }
                
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message);
            }
            tela.Consultar();
        }
        public void inserir(Model.SalaModel sala)
        {

            sala.NmSala = txtSala.Text;
            sala.NmLocal = cboInstituicao.Text;
            sala.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
            sala.BtAtivo = Convert.ToBoolean(chkAtivo.Checked);
            Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
            api.inserir(sala);

            MessageBox.Show("Cadastrado com sucesso");

        }

        public void Alterar(Model.SalaModel sala)
        {
            try
            {
                sala.IdSala = Convert.ToInt32(lblId.Text);
                sala.NmSala = txtSala.Text;
                sala.NmLocal = cboInstituicao.Text;
                sala.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
                sala.BtAtivo = Convert.ToBoolean(chkAtivo.Checked);

                frmSalaCadastrar tela = new frmSalaCadastrar();

                frmInicial.Current.OpenScreen(tela);
                tela.CarregarCampos(sala);

                Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
                api.Alterar(sala);

                MessageBox.Show("Alterado com sucesso", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF");
            }

        }
        public void CarregarCampos(Model.SalaModel model)
        {
            try
            {
                panelId.Visible = true;
                lblId.Text = model.IdSala.ToString();
                txtSala.Text = model.NmSala;
                cboInstituicao.Text = model.NmLocal;
                nudCapacidade.Text = model.NrCapacidadeMaxima.ToString();
                chkAtivo.Checked = model.BtAtivo;

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmSalaCadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}