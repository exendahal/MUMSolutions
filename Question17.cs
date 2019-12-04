using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int aa = -3333531;
            int ret = countDigit(aa,3);
            int countDigit(int n, int digit)
            {
                int count = 0;
                int number = n;
                if (n<0)
                {
                    n = -n;
                }
                while (n>1)
                {
                    if (n % 10 == digit)
                    {
                        count++;
                    }
                    n=n / 10;
                }
                if (number<0)
                {
                    return -count;
                }
                else
                {
                    return count;
                }
               
            }
        }
         
    }
}
