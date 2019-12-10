using Newtonsoft.Json;
using Nsf.App.Utils.APIs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmInscricoesNovo : NsfUserScreen
    {
        public frmInscricoesNovo()
        {
            InitializeComponent();
            CarregarCampos();
        }

        public frmInscricoesNovo(Model.InscricaoResponse model) : this()
        {
            inscricaoModel = model;
        }

        Model.InscricaoResponse inscricaoModel = new Model.InscricaoResponse();

        API.Client.InscricaoAPI Api = new API.Client.InscricaoAPI();
        API.Client.AnoLetivoApi AnoLetivoApi = new API.Client.AnoLetivoApi();
        API.Client.CursoAPI CursoAPI = new API.Client.CursoAPI();

        private void Carregar()
        {
            Model.CursoModel cursoModel1 = cboCurso1.SelectedItem as Model.CursoModel;
            Model.CursoModel cursoModel2 = cboCurso2.SelectedItem as Model.CursoModel;
            Model.AnoLetivoModel anoLetivoModel = cboAnoLetivo.SelectedItem as Model.AnoLetivoModel;


        }
        private void btnCoordenacao_Click(object sender, EventArgs e)
        {
            try
            {
                Model.CursoModel cursoModel1 = cboCurso1.SelectedItem as Model.CursoModel;
                Model.CursoModel cursoModel2 = cboCurso2.SelectedItem as Model.CursoModel;
                Model.AnoLetivoModel anoLetivoModel = cboAnoLetivo.SelectedItem as Model.AnoLetivoModel;
                if(inscricaoModel.IdInscricao > 0)
                {
                    Alterar();
                }
                else
                {
                    Model.InscricaoModel inscricao = new Model.InscricaoModel();
                    inscricao.btMatriculado = false;
                    inscricao.btPendenteComprovresid = chkPendenteComprovResidencia.Checked;
                    inscricao.btPendenteCpf = chkPendenteCpf.Checked;
                    inscricao.btPendenteEscolaridade = chkPendenteEscolaridade.Checked;
                    inscricao.btPendentePagamento = false;
                    inscricao.btPendenteRg = chkPendenteRg.Checked;
                    inscricao.cdInscricao = Convert.ToInt32(nudId.Value);
                    inscricao.dsComoConheceu = cboComoConheceu.Text;
                    inscricao.dsCorPele = txtCorDaPele.Text;
                    inscricao.dsCpf = txtCpf.Text;
                    inscricao.dsCurso2Periodo = cboTurno2.Text;
                    inscricao.dsCursoPeriodo = cboTurno1.Text;
                    inscricao.dsEmail = txtMaeEmail.Text;
                    inscricao.dsEmailInscrito = txtEmailInscrito.Text;
                    inscricao.dsEscolaridade = cboEscolaridade.Text;
                    inscricao.dsNascimentoCidade = txtNascimentoCidade.Text;
                    inscricao.dsNascimentoEstado = cboNascimentoUf.Text;
                    inscricao.dsNascimentoPais = txtNascimentoPais.Text;
                    inscricao.dsObservacao = txtObservacoes.Text;
                    inscricao.dsOrgao = txtRgOrgao.Text;
                    inscricao.dsResidenciaBairro = txtBairro.Text;
                    inscricao.dsResidenciaCep = txtCep.Text;
                    inscricao.dsResidenciaCidade = txtCidade.Text;
                    inscricao.dsResidenciaComplelemento = txtComplemento.Text;
                    inscricao.dsResidenciaEndereco = txtEndereco.Text;
                    inscricao.dsResidenciaEstado = cboUf.Text;
                    inscricao.dsResponsavelCpf = txtCpf.Text;
                    inscricao.dsResponsavelEmail = txtResponsavelEmail.Text;
                    inscricao.dsResponsavelNome = txtResponsavel.Text;
                    inscricao.dsResponsavelParentesco = cboGrauParentesco.Text;
                    inscricao.dsResponsavelRg = "...";
                    inscricao.dsResponsavelTelefone = txtResponsavelTelefone1.Text;
                    inscricao.dsResponsavelTelefone2 = txtResponsavelTelefone2.Text;
                    inscricao.dsRg = txtRG.Text;
                    inscricao.dsSexo = cboSexo.Text;
                    inscricao.dsSituacao = "-";
                    inscricao.dsTelefone = txtTelefone1.Text;
                    inscricao.dsTelefone2 = txtTelefone2.Text;
                    inscricao.dtEmissao = dtpRgEmissao.Value;
                    inscricao.dtInclusao = DateTime.Now;
                    inscricao.dtNascimento = txtNascimentoData.Value;
                    inscricao.dtUltimaAlteracao = DateTime.Now;
                    inscricao.idAnoLetivo = anoLetivoModel.IdAnoLetivo;
                    inscricao.idCurso = cursoModel1.IdCurso;
                    inscricao.idCurso2 = cursoModel1.IdCurso;
                    inscricao.idFuncionarioAlteracao = 1;
                    inscricao.idInscricao = 0;
                    inscricao.idSalaVestibular = 1;
                    inscricao.nmContato = txtContato.Text;
                    inscricao.nmEscola = txtNomeDaEscola.Text;
                    inscricao.nmInscrito = txtNome.Text;
                    inscricao.nrResidenciaEndereco = Convert.ToInt32(txtNumero.Text);
                    inscricao.qtMoramCasa = Convert.ToInt32(nudPessoasMoramCasa.Value);
                    inscricao.qtTrabalhamCasa = Convert.ToInt32(nudPessoasTrabalhamCasa.Value);
                    inscricao.tpEscola = cboTipoDeEscola.Text;
                    inscricao.vlNota = 100;
                    inscricao.vlRenda = txtRenda.Value;

                    Model.InscricaoModel alterar = Api.Inserir(inscricao);

                    MessageBox.Show("Inscrição efetuada.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult result = MessageBox.Show("Inscrição efetuada com sucesso. Deseja fazer alguma alteração?", "NSF", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Alterar();
                    }
                    else
                    {
                        LimparCampos();
                    }
                }

                inscricaoModel.IdInscricao = 0;
                LimparCampos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Alterar()
        {
            try
            {
                Model.CursoModel cursoModel1 = cboCurso1.SelectedItem as Model.CursoModel;
                Model.CursoModel cursoModel2 = cboCurso2.SelectedItem as Model.CursoModel;
                Model.AnoLetivoModel anoLetivoModel = cboAnoLetivo.SelectedItem as Model.AnoLetivoModel;
                Model.InscricaoModel inscricao = new Model.InscricaoModel();
                inscricao.btMatriculado = inscricaoModel.BtMatriculado;
                inscricao.btPendenteComprovresid = chkPendenteComprovResidencia.Checked;
                inscricao.btPendenteCpf = chkPendenteCpf.Checked;
                inscricao.btPendenteEscolaridade = chkPendenteEscolaridade.Checked;
                inscricao.btPendentePagamento = inscricaoModel.BtPendentePagamento;
                inscricao.btPendenteRg = chkPendenteRg.Checked;
                inscricao.cdInscricao = Convert.ToInt32(nudId.Value);
                inscricao.dsComoConheceu = cboComoConheceu.Text;
                inscricao.dsCorPele = txtCorDaPele.Text;
                inscricao.dsCpf = txtCpf.Text;
                inscricao.dsCurso2Periodo = cboTurno2.Text;
                inscricao.dsCursoPeriodo = cboTurno1.Text;
                inscricao.dsEmail = txtMaeEmail.Text;
                inscricao.dsEmailInscrito = txtEmailInscrito.Text;
                inscricao.dsEscolaridade = cboEscolaridade.Text;
                inscricao.dsNascimentoCidade = txtNascimentoCidade.Text;
                inscricao.dsNascimentoEstado = cboNascimentoUf.Text;
                inscricao.dsNascimentoPais = txtNascimentoPais.Text;
                inscricao.dsObservacao = txtObservacoes.Text;
                inscricao.dsOrgao = txtRgOrgao.Text;
                inscricao.dsResidenciaBairro = txtBairro.Text;
                inscricao.dsResidenciaCep = txtCep.Text;
                inscricao.dsResidenciaCidade = txtCidade.Text;
                inscricao.dsResidenciaComplelemento = txtComplemento.Text;
                inscricao.dsResidenciaEndereco = txtEndereco.Text;
                inscricao.dsResidenciaEstado = cboUf.Text;
                inscricao.dsResponsavelCpf = txtCpf.Text;
                inscricao.dsResponsavelEmail = txtResponsavelEmail.Text;
                inscricao.dsResponsavelNome = txtResponsavel.Text;
                inscricao.dsResponsavelParentesco = cboGrauParentesco.Text;
                inscricao.dsResponsavelRg = inscricaoModel.DsResponsavelRg;
                inscricao.dsResponsavelTelefone = txtResponsavelTelefone1.Text;
                inscricao.dsResponsavelTelefone2 = txtResponsavelTelefone2.Text;
                inscricao.dsRg = txtRG.Text;
                inscricao.dsSexo = cboSexo.Text;
                inscricao.dsSituacao = inscricaoModel.DsSituacao;
                inscricao.dsTelefone = txtTelefone1.Text;
                inscricao.dsTelefone2 = txtTelefone2.Text;
                inscricao.dtEmissao = dtpRgEmissao.Value;
                inscricao.dtInclusao = inscricaoModel.DtInclusao;
                inscricao.dtNascimento = txtNascimentoData.Value;
                inscricao.dtUltimaAlteracao = DateTime.Now;
                inscricao.idAnoLetivo = anoLetivoModel.IdAnoLetivo;
                inscricao.idCurso = cursoModel1.IdCurso;
                inscricao.idCurso2 = cursoModel1.IdCurso;
                inscricao.idFuncionarioAlteracao = 1;
                inscricao.idInscricao = inscricaoModel.IdInscricao;
                inscricao.idSalaVestibular = inscricaoModel.IdSalaVestibular;
                inscricao.nmContato = txtContato.Text;
                inscricao.nmEscola = txtNomeDaEscola.Text;
                inscricao.nmInscrito = txtNome.Text;
                inscricao.nrResidenciaEndereco = Convert.ToInt32(txtNumero.Text);
                inscricao.qtMoramCasa = Convert.ToInt32(nudPessoasMoramCasa.Value);
                inscricao.qtTrabalhamCasa = Convert.ToInt32(nudPessoasTrabalhamCasa.Value);
                inscricao.tpEscola = cboTipoDeEscola.Text;
                inscricao.vlNota = inscricaoModel.VlNota;
                inscricao.vlRenda = txtRenda.Value;

                Api.Alterar(inscricao);

                DialogResult result = MessageBox.Show("Alteração efetuada com sucesso. Deseja Consultar sua Alteração?", "NSF", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    frmInicial.Current.OpenScreen(new frmInscricoesConsultar());
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarCampos()
        {
            try
            {
                Model.InscricaoResponse carregar = this.inscricaoModel;

                cboAnoLetivo.ValueMember = nameof(Model.AnoLetivoModel.NrAno);
                cboAnoLetivo.DataSource = AnoLetivoApi.ListarTodos();

                cboCurso1.ValueMember = nameof(Model.CursoModel.NmCurso);
                cboCurso1.DataSource = CursoAPI.ConsultarTodos();
                cboCurso2.ValueMember = nameof(Model.CursoModel.NmCurso);
                cboCurso2.DataSource = CursoAPI.ConsultarTodos();

                
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
        private void LimparCampos()
        {
            try
            {
                chkPendenteComprovResidencia.Checked = false;
                chkPendenteCpf.Checked = false;
                chkPendenteEscolaridade.Checked = false;
                nudId.Value = 0;
                cboComoConheceu.Text = string.Empty;
                txtCorDaPele.Text = string.Empty;
                txtCpf.Text = string.Empty;
                cboTurno2.Text = string.Empty;
                cboTurno2.Text = string.Empty;
                txtMaeEmail.Text = string.Empty;
                txtEmailInscrito.Text = string.Empty;
                cboEscolaridade.Text = string.Empty;
                txtNascimentoCidade.Text = string.Empty;
                txtNascimentoCidade.Text = string.Empty;
                cboNascimentoUf.Text = string.Empty;
                txtObservacoes.Text = string.Empty;
                txtRgOrgao.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtCep.Text = string.Empty;
                txtCidade.Text = string.Empty;
                txtComplemento.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                cboUf.Text = string.Empty;
                txtCpf.Text = string.Empty;
                txtResponsavelEmail.Text = string.Empty;
                txtResponsavel.Text = string.Empty;
                cboGrauParentesco.Text = string.Empty;
                txtResponsavelTelefone1.Text = string.Empty;
                txtResponsavelTelefone2.Text = string.Empty;
                txtRG.Text = string.Empty;
                cboSexo.Text = string.Empty;
                txtTelefone1.Text = string.Empty;
                txtTelefone2.Text = string.Empty;
                dtpRgEmissao.Value = DateTime.Now.Date;
                txtNascimentoData.Value = DateTime.Now.Date;
                txtContato.Text = string.Empty;
                txtNomeDaEscola.Text = string.Empty;
                txtNumero.Text = string.Empty;
                nudPessoasMoramCasa.Value = 0;
                nudPessoasTrabalhamCasa.Value = 0;
                cboTipoDeEscola.Text = string.Empty;
                txtRenda.Value = 0;
                txtNome.Text = string.Empty;
                txtRenda.Value = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtCep_Leave(object sender, EventArgs e)
        {
            try
            {
                CorreioApi correioApi = new CorreioApi();
                CorreioResponse correioResponse = new CorreioResponse();
                bool encontrouCep = correioApi.BuscarAPICorreio(txtCep.Text, out correioResponse);

                if (encontrouCep == false)
                {
                    MessageBox.Show("Cep não encontrado, por favor, tente novamente.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    txtBairro.Text = correioResponse.bairro;
                    cboUf.Text = correioResponse.uf;
                    txtCidade.Text = correioResponse.localidade;
                    txtComplemento.Text = correioResponse.complemento;
                    txtEndereco.Text = correioResponse.logradouro + " " +
                    correioResponse.complemento + ", " + correioResponse.bairro + " " +
                    correioResponse.localidade + " - " + correioResponse.uf;
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
        private void cboTurno1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string turno = cboTurno1.Text;

                var func = cboCurso1.SelectedItem as Model.CursoModel;

                if (turno == "Noite" && func.DsCategoria == "Técnico")
                {
                    MessageBox.Show("O Curso Técnico " + func.NmCurso + ", não estão disponível no período selecionado.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTurno1.SelectedItem = 0;
                }
                else if (turno == "Noite" && func.DsCategoria == "Qualificação")
                {
                    MessageBox.Show("O Curso de Qualificação " + func.NmCurso + ", não estão disponível no período selecionado.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTurno1.SelectedItem = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboTurno2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string turno = cboTurno1.Text;

                var func = cboCurso2.SelectedItem as Model.CursoModel;

                if (turno == "Noite" && func.DsCategoria == "Técnico")
                {
                    MessageBox.Show("O Curso Técnico " + func.NmCurso + ", não estão disponível no período selecionado.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTurno2.SelectedItem = 0;
                }
                else if (turno == "Noite" && func.DsCategoria == "Qualificação")
                {
                    MessageBox.Show("O Curso de Qualificação " + func.NmCurso + ", não estão disponível no período selecionado.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTurno2.SelectedItem = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro. Entre em contato com o administrador.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
