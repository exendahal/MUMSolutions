using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int aa = 0;
            int[] arr = {8,8,8,8};
            bool ret = sumIsPower(arr);

            bool sumIsPower(int[] arr)
            {
                int sum = 0;
                for (int i=0;i<arr.Length;i++)
                {
                    sum = sum + arr[i];
                }

                if (sum==0)
                {
                    return true;
                }
                if (sum > 0)
                {
                    while (sum % 2 == 0)
                    {
                        sum /= 2;
                    }
                    if (sum == 1)
                    {
                        return true;
                    }
                }
                if (sum != 1)
                {
                    return false;
                }
                return true;
            }

           
        }
         
    }
}
