using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDA_AFK_Clicker
{
    public partial class Form_Message_List : Form
    {

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        public const int GWL_EXSTYLE = -20;
        public const int WS_EX_LAYERED = 0x80000;
        public const int LWA_ALPHA = 0x2;
        public const int LWA_COLORKEY = 0x1;
        List<string> main_str;
        public Form_Message_List(List<string> str)
        {
            main_str = str;
            InitializeComponent();
        }

        private void Form_Message_List_Load(object sender, EventArgs e)
        {
            this.TopLevel = true;
            this.TopMost = true;

            SetWindowLong(Handle, GWL_EXSTYLE, GetWindowLong(Handle, GWL_EXSTYLE) ^ WS_EX_LAYERED);
            SetLayeredWindowAttributes(Handle, 0, 255, LWA_ALPHA);
            foreach (string str in main_str)
            {
                listBox_WavesInfo.Items.Add(str);
            }
        }

        private void Update_List_Info(int minute)
        {
            for (int i = 0; i < 6; i++)
            {

            }
        }
    }
}
