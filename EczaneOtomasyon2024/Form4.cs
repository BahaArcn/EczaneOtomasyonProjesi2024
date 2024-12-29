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
                SqlCommand ReceteSorgu3 = new SqlCommand("sp_ReceteBul", baglanti1);
                ReceteSorgu3.CommandType = CommandType.StoredProcedure;
                ReceteSorgu3.Parameters.AddWithValue("@alınanReceteID", ecz_txt_receteAra.Text);
                SqlParameter receteSahibiParam1 = new SqlParameter("@receteSahibi", SqlDbType.NVarChar, 50);
                SqlParameter tcNoParam1 = new SqlParameter("@tcNo", SqlDbType.BigInt);
                receteSahibiParam1.Direction = ParameterDirection.Output;
                tcNoParam1.Direction = ParameterDirection.Output;
                ReceteSorgu3.Parameters.Add(receteSahibiParam1);
                ReceteSorgu3.Parameters.Add(tcNoParam1);
                ReceteSorgu3.ExecuteNonQuery();
                double tcNo1 = Convert.ToDouble(ReceteSorgu3.Parameters["@tcNo"].Value);
                string receteSahibi1 = Convert.ToString(ReceteSorgu3.Parameters["@receteSahibi"].Value);
                SqlDataAdapter adapter3 = new SqlDataAdapter(ReceteSorgu3);
                DataTable dt3 = new DataTable();
                adapter3.Fill(dt3);
                ecz_dgw_receteSorgu.DataSource = dt3;
                ecz_lbl_receteSorgu.Text = receteSahibi1 + " " + tcNo1;
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
            // TODO: This line of code loads data into the 'eczaneOtomasyonuDBDataSet.Hastalar' table. You can move, or remove it, as needed.
            this.hastalarTableAdapter.Fill(this.eczaneOtomasyonuDBDataSet.Hastalar);
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

        private void ecz_btn_hastaAra_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti1.Open();
                SqlCommand hastaAra3 = new SqlCommand("SELECT * FROM Hastalar WHERE TC LIKE @deger4", baglanti1);
                hastaAra3.Parameters.AddWithValue("@deger4", ecz_txt_hastaAra.Text + "%");

                SqlDataAdapter adapter3 = new SqlDataAdapter(hastaAra3);
                DataTable dt3 = new DataTable();
                adapter3.Fill(dt3);
                ecz_dgw_hastaAra.DataSource = dt3;
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
    }
}
