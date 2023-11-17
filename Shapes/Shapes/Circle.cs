using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle:Shape
    {
        public override double Area()
        {
            return Math.PI * edge1 * edge1;
        }
        public override string AssignPicture()
        {
            return "Circle.jpg";
        }
    }
}
