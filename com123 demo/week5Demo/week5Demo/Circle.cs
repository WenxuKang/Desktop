using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5Demo
{
    class Circle:Square
    {

        public override double Area { get{ return Math.PI * Length * Length; } }

        public Circle(double length) : base("square", length) { }




    }
}
