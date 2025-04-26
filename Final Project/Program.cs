using System;
using System.Collections.Generic;

// Nathan
public class Contractor
{
    public string Name { get; set; }
    public int Number { get; set; }
    public DateTime StartDate { get; set; }

    public Contractor() { }

    public Contractor(string name, int number, DateTime startDate)
    {
        Name = name;
        Number = number;
        StartDate = startDate;
    }
}

// Jonathan
public class Subcontractor : Contractor
{
    public int Shift { get; set; } // 1 = Day, 2 = Night
    public double HourlyPayRate { get; set; }

    public Subcontractor() { }

    public Subcontractor(string name, int number, DateTime startDate, int shift, double hourlyPayRate)
        : base(name, number, startDate)
    {
        Shift = shift;
        HourlyPayRate = hourlyPayRate;
    }

    // Juan
    public float CalculatePay(float hoursWorked)
    {
        double basePay = hoursWorked * HourlyPayRate;
        if (Shift == 2) // Night shift
        {
            basePay *= 1.03; // 3% shift differential
        }
        return (float)basePay;
    }
}

// Marc and Ashton
class Program
{
    static void Main()
    {
        List<Subcontractor> subcontractors = new List<Subcontractor>();
        string choice;

        do
        {
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

            Console.WriteLine($"\nPay for {name}: ${sc.CalculatePay(hours):F2}\n");

            Console.Write("Add another subcontractor? (y/n): ");
            choice = Console.ReadLine().ToLower();

        } while (choice == "y");

        Console.WriteLine("\nAll Subcontractors:");
        foreach (var sc in subcontractors)
        {
            Console.WriteLine($"Name: {sc.Name}, Shift: {sc.Shift}, Rate: {sc.HourlyPayRate:C}");
        }
    }
}