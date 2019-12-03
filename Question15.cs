using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int aa = 21;
            int[] arr = { 3, 4, 5, 7 };
            int ret = isNice(arr);

            int isNice(int[] a)
            {
                for (int i=0;i<a.Length;i++)
                {
                    int index1 = Array.IndexOf(a,(a[i]+1));                   
                    if (index1==-1 )
                    {
                        int index2 = Array.IndexOf(a, (a[i] - 1));
                        if (index2 == -1)
                        {
                            return 0;
                        }
                    }
                }
                return 1;
            }
        }
         
    }
}
