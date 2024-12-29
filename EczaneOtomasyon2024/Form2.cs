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

namespace EczaneOtomasyon2024
{
    public partial class Form2 : Form
    {
       
        SqlConnection baglanti1 = new SqlConnection("Data Source=DESKTOP-CKQJPFS;Initial Catalog=EczaneOtomasyonuDB;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }
        private void mod_btn_usrCrt_Click(object sender, EventArgs e)
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

                if (mod_txt_pssw.Text == mod_txt_passwvalid.Text)
                {

                    try
                    {
                        baglanti1.Open();
                        SqlCommand kullaniciEkle = new SqlCommand("sp_KullaniciEkle", baglanti1);
                        kullaniciEkle.CommandType = CommandType.StoredProcedure;
                        kullaniciEkle.Parameters.AddWithValue("@KullaniciAdi", mod_txt_usrnm.Text);
                        kullaniciEkle.Parameters.AddWithValue("@Password", mod_txt_pssw.Text);
                        kullaniciEkle.Parameters.AddWithValue("@Rol", yetki);
                        kullaniciEkle.ExecuteNonQuery();

                        MessageBox.Show("Kullanıcı başarıyla eklendi.");
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
            mod_tabc.Appearance = TabAppearance.FlatButtons;
            mod_tabc.ItemSize = new Size(0, 1);
            mod_tabc.SizeMode = TabSizeMode.Fixed;
        }

        private void mod_btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(mod_txt_modUsrN.Text) && !string.IsNullOrEmpty(mod_txt_modPswd.Text))
                {
                    baglanti1.Open();

                    // SqlCommand tanımla
                    SqlCommand kullaniciKontrol = new SqlCommand("up_KullaniciKontrol1", baglanti1);
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

                    // Stored Procedure'ü çalıştır
                    kullaniciKontrol.ExecuteNonQuery();

                    // OUTPUT parametresini al
                    int sonuc = (int)kullaniciKontrol.Parameters["@is_valid"].Value;

                    // Sonucu kontrol et
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

        private void mod_btn_main_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
