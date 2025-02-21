using System;

class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = "Alex";
        this.age = 21;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {name} and I am {age} years old.");
    }
}