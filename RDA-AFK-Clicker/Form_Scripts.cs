using AutoHotkey.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDA_AFK_Clicker
{
    public partial class Form_Scripts : Form
    {
        public Form_Scripts()
        {
            InitializeComponent();
        }
        //create inputbox for get name new script
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateScripts();
            //SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }
        AutoHotkeyEngine ahk = new AutoHotkeyEngine();
        private void UpdateScripts()
        {
            listBox_Scripts.Items.Clear();
            if (!Directory.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\Scripts"))
                Directory.CreateDirectory("Scripts");
            string[] files = Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath) + "\\Scripts");
            foreach (string file in files)
            {
                listBox_Scripts.Items.Add(Path.GetFileName(file));
            }
        }

        private void listBox_ScriptsSelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox_Scripts.SelectedIndex == -1) { return; };
            label_NameScript.Text = listBox_Scripts.SelectedItem.ToString();
            button_RecordScript.Enabled = true;
            if (File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + "\\Scripts\\" + listBox_Scripts.SelectedItem.ToString()))
            {
                button_StartScript.Enabled = true;
            }
            else
            {
                button_StartScript.Enabled = false;
            }
        }
        private void button_AddNewScript_Click(object sender, EventArgs e)
        {
            string value = "";
            InputBox("Создание скрипта", "Введите название скрипта", ref value);
            File.Create(Path.GetDirectoryName(Application.ExecutablePath) + "\\Scripts\\" + value + ".ahk").Close();
            UpdateScripts();
        }
        private void button_DeleteScriptClick(object sender, EventArgs e)
        {
            File.Delete(Path.GetDirectoryName(Application.ExecutablePath) + "\\Scripts\\" + listBox_Scripts.SelectedItem.ToString());
            UpdateScripts();
            button_RecordScript.Enabled = false;
            button_StartScript.Enabled = false;
        }
        private void button_StartScript_Click(object sender, EventArgs e)
        {   
            //ahk.Reset();
            ahk = new AutoHotkeyEngine();
            ahk.LoadFile(Path.GetDirectoryName(Application.ExecutablePath)+"\\Scripts\\" + listBox_Scripts.SelectedItem.ToString());
        }

        private void button_RecordScript_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажмите Ctrl+R для старта записи.");
            //ahk.Reset();
            ahk = new AutoHotkeyEngine();
            if (!File.Exists(Path.GetTempPath() + "\\AutoHotkey.Interop\\1.0.0.0\\x86\\macro_recorder_v02.ahk"))
                File.Copy("SystemScripts\\macro_recorder_v02.ahk", Path.GetTempPath() + "\\AutoHotkey.Interop\\1.0.0.0\\x86\\macro_recorder_v02.ahk");
            //if (!File.Exists(Path.GetTempPath() + "\\AutoHotkey.Interop\\1.0.0.0\\x86\\recorde_keys.ahk"))
            //    File.Copy("SystemScripts\\recorde_keys.ahk", Path.GetTempPath() + "\\AutoHotkey.Interop\\1.0.0.0\\x86\\recorde_keys.ahk");
            //config with params for ahk creator file (macro_recorder_v02)
            File.WriteAllText(Path.GetTempPath() + "\\AutoHotkey.Interop\\1.0.0.0\\x86" + "\\config.ini",
                            "[Clicker]\n" +
                            "cfgdirectory="+ Path.GetDirectoryName(Application.ExecutablePath) + "\\Scripts\n"+
                            "cfgfilename=" + listBox_Scripts.SelectedItem.ToString()+"\n"+
                            "cfgworkdir=" + Path.GetTempPath() + "\\AutoHotkey.Interop\\1.0.0.0\\x86\n"+
                            "cfgstopscripttext=Идёт выполнение...Ctrl+S для ОСТАНОВКИ"
                            );
            ahk.LoadFile(Path.GetTempPath() + "\\AutoHotkey.Interop\\1.0.0.0\\x86\\macro_recorder_v02.ahk");
        }

        private void checkBox_DebugCheckedChanged(object sender, EventArgs e)
        {
            //more save code
            if (checkBox_Debug.Checked)
            {   if(listBox_Scripts.SelectedIndex != -1)
                    button_ChangeScript.Enabled = true;
            }
            else
            {
                if (listBox_Scripts.SelectedIndex != -1)
                    button_ChangeScript.Enabled = false;
            }

        }

        private void button_ChangeScript_Click(object sender, EventArgs e)
        {
            //need for save script name for intern use
            Form_EasyScript form_EasyScript = new Form_EasyScript(listBox_Scripts.SelectedItem.ToString());
            form_EasyScript.Show();
        }
    }
}
