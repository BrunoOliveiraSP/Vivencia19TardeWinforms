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
            Nsf.App.Model.DisciplinaModel model = new Model.DisciplinaModel();


            model.NmDisciplina = txtDisciplina.Text;
            model.DsSigla = txtSigla.Text;
            model.DtInclusao = dtpinclusao.Value;
            model.BtAtivo = chkAtivo.Checked;


            Nsf.App.API.Client.DisciplinaAPI api = new App.API.Client.DisciplinaAPI();

            api.Inserir(model);

            MessageBox.Show("Disciplina Inserida com sucesso.");

        }
    }

}