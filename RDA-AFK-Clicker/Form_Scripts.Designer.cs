namespace RDA_AFK_Clicker
{
    partial class Form_Scripts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Scripts));
            this.listBox_Scripts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_NameScript = new System.Windows.Forms.Label();
            this.button_AddNewScript = new System.Windows.Forms.Button();
            this.button_StartScript = new System.Windows.Forms.Button();
            this.button_RecordScript = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_Debug = new System.Windows.Forms.CheckBox();
            this.button_ChangeScript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Scripts
            // 
            this.listBox_Scripts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Scripts.FormattingEnabled = true;
            this.listBox_Scripts.Location = new System.Drawing.Point(15, 15);
            this.listBox_Scripts.Name = "listBox_Scripts";
            this.listBox_Scripts.Size = new System.Drawing.Size(218, 147);
            this.listBox_Scripts.TabIndex = 0;
            this.listBox_Scripts.SelectedIndexChanged += new System.EventHandler(this.listBox_ScriptsSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбран скрипт:";
            // 
            // label_NameScript
            // 
            this.label_NameScript.AutoSize = true;
            this.label_NameScript.Location = new System.Drawing.Point(239, 28);
            this.label_NameScript.Name = "label_NameScript";
            this.label_NameScript.Size = new System.Drawing.Size(33, 13);
            this.label_NameScript.TabIndex = 2;
            this.label_NameScript.Text = "None";
            // 
            // button_AddNewScript
            // 
            this.button_AddNewScript.Location = new System.Drawing.Point(12, 168);
            this.button_AddNewScript.Name = "button_AddNewScript";
            this.button_AddNewScript.Size = new System.Drawing.Size(75, 23);
            this.button_AddNewScript.TabIndex = 3;
            this.button_AddNewScript.Text = "Добавить";
            this.button_AddNewScript.UseVisualStyleBackColor = true;
            this.button_AddNewScript.Click += new System.EventHandler(this.button_AddNewScript_Click);
            // 
            // button_StartScript
            // 
            this.button_StartScript.Location = new System.Drawing.Point(335, 168);
            this.button_StartScript.Name = "button_StartScript";
            this.button_StartScript.Size = new System.Drawing.Size(75, 23);
            this.button_StartScript.TabIndex = 4;
            this.button_StartScript.Text = "Запустить";
            this.button_StartScript.UseVisualStyleBackColor = true;
            this.button_StartScript.Click += new System.EventHandler(this.button_StartScript_Click);
            // 
            // button_RecordScript
            // 
            this.button_RecordScript.Location = new System.Drawing.Point(242, 168);
            this.button_RecordScript.Name = "button_RecordScript";
            this.button_RecordScript.Size = new System.Drawing.Size(75, 23);
            this.button_RecordScript.TabIndex = 5;
            this.button_RecordScript.Text = "Записать";
            this.button_RecordScript.UseVisualStyleBackColor = true;
            this.button_RecordScript.Click += new System.EventHandler(this.button_RecordScript_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(93, 168);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_DeleteScriptClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Упрощенное создание:";
            // 
            // checkBox_Debug
            // 
            this.checkBox_Debug.AutoSize = true;
            this.checkBox_Debug.Location = new System.Drawing.Point(242, 83);
            this.checkBox_Debug.Name = "checkBox_Debug";
            this.checkBox_Debug.Size = new System.Drawing.Size(118, 17);
            this.checkBox_Debug.TabIndex = 8;
            this.checkBox_Debug.Text = "Включить отладку";
            this.checkBox_Debug.UseVisualStyleBackColor = true;
            this.checkBox_Debug.CheckedChanged += new System.EventHandler(this.checkBox_DebugCheckedChanged);
            // 
            // button_ChangeScript
            // 
            this.button_ChangeScript.Enabled = false;
            this.button_ChangeScript.Location = new System.Drawing.Point(242, 106);
            this.button_ChangeScript.Name = "button_ChangeScript";
            this.button_ChangeScript.Size = new System.Drawing.Size(75, 23);
            this.button_ChangeScript.TabIndex = 9;
            this.button_ChangeScript.Text = "Изменить";
            this.button_ChangeScript.UseVisualStyleBackColor = true;
            this.button_ChangeScript.Click += new System.EventHandler(this.button_ChangeScript_Click);
            // 
            // Form_Scripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 201);
            this.Controls.Add(this.button_ChangeScript);
            this.Controls.Add(this.checkBox_Debug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_RecordScript);
            this.Controls.Add(this.button_StartScript);
            this.Controls.Add(this.button_AddNewScript);
            this.Controls.Add(this.label_NameScript);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Scripts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(440, 240);
            this.Name = "Form_Scripts";
            this.Text = "RDA-Clicker";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Scripts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NameScript;
        private System.Windows.Forms.Button button_AddNewScript;
        private System.Windows.Forms.Button button_StartScript;
        private System.Windows.Forms.Button button_RecordScript;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox_Debug;
        private System.Windows.Forms.Button button_ChangeScript;
    }
}