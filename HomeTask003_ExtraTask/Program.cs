using System;
using System.Threading;

namespace HomeTask003_ExtraTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello friend. I need your help. Please enter two values and i show you some magic....");
            Thread.Sleep(500);
            // Ask user for fill first value
            Console.WriteLine("Please eneter first value");
            string firstValueString = Console.ReadLine();
            double firstValue = double.Parse(firstValueString);
            // Ask user for fill second value
            Console.WriteLine("Please eneter first value");
            string secondValueString = Console.ReadLine();
            double secondValue = double.Parse(firstValueString);
            Console.WriteLine();
            Thread.Sleep(400);
            Console.WriteLine($"You entered next values --- {firstValue} and {secondValue}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Lets do some actions...");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            // find sum of the elements
            double sumElements = firstValue + secondValue;
            Console.WriteLine($"Summ of two values is ------ {sumElements}");
            Console.WriteLine();
            Thread.Sleep(400);
            // perform the subtraction
            double substractionElements = firstValue - secondValue;
            Console.WriteLine($"Substraxtion of two values is ------ {substractionElements}");
            Thread.Sleep(400);
            Console.WriteLine();
            // perform multiplication
            double multiplyElements = firstValue * secondValue;
            Console.WriteLine($"multiplication of two values is ------  {substractionElements}");
            Thread.Sleep(400);
            Console.WriteLine();
            // perform devision
            double divisionElements = firstValue / secondValue;
            Console.WriteLine($"division of two values is ------ {divisionElements}");
            Thread.Sleep(400);
            Console.WriteLine();
            // perform remainder of the division
            double remainderElements = firstValue % secondValue;
            Console.WriteLine($"remainder of the division of two values is ------ {remainderElements}");
            Thread.Sleep(400);
            Console.WriteLine();
            // perform Square root for two elements
            Console.WriteLine($"Square root for two elements are ------ {Math.Sqrt(firstValue)} and {Math.Sqrt(secondValue)}");
            Thread.Sleep(400);
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Please hit enter for exit the app");
            Console.ReadKey();
        }
    }
}
