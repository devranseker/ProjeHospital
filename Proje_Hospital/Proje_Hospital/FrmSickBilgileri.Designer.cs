namespace Proje_Hospital
{
    partial class FrmSickBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSickBilgileri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LnkBilgiDuzenle = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LnkBilgiDüzenle = new System.Windows.Forms.LinkLabel();
            this.BtnRandevuAl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RchSikayet = new System.Windows.Forms.RichTextBox();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.LnkBilgiDuzenle.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNameSurname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblTc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgileri ";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(117, 66);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(69, 19);
            this.LblNameSurname.TabIndex = 16;
            this.LblNameSurname.Text = "Null Null ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name Surname: ";
            // 
            // LblTc
            // 
            this.LblTc.Location = new System.Drawing.Point(76, 26);
            this.LblTc.Name = "LblTc";
            this.LblTc.Size = new System.Drawing.Size(131, 27);
            this.LblTc.TabIndex = 14;
            this.LblTc.Text = "00000000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "TC No :";
            // 
            // LnkBilgiDuzenle
            // 
            this.LnkBilgiDuzenle.Controls.Add(this.label2);
            this.LnkBilgiDuzenle.Controls.Add(this.TxtId);
            this.LnkBilgiDuzenle.Controls.Add(this.LnkBilgiDüzenle);
            this.LnkBilgiDuzenle.Controls.Add(this.BtnRandevuAl);
            this.LnkBilgiDuzenle.Controls.Add(this.label6);
            this.LnkBilgiDuzenle.Controls.Add(this.label5);
            this.LnkBilgiDuzenle.Controls.Add(this.RchSikayet);
            this.LnkBilgiDuzenle.Controls.Add(this.CmbDoktor);
            this.LnkBilgiDuzenle.Controls.Add(this.label3);
            this.LnkBilgiDuzenle.Controls.Add(this.CmbBrans);
            this.LnkBilgiDuzenle.Location = new System.Drawing.Point(0, 193);
            this.LnkBilgiDuzenle.Name = "LnkBilgiDuzenle";
            this.LnkBilgiDuzenle.Size = new System.Drawing.Size(236, 295);
            this.LnkBilgiDuzenle.TabIndex = 1;
            this.LnkBilgiDuzenle.TabStop = false;
            this.LnkBilgiDuzenle.Text = "Randevu Paneli ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID : ";
            // 
            // TxtId
            // 
            this.TxtId.Enabled = false;
            this.TxtId.Location = new System.Drawing.Point(86, 38);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(121, 27);
            this.TxtId.TabIndex = 8;
            // 
            // LnkBilgiDüzenle
            // 
            this.LnkBilgiDüzenle.Location = new System.Drawing.Point(6, 273);
            this.LnkBilgiDüzenle.Name = "LnkBilgiDüzenle";
            this.LnkBilgiDüzenle.Size = new System.Drawing.Size(118, 19);
            this.LnkBilgiDüzenle.TabIndex = 7;
            this.LnkBilgiDüzenle.TabStop = true;
            this.LnkBilgiDüzenle.Text = "Bilgileri Düzenle";
            this.LnkBilgiDüzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkBilgiDüzenle_LinkClicked);
            // 
            // BtnRandevuAl
            // 
            this.BtnRandevuAl.Location = new System.Drawing.Point(86, 221);
            this.BtnRandevuAl.Name = "BtnRandevuAl";
            this.BtnRandevuAl.Size = new System.Drawing.Size(121, 32);
            this.BtnRandevuAl.TabIndex = 5;
            this.BtnRandevuAl.Text = "Randevu Al";
            this.BtnRandevuAl.UseVisualStyleBackColor = true;
            this.BtnRandevuAl.Click += new System.EventHandler(this.BtnRandevuAl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Şikayet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doktor:";
            // 
            // RchSikayet
            // 
            this.RchSikayet.Location = new System.Drawing.Point(86, 142);
            this.RchSikayet.Name = "RchSikayet";
            this.RchSikayet.Size = new System.Drawing.Size(121, 73);
            this.RchSikayet.TabIndex = 4;
            this.RchSikayet.Text = "";
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(86, 109);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(121, 27);
            this.CmbDoktor.TabIndex = 4;
            this.CmbDoktor.SelectedIndexChanged += new System.EventHandler(this.CmbDoktor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Branş :";
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(86, 71);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(121, 27);
            this.CmbBrans.TabIndex = 2;
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(254, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 264);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(254, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(693, 218);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(687, 192);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // FrmSickBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(948, 501);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LnkBilgiDuzenle);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSickBilgileri";
            this.Text = "Hasta Bilgileri";
            this.Load += new System.EventHandler(this.FrmSickBilgileri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.LnkBilgiDuzenle.ResumeLayout(false);
            this.LnkBilgiDuzenle.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LblTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.GroupBox LnkBilgiDuzenle;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RchSikayet;
        private System.Windows.Forms.Button BtnRandevuAl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel LnkBilgiDüzenle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtId;
    }
}