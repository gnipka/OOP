using System;

namespace Intro_OOP_lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle() { Color = Color.White, Radius = 3, Status = Status.Visible };
            var rectangle = new Rectangle() { Color = Color.Black, Status = Status.Invisible, Lenght = 2, Width = 5.5 };

            circle.AddCoordinate(5, 4);
            circle.HorizontalMovement(-3);
            circle.VerticalMovement(2.5);
            circle.Area();

            rectangle.AddCoordinate(2, 8);
            rectangle.HorizontalMovement(2.5);
            rectangle.VerticalMovement(2);
            rectangle.Area();
        }
    }
}
