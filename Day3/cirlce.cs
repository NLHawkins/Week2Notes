using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class circle : shape
    {
        //property since can be derived from method radius
        public double diameter
        {
            get
            {
                return 2 * radius;
            }
        }
        public circle(double _radius) : base(_radius)
        {
        }

        public override double Area()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
