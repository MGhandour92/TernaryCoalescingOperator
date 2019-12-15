using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryCoalescingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If-Else, Ternary and Coalescing Operators");
            Console.WriteLine("#####################################");
            Console.WriteLine();

            //Traditional If- Else
            //-----------------------
            //pass null
            Console.WriteLine(nullableIntFunction(null, "traditional"));
            //pass value
            Console.WriteLine(nullableIntFunction(1, "traditional"));
            Console.WriteLine("======================");

            //Ternary Operator
            //-----------------------
            //pass null
            Console.WriteLine(nullableIntFunction(null, "ternary"));
            //pass value
            Console.WriteLine(nullableIntFunction(2, "ternary"));
            Console.WriteLine("======================");

            //Coalescing Operator
            //-----------------------
            //pass null
            Console.WriteLine(nullableIntFunction(null, "coalescing"));
            //pass value
            Console.WriteLine(nullableIntFunction(3, "coalescing"));
            Console.WriteLine("======================");
        }

        /// <summary>
        /// Example for explaining the use of If-Else, Ternary and Coalescing Operators
        /// </summary>
        /// <param name="nullableInteger">Integer that can be entered with value or null</param>
        /// <param name="conditionalType">The method to use for conditional operation</param>
        /// <returns></returns>
        private static string nullableIntFunction(int? nullableInteger, string conditionalType)
        {
            string traditionalResult = "Result-Int? (Traditional): ";
            string ternaryResult = "Result-Int? (Ternary): ";
            string coalescingResult = "Result-Int? (Coalescing): ";

            //traditional
            if (nullableInteger.HasValue)
            {
                //add the value to the message
                traditionalResult += nullableInteger.Value;
            }
            else
            {
                traditionalResult += "0";
            }

            //teranry
            //if the integer has value return the value, else  return zero
            ternaryResult += nullableInteger.HasValue ? nullableInteger.Value : 0;

            //coalescing
            //if integer is not null then use it, else use zero
            coalescingResult += nullableInteger ?? 0;


            /*C# 8.0 - coalescing assignment
                nullableInteger ??= 0; 
                coalescingResult += nullableInteger;
            */

            //if the type needed is traditional return traditional, else if ternary retun ternary, else return coalescing
            return conditionalType == "traditional" ? traditionalResult : conditionalType == "ternary" ? ternaryResult : coalescingResult;
        }
    }
}
