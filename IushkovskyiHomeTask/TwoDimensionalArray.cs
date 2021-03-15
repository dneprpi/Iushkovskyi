using System;
using System.Collections.Generic;
using System.Text;

namespace IushkovskyiHomeTask
{
    public class TwoDimensionalArray
    {
        public static int[,] CreateAndFillTwoDimensArray(int a, int b)
        {
            int[,] array = new int[a, b];
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10, 100);
                }
            }
            return array;
        }
        public static void PrintTwoDimensArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine(String.Empty);
            }
        }

        public static int[] FindIndexOfMinimumElementOfTDArray(int[,] array)
        {
            int[] index = new int[2];
            int min = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
            return index;
        }

        public static int[] FindIndexOfMaximumElementOfTDArray(int[,] array)
        {
            int[] index = new int[2];
            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        index[0] = i;
                        index[1] = j;
                    }
                }
            }
            return index;
        }

        public static int FindMinimumElementOfTDArray(int[,] array)
        {
            int[] indexMin = FindIndexOfMinimumElementOfTDArray(array);
            return array[indexMin[0], indexMin[1]];
        }

        public static int FindMaximumElementOfTDArray(int[,] array)
        {
            int[] indexMax = FindIndexOfMaximumElementOfTDArray(array);
            return array[indexMax[0], indexMax[1]];
        }

        public static int FindHowManyElementsOfArrayAreBiggerThanTheirNeighbours(int[,] array)
        {
            int counter = 0;
            int right = array.GetLength(0) - 1;
            int down = array.GetLength(1) - 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i<=0 || array[i,j] > array[i-1,j])
                        && (j<=0 || array[i,j] > array[i, j-1])
                        && (i>= right || array[i,j] > array[i+1,j])
                        && (j >= down || array[i,j] > array[i, j+1]))
                        {
                        counter++;
                    }
                }
            }
            return counter;
        }


        public static int[,] TransposeArray (int[,] array)
        {
            int m = array.GetLength(0);
            int n = array.GetLength(1);

            if (m == n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        int temp = array[i, j];
                        array[i, j] = array[j, i];
                        array[j, i] = temp;
                    }
                }
                return array;
            }
            else
            {
                int[,] arrayTrans = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        arrayTrans[i, j] = array[j, i];
                    }
                }
                return arrayTrans;
            }
        }
    }
}
