using System;

namespace MindBox_Library
{
    public class Circle
    {
        public double Radius { get; private set; }

        /// <summary>
        /// Circle radius must be positive
        /// </summary>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new Exception("Circle radius must be positive");
            Radius = radius;
        }


        /// <summary>
        /// Returns circle area
        /// </summary>
        /// <returns></returns>
        public double CircleArea() => Math.PI * Math.Pow(Radius, 2);        
    }
}
