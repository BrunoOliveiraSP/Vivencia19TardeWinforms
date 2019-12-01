using System;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmDisciplinasCadastrar : NsfUserScreen
    {
        
        public frmDisciplinasCadastrar()
        {
            InitializeComponent();
           
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblId.Text);

                if (id > 0)
                {
                    Alterar();
                }
                else
                {
                    Inserir();
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Inserir()
        {
            try
            {
                Nsf.App.Model.DisciplinaModel model = new Model.DisciplinaModel();

                model.NmDisciplina = txtDisciplina.Text;
                model.DsSigla = txtSigla.Text;
                model.DtInclusao = dtpinclusao.Value;
                model.DtUltimaAlteracao = System.DateTime.Now;
                model.BtAtivo = Convert.ToBoolean(chkAtivo.Checked);

                Nsf.App.API.Client.DisciplinaAPI api = new App.API.Client.DisciplinaAPI();
                api.Inserir(model);

                MessageBox.Show("Disciplina Inserida com sucesso.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public void Alterar()
        {
            Nsf.App.Model.DisciplinaModel model = new Model.DisciplinaModel();

            model.IdDisciplina = Convert.ToInt32(lblId.Text);
            model.NmDisciplina = txtDisciplina.Text;
            model.DsSigla = txtSigla.Text;
            model.DtInclusao = dtpinclusao.Value;
            model.DtUltimaAlteracao = System.DateTime.Now;
            model.BtAtivo = Convert.ToBoolean(chkAtivo.Checked);

            Nsf.App.API.Client.DisciplinaAPI api = new App.API.Client.DisciplinaAPI();
            api.Alterar(model);

            MessageBox.Show("Disciplina Alterada com sucesso.");
        }
        public void CarregarCampos(Model.DisciplinaModel model)
        {
                panelId.Visible = true;

                lblId.Text = model.IdDisciplina.ToString();
                txtDisciplina.Text = model.NmDisciplina;
                txtSigla.Text = model.DsSigla;
                dtpinclusao.Value = model.DtInclusao;
                model.DtUltimaAlteracao = model.DtInclusao;
                chkAtivo.Checked = model.BtAtivo;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
       

      
    }

}