/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/
using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
            Console.Write("1-->int\n2-->double\n3-->string\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Write("int: ");
                    int a = int.Parse(Console.ReadLine());
                    int sum = a + 1;
                    Console.WriteLine(sum); break;
                case "2": Console.Write("double: ");
                    double b = double.Parse(Console.ReadLine());
                    double sum2 = b + 1;
                    Console.WriteLine(sum2); break;
                case "3": Console.Write("string:");
                    string c = Console.ReadLine();
                    Console.WriteLine(c + "*"); break;
            }
    }
}

