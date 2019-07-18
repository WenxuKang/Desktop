using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5Demo
{
    class Diamond:Rectangle
    {
        public override double Area { get{ return Width * Height; } }

        public Diamond(double height, double width) : base("Rectangle", height, width) { }
    }
}
