using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publisher_SubscriberPattern
{
    public partial class Form1 : Form
    {
        Stock s = new Stock();
 StockObserver h;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            StockObserver h = new StockObserver(s);
    
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s.setibm(Convert.ToInt32(textBox3.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            s.setgoog(Convert.ToInt32(textBox2.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s.setapp(Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.unregister(h);
        }
    }
}
