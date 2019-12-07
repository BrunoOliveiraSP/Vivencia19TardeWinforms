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
            try
            {
                Model.SalaModel sala = new Model.SalaModel();

                if (sala.IdSala == 0)
                {
                    sala.NmSala = txtSala.Text;
                    sala.NmLocal = cboInstituicao.Text;
                    sala.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
                    sala.BtAtivo = Convert.ToBoolean(chkAtivo.Checked);
                    Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
                    api.inserir(sala);

                    MessageBox.Show("Cadastrado com sucesso");
                }
                else if (sala.IdSala > 0)
                {
                    this.Alterar(sala);
                }
            }
            catch (ArgumentException ex)
            { 

                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }      
        }

        public void Alterar(Model.SalaModel sala)
        {
            try
            {
                            
                sala.NmSala = txtSala.Text;
                sala.NmLocal = cboInstituicao.Text;
                sala.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
                sala.BtAtivo = Convert.ToBoolean(chkAtivo.Checked);

                frmSalaCadastrar tela = new frmSalaCadastrar();

                frmInicial.Current.OpenScreen(tela);
                tela.CarregarCampos(sala);

                Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
                api.alterar(sala);

                MessageBox.Show("Alterado com sucesso", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF");
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", 
                           MessageBoxButtons.OK, 
                           MessageBoxIcon.Error);
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
            catch
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador", "NSF", 
                           MessageBoxButtons.OK, 
                           MessageBoxIcon.Error);
            }
        }
    }
}