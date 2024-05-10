using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iskanje
{
    public partial class Form1 : Form
    {
        stevila s;
        public Form1()
        {
            InitializeComponent();
            s = new stevila();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
 
            int num = Int32.Parse(textBox1.Text);
            vrnitev.Text= s.Dodaj(num);
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            vrnitev.Text = s.Min();
        }

        private void max_btn_Click(object sender, EventArgs e)
        {
            vrnitev.Text = s.Max();
        }

        private void vsota_btn_Click(object sender, EventArgs e)
        {
            vrnitev.Text = s.Vsota();
        }

        private void pov_btn_Click(object sender, EventArgs e)
        {
            vrnitev.Text = s.Povprecje();
        }

        private void vsebuje_btn_Click(object sender, EventArgs e)
        {
            if (s.Vsebuje(Int32.Parse(textBox1.Text)) == true){
                MessageBox.Show("vsebuje");
            }
            else if (s.Vsebuje(Int32.Parse(textBox1.Text)) == false)
            {
                MessageBox.Show("ne vsebuje");
            }
        }

        private void vse_bin_btn_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            if (s.VsebujeBinarno(x) == true)
            {
                vrnitev.Text = "ga vsebuje";
            }
            else if (s.VsebujeBinarno(x) == false)
            {
                vrnitev.Text = "ga ne vsebuje";
            }
        }

        private void mehur_btn_Click(object sender, EventArgs e)
        {
            vrnitev.Text = s.Urejanjemehur();
        }

        private void dod10btn_Click(object sender, EventArgs e)
        {

        }

        private void dod50_Click(object sender, EventArgs e)
        {

        }

        private void dod20ur_Click(object sender, EventArgs e)
        {


        }

        private void uredi_vstavlj_btn_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            vrnitev.Text = s.DodajInUredi(x);
        }

        private void uredi_izbir_btn_Click(object sender, EventArgs e)
        {
            vrnitev.Text = s.Uredi();
        }
    }
}
