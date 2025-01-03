namespace EczaneOtomasyon2024
{
    partial class Form2
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
            this.mod_tabc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mod_btn_login = new System.Windows.Forms.Button();
            this.mod_txt_modPswd = new System.Windows.Forms.TextBox();
            this.mod_txt_modUsrN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mod_cb_ecz = new System.Windows.Forms.CheckBox();
            this.mod_cb_dr = new System.Windows.Forms.CheckBox();
            this.mod_txt_passwvalid = new System.Windows.Forms.TextBox();
            this.mod_txt_pssw = new System.Windows.Forms.TextBox();
            this.mod_txt_usrnm = new System.Windows.Forms.TextBox();
            this.mod_btn_usrCrt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mod_btn_usrSil = new System.Windows.Forms.Button();
            this.mod_txt_usrSil = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kullanıcıIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcıAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanıcılarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eczaneOtomasyonuDBDataSet = new EczaneOtomasyon2024.EczaneOtomasyonuDBDataSet();
            this.mod_btn_main = new System.Windows.Forms.Button();
            this.kullanıcılarTableAdapter = new EczaneOtomasyon2024.EczaneOtomasyonuDBDataSetTableAdapters.KullanıcılarTableAdapter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mod_tabc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneOtomasyonuDBDataSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mod_tabc
            // 
            this.mod_tabc.Controls.Add(this.tabPage1);
            this.mod_tabc.Controls.Add(this.tabPage2);
            this.mod_tabc.Controls.Add(this.tabPage3);
            this.mod_tabc.Controls.Add(this.tabPage4);
            this.mod_tabc.Location = new System.Drawing.Point(3, 23);
            this.mod_tabc.Name = "mod_tabc";
            this.mod_tabc.SelectedIndex = 0;
            this.mod_tabc.Size = new System.Drawing.Size(793, 427);
            this.mod_tabc.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.mod_cb_ecz);
            this.tabPage1.Controls.Add(this.mod_cb_dr);
            this.tabPage1.Controls.Add(this.mod_txt_passwvalid);
            this.tabPage1.Controls.Add(this.mod_txt_pssw);
            this.tabPage1.Controls.Add(this.mod_txt_usrnm);
            this.tabPage1.Controls.Add(this.mod_btn_usrCrt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kullanıcı Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mod_btn_login);
            this.panel1.Controls.Add(this.mod_txt_modPswd);
            this.panel1.Controls.Add(this.mod_txt_modUsrN);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 426);
            this.panel1.TabIndex = 11;
            // 
            // mod_btn_login
            // 
            this.mod_btn_login.Location = new System.Drawing.Point(268, 224);
            this.mod_btn_login.Name = "mod_btn_login";
            this.mod_btn_login.Size = new System.Drawing.Size(181, 52);
            this.mod_btn_login.TabIndex = 4;
            this.mod_btn_login.Text = "Giriş Yap";
            this.mod_btn_login.UseVisualStyleBackColor = true;
            this.mod_btn_login.Click += new System.EventHandler(this.mod_btn_login_Click);
            // 
            // mod_txt_modPswd
            // 
            this.mod_txt_modPswd.Location = new System.Drawing.Point(268, 156);
            this.mod_txt_modPswd.Name = "mod_txt_modPswd";
            this.mod_txt_modPswd.Size = new System.Drawing.Size(181, 22);
            this.mod_txt_modPswd.TabIndex = 3;
            // 
            // mod_txt_modUsrN
            // 
            this.mod_txt_modUsrN.Location = new System.Drawing.Point(271, 107);
            this.mod_txt_modUsrN.Name = "mod_txt_modUsrN";
            this.mod_txt_modUsrN.Size = new System.Drawing.Size(178, 22);
            this.mod_txt_modUsrN.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Şifre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kullanıcı Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(235, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "YÖNETİCİ ARAYÜZÜ";
            // 
            // mod_cb_ecz
            // 
            this.mod_cb_ecz.AutoSize = true;
            this.mod_cb_ecz.Location = new System.Drawing.Point(406, 256);
            this.mod_cb_ecz.Name = "mod_cb_ecz";
            this.mod_cb_ecz.Size = new System.Drawing.Size(69, 20);
            this.mod_cb_ecz.TabIndex = 9;
            this.mod_cb_ecz.Text = "Eczacı";
            this.mod_cb_ecz.UseVisualStyleBackColor = true;
            // 
            // mod_cb_dr
            // 
            this.mod_cb_dr.AutoSize = true;
            this.mod_cb_dr.Location = new System.Drawing.Point(296, 256);
            this.mod_cb_dr.Name = "mod_cb_dr";
            this.mod_cb_dr.Size = new System.Drawing.Size(69, 20);
            this.mod_cb_dr.TabIndex = 8;
            this.mod_cb_dr.Text = "Doktor";
            this.mod_cb_dr.UseVisualStyleBackColor = true;
            // 
            // mod_txt_passwvalid
            // 
            this.mod_txt_passwvalid.Location = new System.Drawing.Point(267, 205);
            this.mod_txt_passwvalid.Name = "mod_txt_passwvalid";
            this.mod_txt_passwvalid.Size = new System.Drawing.Size(208, 22);
            this.mod_txt_passwvalid.TabIndex = 7;
            // 
            // mod_txt_pssw
            // 
            this.mod_txt_pssw.Location = new System.Drawing.Point(267, 150);
            this.mod_txt_pssw.Name = "mod_txt_pssw";
            this.mod_txt_pssw.Size = new System.Drawing.Size(208, 22);
            this.mod_txt_pssw.TabIndex = 6;
            // 
            // mod_txt_usrnm
            // 
            this.mod_txt_usrnm.Location = new System.Drawing.Point(267, 101);
            this.mod_txt_usrnm.Name = "mod_txt_usrnm";
            this.mod_txt_usrnm.Size = new System.Drawing.Size(208, 22);
            this.mod_txt_usrnm.TabIndex = 5;
            // 
            // mod_btn_usrCrt
            // 
            this.mod_btn_usrCrt.Location = new System.Drawing.Point(240, 315);
            this.mod_btn_usrCrt.Name = "mod_btn_usrCrt";
            this.mod_btn_usrCrt.Size = new System.Drawing.Size(235, 56);
            this.mod_btn_usrCrt.TabIndex = 4;
            this.mod_btn_usrCrt.Text = "Kullanıcı Oluştur";
            this.mod_btn_usrCrt.UseVisualStyleBackColor = true;
            this.mod_btn_usrCrt.Click += new System.EventHandler(this.mod_btn_usrCrt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yetki Seçiniz: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre Kontrol: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mod_btn_usrSil);
            this.tabPage2.Controls.Add(this.mod_txt_usrSil);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kullanıcı Sil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mod_btn_usrSil
            // 
            this.mod_btn_usrSil.Location = new System.Drawing.Point(231, 211);
            this.mod_btn_usrSil.Name = "mod_btn_usrSil";
            this.mod_btn_usrSil.Size = new System.Drawing.Size(265, 72);
            this.mod_btn_usrSil.TabIndex = 2;
            this.mod_btn_usrSil.Text = "Kullanıcı Sil";
            this.mod_btn_usrSil.UseVisualStyleBackColor = true;
            this.mod_btn_usrSil.Click += new System.EventHandler(this.mod_btn_usrSil_Click);
            // 
            // mod_txt_usrSil
            // 
            this.mod_txt_usrSil.Location = new System.Drawing.Point(287, 133);
            this.mod_txt_usrSil.Name = "mod_txt_usrSil";
            this.mod_txt_usrSil.Size = new System.Drawing.Size(209, 22);
            this.mod_txt_usrSil.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kullanıcı Adı : ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(785, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kullanıcılar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kullanıcıIDDataGridViewTextBoxColumn,
            this.kullanıcıAdıDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullanıcılarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // kullanıcıIDDataGridViewTextBoxColumn
            // 
            this.kullanıcıIDDataGridViewTextBoxColumn.DataPropertyName = "KullanıcıID";
            this.kullanıcıIDDataGridViewTextBoxColumn.HeaderText = "KullanıcıID";
            this.kullanıcıIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullanıcıIDDataGridViewTextBoxColumn.Name = "kullanıcıIDDataGridViewTextBoxColumn";
            this.kullanıcıIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullanıcıAdıDataGridViewTextBoxColumn
            // 
            this.kullanıcıAdıDataGridViewTextBoxColumn.DataPropertyName = "KullanıcıAdı";
            this.kullanıcıAdıDataGridViewTextBoxColumn.HeaderText = "KullanıcıAdı";
            this.kullanıcıAdıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullanıcıAdıDataGridViewTextBoxColumn.Name = "kullanıcıAdıDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // rolDataGridViewTextBoxColumn
            // 
            this.rolDataGridViewTextBoxColumn.DataPropertyName = "Rol";
            this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
            this.rolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
            // 
            // kullanıcılarBindingSource
            // 
            this.kullanıcılarBindingSource.DataMember = "Kullanıcılar";
            this.kullanıcılarBindingSource.DataSource = this.eczaneOtomasyonuDBDataSet;
            // 
            // eczaneOtomasyonuDBDataSet
            // 
            this.eczaneOtomasyonuDBDataSet.DataSetName = "EczaneOtomasyonuDBDataSet";
            this.eczaneOtomasyonuDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mod_btn_main
            // 
            this.mod_btn_main.Location = new System.Drawing.Point(664, -6);
            this.mod_btn_main.Name = "mod_btn_main";
            this.mod_btn_main.Size = new System.Drawing.Size(141, 23);
            this.mod_btn_main.TabIndex = 5;
            this.mod_btn_main.Text = "Ana Menü";
            this.mod_btn_main.UseVisualStyleBackColor = true;
            this.mod_btn_main.Click += new System.EventHandler(this.mod_btn_main_Click);
            // 
            // kullanıcılarTableAdapter
            // 
            this.kullanıcılarTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(785, 398);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reçeteler";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(756, 358);
            this.dataGridView2.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mod_btn_main);
            this.Controls.Add(this.mod_tabc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.mod_tabc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanıcılarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneOtomasyonuDBDataSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mod_tabc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox mod_cb_ecz;
        private System.Windows.Forms.CheckBox mod_cb_dr;
        private System.Windows.Forms.TextBox mod_txt_passwvalid;
        private System.Windows.Forms.TextBox mod_txt_pssw;
        private System.Windows.Forms.TextBox mod_txt_usrnm;
        private System.Windows.Forms.Button mod_btn_usrCrt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button mod_btn_usrSil;
        private System.Windows.Forms.TextBox mod_txt_usrSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mod_btn_login;
        private System.Windows.Forms.TextBox mod_txt_modPswd;
        private System.Windows.Forms.TextBox mod_txt_modUsrN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button mod_btn_main;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EczaneOtomasyonuDBDataSet eczaneOtomasyonuDBDataSet;
        private System.Windows.Forms.BindingSource kullanıcılarBindingSource;
        private EczaneOtomasyonuDBDataSetTableAdapters.KullanıcılarTableAdapter kullanıcılarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanıcıAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}