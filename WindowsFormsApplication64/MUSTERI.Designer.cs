namespace WindowsFormsApplication64
{
    partial class MUSTERI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MUSTERI));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRUPADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEHIR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADISOYADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFON1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEPTELEFONU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOPLAMVERILEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOPLAMALINAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAKIYE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ARA = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ED_DURUMU = new System.Windows.Forms.ComboBox();
            this.ED_BAKIYEARA = new System.Windows.Forms.ComboBox();
            this.ED_SEMTARA = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ED_GRUPADIARA = new System.Windows.Forms.ComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedeklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriYüklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedeklemeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.genelAyarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genelerAyarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümİşlemDetayRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ED_MUSTERIADIARAR = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MUSTERIHAREKETLERI = new System.Windows.Forms.Button();
            this.MüsteriSil = new System.Windows.Forms.Button();
            this.MüşteriUpdate = new System.Windows.Forms.Button();
            this.MüşteriEkle = new System.Windows.Forms.Button();
            this.CIKIS = new System.Windows.Forms.Button();
            this.EXTRE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "alacaklandır-30.png");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.GRUPADI,
            this.SEHIR,
            this.ADISOYADI,
            this.TELEFON1,
            this.CEPTELEFONU,
            this.TOPLAMVERILEN,
            this.TOPLAMALINAN,
            this.BAKIYE});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(809, 318);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Kodu";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 57;
            // 
            // GRUPADI
            // 
            this.GRUPADI.DataPropertyName = "GRUPADI";
            this.GRUPADI.HeaderText = "Grup Adı";
            this.GRUPADI.Name = "GRUPADI";
            this.GRUPADI.ReadOnly = true;
            this.GRUPADI.Width = 73;
            // 
            // SEHIR
            // 
            this.SEHIR.DataPropertyName = "SEHIR";
            this.SEHIR.HeaderText = "Şehir";
            this.SEHIR.Name = "SEHIR";
            this.SEHIR.ReadOnly = true;
            this.SEHIR.Width = 56;
            // 
            // ADISOYADI
            // 
            this.ADISOYADI.DataPropertyName = "ADISOYADI";
            this.ADISOYADI.HeaderText = "Müşteri Adı";
            this.ADISOYADI.Name = "ADISOYADI";
            this.ADISOYADI.ReadOnly = true;
            this.ADISOYADI.Width = 84;
            // 
            // TELEFON1
            // 
            this.TELEFON1.DataPropertyName = "TELEFON1";
            this.TELEFON1.HeaderText = "Telefon";
            this.TELEFON1.Name = "TELEFON1";
            this.TELEFON1.ReadOnly = true;
            this.TELEFON1.Width = 68;
            // 
            // CEPTELEFONU
            // 
            this.CEPTELEFONU.DataPropertyName = "CEPTELEFONU";
            this.CEPTELEFONU.HeaderText = "Cep Tel";
            this.CEPTELEFONU.Name = "CEPTELEFONU";
            this.CEPTELEFONU.ReadOnly = true;
            this.CEPTELEFONU.Width = 69;
            // 
            // TOPLAMVERILEN
            // 
            this.TOPLAMVERILEN.DataPropertyName = "TOPLAMVERILEN";
            this.TOPLAMVERILEN.HeaderText = "Toplam Verilen";
            this.TOPLAMVERILEN.Name = "TOPLAMVERILEN";
            this.TOPLAMVERILEN.ReadOnly = true;
            this.TOPLAMVERILEN.Width = 102;
            // 
            // TOPLAMALINAN
            // 
            this.TOPLAMALINAN.DataPropertyName = "TOPLAMALINAN";
            this.TOPLAMALINAN.HeaderText = "Toplam Alınan";
            this.TOPLAMALINAN.Name = "TOPLAMALINAN";
            this.TOPLAMALINAN.ReadOnly = true;
            this.TOPLAMALINAN.Width = 99;
            // 
            // BAKIYE
            // 
            this.BAKIYE.DataPropertyName = "BAKIYE";
            this.BAKIYE.HeaderText = "Bakiye";
            this.BAKIYE.Name = "BAKIYE";
            this.BAKIYE.ReadOnly = true;
            this.BAKIYE.Width = 64;
            // 
            // ARA
            // 
            this.ARA.BackColor = System.Drawing.Color.White;
            this.ARA.ForeColor = System.Drawing.Color.Transparent;
            this.ARA.Image = global::WindowsFormsApplication64.Properties.Resources._1493339576_old_edit_find;
            this.ARA.Location = new System.Drawing.Point(608, 120);
            this.ARA.Name = "ARA";
            this.ARA.Size = new System.Drawing.Size(48, 40);
            this.ARA.TabIndex = 46;
            this.ARA.UseVisualStyleBackColor = false;
            this.ARA.UseWaitCursor = true;
            this.ARA.Click += new System.EventHandler(this.ARA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(538, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Durumu";
            this.label5.UseWaitCursor = true;
            // 
            // ED_DURUMU
            // 
            this.ED_DURUMU.FormattingEnabled = true;
            this.ED_DURUMU.Location = new System.Drawing.Point(541, 128);
            this.ED_DURUMU.Name = "ED_DURUMU";
            this.ED_DURUMU.Size = new System.Drawing.Size(61, 21);
            this.ED_DURUMU.TabIndex = 44;
            this.ED_DURUMU.UseWaitCursor = true;
            // 
            // ED_BAKIYEARA
            // 
            this.ED_BAKIYEARA.FormattingEnabled = true;
            this.ED_BAKIYEARA.Location = new System.Drawing.Point(414, 128);
            this.ED_BAKIYEARA.Name = "ED_BAKIYEARA";
            this.ED_BAKIYEARA.Size = new System.Drawing.Size(121, 21);
            this.ED_BAKIYEARA.TabIndex = 43;
            this.ED_BAKIYEARA.UseWaitCursor = true;
            // 
            // ED_SEMTARA
            // 
            this.ED_SEMTARA.FormattingEnabled = true;
            this.ED_SEMTARA.Location = new System.Drawing.Point(290, 128);
            this.ED_SEMTARA.Name = "ED_SEMTARA";
            this.ED_SEMTARA.Size = new System.Drawing.Size(121, 21);
            this.ED_SEMTARA.TabIndex = 42;
            this.ED_SEMTARA.UseWaitCursor = true;
            this.ED_SEMTARA.SelectedIndexChanged += new System.EventHandler(this.ED_SEMTARA_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(411, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Bakiye Durumu";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(287, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Semt";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(157, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Grup Adı";
            this.label2.UseWaitCursor = true;
            // 
            // ED_GRUPADIARA
            // 
            this.ED_GRUPADIARA.FormattingEnabled = true;
            this.ED_GRUPADIARA.Location = new System.Drawing.Point(160, 128);
            this.ED_GRUPADIARA.Name = "ED_GRUPADIARA";
            this.ED_GRUPADIARA.Size = new System.Drawing.Size(121, 21);
            this.ED_GRUPADIARA.TabIndex = 38;
            this.ED_GRUPADIARA.UseWaitCursor = true;
            this.ED_GRUPADIARA.SelectedIndexChanged += new System.EventHandler(this.ED_GRUPADIARA_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.müşterilerToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(809, 24);
            this.menuStrip2.TabIndex = 31;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.UseWaitCursor = true;
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yedeklemeToolStripMenuItem,
            this.geriYüklemeToolStripMenuItem,
            this.yedeklemeToolStripMenuItem1,
            this.genelAyarToolStripMenuItem,
            this.genelerAyarlarToolStripMenuItem,
            this.şifreDeğiştirToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.tümİşlemDetayRaporuToolStripMenuItem});
            this.menüToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // yedeklemeToolStripMenuItem
            // 
            this.yedeklemeToolStripMenuItem.Name = "yedeklemeToolStripMenuItem";
            this.yedeklemeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.yedeklemeToolStripMenuItem.Text = "         Yedekleme";
            // 
            // geriYüklemeToolStripMenuItem
            // 
            this.geriYüklemeToolStripMenuItem.Name = "geriYüklemeToolStripMenuItem";
            this.geriYüklemeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.geriYüklemeToolStripMenuItem.Text = "Geri Yükleme";
            // 
            // yedeklemeToolStripMenuItem1
            // 
            this.yedeklemeToolStripMenuItem1.Name = "yedeklemeToolStripMenuItem1";
            this.yedeklemeToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.yedeklemeToolStripMenuItem1.Text = "Yedekleme";
            // 
            // genelAyarToolStripMenuItem
            // 
            this.genelAyarToolStripMenuItem.Name = "genelAyarToolStripMenuItem";
            this.genelAyarToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.genelAyarToolStripMenuItem.Text = "           Genel Ayar";
            // 
            // genelerAyarlarToolStripMenuItem
            // 
            this.genelerAyarlarToolStripMenuItem.Name = "genelerAyarlarToolStripMenuItem";
            this.genelerAyarlarToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.genelerAyarlarToolStripMenuItem.Text = "Geneler Ayarlar";
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.raporlarToolStripMenuItem.Text = "            Raporlar";
            // 
            // tümİşlemDetayRaporuToolStripMenuItem
            // 
            this.tümİşlemDetayRaporuToolStripMenuItem.Name = "tümİşlemDetayRaporuToolStripMenuItem";
            this.tümİşlemDetayRaporuToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.tümİşlemDetayRaporuToolStripMenuItem.Text = "Tüm İşlem Detay Raporu";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // ED_MUSTERIADIARAR
            // 
            this.ED_MUSTERIADIARAR.Location = new System.Drawing.Point(45, 129);
            this.ED_MUSTERIADIARAR.Name = "ED_MUSTERIADIARAR";
            this.ED_MUSTERIADIARAR.Size = new System.Drawing.Size(109, 20);
            this.ED_MUSTERIADIARAR.TabIndex = 36;
            this.ED_MUSTERIADIARAR.UseWaitCursor = true;
            this.ED_MUSTERIADIARAR.TextChanged += new System.EventHandler(this.ED_MUSTERIADIARAR_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(42, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Müşteri Adı";
            this.label1.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::WindowsFormsApplication64.Properties.Resources._1493341129_231;
            this.button2.Location = new System.Drawing.Point(491, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 70);
            this.button2.TabIndex = 49;
            this.button2.Text = "Alacak Dekontu";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::WindowsFormsApplication64.Properties.Resources._1493340789_Finance_loan_money1;
            this.button1.Location = new System.Drawing.Point(362, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 70);
            this.button1.TabIndex = 48;
            this.button1.Text = "Borc Dekontu";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MUSTERIHAREKETLERI
            // 
            this.MUSTERIHAREKETLERI.BackColor = System.Drawing.Color.White;
            this.MUSTERIHAREKETLERI.Image = global::WindowsFormsApplication64.Properties.Resources._1493398522_user_group_new;
            this.MUSTERIHAREKETLERI.Location = new System.Drawing.Point(283, 25);
            this.MUSTERIHAREKETLERI.Name = "MUSTERIHAREKETLERI";
            this.MUSTERIHAREKETLERI.Size = new System.Drawing.Size(73, 72);
            this.MUSTERIHAREKETLERI.TabIndex = 30;
            this.MUSTERIHAREKETLERI.Text = "Müşteri Hareketleri";
            this.MUSTERIHAREKETLERI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MUSTERIHAREKETLERI.UseVisualStyleBackColor = false;
            this.MUSTERIHAREKETLERI.UseWaitCursor = true;
            this.MUSTERIHAREKETLERI.Click += new System.EventHandler(this.MUSTERIHAREKETLERI_Click);
            // 
            // MüsteriSil
            // 
            this.MüsteriSil.BackColor = System.Drawing.Color.White;
            this.MüsteriSil.Image = global::WindowsFormsApplication64.Properties.Resources._1493691093_3;
            this.MüsteriSil.Location = new System.Drawing.Point(202, 25);
            this.MüsteriSil.Name = "MüsteriSil";
            this.MüsteriSil.Size = new System.Drawing.Size(73, 72);
            this.MüsteriSil.TabIndex = 29;
            this.MüsteriSil.Text = "Müşteri Sil";
            this.MüsteriSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MüsteriSil.UseVisualStyleBackColor = false;
            this.MüsteriSil.UseWaitCursor = true;
            this.MüsteriSil.Click += new System.EventHandler(this.MüsteriSil_Click);
            // 
            // MüşteriUpdate
            // 
            this.MüşteriUpdate.BackColor = System.Drawing.Color.White;
            this.MüşteriUpdate.Image = global::WindowsFormsApplication64.Properties.Resources._1493686705_preferences_contact_list;
            this.MüşteriUpdate.Location = new System.Drawing.Point(121, 26);
            this.MüşteriUpdate.Name = "MüşteriUpdate";
            this.MüşteriUpdate.Size = new System.Drawing.Size(73, 72);
            this.MüşteriUpdate.TabIndex = 28;
            this.MüşteriUpdate.Text = "Müşteri Kartı";
            this.MüşteriUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MüşteriUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MüşteriUpdate.UseVisualStyleBackColor = false;
            this.MüşteriUpdate.UseWaitCursor = true;
            this.MüşteriUpdate.Click += new System.EventHandler(this.MüşteriUpdate_Click);
            // 
            // MüşteriEkle
            // 
            this.MüşteriEkle.BackColor = System.Drawing.Color.White;
            this.MüşteriEkle.Image = global::WindowsFormsApplication64.Properties.Resources._1493398542_contact_new1;
            this.MüşteriEkle.Location = new System.Drawing.Point(40, 26);
            this.MüşteriEkle.Name = "MüşteriEkle";
            this.MüşteriEkle.Size = new System.Drawing.Size(73, 72);
            this.MüşteriEkle.TabIndex = 27;
            this.MüşteriEkle.Text = "Müşteri Ekle";
            this.MüşteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MüşteriEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MüşteriEkle.UseVisualStyleBackColor = false;
            this.MüşteriEkle.UseWaitCursor = true;
            this.MüşteriEkle.Click += new System.EventHandler(this.MüşteriEkle_Click);
            // 
            // CIKIS
            // 
            this.CIKIS.BackColor = System.Drawing.Color.White;
            this.CIKIS.Image = global::WindowsFormsApplication64.Properties.Resources._1493340210_Exit1;
            this.CIKIS.Location = new System.Drawing.Point(707, 27);
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.Size = new System.Drawing.Size(73, 72);
            this.CIKIS.TabIndex = 35;
            this.CIKIS.Text = "Çıkış";
            this.CIKIS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CIKIS.UseVisualStyleBackColor = false;
            this.CIKIS.UseWaitCursor = true;
            // 
            // EXTRE
            // 
            this.EXTRE.BackColor = System.Drawing.Color.White;
            this.EXTRE.Image = global::WindowsFormsApplication64.Properties.Resources._1493340537_document_open1;
            this.EXTRE.Location = new System.Drawing.Point(628, 27);
            this.EXTRE.Name = "EXTRE";
            this.EXTRE.Size = new System.Drawing.Size(73, 72);
            this.EXTRE.TabIndex = 34;
            this.EXTRE.Text = "Extre";
            this.EXTRE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EXTRE.UseVisualStyleBackColor = false;
            this.EXTRE.UseWaitCursor = true;
            this.EXTRE.Click += new System.EventHandler(this.EXTRE_Click);
            // 
            // MUSTERI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 503);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ARA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ED_DURUMU);
            this.Controls.Add(this.ED_BAKIYEARA);
            this.Controls.Add(this.ED_SEMTARA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ED_GRUPADIARA);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.MUSTERIHAREKETLERI);
            this.Controls.Add(this.MüsteriSil);
            this.Controls.Add(this.MüşteriUpdate);
            this.Controls.Add(this.MüşteriEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ED_MUSTERIADIARAR);
            this.Controls.Add(this.CIKIS);
            this.Controls.Add(this.EXTRE);
            this.Name = "MUSTERI";
            this.Load += new System.EventHandler(this.MUSTERI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ImageList ımageList1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button ARA;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox ED_DURUMU;
        public System.Windows.Forms.ComboBox ED_BAKIYEARA;
        public System.Windows.Forms.ComboBox ED_SEMTARA;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox ED_GRUPADIARA;
        public System.Windows.Forms.MenuStrip menuStrip2;
        public System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yedeklemeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem geriYüklemeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem yedeklemeToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem genelAyarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem genelerAyarlarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tümİşlemDetayRaporuToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        public System.Windows.Forms.Button MUSTERIHAREKETLERI;
        public System.Windows.Forms.Button MüsteriSil;
        public System.Windows.Forms.Button MüşteriUpdate;
        public System.Windows.Forms.Button MüşteriEkle;
        public System.Windows.Forms.TextBox ED_MUSTERIADIARAR;
        public System.Windows.Forms.Button CIKIS;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button EXTRE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRUPADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEHIR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADISOYADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFON1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEPTELEFONU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOPLAMVERILEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOPLAMALINAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAKIYE;
    }
}