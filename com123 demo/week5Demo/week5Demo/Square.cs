using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5Demo
{
    class Square : Shape
    {

        protected double Length { get; set; }
        public override double Area {get { return Length * Length; } }

        public Square(double length) : base("square")
        { Length = length; }
        public Square (string name, double length) : base(name)
        {
            
            Length = length;

        }

    }
}
