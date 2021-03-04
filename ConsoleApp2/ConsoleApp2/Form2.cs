using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    public delegate void SizeChange(object sender, RadiusEventArgs e);
    public partial class Form2 : Form
    {
        public event SizeChange s;
        public Form2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int v = Convert.ToInt32(numericUpDown1.Value);
            if(this.s != null)
            {
                s(this, new RadiusEventArgs(v));
            }
        }
    }
    public class RadiusEventArgs : EventArgs
    {
        //private int rad;
        //public int Rad { get { return rad; } set { Rad = value; } }
        public int Rad { get; set; }
        public RadiusEventArgs(int r)
        {
            Rad = r;
        }
    }
}
