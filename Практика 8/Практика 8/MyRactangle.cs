using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Практика_8
{
    [Serializable]
    class MyRactangle
    {
        private int length;
        private int hight;
        private int x;
        private int y;
        public MyRactangle() { }
        public MyRactangle(int l, int h, int x, int y)
        {
            length = l;
            hight = h;
            this.x = x;
            this.y = y;
        }
        public int Length { get { return length; } set { length = value; } }
        public int Hight { get { return hight; } set { hight = value; } }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
    }
}

