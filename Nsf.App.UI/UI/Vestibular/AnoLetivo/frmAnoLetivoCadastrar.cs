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
        int id = 0;
        public void CarregarTela(Model.AnoLetivoModel model)
        {
            id = model.IdAnoLetivo;
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

            Nsf.App.API.Client.AnoLetivoApi Add = new App.API.Client.AnoLetivoApi();

            if (id > 0)
            {
                add.IdAnoLetivo = id;
                Add.Alterar(add);
                MessageBox.Show("Alterado com sucesso.");
            }
            else
            {
                Add.CadastrarAnoLetivo(add);
                MessageBox.Show("Cadastro realizado com sucesso.");
                frmAnoLetivoConsultar tela = new frmAnoLetivoConsultar();
                tela.Show();
                this.Hide();
            }



        }

       

        private void dgvTurma_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            API.CursoAPI cursoApi = new API.CursoAPI();
            if (e.ColumnIndex == 4)
            {
                cboTurmaCurso.ValueMember = nameof(Model.CursoModel.NmCurso);
                cboTurmaCurso.DataSource = cursoApi.ConsultarTodos();
                Model.TurmaModel turma = dgvTurma.CurrentRow.DataBoundItem as Model.TurmaModel;

                cboTurmaPeriodo.Text = turma.TpPeriodo;
                txtTurmaNome.Text = turma.NmTurma;
                nudTurmaCapacidade.Value = turma.NrCapacidadeMax;

                id = turma.IdTurma;
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
            List<TurmaModel> turmass = turma.ListarTodos();

            dgvTurma.AutoGenerateColumns = false;
            dgvTurma.DataSource = turmass;
        }

        private void btnTurmaAdd_Click_1(object sender, EventArgs e)
        {
            Nsf.App.Model.TurmaModel add = new Model.TurmaModel();
            Nsf.App.Model.CursoModel combo = cboTurmaCurso.SelectedItem as Model.CursoModel;


            add.IdAnoLetivo = 2;
            add.IdCurso = combo.IdCurso; 
            add.NmTurma = txtTurmaNome.Text;
            add.TpPeriodo = cboTurmaPeriodo.Text;
            add.NrCapacidadeMax = Convert.ToInt32(nudTurmaCapacidade.Value);

            Nsf.App.API.Client.TurmaApi Add = new App.API.Client.TurmaApi();
            if(id > 0)
            {
                add.IdTurma = id;
                Add.Alterar(add);

                MessageBox.Show("Alterado com sucesso");
            }

            else
            {
                Add.CadastrarTurma(add);

                MessageBox.Show("Cadastrado com sucesso");
            }
        }
    }
}