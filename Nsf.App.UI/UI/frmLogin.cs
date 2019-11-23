using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Nsf.App.UI
{
	public partial class frmLogin : Form
	{

		public frmLogin()
		{
			InitializeComponent();
        }


        
        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }
    }
}