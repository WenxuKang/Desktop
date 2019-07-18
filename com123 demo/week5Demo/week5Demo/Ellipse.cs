using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5Demo
{
    class Ellipse:Rectangle
    {
        public override double Area { get { return Math.PI * Width * Height; } }

        public Ellipse(double height, double width): base("Rectangle",height, width) { }


    }
}
