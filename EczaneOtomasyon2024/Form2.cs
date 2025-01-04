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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace EczaneOtomasyon2024
{
    public partial class Form2 : Form
    {
       
        SqlConnection baglanti1 = new SqlConnection("Data Source=DESKTOP-CKQJPFS;Initial Catalog=EczaneOtomasyonuDB;Integrated Security=True"); //Veritabanı bağlantısı oluştur
        public Form2()
        {
            InitializeComponent();
        }
        private void mod_btn_usrCrt_Click(object sender, EventArgs e)  //Kullanıcı oluşturma
        {

            string yetki = ""; 

            // Kullanıcı bilgisi kontrolü
            if (!string.IsNullOrEmpty(mod_txt_usrnm.Text) &&
            !string.IsNullOrEmpty(mod_txt_pssw.Text) &&
                !string.IsNullOrEmpty(mod_txt_passwvalid.Text))
            {
                if (mod_cb_dr.Checked && mod_cb_ecz.Checked)
                {
                    MessageBox.Show("Lütfen sadece bir yetki seçiniz!");
                    return;
                }
                else if (mod_cb_dr.Checked)
                {
                    yetki = "Doktor";
                }
                else if (mod_cb_ecz.Checked)
                {
                    yetki = "Eczacı";
                }
                else
                {
                    MessageBox.Show("Lütfen bir yetki seçiniz!");
                    return;
                }

                if (mod_txt_pssw.Text == mod_txt_passwvalid.Text) //Şifre kontrolü
                {

                    try
                    {
                        baglanti1.Open();
                        SqlCommand kullaniciEkle = new SqlCommand("sp_KullaniciEkle", baglanti1); //Kullanıcı ekleyen stored procedureu çağır
                        kullaniciEkle.CommandType = CommandType.StoredProcedure;
                        kullaniciEkle.Parameters.AddWithValue("@KullaniciAdi", mod_txt_usrnm.Text);
                        kullaniciEkle.Parameters.AddWithValue("@Password", mod_txt_pssw.Text);
                        kullaniciEkle.Parameters.AddWithValue("@Rol", yetki);
                        kullaniciEkle.ExecuteNonQuery();

                        MessageBox.Show("Kullanıcı başarıyla eklendi.");
                        mod_txt_pssw.Clear();
                        mod_txt_usrnm.Clear();
                        mod_txt_passwvalid.Clear();
                        mod_cb_dr.Checked = false;
                        mod_cb_ecz.Checked = false;
                        this.kullanıcılarTableAdapter.Fill(this.eczaneOtomasyonuDBDataSet.Kullanıcılar);
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
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mod_tabc.Appearance = TabAppearance.FlatButtons; // Giriş yapılana kadar sekmeleri gizle
            mod_tabc.ItemSize = new Size(0, 1);
            mod_tabc.SizeMode = TabSizeMode.Fixed;
            this.kullanıcılarTableAdapter.Fill(this.eczaneOtomasyonuDBDataSet.Kullanıcılar);
        }

        private void mod_btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(mod_txt_modUsrN.Text) && !string.IsNullOrEmpty(mod_txt_modPswd.Text))
                {
                    baglanti1.Open();

                    SqlCommand kullaniciKontrol = new SqlCommand("up_KullaniciKontrol1", baglanti1); //Kullanıcı doğrulama stored procedure çağrısı
                    kullaniciKontrol.CommandType = CommandType.StoredProcedure;

                    // Parametreleri ekle
                    kullaniciKontrol.Parameters.AddWithValue("@girilen_kullaniciAdi", mod_txt_modUsrN.Text);
                    kullaniciKontrol.Parameters.AddWithValue("@girilen_sifre", mod_txt_modPswd.Text);
                    kullaniciKontrol.Parameters.AddWithValue("@girilen_rol", "Admin");

                    // OUTPUT parametresini ekle
                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@is_valid",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    kullaniciKontrol.Parameters.Add(outputParam);

                    kullaniciKontrol.ExecuteNonQuery();

                    int sonuc = (int)kullaniciKontrol.Parameters["@is_valid"].Value;


                    if (sonuc == 1)
                    {
                        MessageBox.Show("Kullanıcı doğrulandı!");
                        mod_tabc.Appearance = TabAppearance.Normal;
                        mod_tabc.ItemSize = new Size(80, 20); // Varsayılan sekme boyutları
                        mod_tabc.SizeMode = TabSizeMode.Normal;
                        panel1.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                    }

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!");
                }
                SqlDataAdapter dataAdapter6 = new SqlDataAdapter("SELECT * FROM doktorlarınReceteleri",baglanti1); //Doktor reçetelerini gösteren viewi getir
                DataTable dataTable6 = new DataTable();
                dataAdapter6.Fill(dataTable6);
                dataGridView2.DataSource = dataTable6;
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

        private void mod_btn_main_Click(object sender, EventArgs e) //Ana menüye dön
        {

            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void mod_btn_usrSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti1.Open();
                SqlCommand kullaniciSil = new SqlCommand("DELETE FROM Kullanıcılar WHERE KullanıcıAdı=@deger8", baglanti1); //Kullanıcı silen stored procedure çağrısı
                kullaniciSil.Parameters.AddWithValue("@deger8", mod_txt_usrSil.Text);
                kullaniciSil.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarıyla silindi.");
                mod_txt_usrSil.Clear();
            }
            catch(Exception ex)
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
