using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_4._2
{
    public partial class Form2 : Form
    {
        Form1 main;
        public string Data2 { get { return textBox2.Text; } }
        public Form2()
        {
            InitializeComponent();
            main = this.Owner as Form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (main.Data1 != null) textBox1.Text = main.Data1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Data2 = textBox2.Text;
        }
    }
}
