using System;
using System.Collections.Generic;


namespace JurassicPark
{
    class Dinosaurs
    {
        public string Name { get; set; }
        public string DietType { get; set; }
        public string WhenAcquired { get; set; }
        public int Weight { get; set; }
        public int EnclosureNumber { get; set; }
        public string Description()
        {
            return Name + DietType + WhenAcquired + Weight + EnclosureNumber
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //static void DisplayGreeting()
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("  Welcome to Jurassic Park  ");
                Console.WriteLine("----------------------------");
                Console.WriteLine();
                Console.WriteLine();
            }


        }

        static string PromptForString(string prompt)

        {
            Console.Write(prompt);
            var userinput = Console.ReadLine();

            return userinput;

        }
    }
}



