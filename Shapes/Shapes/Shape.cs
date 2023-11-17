using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract internal class Shape
    {
        public string name;
        public double edge1;
        public string nameOfEdge1;
        public string picturePath;
        public abstract double Area();

        virtual public string AssignPicture()
        {
            picturePath = "default.jpg";
            return picturePath;
        }
    }
}
