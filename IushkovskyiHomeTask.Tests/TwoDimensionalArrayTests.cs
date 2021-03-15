using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace IushkovskyiHomeTask.Tests
{
    class TwoDimensionalArrayTests
    {
        [TestCase(1, new int[] { 2, 2 })]
        [TestCase(2, new int[] { 3, 1 })]
        public void FindIndexOfMaximumElementOfTDArray_WhenTDArrayPassed_ShouldReturnIntArray(int mockNumber, int[] expected)
        {

            int[,] arr = TwoDimensionalArrayMock.GetMock(mockNumber);


            int[] actual = TwoDimensionalArray.FindIndexOfMaximumElementOfTDArray(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, new int[] { 2, 1 })]
        [TestCase(2, new int[] { 2, 0 })]
        public void FindIndexOfMinimumElementOfTDArray_WhenTDArrayPassed_ShouldReturnIntArray(int mockNumber, int[] expected)
        {

            int[,] arr = TwoDimensionalArrayMock.GetMock(mockNumber);


            int[] actual = TwoDimensionalArray.FindIndexOfMinimumElementOfTDArray(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        [TestCase(2, 12)]
        public void FindMinimumElementOfTDArray_WhenTDArrayPassed_ShouldReturnInt(int mockNumber, int expected)
        {

            int[,] arr = TwoDimensionalArrayMock.GetMock(mockNumber);


            int actual = TwoDimensionalArray.FindMinimumElementOfTDArray(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 16)]
        [TestCase(2, 94)]
        public void FindMaximumElementOfTDArray_WhenTDArrayPassed_ShouldReturnInt(int mockNumber, int expected)
        {

            int[,] arr = TwoDimensionalArrayMock.GetMock(mockNumber);


            int actual = TwoDimensionalArray.FindMaximumElementOfTDArray(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 3)]
        [TestCase(2, 8)]
        public void FindHowManyElementsOfArrayAreBiggerThanTheirNeighbours_WhenTDArrayPassed_ShouldReturnInt(int mockNumber, int expected)
        {

            int[,] arr = TwoDimensionalArrayMock.GetMock(mockNumber);


            int actual = TwoDimensionalArray.FindHowManyElementsOfArrayAreBiggerThanTheirNeighbours(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 3)]
        [TestCase(2, 4)]
        public void TransposeArray_WhenTDArrayPassed_ShouldReturnTDArray(int mockNumber, int expectedMock)
        {

            int[,] arr = TwoDimensionalArrayMock.GetMock(mockNumber);


            int[,] actual = TwoDimensionalArray.TransposeArray(arr);
            int[,] expected = TwoDimensionalArrayMock.GetMock(expectedMock);

            Assert.AreEqual(expected, actual);
        }
    }
    public static class TwoDimensionalArrayMock
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];
            switch (number)
            {
                case 1:
                    result = new int[,]
                    {
                    {12,2,3},
                    {4,5,6},
                    {9,1,16}
                    };
                    break;
                case 2:
                    result = new int[,]
                    {
                    {42,50,53,48,89,24},
                    {86,65,45,82,27,66},
                    {12,57,85,57,79,93},
                    {67,94,52,14,16,57},
                    {38,18,14,87,54,43}
                    };
                    break;
                case 3:
                    result = new int[,]
                    {
                    {12,4,9},
                    {2,5,1},
                    {3,6,16}
                    };
                    break;
                case 4:
                    result = new int[,]
                    {
                    {42,86,12,67,38},
                    {50,65,57,94,18},
                    {53,45,85,52,14},
                    {48,82,57,14,87},
                    {89,27,79,16,54},
                    {24,66,93,57,43}
                    };
                    break;
            }

            return result;
        }
    }
}
