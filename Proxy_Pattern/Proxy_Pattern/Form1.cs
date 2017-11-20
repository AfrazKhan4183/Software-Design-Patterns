using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy_Pattern
{
    public partial class Form1 : Form
    {
        ATMMachine f = new ATMMachine();
        ATMProxy h = new ATMProxy();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f.insertcard();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.insertpin
                (Convert.ToInt32(textBox2.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.requestCash(Convert.ToInt32(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f.ejectcard();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            h.getATMState();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            h.getCashinMachine();
        }
    }
}
