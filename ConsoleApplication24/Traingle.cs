using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Traingle
    {
        public Point a { get; set; }
        public Point b { get; set; }
        public Point c { get; set; }

        public bool status { get; set; }


        public Traingle(Point a, Point b, Point c)   //конструктор
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Area()
        {
            var ab = new Edge(a, b);
            var ac = new Edge(a, c);
            var bc = new Edge(b, c);
            double p = (ab.GetLength() + ac.GetLength() + bc.GetLength()) / 2;
            return Math.Sqrt(p * (p - ab.GetLength()) * (p - bc.GetLength()) * (p - ac.GetLength()));

        }

        public double Perimeter()
        {
            var ab = new Edge(a, b);
            var ac = new Edge(a, c);
            var bc = new Edge(b, c);
            return  ab.GetLength() + bc.GetLength() + ac.GetLength();
        }
        public string GetType()
        {
            var ab = new Edge(a, b);
            var ac = new Edge(a, c);
            var bc = new Edge(b, c);
            if (ab.GetLength() == Math.Sqrt(Math.Pow(bc.GetLength(), 2) + Math.Pow(ac.GetLength(), 2)) || (bc.GetLength() == Math.Sqrt(Math.Pow(ac.GetLength(), 2) + Math.Pow(ab.GetLength(), 2))) || (ac.GetLength() == Math.Sqrt(Math.Pow(bc.GetLength(), 2) + Math.Pow(ab.GetLength(), 2)))) return "прямоугольный";
            if (ab.GetLength() == bc.GetLength() || ac.GetLength() == ab.GetLength() || ac.GetLength() == bc.GetLength()) return "равнобедренный";
            return "треугольник не является прямоугольным и равнобедренным, возможно, он обычный треугольник, но это не точно";
        }

        public void Check()
        {
            status = false;
            var ab = new Edge(a, b);
            var ac = new Edge(a, c);
            var bc = new Edge(b, c);
           

            if ((ab.GetLength() + bc.GetLength() > ac.GetLength()) || (bc.GetLength() + ac.GetLength() > ab.GetLength()) || (ab.GetLength() + ac.GetLength() > bc.GetLength()))
            {
                status = true;
            }
        }




    }
}
