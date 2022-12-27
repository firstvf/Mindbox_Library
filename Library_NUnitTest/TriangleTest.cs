using NUnit.Framework;
using MindBox_Library;
using System;

namespace Nunit_Library_Test
{
    public class TriangleTest
    {
        public void SetUp(params double[] side)
        {
            var perimeter = (side[0] + side[1] + side[2]) / 2;
            var areaTriangle = Math.Sqrt(perimeter * (perimeter - side[0]) * (perimeter - side[1]) * (perimeter - side[2]));


            var triangle = new Triangle(side[0], side[1], side[2]);
            Assert.AreEqual(triangle.TriangleArea(), areaTriangle);
        }

        [Test]
        public void TestRandomThousandPositiveSides()
        {
            var random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                SetUp(random.Next(1,int.MaxValue),random.Next(1,int.MaxValue),random.Next(1,int.MaxValue));
            }
        }

        [Test]
        public void TestZeroSide()
        {
            SetUp(3, 4, 0);
        }

        [Test]
        public void TestNegativeSide()
        {
            SetUp(-2, 4, 1);
        }
    }
}
