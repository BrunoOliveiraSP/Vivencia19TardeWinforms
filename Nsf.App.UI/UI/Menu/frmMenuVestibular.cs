using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public partial class frmMenuVestibular : NsfUserScreen
    {
        public frmMenuVestibular()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmAnoLetivoCadastrar());
        }

        private void label12_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmAnoLetivoConsultar());
        }

        private void label28_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmInscricoesNovo());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmInscricoesConsultar());
        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmMatriculaNovo());
        }


        private void lblInscricoesPagar_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmInscricoesPagarAvulso());
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void lblMatriculasConsultar_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmMatriculaConsultar());
        }

        private void label19_Click(object sender, EventArgs e)
        {
            var tela = new frmMatriculaNovo();
            frmInicial.Current.OpenScreen(tela);
        }

    }
}
