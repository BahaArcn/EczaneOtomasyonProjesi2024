using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon2024
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti1 = new SqlConnection("Data Source=DESKTOP-CKQJPFS;Initial Catalog=EczaneOtomasyonuDB;Integrated Security=True");
        private void ecz_btn_receteAra_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti1.Open();
                SqlCommand ReceteSorgu1 = new SqlCommand("sp_ReceteBul", baglanti1);
                ReceteSorgu1.CommandType = CommandType.StoredProcedure;
                ReceteSorgu1.Parameters.AddWithValue("@alınanReceteID", ecz_txt_receteAra.Text);
                SqlDataAdapter adapter2 = new SqlDataAdapter(ReceteSorgu1);
                DataTable dt3 = new DataTable();
                adapter2.Fill(dt3);
                ecz_dgw_receteSorgu.DataSource = dt3;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA! : " + ex.Message);
            }
            finally
            {
                baglanti1.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Formu tam ekran yap
            this.FormBorderStyle = FormBorderStyle.None;  // Kenarlıkları kaldır
            this.TopMost = true;                          // Her zaman en üstte olsun

        }

        private void ecz_btn_anaMenü_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void ecz_btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
