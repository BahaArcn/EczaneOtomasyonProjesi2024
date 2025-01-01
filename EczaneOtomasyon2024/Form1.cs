using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 Form2 = new Form2();
        Form3 Form3 = new Form3();
        Form4 Form4 = new Form4();
        private void mod_btn_giris_Click(object sender, EventArgs e)
        {
            Form2.Show();
            this.Hide();
        }

        private void dr_btn_giris_Click(object sender, EventArgs e)
        {
            Form3.Show();
            this.Hide();
        }

        private void ecz_btn_giris_Click(object sender, EventArgs e)
        {
            Form4.Show();
            this.Hide();
        }
    }
}
