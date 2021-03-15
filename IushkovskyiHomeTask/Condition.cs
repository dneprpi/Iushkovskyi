using System;
using System.Collections.Generic;
using System.Text;

namespace IushkovskyiHomeTask
{
    public class Condition
    {
        public static double FindEquationWithCondition(double a, double b)
        {
            double result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a < b)
            {
                result = a - b;
            }
            else
            {
                result = a * b;
            }

            return result;
        }

        public static int FindQuarterOfCoordinateSystem(double x, double y)
        {
            int quarter = 0;
            if (x == 0 || y == 0)
            {
                quarter = 0;
            }
            else if (x > 0)
            {
                if (y > 0)
                {
                    quarter = 1;
                }
                else
                {
                    quarter = 4;
                }
            }
            else if (y > 0)
            {
                quarter = 2;
            }
            else
            {
                quarter = 3;
            }

            return quarter;
        }

        public static void SortThreeDoubles(ref double a, ref double b, ref double c)
        {
            if (a > c)
            {
                Variables.SwapTwoDoubles(ref a, ref c);
            }
            if (a > b)
            {
                Variables.SwapTwoDoubles(ref a, ref b);
            }
            if (b > c)
            {
                Variables.SwapTwoDoubles(ref b, ref c);
            }
        }

        public static double[] SolveQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("a can't be equal to zero");
            }

            double discriminant = FindDiscriminant(a, b, c);

            if (discriminant < 0)
            {
                double[] array = new double[] { };
                return array;
            }
            else if (discriminant == 0)
            {
                double x = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double[] array = new double[] { x };
                return array;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                double[] array = new double[] { x1, x2 };
                return array;
            }
        }

        public static string GetStringFromTwoDigitsInt(int x)
        {
            int a = Math.Abs(x / 10);
            int b = Math.Abs(x % 10);
            string result = String.Empty;
            string dozens = String.Empty;
            string units = String.Empty;
            if (x < 0)
            {
                result += "минус ";
            }
            if (a < 2)
            {
                switch (b)
                {
                    case 1:
                        result += "одинадцать";
                        break;
                    case 2:
                        result += "двенадцать";
                        break;
                    case 3:
                        result += "тринадцать";
                        break;
                    case 4:
                        result += "четырнадцать";
                        break;
                    case 5:
                        result += "пятнадцать";
                        break;
                    case 6:
                        result += "шестнадцать";
                        break;
                    case 7:
                        result += "семнадцать";
                        break;
                    case 8:
                        result += "восемнадцать";
                        break;
                    case 9:
                        result += "девятнадцать";
                        break;
                    case 0:
                        result += "десять";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (a)
                {
                    case 2:
                        dozens = "двадцать";
                        break;
                    case 3:
                        dozens = "тридцать";
                        break;
                    case 4:
                        dozens = "сорок";
                        break;
                    case 5:
                        dozens = "пятьдесят";
                        break;
                    case 6:
                        dozens = "шестьдесят";
                        break;
                    case 7:
                        dozens = "семьдесят";
                        break;
                    case 8:
                        dozens = "восемьдесят";
                        break;
                    case 9:
                        dozens = "девяносто";
                        break;
                }
                switch (b)
                {
                    case 1:
                        units = " один";
                        break;
                    case 2:
                        units = " два";
                        break;
                    case 3:
                        units = " три";
                        break;
                    case 4:
                        units = " четыре";
                        break;
                    case 5:
                        units = " пять";
                        break;
                    case 6:
                        units = " шесть";
                        break;
                    case 7:
                        units = " семь";
                        break;
                    case 8:
                        units = " восемь";
                        break;
                    case 9:
                        units = " девять";
                        break;
                    case 0:
                        units = "";
                        break;
                }
                result += dozens;
                result += units;
            };
            return result;
        }
        private static double FindDiscriminant(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
    }
}
