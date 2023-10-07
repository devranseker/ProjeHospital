namespace Proje_Hospital
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.BtnBilgiGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.MskPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBilgiGuncelle
            // 
            this.BtnBilgiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnBilgiGuncelle.Location = new System.Drawing.Point(161, 256);
            this.BtnBilgiGuncelle.Name = "BtnBilgiGuncelle";
            this.BtnBilgiGuncelle.Size = new System.Drawing.Size(151, 35);
            this.BtnBilgiGuncelle.TabIndex = 76;
            this.BtnBilgiGuncelle.Text = "Update";
            this.BtnBilgiGuncelle.UseVisualStyleBackColor = false;
            this.BtnBilgiGuncelle.Click += new System.EventHandler(this.BtnBilgiGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Gender :";
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın "});
            this.CmbGender.Location = new System.Drawing.Point(144, 208);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(178, 31);
            this.CmbGender.TabIndex = 6;
            // 
            // MskPhone
            // 
            this.MskPhone.Location = new System.Drawing.Point(146, 134);
            this.MskPhone.Mask = "(999) 000-0000";
            this.MskPhone.Name = "MskPhone";
            this.MskPhone.Size = new System.Drawing.Size(178, 31);
            this.MskPhone.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Phone Number :";
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(146, 60);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(178, 31);
            this.TxtSurname.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(146, 23);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(178, 31);
            this.TxtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Surname :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Name :";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(146, 171);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(178, 31);
            this.TxtPassword.TabIndex = 5;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(146, 97);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(178, 31);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Turkish ID No :";
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.BtnBilgiGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(346, 342);
            this.Controls.Add(this.BtnBilgiGuncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.MskPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Bilgi Günelleme ";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBilgiGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.MaskedTextBox MskPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}