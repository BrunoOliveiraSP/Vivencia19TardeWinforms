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
            Carregar();
        }

        Model.InscricaoResponse inscricaoModel = new Model.InscricaoResponse();
        API.Client.InscricaoAPI Api = new API.Client.InscricaoAPI();
        API.Client.AnoLetivoApi AnoLetivoApi = new API.Client.AnoLetivoApi();
        API.Client.CursoAPI CursoAPI = new API.Client.CursoAPI();

        private void Carregar()
        {
            API.Client.AnoLetivoApi anoLetivoApi = new API.Client.AnoLetivoApi();

            Model.AnoLetivoModel anoLetivo = anoLetivoApi.ConsultarAnoLetivo(inscricaoModel.IdAnoLetivo);
            Model.CursoModel curso = CursoAPI.ConsultarCurso(inscricaoModel.IdCurso);
            Model.CursoModel curso2 = CursoAPI.ConsultarCurso(inscricaoModel.IdCurso2);

            chkPendenteEscolaridade.Checked = inscricaoModel.BtPendenteEscolaridade;
            txtResponsavelTelefone2.Text = inscricaoModel.DsResponsavelTelefone2;
            txtResponsavelTelefone1.Text = inscricaoModel.DsResponsavelTelefone;
            cboGrauParentesco.Text = inscricaoModel.DsResponsavelParentesco;
            txtComplemento.Text = inscricaoModel.DsResidenciaComplelemento;
            nudPessoasTrabalhamCasa.Value = inscricaoModel.QtTrabalhamCasa;
            txtNascimentoCidade.Text = inscricaoModel.DsNascimentoCidade;
            txtResponsavelEmail.Text = inscricaoModel.DsResponsavelEmail;
            txtNascimentoPais.Text = inscricaoModel.DsNascimentoPais;
            txtResponsavel.Text = inscricaoModel.DsResponsavelNome;
            txtEndereco.Text = inscricaoModel.DsResidenciaEndereco;
            txtEmailInscrito.Text = inscricaoModel.DsEmailInscrito;
            nudPessoasMoramCasa.Value = inscricaoModel.QtMoramCasa;
            chkPendenteCpf.Checked = inscricaoModel.BtPendenteCpf;
            txtNascimentoData.Value = inscricaoModel.DtNascimento;
            cboEscolaridade.Text = inscricaoModel.DsEscolaridade;
            cboComoConheceu.Text = inscricaoModel.DsComoConheceu;
            txtBairro.Text = inscricaoModel.DsResidenciaBairro;
            txtCidade.Text = inscricaoModel.DsResidenciaCidade;
            txtObservacoes.Text = inscricaoModel.DsObservacao;
            cboTurno2.Text = inscricaoModel.DsCurso2Periodo;
            cboTipoDeEscola.Text = inscricaoModel.TpEscola;
            txtNomeDaEscola.Text = inscricaoModel.NmEscola;
            cboUf.Text = inscricaoModel.DsResidenciaEstado;
            cboTurno1.Text = inscricaoModel.DsCursoPeriodo;
            txtTelefone2.Text = inscricaoModel.DsTelefone2;
            cboAnoLetivo.Text = anoLetivo.NrAno.ToString();
            dtpRgEmissao.Value = inscricaoModel.DtEmissao;
            txtTelefone1.Text = inscricaoModel.DsTelefone;
            txtCpf.Text = inscricaoModel.DsResponsavelCpf;
            txtCep.Text = inscricaoModel.DsResidenciaCep;
            txtCorDaPele.Text = inscricaoModel.DsCorPele;
            txtContato.Text = inscricaoModel.NmContato;
            txtMaeEmail.Text = inscricaoModel.DsEmail;
            txtRgOrgao.Text = inscricaoModel.DsOrgao;
            txtNome.Text = inscricaoModel.NmInscrito;
            nudId.Value = inscricaoModel.CdInscricao;
            txtRenda.Value = inscricaoModel.VlRenda;
            cboSexo.Text = inscricaoModel.DsSexo;
            txtCpf.Text = inscricaoModel.DsCpf;
            txtRG.Text = inscricaoModel.DsRg;
            cboCurso1.Text = curso.NmCurso;
            cboCurso2.Text = curso2.NmCurso;
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
                   

                    DialogResult result = MessageBox.Show("Inscrição efetuada com sucesso. Deseja fazer alguma alteração?", "NSF", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show("Altere os campos desejados, e clique em salvar para concluir sua alteração.", "NSF", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                    else
                    {
                        LimparCampos();
                        inscricaoModel.IdInscricao = 0;
                    }
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
        private void Alterar()
        {
            try
            {
                Model.AnoLetivoModel anoLetivoModel = cboAnoLetivo.SelectedItem as Model.AnoLetivoModel;
                Model.CursoModel cursoModel1 = cboCurso1.SelectedItem as Model.CursoModel;
                Model.CursoModel cursoModel2 = cboCurso2.SelectedItem as Model.CursoModel;
                Model.InscricaoModel inscricao = new Model.InscricaoModel();

                inscricao.qtTrabalhamCasa = Convert.ToInt32(nudPessoasTrabalhamCasa.Value);
                inscricao.btPendenteComprovresid = chkPendenteComprovResidencia.Checked;
                inscricao.qtMoramCasa = Convert.ToInt32(nudPessoasMoramCasa.Value);
                inscricao.btPendenteEscolaridade = chkPendenteEscolaridade.Checked;
                inscricao.btPendentePagamento = inscricaoModel.BtPendentePagamento;
                inscricao.nrResidenciaEndereco = Convert.ToInt32(txtNumero.Text);
                inscricao.dsResponsavelTelefone2 = txtResponsavelTelefone2.Text;
                inscricao.dsResponsavelTelefone = txtResponsavelTelefone1.Text;
                inscricao.idSalaVestibular = inscricaoModel.IdSalaVestibular;
                inscricao.dsResponsavelParentesco = cboGrauParentesco.Text;
                inscricao.dsResponsavelRg = inscricaoModel.DsResponsavelRg;
                inscricao.dsResidenciaComplelemento = txtComplemento.Text;
                inscricao.dsResponsavelEmail = txtResponsavelEmail.Text;
                inscricao.dsNascimentoCidade = txtNascimentoCidade.Text;
                inscricao.btMatriculado = inscricaoModel.BtMatriculado;
                inscricao.cdInscricao = Convert.ToInt32(nudId.Value);
                inscricao.dsNascimentoEstado = cboNascimentoUf.Text;
                inscricao.dsNascimentoPais = txtNascimentoPais.Text;
                inscricao.idAnoLetivo = anoLetivoModel.IdAnoLetivo;
                inscricao.idInscricao = inscricaoModel.IdInscricao;
                inscricao.dsEmailInscrito = txtEmailInscrito.Text;
                inscricao.dsEmailInscrito = txtEmailInscrito.Text;
                inscricao.dsEmailInscrito = txtEmailInscrito.Text;
                inscricao.dsResidenciaEndereco = txtEndereco.Text;
                inscricao.dsResponsavelNome = txtResponsavel.Text;
                inscricao.dsSituacao = inscricaoModel.DsSituacao;
                inscricao.btPendenteCpf = chkPendenteCpf.Checked;
                inscricao.dtInclusao = inscricaoModel.DtInclusao;
                inscricao.dtNascimento = txtNascimentoData.Value;
                inscricao.dsEscolaridade = cboEscolaridade.Text;
                inscricao.dsComoConheceu = cboComoConheceu.Text;
                inscricao.btPendenteRg = chkPendenteRg.Checked;
                inscricao.dsResidenciaBairro = txtBairro.Text;
                inscricao.dsResidenciaCidade = txtCidade.Text;
                inscricao.dsObservacao = txtObservacoes.Text;
                inscricao.dtUltimaAlteracao = DateTime.Now;
                inscricao.dsCurso2Periodo = cboTurno2.Text;
                inscricao.dsTelefone2 = txtTelefone2.Text;
                inscricao.dsCursoPeriodo = cboTurno1.Text;
                inscricao.tpEscola = cboTipoDeEscola.Text;
                inscricao.nmEscola = txtNomeDaEscola.Text;
                inscricao.dsResidenciaEstado = cboUf.Text;
                inscricao.dsTelefone = txtTelefone1.Text;
                inscricao.dsResponsavelCpf = txtCpf.Text;
                inscricao.dtEmissao = dtpRgEmissao.Value;
                inscricao.idCurso2 = cursoModel1.IdCurso;
                inscricao.vlNota = inscricaoModel.VlNota;
                inscricao.dsResidenciaCep = txtCep.Text;
                inscricao.dsCorPele = txtCorDaPele.Text;
                inscricao.idCurso = cursoModel1.IdCurso;
                inscricao.nmContato = txtContato.Text;
                inscricao.dsEmail = txtMaeEmail.Text;
                inscricao.idFuncionarioAlteracao = 1;
                inscricao.nmInscrito = txtNome.Text;
                inscricao.dsOrgao = txtRgOrgao.Text;
                inscricao.vlRenda = txtRenda.Value;
                inscricao.dsSexo = cboSexo.Text;
                inscricao.dsCpf = txtCpf.Text;
                inscricao.dsRg = txtRG.Text;

                Api.Alterar(inscricao);

                DialogResult result = MessageBox.Show("Alteração efetuada com sucesso. Deseja Consultar sua Alteração?", "NSF", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    frmInicial.Current.OpenScreen(new frmInscricoesConsultar());
                }
                else
                {
                    inscricaoModel = null;
                    inscricaoModel.IdInscricao = 0;
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
                txtResponsavelTelefone1.Text = string.Empty;
                txtResponsavelTelefone2.Text = string.Empty;
                txtNascimentoData.Value = DateTime.Now.Date;
                chkPendenteEscolaridade.Checked = false;
                txtNascimentoCidade.Text = string.Empty;
                txtResponsavelEmail.Text = string.Empty;
                dtpRgEmissao.Value = DateTime.Now.Date;
                txtNascimentoPais.Text = string.Empty;
                cboGrauParentesco.Text = "Selecione";
                txtEmailInscrito.Text = string.Empty;
                txtNomeDaEscola.Text = string.Empty;
                txtResponsavel.Text = string.Empty;
                cboComoConheceu.Text = "Selecione";
                cboEscolaridade.Text = "Selecione";
                txtObservacoes.Text = string.Empty;
                txtComplemento.Text = string.Empty;
                cboTipoDeEscola.Text = "Selecione";
                cboNascimentoUf.Text = "Selecione";
                nudPessoasTrabalhamCasa.Value = 0;
                txtTelefone1.Text = string.Empty;
                txtTelefone2.Text = string.Empty;
                txtCorDaPele.Text = string.Empty;
                txtMaeEmail.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtContato.Text = string.Empty;
                chkPendenteCpf.Checked = false;
                txtRgOrgao.Text = string.Empty;
                nudPessoasMoramCasa.Value = 0;
                txtBairro.Text = string.Empty;
                txtCidade.Text = string.Empty;
                cboTurno2.Text = "Selecione";
                cboTurno2.Text = "Selecione";
                txtNome.Text = string.Empty;
                cboSexo.Text = "Selecione";
                txtCpf.Text = string.Empty;
                txtCep.Text = string.Empty;
                txtRG.Text = string.Empty;
                cboUf.Text = "Selecione";
                txtRenda.Value = 1000;
                txtNumero.Value = 0;
                nudId.Value = 0;

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
                    txtEndereco.Text = correioResponse.logradouro;
                    txtCidade.Text = correioResponse.localidade;
                    txtBairro.Text = correioResponse.bairro;
                    cboUf.Text = correioResponse.uf;

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
                    cboTurno1.Text = "Selecione";
                }
                else if (turno == "Noite" && func.DsCategoria == "Qualificação")
                {
                    MessageBox.Show("O Curso de Qualificação " + func.NmCurso + ", não estão disponível no período selecionado.", "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTurno1.Text = "Selecione";
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
