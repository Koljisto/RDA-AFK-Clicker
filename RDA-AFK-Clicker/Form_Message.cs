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
    public partial class Form_Message : Form
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
        string message_;
        public Form_Message(string message)
        {
            InitializeComponent();
            message_ = message;
        }

        private void Form_Message_Load(object sender, EventArgs e)
        {
            label1.Text = message_;
            this.TopLevel = true;
            this.TopMost = true;
            //int winFlags = GetWindowLong(IntPtr.Zero, GWL_EXSTYLE);
            //winFlags |= WS_EX_LAYERED;
            //winFlags |= WS_EX_TRANSPARENT;
            SetWindowLong(Handle, GWL_EXSTYLE, GetWindowLong(Handle, GWL_EXSTYLE) ^ WS_EX_LAYERED);
            SetLayeredWindowAttributes(Handle, 0, 255, LWA_ALPHA);
        }
    }
}
