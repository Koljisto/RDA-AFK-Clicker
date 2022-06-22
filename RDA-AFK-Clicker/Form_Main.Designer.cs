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
            this.domainUpDown_BindKey = new System.Windows.Forms.DomainUpDown();
            this.button_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.checkBox_Enable = new System.Windows.Forms.CheckBox();
            this.label_GoldCounter = new System.Windows.Forms.Label();
            this.button_IsWorking = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label_GoldMax = new System.Windows.Forms.Label();
            this.textBox_GoldMax = new System.Windows.Forms.TextBox();
            this.checkBox_Helper = new System.Windows.Forms.CheckBox();
            this.label_HeroNameText = new System.Windows.Forms.Label();
            this.label_HeroName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Gold
            // 
            this.label_Gold.AutoSize = true;
            this.label_Gold.Location = new System.Drawing.Point(12, 52);
            this.label_Gold.Name = "label_Gold";
            this.label_Gold.Size = new System.Drawing.Size(46, 13);
            this.label_Gold.TabIndex = 0;
            this.label_Gold.Text = "Золото:";
            // 
            // label_BindKey
            // 
            this.label_BindKey.AutoSize = true;
            this.label_BindKey.Location = new System.Drawing.Point(12, 78);
            this.label_BindKey.Name = "label_BindKey";
            this.label_BindKey.Size = new System.Drawing.Size(55, 13);
            this.label_BindKey.TabIndex = 0;
            this.label_BindKey.Text = "Клавиша:";
            // 
            // domainUpDown_BindKey
            // 
            this.domainUpDown_BindKey.Items.Add("F1");
            this.domainUpDown_BindKey.Items.Add("F2");
            this.domainUpDown_BindKey.Items.Add("F3");
            this.domainUpDown_BindKey.Items.Add("F4");
            this.domainUpDown_BindKey.Items.Add("F5");
            this.domainUpDown_BindKey.Items.Add("F6");
            this.domainUpDown_BindKey.Items.Add("F7");
            this.domainUpDown_BindKey.Items.Add("F8");
            this.domainUpDown_BindKey.Items.Add("F10");
            this.domainUpDown_BindKey.Location = new System.Drawing.Point(73, 76);
            this.domainUpDown_BindKey.Name = "domainUpDown_BindKey";
            this.domainUpDown_BindKey.Size = new System.Drawing.Size(139, 20);
            this.domainUpDown_BindKey.TabIndex = 2;
            this.domainUpDown_BindKey.Tag = "";
            this.domainUpDown_BindKey.Text = "Выбери бинд";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(12, 124);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(200, 40);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Статус:";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(62, 167);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(37, 13);
            this.label_Status.TabIndex = 5;
            this.label_Status.Text = "Status";
            // 
            // checkBox_Enable
            // 
            this.checkBox_Enable.AutoSize = true;
            this.checkBox_Enable.Location = new System.Drawing.Point(12, 12);
            this.checkBox_Enable.Name = "checkBox_Enable";
            this.checkBox_Enable.Size = new System.Drawing.Size(75, 17);
            this.checkBox_Enable.TabIndex = 6;
            this.checkBox_Enable.Text = "Включить";
            this.checkBox_Enable.UseVisualStyleBackColor = true;
            // 
            // label_GoldCounter
            // 
            this.label_GoldCounter.AutoSize = true;
            this.label_GoldCounter.Location = new System.Drawing.Point(74, 52);
            this.label_GoldCounter.Name = "label_GoldCounter";
            this.label_GoldCounter.Size = new System.Drawing.Size(13, 13);
            this.label_GoldCounter.TabIndex = 7;
            this.label_GoldCounter.Text = "0";
            // 
            // button_IsWorking
            // 
            this.button_IsWorking.Location = new System.Drawing.Point(137, 22);
            this.button_IsWorking.Name = "button_IsWorking";
            this.button_IsWorking.Size = new System.Drawing.Size(75, 23);
            this.button_IsWorking.TabIndex = 9;
            this.button_IsWorking.Text = "Проверка";
            this.button_IsWorking.UseVisualStyleBackColor = true;
            this.button_IsWorking.Click += new System.EventHandler(this.button_IsWorking_Click);
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
            this.label_GoldMax.Location = new System.Drawing.Point(12, 105);
            this.label_GoldMax.Name = "label_GoldMax";
            this.label_GoldMax.Size = new System.Drawing.Size(84, 13);
            this.label_GoldMax.TabIndex = 11;
            this.label_GoldMax.Text = "Лимит золота: ";
            // 
            // textBox_GoldMax
            // 
            this.textBox_GoldMax.Location = new System.Drawing.Point(102, 102);
            this.textBox_GoldMax.Name = "textBox_GoldMax";
            this.textBox_GoldMax.Size = new System.Drawing.Size(100, 20);
            this.textBox_GoldMax.TabIndex = 12;
            this.textBox_GoldMax.Text = "90000";
            // 
            // checkBox_Helper
            // 
            this.checkBox_Helper.AutoSize = true;
            this.checkBox_Helper.Location = new System.Drawing.Point(12, 32);
            this.checkBox_Helper.Name = "checkBox_Helper";
            this.checkBox_Helper.Size = new System.Drawing.Size(81, 17);
            this.checkBox_Helper.TabIndex = 13;
            this.checkBox_Helper.Text = "Помощник";
            this.checkBox_Helper.UseVisualStyleBackColor = true;
            // 
            // label_HeroNameText
            // 
            this.label_HeroNameText.AutoSize = true;
            this.label_HeroNameText.Location = new System.Drawing.Point(111, 52);
            this.label_HeroNameText.Name = "label_HeroNameText";
            this.label_HeroNameText.Size = new System.Drawing.Size(40, 13);
            this.label_HeroNameText.TabIndex = 14;
            this.label_HeroNameText.Text = "Герой:";
            // 
            // label_HeroName
            // 
            this.label_HeroName.AutoSize = true;
            this.label_HeroName.Location = new System.Drawing.Point(151, 52);
            this.label_HeroName.Name = "label_HeroName";
            this.label_HeroName.Size = new System.Drawing.Size(61, 13);
            this.label_HeroName.TabIndex = 15;
            this.label_HeroName.Text = "Имя героя";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.label_HeroName);
            this.Controls.Add(this.label_HeroNameText);
            this.Controls.Add(this.checkBox_Helper);
            this.Controls.Add(this.textBox_GoldMax);
            this.Controls.Add(this.label_GoldMax);
            this.Controls.Add(this.button_IsWorking);
            this.Controls.Add(this.label_GoldCounter);
            this.Controls.Add(this.checkBox_Enable);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.domainUpDown_BindKey);
            this.Controls.Add(this.label_BindKey);
            this.Controls.Add(this.label_Gold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 230);
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
        private System.Windows.Forms.DomainUpDown domainUpDown_BindKey;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.CheckBox checkBox_Enable;
        private System.Windows.Forms.Label label_GoldCounter;
        private System.Windows.Forms.Button button_IsWorking;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label_GoldMax;
        private System.Windows.Forms.TextBox textBox_GoldMax;
        private System.Windows.Forms.CheckBox checkBox_Helper;
        private System.Windows.Forms.Label label_HeroNameText;
        private System.Windows.Forms.Label label_HeroName;
    }
}
