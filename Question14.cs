using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int aa = 21;
            int ret = isMeera(aa);
            int isMeera(int n)
            {
                int numberOfFactors = 0;
                for (int i=2;i<=n/2;i++)
                {
                    if (n%i==0)
                    {
                        numberOfFactors++;
                    }
                }
                if (n%numberOfFactors!=0)
                {
                    return 0;
                }
                return 1;

            }


        }
         
    }
}
