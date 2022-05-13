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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (rbAdmin.Checked)
            {
                YoneticiEkranics yonetici = new YoneticiEkranics();
                yonetici.Show();
                this.Hide();
              
            }
            else if(rbPersonel.Checked) 
            {
                PersonelEkranics personel = new PersonelEkranics();
                personel.Show();
                this.Hide();

            }

            
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

       
    }
}
