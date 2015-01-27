/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.*/
using System;

class TheBiggest
{
    static void Main()
    {
        Console.Write("Please enter first number: ");
        double FirstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        double SecondNumber = double.Parse(Console.ReadLine());
        Console.Write("Please enter thirt number: ");
        double ThirtNumber = double.Parse(Console.ReadLine());

        if (FirstNumber > SecondNumber && FirstNumber > ThirtNumber)
        {
            Console.WriteLine("The biggest number is {0}", FirstNumber);
        }
        else if (SecondNumber > FirstNumber && SecondNumber > ThirtNumber)
        {
            Console.WriteLine("The biggest number is {0}", SecondNumber);
        }
        else
        {
            Console.WriteLine("The biggest number is {0}", ThirtNumber);
        }
    }
}

