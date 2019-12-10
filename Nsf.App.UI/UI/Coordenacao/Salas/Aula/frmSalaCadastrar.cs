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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador", "NSF",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        public void inserir(Model.SalaModel sala)
        {
            try
            {
                sala.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
                sala.BtAtivo = Convert.ToBoolean(chkAtivo.Checked);
                sala.NmLocal = cboInstituicao.Text;
                sala.NmSala = txtSala.Text;

                Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
                api.inserir(sala);

                MessageBox.Show("Cadastrado com sucesso", "NSF",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador", "NSF",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
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
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador", "NSF",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        public void CarregarCampos(Model.SalaModel model)
        {
            try
            {
                nudCapacidade.Text = model.NrCapacidadeMaxima.ToString();
                lblId.Text = model.IdSala.ToString();
                cboInstituicao.Text = model.NmLocal;
                chkAtivo.Checked = model.BtAtivo;
                txtSala.Text = model.NmSala;
                panelId.Visible = true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF");
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador", "NSF", 
                           MessageBoxButtons.OK, 
                           MessageBoxIcon.Error);
            }
        }
    }
}
  