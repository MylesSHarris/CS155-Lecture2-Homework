using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "myles";
            string last = "harris";

            string firstPiglatin = first.Substring(1, 1).ToUpper() + first.Substring(2) + first.Substring(0, 1) + "ay";
            string lastPiglatin = last.Substring(1, 1).ToUpper() + last.Substring(2) + last.Substring(0, 1) + "ay";

            Console.WriteLine(firstPiglatin + " " + lastPiglatin);
        }
    }
}
