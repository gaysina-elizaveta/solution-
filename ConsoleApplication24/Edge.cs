using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Edge
    {
        public Point A { get; set; }
        public Point B { get; set; }


        public Edge(Point A, Point B)
        {
            this.A = A;
            this.B = B;
        }
        
        public double GetLength()
        {
            return  Math.Sqrt(Math.Pow(B.x - A.x, 2) + Math.Pow(A.y - B.y, 2));
        }

    }
}
