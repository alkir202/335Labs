using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Nizamov
{
    class Sstring
    {
        public static string Ranzniestroki(string a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)
                {

                    Console.Write(a[i] + " ");
                }
                else if (i % 2 != 0)
                    Console.WriteLine(a[i]);

            }
            return " ";
        }

        public static string odderandevenodinaksimvoli(string a)
        {
            string odd = null;
            string even = null;

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 0)

                {
                    even += a[i];
                    Console.WriteLine(even);
                }
                else
                    odd += a[i];
                Console.WriteLine(odd);
            }
            return " ";
        }

        public static string palindrom(string a)
        {
            string res = null;
            a = a.Replace(" ", " ").ToLower();
            for (int i = 0; i < a.Length; i++)
            {
                res += a[a.Length - 1 - i];
            }
            if (a == res)
            {
                Console.WriteLine("+");
            }
            else
                Console.WriteLine("-");
            return " ";
        }

    }
}



