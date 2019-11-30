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
                inscricao.btPendenteComprovresid = false;
                inscricao.btPendenteCpf = false;
                inscricao.btPendenteEscolaridade = false;
                inscricao.btPendentePagamento = false;
                inscricao.btPendenteRg = true;
                inscricao.cdInscricao = 7777;
                inscricao.dsComoConheceu = "Conhecendo";
                inscricao.dsCorPele = "Cor";
                inscricao.dsCpf = "0007";
                inscricao.dsCurso2Periodo = "Tarde";
                inscricao.dsCursoPeriodo = "Tarde";
                inscricao.dsEmail = "email@gmail.com";
                inscricao.dsEmailInscrito = "email@gmail.com";
                inscricao.dsEscolaridade = "Escola";
                inscricao.dsNascimentoCidade = "Aqui mesmo";
                inscricao.dsNascimentoEstado = "Tbm aqui";
                inscricao.dsNascimentoPais = "Vera Cruz";
                inscricao.dsObservacao = "Nenhuma";
                inscricao.dsOrgao = "Supremo Tribunal";
                inscricao.dsResidenciaBairro = "Arredores da minha casa";
                inscricao.dsResidenciaCep = "0012";
                inscricao.dsResidenciaCidade = "Aqui";
                inscricao.dsResidenciaComplelemento = "Mesmo";
                inscricao.dsResidenciaEndereco = "Já";
                inscricao.dsResidenciaEstado = "Falei";
                inscricao.dsResponsavelCpf = "Isso!";
                inscricao.dsResponsavelEmail = "@";
                inscricao.dsResponsavelNome = "Pai e Mãe";
                inscricao.dsResponsavelParentesco = "O mesmo do anterior";
                inscricao.dsResponsavelRg = "Não sei";
                inscricao.dsResponsavelTelefone = "Pi R ao quadrado";
                inscricao.dsResponsavelTelefone2 = "l Raiz de 2";
                inscricao.dsRg = "Baskara";
                inscricao.dsSexo = "Pitágoras";
                inscricao.dsSituacao = "Legal";
                inscricao.dsTelefone = "42";
                inscricao.dsTelefone2 = "IA";
                inscricao.dtEmissao = DateTime.Now;
                inscricao.dtInclusao = DateTime.Now;
                inscricao.dtNascimento = DateTime.Now.Date;
                inscricao.dtUltimaAlteracao = DateTime.Now;
                inscricao.idAnoLetivo = 1;
                inscricao.idCurso = 1;
                inscricao.idCurso2 = 1;
                inscricao.idFuncionarioAlteracao = 1;
                //inscricao.idInscricao = 1;
                //inscricao.idSalaVestibular = 1;
                inscricao.nmContato = "Contato";
                inscricao.nmEscola = "Escola";
                inscricao.nmInscrito = "Eu :)";
                inscricao.nrResidenciaEndereco = 1;
                inscricao.qtMoramCasa = 2;
                inscricao.qtTrabalhamCasa = 2;
                inscricao.tpEscola = "-_-";
                inscricao.vlNota = 10;
                inscricao.vlRenda = 1.00m;

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
//inscricao.DtNascimento = Convert.ToDateTime(txtNascimentoData.Text);
//inscricao.DsCpf = txtCep.Text;
//inscricao.DsSexo = cboSexo.Text;
//inscricao.DsCorPele = txtCorDaPele.Text;
//inscricao.DsRg = Convert.ToInt32(txtRG.Text);
//inscricao.DtEmissao = Convert.ToDateTime(dtpRgEmissao.Text);
//inscricao.DsOrgao = txtRgOrgao.Text;
//inscricao.DsEmail = txtEmailInscrito.Text;
//inscricao.DsNascimentoCidade = txtNascimentoCidade.Text;
//inscricao.DsNascimentoEstado = cboNascimentoUf.Text;
//inscricao.DsNascimentoPais = txtNascimentoPais.Text;
//inscricao.DsResidenciaCep = txtCep.Text;
//inscricao.DsResidenciaEndereco = txtEndereco.Text;
//inscricao.NrResidenciaEndereco = Convert.ToInt32(txtNumero.Text);
//inscricao.DsResidenciaComplelemento = txtComplemento.Text;
//inscricao.DsResidenciaBairro = txtBairro.Text;
//inscricao.DsResidenciaEstado = txtCidade.Text;
//inscricao.DsResidenciaCidade = txtCidade.Text;
// segunda guia
//inscricao.DsResponsavelNome = txtContato.Text;
//inscricao.DsTelefone2 = txtTelefone2.Text;
//inscricao.DsTelefone = txtTelefone1.Text;
//inscricao.DsResponsavelEmail = txtMaeEmail.Text;
//inscricao.NmContato = txtResponsavel.Text;
//inscricao.DsResponsavelTelefone = txtResponsavelTelefone1.Text;
//inscricao.DsResponsavelTelefone2 = txtResponsavelTelefone2.Text;
//inscricao.DsResponsavelEmail = txtResponsavelEmail.Text;
//inscricao.DsResponsavelParentesco = cboGrauParentesco.Text;
//inscricao.DsEscolaridade = cboEscolaridade.Text;
//inscricao.TpEscola = cboTipoDeEscola.Text;
//inscricao.NmEscola = txtNomeDaEscola.Text;
//Campo de curso precisa do modelo de curso pra continuar
//Campo de curso2 ''     ''   ''   ''  ''    ''    ''
//inscricao.DsCursoPeriodo = cboTurno1.Text;
//inscricao.DsCurso2Periodo = cboTurno2.Text;
//Terceira guia
//inscricao.DsComoConheceu = cboComoConheceu.Text;
//inscricao.VlRenda = Convert.ToDecimal(txtRenda.Text);
//inscricao.QtMoramCasa = Convert.ToInt32(nudPessoasMoramCasa.Value);
//inscricao.QtTrabalhamCasa = Convert.ToInt32(nudPessoasTrabalhamCasa.Value);
//inscricao.BtPendenteCpf = chkPendenteCpf.Checked;
//inscricao.BtPendenteRg = chkPendenteRg.Checked;
//inscricao.BtPendenteEscolaridade = chkPendenteEscolaridade.Checked;
//inscricao.BtPendenteComprovresid = chkPendenteComprovResidencia.Checked;
//inscricao.DsObservacao = txtObservacoes.Text;