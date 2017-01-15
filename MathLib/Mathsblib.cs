using System;
using System.Collections;

namespace MathLib
{
    public class Mathsblib
    {
        //Method for Amicable Numebr use FOR LOOP;
        public static void Amicable(int min, int max)
        {
            //Declare for variables;
            long sumA = 0, sumB = 0, temp = 0;

            //Run for loop from min->max value;
            for(int i = min; i <= max; i++)
            {
                sumA = 0; //reset sumA to zero;
                sumB = 0; //reset sumB to zero;

                //Run for loop from j to i-1;
                for(int j = 1; j < i; j++)
                {
                    if (i % j == 0) //Modulo i value with j value, if equal zero, sumA continue plus with j and store it for a round of i;
                        sumA += j; //EX: j=1 --> sumA +=1 -> sumA = 1; j=2 --> sumA +=2 -> sumA = 3; [....];
                }

                //Run for loop from k to sumA-1;
                for(int k = 1; k < sumA; k++)
                {
                    if (sumA % k == 0) //Modulo sumA value with k value, if equal zero, sumB continue plus with k and store if for a round of i;
                        sumB += k; //Like sumA +=j;
                }

                //Condition for i equal sumA, after if over a round loop (i), ex: i = 6 -> [1+2+3] ; sumA = 6 ; And then it i=sumA;
                if (i == sumA)
                    continue; //To over a round of loop;

                //Condition for i equal sumB, after it check in more condition, and temp equal i;
                //it's mean that temp use for over a round, if the number of i equal to sumA;
                //Ex: i=220;sumA=220; then it over one value of sumA, if it's equal; --> i = 220 | sumA = 284 ;
                if (i == sumB)
                {
                    if (temp == i) //Check temp, if equal to i;
                        continue; //And then over a round;
                    else
                        temp = sumA; //Take value from sumA to temp, if condition is false; ex: sumA = 284 -> temp = 284; [....];
                        Console.WriteLine(i + " pair with " + sumA); //Output the result to screen;
                }
            }
        }

        //Method for return long result and detail for pair of amicable number;
        //checkMod: it's mean that it used modulo to get number of value want to check;
        //Example: checkMod(4); when it returned as: 1+2;
        //checkMod used for pair of amicable number used only;
        //it's not return the number of itself;
        //Example: checkMod(4); when it doesn't return as: 1+2+4; (Not acceptable);
        public static string checkMod(int val)
        {
            string res = "";
            int sum = 0;
            for(int i = 1; i <= val; i++)
            {
                if (val % i == 0)
                {
                    if (i != val)
                    {
                        res += i + "+";
                        sum += i;
                    }
                }
            }
            res += "\b ";
            return res;
        }
        
        //Method for Amicable Numebr use WHILE LOOP and Show long result for detail;
        public static void Amicable2(int min, long max)
        {
            long sumA = 0, sumB = 0;
            long j=1;
            for(int i = min; i <= max; i++)
            {
                sumA = 0;
                sumB = 0;

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
                    j++;
                }

                if (i == sumA)
                    continue;

                if (i == sumB)
                {
                   Console.WriteLine(i + " = " + checkMod(i) + " = " + sumA);
                }
            }
        }
        
    }
}
