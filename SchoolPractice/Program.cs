using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student meghan = new Student("Meghan", 1, 1, 4.0);
            Console.WriteLine(meghan.Name + " can see that this worked.");
            Console.WriteLine($"{meghan.Name} is now using string interpolation just to see if it works and it does.");
        }
    }
}
