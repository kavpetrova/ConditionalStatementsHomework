/*Problem 3. Check for a Play Card

Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.*/
using System;

class CheckPlay
{
    static void Main()
    {
        Console.Write("Please enter some sign for cards: ");
        string card = Console.ReadLine();
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        if (Array.IndexOf(cards, card) >= 0)
        {
            Console.WriteLine("Valid card sign: {0}", card);
        }
        else
        {
            Console.WriteLine("Invalid sign!");
        }
    }
}

