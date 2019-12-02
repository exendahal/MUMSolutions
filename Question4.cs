using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -2, 2, 2, 2 };
            int ret = isBalanced(array);
            int isBalanced(int[] a)
            {
                for (int i=0;i<a.Length;i++)
                {
                    int current = a[i];
                    for (int j=0;j<a.Length;j++)
                    {
                        int index = Array.IndexOf(a,(-1)*current);
                        if (index<0)
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
