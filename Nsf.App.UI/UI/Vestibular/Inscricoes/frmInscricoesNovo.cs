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

        App.API.Client.InscricaoAPI Api = new App.API.Client.InscricaoAPI();
        App.API.Client.AnoLetivoApi AnoLetivoApi = new App.API.Client.AnoLetivoApi();
        API.CursoAPI CursoAPI = new API.CursoAPI();
        private void btnCoordenacao_Click(object sender, EventArgs e)
        {
            try
            {
                Model.CursoModel cursoModel1 = cboCurso1.SelectedItem as Model.CursoModel;
                Model.CursoModel cursoModel2 = cboCurso2.SelectedItem as Model.CursoModel;
                Model.AnoLetivoModel anoLetivoModel = cboAnoLetivo.SelectedItem as Model.AnoLetivoModel;
                if(Model.CarregarInscrições.idInscricao > 0)
                {
                    Model.InscricaoModel inscricao = new Model.InscricaoModel();
                    inscricao.btMatriculado = Model.CarregarInscrições.btMatriculado ;
                    inscricao.btPendenteComprovresid = chkPendenteComprovResidencia.Checked;
                    inscricao.btPendenteCpf = chkPendenteCpf.Checked;
                    inscricao.btPendenteEscolaridade = chkPendenteEscolaridade.Checked;
                    inscricao.btPendentePagamento = Model.CarregarInscrições.btPendentePagamento;
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
                    inscricao.dsResponsavelRg = Model.CarregarInscrições.dsResponsavelRg;
                    inscricao.dsResponsavelTelefone = txtResponsavelTelefone1.Text;
                    inscricao.dsResponsavelTelefone2 = txtResponsavelTelefone2.Text;
                    inscricao.dsRg = txtRG.Text;
                    inscricao.dsSexo = cboSexo.Text;
                    inscricao.dsSituacao = Model.CarregarInscrições.dsSituacao;
                    inscricao.dsTelefone = txtTelefone1.Text;
                    inscricao.dsTelefone2 = txtTelefone2.Text;
                    inscricao.dtEmissao = dtpRgEmissao.Value;
                    inscricao.dtInclusao = Model.CarregarInscrições.dtInclusao;
                    inscricao.dtNascimento = txtNascimentoData.Value;
                    inscricao.dtUltimaAlteracao = DateTime.Now;
                    inscricao.idAnoLetivo = anoLetivoModel.IdAnoLetivo;
                    inscricao.idCurso = cursoModel1.IdCurso;
                    inscricao.idCurso2 = cursoModel1.IdCurso;
                    inscricao.idFuncionarioAlteracao = 1;
                    inscricao.idInscricao = Model.CarregarInscrições.idInscricao;
                    inscricao.idSalaVestibular = Model.CarregarInscrições.idSalaVestibular;
                    inscricao.nmContato = txtContato.Text;
                    inscricao.nmEscola = txtNomeDaEscola.Text;
                    inscricao.nmInscrito = txtNome.Text;
                    inscricao.nrResidenciaEndereco = Convert.ToInt32(txtNumero.Text);
                    inscricao.qtMoramCasa = Convert.ToInt32(nudPessoasMoramCasa.Value);
                    inscricao.qtTrabalhamCasa = Convert.ToInt32(nudPessoasTrabalhamCasa.Value);
                    inscricao.tpEscola = cboTipoDeEscola.Text;
                    inscricao.vlNota = Model.CarregarInscrições.vlNota;
                    inscricao.vlRenda = txtRenda.Value;

                    Api.Alterar(inscricao);

                    MessageBox.Show("Alteração efetuada.", "Inscrição", MessageBoxButtons.OK);
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

                    Api.Inserir(inscricao);

                    MessageBox.Show("Inscrição efetuada.", "Inscrição", MessageBoxButtons.OK);
                }

                Model.CarregarInscrições.idInscricao = 0;
                LimparCampos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarCampos()
        {
            try
            {
                cboAnoLetivo.ValueMember = nameof(Model.AnoLetivoModel.NrAno);
                cboAnoLetivo.DataSource = AnoLetivoApi.ListarTodos();

                cboCurso1.ValueMember = nameof(Model.CursoModel.NmCurso);
                cboCurso1.DataSource = CursoAPI.ConsultarTodos();
                cboCurso2.ValueMember = nameof(Model.CursoModel.NmCurso);
                cboCurso2.DataSource = CursoAPI.ConsultarTodos();

                if (Model.CarregarInscrições.idInscricao != 0)
                {

                    Model.AnoLetivoModel anoLetivo = Api.ConsultarAnoLetivo(Model.CarregarInscrições.idAnoLetivo);
                    Model.CursoModel curso = Api.ConsultarCurso(Model.CarregarInscrições.idCurso);
                    Model.CursoModel curso2 = Api.ConsultarCurso(Model.CarregarInscrições.idCurso2);


                    txtNome.Text = Model.CarregarInscrições.nmInscrito;
                    chkPendenteComprovResidencia.Checked = Model.CarregarInscrições.btPendenteComprovresid;
                    chkPendenteCpf.Checked = Model.CarregarInscrições.btPendenteCpf;
                    chkPendenteEscolaridade.Checked = Model.CarregarInscrições.btPendenteEscolaridade;
                    nudId.Value = Model.CarregarInscrições.cdInscricao;
                    cboComoConheceu.Text = Model.CarregarInscrições.dsComoConheceu;
                    txtCorDaPele.Text = Model.CarregarInscrições.dsCorPele;
                    txtCpf.Text = Model.CarregarInscrições.dsCpf;
                    cboTurno2.Text = Model.CarregarInscrições.dsCurso2Periodo;
                    cboTurno1.Text = Model.CarregarInscrições.dsCursoPeriodo;
                    txtMaeEmail.Text = Model.CarregarInscrições.dsEmail;
                    txtEmailInscrito.Text = Model.CarregarInscrições.dsEmailInscrito;
                    cboEscolaridade.Text = Model.CarregarInscrições.dsEscolaridade;
                    txtNascimentoCidade.Text = Model.CarregarInscrições.dsNascimentoCidade;
                    cboNascimentoUf.Text = Model.CarregarInscrições.dsNascimentoEstado;
                    txtNascimentoPais.Text = Model.CarregarInscrições.dsNascimentoPais;
                    txtObservacoes.Text = Model.CarregarInscrições.dsObservacao;
                    txtRgOrgao.Text = Model.CarregarInscrições.dsOrgao;
                    txtBairro.Text = Model.CarregarInscrições.dsResidenciaBairro;
                    txtCep.Text = Model.CarregarInscrições.dsResidenciaCep;
                    txtCidade.Text = Model.CarregarInscrições.dsResidenciaCidade;
                    txtComplemento.Text = Model.CarregarInscrições.dsResidenciaComplelemento;
                    txtEndereco.Text = Model.CarregarInscrições.dsResidenciaEndereco;
                    cboUf.Text = Model.CarregarInscrições.dsResidenciaEstado;
                    txtCpf.Text = Model.CarregarInscrições.dsResponsavelCpf;
                    txtResponsavelEmail.Text = Model.CarregarInscrições.dsResponsavelEmail;
                    txtResponsavel.Text = Model.CarregarInscrições.dsResponsavelNome;
                    cboGrauParentesco.Text = Model.CarregarInscrições.dsResponsavelParentesco;
                    txtResponsavelTelefone1.Text = Model.CarregarInscrições.dsResponsavelTelefone;
                    txtResponsavelTelefone2.Text = Model.CarregarInscrições.dsResponsavelTelefone2;
                    txtRG.Text = Model.CarregarInscrições.dsRg;
                    cboSexo.Text = Model.CarregarInscrições.dsSexo;
                    txtTelefone1.Text = Model.CarregarInscrições.dsTelefone;
                    txtTelefone2.Text = Model.CarregarInscrições.dsTelefone2;
                    dtpRgEmissao.Value = Model.CarregarInscrições.dtEmissao;
                    txtNascimentoData.Value = Model.CarregarInscrições.dtNascimento;
                    cboAnoLetivo.Text = anoLetivo.NrAno.ToString();
                    cboCurso1.Text = curso.NmCurso;
                    cboCurso2.Text = curso2.NmCurso;
                    txtContato.Text = Model.CarregarInscrições.nmContato;
                    txtNomeDaEscola.Text = Model.CarregarInscrições.nmEscola;
                    txtNumero.Text = Model.CarregarInscrições.nrResidenciaEndereco.ToString();
                    nudPessoasMoramCasa.Value = Model.CarregarInscrições.qtMoramCasa;
                    nudPessoasTrabalhamCasa.Value = Model.CarregarInscrições.qtTrabalhamCasa;
                    cboTipoDeEscola.Text = Model.CarregarInscrições.tpEscola;
                    txtRenda.Value = Model.CarregarInscrições.vlRenda;
                }
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro");
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
                //cboAnoLetivo.Text = Model.CarregarInscrições.idAnoLetivo; Fazer um 
                //= Model.CarregarInscrições.idCurso;
                //= Model.CarregarInscrições.idCurso2;
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
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            CorreioApi correioApi = new CorreioApi();
            CorreioResponse correioResponse = new CorreioResponse();
            correioApi.BuscarAPICorreio(txtCep.Text, out correioResponse);
            txtBairro.Text = correioResponse.bairro;
            cboUf.Text = correioResponse.uf;
            txtCidade.Text = correioResponse.localidade;
            txtComplemento.Text = correioResponse.complemento;
            txtEndereco.Text = correioResponse.logradouro + " " +
            correioResponse.complemento + ", " + correioResponse.bairro + " " + 
            correioResponse.localidade + " - " + correioResponse.uf;
        }
    }
}
