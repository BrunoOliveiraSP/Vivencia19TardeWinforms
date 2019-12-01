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
            CarregarDisciplinas();
        }

        List<Model.DisciplinaModel> disciplinasatribuidas;

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

        List<Model.DisciplinaModel> disciplinas;
        public void CarregarDisciplinas()
        {
            App.API.Client.DisciplinaAPI API = new App.API.Client.DisciplinaAPI();
             disciplinas = API.Listar();

            lbxDisciplinasDisponiveis.DisplayMember = nameof(Model.DisciplinaModel.NmDisciplina);
            lbxDisciplinasDisponiveis.DataSource = disciplinas;
         
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbxDisciplinasDoCurso.Items.Add(lbxDisciplinasDisponiveis.SelectedItem);
            lbxDisciplinasDisponiveis.Items.Remove(lbxDisciplinasDisponiveis.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lbxDisciplinasDoCurso.Items.Remove(lbxDisciplinasDisponiveis.SelectedItem);
            lbxDisciplinasDisponiveis.Items.Add(lbxDisciplinasDisponiveis.SelectedItem);
        }
    }
}