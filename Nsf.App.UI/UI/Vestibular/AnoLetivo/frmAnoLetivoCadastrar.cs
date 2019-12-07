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
            //((Control)tabTurmas).Enabled = false;

            CarregarGrid();
            CarregarCurso();
        }

        Model.CursoModel curso = new CursoModel();
        Model.TurmaModell model = new TurmaModell();
        Model.AnoLetivoModel add = new AnoLetivoModel();
        Nsf.App.API.Client.TurmaApii api = new App.API.Client.TurmaApii();

        int idAno = 0;
        int IdTurma = 0;

        public void CarregarTela(Model.AnoLetivoModel model)
        {
            try
            {
                ulong btAberto = Convert.ToUInt32(rdnAberto.Checked);

                btAberto = model.BtAtivo;
                idAno = model.IdAnoLetivo;
                nudAno.Value = model.NrAno;
                dtpFim.Value = model.DtFim;
                cboStatus.Text = model.TpStatus;
                dtpInicio.Value = model.DtInicio;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                add.DtFim = dtpFim.Value;
                add.TpStatus = cboStatus.Text;
                add.DtInicio = dtpInicio.Value;
                add.NrAno = Convert.ToInt32(nudAno.Value);
                add.BtAtivo = Convert.ToUInt32(rdnAberto.Checked);

                Nsf.App.API.Client.AnoLetivoApi api = new App.API.Client.AnoLetivoApi();

                if (idAno > 0)
                {
                    add.IdAnoLetivo = idAno;
                    api.Alterar(add);

                    MessageBox.Show("Alterado com sucesso");
                }

                else
                {
                    api.CadastrarAnoLetivo(add);
                    DialogResult r = MessageBox.Show("Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //if (r == DialogResult.Yes)
                    //{
                    //    tabControl1.TabPages.Remove(tabTurmas);
                    //}
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarCurso()
        {
            API.CursoAPI api = new API.CursoAPI();

            List<Model.CursoModel> lista = api.ConsultarTodos();

            cboTurmaCurso.DisplayMember = nameof(Model.CursoModel.NmCurso);
            cboTurmaCurso.DataSource = lista;
        }

        public void CarregarGrid()
        {
            try
            {
                List<Model.TurmaModell> turma = api.ListarTodos();

                dgvTurma.AutoGenerateColumns = false;
                dgvTurma.DataSource = turma;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    Model.TurmaModell turma = dgvTurma.CurrentRow.DataBoundItem as Model.TurmaModell;
                    Model.CursoModel combo = cboTurmaCurso.SelectedItem as Model.CursoModel;

                    turma.IdAnoLetivo = 2; // ERRO MORTAL
                    txtTurmaNome.Text = turma.NmTurma;
                    cboTurmaCurso.Text = combo.NmCurso;
                    cboTurmaPeriodo.Text = turma.TpPeriodo;
                    nudTurmaCapacidade.Value = turma.NrCapacidadeMax;

                    IdTurma = turma.IdTurma;
                }

                if (e.ColumnIndex == 5)
                {
                    Model.TurmaModell turma = dgvTurma.CurrentRow.DataBoundItem as Model.TurmaModell;

                    DialogResult r = MessageBox.Show("Deseja Remover?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        api.Remover(turma.IdTurma);

                        MessageBox.Show("Removido com sucesso");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTurmaAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                Model.CursoModel combo = cboTurmaCurso.SelectedItem as Model.CursoModel;

                model.IdAnoLetivo = 2;
                model.IdCurso = combo.IdCurso;
                model.NmTurma = txtTurmaNome.Text;
                model.TpPeriodo = cboTurmaPeriodo.Text;             
                model.NrCapacidadeMax = Convert.ToInt32(nudTurmaCapacidade.Value);
                
                Nsf.App.API.Client.TurmaApii api = new Nsf.App.API.Client.TurmaApii();

                if (IdTurma > 0)
                {
                    model.IdTurma = IdTurma;
                    api.Alterar(model);

                    MessageBox.Show("Alterado com sucesso");
                    CarregarGrid();
                }
                else
                {
                    api.CadastrarTurma(model);
                    MessageBox.Show("Cadastrado com sucesso");
                    CarregarGrid();
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void dgvTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


