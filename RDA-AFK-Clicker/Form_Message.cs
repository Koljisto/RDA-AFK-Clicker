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
        private const int WS_EX_LAYERED = 0x00080000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_EXSTYLE = -20;
        string message_;
        public Form_Message(string message)
        {
            InitializeComponent();
            message_ = message;
        }

        private void Form_Message_Load(object sender, EventArgs e)
        {
            label1.Text = message_;
            //handle = IntPtr.Zero;
            int winFlags = GetWindowLong(IntPtr.Zero, GWL_EXSTYLE);
            winFlags |= WS_EX_LAYERED;
            winFlags |= WS_EX_TRANSPARENT;
            SetWindowLong(this.Handle, GWL_EXSTYLE, winFlags);
        }
    }
}
