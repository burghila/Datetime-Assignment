// Program.cs
using System;  // Import necessary namespace

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            Console.WriteLine("The current time is: " + DateTime.Now);

            // Ask the user for a number
            Console.WriteLine("\nEnter a number to see what the time will be in that many hours: ");
            float answer = float.Parse(Console.ReadLine());  // Parse the user input to a float

            // Print what time it will be in the amount of hours the user input
            Console.WriteLine($"In {answer} hour(s), it will be {DateTime.Now.AddHours(answer)}");
        }
    }
}
