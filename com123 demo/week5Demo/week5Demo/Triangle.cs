using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5Demo
{
    class Triangle:Rectangle
    {
        public override double Area { get { return Width * Height * 0.5; } }

        public Triangle(double height, double width): base("Rectangle", height, width) { }
    }
}
