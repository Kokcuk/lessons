using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Я загадал число. Отгадай!");
            Random rnd = new Random();

            int value = rnd.Next(0, 100);

            while (true)
            {
                int userInput = int.Parse(Console.ReadLine());
                var result = CheckValue(userInput, value);
                if (result) break;
            }
        }

        
        
        static bool CheckValue(int userInput, int number)
        {
            if (userInput > number)
            {
                Console.WriteLine("Друг, оно меньше!");
            }

            if (userInput < number)
            {
                Console.WriteLine("Друг, оно больше!");
            }

            if (userInput == number)
            {
                Console.WriteLine("Ты угадал!");
                return true;
            }

            return false;
        }
    }
}
