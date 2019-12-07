﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nsf.App.UI
{
	public partial class frmInscricoesConsultar : NsfUserScreen
	{
		public frmInscricoesConsultar()
		{
			InitializeComponent();
            CarregarGrid();
            Model.CarregarInscrições.idInscricao = 0;
		}

        App.API.Client.InscricaoAPI InscricaoAPI = new App.API.Client.InscricaoAPI();

       private void txtNome_TextChanged(object sender, EventArgs e)
       {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    dgvCandidatos.AutoGenerateColumns = false;
                    dgvCandidatos.DataSource = InscricaoAPI.ConsultarTodos();
                }
                else
                {
                    var func = cboAnoLetivo.SelectedItem as Model.AnoLetivoModel;
                    App.API.Client.InscricaoAPI inscricao = new App.API.Client.InscricaoAPI();
                    dgvCandidatos.AutoGenerateColumns = false;
                    dgvCandidatos.DataSource = inscricao.ConsultarNome(txtNome.Text, func.IdAnoLetivo);
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboAnoLetivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                App.API.Client.InscricaoAPI inscricao = new App.API.Client.InscricaoAPI();
                dgvCandidatos.AutoGenerateColumns = false;
                var func = cboAnoLetivo.SelectedItem as Model.AnoLetivoModel;
                if(string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    dgvCandidatos.DataSource = inscricao.ConsultarAnoLetivoLista(func.IdAnoLetivo);
                }
                else
                {
                    dgvCandidatos.DataSource = inscricao.ConsultarNome(txtNome.Text, func.IdAnoLetivo);
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
               MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarGrid()
        {
            try
            {
                App.API.Client.AnoLetivoApi anoLetivoApi = new App.API.Client.AnoLetivoApi();
                cboAnoLetivo.ValueMember = nameof(Model.AnoLetivoModel.NrAno);
                cboAnoLetivo.DataSource = anoLetivoApi.ListarTodos();
                dgvCandidatos.AutoGenerateColumns = false;
                dgvCandidatos.DataSource = InscricaoAPI.ConsultarTodos();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCandidatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 5)
                {
                    Model.InscricaoModel inscricao = dgvCandidatos.CurrentRow.DataBoundItem as Model.InscricaoModel;

                    Model.CarregarInscrições.btMatriculado = inscricao.btMatriculado;
                    Model.CarregarInscrições.btPendenteComprovresid = inscricao.btPendenteComprovresid;
                    Model.CarregarInscrições.btPendenteCpf = inscricao.btPendenteCpf;
                    Model.CarregarInscrições.btPendenteEscolaridade = inscricao.btPendenteEscolaridade;
                    Model.CarregarInscrições.btPendentePagamento = inscricao.btPendenteRg;
                    Model.CarregarInscrições.cdInscricao = inscricao.cdInscricao;
                    Model.CarregarInscrições.dsComoConheceu = inscricao.dsComoConheceu;
                    Model.CarregarInscrições.dsCorPele = inscricao.dsCorPele;
                    Model.CarregarInscrições.dsCpf = inscricao.dsCpf;
                    Model.CarregarInscrições.dsCurso2Periodo = inscricao.dsCurso2Periodo;
                    Model.CarregarInscrições.dsCursoPeriodo = inscricao.dsCursoPeriodo;
                    Model.CarregarInscrições.dsEmail = inscricao.dsEmail;
                    Model.CarregarInscrições.dsEmailInscrito = inscricao.dsEmailInscrito;
                    Model.CarregarInscrições.dsEscolaridade = inscricao.dsEscolaridade;
                    Model.CarregarInscrições.dsNascimentoCidade = inscricao.dsNascimentoCidade;
                    Model.CarregarInscrições.dsNascimentoEstado = inscricao.dsNascimentoEstado;
                    Model.CarregarInscrições.dsNascimentoPais = inscricao.dsNascimentoPais;
                    Model.CarregarInscrições.dsObservacao = inscricao.dsObservacao;
                    Model.CarregarInscrições.dsOrgao = inscricao.dsOrgao;
                    Model.CarregarInscrições.dsResidenciaBairro = inscricao.dsResidenciaBairro;
                    Model.CarregarInscrições.dsResidenciaCep = inscricao.dsResidenciaCep;
                    Model.CarregarInscrições.dsResidenciaCidade = inscricao.dsResidenciaCidade;
                    Model.CarregarInscrições.dsResidenciaComplelemento = inscricao.dsResidenciaComplelemento;
                    Model.CarregarInscrições.dsResidenciaEndereco = inscricao.dsResidenciaEndereco;
                    Model.CarregarInscrições.dsResidenciaEstado = inscricao.dsResidenciaEstado;
                    Model.CarregarInscrições.dsResponsavelCpf = inscricao.dsResponsavelCpf;
                    Model.CarregarInscrições.dsResponsavelEmail = inscricao.dsResponsavelEmail;
                    Model.CarregarInscrições.dsResponsavelNome = inscricao.dsResponsavelNome;
                    Model.CarregarInscrições.dsResponsavelParentesco = inscricao.dsResponsavelParentesco;
                    Model.CarregarInscrições.dsResponsavelRg = inscricao.dsResponsavelRg;
                    Model.CarregarInscrições.dsResponsavelTelefone = inscricao.dsResponsavelTelefone;
                    Model.CarregarInscrições.dsResponsavelTelefone2 = inscricao.dsResponsavelTelefone2;
                    Model.CarregarInscrições.dsRg = inscricao.dsRg;
                    Model.CarregarInscrições.dsSexo = inscricao.dsSexo;
                    Model.CarregarInscrições.dsSituacao = inscricao.dsSituacao;
                    Model.CarregarInscrições.dsTelefone = inscricao.dsTelefone;
                    Model.CarregarInscrições.dsTelefone2 = inscricao.dsTelefone2;
                    Model.CarregarInscrições.dtEmissao = inscricao.dtEmissao;
                    Model.CarregarInscrições.dtInclusao = inscricao.dtInclusao;
                    Model.CarregarInscrições.dtNascimento = inscricao.dtNascimento;
                    Model.CarregarInscrições.dtUltimaAlteracao = inscricao.dtUltimaAlteracao;
                    Model.CarregarInscrições.idAnoLetivo = inscricao.idAnoLetivo;
                    Model.CarregarInscrições.idCurso = inscricao.idCurso;
                    Model.CarregarInscrições.idCurso2 = inscricao.idCurso2;
                    Model.CarregarInscrições.idFuncionarioAlteracao = inscricao.idFuncionarioAlteracao;
                    Model.CarregarInscrições.idInscricao = inscricao.idInscricao;
                    Model.CarregarInscrições.idSalaVestibular = inscricao.idSalaVestibular;
                    Model.CarregarInscrições.nmContato = inscricao.nmContato;
                    Model.CarregarInscrições.nmEscola = inscricao.nmEscola;
                    Model.CarregarInscrições.nmInscrito = inscricao.nmInscrito;
                    Model.CarregarInscrições.nrResidenciaEndereco = inscricao.nrResidenciaEndereco;
                    Model.CarregarInscrições.qtMoramCasa = inscricao.qtMoramCasa;
                    Model.CarregarInscrições.qtTrabalhamCasa = inscricao.qtTrabalhamCasa;
                    Model.CarregarInscrições.tpEscola = inscricao.tpEscola;
                    Model.CarregarInscrições.vlNota = inscricao.vlNota;
                    Model.CarregarInscrições.vlRenda = inscricao.vlRenda;


                    frmInicial.Current.OpenScreen(new frmInscricoesNovo());
                }

                if (e.ColumnIndex == 6)
                {
                    Model.InscricaoModel inscricao = dgvCandidatos.CurrentRow.DataBoundItem as Model.InscricaoModel;

                    DialogResult result = MessageBox.Show("Dejesa Remover?", "Inscrição", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        InscricaoAPI.Remover(inscricao.idInscricao);
                        MessageBox.Show("Registro removido");
                        CarregarGrid();
                    }
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}