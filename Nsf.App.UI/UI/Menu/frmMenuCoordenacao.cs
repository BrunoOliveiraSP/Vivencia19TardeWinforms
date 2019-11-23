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
    public partial class frmMenuCoordenacao : NsfUserScreen
    {
        public frmMenuCoordenacao()
        {
            InitializeComponent();
        }

        private void frmMenuDiscencia_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmSalaCadastrar());
        }

        private void label13_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmProfessorCadastrar());
        }

        private void label12_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmProfessorConsultar());
        }

        private void label7_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmSalaConsultar());
        }

        private void lblDisciplinasNovo_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmDisciplinasCadastrar());
        }

        private void lblDisciplinasConsultar_Click(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmDisciplinasConsultar());
        }

		private void lblCursosNovo_Click(object sender, EventArgs e)
		{
			frmInicial.Current.OpenScreen(new frmCursoCadastrar());
		}

		private void lblCursosConsultar_Click(object sender, EventArgs e)
		{
			frmInicial.Current.OpenScreen(new frmCursoConsultar());
		}

        private void label12_Click_1(object sender, EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmSalaVestibularCadastrar());
        }

        private void lblEnviarDiario_Click(object sender, EventArgs e)
        {
        }
    }
}