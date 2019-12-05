using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ret = isFancy(55);
            int isFancy(int n)
            {
                if (n == 1)
                    return 1;

                int fancyNumber = 0;
                int pprevious = 1;
                int previous = 1;

                while (fancyNumber < n)
                {
                    fancyNumber = ((previous) + (pprevious));
                    pprevious = previous;
                    previous = fancyNumber;
                }

                if (fancyNumber == n)
                    return 1;

                return 0;
            }
        }

    }
}