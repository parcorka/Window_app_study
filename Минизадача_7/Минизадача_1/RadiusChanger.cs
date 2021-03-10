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
    public delegate void RadChange(object sender, RadiusEventArgs e);
    public partial class RadiusChanger : Form
    {
        public event RadChange s;
        public RadiusChanger()
        {
            InitializeComponent();
            trackBar1.Value = MyFigure.R;
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (this.s != null)
            {
                s(this, new RadiusEventArgs(trackBar1.Value));
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
