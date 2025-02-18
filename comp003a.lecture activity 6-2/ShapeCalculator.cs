using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp003a.lecture_activity_6_2
{
    class ShapeCalculator
    {
        /// <summary>
        /// calculates the area od a rectangle
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        /// <summary>
        /// calcuates the area of a triangle
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public double CalculateArea(double length, double width)
        {
            return length * width;
        }


        public double CalculateArea(double baseLength, double height, bool isTriangle)
        {
            return 0.5 * baseLength * height;
        }
    }
}
