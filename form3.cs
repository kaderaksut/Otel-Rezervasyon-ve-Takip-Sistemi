using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace otel_rezwrvasyon_projesi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string sifre = textBox3.Text;
            string zaman = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            if (ad == "Kader" && soyad == "Aksüt" && sifre == "12345")
            {
                listBox1.Items.Add($"{zaman} - {ad} {soyad} tarafından giriş yapıldı.");
                MessageBox.Show("Giriş Başarılı! HOŞGELDİNİZ! DASHBOARD'a yönlendiriliyorsunuz.");
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                listBox1.Items.Add($"{zaman} - HATALI GİRİŞ YAPILDI!");
                MessageBox.Show("Ad, Soyad veya Şifre HATALI!");

            }
        }
    }
}
