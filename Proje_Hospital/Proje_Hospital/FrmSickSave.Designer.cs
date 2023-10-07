namespace Proje_Hospital
{
    partial class FrmSickSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSickSave));
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.MskPhone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnKayıtYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(187, 211);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(178, 31);
            this.TxtPassword.TabIndex = 5;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(187, 137);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(178, 31);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Turkish ID No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "ŞEKER Hospital Hastanesine Üye Olmaya Hoşgeldiniz.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Surname :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(187, 63);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(178, 31);
            this.TxtName.TabIndex = 1;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(187, 100);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(178, 31);
            this.TxtSurname.TabIndex = 2;
            // 
            // MskPhone
            // 
            this.MskPhone.Location = new System.Drawing.Point(187, 174);
            this.MskPhone.Mask = "(999) 000-0000";
            this.MskPhone.Name = "MskPhone";
            this.MskPhone.Size = new System.Drawing.Size(178, 31);
            this.MskPhone.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone Number :";
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın "});
            this.CmbGender.Location = new System.Drawing.Point(185, 248);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(178, 31);
            this.CmbGender.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Gender :";
            // 
            // BtnKayıtYap
            // 
            this.BtnKayıtYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnKayıtYap.Location = new System.Drawing.Point(202, 296);
            this.BtnKayıtYap.Name = "BtnKayıtYap";
            this.BtnKayıtYap.Size = new System.Drawing.Size(151, 35);
            this.BtnKayıtYap.TabIndex = 67;
            this.BtnKayıtYap.Text = "Sign Up ";
            this.BtnKayıtYap.UseVisualStyleBackColor = false;
            this.BtnKayıtYap.Click += new System.EventHandler(this.BtnKayıtYap_Click);
            // 
            // FrmSickSave
            // 
            this.AcceptButton = this.BtnKayıtYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(516, 363);
            this.Controls.Add(this.BtnKayıtYap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.MskPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSickSave";
            this.Text = "Hasta Kayıt ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.MaskedTextBox MskPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnKayıtYap;
    }
}