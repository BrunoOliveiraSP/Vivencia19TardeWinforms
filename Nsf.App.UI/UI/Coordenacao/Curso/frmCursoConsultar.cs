﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmCursoConsultar : NsfUserScreen
    {
        public frmCursoConsultar()
        {
            InitializeComponent();
            this.Carregar();
        }

        public void txtCurso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string nmcurso = txtCurso.Text;
                if(nmcurso == string.Empty)
                {
                    this.Carregar();
                }
                else
                {
                    Nsf.App.UI.API.CursoAPI curso = new API.CursoAPI();
                    List<Nsf.App.Model.CursoModel> lista = curso.ConsultarPorCurso(nmcurso);

                    dgvCursos.AutoGenerateColumns = false;
                    dgvCursos.DataSource = lista;
                }
                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

          private void txtSigla_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sigla = txtSigla.Text;
                
                if(sigla == string.Empty)
                {
                    this.Carregar();
                }
                else
                {
                    Nsf.App.UI.API.CursoAPI curso = new API.CursoAPI();
                    List<Nsf.App.Model.CursoModel> lista = curso.ConsultarPorSigla(sigla);

                    dgvCursos.AutoGenerateColumns = false;
                    dgvCursos.DataSource = lista;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Carregar()
        {
            Nsf.App.UI.API.CursoAPI curso = new API.CursoAPI();
            List<Nsf.App.Model.CursoModel> lista = curso.ConsultarTodos();

            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = lista;
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {

                    frmCursoCadastrar telaCadastrar = new frmCursoCadastrar();

                    Nsf.App.Model.CursoModel curso = dgvCursos.CurrentRow.DataBoundItem as Nsf.App.Model.CursoModel;

                    Model.CursoModel mod = new Model.CursoModel();

                    mod.IdCurso = Convert.ToInt32(curso.IdCurso);
                    mod.NmCurso = curso.NmCurso;
                    mod.BtAtivo = curso.BtAtivo;
                    mod.DsCategoria= curso.DsCategoria;
                    mod.NrCapacidadeMaxima = Convert.ToInt32(curso.NrCapacidadeMaxima);
                    mod.DsSigla = curso.DsSigla;

                    telaCadastrar.AlterarInformacao(mod);

                    frmInicial.Current.OpenScreen(telaCadastrar);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                if (e.ColumnIndex == 6)
                {
                    Model.CursoModel curso = dgvCursos.CurrentRow.DataBoundItem as Model.CursoModel;

                    DialogResult r = MessageBox.Show("Deseja remover?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        API.CursoAPI api = new API.CursoAPI();
                        api.Remover(curso.IdCurso);

                        MessageBox.Show("Removido com sucesso");
                        Carregar();
                    }

                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void frmCursoConsultar_Load(object sender, EventArgs e)
        {

        }
    }
}