using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        bool draw;
        int cordsY;
        int cordsX;
        int changeY;
        int changeX;
        public Form1()
        {
            InitializeComponent();
            cordsX = 0;
            cordsY = 0;
            draw = false;
            changeX = 2;
            changeY = 2;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            if(draw)e.Graphics.FillEllipse(new SolidBrush(Color.Black), cordsX, cordsY, 30, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            draw = true;
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            draw = false;
            cordsX = 0;
            cordsY = 0;
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                timer1.Start();
                button3.Text = "stop";
            }
            else
            {
                timer1.Stop();
                button3.Text = "start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cordsY >= splitContainer1.Panel1.Bottom - 30) changeY = -4;
            if (cordsY <= splitContainer1.Panel1.Top) changeY = 4;
            if (cordsX >= splitContainer1.Panel1.Right - 30) changeX = -4;
            if (cordsX <= splitContainer1.Panel1.Left) changeX = 4;
            cordsX += changeX;
            cordsY += changeY;
            Refresh();
        }
    }

}
