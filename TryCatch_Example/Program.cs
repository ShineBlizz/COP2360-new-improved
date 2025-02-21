using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.ForegroundColor = ConsoleColor.Cyan; // Sets the text below to the color Cyan

            Console.WriteLine("Welcome to the Try-Catch Program");
            Console.WriteLine("I will take two numbers of your choice and divide them.");
            Console.WriteLine("Then, I will try to catch any potential errors you could possibly cause. Enjoy.");
            Console.ResetColor(); // Resets to default color

            Console.WriteLine("Please enter your first number: ");

            string UserInput1 = Console.ReadLine();

            Console.WriteLine("Now enter your second number: ");
            string UserInput2 = Console.ReadLine();

            try
            {
                num1 = Convert.ToInt32(UserInput1);
                num2 = Convert.ToInt32(UserInput2);

                int result = checked (num1 / num2); // Ensures overflow detection

                Console.WriteLine($"After dividing {num1} and {num2}, your new answer is {result} !");

            }

            catch (OverflowException ex) // num was either too small or too large
            {
                Console.WriteLine($"Detailed error message: {ex.Message}");
                Console.WriteLine("Integers in C# must be between -2,147,483,648 and 2,147,483,648");
            }
            catch (DivideByZeroException ex) // Self explanatory 
            {
                Console.WriteLine($"Detailed error message: {ex.Message}");
                Console.WriteLine("Division by zero is mathematically undefined.");
            } 
            catch (FormatException ex) // Handles invalid input, such as "a" or "/"
            {
                Console.WriteLine($"Detailed error message: {ex.Message}");
                Console.WriteLine("Please enter a whole number.");
                Console.WriteLine("Letters, decimals, and symbols are strictly prohibited");
            }
            catch (Exception ex) // Handles any other exception
            {
                Console.WriteLine($"Detailed error message: {ex.Message}");
                Console.WriteLine("Something went wrong that I didnt expect. At least I caught it!");
            }
        }
    }
}