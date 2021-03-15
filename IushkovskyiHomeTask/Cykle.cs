using System;
using System.Collections.Generic;
using System.Text;

namespace IushkovskyiHomeTask
{
    public class Cykle
    {
        public static int FindAPowB(int a, int b)
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        public static double[] FindNumbersThatDividedByNFrom1to1000(double n)
        {
            if (n == 0)
            {
                throw new DivideByZeroException("n can't be equal to zero");
            }
            double x = Math.Abs(n);
            int length = Convert.ToInt32(Math.Floor(1000 / x));
            double[] array = new double[length];
            double temp = x;
            for (int i = 0; i < length; i++)
            {
                if (temp <= 1000)
                {
                    array[i] = temp;
                    temp += x;
                }
            }
            return array;
        }

        public static int FindQuantityOfNumbersWhichQuadrateIsLessThanN(double n)
        {
            int quantity;
            double root = Math.Sqrt(n);
            if (n < 0)
            {
                throw new ArgumentException("n can't be less than zero");
            }
            if (n == 0)
            {
                quantity = 0;
            }
            else if (root % 1 == 0)
            {
                quantity = Convert.ToInt32(root) - 1;
            }
            else
            {
                quantity = Convert.ToInt32(Math.Floor(root));
            }

            return quantity;
        }

        public static int FindTheGreatestDivisor(int a)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("a shouldn't be equal to zero");
            }
            int b = 0;
            int c = a / 2;
            while (b == 0)
            {
                if (a % c == 0)
                {
                    b = c;
                }
                c--;
            }
            return Math.Abs(b);
        }

        public static int GetSumOfDividersOf7FromAToB(double a, double b)
        {
            if (b < a)
            {
                Variables.SwapTwoDoubles(ref a, ref b);
            }

            int sum = 0;
            int start;
            if (Convert.ToInt32(a) % 1 > 0)
            {
                start = Convert.ToInt32(a) + 1;
            }
            else
            {
                start = Convert.ToInt32(a);
            }
            for (int i = start; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static int FindElementOfFibonacci(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("n can't be less than zero");
            }
            if (n == 0)
            {
                return 0;
            }
            int fib1 = 1;
            int fib2 = 1;
            for (int i = 0; i < n - 2; i++)
            {
                int fibSum = fib1 + fib2;
                fib1 = fib2;
                fib2 = fibSum;
            }

            return fib2;
        }

        public static int FindGreatestCommonDivisor(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        public static double FindQubicRoot(double a)
        {
            double absA = Math.Abs(a);
            double root = absA / 3;
            double max = absA;
            double delta = 0.1;
            double rootQube = root * root * root;

            while (rootQube < absA - delta || rootQube > absA + delta)
            {
                if (rootQube > absA + delta)
                {
                    max = root;
                    root /= 2;
                    rootQube = root * root * root;
                }
                else
                {
                    root = (root + max) / 2;
                    rootQube = root * root * root;
                }
            }
            if (a < 0)
            {
                root = 0 - root;
            }
            return root;
        }

        public static int CountOddDigitsOfNumber (int a)
        {
            a = Math.Abs(a);
            int b = a;
            int counter = 0;
            while (b != 0)
            {
                int c = b % 10;
                b /= 10;
                if (c % 2 != 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int FindMirrorNumber (int a)
        {
            if (a == 0)
            {
                return 0;
            }
            int b = Math.Abs(a);
            string result = "";
            while (b != 0)
            {
                int c = b % 10;
                result += Convert.ToString(c);
                b /= 10;
            }
            int resultNumber = Convert.ToInt32(result);
            if (a < 0)
            {
                resultNumber = 0 - resultNumber;
            }
            return resultNumber;
        }

        public static int[] FindNumbersFromZeroToAWithEvenDidgitsSumBiggerThanOddDidgitsSum (int a)
        {
            if (a < 12)
            {
                return new int[] { };
            }

            int counter = 0;
            for (int i = 12; i <= a; i++)
            {
                int oddsum = 0;
                int evensum = 0;
                int d = i;
                while (d != 0)
                {
                    int c = d % 10;
                    if (c % 2 == 0)
                    {
                        evensum += c;
                    }
                    else
                    {
                        oddsum += c;
                    }
                    d /= 10;
                }
                if (evensum > oddsum)
                {
                    counter++;
                }
            }
            int[] array = new int[counter];
            int index = 0;
            for (int i = 12; i <= a; i++)
            {
                int oddsum = 0;
                int evensum = 0;
                int d = i;

                while (d != 0)
                {
                    int c = d % 10;
                    if (c % 2 == 0)
                    {
                        evensum += c;
                    }
                    else
                    {
                        oddsum += c;
                    }
                    d /= 10;
                }
                if (evensum > oddsum)
                {
                    array[index] = i;
                    index++;
                }
            }
            return array;
        }

        public static bool FindIfNumbersHaveSameDigits (int a, int b)
        {
            int isDigit = 0;
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 && b == 0)
            {
                return true;
            } else if (a == 0)
            {
                while (b != 0)
                {
                    int b1 = b % 10;
                    if (b1 == 0)
                    {
                        return true;
                    }
                    b /= 10; 
                }
            }
            else if (b == 0)
            {
                while (a != 0)
                {
                    int a1 = a % 10;
                    if (a1 == 0)
                    {
                        return true;
                    }
                    a /= 10;
                }
            }
            while (a != 0)
            {
                int a1 = a % 10;
                int b1 = b;
                while (b1 != 0)
                {
                    int b122 = b1 % 10;
                    if (b122 == a1)
                    {
                        isDigit++;
                        break;
                    }
                    b1 /= 10;
                }
                a /= 10;
                if (isDigit > 0)
                {
                    break;
                }
            }
            if (isDigit > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
