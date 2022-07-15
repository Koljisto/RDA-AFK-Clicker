using AutoHotkey.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDA_AFK_Clicker
{
    public partial class Form_EasyScript : Form
    {
        private string script_Name;
        public Form_EasyScript(string name_Script)
        {
            script_Name = name_Script;
            InitializeComponent();
        }
        Regex reg_command = new Regex(@"\w+");
        private void Form_EasyScript_Load(object sender, EventArgs e)
        {
            domainUpDown_Command.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Время измеряется в миллисекундах\n" +
                            "Поэтому 1 секунда - это 1000\n" +
                            "Клавиша вписывается только одна и только на английском\n" +
                            "Координаты мышки только через пробел между x и y\n" +
                            "ВАЖНО ДЕЛАТЬ ЗАДЕРЖКИ МЕЖДУ КЛИКАМИ\n" +
                            "ЕСЛИ НЕ РАБОТАЕТ, ТО ЗАДЕРЖКУ В НАЧАЛО СКРИПТА СДЕЛАЙТЕ\n"
                            );
        }

        private void domainUpDown_Command_SelectedItemChanged(object sender, EventArgs e)
        {
            switch (domainUpDown_Command.SelectedIndex)
            {
                case 0:
                    textBox_Param.Text = "1000";
                    checkBox_HookMouse.Enabled = false;
                    button_Save.Enabled = true;
                    break;
                case 1:
                    textBox_Param.Text = "100 100";
                    checkBox_HookMouse.Enabled = true;
                    button_Save.Enabled = true;
                    break;
                case 2:
                    textBox_Param.Text = "F";
                    checkBox_HookMouse.Enabled = false;
                    button_Save.Enabled = true;
                    break;
                case 3:
                    textBox_Param.Text = "Left";
                    checkBox_HookMouse.Enabled = false;
                    button_Save.Enabled = true;
                    break;
            }
        }

        private void button_SaveClick(object sender, EventArgs e)
        {
            if(listBox_Commands.SelectedIndex == -1) { return; }
            listBox_Commands.Items[listBox_Commands.SelectedIndex] = domainUpDown_Command.SelectedItem.ToString() + ";" + textBox_Param.Text;
            //default header for script
            string tmp_Script = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\SystemScripts\\base_include.ahk");
            foreach (object item in listBox_Commands.Items)
            {
                var matchAll = reg_command.Matches(item.ToString());
                switch (matchAll[0].ToString())
                {
                    case "Время":
                        tmp_Script += "    sleep " + matchAll[1].ToString() + "\n";
                        break;
                    case "Курсор":
                        tmp_Script += "    MouseMove, " + matchAll[1].ToString() + ", " + matchAll[2].ToString() + ", 2\n";
                        break;
                    case "Клавиша":
                        tmp_Script += "    sleep 4\nSend {" + matchAll[1].ToString() + " down}\nsleep 23\nSend {" + matchAll[1].ToString() + " up}" + "\n";
                        break;
                    case "Мышь":
                        tmp_Script += "    sleep 4\nClick, down " + (matchAll[1].ToString() == "Right" ? matchAll[1].ToString() : "") + "\nsleep 23\nClick, up " + (matchAll[1].ToString() == "Right" ? matchAll[1].ToString() : "") + "\n";
                        break;
                }
            }
            //add tail in script
            tmp_Script += "}\n" +
                "^s:: ExitApp\n" +
                "loop:=0\n" +
                "ExitApp\n" +
                "return\n";
            //MessageBox.Show(tmp_Script);
            //save as new script
            File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\Scripts\\" + script_Name, tmp_Script);
            //MessageBox.Show(tmp);
        }

        private void button_AddCommandClick(object sender, EventArgs e)
        {
            //if list is empty or not selected then create new item on top list
            if (listBox_Commands.SelectedIndex == -1)
            {
                listBox_Commands.Items.Add("Новая команда");
                return;
            }
            //if index equal 0 need create new item down else create on current index
            if(listBox_Commands.SelectedIndex == 0)
                listBox_Commands.Items.Insert(listBox_Commands.SelectedIndex + 1, "Новая команда");
            else
                listBox_Commands.Items.Insert(listBox_Commands.SelectedIndex, "Новая команда");
        }

        private void button_RemoveCommand_Click(object sender, EventArgs e)
        {
            if(listBox_Commands.SelectedIndex == -1) { return; }
            listBox_Commands.Items.RemoveAt(listBox_Commands.SelectedIndex);
        }

        private void checkBox_HookMouseCheckedChanged(object sender, EventArgs e)
        {
            //if hook checkbox is true then start ahk with mouse pos
            if (checkBox_HookMouse.Checked)
            {
                AutoHotkeyEngine ahk = AutoHotkeyEngine.Instance;
                ahk.LoadFile(Path.GetDirectoryName(Application.ExecutablePath) + "\\SystemScripts\\mousepos.ahk");
                checkBox_HookMouse.Enabled = false;
                checkBox_HookMouse.Checked = false;
            }
        }

        private void listBox_Commands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox_Commands.SelectedIndex == -1) { return; }
            //get listbox item and put it in regex for convert it in params
            var matchAll = reg_command.Matches(listBox_Commands.SelectedItem.ToString());
            if (matchAll[0].Success)
                switch (matchAll[0].ToString())
                {
                    case "Время":
                        domainUpDown_Command.SelectedIndex = 0;
                        textBox_Param.Text = matchAll[1].ToString();
                        break;
                    case "Курсор":
                        domainUpDown_Command.SelectedIndex = 1;
                        textBox_Param.Text = matchAll[1].ToString();
                        textBox_Param.Text += " " + matchAll[2].ToString();
                        break;
                    case "Клавиша":
                        domainUpDown_Command.SelectedIndex = 2;
                        textBox_Param.Text = matchAll[1].ToString();
                        break;
                    case "Мышь":
                        domainUpDown_Command.SelectedIndex = 3;
                        textBox_Param.Text = matchAll[1].ToString();
                        break;
                }
        }
    }
}
