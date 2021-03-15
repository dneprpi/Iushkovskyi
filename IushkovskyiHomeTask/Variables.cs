using System;
using System.Collections.Generic;
using System.Text;

namespace IushkovskyiHomeTask
{
    public class Variables
    {
        public static double GetResultOfEquation(double a, double b)
        {
            if (b == a)
            {
                throw new Exception("b can't be equal to a");
            }
            return (5 * a + b * b) / (b - a);
        }

        public static void SwapTwoDoubles (ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public static int[] DivideAndRemainder (int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("b can't be equal to zero");
            }
            int[] array = new int[2];
            array[0] = a / b;
            array[1] = a % b;

            return array;
        }

        public static double SolveLinearEquation (double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("a can't be equal to zero");
            }
            return (c - b) / a;
        }

        public static double[] DisplayLineEquation (double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new Exception("x1 can't be equal to x2");
            }
            double[] array = FindConstants(x1, y1, x2, y2);
            double a = array[0];
            double b = array[1];
            double[] resultAandB = new double[] { a, b };

            return resultAandB;
        }

        private static double[] FindConstants (double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new Exception("x1 can't be equal to x2");
            }
            
            double a = (y2 - y1) / (x2 - x1);
            double b = y1 - (y2 - y1) / (x2 - x1) * x1;

            double[] array = new double[2];
            array[0] = a;
            array[1] = b;

            return array;
        }

       
    }
}
