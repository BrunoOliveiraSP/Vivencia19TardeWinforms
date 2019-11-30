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

        private void btnCoordenacao_Click(object sender, EventArgs e)
        {
            try
            {
                Model.InscricaoModel inscricao = new Model.InscricaoModel();
                inscricao.btMatriculado = true;
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
                inscricao.dsCursoPeriodo = cboTurno2.Text;
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
                inscricao.dsResponsavelRg = "-";
                inscricao.dsResponsavelTelefone = txtResponsavelTelefone1.Text;
                inscricao.dsResponsavelTelefone2 = txtResponsavelTelefone2.Text;
                inscricao.dsRg = txtRG.Text;
                inscricao.dsSexo = cboSexo.Text;
                inscricao.dsSituacao = "-";
                inscricao.dsTelefone = txtTelefone1.Text;
                inscricao.dsTelefone2 = txtTelefone2.Text;
                inscricao.dtEmissao = DateTime.Now;
                inscricao.dtInclusao = DateTime.Now;
                inscricao.dtNascimento = DateTime.Now.Date;
                inscricao.dtUltimaAlteracao = DateTime.Now;
                inscricao.idAnoLetivo = 2;
                inscricao.idCurso = 2;
                inscricao.idCurso2 = 2;
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
                inscricao.vlNota = 10;
                inscricao.vlRenda = txtRenda.Value;

                Api.Inserir(inscricao);

                MessageBox.Show("Inscrição efetuada.", "Inscrição", MessageBoxButtons.OK);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CarregarCampos()
        {
            //Carregar os dois combos da tela
        }
        
    }

}
