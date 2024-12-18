using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckFermat();
        }

        static void CheckFermat()
        {

            for (int n = 1; n < 4; n++)
            {
                for (int a = 1; a < 10; a++)
                {
                    for (int b = 1; b < 10; b++)
                    {
                        for (int c = 1; c  10; c++)
                        {
                            if (CheckFermat(a, b, c, n))
                            {
                                Console.WriteLine($"{a}^{n} + {b}^{n} = {c}^{n} - Решение найдено");
                            }
                        }
                    }
                }
            }
        }

        static bool CheckFermat(int a, int b, int c, int n)
        {
            return Math.Pow(a, n) + Math.Pow(b, n) == Math.Pow(c, n);
        }
    }
}
