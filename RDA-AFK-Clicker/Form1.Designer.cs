namespace RDA_AFK_Clicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_Gold = new System.Windows.Forms.Label();
            this.label_BindKey = new System.Windows.Forms.Label();
            this.domainUpDown_BindKey = new System.Windows.Forms.DomainUpDown();
            this.button_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.checkBox_Enable = new System.Windows.Forms.CheckBox();
            this.label_GoldCounter = new System.Windows.Forms.Label();
            this.button_IsWorking = new System.Windows.Forms.Button();
            this.button_OpenScripts = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label_GoldMax = new System.Windows.Forms.Label();
            this.textBox_GoldMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Gold
            // 
            this.label_Gold.AutoSize = true;
            this.label_Gold.Location = new System.Drawing.Point(41, 31);
            this.label_Gold.Name = "label_Gold";
            this.label_Gold.Size = new System.Drawing.Size(46, 13);
            this.label_Gold.TabIndex = 0;
            this.label_Gold.Text = "Золото:";
            // 
            // label_BindKey
            // 
            this.label_BindKey.AutoSize = true;
            this.label_BindKey.Location = new System.Drawing.Point(41, 57);
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
            this.domainUpDown_BindKey.Location = new System.Drawing.Point(102, 55);
            this.domainUpDown_BindKey.Name = "domainUpDown_BindKey";
            this.domainUpDown_BindKey.Size = new System.Drawing.Size(139, 20);
            this.domainUpDown_BindKey.TabIndex = 2;
            this.domainUpDown_BindKey.Tag = "";
            this.domainUpDown_BindKey.Text = "Выбери бинд";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(41, 103);
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
            this.label2.Location = new System.Drawing.Point(41, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Статус:";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(91, 146);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(37, 13);
            this.label_Status.TabIndex = 5;
            this.label_Status.Text = "Status";
            // 
            // checkBox_Enable
            // 
            this.checkBox_Enable.AutoSize = true;
            this.checkBox_Enable.Location = new System.Drawing.Point(44, 5);
            this.checkBox_Enable.Name = "checkBox_Enable";
            this.checkBox_Enable.Size = new System.Drawing.Size(75, 17);
            this.checkBox_Enable.TabIndex = 6;
            this.checkBox_Enable.Text = "Включить";
            this.checkBox_Enable.UseVisualStyleBackColor = true;
            // 
            // label_GoldCounter
            // 
            this.label_GoldCounter.AutoSize = true;
            this.label_GoldCounter.Location = new System.Drawing.Point(103, 31);
            this.label_GoldCounter.Name = "label_GoldCounter";
            this.label_GoldCounter.Size = new System.Drawing.Size(13, 13);
            this.label_GoldCounter.TabIndex = 7;
            this.label_GoldCounter.Text = "0";
            // 
            // button_IsWorking
            // 
            this.button_IsWorking.Location = new System.Drawing.Point(166, 5);
            this.button_IsWorking.Name = "button_IsWorking";
            this.button_IsWorking.Size = new System.Drawing.Size(75, 23);
            this.button_IsWorking.TabIndex = 9;
            this.button_IsWorking.Text = "Проверка";
            this.button_IsWorking.UseVisualStyleBackColor = true;
            this.button_IsWorking.Click += new System.EventHandler(this.button_IsWorking_Click);
            // 
            // button_OpenScripts
            // 
            this.button_OpenScripts.Location = new System.Drawing.Point(166, 31);
            this.button_OpenScripts.Name = "button_OpenScripts";
            this.button_OpenScripts.Size = new System.Drawing.Size(75, 23);
            this.button_OpenScripts.TabIndex = 10;
            this.button_OpenScripts.Text = "Скрипты";
            this.button_OpenScripts.UseVisualStyleBackColor = true;
            this.button_OpenScripts.Click += new System.EventHandler(this.button_OpenScripts_Click);
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
            this.label_GoldMax.Location = new System.Drawing.Point(41, 84);
            this.label_GoldMax.Name = "label_GoldMax";
            this.label_GoldMax.Size = new System.Drawing.Size(84, 13);
            this.label_GoldMax.TabIndex = 11;
            this.label_GoldMax.Text = "Лимит золота: ";
            // 
            // textBox_GoldMax
            // 
            this.textBox_GoldMax.Location = new System.Drawing.Point(131, 81);
            this.textBox_GoldMax.Name = "textBox_GoldMax";
            this.textBox_GoldMax.Size = new System.Drawing.Size(100, 20);
            this.textBox_GoldMax.TabIndex = 12;
            this.textBox_GoldMax.Text = "90000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(271, 168);
            this.Controls.Add(this.textBox_GoldMax);
            this.Controls.Add(this.label_GoldMax);
            this.Controls.Add(this.button_OpenScripts);
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
            this.MinimumSize = new System.Drawing.Size(220, 200);
            this.Name = "Form1";
            this.Text = "RDA-Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_ResizeBegin);
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
        private System.Windows.Forms.Button button_OpenScripts;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label_GoldMax;
        private System.Windows.Forms.TextBox textBox_GoldMax;
    }
}
