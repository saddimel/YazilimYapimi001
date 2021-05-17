using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaProjesiAraSinav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Islemler.Kullanicivarmi(tbkadi.Text) == false)
            {
                Kullanici kullanici = new Kullanici();
                kullanici.Ad = tbad.Text;
                kullanici.Soyad = tbsoyad.Text;
                kullanici.Kullaniciadi = tbkadi.Text;
                kullanici.Sifre = tbsifre.Text;
                kullanici.Email = tbemail.Text;
                kullanici.TC = tbtc.Text;
                kullanici.Telefon = tbtelefon.Text;
                kullanici.Adres = tbadres.Text;
                kullanici.Bakiye = 0;
                kullanici.OnayBakiye = 0;
                Islemler.entities.Kullanicilar.Add(kullanici);
                Islemler.entities.SaveChanges();
                MessageBox.Show("Kaydınız oluşturuldu.");
            }
            else MessageBox.Show("Bu kullanıcı adıyla bir kayıt zaten var.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (giriskadi.Text=="admin"&&girissifre.Text=="admin")
            {
                Yonetici form = new Yonetici();
                form.ShowDialog();
            }
            else
            {
                Kullanici giris = Islemler.Giris(giriskadi.Text, girissifre.Text);
                if (giris == null)
                {
                    MessageBox.Show("Hatalı kullanıcı adı veya şifre girdiniz.");
                }
                else
                {
                    KullaniciForm form = new KullaniciForm(giris);
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Islemler.entities.SaveChanges();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Islemler.AlimSatimGerceklestir();
        }
    }
}
