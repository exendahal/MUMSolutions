using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {            
            int m = 32;
            int n = 18;
            int aaa= check(m , n);
            int check(int a,int b) {
                for (int i = 2; i < m; i++)
                {
                    if (i % 2 == 0 && m % i == 0 && n % i != 0)
                    {
                        return 0;
                    }                   
                   
                }
                return 1;
            }
           
        }
    }
}
