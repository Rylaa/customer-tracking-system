﻿namespace WindowsFormsApplication64
{
    partial class MUSTERIHAREKETLERI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISLEMTURU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUSTERIADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACIKLAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VERILEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALINAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAKIYE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ED_KODU = new System.Windows.Forms.Label();
            this.ED_MUSTERIADI = new System.Windows.Forms.Label();
            this.ED_GRUPADI = new System.Windows.Forms.Label();
            this.ED_VERGİNO = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.BORCLANDIR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TARIH,
            this.ISLEMTURU,
            this.MUSTERIADI,
            this.ACIKLAMA,
            this.VERILEN,
            this.ALINAN,
            this.BAKIYE});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "KODU";
            this.ID.Name = "ID";
            // 
            // TARIH
            // 
            this.TARIH.DataPropertyName = "TARIH";
            this.TARIH.HeaderText = "Tarih";
            this.TARIH.Name = "TARIH";
            // 
            // ISLEMTURU
            // 
            this.ISLEMTURU.DataPropertyName = "ISLEMTURU";
            this.ISLEMTURU.HeaderText = "İşlem Türü";
            this.ISLEMTURU.Name = "ISLEMTURU";
            // 
            // MUSTERIADI
            // 
            this.MUSTERIADI.DataPropertyName = "MUSTERIADI";
            this.MUSTERIADI.HeaderText = "Müşteri Adı";
            this.MUSTERIADI.Name = "MUSTERIADI";
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.DataPropertyName = "ACIKLAMA";
            this.ACIKLAMA.HeaderText = "Açıklama";
            this.ACIKLAMA.Name = "ACIKLAMA";
            // 
            // VERILEN
            // 
            this.VERILEN.DataPropertyName = "VERILEN";
            this.VERILEN.HeaderText = "Verilen";
            this.VERILEN.Name = "VERILEN";
            // 
            // ALINAN
            // 
            this.ALINAN.DataPropertyName = "ALINAN";
            this.ALINAN.HeaderText = "Alınan";
            this.ALINAN.Name = "ALINAN";
            // 
            // BAKIYE
            // 
            this.BAKIYE.DataPropertyName = "BAKIYE";
            this.BAKIYE.HeaderText = "Bakiye";
            this.BAKIYE.Name = "BAKIYE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kodu                    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Adı           :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grup Adı               :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vergi Dairesi/No   :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(296, 218);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // ED_KODU
            // 
            this.ED_KODU.AutoSize = true;
            this.ED_KODU.Location = new System.Drawing.Point(113, 85);
            this.ED_KODU.Name = "ED_KODU";
            this.ED_KODU.Size = new System.Drawing.Size(0, 13);
            this.ED_KODU.TabIndex = 10;
            // 
            // ED_MUSTERIADI
            // 
            this.ED_MUSTERIADI.AutoSize = true;
            this.ED_MUSTERIADI.Location = new System.Drawing.Point(113, 110);
            this.ED_MUSTERIADI.Name = "ED_MUSTERIADI";
            this.ED_MUSTERIADI.Size = new System.Drawing.Size(0, 13);
            this.ED_MUSTERIADI.TabIndex = 11;
            // 
            // ED_GRUPADI
            // 
            this.ED_GRUPADI.AutoSize = true;
            this.ED_GRUPADI.Location = new System.Drawing.Point(113, 134);
            this.ED_GRUPADI.Name = "ED_GRUPADI";
            this.ED_GRUPADI.Size = new System.Drawing.Size(0, 13);
            this.ED_GRUPADI.TabIndex = 12;
            // 
            // ED_VERGİNO
            // 
            this.ED_VERGİNO.AutoSize = true;
            this.ED_VERGİNO.Location = new System.Drawing.Point(113, 163);
            this.ED_VERGİNO.Name = "ED_VERGİNO";
            this.ED_VERGİNO.Size = new System.Drawing.Size(0, 13);
            this.ED_VERGİNO.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CadetBlue;
            this.button4.Location = new System.Drawing.Point(224, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 54);
            this.button4.TabIndex = 17;
            this.button4.Text = "Alacak Dekontu";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BORCLANDIR
            // 
            this.BORCLANDIR.BackColor = System.Drawing.Color.CadetBlue;
            this.BORCLANDIR.Image = global::WindowsFormsApplication64.Properties.Resources.borclandır;
            this.BORCLANDIR.Location = new System.Drawing.Point(118, 12);
            this.BORCLANDIR.Name = "BORCLANDIR";
            this.BORCLANDIR.Size = new System.Drawing.Size(100, 54);
            this.BORCLANDIR.TabIndex = 21;
            this.BORCLANDIR.Text = "Borç Dekontu";
            this.BORCLANDIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BORCLANDIR.UseVisualStyleBackColor = false;
            this.BORCLANDIR.Click += new System.EventHandler(this.BORCLANDIR_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Image = global::WindowsFormsApplication64.Properties.Resources.update;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "Müşteri Kartı";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MUSTERIHAREKETLERI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(751, 490);
            this.Controls.Add(this.BORCLANDIR);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ED_VERGİNO);
            this.Controls.Add(this.ED_GRUPADI);
            this.Controls.Add(this.ED_MUSTERIADI);
            this.Controls.Add(this.ED_KODU);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MUSTERIHAREKETLERI";
            this.Text = "MUSTERIHAREKETLERI";
            this.Load += new System.EventHandler(this.MUSTERIHAREKETLERI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.Label ED_KODU;
        public System.Windows.Forms.Label ED_MUSTERIADI;
        public System.Windows.Forms.Label ED_GRUPADI;
        public System.Windows.Forms.Label ED_VERGİNO;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BORCLANDIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISLEMTURU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUSTERIADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACIKLAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VERILEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALINAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAKIYE;
    }
}