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
    public partial class check_in : Form
    {
        public check_in()
        {
            InitializeComponent();
        }

        private void check_in_Load(object sender, EventArgs e)
        {
            comboBoxDoldur();
        }

        private void comboBoxDoldur()
        {
            string sorgu = "SELECT numara FROM tblOda WHERE durum = 0 ";
            DbManager.Instance().odaListe(sorgu, cbOda);
        }
        private int musteriId()
        {
            string kimlik_no = tbKimlikNoChechIn.Text;

            string komut = $"SELECT musteri_id FROM tblMusteri WHERE kimlik_no = '{kimlik_no}' ";

            int musteri_id = DbManager.Instance().musteriCek(komut, kimlik_no);

            return musteri_id;
        }

        private void btnMusteriCekCheckIn_Click(object sender, EventArgs e)
        {
            int musteri_id = musteriId();

            Console.WriteLine(musteri_id);

            
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

            int odaNumarasi = Convert.ToInt32(cbOda.Text);
            string komut = $"UPDATE tblRezervasyon SET oda_id = {odaNumarasi} WHERE musteri_id = {musteriId()}";

            DbManager.Instance().veritabaniKomut(komut);

            string komutOdaDurum = $"UPDATE tblOda SET durum = {1} WHERE numara = {odaNumarasi}";

            DbManager.Instance().veritabaniKomut(komutOdaDurum);

            cbOda.Items.Clear();
            comboBoxDoldur();

            MessageBox.Show("Check-In işlemi yapıldı!");
        }
    }
}
