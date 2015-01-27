/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater 
than the second one. As a result print the values a and b, separated by a space.*/
using System;

class Exchange
{
    static void Main()
    {
        Console.Write("Please enter first number: ");
        double FirstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        double SecondNumber = double.Parse(Console.ReadLine());

        if (FirstNumber > SecondNumber)
        {
            Console.WriteLine("{0} , {1}", FirstNumber, SecondNumber);
        }
        else
        {
            Console.WriteLine("{0} , {1}", SecondNumber, FirstNumber);
        }
    }
}

