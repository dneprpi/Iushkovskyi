using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace IushkovskyiHomeTask.Tests
{
    class ArrayTests
    {
        [TestCase(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 28}, 10)]
        [TestCase(new double[] { 67, 53, 46, 42.8, 31, 27.8, 25, 14.4, 12, 8, 4, 0}, 0)]
        [TestCase(new double[] { 12,89,34,78,4.55,67,23.5,78}, 1)]
        [TestCase(new double[] { }, 0)]
        [TestCase(new double[] { 4 }, 0)]
        public void FindIndexOfMaximumElementOfArray_WhenDoubleArrayPassed_ShouldReturnInt(double[] array, int expected)
        {
            int actual = Array.FindIndexOfMaximumElement(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 28 }, 0)]
        [TestCase(new double[] { 67, 53, 46, 42.8, 31, 27.8, 25, 14.4, 12, 8, 4, 0 }, 11)]
        [TestCase(new double[] { 12, 89, 34, 78, 4.55, 67, 23.5, 78 }, 4)]
        [TestCase(new double[] { }, 0)]
        [TestCase(new double[] { 4 }, 0)]
        public void FindIndexOfMinimumElementOfArray_WhenDoubleArrayPassed_ShouldReturnInt(double[] array, int expected)
        {
            int actual = Array.FindIndexOfMinimumElement(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 28.5 }, 28.5)]
        [TestCase(new double[] { 67, 53, 46, 42.8, 31, 27.8, 25, 14.4, 12, 8, 4, 0 }, 67)]
        [TestCase(new double[] { 12, 89, 34, 89, 4.55, 67, 23.5, 78 }, 89)]
        [TestCase(new double[] { }, 0)]
        [TestCase(new double[] { 4 }, 4)]
        public void FindMaximumElementOfArray_WhenDoubleArrayPassed_ShouldReturnDouble(double[] array, double expected)
        {
            double actual = Array.FindMaximumElement(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 28 }, 1)]
        [TestCase(new double[] { 67, 53, 46, 42.8, 31, 27.8, 25, 14.4, 12, 8, 4, 0 }, 0)]
        [TestCase(new double[] { 12, 89, 34, 78, 4.55, 67, 23.5, 78 }, 4.55)]
        [TestCase(new double[] { }, 0)]
        [TestCase(new double[] { 4 }, 4)]
        public void FindMinimumElementOfArray_WhenDoubleArrayPassed_ShouldReturnDouble(double[] array, double expected)
        {
            double actual = Array.FindMinimumElement(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 28 }, 32)]
        [TestCase(new double[] { 67, 53, 46, 42.8, 31, 27.8, 25, 14.4, 12, 8, 4, 0 }, 146)]
        [TestCase(new double[] { 12, 89, 34, 78, 4.55, 67, 23.5, 78 }, 312)]
        [TestCase(new double[] { }, 0)]
        [TestCase(new double[] { 4 }, 0)]
        public void FindSumOfArrayElementsWithOddIndex_WhenDoubleArrayPassed_ShouldReturnDouble(double[] array, double expected)
        {
            double actual = Array.FindSumOfArrayElementsWithOddIndex(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 28 }, new int[] { 28, 12, 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 67, 53, 46, 42, 31, 27, 25, 14, 12, 8, 4, 0 }, new int[] { 0, 4, 8, 12, 14, 25, 27, 31, 42, 46, 53, 67 })]
        [TestCase(new int[] { 12, 89, 34, 78, 4, 67, 23, 78 }, new int[] { 78, 23, 67, 4, 78, 34, 89, 12 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 4 }, new int[] { 4 })]
        public void GetArrayReversed_WhenIntArrayPassed_ShouldReturnReversedArray(int[] array, int[] expected)
        {
            int[] actual = Array.GetArrayReversed(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 28 }, 5)]
        [TestCase(new int[] { 67, 53, 46, 42, 31, 27, 25, 14, 12, 8, 4, 0 }, 5)]
        [TestCase(new int[] { 12, 89, 34, 78, 4, 67, 23, 78 }, 3)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 4 }, 0)]
        public void FindHowManyOddElementsInArray_WhenIntArrayPassed_ShouldReturnInt(int[] array, int expected)
        {
            int actual = Array.FindHowManyOddElementsInArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 28 }, new int[] { 7, 8, 9, 12, 28, 6, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 67, 53, 46, 42, 31, 27, 25, 14, 12, 8, 4, 0 }, new int[] {25, 14, 12, 8, 4, 0, 67, 53, 46, 42, 31, 27 })]
        [TestCase(new int[] { 12, 89, 34, 78, 4, 67, 23, 78 }, new int[] { 4, 67, 23, 78, 12, 89, 34, 78 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 4 }, new int[] { 4 })]
        public void SwapFirstAndSecondHalfOfArray_WhenIntArrayPassed_ShouldReturnSwapedArray(int[] array, int[] expected)
        {
            int[] actual = Array.SwapFirstAndSecondHalfOfArray(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 28 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 28 })]
        [TestCase(new int[] { 67, 53, 46, 42, 31, 27, 25, 14, 12, 8, 4, 0 }, new int[] { 0, 4, 8, 12, 14, 25, 27, 31, 42, 46, 53, 67 })]
        [TestCase(new int[] { 12, 89, 34, 78, 4, 67, 23, 78 }, new int[] { 4, 12, 23, 34, 67, 78, 78, 89   })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 4 }, new int[] { 4 })]
        public void SortBubbleAscending_WhenIntArrayPassed_ShouldReturnSortedArray(int[] array, int[] expected)
        {
            int[] actual = Array.SortBubbleAscending(array);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 28 }, new int[] { 28, 12, 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 67, 53, 46, 42, 31, 27, 25, 14, 12, 8, 4, 0 }, new int[] { 67, 53, 46, 42, 31, 27, 25, 14, 12, 8, 4, 0 })]
        [TestCase(new int[] { 12, 89, 34, 78, 4, 67, 23, 78 }, new int[] { 89, 78, 78, 67, 34, 23, 12, 4 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 4 }, new int[] { 4 })]
        public void SortInsertionDescending_WhenIntArrayPassed_ShouldReturnSortedArray(int[] array, int[] expected)
        {
            int[] actual = Array.SortInsertionDescending(array);

            Assert.AreEqual(expected, actual);
        }
    }
}
