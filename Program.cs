using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.Write("Enter your phone number: ");
        var phoneNumber = Console.ReadLine();
        Console.Write("Enter your age: ");
        var age = Console.ReadLine(); ;
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Phone Numner: " + phoneNumber);
        Console.WriteLine("Age: " + age);
        Console.ReadLine();
    }
}
