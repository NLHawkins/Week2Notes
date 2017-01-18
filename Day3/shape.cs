using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class shape
    {
        public double height;
        public double width;
        public double radius;
        
        //zero are instructor
        public shape()
        {

        }
        //circle constructor
        public shape(double _radius)
        {
            
            radius = _radius;
        }

        //square constructor
        public shape(double _height, double _width)

        {
            height = _height;
            width = _width;            
            
        }
        public virtual double Area()
        {
               
            return 0f;
        }


    }
}
