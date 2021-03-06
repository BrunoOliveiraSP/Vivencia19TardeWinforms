﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmDisciplinasConsultar : NsfUserScreen
    {


        public frmDisciplinasConsultar()
        {
            InitializeComponent();

            this.Carregar();
        }

        private void txtSigla_TextChanged(object sender, EventArgs e)
        {
            this.Consultar();
        }

        private void txtDisciplina_TextChanged(object sender, EventArgs e)
        {
            this.Consultar();
        }

        public void Consultar()
        {
            try
            {
                string nome = txtDisciplina.Text.ToLower();
                string sigla = txtSigla.Text.ToLower();

                if (nome == string.Empty)
                    nome = " ";
                if (sigla == string.Empty)
                    sigla = " ";

                Nsf.App.API.Client.DisciplinaAPI api = new Nsf.App.API.Client.DisciplinaAPI();
                BindingList<Nsf.App.Model.DisciplinaModel> lista = new BindingList<Model.DisciplinaModel>();

                if (nome == " " && sigla == " ")
                {
                    lista = api.Listar();
                }
                if(nome == " " && sigla != string.Empty)
                {
                    throw new ArgumentException("Nome da disciplina é obrigatório para consulta");
                }
                else
                {
                    lista = api.Consultar(nome, sigla);
                }
                dgvDisciplinas.AutoGenerateColumns = false;
                dgvDisciplinas.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK);
            }
            catch(Exception )
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK);
            }

        }

        public void Carregar()
        {

            Nsf.App.API.Client.DisciplinaAPI api = new Nsf.App.API.Client.DisciplinaAPI();
            BindingList<Model.DisciplinaModel> lista = new BindingList<Model.DisciplinaModel>();
            lista = api.Listar();

            dgvDisciplinas.AutoGenerateColumns = false;
            dgvDisciplinas.DataSource = lista;

        }
       

        private void dgvDisciplinas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    Model.DisciplinaModel disciplina = dgvDisciplinas.CurrentRow.DataBoundItem as Model.DisciplinaModel;

                    Nsf.App.Model.DisciplinaModel model = new Model.DisciplinaModel();


                    model.IdDisciplina = disciplina.IdDisciplina;
                    model.NmDisciplina = disciplina.NmDisciplina;
                    model.DsSigla = disciplina.DsSigla;
                    model.DtInclusao = disciplina.DtInclusao;
                    model.DtUltimaAlteracao = disciplina.DtUltimaAlteracao;
                    model.BtAtivo = disciplina.BtAtivo;

                    frmDisciplinasCadastrar tela = new frmDisciplinasCadastrar();

                    frmInicial.Current.OpenScreen(tela);
                    tela.CarregarCampos(model);
                }

                if (e.ColumnIndex == 5)
                {
                    Model.DisciplinaModel disciplina = dgvDisciplinas.CurrentRow.DataBoundItem as Model.DisciplinaModel;

                    Nsf.App.Model.DisciplinaModel model = new Model.DisciplinaModel();


                    DialogResult res = MessageBox.Show("Deseja remover essa disciplina?", "Remover",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        Nsf.App.API.Client.DisciplinaAPI api = new Nsf.App.API.Client.DisciplinaAPI();

                        api.Remover(disciplina.IdDisciplina);

                        MessageBox.Show("Removido com Sucesso");
                    }
                    Carregar();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}