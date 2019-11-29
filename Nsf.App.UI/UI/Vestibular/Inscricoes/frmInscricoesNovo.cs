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
            inscricao.DsResidenciaEstado = txt
        }

        private void CarregarCampos()
        {
            //Carregar os dois combos da tela
        }
        
        }
    }
}