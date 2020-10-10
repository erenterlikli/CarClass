using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Otomobil oto = new Otomobil();
            oto.marka = "Toyota";
            oto.model = "Corolla";
            oto.yili = 2013;
            oto.renk = "Füme";
            oto.vitestipi = "Otomatik";

            string marka = oto.markagetir();

            label6.Text = oto.marka.ToString();
            label7.Text = oto.model.ToString();
            label8.Text = oto.yili.ToString();
            label9.Text = oto.renk.ToString();
            label10.Text = oto.vitestipi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();

            Otomobil oto = new Otomobil();
            oto.marka = "Ford";
            oto.model = "Focus";
            oto.yili = 2007;
            oto.renk = "Gri";
            oto.vitestipi = "Manuel";

            string marka = oto.markagetir();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
