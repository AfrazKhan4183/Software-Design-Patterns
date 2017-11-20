using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade_Pattern
{
    public partial class Form1 : Form
    {

        FacadeAccount g;


        public Form1()
        {
            InitializeComponent();
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBox3.Text);
            g.DepositCaash(k);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(textBox4.Text);
            g.withdrawCash(j);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            g = new FacadeAccount(textBox2.Text,textBox1.Text);
        }
    }
}
