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
            Console.ReadKey();






        }
    }
    public class Point
    {
        public float x { get; set;}
        public float y { get; set; }

        public Point(float x,  float y)
        {
            this.x = x;
            this.y = y;
        }

    }


    public class  Edge
    {
        public Point A { get; set; }
        public Point B { get; set; }

       
        public Edge()
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

        public Traingle ()   //конструктор
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void PrintSides()
        {
            Console.WriteLine("a is {0}, b is {1}, c is {2}", a, b, c);
        }
        double Area()
        {
            double p = ( a +  b +  c) /2;
            return Math.Sqrt(p * (p -  a) * (p - b) * (p - c));

        }


        double Perimeter()
        {
            double Perimeter = GetLength(a) + b + c;
            return Perimeter;
        }
        string GetType()
        {
            if (a = Math.Sqrt(Math.Pow(b,2) + Math.Pow(c,2)) || (b = Math.Sqrt(Math.Pow(a,2) + Math.Pow(c,2))) || (c = Math.Sqrt(Math.Pow(b,2) + Math.Pow(a,2)))) return "равносторонний";
            if (AB == BC || AB == AC || BC == AC) return "равнобедренный";
            return "треугольник не является прямоугольным и равнобедренным, возможно, он обычный треугольник, но это не точно";
        }



    }
}


