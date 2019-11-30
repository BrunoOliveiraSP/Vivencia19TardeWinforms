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

        private void btnCoordenacao_Click(object sender, EventArgs e)
        {
            Models.InscricaoModel inscricao = new Models.InscricaoModel();
            inscricao.CdInscricao = Convert.ToInt32(nudId.Value);
            inscricao.NmInscrito = txtNome.Text;
            inscricao.DtNascimento = Convert.ToDateTime(txtNascimentoData.Text);
            inscricao.DsCpf = txtCep.Text;
            inscricao.DsSexo = cboSexo.Text;
            inscricao.DsCorPele = txtCorDaPele.Text;
            inscricao.DsRg = Convert.ToInt32(txtRG.Text);
            inscricao.DtEmissao = Convert.ToDateTime(dtpRgEmissao.Text);
            inscricao.DsOrgao = txtRgOrgao.Text;
            inscricao.DsEmail = txtEmailInscrito.Text;
            inscricao.DsNascimentoCidade = txtNascimentoCidade.Text;
            inscricao.DsNascimentoEstado = cboNascimentoUf.Text;
            inscricao.DsNascimentoPais = txtNascimentoPais.Text;
            inscricao.DsResidenciaCep = txtCep.Text;
            inscricao.DsResidenciaEndereco = txtEndereco.Text;
            inscricao.NrResidenciaEndereco = Convert.ToInt32(txtNumero.Text);
            inscricao.DsResidenciaComplelemento = txtComplemento.Text;
            inscricao.DsResidenciaBairro = txtBairro.Text;
            inscricao.DsResidenciaEstado = txtCidade.Text;
            inscricao.DsResidenciaCidade = txtCidade.Text;
            // segunda guia
            inscricao.DsResponsavelNome = txtContato.Text;
            inscricao.DsTelefone2 = txtTelefone2.Text;
            inscricao.DsTelefone = txtTelefone1.Text;
            inscricao.DsResponsavelEmail = txtMaeEmail.Text;
            inscricao.NmContato = txtResponsavel.Text;
            inscricao.DsResponsavelTelefone = txtResponsavelTelefone1.Text;
            inscricao.DsResponsavelTelefone2 = txtResponsavelTelefone2.Text;
            inscricao.DsResponsavelEmail = txtResponsavelEmail.Text;
            inscricao.DsResponsavelParentesco = cboGrauParentesco.Text;
            inscricao.DsEscolaridade = cboEscolaridade.Text;
            inscricao.TpEscola = cboTipoDeEscola.Text;
            inscricao.NmEscola = txtNomeDaEscola.Text;
            //Campo de curso precisa do modelo de curso pra continuar
            //Campo de curso2 ''     ''   ''   ''  ''    ''    ''
            inscricao.DsCursoPeriodo = cboTurno1.Text;
            inscricao.DsCurso2Periodo = cboTurno2.Text;
            //Terceira guia
            inscricao.DsComoConheceu = cboComoConheceu.Text;
            inscricao.VlRenda = Convert.ToDecimal(txtRenda.Text);
            inscricao.QtMoramCasa = Convert.ToInt32(nudPessoasMoramCasa);
            inscricao.QtTrabalhamCasa = Convert.ToInt32(nudPessoasTrabalhamCasa);
            inscricao.BtPendenteCpf = chkPendenteCpf.Checked;
            inscricao.BtPendenteRg = chkPendenteRg.Checked;
            inscricao.BtPendenteEscolaridade = chkPendenteEscolaridade.Checked;
            inscricao.BtPendenteComprovresid = chkPendenteComprovResidencia.Checked;
            inscricao.DsObservacao = txtObservacoes.Text;
            /*API.api = new API.InscricaoAPI();
            api.Inserir(inscricao);*/

            MessageBox.Show("Inscrição efetuada.", "Inscrição", MessageBoxButtons.OK);
        }

        private void CarregarCampos()
        {
            //Carregar os dois combos da tela
        }
        
        }
    }
