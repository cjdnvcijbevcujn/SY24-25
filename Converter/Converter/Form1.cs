using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int total = 0;
        private void bit4_TextChanged(object sender, EventArgs e)
        {
            total = 0;
            if (bit1.Text == "1") 
            total += 1;
            total = 0;
            if (bit2.Text == "2")
                total += 2;
            total = 0;
            if (bit3.Text == "4")
                total += 4;
            total = 0;
            if (bit4.Text == "8")
                total += 8;
            total = 0;
            if (bit5.Text == "16")
                total += 16;
            total = 0;
            if (bit6.Text == "32")
                total += 32;
            total = 0;
            if (bit7.Text == "64")
                total += 64;
            total = 0;
            if (bit8.Text == "128")
                total += 128;
            Totallabel.Text = total.ToString();
        }
    }
}
