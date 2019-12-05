using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = -250;
            int secnum = 5;
            int ret = getExponent(num, secnum);

            int getExponent(int n, int p)
            {
                int count = 0;
                if (n<0)
                {
                    n = -n;
                }
                if (p <= 1)
                {
                    return -1;
                }

                while (n>1)
                {
                    if (n%p==0)
                    {
                        count++;
                        n = n / p;
                    }
                    else
                    {
                        break;
                    }
                }
                return count;
            }


        }

    }
}
