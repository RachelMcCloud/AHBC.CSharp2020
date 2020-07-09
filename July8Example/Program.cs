using System;

namespace July8Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            var userInput = Console.ReadLine();
            Console.WriteLine("enter a number");
            var seconduserInput = Console.ReadLine();
            int userInputAsInt = int.Parse(userInput);
            userInputAsInt++;
            Console.WriteLine(userInputAsInt);
            

        }
    }
}
