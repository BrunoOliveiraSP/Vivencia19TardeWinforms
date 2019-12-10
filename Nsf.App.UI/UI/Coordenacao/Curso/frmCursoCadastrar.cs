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
           

           
            lbxDisciplinasDoCurso.DisplayMember = nameof(Model.DisciplinaModel.NmDisciplina);
        }

        int idcurso = 0;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int idCursoCondicao = Convert.ToInt32(lblID.Text);
            string lbxDisciplinaCurso = Convert.ToString(lbxDisciplinasDoCurso.DataSource);
          
            if (lbxDisciplinaCurso == null || lbxDisciplinaCurso == "")
            {
                tabControl1.SelectedTab = tabPage2;
                MessageBox.Show("A atribuição de disciplinas ao curso é obrigatória", "Exigencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            else if (idCursoCondicao == 0 ) 
            {
                try
                {
                    Model.CursoModel curso = new Model.CursoModel();

                    curso.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
                    curso.DtUltimaAlteracao = System.DateTime.Now;
                    curso.DtCriacao = System.DateTime.Now;
                    curso.DsCategoria = cboCategoria.Text;
                    curso.BtAtivo = chkAtivo.Checked;
                    curso.NmCurso = txtCurso.Text;
                    curso.DsSigla = txtSigla.Text;

                    API.Client.CursoAPI api = new API.Client.CursoAPI();
                    idcurso = api.Inserir(curso);

                    panelId.Visible = true;
                    lblID.Text = Convert.ToString(idcurso);

                    InserirCursoDiciplina();

                    MessageBox.Show("Curso registrado com sucesso.","Processo com exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Exigencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Entre em contato com o desenvolvedor do programa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                try
                {
                   
                    Nsf.App.Model.CursoModel curso = new Model.CursoModel();

                    int idCurso = Convert.ToInt32(lblID.Text);

                    curso.NrCapacidadeMaxima = Convert.ToInt32(nudCapacidade.Value);
                    curso.DtUltimaAlteracao = System.DateTime.Now;
                    curso.IdCurso = Convert.ToInt32(lblID.Text);
                    curso.DsCategoria = cboCategoria.Text;
                    curso.DtCriacao = System.DateTime.Now;
                    curso.BtAtivo = chkAtivo.Checked;
                    curso.NmCurso = txtCurso.Text;
                    curso.DsSigla = txtSigla.Text;


                    API.Client.CursoAPI api = new API.Client.CursoAPI();
                    api.Alterar(curso);
                    
                    AlterarDisciplinaDoCurso();

                   DialogResult r = MessageBox.Show("Curso alterado com sucesso; deseja cadastrar um curso?","Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if(r == DialogResult.No)
                    {
                        frmInicial.Current.OpenScreen(new frmCursoConsultar());
                    }
                    else
                    {
                        frmInicial.Current.OpenScreen(new frmCursoCadastrar());
                    }
                    

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Exigencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception )
                {
                    MessageBox.Show("Entre em contato com o desenvolvedor do programa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }



        BindingList<Model.DisciplinaModel> disciplinas;
        public void CarregarDisciplinas()
        {
            App.API.Client.DisciplinaAPI API = new App.API.Client.DisciplinaAPI();

            if (idcurso > 0)
            {
                atribuidas = API.ListarCursoDisciplina(idcurso);

                lbxDisciplinasDoCurso.DataSource = atribuidas;
                
                lista = API.Listar();
                lbxDisciplinasDisponiveis.DataSource = lista;
                lbxDisciplinasDisponiveis.DisplayMember = nameof(Model.DisciplinaModel.NmDisciplina);

                foreach (var item in atribuidas)
                {
                    var remover = lista.FirstOrDefault(x => x.IdDisciplina == item.IdDisciplina);
                    if (remover != null)
                        lista.Remove(remover);
                }
            }
            else
            {
                lista = API.Listar();

                lbxDisciplinasDisponiveis.DisplayMember = nameof(Model.DisciplinaModel.NmDisciplina);
                lbxDisciplinasDisponiveis.SelectedValue = nameof(Model.DisciplinaModel.IdDisciplina);

                lbxDisciplinasDisponiveis.DataSource = lista;
            }
         
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

                foreach (var item in atribuidas)
                {
                    if (item.NmDisciplina == mod.NmDisciplina)
                        throw new ArgumentException("A disciplina já foi atribuida");
                }
                atribuidas.Add(mod);
                lista.Remove(mod);

                lbxDisciplinasDoCurso.DataSource = atribuidas;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception )
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AlterarInformacao(Model.CursoModel curso)
        {
            panelId.Visible = true;

            idcurso = curso.IdCurso;

            lblID.Text = Convert.ToString(curso.IdCurso);
            txtCurso.Text = curso.NmCurso;
            chkAtivo.Checked = curso.BtAtivo;
            cboCategoria.Text =  curso.DsCategoria;
            nudCapacidade.Value = curso.NrCapacidadeMaxima;
            txtSigla.Text = curso.DsSigla;

            CarregarCursoDisciplina();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
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
                mod.NrCargaHoraria = 1200;

                api.InserirCursoDisciplina(mod);
            }

        }
        public void CarregarCursoDisciplina()
        {
           
        }
        public void AlterarDisciplinaDoCurso()
        {
            Model.CursoDisciplinaModel mod = new Model.CursoDisciplinaModel();
            Nsf.App.API.Client.DisciplinaAPI api = new App.API.Client.DisciplinaAPI();
            
            api.RemoverCursoDisciplina(idcurso);

            if(cboCategoria.Text == "Selecione")
            {
                throw new ArgumentException("A categoria do curso é obrigatória");
            }
            else if (cboCategoria.Text == "Livre")
            {
                mod.NrCargaHoraria = 0;
            }
            else if (cboCategoria.Text == "Técnico")
            {
                mod.NrCargaHoraria = 1200;
            }
            else if (cboCategoria.Text == "Qualificação")
            {
                mod.NrCargaHoraria = 160; 
            }

            

            foreach (Model.DisciplinaModel item in atribuidas)
            {
                mod.IdCurso = idcurso;
                mod.IdDisciplina = item.IdDisciplina;

               api.InserirCursoDisciplina(mod);
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if( e.TabPage == tabPage2 )
            {
                CarregarDisciplinas();
            }
        }
    }
}