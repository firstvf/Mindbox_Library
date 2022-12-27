using System;

namespace MindBox_Library
{
    public class Triangle
    {
        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }


        ///<summary>
        ///Triangle sides must be positive
        ///</summary>        
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new Exception("Triangle sides must be positive");
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        /// <summary>
        /// Returns triangle area
        /// </summary>
        /// <returns></returns>
        public double TriangleArea()
        {
            var perimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(perimeter * (perimeter - FirstSide) * (perimeter - SecondSide) * (perimeter - ThirdSide));
        }

        /// <summary>
        /// Returns true if this triangle right, otherwise false
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            var maxValue = double.MinValue;
            var sidesArray = new double[] { FirstSide, SecondSide, ThirdSide };
            double sumOfLegs = 0;

            for (int i = 0; i < sidesArray.Length; i++)
                if (sidesArray[i] > maxValue)
                    maxValue = sidesArray[i];

            for (int i = 0; i < sidesArray.Length; i++)
                if (maxValue > sidesArray[i])
                    sumOfLegs += Math.Pow(sidesArray[i], 2);

            return Math.Pow(maxValue, 2) == sumOfLegs;
        }
    }
}