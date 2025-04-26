using System;
using System.Collections.Generic;

// Nathan. I wrote the base code and my group members added their parts. Each part is labeled.
class Program
{
    static void Main()
    {
        // Create a dictionary that maps string keys to lists of string values
        Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>();

        int choice;

        do
        {
            Console.Clear(); // Clears the console for a fresh display
            Console.WriteLine("Dictionary Operations:");
            Console.WriteLine("1 Populate the Dictionary.");
            Console.WriteLine("2 Display Dictionary Contents.");
            Console.WriteLine("3 Remove a Key.");
            Console.WriteLine("4 Add a New Key and Value.");
            Console.WriteLine("5 Add a Value to an Existing Key.");
            Console.WriteLine("6. Sort the keys");
            Console.WriteLine("7 Exit");
            Console.WriteLine("Enter your choice: ");

            // Check if the input is a valid integer
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input, Please enter a number between 1 and 6");
                continue; // If input is invalid, restart the loop
            }

            // Switch statement based on the users choice
            switch (choice)
            {
                // Case to populate the dictionary with initial values
                case 1:
                    myDictionary["Dog"] = new List<string> { "Animal" };
                    myDictionary["Cat"] = new List<string> { "Animal" };
                    myDictionary["Football"] = new List<string> { "Sport" };
                    myDictionary["Soccer"] = new List<string> { "Sport" };
                    Console.WriteLine("The dictionary has been populated");
                    break;

                // Case to display the contents of the dictionary
                case 2:
                    Console.WriteLine("Dictionary Contents: ");
                    // Iterate through all dictionary items and display key-value pairs
                    foreach (var item in myDictionary)
                    {
                        Console.WriteLine($"{item.Key}: {string.Join(",", item.Value)}");
                    }
                    break;

                // Jonathan
                // Case to remove a key-value pair from the dictionary
                case 3:
                    Console.WriteLine("Enter the key to remove");
                    string keyToRemove = Console.ReadLine(); // Read the key to remove

                    // Check if the key exists before removing it
                    if (myDictionary.ContainsKey(keyToRemove))
                    {
                        myDictionary.Remove(keyToRemove); // Remove the key-value pair
                        Console.WriteLine($"Key {keyToRemove} has been removed");
                    }
                    else
                    {
                        Console.WriteLine($"Key {keyToRemove} not found");
                    }
                    break;

                // Juan
                // Case to add a new key-value pair to the dictionary
                case 4:
                    Console.Write("Enter new key: ");
                    string newKey = Console.ReadLine(); // Read the new key
                    Console.Write("Enter new value: ");
                    string newValue = Console.ReadLine(); // Read the new value

                    // If the key does not exist, create a new list for it
                    if (!myDictionary.ContainsKey(newKey))
                    {
                        myDictionary[newKey] = new List<string>();
                    }
                    myDictionary[newKey].Add(newValue); // Add the value to the list for the key
                    Console.WriteLine($"Key-Value pair '{newKey}: {newValue}' added.");
                    break;

                // Marc
                // Case to add a value to an existing key in the dictionary
                case 5:
                    Console.Write("Enter the existing key: ");
                    string existingKey = Console.ReadLine(); // Read the existing key

                    // Check if the key exists in the dictionary
                    if (myDictionary.ContainsKey(existingKey))
                    {
                        Console.Write("Enter the new value to add: ");
                        string newValuetwo = Console.ReadLine(); // Read the new value

                        // Add the new value to the existing list for the key
                        myDictionary[existingKey].Add(newValuetwo);
                        Console.WriteLine("Value added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Key not found in the dictionary.");
                    }
                    break;

                // Ashton
                // Case to sort and display dictionary keys
                case 6:
                    Console.WriteLine("Sorted Keys:");
                    // Sort the keys alphabetically and display them
                    foreach (var key in myDictionary.Keys.OrderBy(k => k))
                    {
                        Console.WriteLine(key); // Display each sorted key
                    }
                    break;

                // Case to exit the program
                case 7:
                    Console.WriteLine("Exiting program...");
                    break;

                // Default case for invalid choices
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue..."); // Prompt the user to continue
            Console.ReadKey(); // Wait for the user to press a key
        } while (choice != 7); // Continue looping until the user selects option 7 (Exit)
    }
}
