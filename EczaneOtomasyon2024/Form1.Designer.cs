namespace EczaneOtomasyon2024
{
    partial class Form1
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
            this.mod_btn_giris = new System.Windows.Forms.Button();
            this.dr_btn_giris = new System.Windows.Forms.Button();
            this.ecz_btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mod_btn_giris
            // 
            this.mod_btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mod_btn_giris.Location = new System.Drawing.Point(1178, 666);
            this.mod_btn_giris.Name = "mod_btn_giris";
            this.mod_btn_giris.Size = new System.Drawing.Size(210, 38);
            this.mod_btn_giris.TabIndex = 2;
            this.mod_btn_giris.Text = "Yönetici Girişi";
            this.mod_btn_giris.UseVisualStyleBackColor = true;
            this.mod_btn_giris.Click += new System.EventHandler(this.mod_btn_giris_Click);
            // 
            // dr_btn_giris
            // 
            this.dr_btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dr_btn_giris.Image = global::EczaneOtomasyon2024.Properties.Resources.doktor;
            this.dr_btn_giris.Location = new System.Drawing.Point(138, 89);
            this.dr_btn_giris.Name = "dr_btn_giris";
            this.dr_btn_giris.Size = new System.Drawing.Size(450, 528);
            this.dr_btn_giris.TabIndex = 1;
            this.dr_btn_giris.Text = "DOKTOR GİRİŞİ";
            this.dr_btn_giris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dr_btn_giris.UseVisualStyleBackColor = true;
            this.dr_btn_giris.Click += new System.EventHandler(this.dr_btn_giris_Click);
            // 
            // ecz_btn_giris
            // 
            this.ecz_btn_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ecz_btn_giris.Image = global::EczaneOtomasyon2024.Properties.Resources.Eczacı_png;
            this.ecz_btn_giris.Location = new System.Drawing.Point(809, 89);
            this.ecz_btn_giris.Name = "ecz_btn_giris";
            this.ecz_btn_giris.Size = new System.Drawing.Size(450, 528);
            this.ecz_btn_giris.TabIndex = 0;
            this.ecz_btn_giris.Text = "ECZANE GİRİŞİ";
            this.ecz_btn_giris.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ecz_btn_giris.UseVisualStyleBackColor = true;
            this.ecz_btn_giris.Click += new System.EventHandler(this.ecz_btn_giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 716);
            this.Controls.Add(this.mod_btn_giris);
            this.Controls.Add(this.dr_btn_giris);
            this.Controls.Add(this.ecz_btn_giris);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_anaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ecz_btn_giris;
        private System.Windows.Forms.Button dr_btn_giris;
        private System.Windows.Forms.Button mod_btn_giris;
    }
}

