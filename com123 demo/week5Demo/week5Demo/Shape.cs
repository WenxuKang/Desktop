using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5Demo
{
    abstract class Shape
    {
        
        public string Name { get; private set; }
        public abstract double Area { get; }
        public Shape(string name)

        {
            Name = name;
         
        }

        public override string ToString()
        {
            return $"The {Name}, the area is {Area:N2}";
        }

    }
}
