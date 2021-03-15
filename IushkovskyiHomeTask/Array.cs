using System;
using System.Collections.Generic;
using System.Text;

namespace IushkovskyiHomeTask
{
    public class Array
    {
        public static int FindIndexOfMaximumElement(double[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            double max = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; ++i)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            return index;
        }

        public static int FindIndexOfMinimumElement(double[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            double min = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }

        public static double FindMaximumElement(double[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            return array[FindIndexOfMaximumElement(array)];
        }

        public static double FindMinimumElement(double[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            return array[FindIndexOfMinimumElement(array)];
        }

        public static double FindSumOfArrayElementsWithOddIndex(double[] array)
        {
            double sum = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int[] GetArrayReversed(int[] array)
        {
            if (array.Length == 0)
            {
                return new int[] { };
            }
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            return array;
        }

        public static int FindHowManyOddElementsInArray(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static int[] SwapFirstAndSecondHalfOfArray(int[] array)
        {
            if (array.Length % 2 == 0)
            {
                for (int i = 0; i < array.Length / 2; ++i)
                {
                    int temp = array[i];
                    array[i] = array[array.Length / 2 + i];
                    array[array.Length / 2 + i] = temp;
                }
            }
            else
            {
                for (int i = 0; i < array.Length / 2; ++i)
                {
                    int temp = array[i];
                    array[i] = array[array.Length / 2 + 1 + i];
                    array[array.Length / 2 + 1 + i] = temp;
                }
            }
            return array;
        }

        public static int[] SortBubbleAscending(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public static int[] SortInsertionDescending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int newElement = array[i];
                int index = i - 1;
                while (index >= 0 && array[index] < newElement)
                {
                    array[index + 1] = array[index];
                    index = index - 1;
                }
                array[index + 1] = newElement;
            }
            return array;
        }
    }
}
