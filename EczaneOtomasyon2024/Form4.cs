using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
        SqlConnection baglanti1 = new SqlConnection("Data Source=DESKTOP-CKQJPFS;Initial Catalog=EczaneOtomasyonuDB;Integrated Security=True"); //Veritabanı bağlantısı oluştur
        private void ecz_btn_receteAra_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti1.Open();
                SqlCommand tarihKontrol = new SqlCommand("sp_ReceteTarihGetir", baglanti1);    //Reçetenin tarihinin getiren stored procedure
                tarihKontrol.CommandType = CommandType.StoredProcedure;
                tarihKontrol.Parameters.AddWithValue("@ReceteID", Convert.ToInt16(ecz_txt_receteAra.Text));
                SqlParameter dogrulamaParam8 = new SqlParameter()
                {
                    ParameterName = "@Tarih",
                    SqlDbType = SqlDbType.Date,                //Çıkış parametrelerini al
                    Direction = ParameterDirection.Output
                };
                tarihKontrol.Parameters.Add(dogrulamaParam8);
                tarihKontrol.ExecuteNonQuery();
                SqlDateTime kontrol8 = (DateTime)tarihKontrol.Parameters["@Tarih"].Value;
                SqlCommand tarihGectiMi = new SqlCommand("SELECT dbo.TarihKontrol(@deger10)", baglanti1);  //Alınan tarihin geçip geçmediğini kontrol eden fonksiyon
                tarihGectiMi.Parameters.AddWithValue("deger10",kontrol8);
                object result8 = tarihGectiMi.ExecuteScalar();
                if (Convert.ToInt16(result8) == 1)
                {
                    MessageBox.Show("Reçete süresi geçmiş!");
                    return;
                }
                SqlCommand ReceteSorgu3 = new SqlCommand("sp_ReceteBul", baglanti1);   //Reçete bilgilerini getiren stored procedure çağrısı
                ReceteSorgu3.CommandType = CommandType.StoredProcedure;
                ReceteSorgu3.Parameters.AddWithValue("@alınanReceteID",ecz_txt_receteAra.Text);
                SqlParameter receteSahibiParam1 = new SqlParameter("@receteSahibi", SqlDbType.NVarChar, 50);
                SqlParameter tcNoParam1 = new SqlParameter("@tcNo", SqlDbType.BigInt);
                receteSahibiParam1.Direction = ParameterDirection.Output;
                tcNoParam1.Direction = ParameterDirection.Output;
                ReceteSorgu3.Parameters.Add(receteSahibiParam1);                //Çıkış parametrelerini al  
                ReceteSorgu3.Parameters.Add(tcNoParam1);
                ReceteSorgu3.ExecuteNonQuery();
                double tcNo1 = Convert.ToDouble(ReceteSorgu3.Parameters["@tcNo"].Value);
                string receteSahibi1 = Convert.ToString(ReceteSorgu3.Parameters["@receteSahibi"].Value);
                SqlDataAdapter adapter3 = new SqlDataAdapter(ReceteSorgu3);
                DataTable dt3 = new DataTable();
                adapter3.Fill(dt3);
                ecz_dgw_receteSorgu.DataSource = dt3;
                ecz_lbl_receteSorgu.Text = receteSahibi1 + " " + tcNo1;
                SqlCommand sigortaTuru = new SqlCommand("SELECT Sigorta FROM Hastalar WHERE TC=@deger7 ", baglanti1);  //Reçete sahibi hastanın sigorta türünü getiren SQL komutu
                sigortaTuru.Parameters.AddWithValue("@deger7", tcNo1);
                object result2 = sigortaTuru.ExecuteScalar(); // İlk sonucu al
                string sigorta = result2?.ToString() ?? "Sonuç bulunamadı";
                ecz_lbl_sigortaTuru.Text = sigorta;

                SqlCommand satildiMi = new SqlCommand("SELECT Satildi FROM Receteler WHERE ReceteID=@deger8", baglanti1);  //Reçetenin satılıp satılmadığını kontrol eden SQL komutu
                satildiMi.Parameters.AddWithValue("@deger8", ecz_txt_receteAra.Text);
                object result3 = satildiMi.ExecuteScalar();
                string satildi = result3.ToString();
                if (satildi == "Satilmadi")
                {
                    ecz_btn_satisYap.Enabled = true;
                    ecz_btn_satisYap.Text = "Satış Yap";
                }
                else
                {
                    ecz_btn_satisYap.Enabled = false;
                    ecz_btn_satisYap.Text = "Bu reçete zaten satılmış";
                }

                SqlCommand toplamFiyat = new SqlCommand("SELECT dbo.ReceteToplamFiyat(@ReceteID) AS ToplamFiyat", baglanti1);  //Reçetenin toplam fiyatını getiren fonksiyon
                toplamFiyat.Parameters.Add(new SqlParameter("@ReceteID", SqlDbType.Int)
                {
                    Value = Convert.ToInt16(ecz_txt_receteAra.Text)
                });

                object result = toplamFiyat.ExecuteScalar();
                ecz_lbl_toplamFiyat.Text = result.ToString() + "  TL";
                if (sigorta == "SGK")                                  //Sigorta türüne göre ödenecek miktarı hesaplayan if-else yapısı                                        
                {
                    ecz_lbl.Text = Convert.ToString(Convert.ToInt16(result) * 0.20);
                    ecz_lbl_odenecekFiyat.Text = Convert.ToString(Convert.ToInt16(result) * 0.80);
                }
                else if (sigorta == "BAĞKUR")
                {
                    ecz_lbl.Text = "" + Convert.ToString(Convert.ToInt16(result) * 0.10);
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

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            this.ilaclarTableAdapter.Fill(this.eczaneOtomasyonuDBDataSet.Ilaclar);
            this.WindowState = FormWindowState.Maximized; // Formu tam ekran yap
            this.FormBorderStyle = FormBorderStyle.None;  // Kenarlıkları kaldır
            this.TopMost = true;                          // Her zaman en üstte olsun

            dataGridView1.Rows.Add("1", "23167196", "Maske", "5");
            dataGridView1.Rows.Add("2", "84913826", "Eldiven", "10");
            dataGridView1.Rows.Add("3", "12460295", "Korse", "20");            //Diğer ürünlerin bilgileri
            dataGridView1.Rows.Add("4", "59316486", "Bone", "5");
            dataGridView1.Rows.Add("5", "90285124", "Baskül", "100");
            dataGridView1.Rows.Add("6", "65731526", "Bez", "50");
            dataGridView1.Rows.Add("7", "49204958", "Pudra", "10");

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
                SqlCommand hastaAra3 = new SqlCommand("SELECT * FROM Hastalar WHERE TC LIKE @deger4", baglanti1);     //TC numarasına göre hastayı getiren SQL komutu
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
                IlacAra1.Parameters.AddWithValue("@deger2", "%" + ecz_txt_ilacAra.Text + "%"); //İlaç adına göre ilaçların istenen sütunlarını getiren SQL komutu

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

                bool stokSorunuVar = false; // Stok kontrolü sonucu için bir bayrak
                string hataMesaji = "Stokta olmayan ilaçlar:\n";

                baglanti1.Open();
                foreach (DataGridViewRow row in ecz_dgw_receteSorgu.Rows)   //Her satır için işlemi uygula
                {
                    if (row.Cells["Id"].Value != null) // IlacID kontrolü
                    {
                        int ilacID = Convert.ToInt32(row.Cells["Id"].Value);

                        // Stok kontrolü için SQL komutu
                        string stokKontrolQuery = "SELECT [Stok Adedi] FROM Ilaclar WHERE Id = @IlacID";  //İstenen ilacın stok adedini getiren SQL komutu
                        using (SqlCommand stokKontrolCmd = new SqlCommand(stokKontrolQuery, baglanti1))
                        {
                            stokKontrolCmd.Parameters.AddWithValue("@IlacID", ilacID);
                            int stok = Convert.ToInt32(stokKontrolCmd.ExecuteScalar());

                            if (stok <= 0)
                            {
                                if (ilacID == 0)
                                {
                                    continue;
                                }
                                else
                                {
                                    stokSorunuVar = true;
                                    hataMesaji += $"- İlaç ID: {ilacID}\n";
                                }
                            }
                            else
                            {
                                // Stok güncelleme komutu
                                string stokGuncelleQuery = "UPDATE Ilaclar SET [Stok Adedi] = [Stok Adedi] - 1 WHERE Id = @IlacID";
                                using (SqlCommand stokGuncelleCmd = new SqlCommand(stokGuncelleQuery, baglanti1))
                                {
                                    stokGuncelleCmd.Parameters.AddWithValue("@IlacID", ilacID);
                                    stokGuncelleCmd.ExecuteNonQuery();
                                    SqlCommand satisYap = new SqlCommand("UPDATE Receteler SET Satildi = 'Satildi' WHERE ReceteID=@deger8", baglanti1); //Reçetenin satıldı bilgisini güncelleyen SQL komutu
                                    satisYap.Parameters.AddWithValue("@deger8", ecz_txt_receteAra.Text);
                                    ecz_btn_satisYap.Enabled = false;
                                    ecz_btn_satisYap.Text = "Bu reçete zaten satılmış";
                                    satisYap.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                if (stokSorunuVar)
                {
                    MessageBox.Show(hataMesaji, "Stok Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Satış başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int toplam = 0;        //Seçilen ürünleri sepete aktarır
                ecz_dgw_sepet.Rows.Add(dataGridView1.Rows[e.RowIndex].Cells[0].Value, dataGridView1.Rows[e.RowIndex].Cells[1].Value, dataGridView1.Rows[e.RowIndex].Cells[2].Value, dataGridView1.Rows[e.RowIndex].Cells[3].Value);

                foreach (DataGridViewRow row in ecz_dgw_sepet.Rows)
                {
                    toplam += Convert.ToInt32(row.Cells["Fiyat1"].Value);  //Sepetteki ürünlerin fiyatlarını toplar
                }
                ecz_lbl_sepetFiyat.Text = toplam.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA! : " + ex.Message);
            }
        }

        private void ecz_btn_sepetSatis_Click(object sender, EventArgs e)
        {
           
            try
            {
                MessageBox.Show("Satış başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ecz_dgw_sepet.Rows.Clear();
                ecz_lbl_sepetFiyat.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA! : " + ex.Message);
            }
            }

        private void ecz_btn_girisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti1.Open();
                SqlCommand eczaciKontrol = new SqlCommand("up_KullaniciKontrol1", baglanti1);  //Giriş yapılacak kullanıcının doğruluğunu kontrol eden stored procedure
                eczaciKontrol.CommandType = CommandType.StoredProcedure;
                eczaciKontrol.Parameters.AddWithValue("@girilen_kullaniciAdi", ecz_txt_usrName.Text);
                eczaciKontrol.Parameters.AddWithValue("@girilen_sifre", ecz_txt_usrName.Text);
                eczaciKontrol.Parameters.AddWithValue("@girilen_rol", "Eczacı");
                SqlParameter dogrulamaParam = new SqlParameter()
                {
                    ParameterName = "@is_valid",   //Çıkış parametrelerini al
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                eczaciKontrol.Parameters.Add(dogrulamaParam);
                eczaciKontrol.ExecuteNonQuery();
                int kontrol = (int)eczaciKontrol.Parameters["@is_valid"].Value;
                if (kontrol == 1)
                {
                    MessageBox.Show("Eczacı doğrulandı!");
                    tabControl1.Appearance = TabAppearance.Normal;
                    tabControl1.ItemSize = new Size(80, 20); // Varsayılan sekme boyutları
                    tabControl1.SizeMode = TabSizeMode.Normal;
                    ecz_pnl.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");

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
    }
}
