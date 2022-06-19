namespace RDA_AFK_Clicker
{
    partial class Form_EasyScript
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EasyScript));
            this.listBox_Commands = new System.Windows.Forms.ListBox();
            this.button_AddCommand = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_RemoveCommand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.domainUpDown_Command = new System.Windows.Forms.DomainUpDown();
            this.label_Param = new System.Windows.Forms.Label();
            this.textBox_Param = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.checkBox_HookMouse = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox_Commands
            // 
            this.listBox_Commands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Commands.FormattingEnabled = true;
            this.listBox_Commands.Location = new System.Drawing.Point(12, 41);
            this.listBox_Commands.Name = "listBox_Commands";
            this.listBox_Commands.Size = new System.Drawing.Size(160, 225);
            this.listBox_Commands.TabIndex = 0;
            this.listBox_Commands.SelectedIndexChanged += new System.EventHandler(this.listBox_Commands_SelectedIndexChanged);
            // 
            // button_AddCommand
            // 
            this.button_AddCommand.Location = new System.Drawing.Point(12, 273);
            this.button_AddCommand.Name = "button_AddCommand";
            this.button_AddCommand.Size = new System.Drawing.Size(75, 23);
            this.button_AddCommand.TabIndex = 1;
            this.button_AddCommand.Text = "Добавить";
            this.button_AddCommand.UseVisualStyleBackColor = true;
            this.button_AddCommand.Click += new System.EventHandler(this.button_AddCommandClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Инструкция";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_RemoveCommand
            // 
            this.button_RemoveCommand.Location = new System.Drawing.Point(93, 273);
            this.button_RemoveCommand.Name = "button_RemoveCommand";
            this.button_RemoveCommand.Size = new System.Drawing.Size(75, 23);
            this.button_RemoveCommand.TabIndex = 3;
            this.button_RemoveCommand.Text = "Убрать";
            this.button_RemoveCommand.UseVisualStyleBackColor = true;
            this.button_RemoveCommand.Click += new System.EventHandler(this.button_RemoveCommand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Параметры:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Команда";
            // 
            // domainUpDown_Command
            // 
            this.domainUpDown_Command.Items.Add("Время");
            this.domainUpDown_Command.Items.Add("Курсор");
            this.domainUpDown_Command.Items.Add("Клавиша");
            this.domainUpDown_Command.Items.Add("Мышь");
            this.domainUpDown_Command.Location = new System.Drawing.Point(236, 63);
            this.domainUpDown_Command.Name = "domainUpDown_Command";
            this.domainUpDown_Command.Size = new System.Drawing.Size(177, 20);
            this.domainUpDown_Command.TabIndex = 7;
            this.domainUpDown_Command.Text = "Команды";
            this.domainUpDown_Command.SelectedItemChanged += new System.EventHandler(this.domainUpDown_Command_SelectedItemChanged);
            // 
            // label_Param
            // 
            this.label_Param.AutoSize = true;
            this.label_Param.Location = new System.Drawing.Point(178, 91);
            this.label_Param.Name = "label_Param";
            this.label_Param.Size = new System.Drawing.Size(58, 13);
            this.label_Param.TabIndex = 6;
            this.label_Param.Text = "Параметр";
            // 
            // textBox_Param
            // 
            this.textBox_Param.Location = new System.Drawing.Point(236, 88);
            this.textBox_Param.Name = "textBox_Param";
            this.textBox_Param.Size = new System.Drawing.Size(100, 20);
            this.textBox_Param.TabIndex = 8;
            // 
            // button_Save
            // 
            this.button_Save.Enabled = false;
            this.button_Save.Location = new System.Drawing.Point(181, 114);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_SaveClick);
            // 
            // checkBox_HookMouse
            // 
            this.checkBox_HookMouse.AutoSize = true;
            this.checkBox_HookMouse.Enabled = false;
            this.checkBox_HookMouse.Location = new System.Drawing.Point(181, 143);
            this.checkBox_HookMouse.Name = "checkBox_HookMouse";
            this.checkBox_HookMouse.Size = new System.Drawing.Size(166, 17);
            this.checkBox_HookMouse.TabIndex = 12;
            this.checkBox_HookMouse.Text = "Поймать левый клик мыши";
            this.checkBox_HookMouse.UseVisualStyleBackColor = true;
            this.checkBox_HookMouse.CheckedChanged += new System.EventHandler(this.checkBox_HookMouseCheckedChanged);
            // 
            // Form_EasyScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 311);
            this.Controls.Add(this.checkBox_HookMouse);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Param);
            this.Controls.Add(this.label_Param);
            this.Controls.Add(this.domainUpDown_Command);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_RemoveCommand);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_AddCommand);
            this.Controls.Add(this.listBox_Commands);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(440, 350);
            this.Name = "Form_EasyScript";
            this.Text = "Изменения скрипта";
            this.Load += new System.EventHandler(this.Form_EasyScript_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Commands;
        private System.Windows.Forms.Button button_AddCommand;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_RemoveCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown domainUpDown_Command;
        private System.Windows.Forms.Label label_Param;
        private System.Windows.Forms.TextBox textBox_Param;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.CheckBox checkBox_HookMouse;
    }
}