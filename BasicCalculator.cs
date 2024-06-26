using System;
using System.Collections.Generic;
class BasicCalculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter the first number: ");
            String firstNum = Console.ReadLine();
            int realFirstNum = Convert.ToInt32(firstNum);
            Console.Write("Enter the second number: ");
            String secondNum = Console.ReadLine();
            int realSecondNum = Convert.ToInt32(secondNum);
            Console.Write("Which Operation you want to do? (+ or - or * or / or %) ");
            String operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    Console.WriteLine(realFirstNum + realSecondNum);
                    break;

                case "-":
                    Console.WriteLine(realFirstNum - realSecondNum);
                    break;

                case "*":
                    Console.WriteLine(realFirstNum * realSecondNum);
                    break;

                case "/":
                    Console.WriteLine(realFirstNum / realSecondNum);
                    break;

                case "%":
                    Console.WriteLine(realFirstNum % realSecondNum);
                    break;

                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }

            Console.WriteLine("Do you want to do again? (Y/N) ");
            String yesOrNo = Console.ReadLine().ToUpper();
            if (yesOrNo != "Y")
            {
                break;
            }
        }

            Console.ReadKey();

        }
    }
