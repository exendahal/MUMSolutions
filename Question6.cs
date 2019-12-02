using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a= { 1,2,3,4,0,0,0,0,4,5,6,7};

            int ret = isHollow(a);

            int isHollow(int[] a)
            {
                int len = a.Length;
                if (a.Length % 3 != 0)
                {
                        return 0;
                    
                }
                for (int i=0;i<=(a.Length/3)-1; i++)
                {
                    if (a[i]==0)
                    {
                        return 0;
                    }
                }
                for (int j= (a.Length/3)+1;j<=(2*(a.Length/3))-1;j++)
                {
                    if (a[j] != 0)
                    {
                        return 0;
                    }
                }

                for (int k = 2 * (a.Length / 3) + 1; k <= a.Length-1; k++)
                {
                    if (a[k] == 0)
                    {
                        return 0;
                    }
                }
                return 1;

            }
            
        }
    }
}
