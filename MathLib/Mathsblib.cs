using System;

namespace MathLib
{
    public class Mathsblib
    {
        public static void Amicable(int min, int max)
        {
            int sumA = 0, sumB = 0, temp = 0;

            for(int i = min; i <= max; i++)
            {
                sumA = 0;
                sumB = 0;

                for(int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sumA += j;
                }

                for(int k = 1; k < sumA; k++)
                {
                    if (sumA % k == 0)
                        sumB += k;
                }

                if (i == sumA)
                    continue;

                if (i == sumB)
                {
                    if (temp == i)
                        continue;
                    else
                        temp = sumA;
                        Console.WriteLine(i + " - " + sumA);
                }
            }
        }

        public static void Amicable2(int min, int max)
        {
            int sumA = 0, sumB = 0, temp = 0;
            int j=1, k=1;
            for(int i = min; i <= max; i++)
            {
                while (j < i)
                {
                    if (i % j == 0)
                        sumA += j;
                    j++;
                }

                j = 1;
                while (j < sumA)
                {
                    if (sumA % j == 0)
                        sumB += j;
                }

                if (i == sumA)
                    continue;

                if (i == sumB)
                {
                    if (temp == i)
                        continue;
                    else
                        temp = sumA;
                        Console.WriteLine(i + " - " + sumA);
                }
            }
        }
    }
}
