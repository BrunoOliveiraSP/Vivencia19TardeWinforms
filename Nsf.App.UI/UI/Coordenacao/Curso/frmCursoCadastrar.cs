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

        int idcurso = 0;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                /*if (id > 0)
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
                }*/

                Nsf.App.Model.CursoModel curso = new Model.CursoModel();

                curso.NmCurso = txtCurso.Text;
                curso.BtAtivo = chkAtivo.Checked;
                curso.DtCriacao = System.DateTime.Now;
                curso.DtUltimaAlteracao = System.DateTime.Now;
                curso.DsCategoria = cboCategoria.Text;
                curso.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
                curso.DsSigla = txtSigla.Text;

                API.CursoAPI api = new API.CursoAPI();
                idcurso = api.Inserir(curso);

                //InserirCursoDiciplina(); --erro de chave estrangeira(banco não consegue achar o id da outra tabela


                MessageBox.Show("Curso registrado com sucesso.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            


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

        public void AlterarInformacao(Model.CursoModel curso)
        {
            panelId.Visible = true;

            idcurso = curso.IdCurso;

            nudID.Text = Convert.ToString(curso.IdCurso);
            txtCurso.Text = curso.NmCurso;
            chkAtivo.Checked = curso.BtAtivo;
            cboCategoria.Text =  curso.DsCategoria;
            nudCapacidade.Value = curso.NrCapacidadeMaxima;
            txtSigla.Text = curso.DsSigla;

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (nudID.Value == 0)
                {
                    btnAlterar.Enabled = false;
                }
                else
                {
                    Nsf.App.Model.CursoModel curso = new Model.CursoModel();

                    curso.IdCurso = Convert.ToInt32(nudID.Text);
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

                    //frmInicial.Current.OpenScreen(telaConsultar);
                    // telaConsultar.AlterarInformacao(model);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
        public void InserirCursoDiciplina()
        {
            Model.CursoDisciplinaModel mod = new Model.CursoDisciplinaModel();

            Nsf.App.API.Client.DisciplinaAPI api = new App.API.Client.DisciplinaAPI();

            foreach (var item in atribuidas)
            {
                mod.IdDisciplina = item.IdDisciplina;
                mod.IdCurso = idcurso;

                api.InserirCursoDisciplina(mod);
            }

        }
        public void CarregarCursoDisciplina()
        {
            Nsf.App.API.Client.DisciplinaAPI api = new App.API.Client.DisciplinaAPI();
            atribuidas = api.ListarCursoDisciplina(idcurso);

            
        }
        public void AlterarDisciplinaDoCurso()
        {
            Model.CursoDisciplinaModel mod = new Model.CursoDisciplinaModel();
            Nsf.App.API.Client.DisciplinaAPI api = new App.API.Client.DisciplinaAPI();

            foreach (var item in atribuidas)
            {
                mod.IdDisciplina = item.IdDisciplina;
                mod.IdCurso = idcurso;

                api.AlterarCursoDisciplina(mod);

            }
        }
    
    }
}