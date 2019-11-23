using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.App.UI
{
    public static class MessageBoxExtension
    {
        public static bool ShowNsfQuestion(this UserControl form, string message)
        {
            return MessageBox.Show(
                message, "NSF", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void ShowNsfMessage(this UserControl form, string message)
        {
            MessageBox.Show(message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowNsfError(this UserControl form, string message)
        {
            MessageBox.Show(message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowNsfWarning(this UserControl form, string message)
        {
            MessageBox.Show(message, "NSF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}