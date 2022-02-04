using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson6
{
    class Rectangle : Point
    {
        public double Lenght { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Lenght * Width;
        }
    }
}
