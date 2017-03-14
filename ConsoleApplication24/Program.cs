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
   

  
}


