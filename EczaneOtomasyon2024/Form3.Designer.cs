namespace EczaneOtomasyon2024
{
    partial class Form3
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
            this.hastalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eczaneOtomasyonuDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eczaneOtomasyonuDBDataSet = new EczaneOtomasyon2024.EczaneOtomasyonuDBDataSet();
            this.ılaclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geciciIlacBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.hastalarTableAdapter = new EczaneOtomasyon2024.EczaneOtomasyonuDBDataSetTableAdapters.HastalarTableAdapter();
            this.dr_btn_anaMenu = new System.Windows.Forms.Button();
            this.dr_btn_cikis = new System.Windows.Forms.Button();
            this.ilaclarTableAdapter = new EczaneOtomasyon2024.EczaneOtomasyonuDBDataSetTableAdapters.IlaclarTableAdapter();
            this.geciciIlacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.geciciIlacTableAdapter = new EczaneOtomasyon2024.EczaneOtomasyonuDBDataSetTableAdapters.GeciciIlacTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dr_txt_usrName = new System.Windows.Forms.TextBox();
            this.dr_txt_passwd = new System.Windows.Forms.TextBox();
            this.dr_btn_profilGiris = new System.Windows.Forms.Button();
            this.dr_tabC = new System.Windows.Forms.TabControl();
            this.dr_tabC_hastalar = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dr_dgw_hastalar = new System.Windows.Forms.DataGridView();
            this.dr_btn_hastaAra = new System.Windows.Forms.Button();
            this.dr_txt_hastaAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dr_tabC_ilacYaz = new System.Windows.Forms.TabPage();
            this.dr_lbl_ilacYazHasta = new System.Windows.Forms.Label();
            this.dr_dgw_ilaclar = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinMaddeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTCKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruhsatSahibiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruhsatTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruhsatNumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullanimYasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dr_btn_ilaçAra = new System.Windows.Forms.Button();
            this.dr_txt_ilacAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dr_tabC_ilacKontrol = new System.Windows.Forms.TabPage();
            this.dr_lbl_receteNo = new System.Windows.Forms.Label();
            this.dr_btn_receteYazdır = new System.Windows.Forms.Button();
            this.dr_dgw_yazılanIlac = new System.Windows.Forms.DataGridView();
            this.dr_tabC_receteSorgu = new System.Windows.Forms.TabPage();
            this.dr_dgw_receteSorgu = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etkinMaddeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTCKoduDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruhsatSahibiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruhsatTarihiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruhsatNumarasiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanimYasiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAdediDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılaclarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dr_btn_receteSorgu = new System.Windows.Forms.Button();
            this.dr_txt_receteSorgu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.receteIcerikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receteIcerikTableAdapter = new EczaneOtomasyon2024.EczaneOtomasyonuDBDataSetTableAdapters.ReceteIcerikTableAdapter();
            this.dr_lbl_mesaj = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigortaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilçeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alerjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneOtomasyonuDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneOtomasyonuDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılaclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geciciIlacBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geciciIlacBindingSource)).BeginInit();
            this.dr_tabC.SuspendLayout();
            this.dr_tabC_hastalar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dr_dgw_hastalar)).BeginInit();
            this.dr_tabC_ilacYaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dr_dgw_ilaclar)).BeginInit();
            this.dr_tabC_ilacKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dr_dgw_yazılanIlac)).BeginInit();
            this.dr_tabC_receteSorgu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dr_dgw_receteSorgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılaclarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteIcerikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hastalarBindingSource
            // 
            this.hastalarBindingSource.DataMember = "Hastalar";
            this.hastalarBindingSource.DataSource = this.eczaneOtomasyonuDBDataSetBindingSource;
            // 
            // eczaneOtomasyonuDBDataSetBindingSource
            // 
            this.eczaneOtomasyonuDBDataSetBindingSource.DataSource = this.eczaneOtomasyonuDBDataSet;
            this.eczaneOtomasyonuDBDataSetBindingSource.Position = 0;
            // 
            // eczaneOtomasyonuDBDataSet
            // 
            this.eczaneOtomasyonuDBDataSet.DataSetName = "EczaneOtomasyonuDBDataSet";
            this.eczaneOtomasyonuDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ılaclarBindingSource
            // 
            this.ılaclarBindingSource.DataMember = "Ilaclar";
            this.ılaclarBindingSource.DataSource = this.eczaneOtomasyonuDBDataSetBindingSource;
            // 
            // geciciIlacBindingSource1
            // 
            this.geciciIlacBindingSource1.DataMember = "GeciciIlac";
            this.geciciIlacBindingSource1.DataSource = this.eczaneOtomasyonuDBDataSetBindingSource;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOKTOR ARAYÜZÜ";
            // 
            // hastalarTableAdapter
            // 
            this.hastalarTableAdapter.ClearBeforeFill = true;
            // 
            // dr_btn_anaMenu
            // 
            this.dr_btn_anaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dr_btn_anaMenu.ForeColor = System.Drawing.Color.Red;
            this.dr_btn_anaMenu.Location = new System.Drawing.Point(1686, 12);
            this.dr_btn_anaMenu.Name = "dr_btn_anaMenu";
            this.dr_btn_anaMenu.Size = new System.Drawing.Size(132, 70);
            this.dr_btn_anaMenu.TabIndex = 2;
            this.dr_btn_anaMenu.Text = "ANA MENÜ";
            this.dr_btn_anaMenu.UseVisualStyleBackColor = true;
            this.dr_btn_anaMenu.Click += new System.EventHandler(this.dr_btn_anaMenu_Click);
            // 
            // dr_btn_cikis
            // 
            this.dr_btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dr_btn_cikis.ForeColor = System.Drawing.Color.Red;
            this.dr_btn_cikis.Location = new System.Drawing.Point(1824, 12);
            this.dr_btn_cikis.Name = "dr_btn_cikis";
            this.dr_btn_cikis.Size = new System.Drawing.Size(132, 70);
            this.dr_btn_cikis.TabIndex = 3;
            this.dr_btn_cikis.Text = "ÇIKIŞ";
            this.dr_btn_cikis.UseVisualStyleBackColor = true;
            this.dr_btn_cikis.Click += new System.EventHandler(this.dr_btn_cikis_Click);
            // 
            // ilaclarTableAdapter
            // 
            this.ilaclarTableAdapter.ClearBeforeFill = true;
            // 
            // geciciIlacBindingSource
            // 
            this.geciciIlacBindingSource.DataMember = "GeciciIlac";
            this.geciciIlacBindingSource.DataSource = this.eczaneOtomasyonuDBDataSetBindingSource;
            // 
            // geciciIlacTableAdapter
            // 
            this.geciciIlacTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kullanıcı Adı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(726, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Şifre : ";
            // 
            // dr_txt_usrName
            // 
            this.dr_txt_usrName.Location = new System.Drawing.Point(802, 276);
            this.dr_txt_usrName.Name = "dr_txt_usrName";
            this.dr_txt_usrName.Size = new System.Drawing.Size(229, 28);
            this.dr_txt_usrName.TabIndex = 2;
            // 
            // dr_txt_passwd
            // 
            this.dr_txt_passwd.Location = new System.Drawing.Point(802, 350);
            this.dr_txt_passwd.Name = "dr_txt_passwd";
            this.dr_txt_passwd.Size = new System.Drawing.Size(229, 28);
            this.dr_txt_passwd.TabIndex = 3;
            // 
            // dr_btn_profilGiris
            // 
            this.dr_btn_profilGiris.Location = new System.Drawing.Point(841, 446);
            this.dr_btn_profilGiris.Name = "dr_btn_profilGiris";
            this.dr_btn_profilGiris.Size = new System.Drawing.Size(190, 59);
            this.dr_btn_profilGiris.TabIndex = 4;
            this.dr_btn_profilGiris.Text = "Giriş Yap";
            this.dr_btn_profilGiris.UseVisualStyleBackColor = true;
            this.dr_btn_profilGiris.Click += new System.EventHandler(this.dr_btn_profilGiris_Click);
            // 
            // dr_tabC
            // 
            this.dr_tabC.Controls.Add(this.dr_tabC_hastalar);
            this.dr_tabC.Controls.Add(this.dr_tabC_ilacYaz);
            this.dr_tabC.Controls.Add(this.dr_tabC_ilacKontrol);
            this.dr_tabC.Controls.Add(this.dr_tabC_receteSorgu);
            this.dr_tabC.Location = new System.Drawing.Point(12, 91);
            this.dr_tabC.Name = "dr_tabC";
            this.dr_tabC.SelectedIndex = 0;
            this.dr_tabC.Size = new System.Drawing.Size(1911, 952);
            this.dr_tabC.TabIndex = 0;
            // 
            // dr_tabC_hastalar
            // 
            this.dr_tabC_hastalar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dr_tabC_hastalar.Controls.Add(this.panel1);
            this.dr_tabC_hastalar.Controls.Add(this.dr_dgw_hastalar);
            this.dr_tabC_hastalar.Controls.Add(this.dr_btn_hastaAra);
            this.dr_tabC_hastalar.Controls.Add(this.dr_txt_hastaAra);
            this.dr_tabC_hastalar.Controls.Add(this.label2);
            this.dr_tabC_hastalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dr_tabC_hastalar.Location = new System.Drawing.Point(4, 25);
            this.dr_tabC_hastalar.Name = "dr_tabC_hastalar";
            this.dr_tabC_hastalar.Padding = new System.Windows.Forms.Padding(3);
            this.dr_tabC_hastalar.Size = new System.Drawing.Size(1903, 923);
            this.dr_tabC_hastalar.TabIndex = 0;
            this.dr_tabC_hastalar.Text = "HASTALAR";
            this.dr_tabC_hastalar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dr_btn_profilGiris);
            this.panel1.Controls.Add(this.dr_txt_passwd);
            this.panel1.Controls.Add(this.dr_txt_usrName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1927, 972);
            this.panel1.TabIndex = 4;
            // 
            // dr_dgw_hastalar
            // 
            this.dr_dgw_hastalar.AutoGenerateColumns = false;
            this.dr_dgw_hastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dr_dgw_hastalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ad,
            this.Soyad,
            this.TC,
            this.sigortaDataGridViewTextBoxColumn,
            this.DogumTarihi,
            this.ilçeDataGridViewTextBoxColumn,
            this.ilDataGridViewTextBoxColumn,
            this.alerjiDataGridViewTextBoxColumn});
            this.dr_dgw_hastalar.DataSource = this.hastalarBindingSource;
            this.dr_dgw_hastalar.Location = new System.Drawing.Point(31, 137);
            this.dr_dgw_hastalar.Name = "dr_dgw_hastalar";
            this.dr_dgw_hastalar.RowHeadersWidth = 51;
            this.dr_dgw_hastalar.RowTemplate.Height = 24;
            this.dr_dgw_hastalar.Size = new System.Drawing.Size(1882, 781);
            this.dr_dgw_hastalar.TabIndex = 3;
            this.dr_dgw_hastalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dr_dgw_hastalar_CellClick);
            // 
            // dr_btn_hastaAra
            // 
            this.dr_btn_hastaAra.Location = new System.Drawing.Point(421, 36);
            this.dr_btn_hastaAra.Name = "dr_btn_hastaAra";
            this.dr_btn_hastaAra.Size = new System.Drawing.Size(70, 37);
            this.dr_btn_hastaAra.TabIndex = 2;
            this.dr_btn_hastaAra.Text = "ARA";
            this.dr_btn_hastaAra.UseVisualStyleBackColor = true;
            this.dr_btn_hastaAra.Click += new System.EventHandler(this.dr_btn_hastaAra_Click);
            // 
            // dr_txt_hastaAra
            // 
            this.dr_txt_hastaAra.Location = new System.Drawing.Point(147, 40);
            this.dr_txt_hastaAra.Name = "dr_txt_hastaAra";
            this.dr_txt_hastaAra.Size = new System.Drawing.Size(239, 28);
            this.dr_txt_hastaAra.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hasta TC :";
            // 
            // dr_tabC_ilacYaz
            // 
            this.dr_tabC_ilacYaz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dr_tabC_ilacYaz.Controls.Add(this.dr_lbl_ilacYazHasta);
            this.dr_tabC_ilacYaz.Controls.Add(this.dr_dgw_ilaclar);
            this.dr_tabC_ilacYaz.Controls.Add(this.dr_btn_ilaçAra);
            this.dr_tabC_ilacYaz.Controls.Add(this.dr_txt_ilacAra);
            this.dr_tabC_ilacYaz.Controls.Add(this.label3);
            this.dr_tabC_ilacYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dr_tabC_ilacYaz.Location = new System.Drawing.Point(4, 25);
            this.dr_tabC_ilacYaz.Name = "dr_tabC_ilacYaz";
            this.dr_tabC_ilacYaz.Padding = new System.Windows.Forms.Padding(3);
            this.dr_tabC_ilacYaz.Size = new System.Drawing.Size(1903, 923);
            this.dr_tabC_ilacYaz.TabIndex = 1;
            this.dr_tabC_ilacYaz.Text = "İLAÇ YAZ";
            this.dr_tabC_ilacYaz.UseVisualStyleBackColor = true;
            // 
            // dr_lbl_ilacYazHasta
            // 
            this.dr_lbl_ilacYazHasta.AutoSize = true;
            this.dr_lbl_ilacYazHasta.Location = new System.Drawing.Point(438, 40);
            this.dr_lbl_ilacYazHasta.Name = "dr_lbl_ilacYazHasta";
            this.dr_lbl_ilacYazHasta.Size = new System.Drawing.Size(85, 22);
            this.dr_lbl_ilacYazHasta.TabIndex = 4;
            this.dr_lbl_ilacYazHasta.Text = "yaşında.";
            // 
            // dr_dgw_ilaclar
            // 
            this.dr_dgw_ilaclar.AutoGenerateColumns = false;
            this.dr_dgw_ilaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dr_dgw_ilaclar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.barkodDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.etkinMaddeDataGridViewTextBoxColumn,
            this.aTCKoduDataGridViewTextBoxColumn,
            this.ruhsatSahibiDataGridViewTextBoxColumn,
            this.ruhsatTarihiDataGridViewTextBoxColumn,
            this.ruhsatNumarasiDataGridViewTextBoxColumn,
            this.KullanimYasi,
            this.fiyatDataGridViewTextBoxColumn,
            this.stokAdediDataGridViewTextBoxColumn});
            this.dr_dgw_ilaclar.DataSource = this.ılaclarBindingSource;
            this.dr_dgw_ilaclar.Location = new System.Drawing.Point(44, 101);
            this.dr_dgw_ilaclar.Name = "dr_dgw_ilaclar";
            this.dr_dgw_ilaclar.RowHeadersWidth = 51;
            this.dr_dgw_ilaclar.RowTemplate.Height = 24;
            this.dr_dgw_ilaclar.Size = new System.Drawing.Size(1861, 817);
            this.dr_dgw_ilaclar.TabIndex = 3;
            this.dr_dgw_ilaclar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dr_dgw_ilaclar_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "Barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "Barkod";
            this.barkodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            this.barkodDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // etkinMaddeDataGridViewTextBoxColumn
            // 
            this.etkinMaddeDataGridViewTextBoxColumn.DataPropertyName = "EtkinMadde";
            this.etkinMaddeDataGridViewTextBoxColumn.HeaderText = "EtkinMadde";
            this.etkinMaddeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.etkinMaddeDataGridViewTextBoxColumn.Name = "etkinMaddeDataGridViewTextBoxColumn";
            this.etkinMaddeDataGridViewTextBoxColumn.Width = 125;
            // 
            // aTCKoduDataGridViewTextBoxColumn
            // 
            this.aTCKoduDataGridViewTextBoxColumn.DataPropertyName = "ATCKodu";
            this.aTCKoduDataGridViewTextBoxColumn.HeaderText = "ATCKodu";
            this.aTCKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aTCKoduDataGridViewTextBoxColumn.Name = "aTCKoduDataGridViewTextBoxColumn";
            this.aTCKoduDataGridViewTextBoxColumn.Visible = false;
            this.aTCKoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // ruhsatSahibiDataGridViewTextBoxColumn
            // 
            this.ruhsatSahibiDataGridViewTextBoxColumn.DataPropertyName = "RuhsatSahibi";
            this.ruhsatSahibiDataGridViewTextBoxColumn.HeaderText = "RuhsatSahibi";
            this.ruhsatSahibiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ruhsatSahibiDataGridViewTextBoxColumn.Name = "ruhsatSahibiDataGridViewTextBoxColumn";
            this.ruhsatSahibiDataGridViewTextBoxColumn.Visible = false;
            this.ruhsatSahibiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ruhsatTarihiDataGridViewTextBoxColumn
            // 
            this.ruhsatTarihiDataGridViewTextBoxColumn.DataPropertyName = "RuhsatTarihi";
            this.ruhsatTarihiDataGridViewTextBoxColumn.HeaderText = "RuhsatTarihi";
            this.ruhsatTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ruhsatTarihiDataGridViewTextBoxColumn.Name = "ruhsatTarihiDataGridViewTextBoxColumn";
            this.ruhsatTarihiDataGridViewTextBoxColumn.Visible = false;
            this.ruhsatTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ruhsatNumarasiDataGridViewTextBoxColumn
            // 
            this.ruhsatNumarasiDataGridViewTextBoxColumn.DataPropertyName = "RuhsatNumarasi";
            this.ruhsatNumarasiDataGridViewTextBoxColumn.HeaderText = "RuhsatNumarasi";
            this.ruhsatNumarasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ruhsatNumarasiDataGridViewTextBoxColumn.Name = "ruhsatNumarasiDataGridViewTextBoxColumn";
            this.ruhsatNumarasiDataGridViewTextBoxColumn.Visible = false;
            this.ruhsatNumarasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // KullanimYasi
            // 
            this.KullanimYasi.DataPropertyName = "KullanimYasi";
            this.KullanimYasi.HeaderText = "KullanimYasi";
            this.KullanimYasi.MinimumWidth = 6;
            this.KullanimYasi.Name = "KullanimYasi";
            this.KullanimYasi.Width = 125;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Visible = false;
            this.fiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokAdediDataGridViewTextBoxColumn
            // 
            this.stokAdediDataGridViewTextBoxColumn.DataPropertyName = "Stok Adedi";
            this.stokAdediDataGridViewTextBoxColumn.HeaderText = "Stok Adedi";
            this.stokAdediDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokAdediDataGridViewTextBoxColumn.Name = "stokAdediDataGridViewTextBoxColumn";
            this.stokAdediDataGridViewTextBoxColumn.Visible = false;
            this.stokAdediDataGridViewTextBoxColumn.Width = 125;
            // 
            // dr_btn_ilaçAra
            // 
            this.dr_btn_ilaçAra.Location = new System.Drawing.Point(330, 34);
            this.dr_btn_ilaçAra.Name = "dr_btn_ilaçAra";
            this.dr_btn_ilaçAra.Size = new System.Drawing.Size(67, 28);
            this.dr_btn_ilaçAra.TabIndex = 2;
            this.dr_btn_ilaçAra.Text = "ARA";
            this.dr_btn_ilaçAra.UseVisualStyleBackColor = true;
            this.dr_btn_ilaçAra.Click += new System.EventHandler(this.dr_btn_ilaçAra_Click);
            // 
            // dr_txt_ilacAra
            // 
            this.dr_txt_ilacAra.Location = new System.Drawing.Point(115, 34);
            this.dr_txt_ilacAra.Name = "dr_txt_ilacAra";
            this.dr_txt_ilacAra.Size = new System.Drawing.Size(193, 28);
            this.dr_txt_ilacAra.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "İlaç Adı: ";
            // 
            // dr_tabC_ilacKontrol
            // 
            this.dr_tabC_ilacKontrol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dr_tabC_ilacKontrol.Controls.Add(this.dr_lbl_receteNo);
            this.dr_tabC_ilacKontrol.Controls.Add(this.dr_btn_receteYazdır);
            this.dr_tabC_ilacKontrol.Controls.Add(this.dr_dgw_yazılanIlac);
            this.dr_tabC_ilacKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dr_tabC_ilacKontrol.Location = new System.Drawing.Point(4, 25);
            this.dr_tabC_ilacKontrol.Name = "dr_tabC_ilacKontrol";
            this.dr_tabC_ilacKontrol.Size = new System.Drawing.Size(1903, 923);
            this.dr_tabC_ilacKontrol.TabIndex = 2;
            this.dr_tabC_ilacKontrol.Text = "YAZILAN İLAÇLAR";
            this.dr_tabC_ilacKontrol.UseVisualStyleBackColor = true;
            // 
            // dr_lbl_receteNo
            // 
            this.dr_lbl_receteNo.AutoSize = true;
            this.dr_lbl_receteNo.Location = new System.Drawing.Point(375, 38);
            this.dr_lbl_receteNo.Name = "dr_lbl_receteNo";
            this.dr_lbl_receteNo.Size = new System.Drawing.Size(116, 22);
            this.dr_lbl_receteNo.TabIndex = 2;
            this.dr_lbl_receteNo.Text = "Reçete No :";
            // 
            // dr_btn_receteYazdır
            // 
            this.dr_btn_receteYazdır.Location = new System.Drawing.Point(33, 20);
            this.dr_btn_receteYazdır.Name = "dr_btn_receteYazdır";
            this.dr_btn_receteYazdır.Size = new System.Drawing.Size(290, 59);
            this.dr_btn_receteYazdır.TabIndex = 1;
            this.dr_btn_receteYazdır.Text = " Reçeteyi Yazdır";
            this.dr_btn_receteYazdır.UseVisualStyleBackColor = true;
            this.dr_btn_receteYazdır.Click += new System.EventHandler(this.dr_btn_receteYazdır_Click);
            // 
            // dr_dgw_yazılanIlac
            // 
            this.dr_dgw_yazılanIlac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dr_dgw_yazılanIlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dr_dgw_yazılanIlac.Location = new System.Drawing.Point(33, 98);
            this.dr_dgw_yazılanIlac.Name = "dr_dgw_yazılanIlac";
            this.dr_dgw_yazılanIlac.RowHeadersWidth = 51;
            this.dr_dgw_yazılanIlac.RowTemplate.Height = 24;
            this.dr_dgw_yazılanIlac.Size = new System.Drawing.Size(1728, 380);
            this.dr_dgw_yazılanIlac.TabIndex = 0;
            this.dr_dgw_yazılanIlac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dr_dgw_yazılanIlac_CellClick);
            // 
            // dr_tabC_receteSorgu
            // 
            this.dr_tabC_receteSorgu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dr_tabC_receteSorgu.Controls.Add(this.dr_dgw_receteSorgu);
            this.dr_tabC_receteSorgu.Controls.Add(this.dr_btn_receteSorgu);
            this.dr_tabC_receteSorgu.Controls.Add(this.dr_txt_receteSorgu);
            this.dr_tabC_receteSorgu.Controls.Add(this.label6);
            this.dr_tabC_receteSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dr_tabC_receteSorgu.Location = new System.Drawing.Point(4, 25);
            this.dr_tabC_receteSorgu.Name = "dr_tabC_receteSorgu";
            this.dr_tabC_receteSorgu.Size = new System.Drawing.Size(1903, 923);
            this.dr_tabC_receteSorgu.TabIndex = 3;
            this.dr_tabC_receteSorgu.Text = "REÇETE SORGULA";
            this.dr_tabC_receteSorgu.UseVisualStyleBackColor = true;
            // 
            // dr_dgw_receteSorgu
            // 
            this.dr_dgw_receteSorgu.AutoGenerateColumns = false;
            this.dr_dgw_receteSorgu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dr_dgw_receteSorgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dr_dgw_receteSorgu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.barkodDataGridViewTextBoxColumn1,
            this.urunAdiDataGridViewTextBoxColumn1,
            this.etkinMaddeDataGridViewTextBoxColumn1,
            this.aTCKoduDataGridViewTextBoxColumn1,
            this.ruhsatSahibiDataGridViewTextBoxColumn1,
            this.ruhsatTarihiDataGridViewTextBoxColumn1,
            this.ruhsatNumarasiDataGridViewTextBoxColumn1,
            this.kullanimYasiDataGridViewTextBoxColumn1,
            this.fiyatDataGridViewTextBoxColumn1,
            this.stokAdediDataGridViewTextBoxColumn1});
            this.dr_dgw_receteSorgu.DataSource = this.ılaclarBindingSource1;
            this.dr_dgw_receteSorgu.Location = new System.Drawing.Point(63, 132);
            this.dr_dgw_receteSorgu.Name = "dr_dgw_receteSorgu";
            this.dr_dgw_receteSorgu.RowHeadersWidth = 51;
            this.dr_dgw_receteSorgu.RowTemplate.Height = 24;
            this.dr_dgw_receteSorgu.Size = new System.Drawing.Size(1831, 587);
            this.dr_dgw_receteSorgu.TabIndex = 3;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // barkodDataGridViewTextBoxColumn1
            // 
            this.barkodDataGridViewTextBoxColumn1.DataPropertyName = "Barkod";
            this.barkodDataGridViewTextBoxColumn1.HeaderText = "Barkod";
            this.barkodDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.barkodDataGridViewTextBoxColumn1.Name = "barkodDataGridViewTextBoxColumn1";
            // 
            // urunAdiDataGridViewTextBoxColumn1
            // 
            this.urunAdiDataGridViewTextBoxColumn1.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn1.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn1.Name = "urunAdiDataGridViewTextBoxColumn1";
            // 
            // etkinMaddeDataGridViewTextBoxColumn1
            // 
            this.etkinMaddeDataGridViewTextBoxColumn1.DataPropertyName = "EtkinMadde";
            this.etkinMaddeDataGridViewTextBoxColumn1.HeaderText = "EtkinMadde";
            this.etkinMaddeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.etkinMaddeDataGridViewTextBoxColumn1.Name = "etkinMaddeDataGridViewTextBoxColumn1";
            // 
            // aTCKoduDataGridViewTextBoxColumn1
            // 
            this.aTCKoduDataGridViewTextBoxColumn1.DataPropertyName = "ATCKodu";
            this.aTCKoduDataGridViewTextBoxColumn1.HeaderText = "ATCKodu";
            this.aTCKoduDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.aTCKoduDataGridViewTextBoxColumn1.Name = "aTCKoduDataGridViewTextBoxColumn1";
            this.aTCKoduDataGridViewTextBoxColumn1.Visible = false;
            // 
            // ruhsatSahibiDataGridViewTextBoxColumn1
            // 
            this.ruhsatSahibiDataGridViewTextBoxColumn1.DataPropertyName = "RuhsatSahibi";
            this.ruhsatSahibiDataGridViewTextBoxColumn1.HeaderText = "RuhsatSahibi";
            this.ruhsatSahibiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ruhsatSahibiDataGridViewTextBoxColumn1.Name = "ruhsatSahibiDataGridViewTextBoxColumn1";
            this.ruhsatSahibiDataGridViewTextBoxColumn1.Visible = false;
            // 
            // ruhsatTarihiDataGridViewTextBoxColumn1
            // 
            this.ruhsatTarihiDataGridViewTextBoxColumn1.DataPropertyName = "RuhsatTarihi";
            this.ruhsatTarihiDataGridViewTextBoxColumn1.HeaderText = "RuhsatTarihi";
            this.ruhsatTarihiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ruhsatTarihiDataGridViewTextBoxColumn1.Name = "ruhsatTarihiDataGridViewTextBoxColumn1";
            this.ruhsatTarihiDataGridViewTextBoxColumn1.Visible = false;
            // 
            // ruhsatNumarasiDataGridViewTextBoxColumn1
            // 
            this.ruhsatNumarasiDataGridViewTextBoxColumn1.DataPropertyName = "RuhsatNumarasi";
            this.ruhsatNumarasiDataGridViewTextBoxColumn1.HeaderText = "RuhsatNumarasi";
            this.ruhsatNumarasiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ruhsatNumarasiDataGridViewTextBoxColumn1.Name = "ruhsatNumarasiDataGridViewTextBoxColumn1";
            this.ruhsatNumarasiDataGridViewTextBoxColumn1.Visible = false;
            // 
            // kullanimYasiDataGridViewTextBoxColumn1
            // 
            this.kullanimYasiDataGridViewTextBoxColumn1.DataPropertyName = "KullanimYasi";
            this.kullanimYasiDataGridViewTextBoxColumn1.HeaderText = "KullanimYasi";
            this.kullanimYasiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kullanimYasiDataGridViewTextBoxColumn1.Name = "kullanimYasiDataGridViewTextBoxColumn1";
            // 
            // fiyatDataGridViewTextBoxColumn1
            // 
            this.fiyatDataGridViewTextBoxColumn1.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn1.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn1.Name = "fiyatDataGridViewTextBoxColumn1";
            this.fiyatDataGridViewTextBoxColumn1.Visible = false;
            // 
            // stokAdediDataGridViewTextBoxColumn1
            // 
            this.stokAdediDataGridViewTextBoxColumn1.DataPropertyName = "Stok Adedi";
            this.stokAdediDataGridViewTextBoxColumn1.HeaderText = "Stok Adedi";
            this.stokAdediDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.stokAdediDataGridViewTextBoxColumn1.Name = "stokAdediDataGridViewTextBoxColumn1";
            this.stokAdediDataGridViewTextBoxColumn1.Visible = false;
            // 
            // ılaclarBindingSource1
            // 
            this.ılaclarBindingSource1.DataMember = "Ilaclar";
            this.ılaclarBindingSource1.DataSource = this.eczaneOtomasyonuDBDataSetBindingSource;
            // 
            // dr_btn_receteSorgu
            // 
            this.dr_btn_receteSorgu.Location = new System.Drawing.Point(413, 47);
            this.dr_btn_receteSorgu.Name = "dr_btn_receteSorgu";
            this.dr_btn_receteSorgu.Size = new System.Drawing.Size(64, 28);
            this.dr_btn_receteSorgu.TabIndex = 2;
            this.dr_btn_receteSorgu.Text = "ARA";
            this.dr_btn_receteSorgu.UseVisualStyleBackColor = true;
            this.dr_btn_receteSorgu.Click += new System.EventHandler(this.dr_btn_receteSorgu_Click);
            // 
            // dr_txt_receteSorgu
            // 
            this.dr_txt_receteSorgu.Location = new System.Drawing.Point(190, 47);
            this.dr_txt_receteSorgu.Name = "dr_txt_receteSorgu";
            this.dr_txt_receteSorgu.Size = new System.Drawing.Size(207, 28);
            this.dr_txt_receteSorgu.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Reçete No :";
            // 
            // receteIcerikBindingSource
            // 
            this.receteIcerikBindingSource.DataMember = "ReceteIcerik";
            this.receteIcerikBindingSource.DataSource = this.eczaneOtomasyonuDBDataSetBindingSource;
            // 
            // receteIcerikTableAdapter
            // 
            this.receteIcerikTableAdapter.ClearBeforeFill = true;
            // 
            // dr_lbl_mesaj
            // 
            this.dr_lbl_mesaj.AutoSize = true;
            this.dr_lbl_mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dr_lbl_mesaj.Location = new System.Drawing.Point(1235, 39);
            this.dr_lbl_mesaj.Name = "dr_lbl_mesaj";
            this.dr_lbl_mesaj.Size = new System.Drawing.Size(220, 25);
            this.dr_lbl_mesaj.TabIndex = 4;
            this.dr_lbl_mesaj.Text = "HOŞGELDİN SAYIN  ";
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.Width = 125;
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soyad";
            this.Soyad.MinimumWidth = 6;
            this.Soyad.Name = "Soyad";
            this.Soyad.Width = 125;
            // 
            // TC
            // 
            this.TC.DataPropertyName = "TC";
            this.TC.HeaderText = "TC";
            this.TC.MinimumWidth = 6;
            this.TC.Name = "TC";
            this.TC.Width = 125;
            // 
            // sigortaDataGridViewTextBoxColumn
            // 
            this.sigortaDataGridViewTextBoxColumn.DataPropertyName = "Sigorta";
            this.sigortaDataGridViewTextBoxColumn.HeaderText = "Sigorta";
            this.sigortaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sigortaDataGridViewTextBoxColumn.Name = "sigortaDataGridViewTextBoxColumn";
            this.sigortaDataGridViewTextBoxColumn.Width = 125;
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.DataPropertyName = "Doğum Tarihi";
            this.DogumTarihi.HeaderText = "Doğum Tarihi";
            this.DogumTarihi.MinimumWidth = 6;
            this.DogumTarihi.Name = "DogumTarihi";
            this.DogumTarihi.Width = 125;
            // 
            // ilçeDataGridViewTextBoxColumn
            // 
            this.ilçeDataGridViewTextBoxColumn.DataPropertyName = "İlçe";
            this.ilçeDataGridViewTextBoxColumn.HeaderText = "İlçe";
            this.ilçeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilçeDataGridViewTextBoxColumn.Name = "ilçeDataGridViewTextBoxColumn";
            this.ilçeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ilDataGridViewTextBoxColumn
            // 
            this.ilDataGridViewTextBoxColumn.DataPropertyName = "İl";
            this.ilDataGridViewTextBoxColumn.HeaderText = "İl";
            this.ilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilDataGridViewTextBoxColumn.Name = "ilDataGridViewTextBoxColumn";
            this.ilDataGridViewTextBoxColumn.Width = 125;
            // 
            // alerjiDataGridViewTextBoxColumn
            // 
            this.alerjiDataGridViewTextBoxColumn.DataPropertyName = "Alerji";
            this.alerjiDataGridViewTextBoxColumn.HeaderText = "Alerji";
            this.alerjiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alerjiDataGridViewTextBoxColumn.Name = "alerjiDataGridViewTextBoxColumn";
            this.alerjiDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.dr_lbl_mesaj);
            this.Controls.Add(this.dr_tabC);
            this.Controls.Add(this.dr_btn_cikis);
            this.Controls.Add(this.dr_btn_anaMenu);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneOtomasyonuDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneOtomasyonuDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılaclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geciciIlacBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geciciIlacBindingSource)).EndInit();
            this.dr_tabC.ResumeLayout(false);
            this.dr_tabC_hastalar.ResumeLayout(false);
            this.dr_tabC_hastalar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dr_dgw_hastalar)).EndInit();
            this.dr_tabC_ilacYaz.ResumeLayout(false);
            this.dr_tabC_ilacYaz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dr_dgw_ilaclar)).EndInit();
            this.dr_tabC_ilacKontrol.ResumeLayout(false);
            this.dr_tabC_ilacKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dr_dgw_yazılanIlac)).EndInit();
            this.dr_tabC_receteSorgu.ResumeLayout(false);
            this.dr_tabC_receteSorgu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dr_dgw_receteSorgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ılaclarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receteIcerikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource eczaneOtomasyonuDBDataSetBindingSource;
        private EczaneOtomasyonuDBDataSet eczaneOtomasyonuDBDataSet;
        private System.Windows.Forms.BindingSource hastalarBindingSource;
        private EczaneOtomasyonuDBDataSetTableAdapters.HastalarTableAdapter hastalarTableAdapter;
        private System.Windows.Forms.Button dr_btn_anaMenu;
        private System.Windows.Forms.Button dr_btn_cikis;
        private System.Windows.Forms.BindingSource ılaclarBindingSource;
        private EczaneOtomasyonuDBDataSetTableAdapters.IlaclarTableAdapter ilaclarTableAdapter;
        private System.Windows.Forms.BindingSource geciciIlacBindingSource;
        private EczaneOtomasyonuDBDataSetTableAdapters.GeciciIlacTableAdapter geciciIlacTableAdapter;
        private System.Windows.Forms.BindingSource geciciIlacBindingSource1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dr_txt_usrName;
        private System.Windows.Forms.TextBox dr_txt_passwd;
        private System.Windows.Forms.Button dr_btn_profilGiris;
        private System.Windows.Forms.TabControl dr_tabC;
        private System.Windows.Forms.TabPage dr_tabC_hastalar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dr_dgw_hastalar;
        private System.Windows.Forms.Button dr_btn_hastaAra;
        private System.Windows.Forms.TextBox dr_txt_hastaAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage dr_tabC_ilacKontrol;
        private System.Windows.Forms.Label dr_lbl_receteNo;
        private System.Windows.Forms.Button dr_btn_receteYazdır;
        private System.Windows.Forms.DataGridView dr_dgw_yazılanIlac;
        private System.Windows.Forms.TabPage dr_tabC_receteSorgu;
        private System.Windows.Forms.TabPage dr_tabC_ilacYaz;
        private System.Windows.Forms.Label dr_lbl_ilacYazHasta;
        private System.Windows.Forms.DataGridView dr_dgw_ilaclar;
        private System.Windows.Forms.Button dr_btn_ilaçAra;
        private System.Windows.Forms.TextBox dr_txt_ilacAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dr_dgw_receteSorgu;
        private System.Windows.Forms.Button dr_btn_receteSorgu;
        private System.Windows.Forms.TextBox dr_txt_receteSorgu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource receteIcerikBindingSource;
        private EczaneOtomasyonuDBDataSetTableAdapters.ReceteIcerikTableAdapter receteIcerikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinMaddeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTCKoduDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruhsatSahibiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruhsatTarihiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruhsatNumarasiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanimYasiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAdediDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource ılaclarBindingSource1;
        private System.Windows.Forms.Label dr_lbl_mesaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etkinMaddeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTCKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruhsatSahibiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruhsatTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruhsatNumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullanimYasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAdediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn TC;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigortaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilçeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alerjiDataGridViewTextBoxColumn;
    }
}