using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Pattern
{
    public partial class Form1 : Form
    {
        string f;
        testing g = new testing();
        EnemyShip j;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.option = "R";
            j = g.EnemyGen();
            g.doenemystuff(j);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            g.option = "M";
            j = g.EnemyGen();
            g.doenemystuff(j);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            g.option="U";
            j = g.EnemyGen();
            g.doenemystuff(j);
        }
    }
}
