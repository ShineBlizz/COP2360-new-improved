using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>();

        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("Dictionary Operations:");
            Console.WriteLine("1 Populate the Dictionary.");
            Console.WriteLine("2 Display Dictionary Contents.");
            Console.WriteLine("3 Remove a Key.");
            Console.WriteLine("4 Add a New Key and Value.");
            Console.WriteLine("5 Add a Value to an Existing Key.");
            Console.WriteLine("6 Exit");
            Console.WriteLine("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input, Please enter a number between 1 and 6");
                continue;
            }


            // Switch statement based on the users choice

            switch (choice)
            {
                // Here we will populate the dictionary with some of our own data
                case 1:
                    myDictionary["Dog"] = new List<string> { "Animal" };
                    myDictionary["Cat"] = new List<string> { "Animal" };
                    myDictionary["Football"] = new List<string> { "Sport" };
                    myDictionary["Soccer"] = new List<string> { "Sport" };
                    Console.WriteLine("The dictionary has been populated");
                    break;

                case 2:
                    // We will display the contents of the dictionary here
                    Console.WriteLine("Dictionary Contents: ");
                    foreach (var item in myDictionary)
                    {
                        Console.WriteLine($"{item.Key}: {string.Join(",", item.Value)}");
                    }
                    break;
                

                // Jonathan
                // Remove a key: Remove a specified key from the dictionary
                case 3:
                    // Write here
                    break;

                // Juan
                // Add a New Key and Value: Insert a new key-value pair into the dictionary
                case 4:
                    // Write here
                    break;

                // Marc
                // Add a Value to an Existing Key: Append a new value to an existing key.
                case 5:
                    // Write here
                    break;

                // Ashton
                // Sort the keys: Sort the keys in the dictionary.
                case 6:
                    // Write here
                    break;

                case 7:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        } while (choice != 6); // This ensures the program will loop as long as the user does not enter 6
    }

}