using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 22;

            int ret = isFibonacci(num);

            int isFibonacci(int n)
            {
                int tempVal = (5 * n * n) + 4;
                int tempVal2 = (5 * n * n) - 4;
                double val = Math.Sqrt(tempVal);
                double val2 = Math.Sqrt(tempVal2);
                if (val%1==0 || val2 % 1 == 0)
                {
                    return 1;
                }
                return 0;
            }


        }

    }
}
