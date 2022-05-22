using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace VeritabaniProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int taban_fiyat = 100;
        
        

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var giris = girisTarihi.Value;
            var cikis = cikisTarihi.Value;
            // .ToString("yyyy-MM-dd hh:mm:ss")
            var gunSayisi = cikis.Day - giris.Day;
            //var aradakiFark = giris.Day - DateTime.Now.Day;
            string sorgu = "SELECT taban_fiyat FROM tblOda";
            int guncelTabanFiyat = DbManager.Instance().guncelTabanFiyat(sorgu);
            int musteri_id = musteriId();
            int toplamFiyat = 0;
            int rezervasyonId = 0;
            if (rb_on_odeme.Checked == true)
            {
                toplamFiyat = guncelTabanFiyat * 75 / 100;
                rezervasyonId = 1;
                /*
                if(aradakiFark < 90)
                {
                    MessageBox.Show("En az 90 gün olmalı");
                }
                else
                {
                    toplamFiyat = guncelTabanFiyat * 75 / 100;
                    rezervasyonId = 1;
                }*/
            }

            else if (rb_std.Checked == true)
            {
                toplamFiyat = guncelTabanFiyat;
                rezervasyonId = 2;

            }

            else if (rb_60.Checked == true)
            {

            }
            
            string rezervasyonEkleSorgu = "INSERT INTO tblRezervasyon (musteri_id, rezervasyon_tip_id, baslangic_tarih, cikis_tarih, " +
                "toplam_fiyat, gun_sayisi) values " +
                $"({musteri_id}, {rezervasyonId}, '{giris.ToString("yyyy-MM-dd hh:mm:ss")}', '{cikis.ToString("yyyy-MM-dd hh:mm:ss")}', {toplamFiyat}, {gunSayisi})";

            DbManager.Instance().veritabaniKomut(rezervasyonEkleSorgu);
            //MessageBox.Show(toplamFiyat.ToString());
            MessageBox.Show("Rezervasyonunuz Oluşturulmuştur.");
            this.Hide();
            PersonelEkranics pe = new PersonelEkranics();
            pe.ShowDialog();
        }

        private void guna2RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void rb_60_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_60.Checked == true)
            {
                guna2Panel2.Hide();
            }
            
        }

        private void btnMusteriCek_Click(object sender, EventArgs e)
        {
            int musteri_id = musteriId();
            if (musteri_id == 0)
            {
                MessageBox.Show("Kimlik no yanlış");
            }
            else
            {
                MessageBox.Show(musteri_id.ToString());
            }
        }
        private int musteriId()
        {
            string kimlik_no = tbKimlikNoRezervasyon.Text;

            string komut = $"SELECT musteri_id FROM tblMusteri WHERE kimlik_no = '{kimlik_no}' ";

            int musteri_id = DbManager.Instance().musteriCek(komut, kimlik_no);

            return musteri_id;
        }
    }
}
