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
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int guncel = Convert.ToInt32(txtGuncelFiyat.Text);
            string sorgu = $"update tblOda set taban_fiyat= {guncel}";
            DbManager.Instance().veritabaniKomut(sorgu);
            MessageBox.Show("Fiyat Güncellendi");
        }
    }
}
