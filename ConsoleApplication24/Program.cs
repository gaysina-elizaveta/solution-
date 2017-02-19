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

            var edge1 = new Edge(point1, point2);
            var edge2 = new Edge(point2, point3);
            var edge3 = new Edge(point3, point1);





        }
    }
    public class Point
    {
        public float x;
        public float y;
        public Point(float _x, float _y)
        {
            x = _x;
            y = _y;
        }
    }


    public class  Edge
    {
        double line;
        public Edge(Point p1, Point p2)
        {
            line = Math.Sqrt(Math.Pow(p1.x - p2.x,2) + Math.Pow(p1.y - p2.y,2));
        }
      

        
    }

    public class Traingle
    {
        public Point a;
        public Point b;
        public Point c;

        public Traingle ()   //конструктор
        {
            a = new Point(,);
            b;
            c;
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
            double Perimeter = a + b + c;
            return Perimeter;
        }




    }
}


