using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number :");
        int num = Convert.ToInt32(Console.ReadLine());
        var even = num % 2;
        if(even == 0)
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
        Console.ReadLine();
    }
}
