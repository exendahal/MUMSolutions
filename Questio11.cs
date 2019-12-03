using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8,3,4};
            int ret = isMeera(array);

            int isMeera(int[] a)
            {
                for (int i=0;i<a.Length;i++)
                {
                    for (int j=0;j<a.Length;j++)
                    {
                        if (a[i]==(2*a[j]))
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
