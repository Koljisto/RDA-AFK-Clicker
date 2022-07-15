namespace RDA_AFK_Clicker
{
    partial class Form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.label_Gold = new System.Windows.Forms.Label();
            this.label_BindKey = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.checkBox_Enable = new System.Windows.Forms.CheckBox();
            this.label_GoldCounter = new System.Windows.Forms.Label();
            this.button_SettingConfig = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label_GoldMax = new System.Windows.Forms.Label();
            this.textBox_GoldMax = new System.Windows.Forms.TextBox();
            this.checkBox_Helper = new System.Windows.Forms.CheckBox();
            this.label_CooldownText = new System.Windows.Forms.Label();
            this.label_Cooldown = new System.Windows.Forms.Label();
            this.checkBox_MidHelper = new System.Windows.Forms.CheckBox();
            this.label_GameTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_MidListWaves = new System.Windows.Forms.CheckBox();
            this.checkBox_MidOnlyCreeps = new System.Windows.Forms.CheckBox();
            this.checkBox_MidOnlyBosses = new System.Windows.Forms.CheckBox();
            this.checkBox_MidHelperNotify1 = new System.Windows.Forms.CheckBox();
            this.checkBox_MidHelperNotify2 = new System.Windows.Forms.CheckBox();
            this.checkBox_MidHelperNotify3 = new System.Windows.Forms.CheckBox();
            this.checkBox_FullAFK = new System.Windows.Forms.CheckBox();
            this.textBox_BindKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Gold
            // 
            this.label_Gold.AutoSize = true;
            this.label_Gold.Location = new System.Drawing.Point(16, 64);
            this.label_Gold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Gold.Name = "label_Gold";
            this.label_Gold.Size = new System.Drawing.Size(58, 16);
            this.label_Gold.TabIndex = 0;
            this.label_Gold.Text = "Золото:";
            // 
            // label_BindKey
            // 
            this.label_BindKey.AutoSize = true;
            this.label_BindKey.Location = new System.Drawing.Point(16, 96);
            this.label_BindKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_BindKey.Name = "label_BindKey";
            this.label_BindKey.Size = new System.Drawing.Size(67, 16);
            this.label_BindKey.TabIndex = 0;
            this.label_BindKey.Text = "Клавиша:";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(16, 153);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(199, 49);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Статус:";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(80, 206);
            this.label_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(53, 16);
            this.label_Status.TabIndex = 5;
            this.label_Status.Text = "Статус";
            // 
            // checkBox_Enable
            // 
            this.checkBox_Enable.AutoSize = true;
            this.checkBox_Enable.Location = new System.Drawing.Point(16, 15);
            this.checkBox_Enable.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_Enable.Name = "checkBox_Enable";
            this.checkBox_Enable.Size = new System.Drawing.Size(93, 20);
            this.checkBox_Enable.TabIndex = 6;
            this.checkBox_Enable.Text = "Включить";
            this.checkBox_Enable.UseVisualStyleBackColor = true;
            this.checkBox_Enable.CheckedChanged += new System.EventHandler(this.checkBox_Enable_CheckedChanged);
            // 
            // label_GoldCounter
            // 
            this.label_GoldCounter.AutoSize = true;
            this.label_GoldCounter.Location = new System.Drawing.Point(69, 64);
            this.label_GoldCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GoldCounter.Name = "label_GoldCounter";
            this.label_GoldCounter.Size = new System.Drawing.Size(14, 16);
            this.label_GoldCounter.TabIndex = 7;
            this.label_GoldCounter.Text = "0";
            // 
            // button_SettingConfig
            // 
            this.button_SettingConfig.Location = new System.Drawing.Point(233, 170);
            this.button_SettingConfig.Margin = new System.Windows.Forms.Padding(4);
            this.button_SettingConfig.Name = "button_SettingConfig";
            this.button_SettingConfig.Size = new System.Drawing.Size(129, 74);
            this.button_SettingConfig.TabIndex = 9;
            this.button_SettingConfig.Text = "Настройка файла";
            this.button_SettingConfig.UseVisualStyleBackColor = true;
            this.button_SettingConfig.Click += new System.EventHandler(this.button_SettingConfig_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Я работаю";
            this.notifyIcon1.BalloonTipTitle = "И даже в свёрнутом режиме.";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RDA-AFK-Clicker";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // label_GoldMax
            // 
            this.label_GoldMax.AutoSize = true;
            this.label_GoldMax.Location = new System.Drawing.Point(16, 129);
            this.label_GoldMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GoldMax.Name = "label_GoldMax";
            this.label_GoldMax.Size = new System.Drawing.Size(104, 16);
            this.label_GoldMax.TabIndex = 11;
            this.label_GoldMax.Text = "Лимит золота: ";
            // 
            // textBox_GoldMax
            // 
            this.textBox_GoldMax.Location = new System.Drawing.Point(136, 126);
            this.textBox_GoldMax.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_GoldMax.Name = "textBox_GoldMax";
            this.textBox_GoldMax.Size = new System.Drawing.Size(79, 22);
            this.textBox_GoldMax.TabIndex = 12;
            this.textBox_GoldMax.Text = "90000";
            // 
            // checkBox_Helper
            // 
            this.checkBox_Helper.AutoSize = true;
            this.checkBox_Helper.Location = new System.Drawing.Point(16, 39);
            this.checkBox_Helper.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_Helper.Name = "checkBox_Helper";
            this.checkBox_Helper.Size = new System.Drawing.Size(96, 20);
            this.checkBox_Helper.TabIndex = 13;
            this.checkBox_Helper.Text = "Помощник";
            this.checkBox_Helper.UseVisualStyleBackColor = true;
            this.checkBox_Helper.CheckedChanged += new System.EventHandler(this.checkBox_Helper_CheckedChanged);
            // 
            // label_CooldownText
            // 
            this.label_CooldownText.AutoSize = true;
            this.label_CooldownText.Location = new System.Drawing.Point(113, 64);
            this.label_CooldownText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CooldownText.Name = "label_CooldownText";
            this.label_CooldownText.Size = new System.Drawing.Size(27, 16);
            this.label_CooldownText.TabIndex = 14;
            this.label_CooldownText.Text = "КД:";
            // 
            // label_Cooldown
            // 
            this.label_Cooldown.AutoSize = true;
            this.label_Cooldown.Location = new System.Drawing.Point(137, 64);
            this.label_Cooldown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Cooldown.Name = "label_Cooldown";
            this.label_Cooldown.Size = new System.Drawing.Size(14, 16);
            this.label_Cooldown.TabIndex = 15;
            this.label_Cooldown.Text = "0";
            // 
            // checkBox_MidHelper
            // 
            this.checkBox_MidHelper.AutoSize = true;
            this.checkBox_MidHelper.Location = new System.Drawing.Point(116, 39);
            this.checkBox_MidHelper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_MidHelper.Name = "checkBox_MidHelper";
            this.checkBox_MidHelper.Size = new System.Drawing.Size(72, 20);
            this.checkBox_MidHelper.TabIndex = 16;
            this.checkBox_MidHelper.Text = "Мидер";
            this.checkBox_MidHelper.UseVisualStyleBackColor = true;
            // 
            // label_GameTime
            // 
            this.label_GameTime.AutoSize = true;
            this.label_GameTime.Location = new System.Drawing.Point(80, 228);
            this.label_GameTime.Name = "label_GameTime";
            this.label_GameTime.Size = new System.Drawing.Size(38, 16);
            this.label_GameTime.TabIndex = 18;
            this.label_GameTime.Text = "99:99";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Время:";
            // 
            // checkBox_MidListWaves
            // 
            this.checkBox_MidListWaves.AutoSize = true;
            this.checkBox_MidListWaves.Location = new System.Drawing.Point(233, 15);
            this.checkBox_MidListWaves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_MidListWaves.Name = "checkBox_MidListWaves";
            this.checkBox_MidListWaves.Size = new System.Drawing.Size(111, 20);
            this.checkBox_MidListWaves.TabIndex = 20;
            this.checkBox_MidListWaves.Text = "Список волн";
            this.checkBox_MidListWaves.UseVisualStyleBackColor = true;
            this.checkBox_MidListWaves.CheckedChanged += new System.EventHandler(this.checkBox_MidListWaves_CheckedChanged);
            // 
            // checkBox_MidOnlyCreeps
            // 
            this.checkBox_MidOnlyCreeps.AutoSize = true;
            this.checkBox_MidOnlyCreeps.Location = new System.Drawing.Point(233, 39);
            this.checkBox_MidOnlyCreeps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_MidOnlyCreeps.Name = "checkBox_MidOnlyCreeps";
            this.checkBox_MidOnlyCreeps.Size = new System.Drawing.Size(119, 20);
            this.checkBox_MidOnlyCreeps.TabIndex = 20;
            this.checkBox_MidOnlyCreeps.Text = "Только крипы";
            this.checkBox_MidOnlyCreeps.UseVisualStyleBackColor = true;
            // 
            // checkBox_MidOnlyBosses
            // 
            this.checkBox_MidOnlyBosses.AutoSize = true;
            this.checkBox_MidOnlyBosses.Location = new System.Drawing.Point(233, 64);
            this.checkBox_MidOnlyBosses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_MidOnlyBosses.Name = "checkBox_MidOnlyBosses";
            this.checkBox_MidOnlyBosses.Size = new System.Drawing.Size(118, 20);
            this.checkBox_MidOnlyBosses.TabIndex = 20;
            this.checkBox_MidOnlyBosses.Text = "Только боссы";
            this.checkBox_MidOnlyBosses.UseVisualStyleBackColor = true;
            // 
            // checkBox_MidHelperNotify1
            // 
            this.checkBox_MidHelperNotify1.AutoSize = true;
            this.checkBox_MidHelperNotify1.Location = new System.Drawing.Point(233, 92);
            this.checkBox_MidHelperNotify1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_MidHelperNotify1.Name = "checkBox_MidHelperNotify1";
            this.checkBox_MidHelperNotify1.Size = new System.Drawing.Size(129, 20);
            this.checkBox_MidHelperNotify1.TabIndex = 20;
            this.checkBox_MidHelperNotify1.Text = "Уведомление 1";
            this.checkBox_MidHelperNotify1.UseVisualStyleBackColor = true;
            // 
            // checkBox_MidHelperNotify2
            // 
            this.checkBox_MidHelperNotify2.AutoSize = true;
            this.checkBox_MidHelperNotify2.Location = new System.Drawing.Point(233, 116);
            this.checkBox_MidHelperNotify2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_MidHelperNotify2.Name = "checkBox_MidHelperNotify2";
            this.checkBox_MidHelperNotify2.Size = new System.Drawing.Size(129, 20);
            this.checkBox_MidHelperNotify2.TabIndex = 20;
            this.checkBox_MidHelperNotify2.Text = "Уведомление 2";
            this.checkBox_MidHelperNotify2.UseVisualStyleBackColor = true;
            // 
            // checkBox_MidHelperNotify3
            // 
            this.checkBox_MidHelperNotify3.AutoSize = true;
            this.checkBox_MidHelperNotify3.Location = new System.Drawing.Point(233, 144);
            this.checkBox_MidHelperNotify3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_MidHelperNotify3.Name = "checkBox_MidHelperNotify3";
            this.checkBox_MidHelperNotify3.Size = new System.Drawing.Size(129, 20);
            this.checkBox_MidHelperNotify3.TabIndex = 20;
            this.checkBox_MidHelperNotify3.Text = "Уведомление 3";
            this.checkBox_MidHelperNotify3.UseVisualStyleBackColor = true;
            // 
            // checkBox_FullAFK
            // 
            this.checkBox_FullAFK.AutoSize = true;
            this.checkBox_FullAFK.Location = new System.Drawing.Point(116, 15);
            this.checkBox_FullAFK.Name = "checkBox_FullAFK";
            this.checkBox_FullAFK.Size = new System.Drawing.Size(111, 20);
            this.checkBox_FullAFK.TabIndex = 21;
            this.checkBox_FullAFK.Text = "Полный АФК";
            this.checkBox_FullAFK.UseVisualStyleBackColor = true;
            this.checkBox_FullAFK.CheckedChanged += new System.EventHandler(this.checkBox_FullAFK_CheckedChanged);
            // 
            // textBox_BindKey
            // 
            this.textBox_BindKey.Location = new System.Drawing.Point(115, 93);
            this.textBox_BindKey.Name = "textBox_BindKey";
            this.textBox_BindKey.Size = new System.Drawing.Size(100, 22);
            this.textBox_BindKey.TabIndex = 22;
            this.textBox_BindKey.Text = "F8";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(440, 290);
            this.Controls.Add(this.textBox_BindKey);
            this.Controls.Add(this.checkBox_FullAFK);
            this.Controls.Add(this.checkBox_MidHelperNotify3);
            this.Controls.Add(this.checkBox_MidHelperNotify2);
            this.Controls.Add(this.checkBox_MidHelperNotify1);
            this.Controls.Add(this.checkBox_MidOnlyBosses);
            this.Controls.Add(this.checkBox_MidOnlyCreeps);
            this.Controls.Add(this.checkBox_MidListWaves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_GameTime);
            this.Controls.Add(this.checkBox_MidHelper);
            this.Controls.Add(this.label_Cooldown);
            this.Controls.Add(this.label_CooldownText);
            this.Controls.Add(this.checkBox_Helper);
            this.Controls.Add(this.textBox_GoldMax);
            this.Controls.Add(this.label_GoldMax);
            this.Controls.Add(this.button_SettingConfig);
            this.Controls.Add(this.label_GoldCounter);
            this.Controls.Add(this.checkBox_Enable);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_BindKey);
            this.Controls.Add(this.label_Gold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(439, 328);
            this.Name = "Form_Main";
            this.Text = "RDA-Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResizeEnd += new System.EventHandler(this.Form_Main_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Gold;
        private System.Windows.Forms.Label label_BindKey;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.CheckBox checkBox_Enable;
        private System.Windows.Forms.Label label_GoldCounter;
        private System.Windows.Forms.Button button_SettingConfig;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label_GoldMax;
        private System.Windows.Forms.TextBox textBox_GoldMax;
        private System.Windows.Forms.CheckBox checkBox_Helper;
        private System.Windows.Forms.Label label_CooldownText;
        private System.Windows.Forms.Label label_Cooldown;
        private System.Windows.Forms.CheckBox checkBox_MidHelper;
        private System.Windows.Forms.Label label_GameTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_MidListWaves;
        private System.Windows.Forms.CheckBox checkBox_MidOnlyCreeps;
        private System.Windows.Forms.CheckBox checkBox_MidOnlyBosses;
        private System.Windows.Forms.CheckBox checkBox_MidHelperNotify1;
        private System.Windows.Forms.CheckBox checkBox_MidHelperNotify2;
        private System.Windows.Forms.CheckBox checkBox_MidHelperNotify3;
        private System.Windows.Forms.CheckBox checkBox_FullAFK;
        private System.Windows.Forms.TextBox textBox_BindKey;
    }
}
