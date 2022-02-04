using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson6
{
    class Circle : Point
    {
        private const double pi = 3.14;
        public double Radius { get; set; }
        public override double Area()
        {
            return pi * Radius * Radius;
        }
    }
}
