using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

using System.Linq.Expressions;

namespace Nsf.App.UI
{
    public partial class frmDisciplinasCadastrar : NsfUserScreen
    {
        
        public frmDisciplinasCadastrar()
        {
            InitializeComponent();
        }

        Model.DisciplinaModel disciplina;


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (disciplina != null && disciplina.IdDisciplina > 0)
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
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.");
            }

        }
        public void Inserir()
        {
            try
            {
                disciplina = new Model.DisciplinaModel();

                disciplina.NmDisciplina = txtDisciplina.Text;
                disciplina.DsSigla = txtSigla.Text;
                disciplina.DtInclusao = System.DateTime.Now;
                disciplina.DtUltimaAlteracao = System.DateTime.Now;
                disciplina.BtAtivo = Convert.ToBoolean(chkAtivo.Checked);

                Nsf.App.API.Client.DisciplinaAPI api = new App.API.Client.DisciplinaAPI();
                disciplina = api.Inserir(disciplina);

                panelId.Visible = true;
                lblId.Text = disciplina.IdDisciplina.ToString();

                MessageBox.Show("Disciplina Inserida com sucesso.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Model.DisciplinaModel> Where(List<Model.DisciplinaModel> lista, 
                                                 Func<Model.DisciplinaModel, bool> where)
        {
            List<Model.DisciplinaModel> l = new List<Model.DisciplinaModel>();
            foreach (var item in lista)
            {
                bool b = where(item);
                if (b == true)
                    l.Add(item);
            }
            return l;
        }

        public int Somar(int a, int b)
        {
            return a + b;
        }
        
        public int Somar(int a, int b, Func<int, int, int> s)
        {
            return s(a, b);
        }

        public void Alterar()
        {

            try
            {
                disciplina.IdDisciplina = disciplina.IdDisciplina;
                disciplina.NmDisciplina = txtDisciplina.Text;
                disciplina.DsSigla = txtSigla.Text;
                disciplina.DtUltimaAlteracao = System.DateTime.Now;
                disciplina.BtAtivo = Convert.ToBoolean(chkAtivo.Checked);

                Nsf.App.API.Client.DisciplinaAPI api = new App.API.Client.DisciplinaAPI();
                api.Alterar(disciplina);

                MessageBox.Show("Disciplina Alterada com sucesso.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CarregarCampos(Model.DisciplinaModel model)
        {
            try
            {
                panelId.Visible = true;
                lblId.Text = model.IdDisciplina.ToString();
                txtDisciplina.Text = model.NmDisciplina;
                txtSigla.Text = model.DsSigla;
                model.DtUltimaAlteracao = model.DtInclusao;
                chkAtivo.Checked = model.BtAtivo;

                disciplina = model;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

   
    }

}