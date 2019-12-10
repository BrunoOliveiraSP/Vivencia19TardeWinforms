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
          //try
          //  {
                Nsf.App.API.Client.SalaVestibularAPI api = new App.API.Client.SalaVestibularAPI();
                List<Model.SalaVestibularModel> consultar = api.listarTudo();

            Model.SalaVestibularModel sala = new Model.SalaVestibularModel();



            int n = 0;

            foreach(Model.SalaVestibularModel item in consultar )
            {
                item.NrOrdem = n;
                n++;
            }


                dgvSalasVestibular.AutoGenerateColumns = false;
                dgvSalasVestibular.DataSource = consultar;
          //  }
         //   catch(ArgumentException ex)
         //   {
               // MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //  }
         //   catch(Exception)
          //  {
           //     MessageBox.Show("Ocorreu um erro entre em contato com o administrador", "NSF",
           //                MessageBoxButtons.OK,
           //                MessageBoxIcon.Error);
           // }
        }

        private void btnVestibularAdd_Click(object sender, EventArgs e)
        {
            //  try
            //  { 
            var func = cboVestibularSala.SelectedItem as Model.SalaModel;
                

            
                Model.SalaVestibularModel vestibular = new Model.SalaVestibularModel();

                vestibular.DsPeriodo = cboPeriodos.Text;

                Model.SalaModel sala = new Model.SalaModel();
                sala.NmLocal = cboVestibularInstituicao.Text;
                sala.NmSala = cboVestibularSala.Text();
 
               Model.SalaVestibularModel salas = new Model.SalaVestibularModel();
            salas.DsPeriodo = cboPeriodos.Text;
            salas.IdSala = func.IdSala;
        
          
          
            
             
                Nsf.App.API.Client.SalaVestibularAPI api = new App.API.Client.SalaVestibularAPI();
                api.Inserir(salas);

                MessageBox.Show("Inserido com sucesso.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.ListarTudo();
          //  }
         //   catch (ArgumentException ex)
          //  {
       //         MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //  }
          //  catch (Exception)
         //   {
            //    MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF",
              //             MessageBoxButtons.OK,
                         //  MessageBoxIcon.Error);
          //  }
        }

        private void CarregarCombo()
        {
           // try
           // {
                Nsf.App.API.Client.SalaAPI api = new App.API.Client.SalaAPI();
                List<Model.SalaModel> model = api.ListarTudo();

                cboVestibularSala.DisplayMember = nameof(Model.SalaModel.NmSala);
                cboVestibularSala.DataSource = model;
         //   }
          //  catch(ArgumentException ex)
          //  {

          //      MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //  }
          //  catch(Exception)
          //  {
               // MessageBox.Show("Ocorreu um erro. Entre em contato com o administardor", "NSF",
           //                MessageBoxButtons.OK,
                   //        MessageBoxIcon.Error);
           // }
        }

        private void dgvSalasVestibular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
          //  {
                if (e.ColumnIndex == 4)
                {
                    Model.SalaVestibularModel te = dgvSalasVestibular.CurrentRow.DataBoundItem as Model.SalaVestibularModel;

                    cboPeriodos.Text = te.DsPeriodo;


                    DialogResult resp = MessageBox.Show("Deseja realmente fazer uma alteração?", "NSF",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Exclamation);
                    if (resp == DialogResult.Yes)
                    {

                        te.DsPeriodo = cboPeriodos.Text;

                        Nsf.App.API.Client.SalaVestibularAPI api = new App.API.Client.SalaVestibularAPI();
                        api.Alterar(te);

                        MessageBox.Show("Alterado com sucesso.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            if (e.ColumnIndex == 5)
            {
                Model.SalaVestibularModel teste = dgvSalasVestibular.CurrentRow.DataBoundItem as Model.SalaVestibularModel;

                DialogResult resp = MessageBox.Show("Deseja realmente excluir este dado?", "NSF", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    Nsf.App.API.Client.SalaVestibularAPI api = new App.API.Client.SalaVestibularAPI();
                    api.Remover(teste.IdSalaVestibular);

                    MessageBox.Show("Removido com sucesso!", "NSF");

                    this.ListarTudo();
                }
            
            }

        }
            //}
            //catch(ArgumentException ex)
           // {
          //      MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
         //   catch(Exception)
            //{
              //  MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador", "NSF", 
              //             MessageBoxButtons.OK, 
                       //    MessageBoxIcon.Error);
           // }
        }
    }
