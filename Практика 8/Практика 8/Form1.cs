using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Практика_8
{
    public partial class Form1 : Form
    {
        static private bool opened;
        public Form1()
        {
            InitializeComponent();
            opened = false;
        }
        static public bool Opened { get { return opened; } set { opened = value; } }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                MyRactangle ract = new MyRactangle();
                BinaryFormatter formater = new BinaryFormatter();
                FileStream file = new FileStream("1", FileMode.Open, FileAccess.Read);
                ract = (MyRactangle)formater.Deserialize(file);
                file.Close();

                e.Graphics.FillRectangle(new SolidBrush(Color.LightPink), ract.X, ract.Y, ract.Length, ract.Hight);
            }
            catch { }
        }

        private void ввестиДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!opened)
            {
                Ввод f = new Ввод();
                f.Show();
                opened = true;
            }
        }

        private void нарисоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
    }

}
