using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle:Shape
    {
        public double edge2;
        public string nameOfEdge2;

        public override double Area()
        {
            return (edge1 * edge2) / 2;
        }
        public override string AssignPicture()
        {
            return "Triangle.jpg";
        }

    }
}
