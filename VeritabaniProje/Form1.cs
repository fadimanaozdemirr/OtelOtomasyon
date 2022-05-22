using System;
using System.Windows.Forms;

namespace VeritabaniProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var giris = girisTarihi.Value;
            var cikis = cikisTarihi.Value;

            var gunSayisi = cikis.Day - giris.Day;
            var aradakiFark = giris.Day - DateTime.Now.Day;
            string sorgu = "SELECT taban_fiyat FROM tblOda";
            int guncelTabanFiyat = DbManager.Instance().guncelTabanFiyat(sorgu);
            Rezervasyon rezervasyon = new Rezervasyon
            {
                baslangic_tarih = giris,
                cikis_tarih = cikis,
                gun_sayisi = gunSayisi
            };

            if (rb_on_odeme.Checked == true)
            {
                if (aradakiFark < 90)
                {
                    MessageBox.Show("En az 90 gün olmalı");
                }
                else
                {
                    int toplamFiyat = guncelTabanFiyat * 75 / 100;
                    rezervasyon.toplam_fiyat = toplamFiyat * gunSayisi;
                    int rezervasyon_tip_id = 2;
                    rezervasyonEkle(rezervasyon, rezervasyon_tip_id);
                }
            }
            if (rb_std.Checked == true)
            {
                int toplamFiyat = guncelTabanFiyat;
                rezervasyon.toplam_fiyat = toplamFiyat * gunSayisi ;
                int rezervasyon_tip_id = 1;
                rezervasyonEkle(rezervasyon, rezervasyon_tip_id);
            }
            if (rb_60.Checked == true)
            {
                int toplamFiyat = guncelTabanFiyat * 85 / 100;
                rezervasyon.toplam_fiyat = toplamFiyat * gunSayisi;
                int rezervasyon_tip_id = 3;
                rezervasyonEkle(rezervasyon, rezervasyon_tip_id);
            }

            MessageBox.Show("Rezervasyonunuz Oluşturulmuştur.");
            this.Hide();
            PersonelEkranics pe = new PersonelEkranics();
            pe.ShowDialog();
        }

        private void rezervasyonEkle(Rezervasyon rezervasyon, int rezervasyon_tip_id)
        {
            int musteri_id = musteriId();

            string rezervasyonEkleSorgu = "INSERT INTO tblRezervasyon (musteri_id, rezervasyon_tip_id, baslangic_tarih, cikis_tarih, " +
                "toplam_fiyat, gun_sayisi) values " +
                $"({musteri_id}, {rezervasyon_tip_id}, '{rezervasyon.baslangic_tarih.ToString("yyyy-MM-dd hh:mm:ss")}', '{rezervasyon.cikis_tarih.ToString("yyyy-MM-dd hh:mm:ss")}', " +
                $"{rezervasyon.toplam_fiyat}, {rezervasyon.gun_sayisi})";

            DbManager.Instance().veritabaniKomut(rezervasyonEkleSorgu);
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
            else
            {
                guna2Panel2.Show();
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

        private void guna2RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}