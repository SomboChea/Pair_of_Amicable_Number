using System; //Call system conponents;
using MathLib; //Call namespace from Mathsblib.dll -> Its class : Mathsblib;
using System.Collections;

namespace Pair_of_Amicable_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Min = 1 ; Max = 10000;
            //Run Method from Mathlib.dll (Class library)

            /* You can set unlimited number */
            Console.WriteLine("\n\t:::::::LONG RESULT AS DETAIL:::::::\n");
            Mathsblib.Amicable2(1, 90000); //For long result for detail;

            Console.WriteLine("\n\t:::::::SHORT RESULT:::::::\n");
            Mathsblib.Amicable(1, 90000); //For short answer;

            /* Get smalllest number only less than or equal to 10000 */
            //Mathsblib.GetAmicable(10000);
            //Console.WriteLine("Done...");

            //You can call it as object;
            /*
             Mathsblib mathlib = new Mathsblib();
             mathlib.Amicable(min,max);
            */
            //Mathsblib is the class that you add reference from Mathsblib.dll;
            //mathlib is the name of the object that you was declared;
            Console.Read();
        }
    }
}
