using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            if (2022 - YearOfBirth < 18)
            {
                Console.WriteLine("You are too young to drive!");
            } else if (2022 - YearOfBirth > 18)
            {
                Console.WriteLine("Drive carefully!");
            } else
            {
                Console.WriteLine("Congratulations! You may apply for your driving lisence now.");
            }
        }
    }
}
