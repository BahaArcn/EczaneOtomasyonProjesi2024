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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ecz_btn_anaMenü = new System.Windows.Forms.Button();
            this.ecz_btn_cikis = new System.Windows.Forms.Button();
            this.ecz_txt_receteAra = new System.Windows.Forms.TextBox();
            this.ecz_lbl_receteSorgu = new System.Windows.Forms.Label();
            this.ecz_btn_receteAra = new System.Windows.Forms.Button();
            this.ecz_dgw_receteSorgu = new System.Windows.Forms.DataGridView();
            this.ecz_txt_hastaAra = new System.Windows.Forms.TextBox();
            this.ecz_btn_hastaAra = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecz_dgw_receteSorgu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridView1);
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
            // ecz_txt_receteAra
            // 
            this.ecz_txt_receteAra.Location = new System.Drawing.Point(191, 48);
            this.ecz_txt_receteAra.Name = "ecz_txt_receteAra";
            this.ecz_txt_receteAra.Size = new System.Drawing.Size(173, 22);
            this.ecz_txt_receteAra.TabIndex = 0;
            // 
            // ecz_lbl_receteSorgu
            // 
            this.ecz_lbl_receteSorgu.AutoSize = true;
            this.ecz_lbl_receteSorgu.Location = new System.Drawing.Point(481, 49);
            this.ecz_lbl_receteSorgu.Name = "ecz_lbl_receteSorgu";
            this.ecz_lbl_receteSorgu.Size = new System.Drawing.Size(16, 16);
            this.ecz_lbl_receteSorgu.TabIndex = 1;
            this.ecz_lbl_receteSorgu.Text = "...";
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
            // ecz_txt_hastaAra
            // 
            this.ecz_txt_hastaAra.Location = new System.Drawing.Point(180, 48);
            this.ecz_txt_hastaAra.Name = "ecz_txt_hastaAra";
            this.ecz_txt_hastaAra.Size = new System.Drawing.Size(170, 22);
            this.ecz_txt_hastaAra.TabIndex = 0;
            // 
            // ecz_btn_hastaAra
            // 
            this.ecz_btn_hastaAra.Location = new System.Drawing.Point(377, 46);
            this.ecz_btn_hastaAra.Name = "ecz_btn_hastaAra";
            this.ecz_btn_hastaAra.Size = new System.Drawing.Size(69, 24);
            this.ecz_btn_hastaAra.TabIndex = 1;
            this.ecz_btn_hastaAra.Text = "ARA";
            this.ecz_btn_hastaAra.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1878, 840);
            this.dataGridView1.TabIndex = 2;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecz_dgw_receteSorgu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ecz_btn_hastaAra;
        private System.Windows.Forms.TextBox ecz_txt_hastaAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}