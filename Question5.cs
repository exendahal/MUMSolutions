using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] array= { 1,2,3,5, 9, 12,-2,-1};

            int [] ret= fill(array,3,10);

            int [] fill(int[] arr, int k, int n)
            {
                int[] newArray=new int[n];
                for(int i = 0; i <= (k-1); i++)
                {
                    newArray[i] = arr[i];
                }

                int[] tempArray = newArray;
                int a = 0;
                for (int j=(k);j<=n-1;j++)
                {
                    newArray[j] = tempArray[a];
                    if (a==k)
                    {
                        a = 0;
                    }
                    a++;
                }
                return newArray;
            }
            
        }
    }
}
