using Nsf.App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Nsf.App.API;

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

        Model.CursoModel curso;
        Model.TurmaModell turmaModel;
        Model.AnoLetivoModel anoModel;
        Model.TurmaRequest turmaRequest;

        Nsf.App.API.Client.TurmaApi turmaApi = new App.API.Client.TurmaApi();

        public void CarregarTela(Model.AnoLetivoModel model)
        {
            try
            {
                anoModel  = new AnoLetivoModel ();

                ulong btAberto = Convert.ToUInt32(rdnAberto.Checked);

                btAberto = model.BtAtivo;
                anoModel.IdAnoLetivo = model.IdAnoLetivo;
                nudAno.Value = model.NrAno;
                dtpFim.Value = model.DtFim;
                cboStatus.Text = model.TpStatus;
                dtpInicio.Value = model.DtInicio;

                anoModel = model;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (anoModel != null && anoModel.IdAnoLetivo > 0)
                {
                    Alterar();
                }

                else
                {
                    Inserir();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public void Inserir()
        {
            try
            {
                anoModel = new AnoLetivoModel();

                anoModel.DtFim = dtpFim.Value;
                anoModel.TpStatus = cboStatus.Text;
                anoModel.DtInicio = dtpInicio.Value;
                anoModel.NrAno = Convert.ToInt32(nudAno.Value);
                anoModel.BtAtivo = Convert.ToUInt32(rdnAberto.Checked);

                Nsf.App.API.Client.AnoLetivoApi api = new App.API.Client.AnoLetivoApi();
                api.CadastrarAnoLetivo(anoModel);

                MessageBox.Show("Ano letivo cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                anoModel.IdAnoLetivo = anoModel.IdAnoLetivo;
                anoModel.DtFim = dtpFim.Value;
                anoModel.TpStatus = cboStatus.Text;
                anoModel.DtInicio = dtpInicio.Value;
                anoModel.NrAno = Convert.ToInt32(nudAno.Value);
                anoModel.BtAtivo = Convert.ToUInt32(rdnAberto.Checked);

                Nsf.App.API.Client.AnoLetivoApi api = new App.API.Client.AnoLetivoApi();
                api.Alterar(anoModel);
                MessageBox.Show("Ano letivo alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCurso()
        {
            try
            {
                API.CursoAPI api = new API.CursoAPI();

                List<Model.CursoModel> lista = api.ConsultarTodos();

                cboTurmaCurso.DisplayMember = nameof(Model.CursoModel.NmCurso);
                cboTurmaCurso.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CarregarGrid()
        {
            try
            {
                List<Model.TurmaResponse> turma = turmaApi.ListarTodos();

                dgvTurma.AutoGenerateColumns = false;
                dgvTurma.DataSource = turma;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    turmaModel = new TurmaModell();
                    Model.TurmaModell turma = dgvTurma.CurrentRow.DataBoundItem as Model.TurmaModell;
                    Model.CursoModel combo = cboTurmaCurso.SelectedItem as Model.CursoModel;

                    turmaModel.IdTurma = turma.IdTurma;
                    turma.IdAnoLetivo = anoModel.IdAnoLetivo;
                    txtTurmaNome.Text = turma.NmTurma;
                    cboTurmaCurso.Text = combo.NmCurso;
                    cboTurmaPeriodo.Text = turma.TpPeriodo;
                    nudTurmaCapacidade.Value = turma.NrCapacidadeMax;

                    turmaModel = turma;
                }

                if (e.ColumnIndex == 5)
                {
                    Model.TurmaModell turma = dgvTurma.CurrentRow.DataBoundItem as Model.TurmaModell;

                    DialogResult r = MessageBox.Show("Deseja Remover?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        turmaApi.Remover(turma.IdTurma);

                        MessageBox.Show("Removido com sucesso");
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTurmaAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (turmaModel != null && turmaModel.IdTurma > 0)
                {
                    AlterarTurma();
                    CarregarGrid();
                }
                else
                {
                    InserirTurma();
                    CarregarGrid();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InserirTurma()
        {
            try
            {
                turmaModel = new TurmaModell();

                Model.CursoModel combo = cboTurmaCurso.SelectedItem as Model.CursoModel;

                turmaModel.IdAnoLetivo = anoModel.IdAnoLetivo;
                turmaModel.IdCurso = combo.IdCurso;
                turmaModel.NmTurma = txtTurmaNome.Text;
                turmaModel.TpPeriodo = cboTurmaPeriodo.Text;
                turmaModel.NrCapacidadeMax = Convert.ToInt32(nudTurmaCapacidade.Value);

                curso = new CursoModel();
                curso.NmCurso = cboTurmaCurso.Text;

                turmaRequest = new TurmaRequest();
                turmaRequest.Turma = turmaModel;
                turmaRequest.Curso = curso;
          
                turmaApi.CadastrarTurma(turmaRequest);

                CarregarGrid();

                MessageBox.Show("Turma cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AlterarTurma()
        {
            try
            {
                turmaModel = new TurmaModell();
                Model.CursoModel combo = cboTurmaCurso.SelectedItem as Model.CursoModel;

                turmaModel.IdTurma = turmaModel.IdTurma;               
                turmaModel.IdCurso = combo.IdCurso;
                turmaModel.NmTurma = txtTurmaNome.Text;
                turmaModel.TpPeriodo = cboTurmaPeriodo.Text;
                turmaModel.NrCapacidadeMax = Convert.ToInt32(nudTurmaCapacidade.Value);
                

                curso = new CursoModel();
                curso.NmCurso = cboTurmaCurso.Text;

                turmaRequest = new TurmaRequest();
                turmaRequest.Turma = turmaModel;
                turmaRequest.Curso = curso;

                turmaApi.Alterar(turmaModel);

                MessageBox.Show("Turma alterada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


