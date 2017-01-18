using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class circle : shape
    {
        public circle(double _radius) : base(_radius)
        {
        }

        public override double Area()
        {
            return Math.Pow((double)Math.PI * radius, 2);
        }
    }
}
