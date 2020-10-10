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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Otomobil oto = new Otomobil();
            oto.marka = "Ford";
            oto.model = "Focus";
            oto.yili = 2010;
            oto.renk = "Gri";
            oto.vitestipi = "Manuel";

            string marka = oto.markagetir();
            label15.Text = oto.marka.ToString();
            label14.Text = oto.model.ToString();
            label13.Text = oto.yili.ToString();
            label12.Text = oto.renk.ToString();
            label11.Text = oto.vitestipi.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
