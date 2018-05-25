namespace WindowsFormsApplication64
{
    partial class KULLANICILAR
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanıcıadı = new System.Windows.Forms.TextBox();
            this.sıfre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GIR = new System.Windows.Forms.Button();
            this.IPTAL = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // kullanıcıadı
            // 
            this.kullanıcıadı.Location = new System.Drawing.Point(94, 17);
            this.kullanıcıadı.Name = "kullanıcıadı";
            this.kullanıcıadı.Size = new System.Drawing.Size(100, 20);
            this.kullanıcıadı.TabIndex = 1;
            // 
            // sıfre
            // 
            this.sıfre.Location = new System.Drawing.Point(94, 43);
            this.sıfre.Name = "sıfre";
            this.sıfre.PasswordChar = '*';
            this.sıfre.Size = new System.Drawing.Size(100, 20);
            this.sıfre.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GIR);
            this.groupBox1.Controls.Add(this.IPTAL);
            this.groupBox1.Location = new System.Drawing.Point(57, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // GIR
            // 
            this.GIR.BackColor = System.Drawing.Color.CadetBlue;
            this.GIR.Image = global::WindowsFormsApplication64.Properties.Resources.Checkmark_30;
            this.GIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GIR.Location = new System.Drawing.Point(6, 16);
            this.GIR.Name = "GIR";
            this.GIR.Size = new System.Drawing.Size(84, 47);
            this.GIR.TabIndex = 3;
            this.GIR.TabStop = false;
            this.GIR.Text = "Giriş";
            this.GIR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GIR.UseVisualStyleBackColor = false;
            this.GIR.UseWaitCursor = true;
            this.GIR.Click += new System.EventHandler(this.GİRİŞ_Click);
            // 
            // IPTAL
            // 
            this.IPTAL.BackColor = System.Drawing.Color.CadetBlue;
            this.IPTAL.Image = global::WindowsFormsApplication64.Properties.Resources.Delete_30;
            this.IPTAL.Location = new System.Drawing.Point(97, 14);
            this.IPTAL.Name = "IPTAL";
            this.IPTAL.Size = new System.Drawing.Size(86, 51);
            this.IPTAL.TabIndex = 4;
            this.IPTAL.Text = "İptal";
            this.IPTAL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IPTAL.UseVisualStyleBackColor = false;
            this.IPTAL.UseWaitCursor = true;
            this.IPTAL.Click += new System.EventHandler(this.İPTAL_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.kullanıcıadı);
            this.groupBox2.Controls.Add(this.sıfre);
            this.groupBox2.Location = new System.Drawing.Point(57, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 68);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication64.Properties.Resources.Checked_User_Male_30;
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // KULLANICILAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(289, 156);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KULLANICILAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GIR;
        private System.Windows.Forms.Button IPTAL;
        public System.Windows.Forms.TextBox kullanıcıadı;
        public System.Windows.Forms.TextBox sıfre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

