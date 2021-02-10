using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArdioButttonKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a = 10;
        int b = 2;
        int topla, cikar, bol, carp;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            topla = a + b;
            label1.Text = topla.ToString();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cikar = a - b;
            label1.Text = cikar.ToString();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            bol = a / b;
            label1.Text = bol.ToString();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            carp = a * b;
            label1.Text = carp.ToString();
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
