using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace IushkovskyiHomeTask.Tests
{
    class CykleTests
    {
        [TestCase(5, 2, 25)]
        [TestCase(-10, 4, 10000)]
        [TestCase(-3, 3, -27)]
        [TestCase(0, 0, 1)]
        [TestCase(2, 30, 1073741824)]
        public void FindAPowB_WhenABPassed_ShouldReturnAToPowB(int a, int b, int expected)
        {
            int actual = Cykle.FindAPowB(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(200, new double[] {200, 400, 600, 800, 1000})]
        [TestCase(300, new double[] {300, 600, 900})]
        [TestCase(250.5, new double[] {250.5, 501, 751.5})]
        [TestCase(-400, new double[] {400, 800})]
        [TestCase(600, new double[] {600})]
        public void FindNumbersThatDividedByNto1000_WhenNPassed_ShouldReurnArray(double n, double[] expected)
        {
            double[] actual = Cykle.FindNumbersThatDividedByNFrom1to1000(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, 9)]
        [TestCase(81.5, 9)]
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(63.5, 7)]
        public void FindQuantityOfNumbersWhichQuadrateIsLessThanN_WhenPositiveDoublePassed_ShouldReturnInt(double n, int expected)
        {
            int actual = Cykle.FindQuantityOfNumbersWhichQuadrateIsLessThanN(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-100)]
        [TestCase(-81.5)]
        [TestCase(-0.5)]
        [TestCase(-1)]
        [TestCase(-1663.5)]
        public void FindQuantityOfNumbersWhichQuadrateIsLessThanN_WhenNegativeDoublePassed_ShouldReturnArgumentException(double n)
        {
            Assert.Throws<ArgumentException>(() => Cykle.FindQuantityOfNumbersWhichQuadrateIsLessThanN(n));
        }

        [TestCase(100, 50)]
        [TestCase(102, 51)]
        [TestCase(-10, 5)]
        [TestCase(101, 1)]
        [TestCase(-50, 25)]
        public void FindTheGreatestDivisor_WhenIntPassed_ShoulReturnInt(int a, int expected)
        {
            int actual = Cykle.FindTheGreatestDivisor(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void FindTheGreatestDivisor_WhenZeroPassed_ShoulReturnDivideByZeroExceprion(int a)
        {
            Assert.Throws<DivideByZeroException>(() => Cykle.FindTheGreatestDivisor(a));
        }

        [TestCase(5,8, 7)]
        [TestCase(0, 0, 0)]
        [TestCase(3.5, 21.5, 42)]
        [TestCase(-8, 14.5, 14)]
        [TestCase(-50, 50, 0)]
        public void GetSumOfDividersOf7FromAToB_WhenABPassed_ShouldReturnInt(double a, double b, int expected)
        {
            int actual = Cykle.GetSumOfDividersOf7FromAToB(a,b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(20, 6765)]
        public void FindElementOfFibonacci_WhenIntPassed_ShouldReturnInt(int n, int expected)
        {
            int actual = Cykle.FindElementOfFibonacci(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-100)]
        [TestCase(-81)]
        [TestCase(-5)]
        [TestCase(-1)]
        [TestCase(-1663)]
        public void FindElementOfFibonacci_WhenNegativeIntPassed_ShouldReturnArgumentException(int n)
        {
            Assert.Throws<ArgumentException>(() => Cykle.FindElementOfFibonacci(n));
        }

        [TestCase(33, 22, 11)]
        [TestCase(-44, 22, 22)]
        [TestCase(120, -80, 40)]
        [TestCase(0, 0, 0)]
        [TestCase(-150, -90, 30)]
        public void FindGreatestCommonDivisor_WhenIntABPassed_ShouldReurnInt(int a, int b, int expected)
        {
            int actual = Cykle.FindGreatestCommonDivisor(a,b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(27, 3)]
        [TestCase(166.375, 5.5)]
        [TestCase(0, 0)]
        [TestCase(-27, -3)]
        [TestCase(3.375, 1.5)]
        public void FindQubicRoot_WhenDoublePassed_ShouldReturnDouble(double a, double expected)
        {
            double actual = Cykle.FindQubicRoot(a);

            Assert.AreEqual(expected, actual, 0.1d);
        }

        [TestCase(13576, 4)]
        [TestCase(0, 0)]
        [TestCase(64822, 0)]
        [TestCase(175113, 6)]
        [TestCase(-2010, 1)]
        public void CountOddDigitsOfNumber_WhenIntPassed_ShouldReturnInt(int a, int expected)
        {
            int actual = Cykle.CountOddDigitsOfNumber(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-13576, -67531)]
        [TestCase(0, 0)]
        [TestCase(64822, 22846)]
        [TestCase(175113, 311571)]
        [TestCase(2010, 102)]
        public void FindMirrorNumber_WhenIntPassed_ShouldReturnInt(int a, int expected)
        {
            int actual = Cykle.FindMirrorNumber(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(18, new int[] { 12, 14, 16, 18})]
        [TestCase(12, new int[] { 12 })]
        [TestCase(10, new int[] { })]
        [TestCase(0, new int[] { })]
        [TestCase(-50, new int[] { })]
        public void FindNumbersFromZeroToAWithEvenDidgitsSumBiggerThanOddDidgitsSum_WhenIntPassed_ShouldReturnArray(int a, int[] expected)
        {
            int[] actual = Cykle.FindNumbersFromZeroToAWithEvenDidgitsSumBiggerThanOddDidgitsSum(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(33, 22, false)]
        [TestCase(-44, 24, true)]
        [TestCase(0, 50, true)]
        [TestCase(10, 54, false)]
        [TestCase(-150, -91, true)]
        [TestCase(0, 0, true)]
        [TestCase(-150, 0, true)]
        public void FindIfNumbersHaveSameDigits(int a, int b, bool expected)
        {
            bool actual = Cykle.FindIfNumbersHaveSameDigits(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
