using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {

        static void Main(string[] args)
        {
            var point1 = new Point(0, 3);
            var point2 = new Point(-2, 3);
            var point3 = new Point(-6, 1);

            Console.WriteLine("{0} { 1} {2}", point1, point2, point3);

             d = 
            var tringle1 = new Traingle(point1, point2, point3);
            Console.WriteLine("Периметр равен:", Perimeter());
            Console.WriteLine("Площадь равна:", Area());
            Console.WriteLine("Вид треугольника:", GetType());

            Console.ReadKey();
        }
    }
    public class Point
    {
        public float x { get; set;}
        public float y { get; set; }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

    }


    public class  Edge
    {
        public Point A { get; set; }
        public Point B { get; set; }

       
        public Edge(Point A, Point B)
        {
            this.A = A;
            this.B = B;
        }
        double line;
        public double GetLength()
        {
           return line = Math.Sqrt(Math.Pow(B.x - A.x,2) + Math.Pow(A.y - B.y,2));
        }
      

        
    }

    public class Traingle
    {
        public Point a { get; set; }
        public Point b { get; set; }
        public Point c { get; set; }

        public Traingle (Point a, Point b, Point c)   //конструктор
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void PrintSides()
        {
            Console.WriteLine("a is {0}, b is {1}, c is {2}", a, b, c);
        }
       public double Area(Edge a, Edge b, Edge c)
        {
            double p = (a.GetLength() + b.GetLength() + c.GetLength()) /2;
            return Math.Sqrt(p * (p - a.GetLength()) * (p - b.GetLength()) * (p - c.GetLength()));

        }

       public double Perimeter(Edge a, Edge b, Edge c)
        {
            double Perimeter = a.GetLength() + b.GetLength() + c.GetLength();
            return Perimeter;
        }
       public string GetType(Edge a, Edge b, Edge c)
        {
            if (a.GetLength() == Math.Sqrt(Math.Pow(b.GetLength(),2) + Math.Pow(c.GetLength(),2)) || (b.GetLength() == Math.Sqrt(Math.Pow(a.GetLength(),2) + Math.Pow(c.GetLength(),2))) || (c.GetLength() == Math.Sqrt(Math.Pow(b.GetLength(), 2) + Math.Pow(a.GetLength(), 2)))) return "равносторонний";
            if (a.GetLength() == b.GetLength() || a.GetLength() == c.GetLength() || b.GetLength() == c.GetLength()) return "равнобедренный";
            return "треугольник не является прямоугольным и равнобедренным, возможно, он обычный треугольник, но это не точно";
        }



    }
}


