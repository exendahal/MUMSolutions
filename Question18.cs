using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = { 7, 6, 10, 5 };
            int ret = isBunker(arr);
            int isBunker(int[] a)
            {
                if (Array.IndexOf(a, 1) == -1)
                {
                    return 0;
                }
                else
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (IsPrime(a[i])==1)
                        {
                            return 1;
                        }
                    }
                }
                
                return 1;
            }

            int IsPrime(int num)
            {
                for (int i=2;i<=num/2;i++)
                {
                    if (num%i==0)
                    {
                        return 0;
                    }
                }
                return 1;
            }
        }
         
    }
}
