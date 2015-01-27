/*Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.*/
using System;

class SortNumbers
{
    static void Main()
    {
        Console.Write("Write a number: ");
            double FirstNumber = Double.Parse(Console.ReadLine());
            Console.Write("Write a number: ");
            double SecondNumber = Double.Parse(Console.ReadLine());
            Console.Write("Write a number: ");
            double ThirtNumber = Double.Parse(Console.ReadLine());
            double first = 0;
            double second = 0;
            double third = 0;

            if (FirstNumber >= SecondNumber)
            {
                if (FirstNumber >= ThirtNumber)
                {
                    first = FirstNumber;

                    if (SecondNumber >= ThirtNumber)
                    {
                        second = SecondNumber;
                        third = ThirtNumber;
                    }
                    else
                    {
                        second = ThirtNumber;
                        third = SecondNumber;
                    }
                }
                else
                {
                    first = ThirtNumber;
                    second = FirstNumber;
                    third = SecondNumber;
                }                
            } 
   
            else
            {
                if (SecondNumber >= ThirtNumber)
                {
                    first = SecondNumber;

                    if (FirstNumber >= ThirtNumber)
                    {
                        second = FirstNumber;
                        third = ThirtNumber;
                    }
                    else
                    {
                        second = ThirtNumber;
                        third = FirstNumber;
                    }
                }
                else
                {
                    first = ThirtNumber;
                    second = SecondNumber;
                    third = FirstNumber;
                }            
            }

            Console.WriteLine(first + " " + second + " " + third);
        }
    }


