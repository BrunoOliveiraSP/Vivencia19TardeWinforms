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
        int idAno = 0;
        int IdTurma = 0;
        public void CarregarTela(Model.AnoLetivoModel model)
        {
            ulong btAberto = Convert.ToUInt32(rdnAberto.Checked);

            idAno = model.IdAnoLetivo;
            nudAno.Value = model.NrAno;
            dtpInicio.Value = model.DtInicio;
            dtpFim.Value = model.DtFim;
            cboStatus.Text = model.TpStatus;
            btAberto = model.BtAtivo;
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
            Nsf.App.API.Client.TurmaApii api = new App.API.Client.TurmaApii();
            List<Model.TurmaModell> turma = api.ListarTodos();

            dgvTurma.AutoGenerateColumns = false;
            dgvTurma.DataSource = turma;
        }


        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Model.TurmaModell turma = dgvTurma.CurrentRow.DataBoundItem as Model.TurmaModell;

                cboTurmaCurso.Text = turma.NmCurso;
                cboTurmaPeriodo.Text = turma.TpPeriodo;
                txtTurmaNome.Text = turma.NmTurma;
                nudTurmaCapacidade.Value = turma.NrCapacidadeMax;

                IdTurma = turma.IdTurma;
            }

            if (e.ColumnIndex == 5)
            {
                Model.TurmaModell turma = dgvTurma.CurrentRow.DataBoundItem as Model.TurmaModell;

                DialogResult r = MessageBox.Show("Deseja Remover?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    Nsf.App.API.Client.TurmaApii api = new App.API.Client.TurmaApii();

                    api.Remover(turma.IdTurma);

                    MessageBox.Show("Removido com sucesso");
                }
            }
        }

        private void btnTurmaAdd_Click_1(object sender, EventArgs e)
        {
            Nsf.App.Model.TurmaModell model = new Model.TurmaModell();

            Model.CursoModel combo = cboTurmaCurso.SelectedItem as Model.CursoModel;


                     

            Nsf.App.API.Client.TurmaApii api = new Nsf.App.API.Client.TurmaApii();

            if (model.IdTurma == IdTurma)
            {
                model.TpPeriodo = cboTurmaPeriodo.Text;
                model.NmTurma = txtTurmaNome.Text;
                model.NrCapacidadeMax = Convert.ToInt32(nudTurmaCapacidade.Value);
                model.IdCurso = combo.IdCurso;
              
                api.Alterar(model);

                MessageBox.Show("Alterado com sucesso");
                CarregarGrid();
            }
            else
            {
                model.TpPeriodo = cboTurmaPeriodo.Text;
                model.NmTurma = txtTurmaNome.Text;
                model.NrCapacidadeMax = Convert.ToInt32(nudTurmaCapacidade.Value);
                model.IdCurso = combo.IdCurso;

                api.CadastrarTurma(model);
                MessageBox.Show("Cadastrado com sucesso");
                CarregarGrid();
            }
        }

    }
}
    
