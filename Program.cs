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
        public string DescriptionOfDinosaur()
        {
            return Name + DietType + WhenAcquired + Weight + EnclosureNumber;
        }
    }
    class Program
    {
        private static void Description(DateTime WhenAcquired, Dinosaurs foundDinosaur)
        {
            Console.WriteLine($"{foundDinosaur.Name} is a {foundDinosaur.DietType}.");
            Console.WriteLine($"{foundDinosaur.Name} weighs {foundDinosaur.Weight} pounds.");
            Console.WriteLine($"{foundDinosaur.Name} was acquired on {WhenAcquired}");
            Console.WriteLine($"{foundDinosaur.Name}is in enclosure {foundDinosaur.EnclosureNumber}");
        }

        private static void IfNoDInosaurs(List<Dinosaurs> dinoList)
        {
            if (dinoList.Count == 0)
            {
                Console.WriteLine("There is no dinosaurs in this park");
            }
        }
        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine().ToUpper();

            return userInput;
        }
        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisInputGood = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisInputGood)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("My apologies, this was an invalid input. Im going to use your input as your number.");
                return 0;
            }
        }
        static void Main(string[] args)
        {

            {

                Console.WriteLine("----------------------------");
                Console.WriteLine("  Welcome to Jurassic Park  ");
                Console.WriteLine("----------------------------");
                Console.WriteLine();
                Console.WriteLine();
            }


        }

    }
}



