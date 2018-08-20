using System;

namespace Class5_UpdatedCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Clear();
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu(); 
            }
            
        }

        /// <summary>
        /// Main menu for calculator program (5 options: addition, subtraction, multiplication, division, and exit)
        /// </summary>
        /// <returns> One of the math operation methods or exits the program.</returns>
        private static bool MainMenu()
        {
            //Clears console after each operation
            Console.Clear();
            //Prints instructions for user and list of options to choose from
            Console.WriteLine("Do simple math with this basic calculator. " +
                "Choose from the following options:");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Subtraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.WriteLine("5) Exit");

            //user input is assigned to string 'result'
            string result = Console.ReadLine();
            //'result' string will be evaluated for each condition and, depending on selection
            //will be passed through appropriate method
            if (result == "1")
            {
                //Invokes addition method
                Addition();
                return true;
            }
            else if (result == "2")
            {
                //Invokes subtraction method
                Subtraction();
                return true;
            }
            else if (result == "3")
            {
                //Invokes multiplication method
                Multiplication();
                return true;
            }
            else if (result == "4")
            {
                //Invokes division method
                Division();
                return true;
            }
            //If option 5 (exit) is selected, the condition returns false, 
            //breaking the loop and quitting the program
            else if (result == "5")
                return false;
            //If the user enters anything else, the console 
            //returns to displaying the 'MainMenu' method
            else
                return true;

        }

        /// <summary>
        /// Adds two numbers and prints out the result.
        /// </summary>
        private static void Addition()
        {
            Console.Clear();
            Console.Write("Type your first number: ");
            Decimal firstAdd = Decimal.Parse(Console.ReadLine());

            Console.Write("Type your second number: ");
            Decimal secondAdd = Decimal.Parse(Console.ReadLine());

            Decimal result = firstAdd + secondAdd;

            DisplayResult(result);
            Console.ReadLine();
           
        }
        
        /// <summary>
        /// Subtracts two numbers and prints out the result.
        /// </summary>
        private static void Subtraction()
        {
            Console.Clear();
            Console.Write("Type the number being subtracted from: ");
            Decimal firstSubtract = Decimal.Parse(Console.ReadLine());

            Console.Write("Type the number being subtracted: ");
            Decimal secondSubtract = Decimal.Parse(Console.ReadLine());

            Decimal result = firstSubtract - secondSubtract;

            DisplayResult(result);
            Console.ReadLine();
        }
        /// <summary>
        /// Multiplies two numbers and prints out the result.
        /// </summary>
        private static void Multiplication()
        {
            Console.Clear();
            Decimal firstMultiply = Decimal.Parse(Console.ReadLine());

            Console.Write("Type a second number to be multiplied by the first: ");
            Decimal secondMultiply = Decimal.Parse(Console.ReadLine());

            Decimal result = firstMultiply * secondMultiply;

            DisplayResult(result);
            Console.ReadLine();
        }

        /// <summary>
        /// Divides two numbers and prints out the result.
        /// </summary>
        private static void Division()
        {
            Console.Clear();
            Console.Write("Enter your dividend: ");
            Decimal firstDivide = Decimal.Parse(Console.ReadLine());

            Console.Write("Enter your divisor: ");
            Decimal secondDivide = Decimal.Parse(Console.ReadLine());

            Decimal result = firstDivide / secondDivide;
            Decimal remainder = firstDivide % secondDivide;

            DisplayResult(result);
            Console.ReadLine();
              
        }

        /// <summary>
        /// Prints "Result: " to console followed by the string of code passed through.
        /// </summary>
        /// <param name="calculatorResult"> The result of calculations. </param>
        private static void DisplayResult(Decimal calculatorResult)
        
            {
                Console.WriteLine($"Result: {calculatorResult}");
              
            }

    }
}
