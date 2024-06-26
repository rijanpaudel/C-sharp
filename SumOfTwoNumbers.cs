using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        String firstNum = Console.ReadLine();
        int realFirstNum  = Convert.ToInt32(firstNum);
        Console.WriteLine("Enter the second number: ");
        String secondNum = Console.ReadLine();
        int realSecondNum = Convert.ToInt32(secondNum);
        int sum = realFirstNum + realSecondNum;
        Console.WriteLine($"The sum is {sum}");
        Console.ReadKey();

    }
}
