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
            int id = Convert.ToInt32(lblId.Text);

            if (id > 0)
            {
                Nsf.App.Model.CursoModel curso = new Model.CursoModel();
                curso.NmCurso = txtCurso.Text;
                curso.BtAtivo = chkAtivo.Checked;
                curso.DtCriacao = System.DateTime.Now;
                curso.DtUltimaAlteracao = System.DateTime.Now;
                curso.DsCategoria = cboCategoria.Text;
                curso.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
                curso.DsSigla = txtSigla.Text;

                API.CursoAPI api = new API.CursoAPI();
                api.Alterar(curso);

                MessageBox.Show("Curso alterado com sucesso.");
            }
            else
            {
                Nsf.App.Model.CursoModel curso = new Model.CursoModel();

                curso.NmCurso = txtCurso.Text;
                curso.BtAtivo = chkAtivo.Checked;
                curso.DtCriacao = System.DateTime.Now;
                curso.DtUltimaAlteracao = System.DateTime.Now;
                curso.DsCategoria = cboCategoria.Text;
                curso.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
                curso.DsSigla = txtSigla.Text;

                API.CursoAPI api = new API.CursoAPI();
                api.Inserir(curso);

                MessageBox.Show("Curso registrado com sucesso.");
            }


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

        public void AlterarInformacao(Model.CursoModel curso)
        {
            lblId.Text = Convert.ToString(curso.IdCurso);
            txtCurso.Text = curso.NmCurso;
            chkAtivo.Checked = curso.BtAtivo;
            cboCategoria.Text =  curso.DsCategoria;
            nudCapacidade.Value = curso.NrCapacidadeMaxima;
            txtSigla.Text = curso.DsSigla;
        }

    }
}