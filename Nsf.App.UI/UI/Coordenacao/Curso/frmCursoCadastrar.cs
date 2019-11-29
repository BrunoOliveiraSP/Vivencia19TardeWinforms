using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmCursoCadastrar : NsfUserScreen
    {
        public frmCursoCadastrar()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Nsf.App.Model.CursoModel curso = new Model.CursoModel();
            curso.NmCurso = txtCurso.Text;
            curso.BtAtivo = chkAtivo.Checked;
            curso.DsCategoria = cboCategoria.Text;
            curso.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
            curso.DsSigla = txtSigla.Text;

            API.CursoAPI api = new API.CursoAPI();
            api.Inserir(curso);

            MessageBox.Show("Curso salvo com sucesso.");

        }
    }
}