namespace EczaneOtomasyon2024
{
    partial class Form4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.ecz_dgw_receteSorgu = new System.Windows.Forms.DataGridView();
            this.ecz_btn_receteAra = new System.Windows.Forms.Button();
            this.ecz_lbl_receteSorgu = new System.Windows.Forms.Label();
            this.ecz_txt_receteAra = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.ecz_dgw_hastaAra = new System.Windows.Forms.DataGridView();
            this.ecz_btn_hastaAra = new System.Windows.Forms.Button();
            this.ecz_txt_hastaAra = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ecz_btn_anaMenü = new System.Windows.Forms.Button();
            this.ecz_btn_cikis = new System.Windows.Forms.Button();
            this.eczaneOtomasyonuDBDataSet = new EczaneOtomasyon2024.EczaneOtomasyonuDBDataSet();
            this.hastalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastalarTableAdapter = new EczaneOtomasyon2024.EczaneOtomasyonuDBDataSetTableAdapters.HastalarTableAdapter();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigortaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doğumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilçeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alerjiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecz_dgw_receteSorgu)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecz_dgw_hastaAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneOtomasyonuDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1920, 957);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ecz_dgw_receteSorgu);
            this.tabPage1.Controls.Add(this.ecz_btn_receteAra);
            this.tabPage1.Controls.Add(this.ecz_lbl_receteSorgu);
            this.tabPage1.Controls.Add(this.ecz_txt_receteAra);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1912, 928);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "REÇETE SORGULA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "REÇETE NO : ";
            // 
            // ecz_dgw_receteSorgu
            // 
            this.ecz_dgw_receteSorgu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ecz_dgw_receteSorgu.Location = new System.Drawing.Point(22, 97);
            this.ecz_dgw_receteSorgu.Name = "ecz_dgw_receteSorgu";
            this.ecz_dgw_receteSorgu.RowHeadersWidth = 51;
            this.ecz_dgw_receteSorgu.RowTemplate.Height = 24;
            this.ecz_dgw_receteSorgu.Size = new System.Drawing.Size(1894, 835);
            this.ecz_dgw_receteSorgu.TabIndex = 3;
            // 
            // ecz_btn_receteAra
            // 
            this.ecz_btn_receteAra.Location = new System.Drawing.Point(383, 45);
            this.ecz_btn_receteAra.Name = "ecz_btn_receteAra";
            this.ecz_btn_receteAra.Size = new System.Drawing.Size(75, 25);
            this.ecz_btn_receteAra.TabIndex = 2;
            this.ecz_btn_receteAra.Text = "ARA";
            this.ecz_btn_receteAra.UseVisualStyleBackColor = true;
            this.ecz_btn_receteAra.Click += new System.EventHandler(this.ecz_btn_receteAra_Click);
            // 
            // ecz_lbl_receteSorgu
            // 
            this.ecz_lbl_receteSorgu.AutoSize = true;
            this.ecz_lbl_receteSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ecz_lbl_receteSorgu.Location = new System.Drawing.Point(481, 49);
            this.ecz_lbl_receteSorgu.Name = "ecz_lbl_receteSorgu";
            this.ecz_lbl_receteSorgu.Size = new System.Drawing.Size(21, 20);
            this.ecz_lbl_receteSorgu.TabIndex = 1;
            this.ecz_lbl_receteSorgu.Text = "...";
            // 
            // ecz_txt_receteAra
            // 
            this.ecz_txt_receteAra.Location = new System.Drawing.Point(191, 48);
            this.ecz_txt_receteAra.Name = "ecz_txt_receteAra";
            this.ecz_txt_receteAra.Size = new System.Drawing.Size(173, 22);
            this.ecz_txt_receteAra.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ecz_dgw_hastaAra);
            this.tabPage2.Controls.Add(this.ecz_btn_hastaAra);
            this.tabPage2.Controls.Add(this.ecz_txt_hastaAra);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1912, 928);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HASTA SORGULA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "HASTA TC:";
            // 
            // ecz_dgw_hastaAra
            // 
            this.ecz_dgw_hastaAra.AutoGenerateColumns = false;
            this.ecz_dgw_hastaAra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ecz_dgw_hastaAra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ecz_dgw_hastaAra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.tCDataGridViewTextBoxColumn,
            this.sigortaDataGridViewTextBoxColumn,
            this.doğumTarihiDataGridViewTextBoxColumn,
            this.ilçeDataGridViewTextBoxColumn,
            this.ilDataGridViewTextBoxColumn,
            this.alerjiDataGridViewTextBoxColumn});
            this.ecz_dgw_hastaAra.DataSource = this.hastalarBindingSource;
            this.ecz_dgw_hastaAra.Location = new System.Drawing.Point(28, 92);
            this.ecz_dgw_hastaAra.Name = "ecz_dgw_hastaAra";
            this.ecz_dgw_hastaAra.RowHeadersWidth = 51;
            this.ecz_dgw_hastaAra.RowTemplate.Height = 24;
            this.ecz_dgw_hastaAra.Size = new System.Drawing.Size(1878, 840);
            this.ecz_dgw_hastaAra.TabIndex = 2;
            // 
            // ecz_btn_hastaAra
            // 
            this.ecz_btn_hastaAra.Location = new System.Drawing.Point(377, 46);
            this.ecz_btn_hastaAra.Name = "ecz_btn_hastaAra";
            this.ecz_btn_hastaAra.Size = new System.Drawing.Size(69, 24);
            this.ecz_btn_hastaAra.TabIndex = 1;
            this.ecz_btn_hastaAra.Text = "ARA";
            this.ecz_btn_hastaAra.UseVisualStyleBackColor = true;
            this.ecz_btn_hastaAra.Click += new System.EventHandler(this.ecz_btn_hastaAra_Click);
            // 
            // ecz_txt_hastaAra
            // 
            this.ecz_txt_hastaAra.Location = new System.Drawing.Point(180, 48);
            this.ecz_txt_hastaAra.Name = "ecz_txt_hastaAra";
            this.ecz_txt_hastaAra.Size = new System.Drawing.Size(170, 22);
            this.ecz_txt_hastaAra.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1912, 928);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "İLAÇLAR";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1912, 928);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "SEPET";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eczacı Arayüzü";
            // 
            // ecz_btn_anaMenü
            // 
            this.ecz_btn_anaMenü.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ecz_btn_anaMenü.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ecz_btn_anaMenü.ForeColor = System.Drawing.Color.Red;
            this.ecz_btn_anaMenü.Location = new System.Drawing.Point(1681, 12);
            this.ecz_btn_anaMenü.Name = "ecz_btn_anaMenü";
            this.ecz_btn_anaMenü.Size = new System.Drawing.Size(139, 58);
            this.ecz_btn_anaMenü.TabIndex = 2;
            this.ecz_btn_anaMenü.Text = "ANA MENÜ";
            this.ecz_btn_anaMenü.UseVisualStyleBackColor = true;
            this.ecz_btn_anaMenü.Click += new System.EventHandler(this.ecz_btn_anaMenü_Click);
            // 
            // ecz_btn_cikis
            // 
            this.ecz_btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ecz_btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ecz_btn_cikis.ForeColor = System.Drawing.Color.Red;
            this.ecz_btn_cikis.Location = new System.Drawing.Point(1837, 12);
            this.ecz_btn_cikis.Name = "ecz_btn_cikis";
            this.ecz_btn_cikis.Size = new System.Drawing.Size(139, 58);
            this.ecz_btn_cikis.TabIndex = 3;
            this.ecz_btn_cikis.Text = "ÇIKIŞ";
            this.ecz_btn_cikis.UseVisualStyleBackColor = true;
            this.ecz_btn_cikis.Click += new System.EventHandler(this.ecz_btn_cikis_Click);
            // 
            // eczaneOtomasyonuDBDataSet
            // 
            this.eczaneOtomasyonuDBDataSet.DataSetName = "EczaneOtomasyonuDBDataSet";
            this.eczaneOtomasyonuDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastalarBindingSource
            // 
            this.hastalarBindingSource.DataMember = "Hastalar";
            this.hastalarBindingSource.DataSource = this.eczaneOtomasyonuDBDataSet;
            // 
            // hastalarTableAdapter
            // 
            this.hastalarTableAdapter.ClearBeforeFill = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            // 
            // sigortaDataGridViewTextBoxColumn
            // 
            this.sigortaDataGridViewTextBoxColumn.DataPropertyName = "Sigorta";
            this.sigortaDataGridViewTextBoxColumn.HeaderText = "Sigorta";
            this.sigortaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sigortaDataGridViewTextBoxColumn.Name = "sigortaDataGridViewTextBoxColumn";
            // 
            // doğumTarihiDataGridViewTextBoxColumn
            // 
            this.doğumTarihiDataGridViewTextBoxColumn.DataPropertyName = "Doğum Tarihi";
            this.doğumTarihiDataGridViewTextBoxColumn.HeaderText = "Doğum Tarihi";
            this.doğumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doğumTarihiDataGridViewTextBoxColumn.Name = "doğumTarihiDataGridViewTextBoxColumn";
            // 
            // ilçeDataGridViewTextBoxColumn
            // 
            this.ilçeDataGridViewTextBoxColumn.DataPropertyName = "İlçe";
            this.ilçeDataGridViewTextBoxColumn.HeaderText = "İlçe";
            this.ilçeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilçeDataGridViewTextBoxColumn.Name = "ilçeDataGridViewTextBoxColumn";
            // 
            // ilDataGridViewTextBoxColumn
            // 
            this.ilDataGridViewTextBoxColumn.DataPropertyName = "İl";
            this.ilDataGridViewTextBoxColumn.HeaderText = "İl";
            this.ilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ilDataGridViewTextBoxColumn.Name = "ilDataGridViewTextBoxColumn";
            // 
            // alerjiDataGridViewTextBoxColumn
            // 
            this.alerjiDataGridViewTextBoxColumn.DataPropertyName = "Alerji";
            this.alerjiDataGridViewTextBoxColumn.HeaderText = "Alerji";
            this.alerjiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alerjiDataGridViewTextBoxColumn.Name = "alerjiDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.ecz_btn_cikis);
            this.Controls.Add(this.ecz_btn_anaMenü);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecz_dgw_receteSorgu)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecz_dgw_hastaAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneOtomasyonuDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ecz_btn_anaMenü;
        private System.Windows.Forms.Button ecz_btn_cikis;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView ecz_dgw_receteSorgu;
        private System.Windows.Forms.Button ecz_btn_receteAra;
        private System.Windows.Forms.Label ecz_lbl_receteSorgu;
        private System.Windows.Forms.TextBox ecz_txt_receteAra;
        private System.Windows.Forms.DataGridView ecz_dgw_hastaAra;
        private System.Windows.Forms.Button ecz_btn_hastaAra;
        private System.Windows.Forms.TextBox ecz_txt_hastaAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private EczaneOtomasyonuDBDataSet eczaneOtomasyonuDBDataSet;
        private System.Windows.Forms.BindingSource hastalarBindingSource;
        private EczaneOtomasyonuDBDataSetTableAdapters.HastalarTableAdapter hastalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigortaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doğumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilçeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alerjiDataGridViewTextBoxColumn;
    }
}