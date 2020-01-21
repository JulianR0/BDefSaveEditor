using System.Windows.Forms;

namespace BDefSaveEditor
{
    partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JulianR0/BDefSaveEditor");
        }
    }
}
