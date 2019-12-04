using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = { 3, 6, 9, 5, 7, 13, 6, 17 };

            int ret = isBean(arr);

            int isBean(int[] a)
            {
                int aa=0, bb=0;
                for (int i=0;i<a.Length;i++)
                {
                    if (a[i]==9)
                    {
                        if (Array.IndexOf(a, 9) != -1)
                        {
                            if (Array.IndexOf(a, 13) != -1)
                            {
                                aa= 1;
                            }
                        }
                    }
                    if (a[i] == 7)
                    {
                        if (Array.IndexOf(a, 7) != -1)
                        {
                            if (Array.IndexOf(a, 16) == -1)
                            {
                                bb = 1;
                            }
                        }
                    }
                    if (aa==1 && bb==1)
                    {
                        return 1;
                    }
                    
                }
                return 0;
            }

          

        }
         
    }
}
