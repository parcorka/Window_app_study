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
    public partial class Form1 : Form
    {
        int checkShape = 0;//фигура
        bool checkDrag = false;//проверка удержания кнопки мыши
        bool Exist = false;//существование вершины
        MyFigure a = new Circle(MousePosition.X, MousePosition.Y);
        int delX = 0;
        int delY = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if(Exist) a.Draw(g);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            квадратToolStripMenuItem.Checked = false;
            треуголькникToolStripMenuItem.Checked = false;
            кругToolStripMenuItem.Checked = true;
            checkShape = 0;
        }

        private void квадратToolStripMenuItem_Click(object sender, EventArgs e)
        {
            квадратToolStripMenuItem.Checked = true;
            треуголькникToolStripMenuItem.Checked = false;
            кругToolStripMenuItem.Checked = false;
            checkShape = 1;
        }

        private void треуголькникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            квадратToolStripMenuItem.Checked = false;
            треуголькникToolStripMenuItem.Checked = true;
            кругToolStripMenuItem.Checked = false;
            checkShape = 2;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                if (a.X - 50 <= MousePosition.X && a.X + 50 >= MousePosition.X && a.Y - 50 <= MousePosition.Y && a.Y + 50 >= MousePosition.Y) 
                {
                    delX = a.X - MousePosition.X;
                    delY = a.Y - MousePosition.Y;
                    checkDrag = true;
                }
                else
                {
                    Exist = true;
                    if (checkShape == 0) a = new Circle(MousePosition.X, MousePosition.Y);
                    if (checkShape == 1) a = new Sqare(MousePosition.X, MousePosition.Y);
                    if (checkShape == 2) a = new Triangle(MousePosition.X, MousePosition.Y);
                    Invalidate();
                }
            }
            if (MouseButtons.Right ==  e.Button && a.X - 50 <= MousePosition.X && a.X + 50 >= MousePosition.X && a.Y - 50 <= MousePosition.Y && a.Y + 50 >= MousePosition.Y)
            {
                Exist = false;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            checkDrag = false;
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (checkDrag)
            {
                if (checkShape == 0) a = new Circle(MousePosition.X + delX, MousePosition.Y + delY);
                if (checkShape == 1) a = new Sqare(MousePosition.X + delX, MousePosition.Y + delY);
                if (checkShape == 2) a = new Triangle(MousePosition.X + delX, MousePosition.Y + delY);
                Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;//изображение не мигает
        }
    }



    abstract class MyFigure
    {
        protected int x;
        protected int y;

        protected MyFigure() { }
        protected MyFigure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract int X { get; }
        public abstract int Y { get; }

        public abstract void Draw(Graphics g);
    }
    class Circle : MyFigure
    {
        public Circle() : base() { }
        public Circle(int x, int y) : base(x, y) { }
        public override int X { get { return x; } }
        public override int Y { get { return y; } }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Green), x - 50, y - 50, 100, 100);
        }
    }
    class Sqare : MyFigure
    {
        public Sqare() : base() { }
        public Sqare(int x, int y) : base(x, y) { }
        public override int X { get { return x; } }
        public override int Y { get { return y; } }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Green), x - 50, y - 50, 100, 100);
        }
    }
    class Triangle : MyFigure
    {
        public Triangle() : base() { }
        public Triangle(int x, int y) : base(x, y) { }
        public override int X { get { return x; } }
        public override int Y { get { return y; } }
        public override void Draw(Graphics g)
        {
            Point[] p = { new Point(x, y - 50), new Point(x - 50, y + 50), new Point(x + 50, y + 50) };
            g.FillPolygon(new SolidBrush(Color.Green), p);
        }
    }
}
