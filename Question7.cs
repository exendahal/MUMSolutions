using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 100, 19, 131, 140 };
            int ret = isEvenSpaced(a);

            int  isEvenSpaced(int[] a){

                int length = a.Length;
                if (length<2)
                {
                    return 0;
                }
                int maxNum=0;
                int minNum=0;
                minNum = maxNum = a[0];
                for (int i=0;i<=length-1;i++)
                {
                    if (a[i]>maxNum)
                    {
                         maxNum= a[i];
                    }

                    if (a[i] < minNum)
                    {
                        minNum = a[i];
                    }
                }
                if ((maxNum-minNum)%2!=0)
                {
                    return 0;
                }

                return 1;
            }
        }
    }
}
