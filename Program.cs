using Static__non_static_functions.lib;
using System;
using System.Runtime.CompilerServices;

namespace Showplaces

{
    class App
    {
        static void Main(string[] args)
        {
            //  Initializing objects
            var place = new Place("Stavern", "Larvik", "Vestfold");


            //  Initializing another object
            var place_2 = new Place("Sjøholt", "Ålesund", "Møre og Romsdal");

            // Object methods
            place.ShowPlace();
            place_2.ShowPlace();


            /******************************************************************************/


            var stats = new Stats();

            while (true)
            {
                //  Prompting the user to type in a number or quit the program
                Console.WriteLine("Skriv et tall (eller blankt for å avslutte");

                //  Initialize user input
                string input = Console.ReadLine();
                
                //  Ensure that the string is empty
                if (string.IsNullOrEmpty(input)) break;

                //  Initialize n
                int n = Convert.ToInt32(input);

                stats.Increment(n);

                //  Prompt the user for a conclusion
                Console.WriteLine(
                    $"Total counted : {stats.I__}" +
                    $"Sum :           {stats.Sum__}" +
                    $"Average       : {stats.Average}");



            }
        }
    }
}