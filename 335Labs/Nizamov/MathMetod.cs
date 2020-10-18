using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Transactions;

namespace _335Labs.Nizamov
{
    class MathMetod
    {
        public static double Okryjnost(double a)
        {
            double square = 3.14 * a * a;
            Console.WriteLine(square);
            return 0;
        }
        public static double dlinaokryj(double a)
        {

            double c = 2 * 3.14 * a;
            Console.WriteLine(c);
            return 0;
        }
        public static double pif(double a, double b)
        {
            double с = a * a + b * b;
            double d = Math.Sqrt(с);
            Console.WriteLine(d);
            return 0;
        }
        public static (double, double) diskrim(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            double result = 0;
            if (D >= 0)
            {

                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                return (x1, x2);
            }
            else
            {
                Console.WriteLine("Нет корней");
            }
            return (0, 0);
        }
        public static int divisioninterval(int a, int b, int c)
        {
            int result = 0;
            for (int i = a; i <= b; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                result = c / i;
                Console.WriteLine(result);
            }
            return 0;
        }
        public static double Obiemparrall(double s, double h)
        {
            double res = s * h;

            return res;
        }
        public static double soprotiv(double a, double b)
        {
            double r = a / b;
            return r;
        }
        public static double tok(double a, double b)
        {
            double i = a / b;
            return i;
        }
        public static double napryajenie(double a, double b)
        {
            double v = a * b;
            return v;
        }

    }

}
