using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 13, 6, 3, 2 } ;
            int ret = isSub(a);
            int isSub(int[] a)
            {

                for (int i=0;i<a.Length;i++)
                {
                    int currentValue = a[i];

                    //Paxadi ko sum nikalne
                    int sum = 0;
                    for (int j=i+1;j<a.Length;j++)
                    {
                        sum = sum + a[j] ;
                    }

                    if (currentValue < sum)
                    {
                        return 0;
                    }
                                
                }
                return 1;

            }
        }
    }
}
