using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int aa = 1001;
            int[] arr = { 1, 7, 11, 13, 77, 91, 143,1001};
            int ret = minDistance(aa);
            int minDistance(int num)
            {
                
                int index = 0;
                for (int k=1;k<=num;k++)
                {
                    if (num%k==0)
                    {
                        index++;
                    }
                }
                int[] n = new int[index];
                int tempInd = 0;
                for (int k = 1; k <= num; k++)
                {
                    if (num % k == 0)
                    {
                        n[tempInd] =k;
                        tempInd++;
                    }
                }

                int distance = n[n.Length-1];

                for (int i= 0; i<n.Length-1;i++)
                {
                    for (int j=i+1;j<n.Length;j++)
                    {
                        int temp = -(n[i] - n[j]);
                        if (temp< distance)
                        {
                            distance = temp;
                        }
                    }
                }
                return distance;
            }
        }
         
    }
}
