/*Problem 8. Digit as Word

Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
Print “not a digit” in case of invalid input.
Use a switch statement.*/
using System;

class DigitWord
{
    static void Main()
    {
        Console.Write("Please enter a digit from 0 to 9: ");
        int digit = int.Parse(Console.ReadLine());

        switch (digit)
        {
            case 0: digit = 0;Console.WriteLine("Zero"); break;
            case 1: digit = 1; Console.WriteLine("One"); break;
            case 2: digit = 2; Console.WriteLine("Two"); break;
            case 3: digit = 3; Console.WriteLine("Three"); break;
            case 4: digit = 4; Console.WriteLine("Four"); break;
            case 5: digit = 5; Console.WriteLine("Fifth"); break;
            case 6: digit = 6; Console.WriteLine("Six"); break;
            case 7: digit = 7; Console.WriteLine("Seven"); break;
            case 8: digit = 8; Console.WriteLine("Eight"); break;
            case 9: digit = 9; Console.WriteLine("Nine"); break;
            default:
                Console.WriteLine("Non a digit!");
                break;

        }
    }
}

