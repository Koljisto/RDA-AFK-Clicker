using AutoHotkey.Interop;
using Dota2GSI;
using System;
using System.Configuration;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        Regex reg = new Regex(@"dota 2 beta");
        Regex reg_final = new Regex(@"dota 2 beta\\game\\dota\\cfg\\gamestate_integration");
        int game_minutes;
        int game_seconds;
        AutoHotkeyEngine ahk_helper;
        public Form_Main()
        {
            InitializeComponent();
            File.Copy("SystemScripts\\global_helper.ahk", Path.GetTempPath() + "\\AutoHotkey.Interop\\1.0.0.0\\x86\\global_helper.ahk", true);
            ahk_helper = AutoHotkeyEngine.Instance;
            ahk_helper.LoadFile(Path.GetTempPath() + "\\AutoHotkey.Interop\\1.0.0.0\\x86\\global_helper.ahk");
        }
        GameStateListener gsl;
        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.Menu = new MainMenu();
            MenuItem item = new MenuItem("Меню");
            this.Menu.MenuItems.Add(item);
            item.MenuItems.Add("Скрипты", new EventHandler(OpenScripts_Menu));
            item.MenuItems.Add("О программе", new EventHandler(AboutProgram_Menu));
            textBox_BindKey.Text = config.AppSettings.Settings["bind_key"].Value;
            textBox_GoldMax.Text = config.AppSettings.Settings["gold_max"].Value;
            label_Status.Text = "Ожидаю...";
            gsl = new GameStateListener(4000);
            gsl.NewGameState += new NewGameStateHandler(OnNewGameState);
            if (!gsl.Start())
            {
                //make save run
                MessageBox.Show("Пробуй запустить от администратора и проверь наличие конфига в Dota 2 (кнопка проверка) и после перезапусти кликер.");
            }
        }
        void OnNewGameState(GameState gs)
        {
            if (game_minutes != gs.Map.ClockTime / 60)
            {
                game_minutes = gs.Map.ClockTime / 60;
                //tick game minute funcs
                if (checkBox_MidListWaves.Checked)
                {
                    ahk_helper.ExecFunction("Print_Waves_List", "", "false");
                    UpdateWavesList();
                }
            }
            game_seconds = gs.Map.ClockTime % 60;
            label_GoldCounter.Text = gs.Player.Gold.ToString();
            label_GameTime.Text = game_minutes.ToString() + ":" + game_seconds.ToString();
            if (checkBox_Enable.Checked)
            {
                IntPtr WindowToFind = FindWindow(null, "Dota 2");
                label_Status.Text = "В работе.";
                if (WindowToFind != IntPtr.Zero)
                {
                    label_Status.Text = "В работе.";
                    if (gs.Player.Gold >= Int32.Parse(config.AppSettings.Settings["gold_max"].Value))
                    {
                        IntPtr tmp = GetForegroundWindow();
                        IntPtr tmpThread = GetWindowThreadProcessId(tmp, IntPtr.Zero);
                        IntPtr WindowToFindThread = GetWindowThreadProcessId(WindowToFind, IntPtr.Zero);
                        //if dota in active window
                        if (tmp == WindowToFind)
                        {
                            ahk_helper.ExecFunction("PressBuyButton_Active", config.AppSettings.Settings["bind_key"].Value, "1");
                        }
                        else
                        {
                            ahk_helper.ExecFunction("PressBuyButton_Inactive", config.AppSettings.Settings["bind_key"].Value, "1");
                        }
                    }
                }
                else
                {
                    label_Status.Text = "Dota 2 не открыта.";
                }
            }
            else
            {
                label_Status.Text = "Не включен.";
            }
            if (checkBox_Helper.Checked)
            {
                if (gs.Hero.Name.ToString() == "npc_dota_hero_treant")
                {
                    label_Cooldown.Text = gs.Abilities[1].Cooldown.ToString();
                    if (gs.Abilities[1].Cooldown == 0)
                    {
                        //Съешь дерево!
                        ahk_helper.ExecFunction("Print_Hero_Help", "Съешь дерево!", "true");
                    }
                    else
                    {
                        //Убрать сообщение
                        ahk_helper.ExecFunction("Print_Hero_Help", "", "false");
                    }
                }
                if (gs.Hero.Name.ToString() == "npc_dota_hero_tinker")
                {
                    //gs.Abilities.Count.ToString();
                    label_Cooldown.Text = gs.Abilities[4].Cooldown.ToString();
                    //form_message = new Form_Message("Test");
                    if (gs.Abilities[4].Cooldown == 0)
                    {
                        //Улучши башню!
                        ahk_helper.ExecFunction("Print_Hero_Help", "Улучши башню!", "true");
                    }
                    else
                    {
                        //Убрать текст
                        ahk_helper.ExecFunction("Print_Hero_Help", "", "false");
                    }
                }
            }

            if (checkBox_MidHelper.Checked)
            {
                if (checkBox_MidHelperNotify1.Checked && (game_seconds >= 10) && (game_seconds <= 12) && !((game_minutes % 5 != 0) && (game_minutes % 6 == 0)))
                {
                    ahk_helper.ExecFunction("Print_Notify1", "true");
                }
                else
                {
                    ahk_helper.ExecFunction("Print_Notify1", "false");
                }

                if (checkBox_MidHelperNotify2.Checked && (game_seconds >= 23) && (game_seconds <= 25) && !((game_minutes % 5 != 0) && (game_minutes % 6 == 0)))
                {
                    ahk_helper.ExecFunction("Print_Notify2", "true");
                }
                else
                {
                    ahk_helper.ExecFunction("Print_Notify2", "false");
                }

                if (checkBox_MidHelperNotify3.Checked && (game_seconds >= 31) && (game_seconds <= 33) && !((game_minutes % 5 != 0) && (game_minutes % 6 == 0)))
                {
                    ahk_helper.ExecFunction("Print_Notify3", "true");
                }
                else
                {
                    ahk_helper.ExecFunction("Print_Notify3", "false");
                }

                if (checkBox_MidOnlyBosses.Checked && (game_minutes % 5 == 0))
                {
                    ahk_helper.ExecFunction("Print_Wave_Boss", "boss", "true");
                }
                else
                {
                    ahk_helper.ExecFunction("Print_Wave_Boss", "", "false");
                }

                if (checkBox_MidOnlyCreeps.Checked && (game_minutes % 5 != 0) && (game_minutes % 6 != 0))
                {
                    ahk_helper.ExecFunction("Print_Wave_Creeps", "creeps", "true");
                }
                else
                {
                    ahk_helper.ExecFunction("Print_Wave_Creeps", "", "false");
                }

                if (checkBox_MidOnlyCreeps.Checked && (game_minutes % 5 != 0) && (game_minutes % 6 == 0))
                {
                    ahk_helper.ExecFunction("Print_Wave_Freetime", "free_time", "true");
                }
                else
                {
                    ahk_helper.ExecFunction("Print_Wave_Freetime", "", "false");
                }
            }
        }
        private void UpdateWavesList()
        {
            string tmp_string = "";
            for (int i = 0; i < 6; i++)
            {
                // tmp_list.Add((gs.Map.ClockTime / 60 % 5).ToString() + " - Босс");
                if ((game_minutes + i) % 5 == 0)
                {
                    tmp_string += (game_minutes + i).ToString() + " - Босс\n";
                }
                else if ((game_minutes + i) % 6 == 0)
                {
                    tmp_string += (game_minutes + i).ToString() + " - Freetime\n";
                }
                else
                {
                    tmp_string += (game_minutes + i).ToString() + " - Крипы\n";
                }
            }
            ahk_helper.ExecFunction("Print_Waves_List", tmp_string, "true");

        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_BindKey.Text.Length >= 1 && Int32.Parse(textBox_GoldMax.Text) > 0)
            {
                config.AppSettings.Settings["bind_key"].Value = textBox_BindKey.Text;
                config.AppSettings.Settings["gold_max"].Value = textBox_GoldMax.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                label_Status.Text = "Сохранено!";
            }
            else
            {
                MessageBox.Show("Введены неверные параметры. Золото должно быть больше нуля и написана любая клавиша (Length >= 1)");
            }
        }
        private void button_ShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("По пути: steamapps\\common\\dota 2 beta\\game\\dota\\cfg необходимо создать папку gamestate_integration \n" +
                "Чтобы путь получился: steamapps\\common\\dota 2 beta\\game\\dota\\cfg\\gamestate_integration\n" +
                "В эту папку скопировать файл, данный в архиве\n");
        }
        private void button_SettingConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Укажите путь до папки игры Dota 2");
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var matched = reg.Match(fbd.SelectedPath.ToString());
                    DirectoryInfo tmpdir = new DirectoryInfo(fbd.SelectedPath.ToString() + "\\game\\dota\\cfg\\gamestate_integration");
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
                        }
                        else
                        {
                            MessageBox.Show("Указан неверный путь, необходимо выбрать на подобии:\n dota 2 beta\\game\\dota\\cfg\\gamestate_integration");
                        }
                    }
                }
            }
        }
        private void OpenScripts_Menu(object sender, EventArgs e)
        {
            //Form_Scripts form_scripts = new Form_Scripts();
            //form_scripts.Show();
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
            gsl.Stop();
            gsl.Dispose();
        }
        private void checkBox_MidListWaves_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_MidListWaves.Checked)
            {
                ahk_helper.ExecFunction("Print_Waves_List", "", "false");
                UpdateWavesList();
            }
            else
            {
                ahk_helper.ExecFunction("Print_Waves_List", "", "false");
            }
        }
        private void checkBox_Helper_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Helper.Checked)
                ahk_helper.ExecFunction("Print_Hero_Help", "", "false");
        }
        private void checkBox_FullAFK_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_FullAFK.Checked)
            {
                ahk_helper.ExecFunction("ChangeTransparent", "Off");
            }
            else
            {
                ahk_helper.ExecFunction("ChangeTransparent", "0");
            }
        }
        private void checkBox_Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Enable.Checked)
            {
                //ahk_helper.SetVar("manual_stop", "false");
                //label_Status.Text = ahk_helper.GetVar("manual_stop");
                ahk_helper.ExecFunction("Print_Disable_AutoBuy", "true");
            }
        }
    }
}
