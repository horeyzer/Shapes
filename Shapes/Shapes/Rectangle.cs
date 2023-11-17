using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle:Shape
    {
        double edge2;
        public string nameOfEdge2;
        override public double Area()
        {
            return edge1 * edge2;
        }

        public override string AssignPicture()
        {
            return "Rectangle.jpg";
        }
    }
}
