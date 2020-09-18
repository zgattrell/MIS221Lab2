using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height in inches.");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of Steps.");
            int steps = int.Parse(Console.ReadLine());
            double strideLengthFt = (height * 0.413)/12;
            double milesWalked = (strideLengthFt * steps)/5280;
            Console.WriteLine("Total Miles Walked is " + milesWalked + " miles.");
        }

    }
}
