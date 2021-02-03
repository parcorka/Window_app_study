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
    public partial class Form1 : Form
    {
        string data;
        public Form1()
        {
            InitializeComponent();
        }

        public string Data1 { get { return textBox1.Text; } }
        public string Data2 { get { return data; } set { data = value; } }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(data != null) textBox2.Text = data;
        }
    }
}
