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
            var point1 = new Point(-3, -2);
            var point2 = new Point(0, -1);
            var point3 = new Point(-2, 5);

            Console.WriteLine("Три точки: ({0};{1}) ({2};{3}) ({4};{5})", point1.x, point1.y, point2.x, point2.y, point3.x, point3.y);

            var edge1 = new Edge(point1, point2);
            var edge2 = new Edge(point2, point3);
            var edge3 = new Edge(point3, point1);


            var tringle1 = new Traingle(point1, point2, point3);

            Console.WriteLine("Периметр равен:" + tringle1.Perimeter());
            Console.WriteLine("Площадь равна:" + tringle1.Area());
            Console.WriteLine("Вид треугольника:" + tringle1.GetType());

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
       public double Area()
        {
            var ab = new Edge(a, b);
            var ac = new Edge(a, c);
            var bc = new Edge(b, c);
            double p = (ab.GetLength() + ac.GetLength() + bc.GetLength()) /2;
            return Math.Sqrt(p * (p - ab.GetLength()) * (p - bc.GetLength()) * (p - ac.GetLength()));

        }

       public double Perimeter()
        {
            var ab = new Edge(a, b);
            var ac = new Edge(a, c);
            var bc = new Edge(b, c);
            double Perimeter = ab.GetLength() + bc.GetLength() + ac.GetLength();
            return Perimeter;
        }
       public string GetType()
        {
            var ab = new Edge(a, b);
            var ac = new Edge(a, c);
            var bc = new Edge(b, c);
            if (ab.GetLength() == Math.Sqrt(Math.Pow(bc.GetLength(),2) + Math.Pow(ac.GetLength(),2)) || (bc.GetLength() == Math.Sqrt(Math.Pow(ac.GetLength(),2) + Math.Pow(ab.GetLength(),2))) || (ac.GetLength() == Math.Sqrt(Math.Pow(bc.GetLength(), 2) + Math.Pow(ab.GetLength(), 2)))) return "прямоугольный";
            if (ab.GetLength() == bc.GetLength() || ac.GetLength() == ab.GetLength() || ac.GetLength() == bc.GetLength()) return "равнобедренный";
            return "треугольник не является прямоугольным и равнобедренным, возможно, он обычный треугольник, но это не точно";
        }





    }
}


