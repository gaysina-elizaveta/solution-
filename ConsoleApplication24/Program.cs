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
            double p = 0;
            double ar = 0;
            int count1 = 0;
            int count2 = 0;

            Traingle[] trgl = new Traingle[10];
            Random gen1 = new Random();
            for (int i = 0; i < trgl.Length; i++)
            {
                Point[] point = new Point[3];
                Random gen = new Random();
                for (int  j= 0; j < 3; j++)
                {
                    point[j] = new Point(gen.Next(10), gen.Next(10));
                }
                trgl[i] = new Traingle(point[0], point[1], point[2]);

                Console.WriteLine("Три точки: ({0};{1}) ({2};{3}) ({4};{5})", point[0].x, point[0].y, point[1].x, point[1].y, point[2].x, point[2].y);

                Console.WriteLine("Периметр треугольника равен:" + trgl[i].Perimeter());
                Console.WriteLine("Площадь треугольника равна:" + trgl[i].Area());
                Console.WriteLine("Вид треугольника:" + trgl[i].GetType());

                if (trgl[i].GetType() == "прямоугольный" )
                {
                    count1++;
                    p = p + trgl[i].Perimeter();
                }
                if (trgl[i].GetType() == "равнобедренный")
                {
                    count2++;
                    ar =  ar + trgl[i].Area();
                }

            }

            p = p / count1;

            ar = ar / count2;

            Console.WriteLine("Средний периметр всех прямоугольных треугольников равен:", p);
            Console.WriteLine("Средняя площадь всех равнобедренных треугольников равна:", ar);

            Console.Read();
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


