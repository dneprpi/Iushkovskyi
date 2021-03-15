using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace IushkovskyiHomeTask.Tests
{
    class ConditionTests
    {
        [TestCase(5, 4, 9)]
        [TestCase(4, 5, -1)]
        [TestCase(3.5, 3.5, 12.25)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, -6, -11)]
        public void GetResultOfEquation_WhenABPassed_ShouldReturnAPlusBOrAMinusBOrAMultB(double a, double b, double expected)
        {
            double actual = Condition.FindEquationWithCondition(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 4, 1)]
        [TestCase(4, -5, 4)]
        [TestCase(-3.5, 3.5, 2)]
        [TestCase(5, 0, 0)]
        [TestCase(-5, -6, 3)]
        public void FindQuarterOfCoordinateSystem_WhenXYPassed_ShouldReturnInt(double x, double y, int expected)
        {
            int actual = Condition.FindQuarterOfCoordinateSystem(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 4, 9, 4, 5, 9)]
        [TestCase(4, 5, -1, -1, 4, 5)]
        [TestCase(3.5, 3.55, 3.25, 3.25, 3.5, 3.55)]
        [TestCase(0, 0, 0, 0, 0, 0)]
        [TestCase(-5, -4.5, 11, -5, -4.5, 11)]
        public void SortThreeDoubles_WhenABCPassed_ShouldSortThem(double a, double b, double c, double expectedA, double expectedB, double expectedC)
        {
            Condition.SortThreeDoubles(ref a, ref b, ref c);
            double actualA = a;
            double actualB = b;
            double actualC = c;

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
            Assert.AreEqual(expectedC, actualC);
        }

        [TestCase(2, 5, -3, new double[] {0.5, -3})]
        [TestCase(4, 21, 5, new double[] { -0.25, -5 })]
        [TestCase(5, 0, 0, new double[] { 0 })]
        [TestCase(4, 0, 36, new double[] { })]
        [TestCase(-4, 28, -49, new double[] {3.5})]
        public void SolveQuadraticEquation_WhenABCPassed_ShouldReturnArrayWithX(double a, double b, double c, double[] expected)
        {
            double[] actual = Condition.SolveQuadraticEquation(a, b, c);
            
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5, -3)]
        [TestCase(0, 21, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 0, 36)]
        [TestCase(0, 28, -49)]
        public void SolveQuadraticEquation_WhenAEqualZeroPassed_ShouldReturnDivideByZeroException(double a, double b, double c)
        {
            Assert.Throws<DivideByZeroException>(()=>Condition.SolveQuadraticEquation(a,b,c));
        }

        [TestCase(21, "двадцать один")]
        [TestCase(-42, "минус сорок два")]
        [TestCase(99, "девяносто девять")]
        [TestCase(12, "двенадцать")]
        [TestCase(80, "восемьдесят")]
        public void GetStringFromTwoDigitsInt_WhenTwoDigitsIntPassed_ShouldReturnString(int x, string expected)
        {
            string actual = Condition.GetStringFromTwoDigitsInt(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
