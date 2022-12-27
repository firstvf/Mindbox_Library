using NUnit.Framework;
using MindBox_Library;
using System;

namespace Nunit_Library_Test
{
    public class CircleTest
    {
        public void SetUp(double radiusTest) =>
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(new Circle(radiusTest).CircleArea(), Math.PI * Math.Pow(radiusTest, 2));

        [Test]
        public void TestRandomThousandPositiveRadiuses()
        {
            var random = new Random();
            Console.WriteLine(random);

            for (int i = 0; i < 1000; i++)
                SetUp(random.Next(1, int.MaxValue));
        }

        [Test]
        public void TestNegativeRadius()
        {
            SetUp(-1);
        }

        [Test]
        public void TestZeroRadius()
        {
            SetUp(0);
        }
    }
}