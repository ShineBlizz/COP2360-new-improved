using System;
using Module2_Codes;

// Class definition
public class Bunny
    {
        public string Name { get; private set; } // "get: private set" means that the values can be read from outside the class
        public bool LikesCarrots { get; private set; } // It also means that it can only be modified inside the class and not from the outside
        public bool LikesHumans { get; private set; }


        private static Random random = new Random(); // Static to prevent reseeding issues
        private static string[] names = { "Timmy", "Jimmy", "Thimmy", "Shimmy", "Simmy", "Mashimmy", "Limmy", "Dimmy", "Rimmy", "Kimmy", "Zimmy", "Blimmy", "Chimmy", "Grimmy", "Whimmy"};

        public Bunny()
        {
            Name = names[random.Next(names.Length)]; // Picks a random name from the array
            LikesCarrots = random.Next(2) == 1; // 50/50 chance
            LikesHumans = random.Next(2) == 1; // 50/50 chance again
        }
    // This is our method to actually print out the Bunnys information
    public void PrintBunnyInfo()
    {
        Console.WriteLine($"Bunny Name: {Name}");
        Console.WriteLine($"Likes Carrots?: {LikesCarrots}");
        Console.WriteLine($"Likes Humans?: {LikesHumans}");
    }
    }

// This is our main program
class Program()
{
    static void Main()
    {
        Bunny myBunny = new Bunny(); // This will create a new bunny with random attributes
        myBunny.PrintBunnyInfo(); // This outputs its details
    }
}