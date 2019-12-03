using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int aa = 18;
            int ret = factorTwoCount(aa);

            int factorTwoCount(int n)
            {
                int numberofDiv = 0;
               
                while (n>1)
                {
                    if (n%2==0)
                    {
                        numberofDiv++;
                        n = n / 2;
                    }
                    else
                    {
                        break;
                    }
                }
                return numberofDiv;
            }
        }
         
    }
}
