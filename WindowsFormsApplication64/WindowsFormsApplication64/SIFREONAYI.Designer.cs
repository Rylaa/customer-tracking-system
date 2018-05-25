namespace WindowsFormsApplication64
{
    partial class SIFREONAYI
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
            this.Giriş = new System.Windows.Forms.Button();
            this.İptal = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Giriş
            // 
            this.Giriş.BackColor = System.Drawing.Color.CadetBlue;
            this.Giriş.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Giriş.Image = global::WindowsFormsApplication64.Properties.Resources.Checkmark_30;
            this.Giriş.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Giriş.Location = new System.Drawing.Point(13, 19);
            this.Giriş.Name = "Giriş";
            this.Giriş.Size = new System.Drawing.Size(88, 48);
            this.Giriş.TabIndex = 0;
            this.Giriş.Text = "    Giriş";
            this.Giriş.UseVisualStyleBackColor = false;
            this.Giriş.Click += new System.EventHandler(this.Giriş_Click);
            // 
            // İptal
            // 
            this.İptal.BackColor = System.Drawing.Color.CadetBlue;
            this.İptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.İptal.Image = global::WindowsFormsApplication64.Properties.Resources.Delete_30;
            this.İptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.İptal.Location = new System.Drawing.Point(106, 19);
            this.İptal.Name = "İptal";
            this.İptal.Size = new System.Drawing.Size(88, 48);
            this.İptal.TabIndex = 1;
            this.İptal.Text = "     İptal";
            this.İptal.UseVisualStyleBackColor = false;
            this.İptal.Click += new System.EventHandler(this.İptal_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(73, 19);
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(121, 20);
            this.sifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifreniz:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Giriş);
            this.groupBox1.Controls.Add(this.İptal);
            this.groupBox1.Location = new System.Drawing.Point(44, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sifre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(44, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 52);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // SIFREONAYI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.CancelButton = this.İptal;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(289, 156);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SIFREONAYI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Silme Onayı";
            this.Load += new System.EventHandler(this.SilmeOnayı_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Giriş;
        private System.Windows.Forms.Button İptal;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}