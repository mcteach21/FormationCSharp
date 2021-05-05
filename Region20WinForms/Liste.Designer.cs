namespace Region20WinForms
{
    partial class Liste
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
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.infos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUsers
            // 
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Items.AddRange(new object[] {
            "aaaaaaaaa",
            "bbbbbbbb",
            "ccccccccc"});
            this.cbUsers.Location = new System.Drawing.Point(13, 13);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(274, 23);
            this.cbUsers.TabIndex = 0;
            this.cbUsers.SelectedIndexChanged += new System.EventHandler(this.cbUsers_SelectedIndexChanged);
            // 
            // picture
            // 
            this.picture.ImageLocation = "";
            this.picture.Location = new System.Drawing.Point(164, 43);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(122, 151);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 1;
            this.picture.TabStop = false;
            // 
            // infos
            // 
            this.infos.BackColor = System.Drawing.SystemColors.Control;
            this.infos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infos.Enabled = false;
            this.infos.ForeColor = System.Drawing.Color.White;
            this.infos.Location = new System.Drawing.Point(11, 10);
            this.infos.Multiline = true;
            this.infos.Name = "infos";
            this.infos.Size = new System.Drawing.Size(125, 131);
            this.infos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.infos);
            this.panel1.Location = new System.Drawing.Point(13, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 151);
            this.panel1.TabIndex = 2;
            // 
            // Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 206);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.cbUsers);
            this.Name = "Liste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste..";
            this.Load += new System.EventHandler(this.Liste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.TextBox infos;
        private System.Windows.Forms.Panel panel1;
    }
}