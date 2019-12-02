using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmCursoCadastrar : NsfUserScreen
    {
        BindingList<Model.DisciplinaModel> lista = new BindingList<Model.DisciplinaModel>();
        BindingList<Model.DisciplinaModel> atribuidas = new BindingList<Model.DisciplinaModel>();

        public frmCursoCadastrar()
        {
            InitializeComponent();
            CarregarDisciplinas();

            lbxDisciplinasDoCurso.DataSource = atribuidas;
            lbxDisciplinasDoCurso.DisplayMember = nameof(Model.DisciplinaModel.NmDisciplina);
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

        BindingList<Model.DisciplinaModel> disciplinas;
        public void CarregarDisciplinas()
        {
            App.API.Client.DisciplinaAPI API = new App.API.Client.DisciplinaAPI();
            lista = API.Listar();

            lbxDisciplinasDisponiveis.DisplayMember = nameof(Model.DisciplinaModel.NmDisciplina);
            lbxDisciplinasDisponiveis.SelectedValue = nameof(Model.DisciplinaModel.IdDisciplina);

            lbxDisciplinasDisponiveis.DataSource = lista;
         
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Model.DisciplinaModel mod = lbxDisciplinasDisponiveis.SelectedItem as Model.DisciplinaModel;

                if(mod == null)
                {
                    throw new ArgumentException("Selecione uma disciplina para adicionar ao curso");
                }

                atribuidas.Add(mod);
                lista.Remove(mod);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Model.DisciplinaModel mod = lbxDisciplinasDoCurso.SelectedItem as Model.DisciplinaModel;

                if (mod == null)
                {
                    throw new ArgumentException("Selecione uma disciplina para remover do curso");
                }

                atribuidas.Remove(mod);
                lista.Add(mod);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}