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

            CarregarCurso();
            CarregarGrid();
        }

        Model.TurmaModell turmaModel;
        Model.AnoLetivoModel anoModel;
        Nsf.App.API.Client.TurmaApi turmaApi;

        public void LimparCamposAnoLetivo()
        {
            dtpFim.Value = DateTime.Now;
            cboStatus.Text = string.Empty;
            dtpInicio.Value = DateTime.Now;
            nudAno.Value = DateTime.Now.Year;
        }

        public void LimparCamposTurma()
        {
            nudTurmaCapacidade.Value = 1;
            txtTurmaNome.Text = string.Empty;
            cboTurmaCurso.Text = string.Empty;
            cboTurmaPeriodo.Text = string.Empty;
        }

        public void CarregarTela(Model.AnoLetivoModel model)
        {
            try
            {
                anoModel  = new AnoLetivoModel ();

                ulong btAberto = Convert.ToUInt32(rdnAberto.Checked);

                btAberto = model.BtAtivo;
                nudAno.Value = model.NrAno;
                dtpFim.Value = model.DtFim;
                cboStatus.Text = model.TpStatus;
                dtpInicio.Value = model.DtInicio;
                anoModel.IdAnoLetivo = model.IdAnoLetivo;

                anoModel = model;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                anoModel = api.Cadastar(anoModel);

                DialogResult d = MessageBox.Show("Ano letivo cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                anoModel.DtFim = dtpFim.Value;
                anoModel.TpStatus = cboStatus.Text;
                anoModel.DtInicio = dtpInicio.Value;
                anoModel.IdAnoLetivo = anoModel.IdAnoLetivo;
                anoModel.NrAno = Convert.ToInt32(nudAno.Value);
                anoModel.BtAtivo = Convert.ToUInt32(rdnAberto.Checked);

                Nsf.App.API.Client.AnoLetivoApi api = new App.API.Client.AnoLetivoApi();
                api.Alterar(anoModel);
                MessageBox.Show("Ano letivo alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCurso()
        {
            try
            {
                API.Client.CursoAPI api = new API.Client.CursoAPI();

                List<Model.CursoModel> lista = api.ConsultarTodos();

                cboTurmaCurso.DisplayMember = nameof(Model.CursoModel.NmCurso);
                cboTurmaCurso.DataSource = lista;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTurmaAdd_Click_1(object sender, EventArgs e)
        {
            try
            {  
                Model.TurmaModell model = new TurmaModell();

                Model.CursoModel combo = cboTurmaCurso.SelectedItem as Model.CursoModel;

                model.IdCurso = combo.IdCurso;
                model.NmTurma = txtTurmaNome.Text;
                model.TpPeriodo = cboTurmaPeriodo.Text;
                model.IdAnoLetivo = anoModel.IdAnoLetivo;
                model.NrCapacidadeMax = Convert.ToInt32(nudTurmaCapacidade.Value);

                App.API.Client.TurmaApi api = new API.Client.TurmaApi();

                if (turmaModel != null && turmaModel.IdTurma > 0)
                {
                    model.IdTurma = turmaModel.IdTurma;
                    api.Alterar(model);

                    MessageBox.Show("Turma alterada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
                else
                {
                    api.Cadastrar(model);
                    CarregarGrid();
                    MessageBox.Show("Turma cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    Model.TurmaResponse turma = dgvTurma.CurrentRow.DataBoundItem as Model.TurmaResponse;

                    cboTurmaPeriodo.Text = turma.TpPeriodo;
                    txtTurmaNome.Text = turma.NmTurma;
                    nudTurmaCapacidade.Value = turma.NrCapacidadeMax;
                    cboTurmaCurso.Text = turma.NmCurso;

                    turmaModel.IdTurma = turma.IdTurma;
                    turmaModel.NmTurma = turma.NmTurma;
                    turmaModel.NrCapacidadeMax = turma.NrCapacidadeMax;
                    turmaModel.TpPeriodo = turma.TpPeriodo;
                }

                if (e.ColumnIndex == 5)
                {
                    Model.TurmaResponse turma = dgvTurma.CurrentRow.DataBoundItem as Model.TurmaResponse;

                    DialogResult r = MessageBox.Show("Deseja Remover?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        turmaApi.Remover(turma.IdTurma);

                        MessageBox.Show("Removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarGrid();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


