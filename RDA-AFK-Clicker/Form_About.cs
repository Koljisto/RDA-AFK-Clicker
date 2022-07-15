using System.Diagnostics;
using System.Windows.Forms;

namespace RDA_AFK_Clicker
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Koljisto/RDA-AFK-Clicker");
        }
    }
}
