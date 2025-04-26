using System;
using System.Collections.Generic;

// Nathan: Contractor class represents a contractor with basic details.
public class Contractor
{
    public string Name { get; set; } 
    public int Number { get; set; } 
    public DateTime StartDate { get; set; } 

    // Default constructor
    public Contractor() { }

 
    public Contractor(string name, int number, DateTime startDate)
    {
        Name = name;
        Number = number;
        StartDate = startDate;
    }
}

// Jonathan: Subcontractor class inherits from Contractor and adds additional properties for subcontractor-specific details.
public class Subcontractor : Contractor
{
    public int Shift { get; set; } // Shift type (1 = Day, 2 = Night)
    public double HourlyPayRate { get; set; } 

   
    public Subcontractor() { }

   
    public Subcontractor(string name, int number, DateTime startDate, int shift, double hourlyPayRate)
        : base(name, number, startDate)
    {
        Shift = shift;
        HourlyPayRate = hourlyPayRate;
    }

    // Juan: Method to calculate the pay for the subcontractor based on hours worked.
    public float CalculatePay(float hoursWorked)
    {
        double basePay = hoursWorked * HourlyPayRate; 

        if (Shift == 2) 
        {
            basePay *= 1.03; 
        }

        return (float)basePay; 
    }
}

// Marc and Ashton: Main program class where we add and manage subcontractor details.
class Program
{
    static void Main()
    {
        List<Subcontractor> subcontractors = new List<Subcontractor>(); 
        string choice; 

       
        do
        {
            // User inputs for subcontractor details
            Console.Write("Enter contractor name: ");
            string name = Console.ReadLine();

            Console.Write("Enter contractor number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter start date (yyyy-mm-dd): ");
            DateTime startDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter shift (1 = Day, 2 = Night): ");
            int shift = int.Parse(Console.ReadLine());

            Console.Write("Enter hourly pay rate: ");
            double rate = double.Parse(Console.ReadLine());

            Console.Write("Enter hours worked: ");
            float hours = float.Parse(Console.ReadLine());

           
            Subcontractor sc = new Subcontractor(name, number, startDate, shift, rate);

           
            subcontractors.Add(sc);

            // Calculate and display the pay for the subcontractor
            Console.WriteLine($"\nPay for {name}: ${sc.CalculatePay(hours):F2}\n");

            // Ask the user if they want to add another subcontractor
            Console.Write("Add another subcontractor? (y/n): ");
            choice = Console.ReadLine().ToLower(); 

        } while (choice == "y");

        // Display all subcontractors and their details
        Console.WriteLine("\nAll Subcontractors:");
        foreach (var sc in subcontractors)
        {
            // Output each subcontractor's details
            Console.WriteLine($"Name: {sc.Name}, Shift: {sc.Shift}, Rate: {sc.HourlyPayRate:C}");
        }
    }
}
