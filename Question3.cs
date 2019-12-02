using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array= { 3,2,2,7,7 }; 
            int ret=isTwinoid (array);
            int isTwinoid(int[] a)
            {
                int count=0;
                for (int i = 0; i < (a.Length) - 1; i++) {
                    if (checkEven(a[i])==1)
                    {
                        count++;
                    }
                }
                if (count==2) {
                    for (int i = 0; i < (a.Length) - 1; i++)
                    {
                        int IsEven = checkEven(a[i]);
                        int IsEven_con = checkEven(a[i + 1]);
                        if (IsEven == 1 && IsEven_con == 1)
                        {
                            return 1;
                        }

                    }
                }
               
                return 0;
            }

            int checkEven(int val)
            {
                if (val%2==0) {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

        }
    }
}
