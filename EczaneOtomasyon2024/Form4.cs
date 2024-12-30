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
                SqlCommand sigortaTuru = new SqlCommand("SELECT Sigorta FROM Hastalar WHERE TC=@deger7 ", baglanti1);
                sigortaTuru.Parameters.AddWithValue("@deger7",tcNo1);
                object result2 = sigortaTuru.ExecuteScalar(); // İlk sonucu al
                string sigorta = result2?.ToString() ?? "Sonuç bulunamadı";
                ecz_lbl_sigortaTuru.Text = sigorta;

                SqlCommand satildiMi = new SqlCommand("SELECT Satildi FROM Receteler WHERE ReceteID=@deger8", baglanti1);
                satildiMi.Parameters.AddWithValue("@deger8", ecz_txt_receteAra.Text);
                object result3 = satildiMi.ExecuteScalar();
                string satildi = result3.ToString();
                if(satildi=="Satilmadi")
                {
                    ecz_btn_satisYap.Enabled = true;
                    ecz_btn_satisYap.Text = "Satış Yap";
                }
                else
                {
                    ecz_btn_satisYap.Enabled = false;
                    ecz_btn_satisYap.Text = "Bu reçete zaten satılmış";
                }

                SqlCommand toplamFiyat = new SqlCommand("SELECT dbo.ReceteToplamFiyat(@ReceteID) AS ToplamFiyat", baglanti1);
                toplamFiyat.Parameters.Add(new SqlParameter("@ReceteID", SqlDbType.Int)
                {
                    Value = Convert.ToInt16(ecz_txt_receteAra.Text)
                });

                object result = toplamFiyat.ExecuteScalar();
                ecz_lbl_toplamFiyat.Text = result.ToString() + "  TL";
                if (sigorta == "SGK")
                {
                    ecz_lbl.Text = Convert.ToString(Convert.ToInt16(result) * 0.20);
                    ecz_lbl_odenecekFiyat.Text = Convert.ToString(Convert.ToInt16(result) * 0.80);
                }
                else if (sigorta == "BAĞKUR")
                {
                    ecz_lbl.Text = ""+Convert.ToString(Convert.ToInt16(result) * 0.10);
                    ecz_lbl_odenecekFiyat.Text = Convert.ToString(Convert.ToInt16(result) * 0.90);
                }
                else
                {
                    ecz_lbl.Text = "0";
                    ecz_lbl_odenecekFiyat.Text = Convert.ToString(result);
                }
                
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
            this.ilaclarTableAdapter.Fill(this.eczaneOtomasyonuDBDataSet.Ilaclar);
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
                hastaAra3.ExecuteNonQuery();
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

        private void ecz_btn_ilacAra_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti1.Open();
                SqlCommand IlacAra1 = new SqlCommand("SELECT Id,Barkod,UrunAdi,EtkinMadde,ATCKodu,RuhsatSahibi,RuhsatTarihi,RuhsatNumarasi,KullanimYasi FROM Ilaclar WHERE UrunAdi LIKE @deger2", baglanti1);
                IlacAra1.Parameters.AddWithValue("@deger2", "%" + ecz_txt_ilacAra.Text + "%");

                SqlDataAdapter adapter5 = new SqlDataAdapter(IlacAra1);
                DataTable dt5 = new DataTable();
                adapter5.Fill(dt5);
                ecz_dgw_ilaclar.DataSource = dt5;
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

        private void ecz_btn_satisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti1.Open();
                SqlCommand satisYap = new SqlCommand("UPDATE Receteler SET Satildi = 'Satildi' WHERE ReceteID=@deger8",baglanti1);
                satisYap.Parameters.AddWithValue("@deger8", ecz_txt_receteAra.Text);
                ecz_btn_satisYap.Enabled = false;
                ecz_btn_satisYap.Text = "Bu reçete zaten satılmış";
                satisYap.ExecuteNonQuery();
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
