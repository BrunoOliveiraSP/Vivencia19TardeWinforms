using System.Collections.Generic;
using System.Linq;

namespace Nsf.App.UI
{
	public partial class frmModeloEstatistica : NsfUserScreen
	{
		public frmModeloEstatistica()
		{
			InitializeComponent();
		}

        public override void OnOpenScreen()
        {
        }

        private void label14_Click(object sender, System.EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmExemploConsultar());
        }

        private void label15_Click(object sender, System.EventArgs e)
        {
            frmInicial.Current.OpenScreen(new frmExemploCadastrar());
        }
    }
}