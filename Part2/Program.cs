using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a temperature in degrees Fahrenheit: ");
            
            int fahrenheit = Int32.Parse(Console.ReadLine());
            double celsius = 5.0 * (fahrenheit - 32) / 9;

            Console.WriteLine(fahrenheit + " degrees Fahrenheit = " + Math.Round(celsius, 1) + " degrees Celsius");
        }
    }
}
