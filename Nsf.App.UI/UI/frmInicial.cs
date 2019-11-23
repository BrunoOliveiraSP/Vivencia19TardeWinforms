using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.App.UI
{
	public partial class frmInicial : Form
	{
        frmModeloEstatistica statistics;


        public static frmInicial Current
		{
			get; private set;
		}


		public frmInicial(NsfUserScreen tela = null)
		{
			InitializeComponent();
			Current = this;
        }

        protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			Left = Top = 0;
			Width = Screen.PrimaryScreen.WorkingArea.Width;
			Height = Screen.PrimaryScreen.WorkingArea.Height;

            imgUser.Left = panelConteudo.Width - imgUser.Width - 50;
            lblUser.Left = panelConteudo.Width - lblUser.Width - 83;

            OpenScreen(statistics = new frmModeloEstatistica(), 0, 0);
			HomeSelected();
			HideBack();
		}

        void OpenStatistic()
        {
            statistics.Show();
        }

        void HideStatistic()
        {
            statistics.Hide();
        }

		void HomeSelected()
		{
			pnSelected.Top = 0 - panelTopo.Height;
		}

        void HideBack()
        {
            lblVoltar.Visible = false;
            OpenStatistic();
        }

        void ShowBack()
        {
            lblVoltar.Visible = true;
            HideStatistic();
        }


		public void OpenScreen(NsfUserScreen tela, int adjustX = 0, int adjustY = 0)
		{
			ShowBack();

			bool alreadyInControls = false;
			UserControl toRemove = null;
			foreach (var item in panelConteudo.Controls)
			{
				if (item is UserControl)
				{
					if (item.GetType() == tela.GetType())
					{
						toRemove = item as UserControl;
						alreadyInControls = true;
					}
				}
			}

			if (alreadyInControls)
				panelConteudo.Controls.Remove(toRemove);


			panelConteudo.Controls.Add(tela);
			panelConteudo.Controls.SetChildIndex(tela, 0);

			tela.Left = (panelConteudo.Width - tela.Width - adjustX) / 2;
			tela.Top = (panelConteudo.Height - tela.Height - adjustY) / 2;


			if (tela is INsfUserScreenCadaster)
			{
				tela.Focus();
				((INsfUserScreenCadaster)tela).SetFocus();
			}

			tela.OnOpenScreen();
		}

        public bool BackScreen()
        {
            if (panelConteudo.Controls.Count > 1)
            {
                panelConteudo.Controls.RemoveAt(0);

				if (panelConteudo.Controls[0] is INsfUserScreenConsult)
				{
					((INsfUserScreenConsult)panelConteudo.Controls[0]).OnBackedScreen();
				}
			}

            if (panelConteudo.Controls.Count == 1)
            {
                HideBack();
                HomeSelected();
                return false;
            }

			return true;

		}



		private void btnDocencia_Click(object sender, EventArgs e)
		{
			pnSelected.Top = btnDocencia.Top;
			OpenScreen(new frmMenuDocencia());
		}

		private void btnDiscencia_Click(object sender, EventArgs e)
		{
			pnSelected.Top = btnDiscencia.Top;
			OpenScreen(new frmMenuDiscencia());
		}

		private void btnCoordenacao_Click(object sender, EventArgs e)
		{
			pnSelected.Top = btnCoordenacao.Top;
			OpenScreen(new frmMenuCoordenacao());
		}

		private void lblLogo_Click(object sender, EventArgs e)
		{
			HomeSelected();
			bool isback = false;
			do { isback = BackScreen(); } while (isback);
		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLogin tela = new frmLogin();
			tela.Show();
			Hide();
		}

		private void btnAdmin_Click(object sender, EventArgs e)
		{
			pnSelected.Top = btnAdmin.Top;
			OpenScreen(new frmMenuAdmin());
		}

		private void lblVoltar_Click(object sender, EventArgs e)
		{
			BackScreen();
		}

		private void btnVestibular_Click(object sender, EventArgs e)
		{
			pnSelected.Top = btnVestibular.Top;
			OpenScreen(new frmMenuVestibular());
		}

		private void btnRelatorios_Click(object sender, EventArgs e)
		{
			pnSelected.Top = btnRelatorios.Top;
			OpenScreen(new frmMenuRelatorios());
		}

		private void frmInicial_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void imgUser_Click(object sender, EventArgs e)
        {
            menuUsuarioLogado.Show(imgUser.Location);
        }

    }
}