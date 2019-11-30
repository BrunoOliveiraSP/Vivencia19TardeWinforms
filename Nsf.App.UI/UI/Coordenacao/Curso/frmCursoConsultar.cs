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

        private void txtCurso_TextChanged(object sender, EventArgs e)
        {
            Nsf.App.UI.API.CursoAPI curso = new API.CursoAPI();
            List<Nsf.App.Model.CursoModel> lista = curso.ConsultarPorCurso();

            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = lista;
        }

        private void txtSigla_TextChanged(object sender, EventArgs e)
        {
            Nsf.App.UI.API.CursoAPI curso = new API.CursoAPI();
            List<Nsf.App.Model.CursoModel> lista = curso.ConsultarPorSigla();

            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = lista;
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
    }
}