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
            if (rb_on_odeme.Checked == true)
            {
                int onOdemeFiyat;
                onOdemeFiyat = taban_fiyat * 75 / 100;
                //string kayit = "select taban_fiyat from tblOda where taban_fiyat = @taban_fiyat";
                //SqlParameter pr1 = new SqlParameter("taban_fiyat");
            }

            if(rb_60.Checked == true)
            {
                
            }

            if (rb_std.Checked == true)
            {

            }

            if (rb_tesvik.Checked == true)
            {

            }
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
    }
}
