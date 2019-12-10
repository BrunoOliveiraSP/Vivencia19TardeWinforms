using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmSalaVestibularCadastrar : NsfUserScreen
    {
        public frmSalaVestibularCadastrar()
        {
            InitializeComponent();

        }

        private void frmSalaVestibularCadastrar_Load(object sender, EventArgs e)
        {
            this.ListarTudo();
            this.CarregarCombo();
        }

        public void ListarTudo()
        {
            try
            {
                Nsf.App.API.Client.SalaVestibularAPI api = new App.API.Client.SalaVestibularAPI();
                List<Model.SalaVestibualrResponse> consultar = api.listarTudo();

                dgvSalasVestibular.AutoGenerateColumns = false;
                dgvSalasVestibular.DataSource = consultar;
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro entre em contato com o administrador", "NSF",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        private void btnVestibularAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var func = cboVestibularSala.SelectedItem as Model.SalaModel;

                Model.SalaVestibularModel vestibular = new Model.SalaVestibularModel();
                vestibular.DsPeriodo = cboPeriodos.Text;
                vestibular.IdSala = func.IdSala;

                Model.SalaModel sala = new Model.SalaModel();
                sala.NmLocal = cboVestibularInstituicao.Text;
                sala.NmSala = cboVestibularSala.Text;
                                      
                Model.SalaVestibularRequest request = new Model.SalaVestibularRequest();
                request.Vestibular = vestibular;
                request.Sala = sala;
                               
                Nsf.App.API.Client.SalaVestibularAPI api = new App.API.Client.SalaVestibularAPI();
                api.Inserir(request);

                MessageBox.Show("Inserido com sucesso.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.ListarTudo();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        private void CarregarCombo()
        {
            try
            {
                Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
                List<Model.SalaModel> model = api.ListarTudo();

                cboVestibularSala.DisplayMember = nameof(Model.SalaModel.NmSala);
                cboVestibularSala.DataSource = model;
            }
            catch(ArgumentException ex)
            {

                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administardor", "NSF",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error);
            }
        }

        private void dgvSalasVestibular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    Model.SalaVestibularModel teste = dgvSalasVestibular.CurrentRow.DataBoundItem as Model.SalaVestibularModel;

                    cboPeriodos.Text = teste.DsPeriodo;


                    DialogResult resp = MessageBox.Show("Deseja realmente fazer uma alteração?", "NSF",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);
                    if (resp == DialogResult.Yes)
                    {

                        teste.DsPeriodo = cboPeriodos.Text;

                        Nsf.App.API.Client.SalaVestibularAPI api = new App.API.Client.SalaVestibularAPI();
                        api.Alterar(teste);

                        MessageBox.Show("Alterado com sucesso.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (e.ColumnIndex == 6)
                {
                    Model.SalaVestibularModel teste = dgvSalasVestibular.CurrentRow.DataBoundItem as Model.SalaVestibularModel;

                    DialogResult resp = MessageBox.Show("Deseja realmente excluir este dado?", "NSF", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resp == DialogResult.Yes)
                    {

                        Nsf.App.API.Client.SalaVestibularAPI api = new App.API.Client.SalaVestibularAPI();
                        api.Remover(teste.IdSalaVestibular);

                        MessageBox.Show("Excluido com sucesso.", "NSF",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

                        this.ListarTudo();
                    }

                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador", "NSF", 
                           MessageBoxButtons.OK, 
                           MessageBoxIcon.Error);
            }
        }
    }
}