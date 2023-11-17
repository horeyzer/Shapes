using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square:Shape
    {
        public override double Area()
        {
            return edge1 * edge1;
        }
        public override string AssignPicture()
        {
            return "Square.jpg";
        }
    }
}
