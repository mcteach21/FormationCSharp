namespace Region20WinForms
{
    partial class Fiche
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.toolTipIdentity = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbh = new System.Windows.Forms.RadioButton();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.grpComps = new System.Windows.Forms.GroupBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.recap = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpComps.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAdresse);
            this.groupBox1.Controls.Add(this.tbNom);
            this.groupBox1.Controls.Add(this.tbPrenom);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identité";
            // 
            // tbAdresse
            // 
            this.tbAdresse.Location = new System.Drawing.Point(25, 92);
            this.tbAdresse.Multiline = true;
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.PlaceholderText = "adresse..";
            this.tbAdresse.Size = new System.Drawing.Size(234, 60);
            this.tbAdresse.TabIndex = 1;
            this.toolTipIdentity.SetToolTip(this.tbAdresse, "votre adresse");
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(25, 62);
            this.tbNom.Name = "tbNom";
            this.tbNom.PlaceholderText = "nom..";
            this.tbNom.Size = new System.Drawing.Size(234, 23);
            this.tbNom.TabIndex = 0;
            this.toolTipIdentity.SetToolTip(this.tbNom, "votre nom");
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(25, 33);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.PlaceholderText = "prénom..";
            this.tbPrenom.Size = new System.Drawing.Size(234, 23);
            this.tbPrenom.TabIndex = 0;
            this.toolTipIdentity.SetToolTip(this.tbPrenom, "votre prénom");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbh);
            this.groupBox2.Controls.Add(this.rbf);
            this.groupBox2.Location = new System.Drawing.Point(295, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexe";
            // 
            // rbh
            // 
            this.rbh.AutoSize = true;
            this.rbh.Checked = true;
            this.rbh.Location = new System.Drawing.Point(28, 48);
            this.rbh.Name = "rbh";
            this.rbh.Size = new System.Drawing.Size(69, 19);
            this.rbh.TabIndex = 1;
            this.rbh.TabStop = true;
            this.rbh.Text = "Homme";
            this.rbh.UseVisualStyleBackColor = true;
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(28, 23);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(65, 19);
            this.rbf.TabIndex = 0;
            this.rbf.TabStop = true;
            this.rbf.Text = "Femme";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // grpComps
            // 
            this.grpComps.Controls.Add(this.cb4);
            this.grpComps.Controls.Add(this.cb3);
            this.grpComps.Controls.Add(this.cb2);
            this.grpComps.Controls.Add(this.cb1);
            this.grpComps.Location = new System.Drawing.Point(295, 136);
            this.grpComps.Name = "grpComps";
            this.grpComps.Size = new System.Drawing.Size(211, 82);
            this.grpComps.TabIndex = 2;
            this.grpComps.TabStop = false;
            this.grpComps.Text = "Compétences";
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(131, 48);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(50, 19);
            this.cb4.TabIndex = 0;
            this.cb4.Text = "Web";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(131, 23);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(67, 19);
            this.cb3.TabIndex = 0;
            this.cb3.Text = "C Sharp";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(28, 48);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(69, 19);
            this.cb2.TabIndex = 0;
            this.cb2.Text = "Android";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(28, 23);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(48, 19);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Java";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(295, 233);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(211, 32);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Valider Informations";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // recap
            // 
            this.recap.AutoEllipsis = true;
            this.recap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recap.ForeColor = System.Drawing.Color.White;
            this.recap.Location = new System.Drawing.Point(12, 275);
            this.recap.Name = "recap";
            this.recap.Size = new System.Drawing.Size(494, 67);
            this.recap.TabIndex = 4;
            this.recap.Text = " ";
            // 
            // Fiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(520, 345);
            this.Controls.Add(this.recap);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpComps);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fiche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ma Fenêtre";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpComps.ResumeLayout(false);
            this.grpComps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.ToolTip toolTipIdentity;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbh;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.GroupBox grpComps;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label recap;
    }
}

