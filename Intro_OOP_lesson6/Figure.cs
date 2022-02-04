using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_OOP_lesson6
{
    public struct Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vector(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Vector HorizontalMovement(double a)
        {
            return new Vector(X + a, Y);
        }
        public Vector VerticalMovement(double a)
        {
            return new Vector(X, Y + a);
        }
    }
    public enum Color { White, Black, Red, Blue, Yellow, Green, Orange};
    public enum Status { Visible, Invisible};
    public class Figure
    {
        public Color Color { get; set; }
        public Status Status { get; set; }
        protected Vector _Vector { get; set; }

        public void AddCoordinate(double x, double y)
        {
            _Vector = new Vector(x, y);
        }
        public void HorizontalMovement(double a)
        {
            _Vector = _Vector.HorizontalMovement(a);
        }
        public void VerticalMovement(double a)
        {
            _Vector = _Vector.VerticalMovement(a);
        }
        public void ChangeColor(Color color)
        {
            Color = color;
        }
        public void ChangeStatus(Status status)
        {
            Status = status;
        }
        public override string ToString() => $"Color - {Color} Coordinate - [{_Vector.X},{_Vector.Y}] Status - {Status}"; 
    }
}
