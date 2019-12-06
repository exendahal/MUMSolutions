using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 8, 7, 13, 14, 17 };

              int vvv = goodSpread(arr);

            int goodSpread(int[] a)
            {
                for (int i = 0, j = a.Length - 1; i < j; i++, j--)
                {
                    if ((a[i] % 2 == 0 && a[j] % 2 != 0) || (a[i] % 2 == 1 && a[j] % 2 != 1))
                    {
                        return 0;
                    }
                    
                }
                return 1;

            }

        }
    }
}