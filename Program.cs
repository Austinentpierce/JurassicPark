using System;
using System.Collections.Generic;
using System.Linq;

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

        private static void IfNoDinosaurs(List<Dinosaurs> dinoList)
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

                DateTime WhenAcquired = DateTime.Now;
                var dinoList = new List<Dinosaurs>();
                var keepGoing = true;

                while (keepGoing)
                {
                    Console.WriteLine();
                    Console.Write("Want to choose : (A)dd a dinosaur (R)emove a dinosaur (V)iew a dinosaur (Transfer a dinosaur (S)ummary of a dinosaur or (Q)uit) ");
                    var choice = Console.ReadLine().ToUpper();
                    Console.WriteLine();

                    if (choice == "A")
                    {
                        Console.WriteLine("Adding Dinosaur");
                        Console.WriteLine();

                        var dinosaur = new Dinosaurs();

                        dinosaur.Name = PromptForString("What is the dinosaurs name? ");
                        dinosaur.DietType = PromptForString("What is this dinosaur's diet type? Carnivore or a Herbivore? ");
                        dinosaur.Weight = PromptForInteger("How much weight in pounds does the dinosaur weigh? ");
                        dinosaur.EnclosureNumber = PromptForInteger("What enclosure number is this dinosaur going to be kept in? ");

                        dinoList.Add(dinosaur);

                    }
                    else if (choice == "R")
                    {
                        Console.WriteLine("Removing Dinosaur: ");
                        Console.WriteLine();

                        IfNoDinosaurs(dinoList);

                        var dinoToSearchFor = PromptForString("Which of the dinosaurs would you like to remove? ");

                        Dinosaurs foundDinosaur = dinoList.FirstOrDefault(dinosaur => dinosaur.Name == dinoToSearchFor);
                        if (foundDinosaur == null)
                        {
                            Console.WriteLine("Sorry there is no dinosaur under that name");
                        }
                        else
                        {
                            Description(WhenAcquired, foundDinosaur);

                            var confirm = PromptForString($"Are you sure you want to remove {foundDinosaur.Name}? [Y/N] ").ToUpper();

                            if (confirm == "Y")
                            {
                                dinoList.Remove(foundDinosaur);
                            }
                            else
                            if (choice == "N")
                            {
                                Console.WriteLine("Redo your choice your dinosaur description if entered wrong");
                            }
                        }
                    }
                    else
                    if (choice == "T")
                    {
                        Console.WriteLine("Transferring dinosaur");
                        Console.WriteLine();

                        IfNoDinosaurs(dinoList);

                        var dinoToSearchFor = PromptForString("Which dinosaur did you want to transfer? ");

                        Dinosaurs foundDinosaur = dinoList.FirstOrDefault(dinosaur => dinosaur.Name == dinoToSearchFor);

                        if (foundDinosaur == null)
                        {
                            Console.WriteLine("No dinosaur under that name was located");
                        }
                        else
                        {
                            Description(WhenAcquired, foundDinosaur);
                            foundDinosaur.EnclosureNumber = PromptForInteger($"What enclosure do you want to transfer {foundDinosaur.Name} to? ");

                            Console.WriteLine($"{foundDinosaur.Name} was moved to {foundDinosaur.EnclosureNumber}. ");
                        }
                    }
                    else
                    if (choice == "V")
                    {
                        Console.WriteLine("Viewing dinosaur: ");
                        Console.WriteLine();
                        foreach (var dinosaurs in dinoList)
                        {
                            Console.WriteLine($"{dinosaurs.Name} weighs {dinosaurs.Weight} pounds. ");
                            Console.WriteLine($"{dinosaurs.Name} is a {dinosaurs.DietType}. ");
                            Console.WriteLine($"{dinosaurs.Name} is in enclosure {dinosaurs.EnclosureNumber}. ");
                            Console.WriteLine($"{dinosaurs.Name} was acquired on {WhenAcquired}. ");
                            Console.WriteLine();
                        }
                        IfNoDinosaurs(dinoList);
                    }
                    else
                    if (choice == "S")
                    {
                        Console.WriteLine("Summary of dinosaurs: ");
                        Console.WriteLine();

                        var carnivores = dinoList.Where(dinosaurs => dinosaurs.DietType == "carnivore").Count();
                        var herbivores = dinoList.Where(dinosaurs => dinosaurs.DietType == "herbivore").Count();

                        Console.WriteLine($"There are {herbivores} herbivore dinosaurs, and {carnivores} carnivore dinosaurs");

                    }
                    else
                    if (choice == "Q")
                    {
                        keepGoing = false;
                    }

                }

            }


        }

    }
}



