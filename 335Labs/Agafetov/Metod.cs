using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _335Labs.Agafetov
{
    class Metod
    {
                public static double PloshadOkruzhnosti(double a)
                {
                    double s = 3.14 * a * a;
                    Console.WriteLine(s);
                    return 0;
                }
                public static double dlinaokruzhnosti(double a)
                {

                    double l = 2 * 3.14 * a;
                    Console.WriteLine(l);
                    return 0;
                }

                public static double teoremaPif(double a, double b)
                {
                    double c = a * a + b * b;
                    double d = Math.Sqrt(c);
                    Console.WriteLine(d);
                    return 0;
                }

                public static (double, double) discriminant(double a, double b, double c)
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
                        Console.WriteLine($"no Sqrt");
                    }
                    return (0, 0);
                }
    
                public static double silatoka(double a, double b)
                {
                    double i = a / b;
                    return i;


                }
                public static double soprotivlenie(double a, double b)
                {
                    double r = a / b;
                    return r;
                }
                public static double napryazhenie(double a, double b)
                {
                    double v = a * b;
                    return v;
                }
            }
}


