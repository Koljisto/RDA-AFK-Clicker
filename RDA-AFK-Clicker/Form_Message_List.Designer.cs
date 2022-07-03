namespace RDA_AFK_Clicker
{
    partial class Form_Message_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Message_List));
            this.listBox_WavesInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox_WavesInfo
            // 
            this.listBox_WavesInfo.Enabled = false;
            this.listBox_WavesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_WavesInfo.FormattingEnabled = true;
            this.listBox_WavesInfo.ItemHeight = 29;
            this.listBox_WavesInfo.Location = new System.Drawing.Point(13, 13);
            this.listBox_WavesInfo.Name = "listBox_WavesInfo";
            this.listBox_WavesInfo.Size = new System.Drawing.Size(157, 323);
            this.listBox_WavesInfo.TabIndex = 0;
            // 
            // Form_Message_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(178, 338);
            this.ControlBox = false;
            this.Controls.Add(this.listBox_WavesInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Message_List";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Form_Message_List_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_WavesInfo;
    }
}