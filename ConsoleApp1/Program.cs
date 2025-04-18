using SharkTaxonomy;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shark1 = new Shark("Great White", 5, "Seals", "Open Ocean") { };

            var shark2 = new Shark("Hammerhead", 4, "Fish", "Tropical Waters") { };

            var shark3 = new Shark("Tiger", 4, "Turtles", "Coral Reefs") { };

            Classifier classifier = new Classifier(3);
            classifier.AddShark(shark1);
            classifier.AddShark(shark2);
            classifier.AddShark(shark3);
            string actualResult = classifier.Report();
            string expectedResult =
                $"3 sharks classified:{Environment.NewLine}Great White shark: 5m long.{Environment.NewLine}Could be spotted in the Open Ocean, typical menu: Seals{Environment.NewLine}Hammerhead shark: 4m long.{Environment.NewLine}Could be spotted in the Tropical Waters, typical menu: Fish{Environment.NewLine}Tiger shark: 4m long.{Environment.NewLine}Could be spotted in the Coral Reefs, typical menu: Turtles";
            Console.WriteLine(actualResult.Length);
            Console.WriteLine(expectedResult.Length);
            if (actualResult == expectedResult)
            {
                Console.WriteLine("True");
            }
        }




    }
}

