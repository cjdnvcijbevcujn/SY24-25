using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper2
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Button[] btn = new Button[2];
        Button[] btnGrid = new Button[100];
        tile[] tileGrid = new tile[100];
        public Form1()
        {
            /*InitializeComponent();
            btnGrid[0] = button1;
            btnGrid[1] = button2;
            btnGrid[2] = button3;
            btnGrid[3] = button4;
            btnGrid[4] = button5;
            btnGrid[5] = button6;
            btnGrid[6] = button7;
            btnGrid[7] = button8;
            btnGrid[8] = button9;
            btnGrid[9] = button10;*/
            for (int i = 0; i < 100; i++)
            {
                btnGrid[i] = (Button)Controls["button" + (i + 1)];
                tileGrid[i]=new tile(btnGrid[i]);
                btnGrid[i].BackColor = Color.Green;
            }
        }
        private int getindex(Button b)
        {
            string tmp = b.Name.Substring(6);
            int retVal = 0;
            int.TryParse(tmp, out retVal);
            return retVal - 1;
        }
        private Button getbutton(int r, int c)
        {
            return (Button)getbutton(r, c);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            getindex(sender as Button);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            b.BackColor = Color.Red;
        }
    }
}
