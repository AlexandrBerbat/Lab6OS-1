using System;

namespace Lab6OS
{
    class Program
    {
        static void Main(string[] args)
        {
            int param = func2(51, 110, 12);
            Console.WriteLine(param);

            int resultOfSum(int a, int b)
            {
                return a + b;
            }

            int func1(int a, int b)
            {
                int res = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (i > 8)
                    {
                        res = resultOfSum(a, b);
                    }
                    if (res > 0)
                    {
                        return res;
                    }
                }
                return res;
            }

            int func2(int a, int b, int c)
            {
                int res = 0;
                for (int i = 0; i < 10; i++)
                {
                    c++;
                    if (c > b)
                    {
                        res = func1(a, b);
                    }
                    else
                    {
                        res = func2(a, b, c);
                    }
                    if (res > 0)
                    {
                        return res;
                    }
                }
                return res;
            }
        }
    }
}
