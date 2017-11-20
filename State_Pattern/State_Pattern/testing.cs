using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State_Pattern
{
    public partial class testing : Form
    {
        ATMMachine g = new ATMMachine();
        public testing()
        {
            InitializeComponent();
        }

        

        private void insert_Click(object sender, EventArgs e)
        {
            g.insertcard();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.ejectcard();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            g.insertpin(Convert.ToInt32(textBox1.Text)); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.requestCash(Convert.ToInt32(textBox2.Text));
        }
    }
}
