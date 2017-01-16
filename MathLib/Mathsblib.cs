using System;
using System.Collections;
using System.Collections.Generic;

namespace MathLib
{
    public class Mathsblib
    {
        //Method for Amicable Numebr use FOR LOOP;
        public static void Amicable(int min, int max)
        {
            ArrayList arrTemp = new ArrayList(); //Create new Array List for store all values from i to check with sumA, if it have duplicated number;
            checkDup check = new checkDup(); //Call checkDup from other class to create new object;

            //Declare for variables;
            //sumA for Store a value about: the partner of i;
            //sumB for Store a value about: the partner of sumA;
            //temp for Store a TEMP value about: the value that used compare with i, if it equal it will over a round loop;
            long sumA = 0, sumB = 0, temp = 0;
            //Run for loop from min->max value;
            for (int i = min; i <= max; i++)
            {
                arrTemp.Add(check.getVal()); //Add value to arraylist by getVal() method in check's object;
                bool isNumberDup = check.Dup(i, arrTemp); //Declared var to get bool from checkDup number;
                if (isNumberDup == true) //If isNumberDup equal true then it over a round loop, it's mean the duplicated number;
                    goto over_around; //Label for over a round loop;

                sumA = 0; //reset sumA to zero;
                sumB = 0; //reset sumB to zero;

                sumA = Modulo(1, i);
                sumB = Modulo(1, sumA);

                /* 
                 * Changed loop to a method: Modulo(val1,val2);
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
                *End released for loop;
                * Note: You can clear all comments;
                */

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
                    {
                        check.setVal(sumA); //Set value to checkDup, and store it in a ArrayList;
                        temp = sumA; //Take value from sumA to temp, if condition is false; ex: sumA = 284 -> temp = 284; [....];
                        Console.WriteLine(i + " pair with " + sumA); //Output the result to screen;
                    }
                }
            over_around:; //Declared for Label for Over a round loop;
            } //End the first loop;

        } //End method Amicable;
        
        //Modulo for Amicable and Amicable2 ; this method like ModAmicable();
        public static long Modulo(int st_loop, long ed_loop)
        {
            long sum = 0;
            for(int i = st_loop; i <= ed_loop - 1; i++)
            {
                if (ed_loop % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
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
            ArrayList arrTemp2 = new ArrayList();
            checkDup check2 = new checkDup();

            long sumA = 0, sumB = 0, j=1, temp = 0;
            for(int i = min; i <= max; i++)
            {
                arrTemp2.Add(check2.getVal());
                bool isNumberDup = check2.Dup(i, arrTemp2);
                if (isNumberDup == true)
                    goto over_around;
                sumA = 0;
                sumB = 0;

                sumA = Modulo(1, i);
                sumB = Modulo(1, sumA);

                if (i == sumA)
                    continue;
                
                if (i == sumB)
                {
                    if (temp == i)
                        continue;
                    else
                    {
                        check2.setVal(sumA);
                        temp = sumA;
                        Console.WriteLine(i + " : " + checkMod(i) + " = " + sumA);
                        Console.WriteLine(sumA + " : " + checkMod(toInt(sumA+"")) + " = " + i + "\n");
                    }
                }
            over_around:;
            }
        }

        //Start Methods Amicable and ModAmicable;
        //Method for Pair of Amicable fixed value: 1 to 10000 for clearly answer;
        public static void GetAmicable(int number)
        {
            int s1, s2, temp = 0;
            for (int i = 1; i <= number; i++)
            {
                s1 = s2 = 0;
                s1 = ModAmicable(i);
                s2 = ModAmicable(s1);

                if (i == s1)
                    continue;

                if (i == s2)
                {
                    if (temp == i)
                        continue;
                    else
                        temp = s1;
                    Console.WriteLine(i + " - " + s1);
                }
            } 
            //End the first loop from 1 to number less than or equal 10000;
        }

        //Method Modulo Amicable number as small thinking;
        public static int ModAmicable(int num)
        {
            int sum = 0;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    sum += i;
            }

            return sum;
        }
        //End Method Amicable and ModAmicable Number;

        //Covert all string to integer;
        public static int toInt(string integer)
        {
            int getInt = 0;
            getInt = int.Parse(integer);
            return getInt;
        }

    } //End Mathsblib class;

    //Create class for check for Duplicate Number;
    //if have, it will over around loop of the first of loop;
    public class checkDup
    {
        public static long temp = 0; //It's the temp value to get and return val to other;
       
        //Set value from other to temp;
        public void setVal(long n)
        {
            temp = n;
        }

        //Get value from temp and return value;
        public long getVal()
        {
            return temp;
        }

        //Check duplicated number method;
        //var -> currentNum: refer to current of value that you want to check and compare with all of values in arrTemp (ArrayList);
        public bool Dup(long currentNum, ArrayList arrTemp)
        {
            bool checkDuplicated = false;
            foreach (long number in arrTemp)
            {
                if (currentNum == number)
                    checkDuplicated = true;
            }
            return checkDuplicated;
        }
    }

}
