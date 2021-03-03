using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_6
{
    class Program
    {
        public delegate void Del();
        public delegate int Mathmetic(int a, int b);
        public class useless
        {
            public static void Ru() { Console.WriteLine("привет! "); }
            public static void En() { Console.WriteLine("hello! "); }
            public static void Lat() { Console.WriteLine("salve! "); }
            public static void Itl() { Console.WriteLine("ciao! "); }
            public static void Sp() { Console.WriteLine("hola! "); }
        }
        static void Main(string[] args)
        {
            Del d = useless.Ru;
            d += useless.En;
            d += useless.Lat;
            d += useless.Itl;
            d += useless.Sp;
            d();
            /*d += new Del(delegate () { Console.WriteLine("hello! "); });
            d += new Del(delegate () { Console.WriteLine("salve! "); });// лат.
            d += new Del(delegate () { Console.WriteLine("ciao! "); });// ит.
            d += new Del(delegate () { Console.WriteLine("hola! "); });// ис.*/

            Mathmetic m = (int x, int y) => { Console.WriteLine("x + y"); return x + y; };
            m += (int x, int y) => { Console.WriteLine("x * y"); return x * y; };
            m += (int x, int y) => { Console.WriteLine("x / y"); return x / y; };

            Console.ReadKey();
        }
    }
}
