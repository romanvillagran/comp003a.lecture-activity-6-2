using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.lecture_activity_6_2
{
    class Shape
    {
        public virtual void DisplayArea()
        {
            Console.WriteLine("Calculating area of a shape.");
        }
    }

    class circle : Shape
    {
        public double Radius { get; set; }


        public circle(double radius)
        {
            Radius = radius;
        }

        public override void DisplayArea()
        {
            Console.WriteLine($"Circle Area: {Math.PI * Radius * Radius}");
        }
    }
    
    class Rectangle : Shape
    {
        public double Length { get; set; }

        public double Width { get; set; }


        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override void DisplayArea()
        {
            Console.WriteLine($"Rectangle Area: {Length * Width}");
        }
    }
}
