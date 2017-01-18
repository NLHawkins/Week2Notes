using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            shape square = new square(4f,7f);
            double squarearea = square.Area();
            Console.WriteLine(square.Area());

            shape circle = new circle(10);
            double circleArea = circle.Area();
            Console.WriteLine(circleArea);
        }
    }
}
