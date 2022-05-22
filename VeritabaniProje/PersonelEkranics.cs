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
    public partial class PersonelEkranics : Form
    {
        public PersonelEkranics()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        { 
            MusteriForm form2 = new MusteriForm();
            form2.Show();  
            this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            form.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonelRapor pr = new PersonelRapor();
            pr.ShowDialog();
        }
    }
}
