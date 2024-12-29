using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EczaneOtomasyon2024
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        object sonuc;
        string adi;
        System.DateTime tarih;
        private double tcDegeri;
        SqlConnection baglanti1 = new SqlConnection("Data Source=DESKTOP-CKQJPFS;Initial Catalog=EczaneOtomasyonuDB;Integrated Security=True");
        private void GeciciIlacRefresh()
        {
            string query = @"
            SELECT 
                G.IlacID AS GeciciIlacID,
                L.UrunAdi,
                L.EtkinMadde,
                L.KullanimYasi
            FROM 
                GeciciIlac G
            INNER JOIN 
                Ilaclar L ON G.IlacID = L.Id";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti1);
            DataTable dataTable = new DataTable();



            dataAdapter.Fill(dataTable);
            dr_dgw_yazılanIlac.DataSource = dataTable;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dr_lbl_mesaj.Visible = false;
            dr_dgw_receteSorgu.DataSource = null;
            this.ilaclarTableAdapter.Fill(this.eczaneOtomasyonuDBDataSet.Ilaclar);
            this.hastalarTableAdapter.Fill(this.eczaneOtomasyonuDBDataSet.Hastalar);

            dr_tabC.Appearance = TabAppearance.FlatButtons;
            dr_tabC.ItemSize = new Size(0, 1);
            dr_tabC.SizeMode = TabSizeMode.Fixed;

            this.WindowState = FormWindowState.Maximized; // Formu tam ekran yap
            this.FormBorderStyle = FormBorderStyle.None;  // Kenarlıkları kaldır
            this.TopMost = true;                          // Her zaman en üstte olsun

            dr_dgw_hastalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dr_dgw_ilaclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn ekleButton = new DataGridViewButtonColumn();
            ekleButton.Name = "Ekle";
            ekleButton.HeaderText = "İlaç Ekle";
            ekleButton.Text = "EKLE";
            ekleButton.UseColumnTextForButtonValue = true;
            dr_dgw_ilaclar.Columns.Add(ekleButton);
            dr_dgw_ilaclar.Columns["Ekle"].DisplayIndex = 0;

        }

        private void dr_btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dr_btn_anaMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 Form1 = new Form1();
            Form1.Show();
        }

        private void dr_dgw_hastalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                baglanti1.Open();

                SqlCommand komut = new SqlCommand("DELETE FROM GeciciIlac", baglanti1);
                adi = Convert.ToString(dr_dgw_hastalar.Rows[e.RowIndex].Cells["Ad"].Value) + " " + Convert.ToString(dr_dgw_hastalar.Rows[e.RowIndex].Cells["Soyad"].Value);
                tcDegeri = Convert.ToDouble(dr_dgw_hastalar.Rows[e.RowIndex].Cells["TC"].Value);
                tarih = Convert.ToDateTime(dr_dgw_hastalar.Rows[e.RowIndex].Cells["DogumTarihi"].Value);
                SqlCommand yasKontrol = new SqlCommand("SELECT dbo.YasHesapla(@gun) AS Yas", baglanti1);
                yasKontrol.Parameters.AddWithValue("@gun", tarih);
                sonuc = yasKontrol.ExecuteScalar();
                dr_lbl_ilacYazHasta.Text = dr_dgw_hastalar.Rows[e.RowIndex].Cells["TC"].Value + " " + adi + " " + sonuc + " yaşında.";
                komut.ExecuteNonQuery();
                GeciciIlacRefresh();
                

                MessageBox.Show("Hasta Seçildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti1.Close();
            }
        }

        private void dr_dgw_ilaclar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                baglanti1.Open();
                if ((int)sonuc >= Convert.ToInt16(dr_dgw_ilaclar.Rows[e.RowIndex].Cells["KullanimYasi"].Value))
                {            
                    if(e.ColumnIndex == dr_dgw_ilaclar.Columns["Ekle"].Index && e.RowIndex >= 0)
                    {
                        // İlgili satırdaki veriyi alabilirsiniz
                        int secilenSatirVerisi = Convert.ToInt16(dr_dgw_ilaclar.Rows[e.RowIndex].Cells["Id"].Value);
                        MessageBox.Show("Eklenen İlaç ID: " + Convert.ToString(secilenSatirVerisi));
                        SqlCommand komut = new SqlCommand("INSERT INTO GeciciIlac (IlacID) VALUES (@IlacID)", baglanti1);
                        komut.Parameters.AddWithValue("@IlacID", secilenSatirVerisi);
                        komut.ExecuteNonQuery();
                        GeciciIlacRefresh();
                    }
                }
                else
                {
                    MessageBox.Show("Hasta bu ilacı kullanabilecek yaşta değil.");
                }
            }



            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti1.Close();
            } 
        }
        


        private void dr_btn_profilGiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti1.Open();
                SqlCommand DoktorKontrol = new SqlCommand("up_KullaniciKontrol1", baglanti1);
                DoktorKontrol.CommandType = CommandType.StoredProcedure;
                DoktorKontrol.Parameters.AddWithValue("@girilen_kullaniciAdi", dr_txt_usrName.Text);
                DoktorKontrol.Parameters.AddWithValue("@girilen_sifre", dr_txt_passwd.Text);
                DoktorKontrol.Parameters.AddWithValue("@girilen_rol", "Doktor");
                SqlParameter dogrulamaParam = new SqlParameter()
                {
                    ParameterName = "@is_valid",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                DoktorKontrol.Parameters.Add(dogrulamaParam);
                DoktorKontrol.ExecuteNonQuery();
                int kontrol = (int)DoktorKontrol.Parameters["@is_valid"].Value;
                if (kontrol == 1)
                {
                    MessageBox.Show("Doktor doğrulandı!");
                    dr_lbl_mesaj.Visible = true;
                    dr_lbl_mesaj.Text = "Hoşgeldiniz Sayın " + dr_txt_usrName.Text;
                    dr_tabC.Appearance = TabAppearance.Normal;
                    dr_tabC.ItemSize = new Size(80, 20); // Varsayılan sekme boyutları
                    dr_tabC.SizeMode = TabSizeMode.Normal;
                    panel1.Hide();
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

        private void dr_dgw_yazılanIlac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                baglanti1.Open();


                // İlgili satırdaki ID'yi al
                int secilenSatirVerisi = Convert.ToInt32(dr_dgw_yazılanIlac.Rows[e.RowIndex].Cells["GeciciIlacId"].Value);

                SqlCommand komut = new SqlCommand("DELETE FROM GeciciIlac WHERE IlacID=@Id", baglanti1);
                komut.Parameters.AddWithValue("@Id", secilenSatirVerisi);
                komut.ExecuteNonQuery();
                GeciciIlacRefresh();
                MessageBox.Show("İlaç başarıyla silindi.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti1.Close();
            }

        }

        private void dr_btn_receteYazdır_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti1.Open();

                SqlCommand ReceteEkle = new SqlCommand("sp_ReceteEkle", baglanti1);
                ReceteEkle.CommandType = CommandType.StoredProcedure;

                // Giriş parametreleri
                ReceteEkle.Parameters.AddWithValue("@KullaniciAdi", dr_txt_usrName.Text); // Kullanıcı adı TextBox'tan alınır
                ReceteEkle.Parameters.AddWithValue("@HastaTC", tcDegeri.ToString()); // Hasta TC değeri

                // Çıkış parametresi
                SqlParameter yeniReceteIDParam = new SqlParameter("@YeniReceteID", SqlDbType.Int);
                yeniReceteIDParam.Direction = ParameterDirection.Output;
                ReceteEkle.Parameters.Add(yeniReceteIDParam);
                // Stored Procedure çalıştır
                ReceteEkle.ExecuteNonQuery();
                // Çıkış parametresinin değerini al
                int yeniReceteID = (int)yeniReceteIDParam.Value;
                MessageBox.Show("Reçete başarıyla eklendi. Reçete ID: " + yeniReceteID);
                for (int i = 0; i < dr_dgw_yazılanIlac.RowCount; i++)
                {
                    if (Convert.ToInt16(dr_dgw_yazılanIlac.Rows[i].Cells["GeciciIlacID"].Value) == 0) { continue; }
                    SqlCommand ReceteIlacEkle = new SqlCommand("INSERT INTO ReceteIcerik VALUES(@ReceteID,@IlacID)", baglanti1);
                    ReceteIlacEkle.Parameters.AddWithValue("@ReceteID", yeniReceteID);
                    ReceteIlacEkle.Parameters.AddWithValue("@IlacID", Convert.ToInt16(dr_dgw_yazılanIlac.Rows[i].Cells["GeciciIlacID"].Value));
                    ReceteIlacEkle.ExecuteNonQuery();
                    dr_lbl_receteNo.Text = "Reçete No: " + yeniReceteID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!: " + ex.Message);
            }
            finally
            {
                baglanti1.Close();
            }
        }

        private void dr_btn_ilaçAra_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti1.Open();
                SqlCommand IlacAra = new SqlCommand("SELECT Id,Barkod,UrunAdi,EtkinMadde,ATCKodu,RuhsatSahibi,RuhsatTarihi,RuhsatNumarasi,KullanimYasi FROM Ilaclar WHERE UrunAdi LIKE @deger2", baglanti1);
                IlacAra.Parameters.AddWithValue("@deger2", "%" + dr_txt_ilacAra.Text + "%");

                SqlDataAdapter adapter1 = new SqlDataAdapter(IlacAra);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                dr_dgw_ilaclar.DataSource = dt1;
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

        private void dr_btn_hastaAra_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti1.Open();
                SqlCommand hastaAra = new SqlCommand("SELECT * FROM Hastalar WHERE TC LIKE @deger2", baglanti1);
                hastaAra.Parameters.AddWithValue("@deger2", dr_txt_hastaAra.Text + "%");

                SqlDataAdapter adapter1 = new SqlDataAdapter(hastaAra);
                DataTable dt1 = new DataTable();
                adapter1.Fill(dt1);
                dr_dgw_hastalar.DataSource = dt1;
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

        private void dr_btn_receteSorgu_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti1.Open();
                SqlCommand ReceteSorgu2 = new SqlCommand("sp_ReceteBul", baglanti1);
                ReceteSorgu2.CommandType = CommandType.StoredProcedure;
                ReceteSorgu2.Parameters.AddWithValue("@alınanReceteID", dr_txt_receteSorgu.Text);
                SqlDataAdapter adapter2 = new SqlDataAdapter(ReceteSorgu2);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                dr_dgw_receteSorgu.DataSource = dt2;
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
