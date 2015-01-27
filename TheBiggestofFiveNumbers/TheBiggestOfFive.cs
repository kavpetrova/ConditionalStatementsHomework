/*Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
*/
using System;

class TheBiggestOfFive
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double FirstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double SecondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter thirt number: ");
        double ThirtNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        double FourthNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        double FifthNumber = double.Parse(Console.ReadLine());

        if (FirstNumber > SecondNumber && FirstNumber > ThirtNumber && FirstNumber > FourthNumber && FirstNumber > FifthNumber)
        {
            Console.WriteLine("The biggest number is {0}", FirstNumber);
        }
        else if (SecondNumber > ThirtNumber && SecondNumber > FourthNumber && SecondNumber > FifthNumber)
        {
            Console.WriteLine("The biggest number is {0}", SecondNumber);
        }
        else if (ThirtNumber > FourthNumber && ThirtNumber > FifthNumber)
        {
            Console.WriteLine("The biggest number is {0}", ThirtNumber);
        }
        else if (FourthNumber > FifthNumber)
        {
            Console.WriteLine("The biggest number is {0}", FourthNumber);
        }
        else
        {
            Console.WriteLine("The biggest number is {0}", FifthNumber);
        }
    }
}

