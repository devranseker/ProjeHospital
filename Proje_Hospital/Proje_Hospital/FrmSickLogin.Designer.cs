namespace Proje_Hospital
{
    partial class FrmSickLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSickLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LinkUyeOl = new System.Windows.Forms.LinkLabel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sick Login Panel ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turkish ID No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password : ";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(184, 75);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(178, 31);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(184, 112);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(178, 31);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // LinkUyeOl
            // 
            this.LinkUyeOl.AutoSize = true;
            this.LinkUyeOl.Location = new System.Drawing.Point(393, 120);
            this.LinkUyeOl.Name = "LinkUyeOl";
            this.LinkUyeOl.Size = new System.Drawing.Size(62, 23);
            this.LinkUyeOl.TabIndex = 5;
            this.LinkUyeOl.TabStop = true;
            this.LinkUyeOl.Text = "Üye Ol";
            this.LinkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkUyeOl_LinkClicked);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(184, 170);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(154, 31);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login ";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FrmSickLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(469, 230);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LinkUyeOl);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = false;
            this.Name = "FrmSickLogin";
            this.Text = "Hasta Girişi ";
//            this.Load += new System.EventHandler(this.FrmSickLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.LinkLabel LinkUyeOl;
        private System.Windows.Forms.Button BtnLogin;
    }
}