using System;
using System.Threading;

namespace HomeTask003_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choise logic function
            GetUserChoise();


        }
        public static void GetUserChoise(){

                bool exitFromApp = false;
                while (exitFromApp == false) {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                // Ask user for selecting hometask
                Console.WriteLine("Please select hometask: (Choose 1-5) or type exit for exit from program: ");
                // Save user decision into variable
                String decision = Console.ReadLine();

                switch (decision)
                {
                    case "1":
                        OutputExpressions();
                        break;
                    case "2":
                        GetArithmeticalMean();
                        break;
                    case "3":
                        GetCircleArea();
                        break;
                    case "4":
                        GetVolumeAndSurfaceArea();
                        break;
                    case "5":
                        CheckVariablesCreation();
                        break;
                    case "exit":
                        exitFromApp = true;
                        break;
                    default:
                        Console.WriteLine("Wrong Input. Please try again later");
                        Thread.Sleep(2000);
                        break;
                }
            }

        }
        public static void OutputExpressions()
        {
            // Declare variables
            int x = 10, y = 12, z = 3;

            // Output the expressions
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 1: Perform and calculate the result of the following operations for these variables:");
            Thread.Sleep(1000);
            Console.WriteLine("initial value of variables");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine($"y = {z}");
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Lets start performing actions:");
            Console.WriteLine();
            Console.Write("First statement is x += y - x++ * z ");
            x += y - x++ * z;
            Console.WriteLine($"       Result: x = {x}");
            Thread.Sleep(1000);
            Console.Write("Second statement is z = --x - y * 5 ");
            z = --x - y * 5;
            Console.WriteLine($"       Result: x = {z}");
            Thread.Sleep(1000);
            Console.Write("Third statement is y /= x + 5 % z ");
            y /= x + 5 % z;
            Console.WriteLine($"         Result: x = {y}");
            Thread.Sleep(1000);
            Console.Write("Fourth statement is z = x++ + y * 5");
            z = x++ + y * 5;
            Console.WriteLine($"        Result: x = {z}");
            Thread.Sleep(1000);
            Console.Write("Fifth statement is x = y - x++ * z");
            x = y - x++ * z;
            Console.WriteLine($"        Result: x = {x}");
            Thread.Sleep(1000);
            Console.WriteLine("Please hit enter for return to hometask selection");
            Console.ReadLine();
        }
        public static void GetArithmeticalMean(){
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(1000);
            Console.WriteLine("Task2: Calculate the arithmetic mean of three integer values and display it.");
            Console.WriteLine();
            // Ask User for the first value
            Console.WriteLine("Please, enter the firsrt value...");
            // Read value and parse it into int
            string firstValueInString = Console.ReadLine();
            int firstValue = int.Parse(firstValueInString);
            // Ask User for the second value
            Console.WriteLine("Please, enter second value...");
            // Read value and parse it into int
            string secondValueInString = Console.ReadLine();
            int secondValue = int.Parse(secondValueInString);
            // Ask User for the third value
            Console.WriteLine("Please, enter second value...");
            // Read value and parse it into int
            string thirddValueInString = Console.ReadLine();
            int thirdValue = int.Parse(thirddValueInString);
            Console.WriteLine("hmmm... Lets check it...");
            Console.WriteLine($"Your first value is {firstValue}");
            Console.WriteLine($"Your second value is {secondValue}");
            Console.WriteLine($"Your third value is {thirdValue}");
            Console.WriteLine();
            Console.WriteLine("Alright lets do the magic...");
            Thread.Sleep(1000);
            Console.Write("Your arithmetic mean of rhose values is...");
            Thread.Sleep(1000);
            Console.WriteLine();
            // Calcualte arithmetic mean of three values
            double calculationResult = (double)(firstValue + secondValue + thirdValue) / 3;
            Console.WriteLine(calculationResult);
            Thread.Sleep(1000);
            Console.WriteLine("Please hit enter for return to hometask selection");
            Console.ReadLine();
        }
        public static void GetCircleArea() {
            // declare PI as a const 
            const double PI = 3.14;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Thread.Sleep(1000);
            Console.WriteLine("Task3: Calculate the area of a circle and displays it.");
            Console.WriteLine();
            // Ask User for the radius of the circle
            Console.WriteLine("Please, type circle radius value...");
            // Parse it to double
            string radiusStringValue = Console.ReadLine();
            double radius = double.Parse(radiusStringValue);
            Console.WriteLine();
            Console.WriteLine("Alright lets check it...");
            Console.WriteLine();
            Console.WriteLine($"You enetered radius with equals =    {radius}");
            Console.WriteLine();
            double circleArea = (double)PI * (radius*radius);
            Console.WriteLine($"Area of a circle according to your data is      {circleArea}");
            Thread.Sleep(1000);
            Console.WriteLine("Please hit enter for return to hometask selection");
            Console.ReadLine();
        }
        public static void GetVolumeAndSurfaceArea() {
            // declare PI as a const 
            const double PI = 3.14;
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(1000);
            Console.WriteLine("Task4: Calculate volume and surface area and display results.");
            Console.WriteLine();
            // Ask User for the radius of the cylinder
            Console.WriteLine("Please, type cylinder radius value...");
            // Parse it to double
            string radiusStringValue = Console.ReadLine();
            double radius = double.Parse(radiusStringValue);
            // Ask User for the height of the cylinder
            Console.WriteLine("Please, type cylinder height value...");
            string heightStringValue = Console.ReadLine();
            double height = double.Parse(heightStringValue);
            Console.WriteLine();
            Console.WriteLine("Alright. Let me check your entered data...");
            Thread.Sleep(1000);
            Console.WriteLine($"Your cylinder radius is {radius}");
            Thread.Sleep(300);
            Console.WriteLine();
            Console.WriteLine($"Your cylinder height is {height}");
            Console.WriteLine();
            Console.WriteLine("Calculating Cylinder Volume via this formula  V = πR2h ");
            Thread.Sleep(500);
            double cylinderVolume = PI * (radius * radius) * height;
            Console.WriteLine($"Cylinder Volume is     {cylinderVolume}");
            Console.WriteLine();
            Thread.Sleep(300);
            Console.WriteLine("Calculating Cylinder Volume via this formula    2πR(R+h) ");
            double cylinderAreaSquare = 2 * PI * radius * (radius + height);
            Console.WriteLine();
            Thread.Sleep(300);
            Console.WriteLine($"Cylinder Area Square is     {cylinderAreaSquare}");
            Thread.Sleep(1000);
            Console.WriteLine("Please hit enter for return to hometask selection");
            Console.ReadLine();
        }
        public static void CheckVariablesCreation() {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(1000);
            Console.WriteLine("Task5: Check if you can create variables with the following names:");
            Console.WriteLine("uberflu?");
            Console.WriteLine("_Identifier");
            Console.WriteLine("\\u006fIdentifier");
            Console.WriteLine("&myVar");
            Console.WriteLine("myVariab1le");
            Console.WriteLine("");
            // This variable declaration makes no sence -- char uberflu?;
            string _Identifier = "_Identifier";
            string \u006fIdentifier = "\\u006fIdentifier";
            // This variable declaration makes no sence -- double  &myVar;
            string myVariab1le = "myVariab1le";
            Console.WriteLine();
            Thread.Sleep(500);
            Console.WriteLine($"After thousents years of brainstorming I can create next values....      {_Identifier}, {\u006fIdentifier}, and {myVariab1le}");
            Thread.Sleep(1000);
            Console.WriteLine("Please hit enter for return to hometask selection");
            Console.ReadLine();
        }
    }
}
