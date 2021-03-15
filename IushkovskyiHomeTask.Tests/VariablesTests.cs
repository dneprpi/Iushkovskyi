using NUnit.Framework;

namespace IushkovskyiHomeTask.Tests
{
    public class Tests
    {
        [TestCase(10, 5, -15)]
        [TestCase(8, -5, -5)]
        [TestCase(10.5, 5.5, -16.55)]
        [TestCase(101, 100, -10505)]
        [TestCase(-5, -6, -11)]
        public void GetResultOfEquation_WhenDifferentABPassed_ShouldReturn5APlusBSquareDivideByBMinusA(double a, double b, double expected)
        {
            double actual = Variables.GetResultOfEquation(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 2, 1)]
        [TestCase(0, 0, 0, 0)]
        [TestCase(21, -50, -50, 21)]
        [TestCase(25.5, 5.5, 5.5, 25.5)]
        [TestCase(0, 8, 8, 0)]
        public void SwapTwoDoublesTests(double a, double b, double expectedA, double expectedB)
        {
            Variables.SwapTwoDoubles(ref a, ref b);
            double actualA = a;
            double actualB = b;

            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        [TestCase(5, 5, new int[] { 1, 0 })]
        [TestCase(10, 5, new int[] { 2, 0 })]
        [TestCase(21, 4, new int[] { 5, 1 })]
        [TestCase(1503, 1663, new int[] { 0, 1503 })]
        [TestCase(1503, 183, new int[] { 8, 39 })]
        public void DivideAndRemainderTests(int a, int b, int[] expected)
        {
            int[] actual = Variables.DivideAndRemainder(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, 1)]
        [TestCase(1, 2, 0, -2)]
        [TestCase(21, -50, -50, 0)]
        [TestCase(2, 4.5, 5.5, 0.5)]
        [TestCase(-2, 8, 10, -1)]
        public void SolveLinearEquationTests(double a, double b, double c, double expected)
        {
            double actual = Variables.SolveLinearEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 2, 2, new double[] { 1, 0 })]
        [TestCase(0, 2, 1, -1, new double[] { -3, 2 })]

        public void DisplayLineEquationTests(double x1, double y1, double x2, double y2, double[] expected)
        {
            double[] actual = Variables.DisplayLineEquation(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }


    }
}