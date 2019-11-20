using System;

namespace Deliverable_1_Ody
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType;
            int size;
            string destination;
            string travelSug;
            string result;
            //defined variables//
            Console.WriteLine("What kind of trip would you like to go on musical, tropical, or adventurous?");
            vacationType = Console.ReadLine(); 
            if (vacationType == "musical")
            {
                destination = "New Orleans";
                vacationType = "musical";
            }
            else if (vacationType == "tropical")
            {
                destination = "a beach vacation in Mexico";
                vacationType = "tropical";
            }
            else if (vacationType == "adventurous")
            {
                destination = "go white water rafting in the Grand Canyon";
                vacationType = "adventurous";
            }
            else
            {
                destination = "";
            }
            //control statments for what type and the destination user inputs//
            Console.WriteLine("What is your group size?");
            size = int.Parse(Console.ReadLine());
            if (size < 3 && size > 0)
            {
                travelSug = "first class flight";
            }
            else if (size > 2 && size < 6)
            {
                travelSug = "helicoptor";
            }
            else if (size > 6)
            {
                travelSug = "charter flight";
            }
            else { travelSug = ""; }
            //control statments and operators for whole number use input//
            result = "Since you are a group of " + size + " going on a " + vacationType + " vacation, you should take a " + travelSug + " to " + destination + ".";
            //concatenation for single string output//
            Console.WriteLine(result);
           



        }

    }

}
