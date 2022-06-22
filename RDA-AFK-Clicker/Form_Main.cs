using Dota2GSI;
using Dota2GSI.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;
using System.Configuration;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;

namespace RDA_AFK_Clicker
{
    public partial class Form_Main : Form
    {
        //const int WM_CHAR = 0x71;
        //const int WM_SYSKEYDOWN = 0x0104;
        //const int WM_SYSKEYUP = 0x0105;
        //const int WM_KEYDOWN = 0x0100;
        //const int WM_KEYUP = 0x0101;

        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        static readonly IntPtr HWND_TOP = new IntPtr(0);
        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        //[DllImport("User32.dll")]
        //static extern int SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        /*[DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, UIntPtr lParam);*/
        [DllImport("user32.dll")]
        private static extern int AttachThreadInput(IntPtr CurrentForegroundThread, IntPtr MakeThisThreadForegrouond, bool boolAttach);
        [DllImport("user32.dll")]
        private static extern int SetFocus(IntPtr hwnd);
        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, IntPtr lpdwProcessId);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        private const int WS_EX_LAYERED = 0x00080000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_EXSTYLE = -20;
        InputSimulator sim = new InputSimulator();
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        Regex reg = new Regex(@"dota 2 beta");
        Regex reg_final = new Regex(@"dota 2 beta\\game\\dota\\cfg\\gamestate_integration");
        VirtualKeyCode selectedKeyCode;
        Form_Message form_message = new Form_Message("Aboba");
        public Form_Main()
        {
            InitializeComponent();
        }
        GameStateListener gsl;
        private void Form_Main_Load(object sender, EventArgs e)
        {
            //form_message = new Form_Message("Test");
            
            this.Menu = new MainMenu();
            MenuItem item = new MenuItem("Меню");
            this.Menu.MenuItems.Add(item);
            item.MenuItems.Add("Скрипты", new EventHandler(OpenScripts_Menu));
            item.MenuItems.Add("О программе", new EventHandler(AboutProgram_Menu));
            //item.MenuItems.Add("Open", new EventHandler(Open_Click));
            //kostili
            switch (config.AppSettings.Settings["bind_key"].Value)
            {
                case "F1":
                    selectedKeyCode = VirtualKeyCode.F1;
                    domainUpDown_BindKey.SelectedIndex = 0;
                    break;
                case "F2":
                    selectedKeyCode = VirtualKeyCode.F2;
                    domainUpDown_BindKey.SelectedIndex = 1;
                    break;
                case "F3":
                    selectedKeyCode = VirtualKeyCode.F3;
                    domainUpDown_BindKey.SelectedIndex = 2;
                    break;
                case "F4":
                    selectedKeyCode = VirtualKeyCode.F4;
                    domainUpDown_BindKey.SelectedIndex = 3;
                    break;
                case "F5":
                    selectedKeyCode = VirtualKeyCode.F5;
                    domainUpDown_BindKey.SelectedIndex = 4;
                    break;
                case "F6":
                    selectedKeyCode = VirtualKeyCode.F6;
                    domainUpDown_BindKey.SelectedIndex = 5;
                    break;
                case "F7":
                    selectedKeyCode = VirtualKeyCode.F7;
                    domainUpDown_BindKey.SelectedIndex = 6;
                    break;
                case "F8":
                    selectedKeyCode = VirtualKeyCode.F8;
                    domainUpDown_BindKey.SelectedIndex = 7;
                    break;
                case "F10":
                    selectedKeyCode = VirtualKeyCode.F10;
                    domainUpDown_BindKey.SelectedIndex = 8;
                    break;
                default:
                    break;
            }
            textBox_GoldMax.Text = config.AppSettings.Settings["gold_max"].Value;
            label_Status.Text = "Ожидаю...";
            gsl = new GameStateListener(4000);
            gsl.NewGameState += new NewGameStateHandler(OnNewGameState);
            if (!gsl.Start())
            {
                //this not calling, but make save run
                MessageBox.Show("Пробуй запустить от администратора и проверь наличие конфига в Dota 2.\nЗакрываю.");
                Environment.Exit(0);
            }
        }
        void OnNewGameState(GameState gs)
        {
            label_GoldCounter.Text = gs.Player.Gold.ToString();
            if (checkBox_Enable.Checked)
            {
                IntPtr WindowToFind = FindWindow(null, "Dota 2");
                label_Status.Text = "В работе.";
                if (WindowToFind != IntPtr.Zero)
                {
                    label_Status.Text = "В работе.";
                    //SendMessage(WindowToFind, WM_KEYDOWN, (IntPtr)WM_CHAR, (UIntPtr)0x00410001);
                    //SendMessage(WindowToFind, WM_KEYUP, (IntPtr)WM_CHAR, (UIntPtr)0xC0410001);
                    if (gs.Player.Gold >= Int32.Parse(config.AppSettings.Settings["gold_max"].Value))
                    {
                        IntPtr tmp = GetForegroundWindow();
                        IntPtr tmpThread = GetWindowThreadProcessId(tmp, IntPtr.Zero);
                        IntPtr WindowToFindThread = GetWindowThreadProcessId(WindowToFind, IntPtr.Zero);
                        //if dota in active window
                        if(tmp == WindowToFind)
                        {
                            sim.Keyboard.KeyUp(VirtualKeyCode.LMENU);
                            sim.Keyboard.KeyPress(selectedKeyCode);
                        } else
                        {
                            AttachThreadInput(tmpThread, WindowToFindThread, true);
                            AttachThreadInput(WindowToFindThread, tmpThread, false);
                            SetFocus(WindowToFind);
                            //make sure if works need 100 ms delay
                            System.Threading.Thread.Sleep(100);
                            //keyup system key LAlt
                            sim.Keyboard.KeyUp(VirtualKeyCode.LMENU);
                            sim.Keyboard.KeyPress(selectedKeyCode);
                            SetFocus(tmp);
                            AttachThreadInput(tmpThread, WindowToFindThread, false);
                            AttachThreadInput(WindowToFindThread, tmpThread, true);
                        }
                    }
                }
                else
                {
                    label_Status.Text = "Нет окна.";
                }
            } else
            {
                label_Status.Text = "Остановлен.";
            }
            if (checkBox_Helper.Checked)
            {
                label_HeroName.Text = gs.Abilities[1].Cooldown.ToString();
                if (gs.Hero.Name.ToString() == "npc_dota_hero_treant")
                {
                    //form_message = new Form_Message("Test");
                    if (gs.Abilities[1].Cooldown == 0)
                    {
                        if (!form_message.IsHandleCreated)
                        {
                            form_message.Close();
                            form_message = new Form_Message("Прожми дерево!");
                            form_message.Show();
                        }
                    }
                    else
                    {
                        if (form_message.IsHandleCreated)
                            form_message.Close();
                    }
                }
                //label_HeroName.Text = gs.Hero.Name.ToString();
                //label_HeroName.Text = gs.Abilities[1].Cooldown.ToString();
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if(domainUpDown_BindKey.SelectedItem.ToString().Length == 2 && Int32.Parse(textBox_GoldMax.Text) > 0)
            {
                switch (domainUpDown_BindKey.SelectedItem.ToString())
                {
                    case "F1":
                        selectedKeyCode = VirtualKeyCode.F1;
                        config.AppSettings.Settings["bind_key"].Value = "F1";
                        break;
                    case "F2":
                        selectedKeyCode = VirtualKeyCode.F2;
                        config.AppSettings.Settings["bind_key"].Value = "F2";
                        break;
                    case "F3":
                        selectedKeyCode = VirtualKeyCode.F3;
                        config.AppSettings.Settings["bind_key"].Value = "F3";
                        break;
                    case "F4":
                        selectedKeyCode = VirtualKeyCode.F4;
                        config.AppSettings.Settings["bind_key"].Value = "F4";
                        break;
                    case "F5":
                        selectedKeyCode = VirtualKeyCode.F5;
                        config.AppSettings.Settings["bind_key"].Value = "F5";
                        break;
                    case "F6":
                        selectedKeyCode = VirtualKeyCode.F6;
                        config.AppSettings.Settings["bind_key"].Value = "F6";
                        break;
                    case "F7":
                        selectedKeyCode = VirtualKeyCode.F7;
                        config.AppSettings.Settings["bind_key"].Value = "F7";
                        break;
                    case "F8":
                        selectedKeyCode = VirtualKeyCode.F8;
                        config.AppSettings.Settings["bind_key"].Value = "F8";
                        break;
                    case "F10":
                        selectedKeyCode = VirtualKeyCode.F10;
                        config.AppSettings.Settings["bind_key"].Value = "F10";
                        break;
                    default:
                        MessageBox.Show("Введён неверный бинд клавиши. Восстановлена последняя успешная");
                        break;
                }
                config.AppSettings.Settings["gold_max"].Value = textBox_GoldMax.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                label_Status.Text = "Сохранено!";
            } else
            {
                MessageBox.Show("Введены неверные параметры");
            }
        }

        private void button_ShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("По пути: steamapps\\common\\dota 2 beta\\game\\dota\\cfg необходимо создать папку gamestate_integration \n" +
                "Чтобы путь получился: steamapps\\common\\dota 2 beta\\game\\dota\\cfg\\gamestate_integration\n" +
                "В эту папку скопировать файл, данный в архиве\n");
        }

        private void button_IsWorking_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Укажите путь до папки игры Dota 2");
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var matched = reg.Match(fbd.SelectedPath.ToString());
                    DirectoryInfo tmpdir = new DirectoryInfo(fbd.SelectedPath.ToString()+ "\\game\\dota\\cfg\\gamestate_integration");
                    if (!Directory.Exists(tmpdir.ToString()))
                    {
                        Directory.CreateDirectory(tmpdir.ToString());
                    }
                    if (matched.Success)
                    {
                        var matched_final = reg_final.Match(tmpdir.ToString());
                        if (matched_final.Success)
                        {
                            File.WriteAllText(tmpdir + "\\gamestate_integration_test.cfg",
                            "\"Dota 2 Integration Configuration\"\n" +
                            "{\n" +
                            "    \"uri\"           \"http://localhost:4000/\"\n" +
                            "    \"timeout\"       \"5.0\"\n" +
                            "    \"buffer\"        \"0.1\"\n" +
                            "    \"throttle\"      \"0.1\"\n" +
                            "    \"heartbeat\"     \"30.0\"\n" +
                            "    \"data\"\n" +
                            "    {\n" +
                            "        \"provider\"      \"1\"\n" +
                            "        \"map\"           \"1\"\n" +
                            "        \"player\"        \"1\"\n" +
                            "        \"hero\"          \"1\"\n" +
                            "        \"abilities\"     \"1\"\n" +
                            "        \"items\"         \"1\"\n" +
                            "    }\n" +
                            "}\n"
                            );
                            MessageBox.Show("Файл был успешно создан.");
                        } else
                        {
                            MessageBox.Show("Указан неверный путь, необходимо выбрать на подобии:\n dota 2 beta\\game\\dota\\cfg\\gamestate_integration");
                        }
                    }
                }
            }
        }

        private void OpenScripts_Menu(object sender, EventArgs e)
        {
            Form_Scripts form_scripts = new Form_Scripts();
            form_scripts.Show();
        }
        private void AboutProgram_Menu(object sender, EventArgs e)
        {
            Form_About form_about = new Form_About();
            form_about.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form_Main_ResizeEnd(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Icon.Dispose();
            notifyIcon1.Dispose();
        }
    }
}
