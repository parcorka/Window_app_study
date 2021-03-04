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

    public partial class Form1 : Form
    {
        Color Br;
        int Radius;
        delegate void Change();

        public Form1()
        {
            InitializeComponent();
            Br = Color.Red;
            Radius = 25;
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(Br), 50, 50, Radius, Radius);
        }
        private void RadDel(object sender, RadiusEventArgs e)
        {
            Radius = e.Rad;
            Refresh();
        }

        private void изменениеРадиусаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            f.s += RadDel;
        }
    }
    
}
