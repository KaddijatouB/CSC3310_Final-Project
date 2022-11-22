using System;

namespace ArrayTutorial
{
    class Array
    {
        static void Main(string[] args)
        {

            // create an array
            int[] digits = { 20, 83, 79, 100, 103};

            foreach(int i in digits)
            {
                //Print the array
                Console.WriteLine(i);
            }
            
            Console.WriteLine("the Old Value at index 0: " + digits[0]);
            Console.WriteLine("The Length is: " + digits.Length);

            //Get values at index n
            Console.WriteLine("Get Value at index 4: " + digits.GetValue(4));
            Console.WriteLine("Get Value at index 3: " + digits.GetValue(3));
            Console.WriteLine("Get Value at index 2 is: " + digits.GetValue(2));
            Console.WriteLine("Get Value at index 1 is: " + digits.GetValue(1));

            // change the value at index 0
            digits[0] = 70;
            digits[1] = 145;

            //Print the new value
            Console.WriteLine("the new Value at index 0: " + digits[0]);

            
            var language = new[] { "ADA", "C#", "F#" };
            //language[0] = "ADA";
            //language[1] = "F#";
            //language[2] = "C#";

            for (int i = 0; i <= language.Length - 1; i++)
            {
                //Print the fixed size array
                Console.WriteLine(" " +language[i]);
            }
            //Create a fixed size array
            //copy all items in language to language1
            //staring at index 1. Index 0 is null
            var language1 = new string[4];
            language.CopyTo(language1, 1);

            foreach(var i in language1)
            {
                Console.WriteLine("Item copied: ");
                Console.WriteLine(i);
            }


        }
    }
}