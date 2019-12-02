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
        int idAno = 0;
        int IdTurma = 0;
        public void CarregarTela(Model.AnoLetivoModel model)
        {
            idAno = model.IdAnoLetivo;
            nudAno.Value = model.NrAno;
            dtpInicio.Value = model.DtInicio;
            dtpFim.Value = model.DtFim;
            cboStatus.Text = model.TpStatus;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Model.AnoLetivoModel add = new Model.AnoLetivoModel();
            add.NrAno = Convert.ToInt32(nudAno.Value);
            add.DtInicio = dtpInicio.Value;
            add.DtFim = dtpFim.Value;
            add.TpStatus = cboStatus.Text;
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
        private void CarregarCurso()
        {
           API.CursoAPI api = new API.CursoAPI();

            List<Model.CursoModel> lista = api.ConsultarTodos();

            cboTurmaCurso.DisplayMember = nameof(Model.CursoModel.NmCurso);
            cboTurmaCurso.DataSource = lista;
        }
        public void CarregarGrid()
        {
            Nsf.App.API.Client.TurmaApi api = new App.API.Client.TurmaApi();
            List<Model.TurmaModel> turma = api.ListarTodos();

            dgvTurma.AutoGenerateColumns = false;
            dgvTurma.DataSource = turma;
        }

        

        private void btnTurmaAdd_Click(object sender, EventArgs e)
        {
            Nsf.App.Model.TurmaModel model = new Model.TurmaModel();

            Model.CursoModel combo = cboTurmaCurso.SelectedItem as Model.CursoModel;

            model.TpPeriodo = cboTurmaPeriodo.Text;
            model.NmTurma = txtTurmaNome.Text;
            model.NrCapacidadeMax = Convert.ToInt32(nudTurmaCapacidade.Value);
            model.IdAnoLetivo = idAno;
            model.IdCurso = combo.IdCurso;


          Nsf.App.API.Client.TurmaApi api = new Nsf.App.API.Client.TurmaApi();

            if (IdTurma > 0)
            {
                model.IdTurma =  IdTurma;
                api.Alterar(model);

                MessageBox.Show("Alterado com sucesso");
                CarregarGrid();
            }
            else
            {
                api.CadastrarTurma(model);

              
                MessageBox.Show("Cadastrado com sucesso");
            }
        }

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Model.TurmaModel turma = dgvTurma.CurrentRow.DataBoundItem as Model.TurmaModel;

                cboTurmaPeriodo.Text = turma.TpPeriodo;
                txtTurmaNome.Text = turma.NmTurma;
                nudTurmaCapacidade.Value = turma.NrCapacidadeMax;

                IdTurma = turma.IdTurma;
            }

            if (e.ColumnIndex == 5)
            {
                Model.TurmaModel turma = dgvTurma.CurrentRow.DataBoundItem as Model.TurmaModel;

                DialogResult r = MessageBox.Show("Deseja Remover?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    Nsf.App.API.Client.TurmaApi api = new App.API.Client.TurmaApi();

                    api.Remover(turma.IdTurma);

                    MessageBox.Show("Removido com sucesso");
                }
            }
        }
    }
    }
