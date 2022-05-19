using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabaniProje
{
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }
        
        private Musteri musteriBilgi()
        {
            Musteri musteri = new Musteri();
            musteri.ad = tbMusteriAd.Text;
            musteri.soyad = tbMusteriSoyad.Text;
            musteri.kimlik_no = tbKimlikNo.Text;
            musteri.telefon = tbTelefon.Text;
            musteri.e_posta = tbEposta.Text;

            return musteri;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = musteriBilgi();

            string komut = "INSERT INTO tblMusteri (ad, soyad, kimlik_no, telefon, e_posta) " +
                $"values ('{musteri.ad}', '{musteri.soyad}', '{musteri.kimlik_no}', '{musteri.telefon}', '{musteri.e_posta}')";
            
            DbManager.Instance().veritabaniKomut(komut);
            MessageBox.Show("Müşteri Eklendi");
            tbMusteriAd.Clear();
            tbMusteriSoyad.Clear();
            tbKimlikNo.Clear();
            tbTelefon.Clear();
            tbEposta.Clear();

            /*this.Hide();
            PersonelEkranics personel = new PersonelEkranics();
            personel.Show();
          */

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelEkranics personel = new PersonelEkranics();
            personel.Show();


        }
    }
}
