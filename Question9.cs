using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 9, 8, 7, 13, 14, 17 };
            int ret = isSym(a);
            
            int isSym(int[] a)
            {
                int len = a.Length;
                int[] forwardArray= new int[a.Length];
                int[] reverseArray =new int[a.Length];
                for (int i=0;i< len; i++)
                {
                    if (a[i]%2==0)
                    {
                        forwardArray[i] = 1;
                    }
                    else
                    {
                        forwardArray[i] = 0;
                    }
                }
                int index = 0;
                for (int j = (len-1); j >= 0; j--)
                {
                    
                    if (a[j] % 2 == 0)
                    {
                        reverseArray[index] = 1;
                    }
                    else
                    {
                        reverseArray[index] = 0;
                    }
                    index++;
                }

                for (int k=0;k< forwardArray.Length;k++)
                {
                    if (forwardArray[k]!= reverseArray[k])
                    {
                        return 0;
                    }
                }

                return 1;
            }


         }
    }
}
