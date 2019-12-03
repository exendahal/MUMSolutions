using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int aa = 1001;
            int[] arr = {4, 11, 12, 1, 6};
            int ret = isWave(arr);
            int isWave(int[] a)
            {
                for (int i=0;i<(a.Length-1);i++)
                {
                    if (a[i]%2==0 && a[i+1]%2==0)
                    {
                        return 0;
                    }
                    else if(a[i] % 2 != 0 && a[i + 1] % 2 != 0)
                    {
                        return 0;
                    }
                }

                return 1;
            }
        }
         
    }
}
