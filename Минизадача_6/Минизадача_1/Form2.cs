using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Минизадача_1
{
    public partial class Form2 : Form
    {
        int sec;
        public Form2()
        {
            InitializeComponent();
        }
        public int Sec { get { return sec; } set { sec = value; } }

        private void button1_Click(object sender, EventArgs e)
        {
            Sec = int.Parse(textBox1.Text);
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
