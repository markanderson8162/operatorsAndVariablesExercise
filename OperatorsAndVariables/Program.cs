using System;

namespace OperatorsAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Create a program that asks for a number
            Console.WriteLine("What is your number?");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your number is {number}");

            //TODO Take that number as an input and using a ternary operator respond with if that number is even or odd.
            var evenNumber = (number % 2 == 0) ? $"{number} is even!" : $"{number} is odd!";
            Console.WriteLine(evenNumber);
            //TODO Assign the value of the double below to an int variable called "priceRounded". google "w3schools C# type casting"

            //double price = 15.99;
            Console.WriteLine("Give me a decimal number and I will round it up!");
            double price = double.Parse(Console.ReadLine());
            int priceRounded = (int) price;

            if(price >= priceRounded + 0.01)
			{
                Console.WriteLine(priceRounded + 1);
            }
			else
			{
                Console.WriteLine(priceRounded);
			}
            



        }
    }
}
