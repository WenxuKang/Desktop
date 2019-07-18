using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5Demo
{
    class Rectangle : Shape
    {


        protected double Width { get; set;}
      
        protected double Height { get; set; }

        public override double Area { get { return Width * Height; } }
        public Rectangle(double height, double width):base("Rectangle")

        {
            Height = height;
            Width = width;
        }

        public Rectangle(string name, double height,double width) : base(name)

        {

            Height = height;
            Width = width;
        }
    }
}
