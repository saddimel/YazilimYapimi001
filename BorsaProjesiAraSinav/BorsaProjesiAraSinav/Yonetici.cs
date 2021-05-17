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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        private void Yonetici_Load(object sender, EventArgs e)
        {
            foreach (Kullanici kullanici in Islemler.entities.Kullanicilar)
            {
                listBox1.Items.Add(kullanici.Kullaniciadi);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Kullanici kullanici = Islemler.entities.Kullanicilar.Find(listBox1.SelectedItem.ToString());
            if (kullanici!=null)
            {
                bakiyetalep.Text = kullanici.OnayBakiye.ToString() + " TL";
                foreach (KullaniciUrun urun in kullanici.Urunler)
                {
                    if (urun.Urun.Onay==0)
                    {
                        listBox2.Items.Add(urun.Urun.Id+" - "+urun.Urun.UrunAdi + " - " + urun.Urun.Miktar + " adet");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>=0)
            {
                Kullanici kullanici = Islemler.entities.Kullanicilar.Find(listBox1.SelectedItem.ToString());
                kullanici.Bakiye += kullanici.OnayBakiye;
                kullanici.OnayBakiye = 0;
                foreach (KullaniciUrun urun in kullanici.Urunler)
                {
                    if (urun.Urun.Onay == 0)
                    {
                        urun.Urun.Onay = 1;
                    }
                }
                Islemler.entities.SaveChanges();
                listBox2.Items.Clear();
                bakiyetalep.Text = "0 TL";
                Islemler.AlimSatimGerceklestir();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new IslemForm().ShowDialog();
        }
    }
}
