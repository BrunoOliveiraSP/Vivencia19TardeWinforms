using Nsf.App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmAnoLetivoCadastrar : NsfUserScreen
    {
        public frmAnoLetivoCadastrar()
        {
            InitializeComponent();
            CarregarGrid();
            CarregarCurso();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Model.AnoLetivoModel add = new Model.AnoLetivoModel();
            add.NrAno = Convert.ToInt32(nudAno.Value);
            add.DtInicio = dtpInicio.Value;
            add.DtFim = dtpFim.Value;
            add.TpStatus = cboStatus.Text;
            add.BtAtivo = Convert.ToUInt32(rdnAberto.Checked);

            Nsf.App.API.Client.AnoLetivoApi Add = new App.API.Client.AnoLetivoApi();
            Add.CadastrarAnoLetivo(add);

            MessageBox.Show("Cadastro realizado com sucesso.");
            frmAnoLetivoConsultar tela = new frmAnoLetivoConsultar();
            tela.Show();
            this.Hide();
        }

        public void CarregarGrid(Model.AnoLetivoModel carregar)
        {
            Model.AnoLetivoModel add = new Model.AnoLetivoModel();
            add.NrAno = Convert.ToInt32(nudAno.Value);
            add.DtInicio = dtpInicio.Value;
            add.DtFim = dtpFim.Value;
            add.TpStatus = cboStatus.Text;
            add.BtAtivo = Convert.ToUInt32(rdnAberto.Checked);
        }

        private void btnTurmaAdd_Click(object sender, EventArgs e)
        {
            Nsf.App.Model.TurmaModel add = new Model.TurmaModel();
            Nsf.App.Model.CursoModel curso = new Model.CursoModel();
            curso.NmCurso = cboTurmaCurso.Text;
            //add.IdCurso = cboTurmaCurso.Text; 
            add.NmTurma = txtTurmaNome.Text;
            add.TpPeriodo = cboTurmaPeriodo.Text;
            add.NrCapacidadeMax = Convert.ToInt32(nudTurmaCapacidade.Value);

            Nsf.App.API.Client.TurmaApi Add = new App.API.Client.TurmaApi();
            Add.CadastrarTurma(add);

            MessageBox.Show("Turma cadastrada com sucesso!");
        }

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Nsf.App.Model.TurmaModel add = new Model.TurmaModel();
            Nsf.App.Model.CursoModel curso = new Model.CursoModel();
            curso.NmCurso = cboTurmaCurso.Text;
            //add.IdCurso = cboTurmaCurso.Text; 
            add.NmTurma = txtTurmaNome.Text;
            add.TpPeriodo = cboTurmaPeriodo.Text;
            add.NrCapacidadeMax = Convert.ToInt32(nudTurmaCapacidade.Value);
        }

        private void CarregarCurso()
        {
            Nsf.App.API.Client.CursoApi curso = new App.API.Client.CursoApi();
           
            List<Model.CursoModel> lista = curso.ListarTodos();

            cboTurmaCurso.DisplayMember = nameof(CursoModel.NmCurso);
            cboTurmaCurso.DataSource = lista;
        }

        public void CarregarGrid()
        {
            Nsf.App.API.Client.TurmaApi turma = new App.API.Client.TurmaApi(); 
            List<TurmaModel> turmas = turma.ListarTodos();

            dgvTurma.AutoGenerateColumns = false;
            dgvTurma.DataSource = turma;
        }
    }
}