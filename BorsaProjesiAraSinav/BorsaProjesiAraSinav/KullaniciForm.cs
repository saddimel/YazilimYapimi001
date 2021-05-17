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
    public partial class KullaniciForm : Form
    {
        Kullanici kullanici;
        public KullaniciForm(Kullanici giris)
        {
            kullanici = giris;
            InitializeComponent();
        }

        private void KullaniciForm_Load(object sender, EventArgs e)
        {
            cburunler.Items.AddRange(Islemler.urunler());
            cburunler.SelectedIndex = 0;
            cburun2.Items.AddRange(Islemler.urunler());
            cburun2.SelectedIndex = 0;
            Islemler.AlimSatimGerceklestir();
            Yenile();
        }

        private void KullaniciForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciUrun urun = new KullaniciUrun();
            urun.Kullanici = kullanici;
            urun.Urun = new Urun();
            urun.Urun.BirimFiyat = int.Parse(textBox1.Text);
            urun.Urun.Miktar = trackBar1.Value;
            urun.Urun.UrunAdi = cburunler.SelectedItem.ToString();
            urun.Urun.Onay = 0;
            kullanici.Urunler.Add(urun);
            Yenile();
            Islemler.AlimSatimGerceklestir();
            Yenile();
            MessageBox.Show("Onaya gönderildi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullanici.OnayBakiye += int.Parse(textBox2.Text);
            Yenile();
            MessageBox.Show("Talebiniz gönderildi.");
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar2.Value.ToString();
        }
        void Yenile()
        {
            Islemler.entities.SaveChanges();
            kullanici = Islemler.entities.Kullanicilar.Find(kullanici.Kullaniciadi);
            label10.Text = kullanici.Bakiye.ToString() + " TL";
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            foreach (KullaniciUrun urun in kullanici.Urunler)
            {
                if (urun.Urun.Onay == 1)
                {
                    dataGridView1.Rows.Add(urun.Urun.UrunAdi, urun.Urun.Miktar, urun.Urun.BirimFiyat);
                }
            }
            foreach (KullaniciTalep talep in kullanici.Talepler)
            {
                dataGridView2.Rows.Add(talep.Talep.UrunAdi, talep.Talep.TalepMiktari);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciTalep talep = new KullaniciTalep();
            talep.Kullanici = kullanici;
            talep.Talep = new Talep();
            talep.Talep.TalepMiktari = trackBar2.Value;
            talep.Talep.UrunAdi = cburun2.SelectedItem.ToString();
            kullanici.Talepler.Add(talep);
            Yenile();
            Islemler.AlimSatimGerceklestir();
            Yenile();
            MessageBox.Show("Talebiniz oluşturuldu.");
        }
    }
}
