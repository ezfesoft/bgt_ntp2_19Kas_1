using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt_ntp2_19Kas_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kitap> kitaplar=new List<Kitap>(); 
        List<Uye> uyeler =new List<Uye>();

        private void button1_Click(object sender, EventArgs e)
        {
            string kAd, yAd, yEvi;
            int yil;
            kAd = textBox1.Text;
            yAd = textBox2.Text;
            yEvi = textBox3.Text;
            yil = Convert.ToInt32(textBox4.Text);

            Kitap book = new Kitap(kAd,yAd,yEvi,yil);

            kitaplar.Add(book);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            label6.Text=kitaplar.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string uAd, uSoyad, uTel;
            int uYas;

            uAd = textBox5.Text;
            uSoyad = textBox6.Text;
            uTel = textBox7.Text;
            uYas = Convert.ToInt32(textBox8.Text);

            Uye user = new Uye(uAd,uSoyad,uTel,uYas);
            uyeler.Add(user);

            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            label14.Text = uyeler.Count.ToString();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            if (tabControl1.SelectedIndex == 0)
            {
                label6.Text = kitaplar.Count.ToString();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                label14.Text = uyeler.Count.ToString();
            }
            if (tabControl1.SelectedIndex==2)
            {
                for (int i = 0; i < kitaplar.Count; i++)
                {
                    listBox1.Items.Add(kitaplar[i].kitapAdi);
                }
            }
            if (tabControl1.SelectedIndex == 3)
            {
                for (int i = 0; i < uyeler.Count; i++)
                {
                    listBox2.Items.Add(uyeler[i].uyeAdi);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            label19.Text = kitaplar[index].kitapAdi;
            label20.Text = kitaplar[index].yazarAdi;
            label22.Text = kitaplar[index].yayinEvi;
            label24.Text = kitaplar[index].basimYili.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;
            label32.Text = uyeler[index].uyeAdi;
            label30.Text = uyeler[index].uyeSoyadi;
            label28.Text = uyeler[index].uyeTel;
            label26.Text = uyeler[index].uyeYas.ToString();
        }
    }
}
